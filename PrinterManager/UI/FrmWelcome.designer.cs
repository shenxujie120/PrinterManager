namespace PrinterManager
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.Timer_judge = new System.Windows.Forms.Timer(this.components);
            this.btnRandCode = new CCWin.SkinControl.SkinButton();
            this.btnSetting = new CCWin.SkinControl.SkinButton();
            this.Welcome_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Welcome_tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer_judge
            // 
            this.Timer_judge.Interval = 1000;
            // 
            // btnRandCode
            // 
            this.btnRandCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandCode.BackColor = System.Drawing.Color.Transparent;
            this.btnRandCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRandCode.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnRandCode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnRandCode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRandCode.DownBack = ((System.Drawing.Image)(resources.GetObject("btnRandCode.DownBack")));
            this.btnRandCode.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnRandCode.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRandCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnRandCode.Location = new System.Drawing.Point(366, 536);
            this.btnRandCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnRandCode.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnRandCode.MouseBack")));
            this.btnRandCode.Name = "btnRandCode";
            this.btnRandCode.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnRandCode.NormlBack")));
            this.btnRandCode.Radius = 10;
            this.btnRandCode.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnRandCode.Size = new System.Drawing.Size(180, 68);
            this.btnRandCode.TabIndex = 1;
            this.btnRandCode.Text = "进入系统";
            this.btnRandCode.UseVisualStyleBackColor = false;
            this.btnRandCode.Click += new System.EventHandler(this.BtnWelcome_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetting.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnSetting.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetting.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSetting.DownBack")));
            this.btnSetting.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnSetting.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnSetting.Location = new System.Drawing.Point(819, 536);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSetting.MouseBack")));
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSetting.NormlBack")));
            this.btnSetting.Radius = 10;
            this.btnSetting.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnSetting.Size = new System.Drawing.Size(180, 68);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "设备管理";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // Welcome_tableLayout
            // 
            this.Welcome_tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_tableLayout.ColumnCount = 5;
            this.Welcome_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Welcome_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Welcome_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Welcome_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Welcome_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Welcome_tableLayout.Controls.Add(this.btnRandCode, 1, 2);
            this.Welcome_tableLayout.Controls.Add(this.btnSetting, 3, 2);
            this.Welcome_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome_tableLayout.Location = new System.Drawing.Point(0, 0);
            this.Welcome_tableLayout.Name = "Welcome_tableLayout";
            this.Welcome_tableLayout.RowCount = 3;
            this.Welcome_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Welcome_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Welcome_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Welcome_tableLayout.Size = new System.Drawing.Size(1366, 768);
            this.Welcome_tableLayout.TabIndex = 3;
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Welcome_tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWelcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "欢迎进入到梦空间";
            this.Load += new System.EventHandler(this.Frm_Welcome_Load);
            this.Welcome_tableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_judge;
        private CCWin.SkinControl.SkinButton btnRandCode;
        private CCWin.SkinControl.SkinButton btnSetting;
        private System.Windows.Forms.TableLayoutPanel Welcome_tableLayout;



    }
}