﻿using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Shadowsocks.Controller;
using Shadowsocks.Model;
using Shadowsocks.Properties;

namespace Shadowsocks.View
{
    public partial class SettingsForm : MaterialForm
    {
        private ShadowsocksController controller;
        // this is a copy of configuration that we are working on
        private Configuration _modifiedConfiguration;

        public SettingsForm(ShadowsocksController controller)
        {
            this.Font = System.Drawing.SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());
            this.controller = controller;

            UpdateTexts();
            controller.ConfigChanged += controller_ConfigChanged;

            int dpi_mul = Util.Utils.GetDpiMul();
            //int font_height = 9;
            //Font new_font = new Font("Arial", (float)(9.0 * dpi_mul / 4));
            //this.Font = new_font;

            //comboProxyType.Height = comboProxyType.Height - font_height + font_height * dpi_mul / 4;
            comboProxyType.Width = comboProxyType.Width * dpi_mul / 4;
            //RandomComboBox.Height = RandomComboBox.Height - font_height + font_height * dpi_mul / 4;
            RandomComboBox.Width = RandomComboBox.Width * dpi_mul / 4;

            TextS5Server.Width = TextS5Server.Width * dpi_mul / 4;
            NumS5Port.Width = NumS5Port.Width * dpi_mul / 4;
            TextS5User.Width = TextS5User.Width * dpi_mul / 4;
            TextS5Pass.Width = TextS5Pass.Width * dpi_mul / 4;
            TextUserAgent.Width = TextUserAgent.Width * dpi_mul / 4;

            NumProxyPort.Width = NumProxyPort.Width * dpi_mul / 4;
            TextAuthUser.Width = TextAuthUser.Width * dpi_mul / 4;
            TextAuthPass.Width = TextAuthPass.Width * dpi_mul / 4;

            buttonDefault.Height = buttonDefault.Height * dpi_mul / 4;
            buttonDefault.Width = buttonDefault.Width * dpi_mul / 4;
            DNSText.Width = DNSText.Width * dpi_mul / 4;
            NumReconnect.Width = NumReconnect.Width * dpi_mul / 4;
            NumTimeout.Width = NumTimeout.Width * dpi_mul / 4;
            NumTTL.Width = NumTTL.Width * dpi_mul / 4;

            LoadCurrentConfiguration();
        }
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.ConfigChanged -= controller_ConfigChanged;
        }

        private void UpdateTexts()
        {
            this.Text = I18N.GetString("Global Settings") + "("
                + (controller.GetCurrentConfiguration().shareOverLan ? "any" : "local") + ":" + controller.GetCurrentConfiguration().localPort.ToString()
                + I18N.GetString(" Version") + UpdateChecker.FullVersion
                + ")";

            ListenGroup.Text = I18N.GetString(ListenGroup.Text);
            checkShareOverLan.Text = I18N.GetString(checkShareOverLan.Text);
            ProxyPortLabel.Text = I18N.GetString("Proxy Port");
            ReconnectLabel.Text = I18N.GetString("Reconnect Times");
            TTLLabel.Text = I18N.GetString("TTL");
            labelTimeout.Text = I18N.GetString(labelTimeout.Text);

            checkAutoStartup.Text = I18N.GetString(checkAutoStartup.Text);
            checkRandom.Text = I18N.GetString(checkRandom.Text);
            CheckAutoBan.Text = I18N.GetString("AutoBan");

            Socks5ProxyGroup.Text = I18N.GetString(Socks5ProxyGroup.Text);
            checkBoxPacProxy.Text = I18N.GetString(checkBoxPacProxy.Text);
            CheckSockProxy.Text = I18N.GetString("Proxy On");
            LabelS5Server.Text = I18N.GetString("Server IP");
            LabelS5Port.Text = I18N.GetString("Server Port");
            LabelS5Server.Text = I18N.GetString("Server IP");
            LabelS5Port.Text = I18N.GetString("Server Port");
            LabelS5Username.Text = I18N.GetString("Username");
            LabelS5Password.Text = I18N.GetString("Password");
            LabelAuthUser.Text = I18N.GetString("Username");
            LabelAuthPass.Text = I18N.GetString("Password");

            LabelRandom.Text = I18N.GetString("Balance");
            for (int i = 0; i < comboProxyType.Items.Count; ++i)
            {
                comboProxyType.Items[i] = I18N.GetString(comboProxyType.Items[i].ToString());
            }
            checkBalanceInGroup.Text = I18N.GetString("Balance in group");
            for (int i = 0; i < RandomComboBox.Items.Count; ++i)
            {
                RandomComboBox.Items[i] = I18N.GetString(RandomComboBox.Items[i].ToString());
            }

            OKButton.Text = I18N.GetString("OK");
            MyCancelButton.Text = I18N.GetString("Cancel");
        }

        private void controller_ConfigChanged(object sender, EventArgs e)
        {
            LoadCurrentConfiguration();
        }

        private void ShowWindow()
        {
            this.Opacity = 1;
            this.Show();
        }

        private int SaveOldSelectedServer()
        {
            try
            {
                int localPort = int.Parse(NumProxyPort.Text);
                Configuration.CheckPort(localPort);
                int ret = 0;
                _modifiedConfiguration.shareOverLan = checkShareOverLan.Checked;
                _modifiedConfiguration.localPort = localPort;
                _modifiedConfiguration.reconnectTimes = NumReconnect.Text.Length == 0 ? 0 : int.Parse(NumReconnect.Text);

                if (checkAutoStartup.Checked != AutoStartup.Check() && !AutoStartup.Set(checkAutoStartup.Checked))
                {
                    MessageBox.Show(I18N.GetString("Failed to update registry"));
                }
                _modifiedConfiguration.random = checkRandom.Checked;
                _modifiedConfiguration.randomAlgorithm = RandomComboBox.SelectedIndex;
                _modifiedConfiguration.randomInGroup = checkBalanceInGroup.Checked;
                _modifiedConfiguration.TTL = Convert.ToInt32(NumTTL.Value);
                _modifiedConfiguration.connectTimeout = Convert.ToInt32(NumTimeout.Value);
                _modifiedConfiguration.dnsServer = DNSText.Text;
                _modifiedConfiguration.proxyEnable = CheckSockProxy.Checked;
                _modifiedConfiguration.pacDirectGoProxy = checkBoxPacProxy.Checked;
                _modifiedConfiguration.proxyType = comboProxyType.SelectedIndex;
                _modifiedConfiguration.proxyHost = TextS5Server.Text;
                _modifiedConfiguration.proxyPort = Convert.ToInt32(NumS5Port.Value);
                _modifiedConfiguration.proxyAuthUser = TextS5User.Text;
                _modifiedConfiguration.proxyAuthPass = TextS5Pass.Text;
                _modifiedConfiguration.proxyUserAgent = TextUserAgent.Text;
                _modifiedConfiguration.authUser = TextAuthUser.Text;
                _modifiedConfiguration.authPass = TextAuthPass.Text;

                _modifiedConfiguration.autoBan = CheckAutoBan.Checked;

                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1; // ERROR
        }

        private void LoadSelectedServer()
        {
            checkShareOverLan.Checked = _modifiedConfiguration.shareOverLan;
            NumProxyPort.Value = _modifiedConfiguration.localPort;
            NumReconnect.Value = _modifiedConfiguration.reconnectTimes;

            checkAutoStartup.Checked = AutoStartup.Check();
            checkRandom.Checked = _modifiedConfiguration.random;
            if (_modifiedConfiguration.randomAlgorithm >= 0 && _modifiedConfiguration.randomAlgorithm < RandomComboBox.Items.Count)
            {
                RandomComboBox.SelectedIndex = _modifiedConfiguration.randomAlgorithm;
            }
            else
            {
                RandomComboBox.SelectedIndex = (int)ServerSelectStrategy.SelectAlgorithm.LowException;
            }
            checkBalanceInGroup.Checked = _modifiedConfiguration.randomInGroup;
            NumTTL.Value = _modifiedConfiguration.TTL;
            NumTimeout.Value = _modifiedConfiguration.connectTimeout;
            DNSText.Text = _modifiedConfiguration.dnsServer;

            CheckSockProxy.Checked = _modifiedConfiguration.proxyEnable;
            checkBoxPacProxy.Checked = _modifiedConfiguration.pacDirectGoProxy;
            comboProxyType.SelectedIndex = _modifiedConfiguration.proxyType;
            TextS5Server.Text = _modifiedConfiguration.proxyHost;
            NumS5Port.Value = _modifiedConfiguration.proxyPort;
            TextS5User.Text = _modifiedConfiguration.proxyAuthUser;
            TextS5Pass.Text = _modifiedConfiguration.proxyAuthPass;
            TextUserAgent.Text = _modifiedConfiguration.proxyUserAgent;
            TextAuthUser.Text = _modifiedConfiguration.authUser;
            TextAuthPass.Text = _modifiedConfiguration.authPass;

            CheckAutoBan.Checked = _modifiedConfiguration.autoBan;
        }

        private void LoadCurrentConfiguration()
        {
            _modifiedConfiguration = controller.GetConfiguration();
            LoadSelectedServer();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (SaveOldSelectedServer() == -1)
            {
                return;
            }
            controller.SaveServersConfig(_modifiedConfiguration);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            if (CheckSockProxy.Checked)
            {
                NumReconnect.Value = 4;
                NumTimeout.Value = 10;
                NumTTL.Value = 60;
            }
            else
            {
                NumReconnect.Value = 4;
                NumTimeout.Value = 5;
                NumTTL.Value = 60;
            }
        }
    }
}
