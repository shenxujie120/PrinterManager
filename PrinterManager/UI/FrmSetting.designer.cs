namespace PrinterManager
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.TabControl_Setting = new CCWin.SkinControl.SkinTabControl();
            this.TabCon_General = new CCWin.SkinControl.SkinTabPage();
            this.printerComboBox = new CCWin.SkinControl.SkinComboBox();
            this.Pnl_settingsuccess1 = new CCWin.SkinControl.SkinPanel();
            this.Lbl_settingsuccess1 = new System.Windows.Forms.Label();
            this.Pic_settingsuccess1 = new CCWin.SkinControl.SkinPictureBox();
            this.Btn_log = new CCWin.SkinControl.SkinButton();
            this.Btn_localPrinter = new CCWin.SkinControl.SkinButton();
            this.Lbl_pinterstatus = new System.Windows.Forms.Label();
            this.Btn_changeDir = new CCWin.SkinControl.SkinButton();
            this.CBox_printlimit = new CCWin.SkinControl.SkinCheckBox();
            this.LblDirectory = new System.Windows.Forms.Label();
            this.CBox_autorun = new CCWin.SkinControl.SkinCheckBox();
            this.TabCon_About = new CCWin.SkinControl.SkinTabPage();
            this.Pnl_settingsuccess3 = new CCWin.SkinControl.SkinPanel();
            this.Lbl_settingsuccess3 = new System.Windows.Forms.Label();
            this.Pic_settingsuccess3 = new CCWin.SkinControl.SkinPictureBox();
            this.Linklbl_url = new System.Windows.Forms.LinkLabel();
            this.Lbl_version = new System.Windows.Forms.Label();
            this.Btn_testupdate = new CCWin.SkinControl.SkinButton();
            this.RadioBtn_Autoupdate2 = new CCWin.SkinControl.SkinRadioButton();
            this.RadioBtn_Autoupdate1 = new CCWin.SkinControl.SkinRadioButton();
            this.TabCon_Device = new CCWin.SkinControl.SkinTabPage();
            this.Btn_Quit = new CCWin.SkinControl.SkinButton();
            this.Pnl_settingsuccess2 = new CCWin.SkinControl.SkinPanel();
            this.Lbl_settingsuccess2 = new System.Windows.Forms.Label();
            this.Pic_settingsuccess2 = new CCWin.SkinControl.SkinPictureBox();
            this.Txt_deviceno = new CCWin.SkinControl.SkinWaterTextBox();
            this.Lbl_adminaddress = new System.Windows.Forms.Label();
            this.Lbl_adminphone = new System.Windows.Forms.Label();
            this.Lbl_adminname = new System.Windows.Forms.Label();
            this.Btn_setdevice = new CCWin.SkinControl.SkinButton();
            this.Timersetting = new System.Windows.Forms.Timer(this.components);
            this.CacheDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TabControl_Setting.SuspendLayout();
            this.TabCon_General.SuspendLayout();
            this.Pnl_settingsuccess1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_settingsuccess1)).BeginInit();
            this.TabCon_About.SuspendLayout();
            this.Pnl_settingsuccess3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_settingsuccess3)).BeginInit();
            this.TabCon_Device.SuspendLayout();
            this.Pnl_settingsuccess2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_settingsuccess2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "GeneralSetting.png");
            this.ImageList.Images.SetKeyName(1, "AboutSetting.png");
            this.ImageList.Images.SetKeyName(2, "DeviceSetting.png");
            // 
            // TabControl_Setting
            // 
            this.TabControl_Setting.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl_Setting.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.TabControl_Setting.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.TabControl_Setting.Controls.Add(this.TabCon_General);
            this.TabControl_Setting.Controls.Add(this.TabCon_About);
            this.TabControl_Setting.Controls.Add(this.TabCon_Device);
            this.TabControl_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Setting.HeadBack = null;
            this.TabControl_Setting.ImageList = this.ImageList;
            this.TabControl_Setting.ImgSize = new System.Drawing.Size(25, 25);
            this.TabControl_Setting.ImgTxtOffset = new System.Drawing.Point(-15, 0);
            this.TabControl_Setting.ImgTxtSpace = 5;
            this.TabControl_Setting.ItemSize = new System.Drawing.Size(50, 150);
            this.TabControl_Setting.Location = new System.Drawing.Point(4, 34);
            this.TabControl_Setting.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TabControl_Setting.Multiline = true;
            this.TabControl_Setting.Name = "TabControl_Setting";
            this.TabControl_Setting.Padding = new System.Drawing.Point(0, 0);
            this.TabControl_Setting.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageArrowDown")));
            this.TabControl_Setting.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageArrowHover")));
            this.TabControl_Setting.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageCloseHover")));
            this.TabControl_Setting.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageCloseNormal")));
            this.TabControl_Setting.PageDown = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageDown")));
            this.TabControl_Setting.PageHover = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageHover")));
            this.TabControl_Setting.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Right;
            this.TabControl_Setting.PageNorml = ((System.Drawing.Image)(resources.GetObject("TabControl_Setting.PageNorml")));
            this.TabControl_Setting.PageTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TabControl_Setting.SelectedIndex = 2;
            this.TabControl_Setting.Size = new System.Drawing.Size(792, 377);
            this.TabControl_Setting.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl_Setting.TabIndex = 142;
            // 
            // TabCon_General
            // 
            this.TabCon_General.BackColor = System.Drawing.Color.White;
            this.TabCon_General.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabCon_General.BackgroundImage")));
            this.TabCon_General.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabCon_General.Controls.Add(this.printerComboBox);
            this.TabCon_General.Controls.Add(this.Pnl_settingsuccess1);
            this.TabCon_General.Controls.Add(this.Btn_log);
            this.TabCon_General.Controls.Add(this.Btn_localPrinter);
            this.TabCon_General.Controls.Add(this.Lbl_pinterstatus);
            this.TabCon_General.Controls.Add(this.Btn_changeDir);
            this.TabCon_General.Controls.Add(this.CBox_printlimit);
            this.TabCon_General.Controls.Add(this.LblDirectory);
            this.TabCon_General.Controls.Add(this.CBox_autorun);
            this.TabCon_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCon_General.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabCon_General.ForeColor = System.Drawing.Color.Teal;
            this.TabCon_General.ImageIndex = 0;
            this.TabCon_General.Location = new System.Drawing.Point(150, 0);
            this.TabCon_General.Margin = new System.Windows.Forms.Padding(0);
            this.TabCon_General.Name = "TabCon_General";
            this.TabCon_General.Size = new System.Drawing.Size(642, 377);
            this.TabCon_General.TabIndex = 1;
            this.TabCon_General.TabItemImage = null;
            this.TabCon_General.Text = "常规设置";
            // 
            // printerComboBox
            // 
            this.printerComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.printerComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.printerComboBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.printerComboBox.FormattingEnabled = true;
            this.printerComboBox.Location = new System.Drawing.Point(264, 254);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(221, 30);
            this.printerComboBox.TabIndex = 9;
            this.printerComboBox.Visible = false;
            this.printerComboBox.WaterText = "";
            // 
            // Pnl_settingsuccess1
            // 
            this.Pnl_settingsuccess1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_settingsuccess1.Controls.Add(this.Lbl_settingsuccess1);
            this.Pnl_settingsuccess1.Controls.Add(this.Pic_settingsuccess1);
            this.Pnl_settingsuccess1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Pnl_settingsuccess1.DownBack = null;
            this.Pnl_settingsuccess1.Location = new System.Drawing.Point(221, 148);
            this.Pnl_settingsuccess1.MouseBack = null;
            this.Pnl_settingsuccess1.Name = "Pnl_settingsuccess1";
            this.Pnl_settingsuccess1.NormlBack = null;
            this.Pnl_settingsuccess1.Radius = 16;
            this.Pnl_settingsuccess1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Pnl_settingsuccess1.Size = new System.Drawing.Size(200, 80);
            this.Pnl_settingsuccess1.TabIndex = 7;
            this.Pnl_settingsuccess1.Visible = false;
            // 
            // Lbl_settingsuccess1
            // 
            this.Lbl_settingsuccess1.AutoSize = true;
            this.Lbl_settingsuccess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_settingsuccess1.ForeColor = System.Drawing.Color.White;
            this.Lbl_settingsuccess1.Location = new System.Drawing.Point(71, 29);
            this.Lbl_settingsuccess1.Name = "Lbl_settingsuccess1";
            this.Lbl_settingsuccess1.Size = new System.Drawing.Size(105, 24);
            this.Lbl_settingsuccess1.TabIndex = 1;
            this.Lbl_settingsuccess1.Text = "设置已更新";
            // 
            // Pic_settingsuccess1
            // 
            this.Pic_settingsuccess1.BackColor = System.Drawing.Color.Transparent;
            this.Pic_settingsuccess1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_settingsuccess1.BackgroundImage")));
            this.Pic_settingsuccess1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_settingsuccess1.Location = new System.Drawing.Point(21, 18);
            this.Pic_settingsuccess1.Name = "Pic_settingsuccess1";
            this.Pic_settingsuccess1.Size = new System.Drawing.Size(43, 40);
            this.Pic_settingsuccess1.TabIndex = 0;
            this.Pic_settingsuccess1.TabStop = false;
            // 
            // Btn_log
            // 
            this.Btn_log.BackColor = System.Drawing.Color.White;
            this.Btn_log.BaseColor = System.Drawing.Color.White;
            this.Btn_log.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_log.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_log.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_log.DownBack")));
            this.Btn_log.DownBaseColor = System.Drawing.Color.LightGray;
            this.Btn_log.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_log.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_log.ForeColor = System.Drawing.Color.Black;
            this.Btn_log.Location = new System.Drawing.Point(491, 327);
            this.Btn_log.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_log.MouseBack")));
            this.Btn_log.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_log.Name = "Btn_log";
            this.Btn_log.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_log.NormlBack")));
            this.Btn_log.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_log.Size = new System.Drawing.Size(91, 30);
            this.Btn_log.TabIndex = 6;
            this.Btn_log.Text = "查看";
            this.Btn_log.UseVisualStyleBackColor = false;
            this.Btn_log.Visible = false;
            // 
            // Btn_localPrinter
            // 
            this.Btn_localPrinter.BackColor = System.Drawing.Color.White;
            this.Btn_localPrinter.BaseColor = System.Drawing.Color.White;
            this.Btn_localPrinter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_localPrinter.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_localPrinter.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_localPrinter.DownBack")));
            this.Btn_localPrinter.DownBaseColor = System.Drawing.Color.LightGray;
            this.Btn_localPrinter.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_localPrinter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_localPrinter.ForeColor = System.Drawing.Color.Black;
            this.Btn_localPrinter.Location = new System.Drawing.Point(491, 254);
            this.Btn_localPrinter.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_localPrinter.MouseBack")));
            this.Btn_localPrinter.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_localPrinter.Name = "Btn_localPrinter";
            this.Btn_localPrinter.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_localPrinter.NormlBack")));
            this.Btn_localPrinter.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_localPrinter.Size = new System.Drawing.Size(91, 30);
            this.Btn_localPrinter.TabIndex = 5;
            this.Btn_localPrinter.Text = "默认打印机";
            this.Btn_localPrinter.UseVisualStyleBackColor = false;
            this.Btn_localPrinter.Click += new System.EventHandler(this.Btn_localPrinter_Click);
            // 
            // Lbl_pinterstatus
            // 
            this.Lbl_pinterstatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_pinterstatus.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_pinterstatus.Location = new System.Drawing.Point(260, 257);
            this.Lbl_pinterstatus.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_pinterstatus.Name = "Lbl_pinterstatus";
            this.Lbl_pinterstatus.Size = new System.Drawing.Size(177, 22);
            this.Lbl_pinterstatus.TabIndex = 4;
            this.Lbl_pinterstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_changeDir
            // 
            this.Btn_changeDir.BackColor = System.Drawing.Color.White;
            this.Btn_changeDir.BaseColor = System.Drawing.Color.White;
            this.Btn_changeDir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_changeDir.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_changeDir.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_changeDir.DownBack")));
            this.Btn_changeDir.DownBaseColor = System.Drawing.Color.LightGray;
            this.Btn_changeDir.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_changeDir.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_changeDir.ForeColor = System.Drawing.Color.Black;
            this.Btn_changeDir.Location = new System.Drawing.Point(491, 169);
            this.Btn_changeDir.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_changeDir.MouseBack")));
            this.Btn_changeDir.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_changeDir.Name = "Btn_changeDir";
            this.Btn_changeDir.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_changeDir.NormlBack")));
            this.Btn_changeDir.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_changeDir.Size = new System.Drawing.Size(91, 30);
            this.Btn_changeDir.TabIndex = 3;
            this.Btn_changeDir.Text = "更改";
            this.Btn_changeDir.UseVisualStyleBackColor = false;
            this.Btn_changeDir.Click += new System.EventHandler(this.Btn_changeDir_Click);
            // 
            // CBox_printlimit
            // 
            this.CBox_printlimit.AutoSize = true;
            this.CBox_printlimit.BackColor = System.Drawing.Color.Transparent;
            this.CBox_printlimit.BaseColor = System.Drawing.Color.MediumAquamarine;
            this.CBox_printlimit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CBox_printlimit.DownBack = null;
            this.CBox_printlimit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBox_printlimit.Location = new System.Drawing.Point(175, 235);
            this.CBox_printlimit.MouseBack = null;
            this.CBox_printlimit.Name = "CBox_printlimit";
            this.CBox_printlimit.NormlBack = null;
            this.CBox_printlimit.SelectedDownBack = null;
            this.CBox_printlimit.SelectedMouseBack = null;
            this.CBox_printlimit.SelectedNormlBack = null;
            this.CBox_printlimit.Size = new System.Drawing.Size(283, 21);
            this.CBox_printlimit.TabIndex = 2;
            this.CBox_printlimit.Text = "                                                                ";
            this.CBox_printlimit.UseVisualStyleBackColor = false;
            this.CBox_printlimit.CheckedChanged += new System.EventHandler(this.CBox_printlimit_CheckedChanged);
            // 
            // LblDirectory
            // 
            this.LblDirectory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblDirectory.ForeColor = System.Drawing.Color.DimGray;
            this.LblDirectory.Location = new System.Drawing.Point(175, 174);
            this.LblDirectory.Margin = new System.Windows.Forms.Padding(3);
            this.LblDirectory.Name = "LblDirectory";
            this.LblDirectory.Size = new System.Drawing.Size(310, 22);
            this.LblDirectory.TabIndex = 1;
            this.LblDirectory.Text = "C:\\Program Files\\iDream\\Cache";
            // 
            // CBox_autorun
            // 
            this.CBox_autorun.AutoSize = true;
            this.CBox_autorun.BackColor = System.Drawing.Color.Transparent;
            this.CBox_autorun.BaseColor = System.Drawing.Color.MediumAquamarine;
            this.CBox_autorun.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.CBox_autorun.DownBack = null;
            this.CBox_autorun.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBox_autorun.Location = new System.Drawing.Point(175, 121);
            this.CBox_autorun.MouseBack = null;
            this.CBox_autorun.Name = "CBox_autorun";
            this.CBox_autorun.NormlBack = null;
            this.CBox_autorun.SelectedDownBack = null;
            this.CBox_autorun.SelectedMouseBack = null;
            this.CBox_autorun.SelectedNormlBack = null;
            this.CBox_autorun.Size = new System.Drawing.Size(247, 21);
            this.CBox_autorun.TabIndex = 0;
            this.CBox_autorun.Text = "                                                       ";
            this.CBox_autorun.UseVisualStyleBackColor = false;
            this.CBox_autorun.CheckedChanged += new System.EventHandler(this.CBox_autorun_CheckedChanged);
            // 
            // TabCon_About
            // 
            this.TabCon_About.BackColor = System.Drawing.Color.White;
            this.TabCon_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabCon_About.BackgroundImage")));
            this.TabCon_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabCon_About.Controls.Add(this.Pnl_settingsuccess3);
            this.TabCon_About.Controls.Add(this.Linklbl_url);
            this.TabCon_About.Controls.Add(this.Lbl_version);
            this.TabCon_About.Controls.Add(this.Btn_testupdate);
            this.TabCon_About.Controls.Add(this.RadioBtn_Autoupdate2);
            this.TabCon_About.Controls.Add(this.RadioBtn_Autoupdate1);
            this.TabCon_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCon_About.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabCon_About.ForeColor = System.Drawing.Color.Teal;
            this.TabCon_About.ImageIndex = 1;
            this.TabCon_About.Location = new System.Drawing.Point(150, 0);
            this.TabCon_About.Margin = new System.Windows.Forms.Padding(0);
            this.TabCon_About.Name = "TabCon_About";
            this.TabCon_About.Size = new System.Drawing.Size(642, 377);
            this.TabCon_About.TabIndex = 4;
            this.TabCon_About.TabItemImage = null;
            this.TabCon_About.Text = "关于到梦空间";
            // 
            // Pnl_settingsuccess3
            // 
            this.Pnl_settingsuccess3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_settingsuccess3.Controls.Add(this.Lbl_settingsuccess3);
            this.Pnl_settingsuccess3.Controls.Add(this.Pic_settingsuccess3);
            this.Pnl_settingsuccess3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Pnl_settingsuccess3.DownBack = null;
            this.Pnl_settingsuccess3.Location = new System.Drawing.Point(221, 148);
            this.Pnl_settingsuccess3.MouseBack = null;
            this.Pnl_settingsuccess3.Name = "Pnl_settingsuccess3";
            this.Pnl_settingsuccess3.NormlBack = null;
            this.Pnl_settingsuccess3.Radius = 16;
            this.Pnl_settingsuccess3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Pnl_settingsuccess3.Size = new System.Drawing.Size(200, 80);
            this.Pnl_settingsuccess3.TabIndex = 9;
            this.Pnl_settingsuccess3.Visible = false;
            // 
            // Lbl_settingsuccess3
            // 
            this.Lbl_settingsuccess3.AutoSize = true;
            this.Lbl_settingsuccess3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_settingsuccess3.ForeColor = System.Drawing.Color.White;
            this.Lbl_settingsuccess3.Location = new System.Drawing.Point(71, 29);
            this.Lbl_settingsuccess3.Name = "Lbl_settingsuccess3";
            this.Lbl_settingsuccess3.Size = new System.Drawing.Size(105, 24);
            this.Lbl_settingsuccess3.TabIndex = 1;
            this.Lbl_settingsuccess3.Text = "设置已更新";
            // 
            // Pic_settingsuccess3
            // 
            this.Pic_settingsuccess3.BackColor = System.Drawing.Color.Transparent;
            this.Pic_settingsuccess3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_settingsuccess3.BackgroundImage")));
            this.Pic_settingsuccess3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_settingsuccess3.Location = new System.Drawing.Point(21, 18);
            this.Pic_settingsuccess3.Name = "Pic_settingsuccess3";
            this.Pic_settingsuccess3.Size = new System.Drawing.Size(43, 40);
            this.Pic_settingsuccess3.TabIndex = 0;
            this.Pic_settingsuccess3.TabStop = false;
            // 
            // Linklbl_url
            // 
            this.Linklbl_url.AutoSize = true;
            this.Linklbl_url.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Linklbl_url.Location = new System.Drawing.Point(178, 287);
            this.Linklbl_url.Name = "Linklbl_url";
            this.Linklbl_url.Size = new System.Drawing.Size(239, 21);
            this.Linklbl_url.TabIndex = 8;
            this.Linklbl_url.TabStop = true;
            this.Linklbl_url.Text = "http://www.5idream.net/login";
            // 
            // Lbl_version
            // 
            this.Lbl_version.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_version.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_version.Location = new System.Drawing.Point(252, 131);
            this.Lbl_version.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_version.Name = "Lbl_version";
            this.Lbl_version.Padding = new System.Windows.Forms.Padding(3);
            this.Lbl_version.Size = new System.Drawing.Size(207, 30);
            this.Lbl_version.TabIndex = 7;
            // 
            // Btn_testupdate
            // 
            this.Btn_testupdate.BackColor = System.Drawing.Color.White;
            this.Btn_testupdate.BaseColor = System.Drawing.Color.White;
            this.Btn_testupdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_testupdate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_testupdate.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_testupdate.DownBack")));
            this.Btn_testupdate.DownBaseColor = System.Drawing.Color.LightGray;
            this.Btn_testupdate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_testupdate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_testupdate.ForeColor = System.Drawing.Color.Black;
            this.Btn_testupdate.Location = new System.Drawing.Point(493, 127);
            this.Btn_testupdate.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_testupdate.MouseBack")));
            this.Btn_testupdate.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_testupdate.Name = "Btn_testupdate";
            this.Btn_testupdate.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_testupdate.NormlBack")));
            this.Btn_testupdate.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_testupdate.Size = new System.Drawing.Size(81, 30);
            this.Btn_testupdate.TabIndex = 6;
            this.Btn_testupdate.Text = "检测更新";
            this.Btn_testupdate.UseVisualStyleBackColor = false;
            this.Btn_testupdate.Click += new System.EventHandler(this.Btn_testupdate_Click);
            // 
            // RadioBtn_Autoupdate2
            // 
            this.RadioBtn_Autoupdate2.AutoSize = true;
            this.RadioBtn_Autoupdate2.BackColor = System.Drawing.Color.Transparent;
            this.RadioBtn_Autoupdate2.BaseColor = System.Drawing.Color.MediumAquamarine;
            this.RadioBtn_Autoupdate2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.RadioBtn_Autoupdate2.DownBack = null;
            this.RadioBtn_Autoupdate2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBtn_Autoupdate2.Location = new System.Drawing.Point(173, 231);
            this.RadioBtn_Autoupdate2.MouseBack = null;
            this.RadioBtn_Autoupdate2.Name = "RadioBtn_Autoupdate2";
            this.RadioBtn_Autoupdate2.NormlBack = null;
            this.RadioBtn_Autoupdate2.SelectedDownBack = null;
            this.RadioBtn_Autoupdate2.SelectedMouseBack = null;
            this.RadioBtn_Autoupdate2.SelectedNormlBack = null;
            this.RadioBtn_Autoupdate2.Size = new System.Drawing.Size(294, 21);
            this.RadioBtn_Autoupdate2.TabIndex = 1;
            this.RadioBtn_Autoupdate2.TabStop = true;
            this.RadioBtn_Autoupdate2.Text = "                                                                   ";
            this.RadioBtn_Autoupdate2.UseVisualStyleBackColor = false;
            this.RadioBtn_Autoupdate2.CheckedChanged += new System.EventHandler(this.RadioBtn_Autoupdate2_CheckedChanged);
            // 
            // RadioBtn_Autoupdate1
            // 
            this.RadioBtn_Autoupdate1.AutoSize = true;
            this.RadioBtn_Autoupdate1.BackColor = System.Drawing.Color.Transparent;
            this.RadioBtn_Autoupdate1.BaseColor = System.Drawing.Color.MediumAquamarine;
            this.RadioBtn_Autoupdate1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.RadioBtn_Autoupdate1.DownBack = null;
            this.RadioBtn_Autoupdate1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioBtn_Autoupdate1.Location = new System.Drawing.Point(173, 201);
            this.RadioBtn_Autoupdate1.MouseBack = null;
            this.RadioBtn_Autoupdate1.Name = "RadioBtn_Autoupdate1";
            this.RadioBtn_Autoupdate1.NormlBack = null;
            this.RadioBtn_Autoupdate1.SelectedDownBack = null;
            this.RadioBtn_Autoupdate1.SelectedMouseBack = null;
            this.RadioBtn_Autoupdate1.SelectedNormlBack = null;
            this.RadioBtn_Autoupdate1.Size = new System.Drawing.Size(306, 21);
            this.RadioBtn_Autoupdate1.TabIndex = 0;
            this.RadioBtn_Autoupdate1.TabStop = true;
            this.RadioBtn_Autoupdate1.Text = "                                                                      ";
            this.RadioBtn_Autoupdate1.UseVisualStyleBackColor = false;
            this.RadioBtn_Autoupdate1.CheckedChanged += new System.EventHandler(this.RadioBtn_Autoupdate1_CheckedChanged);
            // 
            // TabCon_Device
            // 
            this.TabCon_Device.BackColor = System.Drawing.Color.White;
            this.TabCon_Device.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabCon_Device.BackgroundImage")));
            this.TabCon_Device.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TabCon_Device.Controls.Add(this.Btn_Quit);
            this.TabCon_Device.Controls.Add(this.Pnl_settingsuccess2);
            this.TabCon_Device.Controls.Add(this.Txt_deviceno);
            this.TabCon_Device.Controls.Add(this.Lbl_adminaddress);
            this.TabCon_Device.Controls.Add(this.Lbl_adminphone);
            this.TabCon_Device.Controls.Add(this.Lbl_adminname);
            this.TabCon_Device.Controls.Add(this.Btn_setdevice);
            this.TabCon_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCon_Device.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabCon_Device.ForeColor = System.Drawing.Color.Teal;
            this.TabCon_Device.ImageIndex = 2;
            this.TabCon_Device.Location = new System.Drawing.Point(150, 0);
            this.TabCon_Device.Margin = new System.Windows.Forms.Padding(0);
            this.TabCon_Device.Name = "TabCon_Device";
            this.TabCon_Device.Size = new System.Drawing.Size(642, 377);
            this.TabCon_Device.TabIndex = 3;
            this.TabCon_Device.TabItemImage = null;
            this.TabCon_Device.Text = "设备设置";
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.BackColor = System.Drawing.Color.White;
            this.Btn_Quit.BaseColor = System.Drawing.Color.White;
            this.Btn_Quit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Quit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_Quit.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_Quit.DownBack")));
            this.Btn_Quit.DownBaseColor = System.Drawing.Color.LightGray;
            this.Btn_Quit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_Quit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Quit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Quit.Location = new System.Drawing.Point(493, 309);
            this.Btn_Quit.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_Quit.MouseBack")));
            this.Btn_Quit.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_Quit.NormlBack")));
            this.Btn_Quit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_Quit.Size = new System.Drawing.Size(73, 30);
            this.Btn_Quit.TabIndex = 11;
            this.Btn_Quit.Text = "退出系统";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Pnl_settingsuccess2
            // 
            this.Pnl_settingsuccess2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_settingsuccess2.Controls.Add(this.Lbl_settingsuccess2);
            this.Pnl_settingsuccess2.Controls.Add(this.Pic_settingsuccess2);
            this.Pnl_settingsuccess2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Pnl_settingsuccess2.DownBack = null;
            this.Pnl_settingsuccess2.Location = new System.Drawing.Point(221, 148);
            this.Pnl_settingsuccess2.MouseBack = null;
            this.Pnl_settingsuccess2.Name = "Pnl_settingsuccess2";
            this.Pnl_settingsuccess2.NormlBack = null;
            this.Pnl_settingsuccess2.Radius = 16;
            this.Pnl_settingsuccess2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Pnl_settingsuccess2.Size = new System.Drawing.Size(200, 80);
            this.Pnl_settingsuccess2.TabIndex = 10;
            this.Pnl_settingsuccess2.Visible = false;
            // 
            // Lbl_settingsuccess2
            // 
            this.Lbl_settingsuccess2.AutoSize = true;
            this.Lbl_settingsuccess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_settingsuccess2.ForeColor = System.Drawing.Color.White;
            this.Lbl_settingsuccess2.Location = new System.Drawing.Point(71, 29);
            this.Lbl_settingsuccess2.Name = "Lbl_settingsuccess2";
            this.Lbl_settingsuccess2.Size = new System.Drawing.Size(105, 24);
            this.Lbl_settingsuccess2.TabIndex = 1;
            this.Lbl_settingsuccess2.Text = "设置已更新";
            // 
            // Pic_settingsuccess2
            // 
            this.Pic_settingsuccess2.BackColor = System.Drawing.Color.Transparent;
            this.Pic_settingsuccess2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_settingsuccess2.BackgroundImage")));
            this.Pic_settingsuccess2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_settingsuccess2.Location = new System.Drawing.Point(21, 18);
            this.Pic_settingsuccess2.Name = "Pic_settingsuccess2";
            this.Pic_settingsuccess2.Size = new System.Drawing.Size(43, 40);
            this.Pic_settingsuccess2.TabIndex = 0;
            this.Pic_settingsuccess2.TabStop = false;
            // 
            // Txt_deviceno
            // 
            this.Txt_deviceno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_deviceno.Enabled = false;
            this.Txt_deviceno.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_deviceno.Location = new System.Drawing.Point(174, 131);
            this.Txt_deviceno.Name = "Txt_deviceno";
            this.Txt_deviceno.Size = new System.Drawing.Size(224, 29);
            this.Txt_deviceno.TabIndex = 9;
            this.Txt_deviceno.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Txt_deviceno.WaterText = "学校中文+编号(如北京科技大学1号机)";
            // 
            // Lbl_adminaddress
            // 
            this.Lbl_adminaddress.AutoSize = true;
            this.Lbl_adminaddress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_adminaddress.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_adminaddress.Location = new System.Drawing.Point(254, 257);
            this.Lbl_adminaddress.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_adminaddress.Name = "Lbl_adminaddress";
            this.Lbl_adminaddress.Padding = new System.Windows.Forms.Padding(3);
            this.Lbl_adminaddress.Size = new System.Drawing.Size(6, 27);
            this.Lbl_adminaddress.TabIndex = 8;
            // 
            // Lbl_adminphone
            // 
            this.Lbl_adminphone.AutoSize = true;
            this.Lbl_adminphone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_adminphone.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_adminphone.Location = new System.Drawing.Point(254, 229);
            this.Lbl_adminphone.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_adminphone.Name = "Lbl_adminphone";
            this.Lbl_adminphone.Padding = new System.Windows.Forms.Padding(3);
            this.Lbl_adminphone.Size = new System.Drawing.Size(6, 27);
            this.Lbl_adminphone.TabIndex = 7;
            // 
            // Lbl_adminname
            // 
            this.Lbl_adminname.AutoSize = true;
            this.Lbl_adminname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_adminname.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_adminname.Location = new System.Drawing.Point(254, 200);
            this.Lbl_adminname.Margin = new System.Windows.Forms.Padding(3);
            this.Lbl_adminname.Name = "Lbl_adminname";
            this.Lbl_adminname.Padding = new System.Windows.Forms.Padding(3);
            this.Lbl_adminname.Size = new System.Drawing.Size(6, 27);
            this.Lbl_adminname.TabIndex = 6;
            // 
            // Btn_setdevice
            // 
            this.Btn_setdevice.BackColor = System.Drawing.Color.White;
            this.Btn_setdevice.BaseColor = System.Drawing.Color.White;
            this.Btn_setdevice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_setdevice.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_setdevice.DownBack = ((System.Drawing.Image)(resources.GetObject("Btn_setdevice.DownBack")));
            this.Btn_setdevice.DownBaseColor = System.Drawing.Color.LightGray;
            this.Btn_setdevice.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.Btn_setdevice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_setdevice.ForeColor = System.Drawing.Color.Black;
            this.Btn_setdevice.Location = new System.Drawing.Point(493, 131);
            this.Btn_setdevice.MouseBack = ((System.Drawing.Image)(resources.GetObject("Btn_setdevice.MouseBack")));
            this.Btn_setdevice.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_setdevice.Name = "Btn_setdevice";
            this.Btn_setdevice.NormlBack = ((System.Drawing.Image)(resources.GetObject("Btn_setdevice.NormlBack")));
            this.Btn_setdevice.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Btn_setdevice.Size = new System.Drawing.Size(73, 30);
            this.Btn_setdevice.TabIndex = 5;
            this.Btn_setdevice.Text = "设置";
            this.Btn_setdevice.UseVisualStyleBackColor = false;
            this.Btn_setdevice.Click += new System.EventHandler(this.Btn_SetDevice_Click);
            // 
            // Timersetting
            // 
            this.Timersetting.Interval = 300;
            this.Timersetting.Tick += new System.EventHandler(this.Timersetting_Tick);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.CloseBoxSize = new System.Drawing.Size(40, 25);
            this.ControlBoxOffset = new System.Drawing.Point(8, 4);
            this.Controls.Add(this.TabControl_Setting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetting";
            this.Radius = 8;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备管理";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.TabControl_Setting.ResumeLayout(false);
            this.TabCon_General.ResumeLayout(false);
            this.TabCon_General.PerformLayout();
            this.Pnl_settingsuccess1.ResumeLayout(false);
            this.Pnl_settingsuccess1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_settingsuccess1)).EndInit();
            this.TabCon_About.ResumeLayout(false);
            this.TabCon_About.PerformLayout();
            this.Pnl_settingsuccess3.ResumeLayout(false);
            this.Pnl_settingsuccess3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_settingsuccess3)).EndInit();
            this.TabCon_Device.ResumeLayout(false);
            this.TabCon_Device.PerformLayout();
            this.Pnl_settingsuccess2.ResumeLayout(false);
            this.Pnl_settingsuccess2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_settingsuccess2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ImageList;
        private CCWin.SkinControl.SkinTabControl TabControl_Setting;
        private CCWin.SkinControl.SkinTabPage TabCon_General;
        private CCWin.SkinControl.SkinTabPage TabCon_Device;
        private CCWin.SkinControl.SkinTabPage TabCon_About;
        private CCWin.SkinControl.SkinCheckBox CBox_autorun;
        private System.Windows.Forms.Label LblDirectory;
        private System.Windows.Forms.Label Lbl_pinterstatus;
        private CCWin.SkinControl.SkinButton Btn_changeDir;
        private CCWin.SkinControl.SkinButton Btn_log;
        private CCWin.SkinControl.SkinButton Btn_localPrinter;
        private System.Windows.Forms.Label Lbl_adminaddress;
        private System.Windows.Forms.Label Lbl_adminphone;
        private System.Windows.Forms.Label Lbl_adminname;
        private CCWin.SkinControl.SkinButton Btn_setdevice;
        private CCWin.SkinControl.SkinButton Btn_testupdate;
        private CCWin.SkinControl.SkinRadioButton RadioBtn_Autoupdate2;
        private CCWin.SkinControl.SkinRadioButton RadioBtn_Autoupdate1;
        private System.Windows.Forms.LinkLabel Linklbl_url;
        private System.Windows.Forms.Label Lbl_version;
        private CCWin.SkinControl.SkinWaterTextBox Txt_deviceno;
        private CCWin.SkinControl.SkinPanel Pnl_settingsuccess1;
        private System.Windows.Forms.Label Lbl_settingsuccess1;
        private CCWin.SkinControl.SkinPictureBox Pic_settingsuccess1;
        private System.Windows.Forms.Timer Timersetting;
        private CCWin.SkinControl.SkinPanel Pnl_settingsuccess2;
        private System.Windows.Forms.Label Lbl_settingsuccess2;
        private CCWin.SkinControl.SkinPictureBox Pic_settingsuccess2;
        private CCWin.SkinControl.SkinPanel Pnl_settingsuccess3;
        private System.Windows.Forms.Label Lbl_settingsuccess3;
        private CCWin.SkinControl.SkinPictureBox Pic_settingsuccess3;
        private CCWin.SkinControl.SkinButton Btn_Quit;
        private System.Windows.Forms.FolderBrowserDialog CacheDialog;
        private CCWin.SkinControl.SkinComboBox printerComboBox;
        private CCWin.SkinControl.SkinCheckBox CBox_printlimit;
    }
}