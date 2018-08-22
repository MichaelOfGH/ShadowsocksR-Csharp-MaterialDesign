﻿using Shadowsocks.Model;
using Shadowsocks.Properties;
using Shadowsocks.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Shadowsocks.Controller
{
    class PACServer : Listener.Service
    {
        public static string PAC_FILE = "pac.txt";

        public static string USER_RULE_FILE = "user-rule.txt";

        public static string USER_ABP_FILE = "abp.txt";

        FileSystemWatcher PACFileWatcher;
        FileSystemWatcher UserRuleFileWatcher;
        private Configuration _config;

        public event EventHandler PACFileChanged;
        public event EventHandler UserRuleFileChanged;

        public PACServer()
        {
            this.WatchPacFile();
            this.WatchUserRuleFile();
        }

        public void UpdateConfiguration(Configuration config)
        {
            this._config = config;
        }

        public bool Handle(byte[] firstPacket, int length, Socket socket)
        {
            try
            {
                string request = Encoding.UTF8.GetString(firstPacket, 0, length);
                string[] lines = request.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                bool hostMatch = false, pathMatch = false;
                int socksType = 0;
                string proxy = null;
                foreach (string line in lines)
                {
                    string[] kv = line.Split(new char[]{':'}, 2);
                    if (kv.Length == 2)
                    {
                        if (kv[0] == "Host")
                        {
                            if (kv[1].Trim() == ((IPEndPoint)socket.LocalEndPoint).ToString())
                            {
                                hostMatch = true;
                            }
                        }
                        else if (kv[0] == "User-Agent")
                        {
                            // we need to drop connections when changing servers
                            /* if (kv[1].IndexOf("Chrome") >= 0)
                            {
                                useSocks = true;
                            } */
                        }
                    }
                    else if (kv.Length == 1)
                    {
                        if (!Util.Utils.isLocal(socket) || line.IndexOf("auth=" + _config.localAuthPassword) > 0)
                        {
                            if (line.IndexOf(" /pac?") > 0 && line.IndexOf("GET") == 0)
                            {
                                string url = line.Substring(line.IndexOf(" ") + 1);
                                url = url.Substring(0, url.IndexOf(" "));
                                pathMatch = true;
                                int port_pos = url.IndexOf("port=");
                                if (port_pos > 0)
                                {
                                    string port = url.Substring(port_pos + 5);
                                    if (port.IndexOf("&") >= 0)
                                    {
                                        port = port.Substring(0, port.IndexOf("&"));
                                    }

                                    int ip_pos = url.IndexOf("ip=");
                                    if (ip_pos > 0)
                                    {
                                        proxy = url.Substring(ip_pos + 3);
                                        if (proxy.IndexOf("&") >= 0)
                                        {
                                            proxy = proxy.Substring(0, proxy.IndexOf("&"));
                                        }
                                        proxy += ":" + port + ";";
                                    }
                                    else
                                    {
                                        proxy = "127.0.0.1:" + port + ";";
                                    }
                                }

                                if (url.IndexOf("type=socks4") > 0 || url.IndexOf("type=s4") > 0)
                                {
                                    socksType = 4;
                                }
                                if (url.IndexOf("type=socks5") > 0 || url.IndexOf("type=s5") > 0)
                                {
                                    socksType = 5;
                                }
                            }
                        }
                    }
                }
                if (hostMatch && pathMatch)
                {
                    SendResponse(firstPacket, length, socket, socksType, proxy);
                    return true;
                }
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }


        public string TouchPACFile()
        {
            if (File.Exists(PAC_FILE))
            {
                return PAC_FILE;
            }
            else
            {
                FileManager.UncompressFile(PAC_FILE, Resources.proxy_pac_txt);
                return PAC_FILE;
            }
        }

        internal string TouchUserRuleFile()
        {
            if (File.Exists(USER_RULE_FILE))
            {
                return USER_RULE_FILE;
            }
            else
            {
                File.WriteAllText(USER_RULE_FILE, Resources.user_rule);
                return USER_RULE_FILE;
            }
        }

        private string GetPACContent()
        {
            if (File.Exists(PAC_FILE))
            {
                return File.ReadAllText(PAC_FILE, Encoding.UTF8);
            }
            else
            {
                return Utils.UnGzip(Resources.proxy_pac_txt);
            }
        }

        public void SendResponse(byte[] firstPacket, int length, Socket socket, int socksType, string setProxy)
        {
            try
            {
                string pac = GetPACContent();

                IPEndPoint localEndPoint = (IPEndPoint)socket.LocalEndPoint;

                string proxy =
                    setProxy == null ? GetPACAddress(firstPacket, length, localEndPoint, socksType) :
                    socksType == 5 ? "SOCKS5 " + setProxy :
                    socksType == 4 ? "SOCKS " + setProxy :
                    "PROXY " + setProxy;

                if (_config.pacDirectGoProxy && _config.proxyEnable)
                {
                    if (_config.proxyType == 0)
                        pac = pac.Replace("__DIRECT__", "SOCKS5 " + _config.proxyHost + ":" +  _config.proxyPort.ToString() + ";DIRECT;");
                    else if (_config.proxyType == 1)
                        pac = pac.Replace("__DIRECT__", "PROXY " + _config.proxyHost + ":" + _config.proxyPort.ToString() + ";DIRECT;");
                }
                else
                    pac = pac.Replace("__DIRECT__", "DIRECT;");
                pac = pac.Replace("__PROXY__", proxy + "DIRECT;");

                string text = String.Format(@"HTTP/1.1 200 OK
Server: ShadowsocksR
Content-Type: application/x-ns-proxy-autoconfig
Content-Length: {0}
Connection: Close

", System.Text.Encoding.UTF8.GetBytes(pac).Length) + pac;
                byte[] response = System.Text.Encoding.UTF8.GetBytes(text);
                socket.BeginSend(response, 0, response.Length, 0, new AsyncCallback(SendCallback), socket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }

        private void SendCallback(IAsyncResult ar)
        {
            Socket conn = (Socket)ar.AsyncState;
            try
            {
                conn.Shutdown(SocketShutdown.Both);
                conn.Close();
            }
            catch
            { }
        }

        private void WatchPacFile()
        {
            if (PACFileWatcher != null)
            {
                PACFileWatcher.Dispose();
            }
            PACFileWatcher = new FileSystemWatcher(Directory.GetCurrentDirectory());
            PACFileWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            PACFileWatcher.Filter = PAC_FILE;
            PACFileWatcher.Changed += Watcher_Changed;
            PACFileWatcher.Created += Watcher_Changed;
            PACFileWatcher.Deleted += Watcher_Changed;
            PACFileWatcher.Renamed += Watcher_Changed;
            PACFileWatcher.EnableRaisingEvents = true;
        }

        private void WatchUserRuleFile()
        {
            if (UserRuleFileWatcher != null)
            {
                UserRuleFileWatcher.Dispose();
            }
            UserRuleFileWatcher = new FileSystemWatcher(Directory.GetCurrentDirectory());
            UserRuleFileWatcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            UserRuleFileWatcher.Filter = USER_RULE_FILE;
            UserRuleFileWatcher.Changed += UserRuleFileWatcher_Changed;
            UserRuleFileWatcher.Created += UserRuleFileWatcher_Changed;
            UserRuleFileWatcher.Deleted += UserRuleFileWatcher_Changed;
            UserRuleFileWatcher.Renamed += UserRuleFileWatcher_Changed;
            UserRuleFileWatcher.EnableRaisingEvents = true;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (PACFileChanged != null)
            {
                PACFileChanged(this, new EventArgs());
            }
        }

        private void UserRuleFileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (UserRuleFileChanged != null)
            {
                UserRuleFileChanged(this, new EventArgs());
            }
        }

        private string GetPACAddress(byte[] requestBuf, int length, IPEndPoint localEndPoint, int socksType)
        {
            //try
            //{
            //    string requestString = Encoding.UTF8.GetString(requestBuf);
            //    if (requestString.IndexOf("AppleWebKit") >= 0)
            //    {
            //        string address = "" + localEndPoint.Address + ":" + config.GetCurrentServer().local_port;
            //        proxy = "SOCKS5 " + address + "; SOCKS " + address + ";";
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            if (socksType == 5)
            {
                return "SOCKS5 " + localEndPoint.Address + ":" + this._config.localPort + ";";
            }
            else if (socksType == 4)
            {
                return "SOCKS " + localEndPoint.Address + ":" + this._config.localPort + ";";
            }
            return "PROXY " + localEndPoint.Address + ":" + this._config.localPort + ";";
        }
    }
}
