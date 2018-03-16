namespace PrinterManager
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            this.btn_Print = new CCWin.SkinControl.SkinButton();
            this.btn_QrQuit = new CCWin.SkinControl.SkinButton();
            this.PDFView = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PDFView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Print.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btn_Print.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Print.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Print.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_Print.DownBack")));
            this.btn_Print.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Print.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Print.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(162, 687);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Print.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_Print.MouseBack")));
            this.btn_Print.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_Print.NormlBack")));
            this.btn_Print.Radius = 16;
            this.btn_Print.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_Print.Size = new System.Drawing.Size(100, 37);
            this.btn_Print.TabIndex = 50;
            this.btn_Print.Text = "打 印";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.Btn_OnePrint_Click);
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
            this.btn_QrQuit.Location = new System.Drawing.Point(480, 687);
            this.btn_QrQuit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_QrQuit.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_QrQuit.MouseBack")));
            this.btn_QrQuit.Name = "btn_QrQuit";
            this.btn_QrQuit.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_QrQuit.NormlBack")));
            this.btn_QrQuit.Radius = 16;
            this.btn_QrQuit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_QrQuit.Size = new System.Drawing.Size(100, 37);
            this.btn_QrQuit.TabIndex = 49;
            this.btn_QrQuit.Text = "返 回";
            this.btn_QrQuit.UseVisualStyleBackColor = false;
            this.btn_QrQuit.Click += new System.EventHandler(this.Btn_return_Click);
            // 
            // PDFView
            // 
            this.PDFView.Enabled = true;
            this.PDFView.Location = new System.Drawing.Point(45, 20);
            this.PDFView.Name = "PDFView";
            this.PDFView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFView.OcxState")));
            this.PDFView.Size = new System.Drawing.Size(663, 639);
            this.PDFView.TabIndex = 51;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(750, 750);
            this.ControlBox = false;
            this.Controls.Add(this.PDFView);
            this.Controls.Add(this.btn_QrQuit);
            this.Controls.Add(this.btn_Print);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmView";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDFView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton btn_Print;
        private CCWin.SkinControl.SkinButton btn_QrQuit;
        private AxAcroPDFLib.AxAcroPDF PDFView;
    }
}