namespace PrinterManager
{
    partial class FrmResultInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox_Instro = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox_View = new System.Windows.Forms.GroupBox();
            this.Pic_view = new AxAcroPDFLib.AxAcroPDF();
            this.Pic_title = new System.Windows.Forms.PictureBox();
            this.Btn_Print = new CCWin.SkinControl.SkinButton();
            this.Btn_Quit = new CCWin.SkinControl.SkinButton();
            this.Txt_PrinterStatus = new System.Windows.Forms.TextBox();
            this.Txt_CreateTime = new System.Windows.Forms.TextBox();
            this.Txt_ResultNo = new System.Windows.Forms.TextBox();
            this.GroupBox_Instro.SuspendLayout();
            this.GroupBox_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_title)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(180, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "打印状态";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(180, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "生成时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(180, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "证书编号";
            // 
            // GroupBox_Instro
            // 
            this.GroupBox_Instro.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_Instro.Controls.Add(this.label7);
            this.GroupBox_Instro.Controls.Add(this.label5);
            this.GroupBox_Instro.Controls.Add(this.label4);
            this.GroupBox_Instro.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox_Instro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupBox_Instro.Location = new System.Drawing.Point(434, 28);
            this.GroupBox_Instro.Name = "GroupBox_Instro";
            this.GroupBox_Instro.Size = new System.Drawing.Size(254, 127);
            this.GroupBox_Instro.TabIndex = 3;
            this.GroupBox_Instro.TabStop = false;
            this.GroupBox_Instro.Text = "说明";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "* 确认无误后方可“打印”";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "* 下方缩略图区域会显示您的成绩单";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "* 确认您要查询的成绩单内容";
            // 
            // GroupBox_View
            // 
            this.GroupBox_View.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_View.Controls.Add(this.Pic_view);
            this.GroupBox_View.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroupBox_View.Location = new System.Drawing.Point(38, 167);
            this.GroupBox_View.Name = "GroupBox_View";
            this.GroupBox_View.Size = new System.Drawing.Size(650, 538);
            this.GroupBox_View.TabIndex = 4;
            this.GroupBox_View.TabStop = false;
            this.GroupBox_View.Text = "缩略图";
            // 
            // Pic_view
            // 
            this.Pic_view.Enabled = true;
            this.Pic_view.Location = new System.Drawing.Point(19, 25);
            this.Pic_view.Name = "Pic_view";
            this.Pic_view.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Pic_view.OcxState")));
            this.Pic_view.Size = new System.Drawing.Size(611, 495);
            this.Pic_view.TabIndex = 2;
            // 
            // Pic_title
            // 
            this.Pic_title.BackColor = System.Drawing.Color.Transparent;
            this.Pic_title.Location = new System.Drawing.Point(38, 28);
            this.Pic_title.Name = "Pic_title";
            this.Pic_title.Size = new System.Drawing.Size(118, 136);
            this.Pic_title.TabIndex = 11;
            this.Pic_title.TabStop = false;
            // 
            // Btn_Print
            // 
            this.Btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Print.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_Print.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_Print.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Print.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_Print.DownBack")));
            this.Btn_Print.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Print.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_Print.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Print.ForeColor = System.Drawing.Color.White;
            this.Btn_Print.Location = new System.Drawing.Point(184, 717);
            this.Btn_Print.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Print.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_Print.MouseBack")));
            this.Btn_Print.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_Print.NormlBack")));
            this.Btn_Print.Radius = 16;
            this.Btn_Print.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_Print.Size = new System.Drawing.Size(97, 37);
            this.Btn_Print.TabIndex = 50;
            this.Btn_Print.Text = "打印";
            this.Btn_Print.UseVisualStyleBackColor = false;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_print_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Quit.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Quit.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_Quit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_Quit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Quit.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_Quit.DownBack")));
            this.Btn_Quit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_Quit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Quit.ForeColor = System.Drawing.Color.White;
            this.Btn_Quit.Location = new System.Drawing.Point(462, 717);
            this.Btn_Quit.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Quit.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_Quit.MouseBack")));
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_Quit.NormlBack")));
            this.Btn_Quit.Radius = 16;
            this.Btn_Quit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_Quit.Size = new System.Drawing.Size(97, 37);
            this.Btn_Quit.TabIndex = 49;
            this.Btn_Quit.Text = "退 出";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // Txt_PrinterStatus
            // 
            this.Txt_PrinterStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_PrinterStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_PrinterStatus.Location = new System.Drawing.Point(260, 76);
            this.Txt_PrinterStatus.Name = "Txt_PrinterStatus";
            this.Txt_PrinterStatus.Size = new System.Drawing.Size(145, 29);
            this.Txt_PrinterStatus.TabIndex = 12;
            // 
            // Txt_CreateTime
            // 
            this.Txt_CreateTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_CreateTime.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_CreateTime.Location = new System.Drawing.Point(260, 126);
            this.Txt_CreateTime.Name = "Txt_CreateTime";
            this.Txt_CreateTime.Size = new System.Drawing.Size(145, 29);
            this.Txt_CreateTime.TabIndex = 13;
            // 
            // Txt_ResultNo
            // 
            this.Txt_ResultNo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_ResultNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_ResultNo.Location = new System.Drawing.Point(260, 28);
            this.Txt_ResultNo.Name = "Txt_ResultNo";
            this.Txt_ResultNo.Size = new System.Drawing.Size(145, 29);
            this.Txt_ResultNo.TabIndex = 14;
            // 
            // FrmResultInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(720, 767);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_PrinterStatus);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Txt_CreateTime);
            this.Controls.Add(this.Pic_title);
            this.Controls.Add(this.GroupBox_View);
            this.Controls.Add(this.Txt_ResultNo);
            this.Controls.Add(this.GroupBox_Instro);
            this.Controls.Add(this.label3);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MobileApi = false;
            this.Name = "FrmResultInfo";
            this.Radius = 25;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_RusultInfo_Load);
            this.GroupBox_Instro.ResumeLayout(false);
            this.GroupBox_Instro.PerformLayout();
            this.GroupBox_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBox_Instro;
        private System.Windows.Forms.GroupBox GroupBox_View;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Pic_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private AxAcroPDFLib.AxAcroPDF Pic_view;
        private CCWin.SkinControl.SkinButton Btn_Print;
        private CCWin.SkinControl.SkinButton Btn_Quit;
        private System.Windows.Forms.TextBox Txt_PrinterStatus;
        private System.Windows.Forms.TextBox Txt_CreateTime;
        private System.Windows.Forms.TextBox Txt_ResultNo;
    }
}