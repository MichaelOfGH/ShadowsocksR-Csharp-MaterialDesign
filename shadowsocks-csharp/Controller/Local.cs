﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Shadowsocks.Encryption;
using Shadowsocks.Obfs;
using Shadowsocks.Model;
using System.Timers;
using System.Threading;
using OpenDNS;
using Shadowsocks.Util;

namespace Shadowsocks.Controller
{
    class CallbackStatus
    {
        protected int status;

        public CallbackStatus()
        {
            status = 0;
        }

        public void SetIfEqu(int newStatus, int oldStatus)
        {
            lock (this)
            {
                if (status == oldStatus)
                {
                    status = newStatus;
                }
            }
        }

        public int Status
        {
            get
            {
                lock (this)
                {
                    return status;
                }
            }
            set
            {
                lock (this)
                {
                    status = value;
                }
            }
        }
    }

    class Local : Listener.Service
    {
        private delegate void InvokeHandler();
        private Configuration _config;
        private ServerTransferTotal _transfer;
        private IPRangeSet _IPRange;

        public Local(Configuration config, ServerTransferTotal transfer, IPRangeSet IPRange)
        {
            _config = config;
            _transfer = transfer;
            _IPRange = IPRange;
        }

        protected bool Accept(byte[] firstPacket, int length)
        {
            if (length < 2)
            {
                return false;
            }
            if (firstPacket[0] == 5 || firstPacket[0] == 4)
            {
                return true;
            }
            if (length > 8
                && firstPacket[0] == 'C'
                && firstPacket[1] == 'O'
                && firstPacket[2] == 'N'
                && firstPacket[3] == 'N'
                && firstPacket[4] == 'E'
                && firstPacket[5] == 'C'
                && firstPacket[6] == 'T'
                && firstPacket[7] == ' ')
            {
                return true;
            }
            return false;
        }

        public bool Handle(byte[] firstPacket, int length, Socket socket)
        {
            if (!_config.GetPortMapCache().ContainsKey(((IPEndPoint)socket.LocalEndPoint).Port) && !Accept(firstPacket, length))
            {
                return false;
            }
            InvokeHandler handler = () => new ProxyAuthHandler(_config, _transfer, _IPRange, firstPacket, length, socket);
            handler.BeginInvoke(null, null);
            return true;
        }
    }

    class HandlerConfig
    {
        public string targetHost;
        public int targetPort;

        public Double TTL = 0; // Second
        public Double connect_timeout = 0;
        public int try_keep_alive = 0;
        public string dns_servers;
        public bool fouce_local_dns_query = false;
        // Server proxy
        public int proxyType = 0;
        public string socks5RemoteHost;
        public int socks5RemotePort = 0;
        public string socks5RemoteUsername;
        public string socks5RemotePassword;
        public string proxyUserAgent;
        // auto ban
        public bool autoSwitchOff = true;
        // Reconnect
        public int reconnectTimesRemain = 0;
        public int reconnectTimes = 0;
        public bool random = false;
        public bool forceRandom = false;
    }

    class Handler
        : IHandler
    {
        private delegate IPHostEntry GetHostEntryHandler(string ip);

        public delegate Server GetCurrentServer(int localPort, ServerSelectStrategy.FilterFunc filter, string targetURI = null, bool cfgRandom = false, bool usingRandom = false, bool forceRandom = false);
        public delegate void KeepCurrentServer(int localPort, string targetURI, string id);
        public GetCurrentServer getCurrentServer;
        public KeepCurrentServer keepCurrentServer;
        public Server server;
        public ServerSelectStrategy.FilterFunc select_server;
        public HandlerConfig cfg = new HandlerConfig();
        // Connection socket
        public ProxySocketTunLocal connection;
        public Socket connectionUDP;
        protected IPEndPoint connectionUDPEndPoint;
        protected int localPort;

        protected ProtocolResponseDetector detector = new ProtocolResponseDetector();
        // remote socket.
        //protected Socket remote;
        protected ProxyEncryptSocket remote;
        protected ProxyEncryptSocket remoteUDP;
        // Size of receive buffer.
        protected const int RecvSize = ProxyEncryptSocket.MSS * 4;
        protected const int BufferSize = ProxyEncryptSocket.MSS * 16;
        // remote header send buffer
        protected byte[] remoteHeaderSendBuffer;
        // connection send buffer
        protected List<byte[]> connectionSendBufferList = new List<byte[]>();

        protected DateTime lastKeepTime;
        private int _totalRecvSize = 0;

        protected byte[] remoteUDPRecvBuffer = new byte[BufferSize];
        protected int remoteUDPRecvBufferLength = 0;
        protected object recvUDPoverTCPLock = new object();

        protected bool closed = false;
        protected bool local_error = false;
        protected bool is_protocol_sendback = false;
        protected bool is_obfs_sendback = false;

        protected bool connectionTCPIdle, connectionUDPIdle, remoteTCPIdle, remoteUDPIdle;

        protected SpeedTester speedTester = new SpeedTester();
        protected int lastErrCode;
        protected Random random = new Random();
        protected System.Timers.Timer timer;
        protected object timerLock = new object();
        protected DateTime lastTimerSetTime;

        enum ConnectState
        {
            END = -1,
            READY = 0,
            HANDSHAKE = 1,
            CONNECTING = 2,
            CONNECTED = 3,
        }
        private ConnectState state = ConnectState.READY;

        private ConnectState State
        {
            get
            {
                return this.state;
            }
            set
            {
                lock (this)
                {
                    this.state = value;
                }
            }
        }

        private void ResetTimeout(double time, bool reset_keep_alive = true)
        {
            if (time <= 0 && timer == null)
                return;

            if (reset_keep_alive)
                cfg.try_keep_alive = 0;

            if (time <= 0)
            {
                if (timer != null)
                {
                    lock (timerLock)
                    {
                        if (timer != null)
                        {
                            timer.Enabled = false;
                            timer.Elapsed -= timer_Elapsed;
                            timer.Dispose();
                            timer = null;
                        }
                    }
                }
            }
            else
            {
                if (lastTimerSetTime != null && (DateTime.Now - lastTimerSetTime).TotalMilliseconds > 500)
                {
                    lock (timerLock)
                    {
                        if (timer == null)
                        {
                            timer = new System.Timers.Timer(time * 1000.0);
                            timer.Elapsed += timer_Elapsed;
                        }
                        else
                        {
                            timer.Interval = time * 1000.0;
                            timer.Stop();
                        }
                        timer.Start();
                        lastTimerSetTime = DateTime.Now;
                    }
                }
            }
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (closed)
            {
                return;
            }
            bool stop = false;

            try
            {
                if (cfg.try_keep_alive <= 0 && State == ConnectState.CONNECTED && remote != null && remoteUDP == null && remote.CanSendKeepAlive)
                {
                    cfg.try_keep_alive++;
                    RemoteSend(remoteUDPRecvBuffer, -1);
                }
                else
                {
                    if (connection != null)
                    {
                        Server s = server;
                        if (remote != null && cfg.reconnectTimesRemain > 0
                            //&& obfs != null && obfs.getSentLength() == 0
                            && connectionSendBufferList != null
                            && (State == ConnectState.CONNECTED || State == ConnectState.CONNECTING))
                        {
                            if (lastErrCode == 0)
                            {
                                if (State == ConnectState.CONNECTING && cfg.socks5RemotePort > 0)
                                {
                                }
                                else
                                {
                                    lastErrCode = 8;
                                    s.ServerSpeedLog().AddTimeoutTimes();
                                }
                            }
                            //remote.Shutdown(SocketShutdown.Both);
                            stop = true;
                        }
                        else
                        {
                            if (s != null
                                && connectionSendBufferList != null
                                )
                            {
                                if (lastErrCode == 0)
                                {
                                    lastErrCode = 8;
                                    s.ServerSpeedLog().AddTimeoutTimes();
                                }
                            }
                            //connection.Shutdown(SocketShutdown.Both);
                            stop = true;
                            local_error = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                //
            }
            if (stop)
            {
                //Thread.Sleep(200);
                Close();
            }
        }

        public void setServerTransferTotal(ServerTransferTotal transfer)
        {
            speedTester.transfer = transfer;
        }

        public int LogSocketException(Exception e)
        {
            // just log useful exceptions, not all of them
            Server s = server;
            if (e is ObfsException)
            {
                ObfsException oe = (ObfsException)e;
                if (lastErrCode == 0)
                {
                    if (s != null)
                    {
                        lastErrCode = 16;
                        s.ServerSpeedLog().AddErrorDecodeTimes();
                    }
                }
                return 16; // ObfsException(decrypt error)
            }
            else if (e is ProtocolException)
            {
                ProtocolException pe = (ProtocolException)e;
                if (lastErrCode == 0)
                {
                    if (s != null)
                    {
                        lastErrCode = 16;
                        s.ServerSpeedLog().AddErrorDecodeTimes();
                    }
                }
                return 16; // ObfsException(decrypt error)
            }
            else if (e is SocketException)
            {
                SocketException se = (SocketException)e;
                if (se.SocketErrorCode == SocketError.ConnectionAborted
                    || se.SocketErrorCode == SocketError.ConnectionReset
                    || se.SocketErrorCode == SocketError.NotConnected
                    || se.SocketErrorCode == SocketError.Interrupted
                    || se.SocketErrorCode == SocketError.Shutdown
                    )
                {
                    // closed by browser when sending
                    // normally happens when download is canceled or a tab is closed before page is loaded
                }
                else if (se.ErrorCode == 11004)
                {
                    if (lastErrCode == 0)
                    {
                        if (s != null)
                        {
                            lastErrCode = 1;
                            s.ServerSpeedLog().AddErrorTimes();
                        }
                    }
                    return 1; // proxy DNS error
                }
                else if (se.SocketErrorCode == SocketError.HostNotFound)
                {
                    if (lastErrCode == 0)
                    {
                        if (s != null)
                        {
                            lastErrCode = 2;
                            s.ServerSpeedLog().AddErrorTimes();
                            if (s.ServerSpeedLog().ErrorConnectTimes >= 3 && cfg.autoSwitchOff)
                            {
                                s.setEnable(false);
                            }
                        }
                    }
                    return 2; // ip not exist
                }
                else if (se.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    if (lastErrCode == 0)
                    {
                        if (s != null)
                        {
                            lastErrCode = 1;
                            if (cfg != null && cfg.socks5RemotePort == 0)
                                s.ServerSpeedLog().AddErrorTimes();
                        }
                    }
                    return 2; // proxy ip/port error
                }
                else if (se.SocketErrorCode == SocketError.NetworkUnreachable)
                {
                    if (lastErrCode == 0)
                    {
                        if (s != null)
                        {
                            lastErrCode = 3;
                            //s.ServerSpeedLog().AddErrorTimes();
                        }
                    }
                    return 3; // proxy ip/port error
                }
                else if (se.SocketErrorCode == SocketError.TimedOut)
                {
                    if (lastErrCode == 0)
                    {
                        if (s != null)
                        {
                            lastErrCode = 8;
                            s.ServerSpeedLog().AddTimeoutTimes();
                        }
                    }
                    return 8; // proxy server no response too slow
                }
                else
                {
                    if (lastErrCode == 0)
                    {
                        lastErrCode = -1;
                        if (s != null)
                            s.ServerSpeedLog().AddNoErrorTimes(); //?
                    }
                    return -1;
                }
            }
            return 0;
        }

        public bool ReConnect()
        {
            Logging.Debug("Reconnect " + cfg.targetHost + ":" + cfg.targetPort.ToString() + " " + connection.GetSocket().Handle.ToString());
            {
                Handler handler = new Handler();
                handler.getCurrentServer = getCurrentServer;
                handler.keepCurrentServer = keepCurrentServer;
                handler.select_server = select_server;
                handler.connection = connection;
                handler.connectionUDP = connectionUDP;
                handler.cfg = cfg;
                handler.cfg.reconnectTimesRemain = cfg.reconnectTimesRemain - 1;
                handler.cfg.reconnectTimes = cfg.reconnectTimes + 1;

                handler.speedTester.transfer = speedTester.transfer;

                int total_len = 0;
                byte[] newFirstPacket = remoteHeaderSendBuffer;
                if (connectionSendBufferList != null && connectionSendBufferList.Count > 0)
                {
                    foreach (byte[] data in connectionSendBufferList)
                    {
                        total_len += data.Length;
                    }
                    newFirstPacket = new byte[total_len];
                    total_len = 0;
                    foreach (byte[] data in connectionSendBufferList)
                    {
                        Buffer.BlockCopy(data, 0, newFirstPacket, total_len, data.Length);
                        total_len += data.Length;
                    }
                }
                handler.Start(newFirstPacket, newFirstPacket.Length, connection.local_sendback_protocol);
            }
            return true;
        }

        public void Start(byte[] firstPacket, int length, string rsp_protocol)
        {
            connection.local_sendback_protocol = rsp_protocol;
            if (cfg.socks5RemotePort > 0)
            {
                cfg.autoSwitchOff = false;
            }
            ResetTimeout(cfg.TTL);
            if (this.State == ConnectState.READY)
            {
                State = ConnectState.HANDSHAKE;
                remoteHeaderSendBuffer = firstPacket;

                detector.OnSend(remoteHeaderSendBuffer, length);
                byte[] data = new byte[length];
                Array.Copy(remoteHeaderSendBuffer, data, data.Length);
                connectionSendBufferList.Add(data);
                remoteHeaderSendBuffer = data;

                Connect();
            }
            else
            {
                Close();
            }
        }

        private void BeginConnect(IPAddress ipAddress, int serverPort)
        {
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, serverPort);

            if (cfg.socks5RemotePort != 0
                || connectionUDP == null
                || connectionUDP != null && server.udp_over_tcp)
            {
                remote = new ProxyEncryptSocket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                remote.GetSocket().NoDelay = true;
                try
                {
                    remote.CreateEncryptor(server.method, server.password);
                }
                catch
                {

                }
                remote.SetProtocol(ObfsFactory.GetObfs(server.protocol));
                remote.SetObfs(ObfsFactory.GetObfs(server.obfs));
            }

            if (connectionUDP != null && !server.udp_over_tcp)
            {
                try
                {
                    remoteUDP = new ProxyEncryptSocket(ipAddress.AddressFamily,
                        SocketType.Dgram, ProtocolType.Udp);
                    remoteUDP.GetSocket().Bind(new IPEndPoint(ipAddress.AddressFamily == AddressFamily.InterNetworkV6 ? IPAddress.IPv6Any : IPAddress.Any, 0));

                    remoteUDP.CreateEncryptor(server.method, server.password);
                    remoteUDP.SetProtocol(ObfsFactory.GetObfs(server.protocol));
                    remoteUDP.SetObfs(ObfsFactory.GetObfs(server.obfs));
                    if (server.server_udp_port == 0 || cfg.socks5RemotePort != 0)
                    {
                        IPEndPoint _remoteEP = new IPEndPoint(ipAddress, serverPort);
                        remoteUDP.SetUdpEndPoint(_remoteEP);
                    }
                    else
                    {
                        IPEndPoint _remoteEP = new IPEndPoint(ipAddress, server.server_udp_port);
                        remoteUDP.SetUdpEndPoint(_remoteEP);
                    }
                }
                catch (SocketException)
                {
                    remoteUDP = null;
                }
            }
            ResetTimeout(cfg.TTL);

            // Connect to the remote endpoint.
            if (cfg.socks5RemotePort == 0 && connectionUDP != null && !server.udp_over_tcp)
            {
                ConnectState _state = this.State;
                if (_state == ConnectState.CONNECTING)
                {
                    StartPipe();
                }
            }
            else
            {
                speedTester.BeginConnect();
                IAsyncResult result = remote.BeginConnect(remoteEP,
                    new AsyncCallback(ConnectCallback), new CallbackStatus());
                double t = cfg.connect_timeout <= 0 ? 30 : cfg.connect_timeout;
                bool success = result.AsyncWaitHandle.WaitOne((int)(t * 1000), true);
                if (!success)
                {
                    ((CallbackStatus)result.AsyncState).SetIfEqu(-1, 0);
                    if (((CallbackStatus)result.AsyncState).Status == -1)
                    {
                        if (lastErrCode == 0)
                        {
                            lastErrCode = 8;
                            server.ServerSpeedLog().AddTimeoutTimes();
                        }
                        CloseSocket(ref remote);
                        Close();
                    }
                }
            }
        }

        public bool TryReconnect()
        {
            if (local_error)
                return false;
            if (cfg.reconnectTimesRemain > 0)
            {
                if (this.State == ConnectState.CONNECTING)
                {
                    return ReConnect();
                }
                else if (this.State == ConnectState.CONNECTED && lastErrCode == 8)
                {
                    if (connectionSendBufferList != null)
                    {
                        return ReConnect();
                    }
                }
            }
            return false;
        }

        private void CloseSocket(ref Socket sock)
        {
            lock (this)
            {
                if (sock != null)
                {
                    Socket s = sock;
                    sock = null;
                    try
                    {
                        s.Shutdown(SocketShutdown.Both);
                    }
                    catch { }
                    try
                    {
                        s.Close();
                    }
                    catch { }
                }
            }
        }

        private void CloseSocket(ref ProxySocketTunLocal sock)
        {
            lock (this)
            {
                if (sock != null)
                {
                    ProxySocketTunLocal s = sock;
                    sock = null;
                    try
                    {
                        s.Shutdown(SocketShutdown.Both);
                    }
                    catch { }
                    try
                    {
                        s.Close();
                    }
                    catch { }
                }
            }
        }

        private void CloseSocket(ref ProxyEncryptSocket sock)
        {
            lock (this)
            {
                if (sock != null)
                {
                    ProxyEncryptSocket s = sock;
                    sock = null;
                    try
                    {
                        s.Shutdown(SocketShutdown.Both);
                    }
                    catch { }
                    try
                    {
                        s.Close();
                    }
                    catch { }
                }
            }
        }

        public override void Shutdown()
        {
            InvokeHandler handler = () => Close();
            handler.BeginInvoke(null, null);
        }

        public void Close()
        {
            lock (this)
            {
                if (closed)
                {
                    return;
                }
                closed = true;
            }
            Thread.Sleep(200);
            CloseSocket(ref remote);
            CloseSocket(ref remoteUDP);
            if (connection != null && cfg != null)
            {
                Logging.Debug("Close   " + cfg.targetHost + ":" + cfg.targetPort.ToString() + " " + connection.GetSocket().Handle.ToString());
            }
            if (lastErrCode == 0 && server != null && speedTester != null)
            {
                if (!local_error && speedTester.sizeProtocolRecv == 0 && speedTester.sizeUpload > 0)
                {
                    if (is_protocol_sendback
                        || (is_obfs_sendback && speedTester.sizeDownload == 0))
                    {
                        lastErrCode = 16;
                        server.ServerSpeedLog().AddErrorDecodeTimes();
                    }
                    else
                        server.ServerSpeedLog().AddErrorEmptyTimes();
                }
                else
                    server.ServerSpeedLog().AddNoErrorTimes();
            }

            if (lastErrCode == 0 && server != null && cfg != null && keepCurrentServer != null)
                keepCurrentServer(localPort, cfg.targetHost, server.id);

            ResetTimeout(0);
            try
            {
                bool reconnect = TryReconnect();
                //lock (this)
                {
                    if (this.State != ConnectState.END)
                    {
                        if (this.State != ConnectState.READY && this.State != ConnectState.HANDSHAKE && server != null)
                        {
                            if (server.GetConnections().DecRef(this))
                            {
                                server.ServerSpeedLog().AddDisconnectTimes();
                            }
                        }
                        this.State = ConnectState.END;
                    }
                    getCurrentServer = null;
                    keepCurrentServer = null;
                }

                if (!reconnect)
                {
                    Logging.Info($"Disconnect {cfg.targetHost}:{cfg.targetPort.ToString()}");
                    CloseSocket(ref connection);
                    CloseSocket(ref connectionUDP);
                    Logging.Debug($"Transfer {cfg.targetHost}:{cfg.targetPort.ToString() + speedTester.TransferLog()}");
                }
                else
                {
                    connection = null;
                    connectionUDP = null;
                }

                detector = null;
                speedTester = null;
                random = null;
                remoteUDPRecvBuffer = null;

                server = null;
                select_server = null;
            }
            catch (Exception e)
            {
                Logging.LogUsefulException(e);
            }
        }

        private bool ConnectProxyServer(string strRemoteHost, int iRemotePort)
        {
            if (cfg.proxyType == 0)
            {
                bool ret = remote.ConnectSocks5ProxyServer(strRemoteHost, iRemotePort, connectionUDP != null && !server.udp_over_tcp, cfg.socks5RemoteUsername, cfg.socks5RemotePassword);
                remote.SetTcpServer(server.server, server.server_port);
                remote.SetUdpServer(server.server, server.server_udp_port == 0 ? server.server_port : server.server_udp_port);
                if (remoteUDP != null)
                {
                    remoteUDP.GoS5Proxy = true;
                    remoteUDP.SetUdpServer(server.server, server.server_udp_port == 0 ? server.server_port : server.server_udp_port);
                    remoteUDP.SetUdpEndPoint(remote.GetProxyUdpEndPoint());
                }
                return ret;
            }
            else if (cfg.proxyType == 1)
            {
                bool ret = remote.ConnectHttpProxyServer(strRemoteHost, iRemotePort, cfg.socks5RemoteUsername, cfg.socks5RemotePassword, cfg.proxyUserAgent);
                remote.SetTcpServer(server.server, server.server_port);
                return ret;
            }
            else
            {
                return true;
            }
        }

        private void Connect()
        {
            remote = null;
            remoteUDP = null;
            localPort = ((IPEndPoint)connection.GetSocket().LocalEndPoint).Port;
            if (select_server == null)
            {
                if (cfg.targetHost == null)
                {
                    cfg.targetHost = GetQueryString();
                    cfg.targetPort = GetQueryPort();
                    server = this.getCurrentServer(localPort, null, cfg.targetHost, cfg.random, true);
                }
                else
                {
                    server = this.getCurrentServer(localPort, null, cfg.targetHost, cfg.random, true, cfg.forceRandom);
                }
            }
            else
            {
                if (cfg.targetHost == null)
                {
                    cfg.targetHost = GetQueryString();
                    cfg.targetPort = GetQueryPort();
                    server = this.getCurrentServer(localPort, select_server, cfg.targetHost, true, true);
                }
                else
                {
                    server = this.getCurrentServer(localPort, select_server, cfg.targetHost, true, true, cfg.forceRandom);
                }
            }
            speedTester.server = server.server;
            Logging.Info($"Connect {cfg.targetHost}:{cfg.targetPort.ToString()}");

            ResetTimeout(cfg.TTL);
            if (cfg.fouce_local_dns_query && cfg.targetHost != null)
            {
                IPAddress ipAddress;

                string host = cfg.targetHost;

                if (!IPAddress.TryParse(host, out ipAddress))
                {
                    ipAddress = Utils.DnsBuffer.Get(host);
                    if (ipAddress == null)
                    {
                        if (host.IndexOf('.') >= 0)
                        {
                            ipAddress = Utils.QueryDns(host, cfg.dns_servers);
                        }
                        else
                        {
                            ipAddress = Utils.QueryDns(host, null);
                        }
                    }
                    if (ipAddress != null)
                    {
                        Utils.DnsBuffer.Set(host, new IPAddress(ipAddress.GetAddressBytes()));
                        Utils.DnsBuffer.Sweep();
                    }
                }
                if (ipAddress != null)
                {
                    cfg.targetHost = ipAddress.ToString();
                    ResetTimeout(cfg.TTL);
                }
                else
                {
                    //throw new SocketException((int)SocketError.HostNotFound);
                    Close();
                    return;
                }
            }

            lock (this)
            {
                server.ServerSpeedLog().AddConnectTimes();
                if (this.State == ConnectState.HANDSHAKE)
                {
                    this.State = ConnectState.CONNECTING;
                }
                server.GetConnections().AddRef(this);
            }
            try
            {
                IPAddress ipAddress;
                string serverHost = server.server;
                int serverPort = server.server_port;
                if (cfg.socks5RemotePort > 0)
                {
                    serverHost = cfg.socks5RemoteHost;
                    serverPort = cfg.socks5RemotePort;
                }
                bool parsed = IPAddress.TryParse(serverHost, out ipAddress);
                if (!parsed)
                {
                    if (server.DnsBuffer().isExpired(serverHost))
                    {
                        bool dns_ok = false;
                        {
                            DnsBuffer buf = server.DnsBuffer();
                            lock (buf)
                            {
                                if (buf.isExpired(serverHost))
                                {
                                    if (serverHost.IndexOf('.') >= 0)
                                    {
                                        ipAddress = Util.Utils.QueryDns(serverHost, cfg.dns_servers);
                                    }
                                    else
                                    {
                                        ipAddress = Utils.QueryDns(serverHost, null);
                                    }
                                    if (ipAddress != null)
                                    {
                                        buf.UpdateDns(serverHost, ipAddress);
                                        dns_ok = true;
                                    }
                                }
                                else
                                {
                                    ipAddress = buf.ip;
                                    dns_ok = true;
                                }
                            }
                        }
                        if (!dns_ok)
                        {
                            if (server.DnsBuffer().ip != null)
                            {
                                ipAddress = server.DnsBuffer().ip;
                            }
                            else
                            {
                                lastErrCode = 8;
                                server.ServerSpeedLog().AddTimeoutTimes();
                                Close();
                                return;
                            }
                        }
                    }
                    else
                    {
                        ipAddress = server.DnsBuffer().ip;
                    }
                }
                BeginConnect(ipAddress, serverPort);
            }
            catch (Exception e)
            {
                LogException(e);
                Close();
            }
        }


        private void ConnectCallback(IAsyncResult ar)
        {
            if (ar != null && ar.AsyncState != null)
            {
                ((CallbackStatus)ar.AsyncState).SetIfEqu(1, 0);
                if (((CallbackStatus)ar.AsyncState).Status != 1)
                    return;
            }
            try
            {
                remote.EndConnect(ar);
                if (cfg.socks5RemotePort > 0)
                {
                    if (!ConnectProxyServer(server.server, server.server_port))
                    {
                        throw new SocketException((int)SocketError.ConnectionReset);
                    }
                }
                speedTester.EndConnect();

                ConnectState _state = this.State;
                if (_state == ConnectState.CONNECTING)
                {
                    StartPipe();
                }
            }
            catch (Exception e)
            {
                LogExceptionAndClose(e);
            }
        }

        // do/end xxx tcp/udp Recv
        private void doConnectionTCPRecv()
        {
            if (connection != null && connectionTCPIdle)
            {
                connectionTCPIdle = false;
                byte[] buffer = new byte[BufferSize];
                int recv_size = remote == null ? RecvSize : remote.TcpMSS - remote.OverHead;
                connection.BeginReceive(buffer, recv_size, 0,
                    new AsyncCallback(PipeConnectionReceiveCallback), null);
            }
        }

        private int endConnectionTCPRecv(IAsyncResult ar)
        {
            if (connection != null)
            {
                int bytesRead = connection.EndReceive(ar);
                connectionTCPIdle = true;
                return bytesRead;
            }
            return 0;
        }

        private void doConnectionUDPRecv()
        {
            if (connectionUDP != null && connectionUDPIdle)
            {
                connectionUDPIdle = false;
                const int BufferSize = 65536;
                IPEndPoint sender = new IPEndPoint(connectionUDP.AddressFamily == AddressFamily.InterNetworkV6 ? IPAddress.IPv6Any : IPAddress.Any, 0);
                EndPoint tempEP = (EndPoint)sender;
                byte[] buffer = new byte[BufferSize];
                connectionUDP.BeginReceiveFrom(buffer, 0, BufferSize, SocketFlags.None, ref tempEP,
                    new AsyncCallback(PipeConnectionUDPReceiveCallback), buffer);
            }
        }

        private int endConnectionUDPRecv(IAsyncResult ar, ref EndPoint endPoint)
        {
            if (connectionUDP != null)
            {
                int bytesRead = connectionUDP.EndReceiveFrom(ar, ref endPoint);
                if (connectionUDPEndPoint == null)
                    connectionUDPEndPoint = (IPEndPoint)endPoint;
                connectionUDPIdle = true;
                return bytesRead;
            }
            return 0;
        }

        private void doRemoteTCPRecv()
        {
            if (remote != null && remoteTCPIdle)
            {
                remoteTCPIdle = false;
                remote.BeginReceive(new byte[BufferSize], RecvSize, 0,
                    new AsyncCallback(PipeRemoteReceiveCallback), null);
            }
        }

        private int endRemoteTCPRecv(IAsyncResult ar)
        {
            if (remote != null)
            {
                bool sendback;
                int bytesRead = remote.EndReceive(ar, out sendback);

                int bytesRecv = remote.GetAsyncResultSize(ar);
                server.ServerSpeedLog().AddDownloadBytes(bytesRecv, DateTime.Now, speedTester.AddDownloadSize(bytesRecv));

                if (sendback)
                {
                    RemoteSend(remoteUDPRecvBuffer, 0);
                    doConnectionRecv();
                }
                remoteTCPIdle = true;
                return bytesRead;
            }
            return 0;
        }

        private void doRemoteUDPRecv()
        {
            if (remoteUDP != null && remoteUDPIdle)
            {
                remoteUDPIdle = false;
                const int BufferSize = 65536;
                IPEndPoint sender = new IPEndPoint(remoteUDP.AddressFamily == AddressFamily.InterNetworkV6 ? IPAddress.IPv6Any : IPAddress.Any, 0);
                EndPoint tempEP = (EndPoint)sender;
                remoteUDP.BeginReceiveFrom(new byte[BufferSize], BufferSize, SocketFlags.None, ref tempEP,
                    new AsyncCallback(PipeRemoteUDPReceiveCallback), null);
            }
        }

        private int endRemoteUDPRecv(IAsyncResult ar, ref EndPoint endPoint)
        {
            if (remoteUDP != null)
            {
                int bytesRead = remoteUDP.EndReceiveFrom(ar, ref endPoint);
                remoteUDPIdle = true;
                return bytesRead;
            }
            return 0;
        }

        private void doConnectionRecv()
        {
            doConnectionTCPRecv();
            doConnectionUDPRecv();
        }

        private void SetObfsPlugin()
        {
            int head_len = 30;
            if (connectionSendBufferList != null && connectionSendBufferList.Count > 0)
            {
                head_len = ObfsBase.GetHeadSize(connectionSendBufferList[0], 30);
            }
            else
            {
                head_len = ObfsBase.GetHeadSize(remoteHeaderSendBuffer, 30);
            }
            if (remote != null) remote.SetObfsPlugin(server, head_len);
            if (remoteUDP != null) remoteUDP.SetObfsPlugin(server, head_len);
        }

        private string GetQueryString()
        {
            if (remoteHeaderSendBuffer == null)
                return null;

            if (remoteHeaderSendBuffer[0] == 1)
            {
                if (remoteHeaderSendBuffer.Length > 4)
                {
                    byte[] addr = new byte[4];
                    Array.Copy(remoteHeaderSendBuffer, 1, addr, 0, 4);
                    IPAddress ipAddress = new IPAddress(addr);
                    return ipAddress.ToString();
                }
                return null;
            }
            if (remoteHeaderSendBuffer[0] == 4)
            {
                if (remoteHeaderSendBuffer.Length > 16)
                {
                    byte[] addr = new byte[16];
                    Array.Copy(remoteHeaderSendBuffer, 1, addr, 0, 16);
                    IPAddress ipAddress = new IPAddress(addr);
                    return ipAddress.ToString();
                }
                return null;
            }
            if (remoteHeaderSendBuffer[0] == 3 && remoteHeaderSendBuffer.Length > 1)
            {
                if (remoteHeaderSendBuffer.Length > remoteHeaderSendBuffer[1] + 1)
                {
                    string url = System.Text.Encoding.UTF8.GetString(remoteHeaderSendBuffer, 2, remoteHeaderSendBuffer[1]);
                    return url;
                }
            }
            return null;
        }

        private int GetQueryPort()
        {
            if (remoteHeaderSendBuffer == null)
                return 0;

            if (remoteHeaderSendBuffer[0] == 1)
            {
                if (remoteHeaderSendBuffer.Length > 6)
                {
                    int port = (remoteHeaderSendBuffer[5] << 8) | remoteHeaderSendBuffer[6];
                    return port;
                }
                return 0;
            }
            if (remoteHeaderSendBuffer[0] == 4)
            {
                if (remoteHeaderSendBuffer.Length > 18)
                {
                    int port = (remoteHeaderSendBuffer[17] << 8) | remoteHeaderSendBuffer[18];
                    return port;
                }
                return 0;
            }
            if (remoteHeaderSendBuffer[0] == 3 && remoteHeaderSendBuffer.Length > 1)
            {
                if (remoteHeaderSendBuffer.Length > remoteHeaderSendBuffer[1] + 2)
                {
                    int port = (remoteHeaderSendBuffer[remoteHeaderSendBuffer[1] + 2] << 8) | remoteHeaderSendBuffer[remoteHeaderSendBuffer[1] + 3];
                    return port;
                }
            }
            return 0;
        }

        // 2 sides connection start
        private void StartPipe()
        {
            try
            {
                // set mark
                connectionTCPIdle = true;
                connectionUDPIdle = true;
                remoteTCPIdle = true;
                remoteUDPIdle = true;
                closed = false;

                remoteUDPRecvBufferLength = 0;
                SetObfsPlugin();

                ResetTimeout(cfg.connect_timeout);

                speedTester.BeginUpload();

                // remote ready
                if (connectionUDP == null) // TCP
                {
                    if (cfg.reconnectTimes > 0 || cfg.targetPort != 0)
                    {
                        RemoteSend(remoteHeaderSendBuffer, remoteHeaderSendBuffer.Length);
                        remoteHeaderSendBuffer = null;
                    }

                    is_protocol_sendback = remote.isProtocolSendback;
                    is_obfs_sendback = remote.isObfsSendback;
                }
                else // UDP
                {
                    if (!server.udp_over_tcp &&
                        remoteUDP != null)
                    {
                        if (cfg.socks5RemotePort == 0)
                            CloseSocket(ref remote);
                        remoteHeaderSendBuffer = null;
                    }
                    else if (remoteHeaderSendBuffer != null)
                    {
                        RemoteSend(remoteHeaderSendBuffer, remoteHeaderSendBuffer.Length);
                        remoteHeaderSendBuffer = null;
                    }
                }
                this.State = ConnectState.CONNECTED;

                if (connection.local_sendback_protocol != null)
                {
                    connection.Send(remoteUDPRecvBuffer, 0, 0);
                }

                // remote recv first
                doRemoteTCPRecv();
                doRemoteUDPRecv();

                doConnectionTCPRecv();
                doConnectionUDPRecv();
            }
            catch (Exception e)
            {
                LogExceptionAndClose(e);
            }
        }

        private void ConnectionSend(byte[] buffer, int bytesToSend)
        {
            if (connectionUDP == null)
            {
                connection.Send(buffer, bytesToSend, SocketFlags.None);
                doRemoteUDPRecv();
            }
            else
            {
                connectionUDP.BeginSendTo(buffer, 0, bytesToSend, SocketFlags.None, connectionUDPEndPoint, new AsyncCallback(PipeConnectionUDPSendCallback), null);
            }
        }

        private void UDPoverTCPConnectionSend(byte[] send_buffer, int bytesToSend)
        {
            List<byte[]> buffer_list = new List<byte[]>();
            lock (recvUDPoverTCPLock)
            {
                Util.Utils.SetArrayMinSize(ref remoteUDPRecvBuffer, bytesToSend + remoteUDPRecvBufferLength);
                Array.Copy(send_buffer, 0, remoteUDPRecvBuffer, remoteUDPRecvBufferLength, bytesToSend);
                remoteUDPRecvBufferLength += bytesToSend;
                while (remoteUDPRecvBufferLength > 6)
                {
                    int len = (remoteUDPRecvBuffer[0] << 8) + remoteUDPRecvBuffer[1];
                    if (len > remoteUDPRecvBufferLength)
                        break;

                    byte[] buffer = new byte[len];
                    Array.Copy(remoteUDPRecvBuffer, buffer, len);
                    remoteUDPRecvBufferLength -= len;
                    Array.Copy(remoteUDPRecvBuffer, len, remoteUDPRecvBuffer, 0, remoteUDPRecvBufferLength);

                    buffer[0] = 0;
                    buffer[1] = 0;
                    buffer_list.Add(buffer);
                }
            }
            if (buffer_list.Count == 0)
            {
                doRemoteTCPRecv();
            }
            else
            {
                foreach (byte[] buffer in buffer_list)
                {
                    if (buffer == buffer_list[buffer_list.Count - 1])
                        connectionUDP.BeginSendTo(buffer, 0, buffer.Length, SocketFlags.None, connectionUDPEndPoint, new AsyncCallback(PipeConnectionUDPSendCallback), null);
                    else
                        connectionUDP.BeginSendTo(buffer, 0, buffer.Length, SocketFlags.None, connectionUDPEndPoint, new AsyncCallback(PipeConnectionUDPSendCallbackNoRecv), null);
                }
            }
        }

        private void PipeRemoteReceiveCallback(IAsyncResult ar)
        {
            bool final_close = false;
            try
            {
                if (closed)
                {
                    return;
                }
                int bytesRead = endRemoteTCPRecv(ar);

                if (remote.IsClose)
                {
                    final_close = true;
                }
                else
                {
                    int bytesRecv = remote.GetAsyncResultSize(ar);
                    if (speedTester.BeginDownload())
                    {
                        int pingTime = -1;
                        if (speedTester.timeBeginDownload != null && speedTester.timeBeginUpload != null)
                            pingTime = (int)(speedTester.timeBeginDownload - speedTester.timeBeginUpload).TotalMilliseconds;
                        if (pingTime >= 0)
                            server.ServerSpeedLog().AddConnectTime(pingTime);
                    }
                    ResetTimeout(cfg.TTL);

                    speedTester.AddProtocolRecvSize(remote.GetAsyncProtocolSize(ar));
                    if (bytesRead > 0)
                    {
                        byte[] remoteSendBuffer = new byte[BufferSize];

                        Array.Copy(remote.GetAsyncResultBuffer(ar), remoteSendBuffer, bytesRead);
                        if (connectionUDP == null)
                        {
                            if (detector.OnRecv(remoteSendBuffer, bytesRead) > 0)
                            {
                                server.ServerSpeedLog().AddErrorTimes();
                            }
                            if (detector.Pass)
                            {
                                server.ServerSpeedLog().ResetErrorDecodeTimes();
                            }
                            else
                            {
                                server.ServerSpeedLog().ResetEmptyTimes();
                            }
                            connection.Send(remoteSendBuffer, bytesRead, 0);
                        }
                        else
                        {
                            UDPoverTCPConnectionSend(remoteSendBuffer, bytesRead);
                        }
                        server.ServerSpeedLog().AddDownloadRawBytes(bytesRead);
                        speedTester.AddRecvSize(bytesRead);
                        _totalRecvSize += bytesRead;
                    }
                    if (connectionUDP == null && _totalRecvSize > 1024 * 1024 * 2)
                    {
                        PipeRemoteReceiveLoop();
                    }
                    else
                    {
                        doRemoteTCPRecv();
                    }
                }
            }
            catch (Exception e)
            {
                LogException(e);
                final_close = true;
            }
            finally
            {
                if (final_close)
                {
                    Close();
                }
            }
        }

        private void PipeRemoteReceiveLoop()
        {
            bool final_close = false;
            byte[] recv_buffer = new byte[BufferSize * 4];

            DateTime beforeReceive = DateTime.Now;
            while (!closed)
            {
                try
                {
                    int protocolSize;
                    bool sendback;
                    int bytesRecv;
                    int bytesRead = remote.Receive(recv_buffer, RecvSize, 0, out bytesRecv, out protocolSize, out sendback);
                    DateTime now = DateTime.Now;
                    if (remote != null && remote.IsClose)
                    {
                        final_close = true;
                        break;
                    }
                    if (closed)
                    {
                        break;
                    }
                    if (speedTester.BeginDownload())
                    {
                        int pingTime = -1;
                        if (speedTester.timeBeginDownload != null && speedTester.timeBeginUpload != null)
                            pingTime = (int)(speedTester.timeBeginDownload - speedTester.timeBeginUpload).TotalMilliseconds;
                        if (pingTime >= 0)
                            server.ServerSpeedLog().AddConnectTime(pingTime);
                    }
                    server.ServerSpeedLog().AddDownloadBytes(bytesRecv, now, speedTester.AddDownloadSize(bytesRecv));
                    ResetTimeout(cfg.TTL);
                    if (sendback)
                    {
                        RemoteSend(remoteUDPRecvBuffer, 0);
                        doConnectionRecv();
                    }

                    if (bytesRead > 0)
                    {
                        byte[] remoteSendBuffer = new byte[BufferSize];

                        Array.Copy(recv_buffer, remoteSendBuffer, bytesRead);
                        if (connectionUDP == null)
                        {
                            if (detector.OnRecv(remoteSendBuffer, bytesRead) > 0)
                            {
                                server.ServerSpeedLog().AddErrorTimes();
                            }
                            if (detector.Pass)
                            {
                                server.ServerSpeedLog().ResetErrorDecodeTimes();
                            }
                            else
                            {
                                server.ServerSpeedLog().ResetEmptyTimes();
                            }
                            connection.Send(remoteSendBuffer, bytesRead, 0);
                        }
                        else
                        {
                            UDPoverTCPConnectionSend(remoteSendBuffer, bytesRead);
                        }
                        speedTester.AddProtocolRecvSize(protocolSize);
                        server.ServerSpeedLog().AddDownloadRawBytes(bytesRead);
                        speedTester.AddRecvSize(bytesRead);
                    }

                    if ((now - beforeReceive).TotalSeconds > 5)
                    {
                        _totalRecvSize = 0;
                        doRemoteTCPRecv();
                        return;
                    }
                    else
                    {
                        beforeReceive = now;
                    }
                }
                catch (Exception e)
                {
                    LogException(e);
                    final_close = true;
                    break;
                }
            }
            if (final_close)
                Close();
        }

        // end ReceiveCallback
        private void PipeRemoteUDPReceiveCallback(IAsyncResult ar)
        {
            bool final_close = false;
            try
            {
                if (closed)
                {
                    return;
                }
                IPEndPoint sender = new IPEndPoint(remoteUDP.AddressFamily == AddressFamily.InterNetworkV6 ? IPAddress.IPv6Any : IPAddress.Any, 0);
                EndPoint tempEP = (EndPoint)sender;

                int bytesRead = endRemoteUDPRecv(ar, ref tempEP);

                if (remoteUDP.IsClose)
                {
                    final_close = true;
                }
                else
                {
                    int bytesRecv = remoteUDP.GetAsyncResultSize(ar);
                    if (speedTester.BeginDownload())
                    {
                        int pingTime = -1;
                        if (speedTester.timeBeginDownload != null && speedTester.timeBeginUpload != null)
                            pingTime = (int)(speedTester.timeBeginDownload - speedTester.timeBeginUpload).TotalMilliseconds;
                        if (pingTime >= 0)
                            server.ServerSpeedLog().AddConnectTime(pingTime);
                    }
                    server.ServerSpeedLog().AddDownloadBytes(bytesRecv, DateTime.Now, speedTester.AddDownloadSize(bytesRecv));
                    ResetTimeout(cfg.TTL);

                    if (bytesRead <= 0)
                    {
                        doRemoteUDPRecv();
                    }
                    else //if (bytesRead > 0)
                    {
                        ConnectionSend(remoteUDP.GetAsyncResultBuffer(ar), bytesRead);

                        speedTester.AddRecvSize(bytesRead);
                        server.ServerSpeedLog().AddDownloadRawBytes(bytesRead);
                    }
                }
            }
            catch (Exception e)
            {
                LogException(e);
                final_close = true;
            }
            finally
            {
                if (final_close)
                {
                    Close();
                }
            }
        }

        private int RemoteSend(byte[] bytes, int length)
        {
            int total_len = 0;
            int send_len;
            send_len = remote.Send(bytes, length, SocketFlags.None);
            if (send_len > 0)
            {
                server.ServerSpeedLog().AddUploadBytes(send_len, DateTime.Now, speedTester.AddUploadSize(send_len));
                if (length >= 0)
                    ResetTimeout(cfg.TTL);
                else
                    ResetTimeout(cfg.connect_timeout <= 0 ? 30 : cfg.connect_timeout, false);
                total_len += send_len;

                if (lastKeepTime == null || (DateTime.Now - lastKeepTime).TotalSeconds > 5)
                {
                    if (keepCurrentServer != null)
                    {
                        keepCurrentServer(localPort, cfg.targetHost, server.id);
                    }
                    lastKeepTime = DateTime.Now;
                }

                while (true)
                {
                    send_len = remote.Send(null, 0, SocketFlags.None);
                    if (send_len > 0)
                    {
                        server.ServerSpeedLog().AddUploadBytes(send_len, DateTime.Now, speedTester.AddUploadSize(send_len));
                        total_len += send_len;
                    }
                    else
                        break;
                }
            }
            return total_len;
        }

        private void RemoteSendto(byte[] bytes, int length)
        {
            int send_len;
            send_len = remoteUDP.BeginSendTo(bytes, length, SocketFlags.None, new AsyncCallback(PipeRemoteUDPSendCallback), null);
            server.ServerSpeedLog().AddUploadBytes(send_len, DateTime.Now, speedTester.AddUploadSize(send_len));
        }

        private void PipeConnectionReceiveCallback(IAsyncResult ar)
        {
            bool final_close = false;
            try
            {
                if (closed)
                {
                    return;
                }
                int bytesRead = endConnectionTCPRecv(ar);

                if (bytesRead > 0)
                {
                    if (connectionUDP != null)
                    {
                        doConnectionTCPRecv();
                        ResetTimeout(cfg.TTL);
                        return;
                    }
                    byte[] connetionRecvBuffer = new byte[BufferSize];
                    Array.Copy((ar.AsyncState as CallbackState).buffer, 0, connetionRecvBuffer, 0, bytesRead);
                    if (connectionSendBufferList != null)
                    {
                        detector.OnSend(connetionRecvBuffer, bytesRead);
                        byte[] data = new byte[bytesRead];
                        Array.Copy(connetionRecvBuffer, data, data.Length);
                        connectionSendBufferList.Add(data);
                    }
                    if (State == ConnectState.CONNECTED)
                    {
                        if (remoteHeaderSendBuffer != null)
                        {
                            Array.Copy(connetionRecvBuffer, 0, connetionRecvBuffer, remoteHeaderSendBuffer.Length, bytesRead);
                            Array.Copy(remoteHeaderSendBuffer, 0, connetionRecvBuffer, 0, remoteHeaderSendBuffer.Length);
                            bytesRead += remoteHeaderSendBuffer.Length;
                            remoteHeaderSendBuffer = null;
                        }
                        else
                        {
                            Logging.LogBin(LogLevel.Debug, "remote send", connetionRecvBuffer, bytesRead);
                        }
                    }
                    if (speedTester.sizeRecv > 0)
                    {
                        connectionSendBufferList = null;
                        server.ServerSpeedLog().ResetContinurousTimes();
                    }
                    if (closed || State != ConnectState.CONNECTED)
                    {
                        return;
                    }
                    if (connectionSendBufferList != null)
                    {
                        ResetTimeout(cfg.connect_timeout);
                    }
                    else
                    {
                        ResetTimeout(cfg.TTL);
                    }
                    int send_len = RemoteSend(connetionRecvBuffer, bytesRead);
                    if (!( send_len == 0 && bytesRead > 0) )
                        doConnectionRecv();
                }
                else
                {
                    local_error = true;
                    final_close = true;
                }
            }
            catch (Exception e)
            {
                local_error = true;
                LogException(e);
                final_close = true;
            }
            finally
            {
                if (final_close)
                {
                    Close();
                }
            }
        }

        private void PipeConnectionUDPReceiveCallback(IAsyncResult ar)
        {
            bool final_close = false;
            try
            {
                if (closed)
                {
                    return;
                }
                IPEndPoint sender = new IPEndPoint(connectionUDP.AddressFamily == AddressFamily.InterNetworkV6 ? IPAddress.IPv6Any : IPAddress.Any, 0);
                EndPoint tempEP = (EndPoint)sender;

                int bytesRead = endConnectionUDPRecv(ar, ref tempEP);

                if (bytesRead > 0)
                {
                    byte[] connetionSendBuffer = new byte[bytesRead];
                    Array.Copy((byte[])ar.AsyncState, connetionSendBuffer, bytesRead);
                    if (!server.udp_over_tcp && remoteUDP != null)
                    {
                        RemoteSendto(connetionSendBuffer, bytesRead);
                    }
                    else
                    {
                        if (connetionSendBuffer[0] == 0 && connetionSendBuffer[1] == 0)
                        {
                            connetionSendBuffer[0] = (byte)(bytesRead >> 8);
                            connetionSendBuffer[1] = (byte)(bytesRead);
                            RemoteSend(connetionSendBuffer, bytesRead);
                            doConnectionRecv();
                        }
                    }
                    ResetTimeout(cfg.TTL);
                }
                else
                {
                    final_close = true;
                }
            }
            catch (Exception e)
            {
                LogException(e);
                final_close = true;
            }
            finally
            {
                if (final_close)
                {
                    Close();
                }
            }
        }

        private void PipeRemoteUDPSendCallback(IAsyncResult ar)
        {
            if (closed)
            {
                return;
            }
            try
            {
                remoteUDP.EndSendTo(ar);
                doConnectionRecv();
            }
            catch (Exception e)
            {
                LogExceptionAndClose(e);
            }
        }

        private void PipeConnectionUDPSendCallbackNoRecv(IAsyncResult ar)
        {
            if (closed)
            {
                return;
            }
            try
            {
                connectionUDP.EndSendTo(ar);
            }
            catch (Exception e)
            {
                LogExceptionAndClose(e);
            }
        }

        private void PipeConnectionUDPSendCallback(IAsyncResult ar)
        {
            if (closed)
            {
                return;
            }
            try
            {
                connectionUDP.EndSendTo(ar);
                doRemoteTCPRecv();
                doRemoteUDPRecv();
            }
            catch (Exception e)
            {
                LogExceptionAndClose(e);
            }
        }

        protected string getServerUrl(out string remarks)
        {
            Server s = server;
            if (s == null)
            {
                remarks = "";
                return "";
            }
            remarks = s.remarks;
            return s.server;
        }

        private void LogException(Exception e)
        {
            int err = LogSocketException(e);
            string remarks;
            string server_url = getServerUrl(out remarks);
            if (err != 0 && !Logging.LogSocketException(remarks, server_url, e))
                Logging.LogUsefulException(e);
        }

        private void LogExceptionAndClose(Exception e)
        {
            LogException(e);
            Close();
        }
    }

}
