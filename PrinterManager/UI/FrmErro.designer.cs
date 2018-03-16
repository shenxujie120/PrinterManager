namespace PrinterManager
{
    partial class FrmErro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmErro));
            this.Btn_Confirm = new CCWin.SkinControl.SkinButton();
            this.Pic_Icon = new CCWin.SkinControl.SkinPictureBox();
            this.Lbl_AnotherTip = new CCWin.SkinControl.SkinLabel();
            this.Lbl_Erro = new CCWin.SkinControl.SkinLabel();
            this.Btn_Return = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Confirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_Confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Confirm.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_Confirm.DownBack")));
            this.Btn_Confirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.Btn_Confirm.Location = new System.Drawing.Point(150, 100);
            this.Btn_Confirm.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_Confirm.MouseBack")));
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_Confirm.NormlBack")));
            this.Btn_Confirm.Palace = true;
            this.Btn_Confirm.Radius = 10;
            this.Btn_Confirm.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_Confirm.Size = new System.Drawing.Size(95, 31);
            this.Btn_Confirm.TabIndex = 38;
            this.Btn_Confirm.Text = "确认";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Pic_Icon
            // 
            this.Pic_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Icon.BackgroundImage = global::PrinterManager.Properties.Resources.Warning;
            this.Pic_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Icon.Location = new System.Drawing.Point(12, 31);
            this.Pic_Icon.Name = "Pic_Icon";
            this.Pic_Icon.Size = new System.Drawing.Size(55, 55);
            this.Pic_Icon.TabIndex = 37;
            this.Pic_Icon.TabStop = false;
            // 
            // Lbl_AnotherTip
            // 
            this.Lbl_AnotherTip.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.Lbl_AnotherTip.AutoSize = true;
            this.Lbl_AnotherTip.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_AnotherTip.BorderColor = System.Drawing.Color.White;
            this.Lbl_AnotherTip.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Lbl_AnotherTip.Location = new System.Drawing.Point(73, 69);
            this.Lbl_AnotherTip.Name = "Lbl_AnotherTip";
            this.Lbl_AnotherTip.Size = new System.Drawing.Size(272, 17);
            this.Lbl_AnotherTip.TabIndex = 36;
            this.Lbl_AnotherTip.Text = "如果您的密码丢失或遗忘，可访问到梦空间官网。";
            // 
            // Lbl_Erro
            // 
            this.Lbl_Erro.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.Lbl_Erro.AutoSize = true;
            this.Lbl_Erro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Erro.BorderColor = System.Drawing.Color.White;
            this.Lbl_Erro.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Erro.Location = new System.Drawing.Point(72, 37);
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(298, 22);
            this.Lbl_Erro.TabIndex = 34;
            this.Lbl_Erro.Text = "您输入的密码不正确，您要找回密码吗？";
            this.Lbl_Erro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Return
            // 
            this.Btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Return.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_Return.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Return.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Return.DownBack = global::PrinterManager.Properties.Resources.btn_quitDown;
            this.Btn_Return.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_Return.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Return.ForeColor = System.Drawing.Color.White;
            this.Btn_Return.Location = new System.Drawing.Point(275, 100);
            this.Btn_Return.MouseBack = global::PrinterManager.Properties.Resources.btn_quitMouse;
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.NormlBack = global::PrinterManager.Properties.Resources.btn_quitnorml;
            this.Btn_Return.Palace = true;
            this.Btn_Return.Radius = 10;
            this.Btn_Return.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_Return.Size = new System.Drawing.Size(95, 31);
            this.Btn_Return.TabIndex = 39;
            this.Btn_Return.Text = "返回";
            this.Btn_Return.UseVisualStyleBackColor = false;
            this.Btn_Return.Visible = false;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // FrmErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(402, 148);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Pic_Icon);
            this.Controls.Add(this.Lbl_AnotherTip);
            this.Controls.Add(this.Lbl_Erro);
            this.DropBack = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InnerBorderColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MobileApi = false;
            this.Name = "FrmErro";
            this.Radius = 16;
            this.Shadow = false;
            this.ShadowColor = System.Drawing.Color.Teal;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmErro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton Btn_Confirm;
        private CCWin.SkinControl.SkinPictureBox Pic_Icon;
        private CCWin.SkinControl.SkinLabel Lbl_AnotherTip;
        private CCWin.SkinControl.SkinLabel Lbl_Erro;
        private CCWin.SkinControl.SkinButton Btn_Return;
    }
}