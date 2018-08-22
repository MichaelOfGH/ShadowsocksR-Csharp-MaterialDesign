﻿using MaterialSkin.Controls;

namespace Shadowsocks.View
{
    partial class PortSettingsForm
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
            this.listPorts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAddr = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.checkEnable = new MaterialSkin.Controls.MaterialCheckBox();
            this.textAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NumTargetPort = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboServers = new System.Windows.Forms.ComboBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.NumLocalPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textRemarks = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.MyCancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Add = new MaterialSkin.Controls.MaterialFlatButton();
            this.Del = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTargetPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLocalPort)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listPorts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listPorts
            // 
            this.listPorts.FormattingEnabled = true;
            this.listPorts.ItemHeight = 12;
            this.listPorts.Location = new System.Drawing.Point(3, 3);
            this.listPorts.Name = "listPorts";
            this.listPorts.Size = new System.Drawing.Size(144, 244);
            this.listPorts.TabIndex = 0;
            this.listPorts.SelectedIndexChanged += new System.EventHandler(this.listPorts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(153, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Setting";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelID, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelAddr, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelPort, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkEnable, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textAddr, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.NumTargetPort, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboServers, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelLocal, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.NumLocalPort, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.textRemarks, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 223);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(45, 37);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 12);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(15, 63);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(59, 12);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Server ID";
            // 
            // labelAddr
            // 
            this.labelAddr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddr.AutoSize = true;
            this.labelAddr.Location = new System.Drawing.Point(3, 117);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(71, 12);
            this.labelAddr.TabIndex = 0;
            this.labelAddr.Text = "Target Addr";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(3, 145);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(71, 12);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Target Port";
            // 
            // checkEnable
            // 
            this.checkEnable.AutoSize = true;
            this.checkEnable.Depth = 0;
            this.checkEnable.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkEnable.Location = new System.Drawing.Point(77, 0);
            this.checkEnable.Margin = new System.Windows.Forms.Padding(0);
            this.checkEnable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkEnable.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkEnable.Name = "checkEnable";
            this.checkEnable.Ripple = true;
            this.checkEnable.Size = new System.Drawing.Size(71, 30);
            this.checkEnable.TabIndex = 3;
            this.checkEnable.Text = "Enable";
            this.checkEnable.UseVisualStyleBackColor = true;
            // 
            // textAddr
            // 
            this.textAddr.Depth = 0;
            this.textAddr.Hint = "";
            this.textAddr.Location = new System.Drawing.Point(80, 112);
            this.textAddr.MaxLength = 32767;
            this.textAddr.MouseState = MaterialSkin.MouseState.HOVER;
            this.textAddr.Name = "textAddr";
            this.textAddr.PasswordChar = '\0';
            this.textAddr.SelectedText = "";
            this.textAddr.SelectionLength = 0;
            this.textAddr.SelectionStart = 0;
            this.textAddr.Size = new System.Drawing.Size(403, 23);
            this.textAddr.TabIndex = 7;
            this.textAddr.TabStop = false;
            this.textAddr.UseSystemPasswordChar = false;
            // 
            // NumTargetPort
            // 
            this.NumTargetPort.Location = new System.Drawing.Point(80, 141);
            this.NumTargetPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumTargetPort.Name = "NumTargetPort";
            this.NumTargetPort.Size = new System.Drawing.Size(403, 21);
            this.NumTargetPort.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Port Forward",
            "Force Proxy",
            "Proxy With Rule"});
            this.comboBoxType.Location = new System.Drawing.Point(80, 33);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(403, 20);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboServers
            // 
            this.comboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServers.FormattingEnabled = true;
            this.comboServers.Location = new System.Drawing.Point(80, 59);
            this.comboServers.Name = "comboServers";
            this.comboServers.Size = new System.Drawing.Size(403, 20);
            this.comboServers.TabIndex = 5;
            // 
            // labelLocal
            // 
            this.labelLocal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(9, 89);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(65, 12);
            this.labelLocal.TabIndex = 0;
            this.labelLocal.Text = "Local Port";
            // 
            // NumLocalPort
            // 
            this.NumLocalPort.Location = new System.Drawing.Point(80, 85);
            this.NumLocalPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumLocalPort.Name = "NumLocalPort";
            this.NumLocalPort.Size = new System.Drawing.Size(403, 21);
            this.NumLocalPort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remarks";
            // 
            // textRemarks
            // 
            this.textRemarks.Depth = 0;
            this.textRemarks.Hint = "";
            this.textRemarks.Location = new System.Drawing.Point(80, 168);
            this.textRemarks.MaxLength = 32767;
            this.textRemarks.MouseState = MaterialSkin.MouseState.HOVER;
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.PasswordChar = '\0';
            this.textRemarks.SelectedText = "";
            this.textRemarks.SelectionLength = 0;
            this.textRemarks.SelectionStart = 0;
            this.textRemarks.Size = new System.Drawing.Size(403, 23);
            this.textRemarks.TabIndex = 9;
            this.textRemarks.TabStop = false;
            this.textRemarks.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(153, 264);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(490, 54);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKButton.Depth = 0;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Icon = null;
            this.OKButton.Location = new System.Drawing.Point(4, 6);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKButton.Name = "OKButton";
            this.OKButton.Primary = false;
            this.OKButton.Size = new System.Drawing.Size(237, 42);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.AutoSize = true;
            this.MyCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MyCancelButton.Depth = 0;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyCancelButton.Icon = null;
            this.MyCancelButton.Location = new System.Drawing.Point(249, 6);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MyCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Primary = false;
            this.MyCancelButton.Size = new System.Drawing.Size(237, 42);
            this.MyCancelButton.TabIndex = 11;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Add, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Del, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(144, 54);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add.Depth = 0;
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Icon = null;
            this.Add.Location = new System.Drawing.Point(4, 6);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.Add.Name = "Add";
            this.Add.Primary = false;
            this.Add.Size = new System.Drawing.Size(136, 15);
            this.Add.TabIndex = 1;
            this.Add.Text = "&Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Del
            // 
            this.Del.AutoSize = true;
            this.Del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Del.Depth = 0;
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Icon = null;
            this.Del.Location = new System.Drawing.Point(4, 33);
            this.Del.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Del.MouseState = MaterialSkin.MouseState.HOVER;
            this.Del.Name = "Del";
            this.Del.Primary = false;
            this.Del.Size = new System.Drawing.Size(136, 15);
            this.Del.TabIndex = 2;
            this.Del.Text = "&Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // PortSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(727, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PortSettingsForm";
            this.Padding = new System.Windows.Forms.Padding(0, 56, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PortMapForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTargetPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLocalPort)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listPorts;
        private MaterialFlatButton OKButton;
        private MaterialFlatButton MyCancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAddr;
        private System.Windows.Forms.Label labelPort;
        private MaterialCheckBox checkEnable;
        private MaterialSingleLineTextField textAddr;
        private System.Windows.Forms.NumericUpDown NumTargetPort;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboServers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.NumericUpDown NumLocalPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialFlatButton Add;
        private MaterialFlatButton Del;
        private System.Windows.Forms.Label label1;
        private MaterialSingleLineTextField textRemarks;
    }
}