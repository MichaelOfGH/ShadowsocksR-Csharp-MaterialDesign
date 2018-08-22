using MaterialSkin.Controls;

namespace Shadowsocks.View
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelRandom = new System.Windows.Forms.Label();
            this.RandomComboBox = new System.Windows.Forms.ComboBox();
            this.CheckAutoBan = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkRandom = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkAutoStartup = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBalanceInGroup = new MaterialSkin.Controls.MaterialCheckBox();
            this.Socks5ProxyGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelS5Password = new System.Windows.Forms.Label();
            this.LabelS5Username = new System.Windows.Forms.Label();
            this.TextS5Pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelS5Port = new System.Windows.Forms.Label();
            this.TextS5User = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelS5Server = new System.Windows.Forms.Label();
            this.NumS5Port = new System.Windows.Forms.NumericUpDown();
            this.TextS5Server = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboProxyType = new System.Windows.Forms.ComboBox();
            this.CheckSockProxy = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBoxPacProxy = new MaterialSkin.Controls.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextUserAgent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ListenGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TextAuthPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelAuthPass = new System.Windows.Forms.Label();
            this.TextAuthUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelAuthUser = new System.Windows.Forms.Label();
            this.checkShareOverLan = new MaterialSkin.Controls.MaterialCheckBox();
            this.NumProxyPort = new System.Windows.Forms.NumericUpDown();
            this.ProxyPortLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MyCancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OKButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ReconnectLabel = new System.Windows.Forms.Label();
            this.NumReconnect = new System.Windows.Forms.NumericUpDown();
            this.TTLLabel = new System.Windows.Forms.Label();
            this.NumTTL = new System.Windows.Forms.NumericUpDown();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.NumTimeout = new System.Windows.Forms.NumericUpDown();
            this.DNSText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonDefault = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Socks5ProxyGroup.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumS5Port)).BeginInit();
            this.ListenGroup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumProxyPort)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumReconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Socks5ProxyGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListenGroup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LabelRandom, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.RandomComboBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.CheckAutoBan, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkRandom, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkAutoStartup, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBalanceInGroup, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(372, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 152);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LabelRandom
            // 
            this.LabelRandom.AutoSize = true;
            this.LabelRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelRandom.Location = new System.Drawing.Point(3, 60);
            this.LabelRandom.Name = "LabelRandom";
            this.LabelRandom.Size = new System.Drawing.Size(51, 32);
            this.LabelRandom.TabIndex = 12;
            this.LabelRandom.Text = "Balance";
            this.LabelRandom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RandomComboBox
            // 
            this.RandomComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RandomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RandomComboBox.FormattingEnabled = true;
            this.RandomComboBox.Items.AddRange(new object[] {
            "Order",
            "Random",
            "LowLatency",
            "LowException",
            "SelectedFirst",
            "Timer"});
            this.RandomComboBox.Location = new System.Drawing.Point(60, 63);
            this.RandomComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.RandomComboBox.Name = "RandomComboBox";
            this.RandomComboBox.Size = new System.Drawing.Size(147, 22);
            this.RandomComboBox.TabIndex = 14;
            // 
            // CheckAutoBan
            // 
            this.CheckAutoBan.AutoSize = true;
            this.CheckAutoBan.Depth = 0;
            this.CheckAutoBan.Enabled = false;
            this.CheckAutoBan.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckAutoBan.Location = new System.Drawing.Point(57, 122);
            this.CheckAutoBan.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAutoBan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckAutoBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckAutoBan.Name = "CheckAutoBan";
            this.CheckAutoBan.Ripple = true;
            this.CheckAutoBan.Size = new System.Drawing.Size(83, 30);
            this.CheckAutoBan.TabIndex = 15;
            this.CheckAutoBan.Text = "AutoBan";
            this.CheckAutoBan.UseVisualStyleBackColor = true;
            // 
            // checkRandom
            // 
            this.checkRandom.AutoSize = true;
            this.checkRandom.Depth = 0;
            this.checkRandom.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkRandom.Location = new System.Drawing.Point(57, 30);
            this.checkRandom.Margin = new System.Windows.Forms.Padding(0);
            this.checkRandom.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRandom.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRandom.Name = "checkRandom";
            this.checkRandom.Ripple = true;
            this.checkRandom.Size = new System.Drawing.Size(112, 30);
            this.checkRandom.TabIndex = 13;
            this.checkRandom.Text = "Load balance";
            this.checkRandom.UseVisualStyleBackColor = true;
            // 
            // checkAutoStartup
            // 
            this.checkAutoStartup.AutoSize = true;
            this.checkAutoStartup.Depth = 0;
            this.checkAutoStartup.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkAutoStartup.Location = new System.Drawing.Point(57, 0);
            this.checkAutoStartup.Margin = new System.Windows.Forms.Padding(0);
            this.checkAutoStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkAutoStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkAutoStartup.Name = "checkAutoStartup";
            this.checkAutoStartup.Ripple = true;
            this.checkAutoStartup.Size = new System.Drawing.Size(111, 30);
            this.checkAutoStartup.TabIndex = 12;
            this.checkAutoStartup.Text = "Start on Boot";
            this.checkAutoStartup.UseVisualStyleBackColor = true;
            // 
            // checkBalanceInGroup
            // 
            this.checkBalanceInGroup.AutoSize = true;
            this.checkBalanceInGroup.Depth = 0;
            this.checkBalanceInGroup.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBalanceInGroup.Location = new System.Drawing.Point(57, 92);
            this.checkBalanceInGroup.Margin = new System.Windows.Forms.Padding(0);
            this.checkBalanceInGroup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBalanceInGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBalanceInGroup.Name = "checkBalanceInGroup";
            this.checkBalanceInGroup.Ripple = true;
            this.checkBalanceInGroup.Size = new System.Drawing.Size(133, 30);
            this.checkBalanceInGroup.TabIndex = 15;
            this.checkBalanceInGroup.Text = "Balance in group";
            this.checkBalanceInGroup.UseVisualStyleBackColor = true;
            // 
            // Socks5ProxyGroup
            // 
            this.Socks5ProxyGroup.AutoSize = true;
            this.Socks5ProxyGroup.Controls.Add(this.tableLayoutPanel9);
            this.Socks5ProxyGroup.Font = new System.Drawing.Font("Roboto", 9F);
            this.Socks5ProxyGroup.Location = new System.Drawing.Point(14, 0);
            this.Socks5ProxyGroup.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.Socks5ProxyGroup.Name = "Socks5ProxyGroup";
            this.tableLayoutPanel1.SetRowSpan(this.Socks5ProxyGroup, 2);
            this.Socks5ProxyGroup.Size = new System.Drawing.Size(355, 256);
            this.Socks5ProxyGroup.TabIndex = 0;
            this.Socks5ProxyGroup.TabStop = false;
            this.Socks5ProxyGroup.Text = "Remote proxy";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.LabelS5Password, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.LabelS5Username, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.TextS5Pass, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.LabelS5Port, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.TextS5User, 1, 4);
            this.tableLayoutPanel9.Controls.Add(this.LabelS5Server, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.NumS5Port, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.TextS5Server, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.comboProxyType, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.CheckSockProxy, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.checkBoxPacProxy, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.TextUserAgent, 1, 6);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(11, 32);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 7;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(338, 203);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // LabelS5Password
            // 
            this.LabelS5Password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelS5Password.AutoSize = true;
            this.LabelS5Password.Location = new System.Drawing.Point(21, 151);
            this.LabelS5Password.Name = "LabelS5Password";
            this.LabelS5Password.Size = new System.Drawing.Size(61, 14);
            this.LabelS5Password.TabIndex = 5;
            this.LabelS5Password.Text = "Password";
            // 
            // LabelS5Username
            // 
            this.LabelS5Username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelS5Username.AutoSize = true;
            this.LabelS5Username.Location = new System.Drawing.Point(21, 122);
            this.LabelS5Username.Name = "LabelS5Username";
            this.LabelS5Username.Size = new System.Drawing.Size(61, 14);
            this.LabelS5Username.TabIndex = 4;
            this.LabelS5Username.Text = "Username";
            // 
            // TextS5Pass
            // 
            this.TextS5Pass.Depth = 0;
            this.TextS5Pass.Hint = "";
            this.TextS5Pass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextS5Pass.Location = new System.Drawing.Point(88, 147);
            this.TextS5Pass.MaxLength = 32767;
            this.TextS5Pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextS5Pass.Name = "TextS5Pass";
            this.TextS5Pass.PasswordChar = '\0';
            this.TextS5Pass.SelectedText = "";
            this.TextS5Pass.SelectionLength = 0;
            this.TextS5Pass.SelectionStart = 0;
            this.TextS5Pass.Size = new System.Drawing.Size(236, 23);
            this.TextS5Pass.TabIndex = 6;
            this.TextS5Pass.TabStop = false;
            this.TextS5Pass.UseSystemPasswordChar = false;
            // 
            // LabelS5Port
            // 
            this.LabelS5Port.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelS5Port.AutoSize = true;
            this.LabelS5Port.Location = new System.Drawing.Point(52, 94);
            this.LabelS5Port.Name = "LabelS5Port";
            this.LabelS5Port.Size = new System.Drawing.Size(30, 14);
            this.LabelS5Port.TabIndex = 1;
            this.LabelS5Port.Text = "Port";
            // 
            // TextS5User
            // 
            this.TextS5User.Depth = 0;
            this.TextS5User.Hint = "";
            this.TextS5User.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextS5User.Location = new System.Drawing.Point(88, 118);
            this.TextS5User.MaxLength = 32767;
            this.TextS5User.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextS5User.Name = "TextS5User";
            this.TextS5User.PasswordChar = '\0';
            this.TextS5User.SelectedText = "";
            this.TextS5User.SelectionLength = 0;
            this.TextS5User.SelectionStart = 0;
            this.TextS5User.Size = new System.Drawing.Size(236, 23);
            this.TextS5User.TabIndex = 5;
            this.TextS5User.TabStop = false;
            this.TextS5User.UseSystemPasswordChar = false;
            // 
            // LabelS5Server
            // 
            this.LabelS5Server.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelS5Server.AutoSize = true;
            this.LabelS5Server.Location = new System.Drawing.Point(28, 65);
            this.LabelS5Server.Name = "LabelS5Server";
            this.LabelS5Server.Size = new System.Drawing.Size(54, 14);
            this.LabelS5Server.TabIndex = 0;
            this.LabelS5Server.Text = "Server IP";
            // 
            // NumS5Port
            // 
            this.NumS5Port.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumS5Port.Location = new System.Drawing.Point(88, 90);
            this.NumS5Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumS5Port.Name = "NumS5Port";
            this.NumS5Port.Size = new System.Drawing.Size(236, 22);
            this.NumS5Port.TabIndex = 4;
            // 
            // TextS5Server
            // 
            this.TextS5Server.Depth = 0;
            this.TextS5Server.Hint = "";
            this.TextS5Server.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextS5Server.Location = new System.Drawing.Point(88, 61);
            this.TextS5Server.MaxLength = 32767;
            this.TextS5Server.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextS5Server.Name = "TextS5Server";
            this.TextS5Server.PasswordChar = '\0';
            this.TextS5Server.SelectedText = "";
            this.TextS5Server.SelectionLength = 0;
            this.TextS5Server.SelectionStart = 0;
            this.TextS5Server.Size = new System.Drawing.Size(236, 23);
            this.TextS5Server.TabIndex = 3;
            this.TextS5Server.TabStop = false;
            this.TextS5Server.UseSystemPasswordChar = false;
            // 
            // comboProxyType
            // 
            this.comboProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProxyType.FormattingEnabled = true;
            this.comboProxyType.Items.AddRange(new object[] {
            "Socks5(support UDP)",
            "Http tunnel",
            "TCP Port tunnel"});
            this.comboProxyType.Location = new System.Drawing.Point(88, 33);
            this.comboProxyType.Name = "comboProxyType";
            this.comboProxyType.Size = new System.Drawing.Size(236, 22);
            this.comboProxyType.TabIndex = 2;
            // 
            // CheckSockProxy
            // 
            this.CheckSockProxy.AutoSize = true;
            this.CheckSockProxy.Depth = 0;
            this.CheckSockProxy.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckSockProxy.Location = new System.Drawing.Point(0, 0);
            this.CheckSockProxy.Margin = new System.Windows.Forms.Padding(0);
            this.CheckSockProxy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckSockProxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckSockProxy.Name = "CheckSockProxy";
            this.CheckSockProxy.Ripple = true;
            this.CheckSockProxy.Size = new System.Drawing.Size(85, 30);
            this.CheckSockProxy.TabIndex = 0;
            this.CheckSockProxy.Text = "Proxy On";
            this.CheckSockProxy.UseVisualStyleBackColor = true;
            // 
            // checkBoxPacProxy
            // 
            this.checkBoxPacProxy.AutoSize = true;
            this.checkBoxPacProxy.Depth = 0;
            this.checkBoxPacProxy.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxPacProxy.Location = new System.Drawing.Point(85, 0);
            this.checkBoxPacProxy.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPacProxy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxPacProxy.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxPacProxy.Name = "checkBoxPacProxy";
            this.checkBoxPacProxy.Ripple = true;
            this.checkBoxPacProxy.Size = new System.Drawing.Size(208, 30);
            this.checkBoxPacProxy.TabIndex = 1;
            this.checkBoxPacProxy.Text = "PAC \"direct\" return this proxy";
            this.checkBoxPacProxy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserAgent";
            // 
            // TextUserAgent
            // 
            this.TextUserAgent.Depth = 0;
            this.TextUserAgent.Hint = "";
            this.TextUserAgent.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextUserAgent.Location = new System.Drawing.Point(88, 176);
            this.TextUserAgent.MaxLength = 32767;
            this.TextUserAgent.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextUserAgent.Name = "TextUserAgent";
            this.TextUserAgent.PasswordChar = '\0';
            this.TextUserAgent.SelectedText = "";
            this.TextUserAgent.SelectionLength = 0;
            this.TextUserAgent.SelectionStart = 0;
            this.TextUserAgent.Size = new System.Drawing.Size(236, 23);
            this.TextUserAgent.TabIndex = 7;
            this.TextUserAgent.TabStop = false;
            this.TextUserAgent.UseSystemPasswordChar = false;
            // 
            // ListenGroup
            // 
            this.ListenGroup.AutoSize = true;
            this.ListenGroup.Controls.Add(this.tableLayoutPanel4);
            this.ListenGroup.Location = new System.Drawing.Point(14, 256);
            this.ListenGroup.Margin = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.ListenGroup.Name = "ListenGroup";
            this.ListenGroup.Size = new System.Drawing.Size(339, 177);
            this.ListenGroup.TabIndex = 1;
            this.ListenGroup.TabStop = false;
            this.ListenGroup.Text = "Local proxy";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.TextAuthPass, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.LabelAuthPass, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.TextAuthUser, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.LabelAuthUser, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkShareOverLan, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.NumProxyPort, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ProxyPortLabel, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 32);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(328, 124);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // TextAuthPass
            // 
            this.TextAuthPass.Depth = 0;
            this.TextAuthPass.Hint = "";
            this.TextAuthPass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextAuthPass.Location = new System.Drawing.Point(70, 90);
            this.TextAuthPass.MaxLength = 32767;
            this.TextAuthPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextAuthPass.Name = "TextAuthPass";
            this.TextAuthPass.PasswordChar = '\0';
            this.TextAuthPass.SelectedText = "";
            this.TextAuthPass.SelectionLength = 0;
            this.TextAuthPass.SelectionStart = 0;
            this.TextAuthPass.Size = new System.Drawing.Size(236, 23);
            this.TextAuthPass.TabIndex = 11;
            this.TextAuthPass.TabStop = false;
            this.TextAuthPass.UseSystemPasswordChar = false;
            // 
            // LabelAuthPass
            // 
            this.LabelAuthPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelAuthPass.AutoSize = true;
            this.LabelAuthPass.Location = new System.Drawing.Point(3, 98);
            this.LabelAuthPass.Name = "LabelAuthPass";
            this.LabelAuthPass.Size = new System.Drawing.Size(61, 14);
            this.LabelAuthPass.TabIndex = 8;
            this.LabelAuthPass.Text = "Password";
            // 
            // TextAuthUser
            // 
            this.TextAuthUser.Depth = 0;
            this.TextAuthUser.Hint = "";
            this.TextAuthUser.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextAuthUser.Location = new System.Drawing.Point(70, 61);
            this.TextAuthUser.MaxLength = 32767;
            this.TextAuthUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextAuthUser.Name = "TextAuthUser";
            this.TextAuthUser.PasswordChar = '\0';
            this.TextAuthUser.SelectedText = "";
            this.TextAuthUser.SelectionLength = 0;
            this.TextAuthUser.SelectionStart = 0;
            this.TextAuthUser.Size = new System.Drawing.Size(236, 23);
            this.TextAuthUser.TabIndex = 10;
            this.TextAuthUser.TabStop = false;
            this.TextAuthUser.UseSystemPasswordChar = false;
            // 
            // LabelAuthUser
            // 
            this.LabelAuthUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelAuthUser.AutoSize = true;
            this.LabelAuthUser.Location = new System.Drawing.Point(3, 65);
            this.LabelAuthUser.Name = "LabelAuthUser";
            this.LabelAuthUser.Size = new System.Drawing.Size(61, 14);
            this.LabelAuthUser.TabIndex = 5;
            this.LabelAuthUser.Text = "Username";
            // 
            // checkShareOverLan
            // 
            this.checkShareOverLan.AutoSize = true;
            this.checkShareOverLan.Depth = 0;
            this.checkShareOverLan.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkShareOverLan.Location = new System.Drawing.Point(67, 0);
            this.checkShareOverLan.Margin = new System.Windows.Forms.Padding(0);
            this.checkShareOverLan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkShareOverLan.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkShareOverLan.Name = "checkShareOverLan";
            this.checkShareOverLan.Ripple = true;
            this.checkShareOverLan.Size = new System.Drawing.Size(173, 30);
            this.checkShareOverLan.TabIndex = 8;
            this.checkShareOverLan.Text = "Allow Clients from LAN";
            this.checkShareOverLan.UseVisualStyleBackColor = true;
            // 
            // NumProxyPort
            // 
            this.NumProxyPort.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumProxyPort.Location = new System.Drawing.Point(70, 33);
            this.NumProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumProxyPort.Name = "NumProxyPort";
            this.NumProxyPort.Size = new System.Drawing.Size(236, 22);
            this.NumProxyPort.TabIndex = 9;
            // 
            // ProxyPortLabel
            // 
            this.ProxyPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProxyPortLabel.AutoSize = true;
            this.ProxyPortLabel.Location = new System.Drawing.Point(34, 37);
            this.ProxyPortLabel.Name = "ProxyPortLabel";
            this.ProxyPortLabel.Size = new System.Drawing.Size(30, 14);
            this.ProxyPortLabel.TabIndex = 3;
            this.ProxyPortLabel.Text = "Port";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(453, 271);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(191, 212);
            this.tableLayoutPanel10.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(36, 170);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(121, 39);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.AutoSize = true;
            this.MyCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MyCancelButton.Depth = 0;
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyCancelButton.Icon = null;
            this.MyCancelButton.Location = new System.Drawing.Point(48, 3);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.MyCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Primary = false;
            this.MyCancelButton.Size = new System.Drawing.Size(73, 36);
            this.MyCancelButton.TabIndex = 22;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKButton.Depth = 0;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(3, 3);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.Primary = false;
            this.OKButton.Size = new System.Drawing.Size(39, 36);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.ReconnectLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.NumReconnect, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.TTLLabel, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.NumTTL, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.labelTimeout, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.NumTimeout, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.DNSText, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.buttonDefault, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(191, 167);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // ReconnectLabel
            // 
            this.ReconnectLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ReconnectLabel.AutoSize = true;
            this.ReconnectLabel.Location = new System.Drawing.Point(6, 87);
            this.ReconnectLabel.Name = "ReconnectLabel";
            this.ReconnectLabel.Size = new System.Drawing.Size(64, 14);
            this.ReconnectLabel.TabIndex = 3;
            this.ReconnectLabel.Text = "Reconnect";
            // 
            // NumReconnect
            // 
            this.NumReconnect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumReconnect.Location = new System.Drawing.Point(76, 83);
            this.NumReconnect.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumReconnect.Name = "NumReconnect";
            this.NumReconnect.Size = new System.Drawing.Size(109, 22);
            this.NumReconnect.TabIndex = 18;
            // 
            // TTLLabel
            // 
            this.TTLLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TTLLabel.AutoSize = true;
            this.TTLLabel.Location = new System.Drawing.Point(42, 143);
            this.TTLLabel.Name = "TTLLabel";
            this.TTLLabel.Size = new System.Drawing.Size(28, 14);
            this.TTLLabel.TabIndex = 3;
            this.TTLLabel.Text = "TTL";
            // 
            // NumTTL
            // 
            this.NumTTL.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumTTL.Location = new System.Drawing.Point(76, 139);
            this.NumTTL.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NumTTL.Name = "NumTTL";
            this.NumTTL.Size = new System.Drawing.Size(109, 22);
            this.NumTTL.TabIndex = 20;
            // 
            // labelTimeout
            // 
            this.labelTimeout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Location = new System.Drawing.Point(16, 115);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(54, 14);
            this.labelTimeout.TabIndex = 3;
            this.labelTimeout.Text = " Timeout";
            // 
            // NumTimeout
            // 
            this.NumTimeout.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumTimeout.Location = new System.Drawing.Point(76, 111);
            this.NumTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumTimeout.Name = "NumTimeout";
            this.NumTimeout.Size = new System.Drawing.Size(109, 22);
            this.NumTimeout.TabIndex = 19;
            // 
            // DNSText
            // 
            this.DNSText.Depth = 0;
            this.DNSText.Hint = "";
            this.DNSText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DNSText.Location = new System.Drawing.Point(76, 54);
            this.DNSText.MaxLength = 0;
            this.DNSText.MouseState = MaterialSkin.MouseState.HOVER;
            this.DNSText.Name = "DNSText";
            this.DNSText.PasswordChar = '\0';
            this.DNSText.SelectedText = "";
            this.DNSText.SelectionLength = 0;
            this.DNSText.SelectionStart = 0;
            this.DNSText.Size = new System.Drawing.Size(109, 23);
            this.DNSText.TabIndex = 17;
            this.DNSText.TabStop = false;
            this.DNSText.UseSystemPasswordChar = false;
            // 
            // buttonDefault
            // 
            this.buttonDefault.AutoSize = true;
            this.buttonDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDefault.Depth = 0;
            this.buttonDefault.Icon = null;
            this.buttonDefault.Location = new System.Drawing.Point(77, 9);
            this.buttonDefault.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDefault.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Primary = false;
            this.buttonDefault.Size = new System.Drawing.Size(107, 36);
            this.buttonDefault.TabIndex = 16;
            this.buttonDefault.Text = "Set Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNS";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(728, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(0, 56, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Socks5ProxyGroup.ResumeLayout(false);
            this.Socks5ProxyGroup.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumS5Port)).EndInit();
            this.ListenGroup.ResumeLayout(false);
            this.ListenGroup.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumProxyPort)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumReconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Socks5ProxyGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MaterialSingleLineTextField TextS5Pass;
        private MaterialSingleLineTextField TextS5User;
        private System.Windows.Forms.Label LabelS5Password;
        private System.Windows.Forms.Label LabelS5Server;
        private System.Windows.Forms.Label LabelS5Port;
        private MaterialSingleLineTextField TextS5Server;
        private System.Windows.Forms.NumericUpDown NumS5Port;
        private System.Windows.Forms.Label LabelS5Username;
        private MaterialCheckBox CheckSockProxy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialFlatButton MyCancelButton;
        private MaterialFlatButton OKButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown NumProxyPort;
        private System.Windows.Forms.Label ProxyPortLabel;
        private System.Windows.Forms.Label ReconnectLabel;
        private System.Windows.Forms.NumericUpDown NumReconnect;
        private System.Windows.Forms.Label TTLLabel;
        private System.Windows.Forms.NumericUpDown NumTTL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelRandom;
        private System.Windows.Forms.ComboBox RandomComboBox;
        private MaterialCheckBox CheckAutoBan;
        private MaterialCheckBox checkRandom;
        private MaterialCheckBox checkAutoStartup;
        private MaterialCheckBox checkShareOverLan;
        private System.Windows.Forms.ComboBox comboProxyType;
        private System.Windows.Forms.GroupBox ListenGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSingleLineTextField TextAuthPass;
        private System.Windows.Forms.Label LabelAuthPass;
        private MaterialSingleLineTextField TextAuthUser;
        private System.Windows.Forms.Label LabelAuthUser;
        private MaterialCheckBox checkBoxPacProxy;
        private System.Windows.Forms.Label label1;
        private MaterialSingleLineTextField TextUserAgent;
        private System.Windows.Forms.Label label2;
        private MaterialSingleLineTextField DNSText;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.NumericUpDown NumTimeout;
        private MaterialFlatButton buttonDefault;
        private MaterialCheckBox checkBalanceInGroup;
    }
}