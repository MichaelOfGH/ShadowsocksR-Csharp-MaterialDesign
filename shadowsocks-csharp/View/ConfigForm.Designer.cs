using MaterialSkin.Controls;

namespace Shadowsocks.View
{
    partial class ConfigForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.AddButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PictureQRcode = new System.Windows.Forms.PictureBox();
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ObfsCombo = new System.Windows.Forms.ComboBox();
            this.labelObfs = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NumServerPort = new System.Windows.Forms.NumericUpDown();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EncryptionLabel = new System.Windows.Forms.Label();
            this.EncryptionSelect = new System.Windows.Forms.ComboBox();
            this.TextLink = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RemarksTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ObfsUDPLabel = new System.Windows.Forms.Label();
            this.CheckObfsUDP = new MaterialCheckBox();
            this.TCPProtocolLabel = new System.Windows.Forms.Label();
            this.UDPoverTCPLabel = new System.Windows.Forms.Label();
            this.CheckUDPoverUDP = new MaterialCheckBox();
            this.LabelNote = new System.Windows.Forms.Label();
            this.PasswordLabel = new MaterialCheckBox();
            this.TCPoverUDPLabel = new System.Windows.Forms.Label();
            this.CheckTCPoverUDP = new MaterialCheckBox();
            this.TCPProtocolComboBox = new System.Windows.Forms.ComboBox();
            this.labelObfsParam = new System.Windows.Forms.Label();
            this.TextObfsParam = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelGroup = new System.Windows.Forms.Label();
            this.TextGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkAdvSetting = new MaterialCheckBox();
            this.labelUDPPort = new System.Windows.Forms.Label();
            this.NumUDPPort = new System.Windows.Forms.NumericUpDown();
            this.checkSSRLink = new MaterialCheckBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.labelProtocolParam = new System.Windows.Forms.Label();
            this.TextProtocolParam = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.IPLabel = new MaterialCheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.LinkUpdate = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DownButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.UpButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MyCancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OKButton = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQRcode)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.ServerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPPort)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(342, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(172, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = false;
            this.DeleteButton.Size = new System.Drawing.Size(78, 36);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = false;
            this.AddButton.Size = new System.Drawing.Size(57, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PictureQRcode
            // 
            this.PictureQRcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureQRcode.BackColor = System.Drawing.SystemColors.Control;
            this.PictureQRcode.Location = new System.Drawing.Point(4, 147);
            this.PictureQRcode.Margin = new System.Windows.Forms.Padding(4);
            this.PictureQRcode.Name = "PictureQRcode";
            this.PictureQRcode.Size = new System.Drawing.Size(260, 200);
            this.PictureQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureQRcode.TabIndex = 13;
            this.PictureQRcode.TabStop = false;
            // 
            // ServersListBox
            // 
            this.ServersListBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ServersListBox.ItemHeight = 14;
            this.ServersListBox.Location = new System.Drawing.Point(0, 0);
            this.ServersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ServersListBox.Size = new System.Drawing.Size(250, 284);
            this.ServersListBox.TabIndex = 0;
            this.ServersListBox.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ServerGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(904, 546);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.AutoSize = true;
            this.ServerGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServerGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ServerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerGroupBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ServerGroupBox.Location = new System.Drawing.Point(268, 0);
            this.ServerGroupBox.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Size = new System.Drawing.Size(353, 501);
            this.ServerGroupBox.TabIndex = 20;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "Server";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ObfsCombo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelObfs, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IPTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumServerPort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionSelect, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextLink, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.RemarksTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.ObfsUDPLabel, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.CheckObfsUDP, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.TCPProtocolLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.UDPoverTCPLabel, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.CheckUDPoverUDP, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.LabelNote, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TCPoverUDPLabel, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.CheckTCPoverUDP, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.TCPProtocolComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelObfsParam, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.TextObfsParam, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelGroup, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.TextGroup, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.checkAdvSetting, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.labelUDPPort, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.NumUDPPort, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.checkSSRLink, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelRemarks, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelProtocolParam, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.TextProtocolParam, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.IPLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 18;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 451);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ObfsCombo
            // 
            this.ObfsCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ObfsCombo.FormattingEnabled = true;
            this.ObfsCombo.Items.AddRange(new object[] {
            "plain",
            "http_simple",
            "http_post",
            "random_head",
            "tls1.2_ticket_auth",
            "tls1.2_ticket_fastauth"});
            this.ObfsCombo.Location = new System.Drawing.Point(103, 181);
            this.ObfsCombo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.ObfsCombo.Name = "ObfsCombo";
            this.ObfsCombo.Size = new System.Drawing.Size(233, 22);
            this.ObfsCombo.TabIndex = 19;
            this.ObfsCombo.TextChanged += new System.EventHandler(this.ObfsCombo_TextChanged);
            // 
            // labelObfs
            // 
            this.labelObfs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelObfs.AutoSize = true;
            this.labelObfs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelObfs.Location = new System.Drawing.Point(65, 186);
            this.labelObfs.Name = "labelObfs";
            this.labelObfs.Size = new System.Drawing.Size(32, 14);
            this.labelObfs.TabIndex = 18;
            this.labelObfs.Text = "Obfs";
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(31, 39);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(66, 14);
            this.ServerPortLabel.TabIndex = 8;
            this.ServerPortLabel.Text = "Server Port";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Depth = 0;
            this.IPTextBox.Hint = "";
            this.IPTextBox.Location = new System.Drawing.Point(103, 6);
            this.IPTextBox.MaxLength = 512;
            this.IPTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.PasswordChar = '\0';
            this.IPTextBox.SelectedText = "";
            this.IPTextBox.SelectionLength = 0;
            this.IPTextBox.SelectionStart = 0;
            this.IPTextBox.Size = new System.Drawing.Size(233, 23);
            this.IPTextBox.TabIndex = 7;
            this.IPTextBox.TabStop = false;
            this.IPTextBox.UseSystemPasswordChar = true;
            // 
            // NumServerPort
            // 
            this.NumServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumServerPort.Location = new System.Drawing.Point(103, 35);
            this.NumServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumServerPort.Name = "NumServerPort";
            this.NumServerPort.Size = new System.Drawing.Size(233, 22);
            this.NumServerPort.TabIndex = 9;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Hint = "";
            this.PasswordTextBox.Location = new System.Drawing.Point(103, 63);
            this.PasswordTextBox.MaxLength = 256;
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.Size = new System.Drawing.Size(233, 23);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EncryptionLabel
            // 
            this.EncryptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EncryptionLabel.AutoSize = true;
            this.EncryptionLabel.Location = new System.Drawing.Point(32, 97);
            this.EncryptionLabel.Name = "EncryptionLabel";
            this.EncryptionLabel.Size = new System.Drawing.Size(65, 14);
            this.EncryptionLabel.TabIndex = 12;
            this.EncryptionLabel.Text = "Encryption";
            // 
            // EncryptionSelect
            // 
            this.EncryptionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptionSelect.FormattingEnabled = true;
            this.EncryptionSelect.Location = new System.Drawing.Point(103, 92);
            this.EncryptionSelect.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.EncryptionSelect.Name = "EncryptionSelect";
            this.EncryptionSelect.Size = new System.Drawing.Size(233, 22);
            this.EncryptionSelect.TabIndex = 13;
            // 
            // TextLink
            // 
            this.TextLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLink.Depth = 0;
            this.TextLink.Hint = "";
            this.TextLink.Location = new System.Drawing.Point(103, 298);
            this.TextLink.MaxLength = 32767;
            this.TextLink.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextLink.Name = "TextLink";
            this.TextLink.PasswordChar = '\0';
            this.TextLink.SelectedText = "";
            this.TextLink.SelectionLength = 0;
            this.TextLink.SelectionStart = 0;
            this.TextLink.Size = new System.Drawing.Size(233, 23);
            this.TextLink.TabIndex = 27;
            this.TextLink.TabStop = false;
            this.TextLink.UseSystemPasswordChar = false;
            this.TextLink.Enter += new System.EventHandler(this.TextBox_Enter);
            this.TextLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseUp);
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksTextBox.Depth = 0;
            this.RemarksTextBox.Hint = "";
            this.RemarksTextBox.Location = new System.Drawing.Point(103, 240);
            this.RemarksTextBox.MaxLength = 256;
            this.RemarksTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.PasswordChar = '\0';
            this.RemarksTextBox.SelectedText = "";
            this.RemarksTextBox.SelectionLength = 0;
            this.RemarksTextBox.SelectionStart = 0;
            this.RemarksTextBox.Size = new System.Drawing.Size(233, 23);
            this.RemarksTextBox.TabIndex = 23;
            this.RemarksTextBox.TabStop = false;
            this.RemarksTextBox.UseSystemPasswordChar = false;
            // 
            // ObfsUDPLabel
            // 
            this.ObfsUDPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ObfsUDPLabel.AutoSize = true;
            this.ObfsUDPLabel.Location = new System.Drawing.Point(38, 429);
            this.ObfsUDPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ObfsUDPLabel.Name = "ObfsUDPLabel";
            this.ObfsUDPLabel.Size = new System.Drawing.Size(59, 14);
            this.ObfsUDPLabel.TabIndex = 36;
            this.ObfsUDPLabel.Text = "Obfs UDP";
            this.ObfsUDPLabel.Visible = false;
            // 
            // CheckObfsUDP
            // 
            this.CheckObfsUDP.AutoSize = true;
            this.CheckObfsUDP.Location = new System.Drawing.Point(103, 427);
            this.CheckObfsUDP.Name = "CheckObfsUDP";
            this.CheckObfsUDP.Size = new System.Drawing.Size(140, 18);
            this.CheckObfsUDP.TabIndex = 37;
            this.CheckObfsUDP.Text = "Recommend checked";
            this.CheckObfsUDP.UseVisualStyleBackColor = true;
            this.CheckObfsUDP.Visible = false;
            // 
            // TCPProtocolLabel
            // 
            this.TCPProtocolLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TCPProtocolLabel.AutoSize = true;
            this.TCPProtocolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TCPProtocolLabel.Location = new System.Drawing.Point(44, 127);
            this.TCPProtocolLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TCPProtocolLabel.Name = "TCPProtocolLabel";
            this.TCPProtocolLabel.Size = new System.Drawing.Size(53, 14);
            this.TCPProtocolLabel.TabIndex = 14;
            this.TCPProtocolLabel.Text = "Protocol";
            // 
            // UDPoverTCPLabel
            // 
            this.UDPoverTCPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UDPoverTCPLabel.AutoSize = true;
            this.UDPoverTCPLabel.Location = new System.Drawing.Point(14, 405);
            this.UDPoverTCPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UDPoverTCPLabel.Name = "UDPoverTCPLabel";
            this.UDPoverTCPLabel.Size = new System.Drawing.Size(83, 14);
            this.UDPoverTCPLabel.TabIndex = 34;
            this.UDPoverTCPLabel.Text = "UDP over TCP";
            this.UDPoverTCPLabel.Visible = false;
            // 
            // CheckUDPoverUDP
            // 
            this.CheckUDPoverUDP.AutoSize = true;
            this.CheckUDPoverUDP.Location = new System.Drawing.Point(103, 403);
            this.CheckUDPoverUDP.Name = "CheckUDPoverUDP";
            this.CheckUDPoverUDP.Size = new System.Drawing.Size(181, 18);
            this.CheckUDPoverUDP.TabIndex = 35;
            this.CheckUDPoverUDP.Text = "UDP over UDP if not checked";
            this.CheckUDPoverUDP.UseVisualStyleBackColor = true;
            this.CheckUDPoverUDP.Visible = false;
            // 
            // LabelNote
            // 
            this.LabelNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNote.AutoSize = true;
            this.LabelNote.Location = new System.Drawing.Point(105, 329);
            this.LabelNote.Margin = new System.Windows.Forms.Padding(5);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(167, 14);
            this.LabelNote.TabIndex = 29;
            this.LabelNote.Text = "NOT all server support belows";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(17, 65);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(80, 18);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.UseVisualStyleBackColor = true;
            this.PasswordLabel.CheckedChanged += new System.EventHandler(this.PasswordLabel_CheckedChanged);
            // 
            // TCPoverUDPLabel
            // 
            this.TCPoverUDPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TCPoverUDPLabel.AutoSize = true;
            this.TCPoverUDPLabel.Location = new System.Drawing.Point(14, 381);
            this.TCPoverUDPLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TCPoverUDPLabel.Name = "TCPoverUDPLabel";
            this.TCPoverUDPLabel.Size = new System.Drawing.Size(83, 14);
            this.TCPoverUDPLabel.TabIndex = 32;
            this.TCPoverUDPLabel.Text = "TCP over UDP";
            this.TCPoverUDPLabel.Visible = false;
            // 
            // CheckTCPoverUDP
            // 
            this.CheckTCPoverUDP.AutoSize = true;
            this.CheckTCPoverUDP.Location = new System.Drawing.Point(103, 379);
            this.CheckTCPoverUDP.Name = "CheckTCPoverUDP";
            this.CheckTCPoverUDP.Size = new System.Drawing.Size(179, 18);
            this.CheckTCPoverUDP.TabIndex = 33;
            this.CheckTCPoverUDP.Text = "TCP over TCP if not checked";
            this.CheckTCPoverUDP.UseVisualStyleBackColor = true;
            this.CheckTCPoverUDP.Visible = false;
            // 
            // TCPProtocolComboBox
            // 
            this.TCPProtocolComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TCPProtocolComboBox.FormattingEnabled = true;
            this.TCPProtocolComboBox.Items.AddRange(new object[] {
            "origin",
            "verify_deflate",
            "auth_sha1_v4",
            "auth_aes128_md5",
            "auth_aes128_sha1",
            "auth_chain_a",
            "auth_chain_b"});
            this.TCPProtocolComboBox.Location = new System.Drawing.Point(103, 122);
            this.TCPProtocolComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.TCPProtocolComboBox.Name = "TCPProtocolComboBox";
            this.TCPProtocolComboBox.Size = new System.Drawing.Size(233, 22);
            this.TCPProtocolComboBox.TabIndex = 15;
            // 
            // labelObfsParam
            // 
            this.labelObfsParam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelObfsParam.AutoSize = true;
            this.labelObfsParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelObfsParam.Location = new System.Drawing.Point(27, 215);
            this.labelObfsParam.Name = "labelObfsParam";
            this.labelObfsParam.Size = new System.Drawing.Size(70, 14);
            this.labelObfsParam.TabIndex = 20;
            this.labelObfsParam.Text = "Obfs param";
            // 
            // TextObfsParam
            // 
            this.TextObfsParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextObfsParam.Depth = 0;
            this.TextObfsParam.Hint = "";
            this.TextObfsParam.Location = new System.Drawing.Point(103, 211);
            this.TextObfsParam.MaxLength = 32767;
            this.TextObfsParam.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextObfsParam.Name = "TextObfsParam";
            this.TextObfsParam.PasswordChar = '\0';
            this.TextObfsParam.SelectedText = "";
            this.TextObfsParam.SelectionLength = 0;
            this.TextObfsParam.SelectionStart = 0;
            this.TextObfsParam.Size = new System.Drawing.Size(233, 23);
            this.TextObfsParam.TabIndex = 21;
            this.TextObfsParam.TabStop = false;
            this.TextObfsParam.UseSystemPasswordChar = false;
            // 
            // labelGroup
            // 
            this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(57, 273);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(40, 14);
            this.labelGroup.TabIndex = 24;
            this.labelGroup.Text = "Group";
            // 
            // TextGroup
            // 
            this.TextGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextGroup.Depth = 0;
            this.TextGroup.Hint = "";
            this.TextGroup.Location = new System.Drawing.Point(103, 269);
            this.TextGroup.MaxLength = 64;
            this.TextGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.PasswordChar = '\0';
            this.TextGroup.SelectedText = "";
            this.TextGroup.SelectionLength = 0;
            this.TextGroup.SelectionStart = 0;
            this.TextGroup.Size = new System.Drawing.Size(233, 23);
            this.TextGroup.TabIndex = 25;
            this.TextGroup.TabStop = false;
            this.TextGroup.UseSystemPasswordChar = false;
            // 
            // checkAdvSetting
            // 
            this.checkAdvSetting.AutoSize = true;
            this.checkAdvSetting.Location = new System.Drawing.Point(6, 327);
            this.checkAdvSetting.Name = "checkAdvSetting";
            this.checkAdvSetting.Size = new System.Drawing.Size(91, 18);
            this.checkAdvSetting.TabIndex = 28;
            this.checkAdvSetting.Text = "Adv. Setting";
            this.checkAdvSetting.UseVisualStyleBackColor = true;
            this.checkAdvSetting.CheckedChanged += new System.EventHandler(this.checkAdvSetting_CheckedChanged);
            // 
            // labelUDPPort
            // 
            this.labelUDPPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUDPPort.AutoSize = true;
            this.labelUDPPort.Location = new System.Drawing.Point(40, 355);
            this.labelUDPPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelUDPPort.Name = "labelUDPPort";
            this.labelUDPPort.Size = new System.Drawing.Size(57, 14);
            this.labelUDPPort.TabIndex = 30;
            this.labelUDPPort.Text = "UDP Port";
            this.labelUDPPort.Visible = false;
            // 
            // NumUDPPort
            // 
            this.NumUDPPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NumUDPPort.Location = new System.Drawing.Point(103, 351);
            this.NumUDPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumUDPPort.Name = "NumUDPPort";
            this.NumUDPPort.Size = new System.Drawing.Size(233, 22);
            this.NumUDPPort.TabIndex = 31;
            this.NumUDPPort.Visible = false;
            // 
            // checkSSRLink
            // 
            this.checkSSRLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkSSRLink.AutoSize = true;
            this.checkSSRLink.Checked = true;
            this.checkSSRLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSSRLink.Location = new System.Drawing.Point(23, 300);
            this.checkSSRLink.Name = "checkSSRLink";
            this.checkSSRLink.Size = new System.Drawing.Size(74, 18);
            this.checkSSRLink.TabIndex = 26;
            this.checkSSRLink.Text = "SSR Link";
            this.checkSSRLink.UseVisualStyleBackColor = true;
            this.checkSSRLink.CheckedChanged += new System.EventHandler(this.checkSSRLink_CheckedChanged);
            // 
            // labelRemarks
            // 
            this.labelRemarks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(43, 244);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(54, 14);
            this.labelRemarks.TabIndex = 22;
            this.labelRemarks.Text = "Remarks";
            // 
            // labelProtocolParam
            // 
            this.labelProtocolParam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelProtocolParam.AutoSize = true;
            this.labelProtocolParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelProtocolParam.Location = new System.Drawing.Point(6, 156);
            this.labelProtocolParam.Name = "labelProtocolParam";
            this.labelProtocolParam.Size = new System.Drawing.Size(91, 14);
            this.labelProtocolParam.TabIndex = 16;
            this.labelProtocolParam.Text = "Protocol param";
            // 
            // TextProtocolParam
            // 
            this.TextProtocolParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextProtocolParam.Depth = 0;
            this.TextProtocolParam.Hint = "";
            this.TextProtocolParam.Location = new System.Drawing.Point(103, 152);
            this.TextProtocolParam.MaxLength = 32767;
            this.TextProtocolParam.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextProtocolParam.Name = "TextProtocolParam";
            this.TextProtocolParam.PasswordChar = '\0';
            this.TextProtocolParam.SelectedText = "";
            this.TextProtocolParam.SelectionLength = 0;
            this.TextProtocolParam.SelectionStart = 0;
            this.TextProtocolParam.Size = new System.Drawing.Size(233, 23);
            this.TextProtocolParam.TabIndex = 17;
            this.TextProtocolParam.TabStop = false;
            this.TextProtocolParam.UseSystemPasswordChar = false;
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(24, 8);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(73, 18);
            this.IPLabel.TabIndex = 38;
            this.IPLabel.Text = "Server IP";
            this.IPLabel.UseVisualStyleBackColor = true;
            this.IPLabel.CheckedChanged += new System.EventHandler(this.IPLabel_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.ServersListBox, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.LinkUpdate, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel7, 2);
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(250, 540);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // LinkUpdate
            // 
            this.LinkUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinkUpdate.AutoSize = true;
            this.LinkUpdate.Location = new System.Drawing.Point(63, 443);
            this.LinkUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.LinkUpdate.Name = "LinkUpdate";
            this.LinkUpdate.Size = new System.Drawing.Size(124, 14);
            this.LinkUpdate.TabIndex = 5;
            this.LinkUpdate.TabStop = true;
            this.LinkUpdate.Text = "New version available";
            this.LinkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUpdate_LinkClicked);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.DownButton, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.UpButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.DeleteButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 289);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(250, 72);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // DownButton
            // 
            this.DownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownButton.AutoSize = true;
            this.DownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownButton.Depth = 0;
            this.DownButton.Icon = null;
            this.DownButton.Location = new System.Drawing.Point(189, 36);
            this.DownButton.Margin = new System.Windows.Forms.Padding(0);
            this.DownButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownButton.Name = "DownButton";
            this.DownButton.Primary = false;
            this.DownButton.Size = new System.Drawing.Size(61, 36);
            this.DownButton.TabIndex = 4;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.AutoSize = true;
            this.UpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpButton.Depth = 0;
            this.UpButton.Icon = null;
            this.UpButton.Location = new System.Drawing.Point(0, 36);
            this.UpButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpButton.Name = "UpButton";
            this.UpButton.Primary = false;
            this.UpButton.Size = new System.Drawing.Size(39, 36);
            this.UpButton.TabIndex = 3;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.PictureQRcode, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(633, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(268, 495);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(259, 504);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(362, 39);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyCancelButton.AutoSize = true;
            this.MyCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MyCancelButton.Depth = 0;
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Icon = null;
            this.MyCancelButton.Location = new System.Drawing.Point(289, 3);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.MyCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Primary = false;
            this.MyCancelButton.Size = new System.Drawing.Size(73, 36);
            this.MyCancelButton.TabIndex = 39;
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
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(3, 3);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.Primary = false;
            this.OKButton.Size = new System.Drawing.Size(39, 36);
            this.OKButton.TabIndex = 38;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 564);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(0, 56, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Servers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureQRcode)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ServerGroupBox.ResumeLayout(false);
            this.ServerGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDPPort)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private MaterialFlatButton DeleteButton;
        private MaterialFlatButton AddButton;
        private System.Windows.Forms.ListBox ServersListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialFlatButton DownButton;
        private MaterialFlatButton UpButton;
        private System.Windows.Forms.PictureBox PictureQRcode;
        private System.Windows.Forms.LinkLabel LinkUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox ObfsCombo;
        private System.Windows.Forms.Label labelObfs;
        private System.Windows.Forms.Label ServerPortLabel;
        private MaterialSingleLineTextField IPTextBox;
        private System.Windows.Forms.NumericUpDown NumServerPort;
        private MaterialSingleLineTextField PasswordTextBox;
        private System.Windows.Forms.Label EncryptionLabel;
        private System.Windows.Forms.ComboBox EncryptionSelect;
        private MaterialSingleLineTextField TextLink;
        private MaterialSingleLineTextField RemarksTextBox;
        private System.Windows.Forms.Label ObfsUDPLabel;
        private MaterialCheckBox CheckObfsUDP;
        private System.Windows.Forms.Label TCPProtocolLabel;
        private System.Windows.Forms.Label UDPoverTCPLabel;
        private MaterialCheckBox CheckUDPoverUDP;
        private System.Windows.Forms.Label LabelNote;
        private MaterialCheckBox PasswordLabel;
        private System.Windows.Forms.Label TCPoverUDPLabel;
        private MaterialCheckBox CheckTCPoverUDP;
        private System.Windows.Forms.ComboBox TCPProtocolComboBox;
        private System.Windows.Forms.Label labelObfsParam;
        private MaterialSingleLineTextField TextObfsParam;
        private System.Windows.Forms.Label labelGroup;
        private MaterialSingleLineTextField TextGroup;
        private MaterialCheckBox checkAdvSetting;
        private System.Windows.Forms.Label labelUDPPort;
        private System.Windows.Forms.NumericUpDown NumUDPPort;
        private MaterialCheckBox checkSSRLink;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialFlatButton MyCancelButton;
        private MaterialFlatButton OKButton;
        private System.Windows.Forms.Label labelProtocolParam;
        private MaterialSingleLineTextField TextProtocolParam;
        private MaterialCheckBox IPLabel;
    }
}

