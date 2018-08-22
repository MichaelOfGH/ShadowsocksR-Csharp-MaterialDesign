using MaterialSkin.Controls;

namespace Shadowsocks.View
{
    partial class ResetPassword
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
            this.buttonOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.textOld = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textPassword2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOK.Depth = 0;
            this.buttonOK.Icon = null;
            this.buttonOK.Location = new System.Drawing.Point(277, 201);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Primary = false;
            this.buttonOK.Size = new System.Drawing.Size(39, 36);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textOld
            // 
            this.textOld.Depth = 0;
            this.textOld.Hint = "";
            this.textOld.Location = new System.Drawing.Point(28, 87);
            this.textOld.MaxLength = 32767;
            this.textOld.MouseState = MaterialSkin.MouseState.HOVER;
            this.textOld.Name = "textOld";
            this.textOld.PasswordChar = '\0';
            this.textOld.SelectedText = "";
            this.textOld.SelectionLength = 0;
            this.textOld.SelectionStart = 0;
            this.textOld.Size = new System.Drawing.Size(288, 23);
            this.textOld.TabIndex = 0;
            this.textOld.TabStop = false;
            this.textOld.UseSystemPasswordChar = true;
            // 
            // textPassword
            // 
            this.textPassword.Depth = 0;
            this.textPassword.Hint = "";
            this.textPassword.Location = new System.Drawing.Point(28, 116);
            this.textPassword.MaxLength = 32767;
            this.textPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '\0';
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.Size = new System.Drawing.Size(288, 23);
            this.textPassword.TabIndex = 1;
            this.textPassword.TabStop = false;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textPassword2
            // 
            this.textPassword2.Depth = 0;
            this.textPassword2.Hint = "";
            this.textPassword2.Location = new System.Drawing.Point(28, 145);
            this.textPassword2.MaxLength = 32767;
            this.textPassword2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.PasswordChar = '\0';
            this.textPassword2.SelectedText = "";
            this.textPassword2.SelectionLength = 0;
            this.textPassword2.SelectionStart = 0;
            this.textPassword2.Size = new System.Drawing.Size(288, 23);
            this.textPassword2.TabIndex = 2;
            this.textPassword2.TabStop = false;
            this.textPassword2.UseSystemPasswordChar = true;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 256);
            this.Controls.Add(this.textPassword2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textOld);
            this.Controls.Add(this.buttonOK);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "ResetPassword";
            this.Padding = new System.Windows.Forms.Padding(0, 56, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResetPassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialFlatButton buttonOK;
        private MaterialSingleLineTextField textOld;
        private MaterialSingleLineTextField textPassword;
        private MaterialSingleLineTextField textPassword2;
    }
}