using CNPOPSOFT.Controls;
namespace PrinterManager.UI
{
    partial class FrmConnectServer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loadingCircle = new CNPOPSOFT.Controls.LoadingCircle();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_dot = new System.Windows.Forms.Timer(this.components);
            this.Timer_total = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingCircle
            // 
            this.loadingCircle.Active = false;
            this.loadingCircle.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle.Color = System.Drawing.Color.DarkOrange;
            this.loadingCircle.ForeColor = System.Drawing.Color.Red;
            this.loadingCircle.InnerCircleRadius = 6;
            this.loadingCircle.Location = new System.Drawing.Point(12, -7);
            this.loadingCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingCircle.Name = "loadingCircle";
            this.loadingCircle.NumberSpoke = 9;
            this.loadingCircle.OuterCircleRadius = 7;
            this.loadingCircle.RotationSpeed = 30;
            this.loadingCircle.Size = new System.Drawing.Size(96, 92);
            this.loadingCircle.SpokeThickness = 4;
            this.loadingCircle.StylePreset = CNPOPSOFT.Controls.LoadingCircle.StylePresets.Firefox;
            this.loadingCircle.TabIndex = 14;
            this.loadingCircle.Text = "loadingCircle";
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_loading.Location = new System.Drawing.Point(134, 32);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(152, 16);
            this.lbl_loading.TabIndex = 15;
            this.lbl_loading.Text = "正在检测网络连接中";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 16;
            // 
            // Timer_dot
            // 
            this.Timer_dot.Interval = 10;
            this.Timer_dot.Tick += new System.EventHandler(this.Timer_dot_Tick);
            // 
            // Timer_total
            // 
            this.Timer_total.Tick += new System.EventHandler(this.Timer_total_Tick);
            // 
            // ConnectServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(338, 80);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.loadingCircle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ConnectServer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConnectServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private LoadingCircle loadingCircle;
        private LoadingCircle loadingCircle;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_dot;
        private System.Windows.Forms.Timer Timer_total;

    }
}

