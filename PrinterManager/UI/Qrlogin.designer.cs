namespace PrinterManager
{
    partial class Qrlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qrlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_tip = new System.Windows.Forms.Label();
            this.timer_Check = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_yes = new System.Windows.Forms.PictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.btnfreshQrCode = new CCWin.SkinControl.SkinButton();
            this.btn_QrQuit = new CCWin.SkinControl.SkinButton();
            this.btn_Qrlogin = new CCWin.SkinControl.SkinButton();
            this.QrCode_tips = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrCode_tips)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tip.Location = new System.Drawing.Point(118, 264);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(151, 25);
            this.label_tip.TabIndex = 2;
            this.label_tip.Text = "出示 二维码验证";
            // 
            // timer_Check
            // 
            this.timer_Check.Enabled = true;
            this.timer_Check.Interval = 1000;
            this.timer_Check.Tick += new System.EventHandler(this.Timer_Check_Tick);
            // 
            // pictureBox_yes
            // 
            this.pictureBox_yes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_yes.Image = global::PrinterManager.Properties.Resources.QrCodeYes;
            this.pictureBox_yes.InitialImage = null;
            this.pictureBox_yes.Location = new System.Drawing.Point(170, 124);
            this.pictureBox_yes.Name = "pictureBox_yes";
            this.pictureBox_yes.Size = new System.Drawing.Size(37, 42);
            this.pictureBox_yes.TabIndex = 10;
            this.pictureBox_yes.TabStop = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.skinLabel1.Location = new System.Drawing.Point(126, 300);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 13;
            this.skinLabel1.Text = "请使用";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.skinLabel2.Location = new System.Drawing.Point(164, 300);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(92, 17);
            this.skinLabel2.TabIndex = 14;
            this.skinLabel2.Text = "到梦空间客户端";
            // 
            // btnfreshQrCode
            // 
            this.btnfreshQrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnfreshQrCode.BackColor = System.Drawing.Color.Transparent;
            this.btnfreshQrCode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnfreshQrCode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnfreshQrCode.DownBack = ((System.Drawing.Image)(resources.GetObject("btnfreshQrCode.DownBack")));
            this.btnfreshQrCode.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnfreshQrCode.Location = new System.Drawing.Point(157, 115);
            this.btnfreshQrCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnfreshQrCode.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnfreshQrCode.MouseBack")));
            this.btnfreshQrCode.Name = "btnfreshQrCode";
            this.btnfreshQrCode.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnfreshQrCode.NormlBack")));
            this.btnfreshQrCode.Size = new System.Drawing.Size(60, 60);
            this.btnfreshQrCode.TabIndex = 46;
            this.btnfreshQrCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnfreshQrCode.UseVisualStyleBackColor = false;
            // 
            // btn_QrQuit
            // 
            this.btn_QrQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_QrQuit.BackColor = System.Drawing.Color.Salmon;
            this.btn_QrQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QrQuit.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btn_QrQuit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_QrQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_QrQuit.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_QrQuit.DownBack")));
            this.btn_QrQuit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_QrQuit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_QrQuit.ForeColor = System.Drawing.Color.White;
            this.btn_QrQuit.Location = new System.Drawing.Point(332, 261);
            this.btn_QrQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QrQuit.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_QrQuit.MouseBack")));
            this.btn_QrQuit.Name = "btn_QrQuit";
            this.btn_QrQuit.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_QrQuit.NormlBack")));
            this.btn_QrQuit.Radius = 16;
            this.btn_QrQuit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_QrQuit.Size = new System.Drawing.Size(200, 37);
            this.btn_QrQuit.TabIndex = 47;
            this.btn_QrQuit.Text = "退 出";
            this.btn_QrQuit.UseVisualStyleBackColor = false;
            this.btn_QrQuit.Click += new System.EventHandler(this.Btn_QrQuit_Click);
            // 
            // btn_Qrlogin
            // 
            this.btn_Qrlogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Qrlogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Qrlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Qrlogin.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btn_Qrlogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Qrlogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Qrlogin.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_Qrlogin.DownBack")));
            this.btn_Qrlogin.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Qrlogin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Qrlogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Qrlogin.ForeColor = System.Drawing.Color.White;
            this.btn_Qrlogin.Location = new System.Drawing.Point(332, 309);
            this.btn_Qrlogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Qrlogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_Qrlogin.MouseBack")));
            this.btn_Qrlogin.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Qrlogin.Name = "btn_Qrlogin";
            this.btn_Qrlogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_Qrlogin.NormlBack")));
            this.btn_Qrlogin.Radius = 16;
            this.btn_Qrlogin.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_Qrlogin.Size = new System.Drawing.Size(200, 37);
            this.btn_Qrlogin.TabIndex = 48;
            this.btn_Qrlogin.Text = "登  录";
            this.btn_Qrlogin.UseVisualStyleBackColor = false;
            this.btn_Qrlogin.Click += new System.EventHandler(this.Btn_Qrlogin_Click);
            // 
            // QrCode_tips
            // 
            this.QrCode_tips.BackColor = System.Drawing.Color.Transparent;
            this.QrCode_tips.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QrCode_tips.BackgroundImage")));
            this.QrCode_tips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QrCode_tips.Location = new System.Drawing.Point(332, 23);
            this.QrCode_tips.Name = "QrCode_tips";
            this.QrCode_tips.Size = new System.Drawing.Size(200, 224);
            this.QrCode_tips.TabIndex = 49;
            this.QrCode_tips.TabStop = false;
            // 
            // Qrlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackShade = false;
            this.BackToColor = false;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.CloseBoxSize = new System.Drawing.Size(40, 40);
            this.ControlBox = false;
            this.Controls.Add(this.btnfreshQrCode);
            this.Controls.Add(this.btn_Qrlogin);
            this.Controls.Add(this.btn_QrQuit);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.pictureBox_yes);
            this.Controls.Add(this.label_tip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QrCode_tips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Qrlogin";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Qrlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrCode_tips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Timer timer_Check;
        private System.Windows.Forms.PictureBox pictureBox_yes;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton btnfreshQrCode;
        private CCWin.SkinControl.SkinButton btn_QrQuit;
        private CCWin.SkinControl.SkinButton btn_Qrlogin;
        private CCWin.SkinControl.SkinPictureBox QrCode_tips;
    }
}