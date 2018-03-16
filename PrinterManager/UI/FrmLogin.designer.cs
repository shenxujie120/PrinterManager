namespace PrinterManager
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnDl = new CCWin.SkinControl.SkinButton();
            this.btnSw = new CCWin.SkinControl.SkinButton();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtRandcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDl
            // 
            this.btnDl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDl.BackColor = System.Drawing.Color.Transparent;
            this.btnDl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDl.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnDl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnDl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDl.DownBack = ((System.Drawing.Image)(resources.GetObject("btnDl.DownBack")));
            this.btnDl.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnDl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnDl.ForeColor = System.Drawing.Color.White;
            this.btnDl.Location = new System.Drawing.Point(40, 286);
            this.btnDl.Margin = new System.Windows.Forms.Padding(0);
            this.btnDl.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnDl.MouseBack")));
            this.btnDl.Name = "btnDl";
            this.btnDl.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnDl.NormlBack")));
            this.btnDl.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnDl.Size = new System.Drawing.Size(216, 30);
            this.btnDl.TabIndex = 4;
            this.btnDl.Text = "随机码 打印";
            this.btnDl.UseVisualStyleBackColor = false;
            this.btnDl.Click += new System.EventHandler(this.BtnDl_Click);
            // 
            // btnSw
            // 
            this.btnSw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSw.BackColor = System.Drawing.Color.Transparent;
            this.btnSw.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnSw.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSw.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSw.DownBack")));
            this.btnSw.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSw.Location = new System.Drawing.Point(280, 199);
            this.btnSw.Margin = new System.Windows.Forms.Padding(0);
            this.btnSw.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSw.MouseBack")));
            this.btnSw.Name = "btnSw";
            this.btnSw.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSw.NormlBack")));
            this.btnSw.Size = new System.Drawing.Size(87, 117);
            this.btnSw.TabIndex = 45;
            this.btnSw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSw.UseVisualStyleBackColor = false;
            this.btnSw.Click += new System.EventHandler(this.btnSw_Click);
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtphone.Location = new System.Drawing.Point(111, 199);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(145, 29);
            this.txtphone.TabIndex = 46;
            this.txtphone.Click += new System.EventHandler(this.TxtId_Click);
            // 
            // txtRandcode
            // 
            this.txtRandcode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRandcode.Location = new System.Drawing.Point(111, 243);
            this.txtRandcode.Name = "txtRandcode";
            this.txtRandcode.Size = new System.Drawing.Size(145, 29);
            this.txtRandcode.TabIndex = 47;
            this.txtRandcode.Click += new System.EventHandler(this.TxtPwd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "手机号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "随机码";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackShade = false;
            this.BackToColor = false;
            this.CanResize = false;
            this.CaptionHeight = 30;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.CloseBoxSize = new System.Drawing.Size(35, 35);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRandcode);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.btnSw);
            this.Controls.Add(this.btnDl);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MobileApi = false;
            this.Name = "FrmLogin";
            this.Radius = 5;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnDl;
        private CCWin.SkinControl.SkinButton btnSw;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtRandcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}