using MaterialSkin.Controls;

namespace Shadowsocks.View
{
    partial class InputPassword
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
            this.textPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPassword
            // 
            this.textPassword.Depth = 0;
            this.textPassword.Hint = "";
            this.textPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textPassword.Location = new System.Drawing.Point(31, 108);
            this.textPassword.MaxLength = 32767;
            this.textPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.Size = new System.Drawing.Size(373, 23);
            this.textPassword.TabIndex = 0;
            this.textPassword.TabStop = false;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOK.Depth = 0;
            this.buttonOK.Icon = null;
            this.buttonOK.Location = new System.Drawing.Point(381, 153);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Primary = false;
            this.buttonOK.Size = new System.Drawing.Size(39, 36);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.Transparent;
            this.label_info.Location = new System.Drawing.Point(28, 91);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(345, 14);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "Parse gui-config.json error, maybe require password to decrypt";
            // 
            // InputPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(448, 224);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textPassword);
            this.Font = new System.Drawing.Font("Roboto", 9F);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputPassword";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputPassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSingleLineTextField textPassword;
        private MaterialFlatButton buttonOK;
        private System.Windows.Forms.Label label_info;
    }
}