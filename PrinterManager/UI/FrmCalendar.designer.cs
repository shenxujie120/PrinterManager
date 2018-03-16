namespace PrinterManager
{
    partial class FrmCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendar));
            this.Lbl_Day = new System.Windows.Forms.Label();
            this.Lbl_Month = new System.Windows.Forms.Label();
            this.Lbl_Year = new System.Windows.Forms.Label();
            this.Lbl_YearValue = new System.Windows.Forms.Label();
            this.Btn_YearMinus = new CCWin.SkinControl.SkinButton();
            this.Btn_YearPlus = new CCWin.SkinControl.SkinButton();
            this.Lbl_DayValue = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Btn_MonthPlus = new CCWin.SkinControl.SkinButton();
            this.Btn_MonthMinus = new CCWin.SkinControl.SkinButton();
            this.Btn_DayPlus = new CCWin.SkinControl.SkinButton();
            this.Btn_DayMinus = new CCWin.SkinControl.SkinButton();
            this.Lbl_MonthValue = new System.Windows.Forms.Label();
            this.Btn_TimeConfirm = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // Lbl_Day
            // 
            this.Lbl_Day.AutoSize = true;
            this.Lbl_Day.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Day.ForeColor = System.Drawing.Color.White;
            this.Lbl_Day.Location = new System.Drawing.Point(228, 9);
            this.Lbl_Day.Name = "Lbl_Day";
            this.Lbl_Day.Size = new System.Drawing.Size(26, 21);
            this.Lbl_Day.TabIndex = 58;
            this.Lbl_Day.Text = "日";
            // 
            // Lbl_Month
            // 
            this.Lbl_Month.AutoSize = true;
            this.Lbl_Month.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Month.ForeColor = System.Drawing.Color.White;
            this.Lbl_Month.Location = new System.Drawing.Point(144, 9);
            this.Lbl_Month.Name = "Lbl_Month";
            this.Lbl_Month.Size = new System.Drawing.Size(26, 21);
            this.Lbl_Month.TabIndex = 57;
            this.Lbl_Month.Text = "月";
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.AutoSize = true;
            this.Lbl_Year.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Year.ForeColor = System.Drawing.Color.White;
            this.Lbl_Year.Location = new System.Drawing.Point(58, 9);
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.Size = new System.Drawing.Size(26, 21);
            this.Lbl_Year.TabIndex = 56;
            this.Lbl_Year.Text = "年";
            // 
            // Lbl_YearValue
            // 
            this.Lbl_YearValue.AutoSize = true;
            this.Lbl_YearValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_YearValue.ForeColor = System.Drawing.Color.White;
            this.Lbl_YearValue.Location = new System.Drawing.Point(49, 66);
            this.Lbl_YearValue.Name = "Lbl_YearValue";
            this.Lbl_YearValue.Size = new System.Drawing.Size(46, 21);
            this.Lbl_YearValue.TabIndex = 62;
            this.Lbl_YearValue.Text = "2016";
            // 
            // Btn_YearMinus
            // 
            this.Btn_YearMinus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_YearMinus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_YearMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_YearMinus.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_YearMinus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_YearMinus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_YearMinus.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_YearMinus.DownBack")));
            this.Btn_YearMinus.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_YearMinus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_YearMinus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_YearMinus.ForeColor = System.Drawing.Color.White;
            this.Btn_YearMinus.Location = new System.Drawing.Point(48, 37);
            this.Btn_YearMinus.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_YearMinus.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_YearMinus.MouseBack")));
            this.Btn_YearMinus.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_YearMinus.Name = "Btn_YearMinus";
            this.Btn_YearMinus.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_YearMinus.NormlBack")));
            this.Btn_YearMinus.Radius = 5;
            this.Btn_YearMinus.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_YearMinus.Size = new System.Drawing.Size(47, 21);
            this.Btn_YearMinus.TabIndex = 63;
            this.Btn_YearMinus.Text = "^";
            this.Btn_YearMinus.UseVisualStyleBackColor = false;
            this.Btn_YearMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMinus_MouseDown);
            this.Btn_YearMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMonDayPlusOrMinus_MouseUp);
            // 
            // Btn_YearPlus
            // 
            this.Btn_YearPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_YearPlus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_YearPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_YearPlus.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_YearPlus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_YearPlus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_YearPlus.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_YearPlus.DownBack")));
            this.Btn_YearPlus.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_YearPlus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_YearPlus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_YearPlus.ForeColor = System.Drawing.Color.White;
            this.Btn_YearPlus.Location = new System.Drawing.Point(48, 96);
            this.Btn_YearPlus.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_YearPlus.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_YearPlus.MouseBack")));
            this.Btn_YearPlus.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_YearPlus.Name = "Btn_YearPlus";
            this.Btn_YearPlus.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_YearPlus.NormlBack")));
            this.Btn_YearPlus.Radius = 5;
            this.Btn_YearPlus.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_YearPlus.Size = new System.Drawing.Size(47, 21);
            this.Btn_YearPlus.TabIndex = 64;
            this.Btn_YearPlus.UseVisualStyleBackColor = false;
            this.Btn_YearPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_YearPlus_MouseDown);
            this.Btn_YearPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMonDayPlusOrMinus_MouseUp);
            // 
            // Lbl_DayValue
            // 
            this.Lbl_DayValue.AutoSize = true;
            this.Lbl_DayValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_DayValue.ForeColor = System.Drawing.Color.White;
            this.Lbl_DayValue.Location = new System.Drawing.Point(233, 66);
            this.Lbl_DayValue.Name = "Lbl_DayValue";
            this.Lbl_DayValue.Size = new System.Drawing.Size(19, 21);
            this.Lbl_DayValue.TabIndex = 70;
            this.Lbl_DayValue.Text = "8";
            // 
            // Timer
            // 
            this.Timer.Interval = 300;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Btn_MonthPlus
            // 
            this.Btn_MonthPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_MonthPlus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MonthPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_MonthPlus.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_MonthPlus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_MonthPlus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_MonthPlus.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_MonthPlus.DownBack")));
            this.Btn_MonthPlus.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_MonthPlus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_MonthPlus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_MonthPlus.ForeColor = System.Drawing.Color.White;
            this.Btn_MonthPlus.Location = new System.Drawing.Point(132, 96);
            this.Btn_MonthPlus.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_MonthPlus.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_MonthPlus.MouseBack")));
            this.Btn_MonthPlus.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_MonthPlus.Name = "Btn_MonthPlus";
            this.Btn_MonthPlus.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_MonthPlus.NormlBack")));
            this.Btn_MonthPlus.Radius = 5;
            this.Btn_MonthPlus.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_MonthPlus.Size = new System.Drawing.Size(47, 21);
            this.Btn_MonthPlus.TabIndex = 72;
            this.Btn_MonthPlus.UseVisualStyleBackColor = false;
            this.Btn_MonthPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MonthPlus_MouseDown);
            this.Btn_MonthPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMonDayPlusOrMinus_MouseUp);
            // 
            // Btn_MonthMinus
            // 
            this.Btn_MonthMinus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_MonthMinus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MonthMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_MonthMinus.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_MonthMinus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_MonthMinus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_MonthMinus.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_MonthMinus.DownBack")));
            this.Btn_MonthMinus.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_MonthMinus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_MonthMinus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_MonthMinus.ForeColor = System.Drawing.Color.White;
            this.Btn_MonthMinus.Location = new System.Drawing.Point(132, 37);
            this.Btn_MonthMinus.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_MonthMinus.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_MonthMinus.MouseBack")));
            this.Btn_MonthMinus.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_MonthMinus.Name = "Btn_MonthMinus";
            this.Btn_MonthMinus.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_MonthMinus.NormlBack")));
            this.Btn_MonthMinus.Radius = 5;
            this.Btn_MonthMinus.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_MonthMinus.Size = new System.Drawing.Size(47, 21);
            this.Btn_MonthMinus.TabIndex = 71;
            this.Btn_MonthMinus.Text = "^";
            this.Btn_MonthMinus.UseVisualStyleBackColor = false;
            this.Btn_MonthMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MonthMinus_MouseDown);
            this.Btn_MonthMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMonDayPlusOrMinus_MouseUp);
            // 
            // Btn_DayPlus
            // 
            this.Btn_DayPlus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_DayPlus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_DayPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_DayPlus.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_DayPlus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_DayPlus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_DayPlus.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_DayPlus.DownBack")));
            this.Btn_DayPlus.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_DayPlus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_DayPlus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_DayPlus.ForeColor = System.Drawing.Color.White;
            this.Btn_DayPlus.Location = new System.Drawing.Point(217, 96);
            this.Btn_DayPlus.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DayPlus.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_DayPlus.MouseBack")));
            this.Btn_DayPlus.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_DayPlus.Name = "Btn_DayPlus";
            this.Btn_DayPlus.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_DayPlus.NormlBack")));
            this.Btn_DayPlus.Radius = 5;
            this.Btn_DayPlus.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_DayPlus.Size = new System.Drawing.Size(47, 21);
            this.Btn_DayPlus.TabIndex = 74;
            this.Btn_DayPlus.UseVisualStyleBackColor = false;
            this.Btn_DayPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_DayPlus_MouseDown);
            this.Btn_DayPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMonDayPlusOrMinus_MouseUp);
            // 
            // Btn_DayMinus
            // 
            this.Btn_DayMinus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_DayMinus.BackColor = System.Drawing.Color.Transparent;
            this.Btn_DayMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_DayMinus.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_DayMinus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_DayMinus.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_DayMinus.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_DayMinus.DownBack")));
            this.Btn_DayMinus.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_DayMinus.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_DayMinus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_DayMinus.ForeColor = System.Drawing.Color.White;
            this.Btn_DayMinus.Location = new System.Drawing.Point(217, 37);
            this.Btn_DayMinus.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_DayMinus.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_DayMinus.MouseBack")));
            this.Btn_DayMinus.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_DayMinus.Name = "Btn_DayMinus";
            this.Btn_DayMinus.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_DayMinus.NormlBack")));
            this.Btn_DayMinus.Radius = 5;
            this.Btn_DayMinus.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_DayMinus.Size = new System.Drawing.Size(47, 21);
            this.Btn_DayMinus.TabIndex = 73;
            this.Btn_DayMinus.Text = "^";
            this.Btn_DayMinus.UseVisualStyleBackColor = false;
            this.Btn_DayMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_DayMinus_MouseDown);
            this.Btn_DayMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_YearMonDayPlusOrMinus_MouseUp);
            // 
            // Lbl_MonthValue
            // 
            this.Lbl_MonthValue.AutoSize = true;
            this.Lbl_MonthValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_MonthValue.ForeColor = System.Drawing.Color.White;
            this.Lbl_MonthValue.Location = new System.Drawing.Point(147, 66);
            this.Lbl_MonthValue.Name = "Lbl_MonthValue";
            this.Lbl_MonthValue.Size = new System.Drawing.Size(19, 21);
            this.Lbl_MonthValue.TabIndex = 75;
            this.Lbl_MonthValue.Text = "4";
            // 
            // Btn_TimeConfirm
            // 
            this.Btn_TimeConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_TimeConfirm.BackColor = System.Drawing.Color.Salmon;
            this.Btn_TimeConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_TimeConfirm.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.Btn_TimeConfirm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Btn_TimeConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_TimeConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_TimeConfirm.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_TimeConfirm.DownBack")));
            this.Btn_TimeConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_TimeConfirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_TimeConfirm.ForeColor = System.Drawing.Color.White;
            this.Btn_TimeConfirm.Location = new System.Drawing.Point(292, 50);
            this.Btn_TimeConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_TimeConfirm.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_TimeConfirm.MouseBack")));
            this.Btn_TimeConfirm.Name = "Btn_TimeConfirm";
            this.Btn_TimeConfirm.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_TimeConfirm.NormlBack")));
            this.Btn_TimeConfirm.Radius = 16;
            this.Btn_TimeConfirm.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_TimeConfirm.Size = new System.Drawing.Size(65, 28);
            this.Btn_TimeConfirm.TabIndex = 76;
            this.Btn_TimeConfirm.Text = "确认";
            this.Btn_TimeConfirm.UseVisualStyleBackColor = false;
            this.Btn_TimeConfirm.Click += new System.EventHandler(this.Btn_TimeConfirm_Click);
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackShade = false;
            this.BackToColor = false;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(380, 133);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_TimeConfirm);
            this.Controls.Add(this.Lbl_MonthValue);
            this.Controls.Add(this.Btn_DayPlus);
            this.Controls.Add(this.Btn_DayMinus);
            this.Controls.Add(this.Btn_MonthPlus);
            this.Controls.Add(this.Btn_MonthMinus);
            this.Controls.Add(this.Lbl_DayValue);
            this.Controls.Add(this.Btn_YearPlus);
            this.Controls.Add(this.Btn_YearMinus);
            this.Controls.Add(this.Lbl_YearValue);
            this.Controls.Add(this.Lbl_Day);
            this.Controls.Add(this.Lbl_Month);
            this.Controls.Add(this.Lbl_Year);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MobileApi = false;
            this.Name = "FrmCalendar";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Day;
        private System.Windows.Forms.Label Lbl_Month;
        private System.Windows.Forms.Label Lbl_Year;
        private System.Windows.Forms.Label Lbl_YearValue;
        private CCWin.SkinControl.SkinButton Btn_YearMinus;
        private CCWin.SkinControl.SkinButton Btn_YearPlus;
        private System.Windows.Forms.Label Lbl_DayValue;
        private System.Windows.Forms.Timer Timer;
        private CCWin.SkinControl.SkinButton Btn_MonthPlus;
        private CCWin.SkinControl.SkinButton Btn_MonthMinus;
        private CCWin.SkinControl.SkinButton Btn_DayPlus;
        private CCWin.SkinControl.SkinButton Btn_DayMinus;
        private System.Windows.Forms.Label Lbl_MonthValue;
        private CCWin.SkinControl.SkinButton Btn_TimeConfirm;
    }
}