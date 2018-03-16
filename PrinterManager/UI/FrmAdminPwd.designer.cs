namespace PrinterManager
{
    partial class FrmAdminPwd
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
            this.Lbl_AdminPwdTip = new System.Windows.Forms.Label();
            this.Txt_adminpwd = new System.Windows.Forms.TextBox();
            this.Btn_confirm = new System.Windows.Forms.Button();
            this.Btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_AdminPwdTip
            // 
            this.Lbl_AdminPwdTip.AutoSize = true;
            this.Lbl_AdminPwdTip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_AdminPwdTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_AdminPwdTip.Location = new System.Drawing.Point(23, 21);
            this.Lbl_AdminPwdTip.Name = "Lbl_AdminPwdTip";
            this.Lbl_AdminPwdTip.Size = new System.Drawing.Size(138, 21);
            this.Lbl_AdminPwdTip.TabIndex = 0;
            this.Lbl_AdminPwdTip.Text = "请输入管理员密码";
            // 
            // Txt_adminpwd
            // 
            this.Txt_adminpwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_adminpwd.Location = new System.Drawing.Point(27, 58);
            this.Txt_adminpwd.Name = "Txt_adminpwd";
            this.Txt_adminpwd.PasswordChar = '*';
            this.Txt_adminpwd.Size = new System.Drawing.Size(197, 29);
            this.Txt_adminpwd.TabIndex = 1;
            this.Txt_adminpwd.Click += new System.EventHandler(this.Txt_adminpwd_Click);
            // 
            // Btn_confirm
            // 
            this.Btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_confirm.Location = new System.Drawing.Point(243, 56);
            this.Btn_confirm.Name = "Btn_confirm";
            this.Btn_confirm.Size = new System.Drawing.Size(75, 30);
            this.Btn_confirm.TabIndex = 2;
            this.Btn_confirm.Text = "确认";
            this.Btn_confirm.UseVisualStyleBackColor = true;
            this.Btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // Btn_return
            // 
            this.Btn_return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_return.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_return.Location = new System.Drawing.Point(331, 56);
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.Size = new System.Drawing.Size(75, 30);
            this.Btn_return.TabIndex = 3;
            this.Btn_return.Text = "返回";
            this.Btn_return.UseVisualStyleBackColor = true;
            this.Btn_return.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // FrmAdminPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(429, 118);
            this.Controls.Add(this.Btn_return);
            this.Controls.Add(this.Btn_confirm);
            this.Controls.Add(this.Txt_adminpwd);
            this.Controls.Add(this.Lbl_AdminPwdTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminPwd";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AdminPwdTip;
        private System.Windows.Forms.TextBox Txt_adminpwd;
        private System.Windows.Forms.Button Btn_confirm;
        private System.Windows.Forms.Button Btn_return;
    }
}