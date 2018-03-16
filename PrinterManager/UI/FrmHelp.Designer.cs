using System.Drawing;
using System.Windows.Forms;
using System;
namespace PrinterManager
{
    partial class FrmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.PanelTips = new CCWin.SkinControl.SkinPanel();
            this.Pic_Tips = new CCWin.SkinControl.SkinPictureBox();
            this.Lbl_Tips = new CCWin.SkinControl.SkinLabel();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.MainLayoutPanel = new CCWin.SkinControl.SkinPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PicArrow３ = new CCWin.SkinControl.SkinPictureBox();
            this.Timer_Now = new System.Windows.Forms.Timer(this.components);
            this.LMain_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPrint = new CCWin.SkinControl.SkinButton();
            this.BtnHistory = new CCWin.SkinControl.SkinButton();
            this.BtnInfo = new CCWin.SkinControl.SkinButton();
            this.BtnQuit = new CCWin.SkinControl.SkinButton();
            this.Lbl_Info_name = new System.Windows.Forms.Label();
            this.Lbl_Info_username = new System.Windows.Forms.Label();
            this.PanelTips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tips)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrow３)).BeginInit();
            this.LMain_tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTips
            // 
            this.PanelTips.BackColor = System.Drawing.Color.MintCream;
            this.PanelTips.Controls.Add(this.Pic_Tips);
            this.PanelTips.Controls.Add(this.Lbl_Tips);
            this.PanelTips.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.PanelTips.DownBack = null;
            this.PanelTips.Location = new System.Drawing.Point(266, 673);
            this.PanelTips.MouseBack = null;
            this.PanelTips.Name = "PanelTips";
            this.PanelTips.NormlBack = null;
            this.PanelTips.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PanelTips.Radius = 16;
            this.PanelTips.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.PanelTips.Size = new System.Drawing.Size(1050, 49);
            this.PanelTips.TabIndex = 1;
            // 
            // Pic_Tips
            // 
            this.Pic_Tips.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Tips.BackgroundImage = global::PrinterManager.Properties.Resources.Tips;
            this.Pic_Tips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Tips.Location = new System.Drawing.Point(14, 10);
            this.Pic_Tips.Margin = new System.Windows.Forms.Padding(0);
            this.Pic_Tips.Name = "Pic_Tips";
            this.Pic_Tips.Size = new System.Drawing.Size(30, 30);
            this.Pic_Tips.TabIndex = 0;
            this.Pic_Tips.TabStop = false;
            // 
            // Lbl_Tips
            // 
            this.Lbl_Tips.AutoSize = true;
            this.Lbl_Tips.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tips.BorderColor = System.Drawing.Color.White;
            this.Lbl_Tips.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Tips.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Lbl_Tips.Location = new System.Drawing.Point(63, 15);
            this.Lbl_Tips.Name = "Lbl_Tips";
            this.Lbl_Tips.Size = new System.Drawing.Size(82, 21);
            this.Lbl_Tips.TabIndex = 1;
            this.Lbl_Tips.Text = "11111111";
            this.Lbl_Tips.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Time.ForeColor = System.Drawing.Color.White;
            this.Lbl_Time.Location = new System.Drawing.Point(1150, 20);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(85, 20);
            this.Lbl_Time.TabIndex = 52;
            this.Lbl_Time.Text = "2016/04/08";
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.BackColor = System.Drawing.Color.MintCream;
            this.MainLayoutPanel.Controls.Add(this.label12);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainLayoutPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.MainLayoutPanel.DownBack = null;
            this.MainLayoutPanel.Location = new System.Drawing.Point(266, 73);
            this.MainLayoutPanel.MouseBack = null;
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.NormlBack = null;
            this.MainLayoutPanel.Radius = 16;
            this.MainLayoutPanel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.MainLayoutPanel.Size = new System.Drawing.Size(1050, 574);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(466, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "使用帮助";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 9);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "请不要使用该设备执行非相关行为。";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(443, 40);
            this.label10.TabIndex = 9;
            this.label10.Text = "忘记用户名或密码：请登录手机APP“到梦空间”修改用户名和密码。\r\n打印故障：打印机缺纸或无反应，请联系管理员。";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(457, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "在 系统设置 中选择“到梦空间信息”-“自动升级版本”进行版本更新。";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "常见问题";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "更新";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "需使用 管理员密码 进入系统设置界面。\r\n修改 设备码 前请先在后台管理系统内修改。";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "证书列表中支持多选打印。\r\n打印历史可以回看证书打印。";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "本系统为共青团第二课堂自助打印系统，由到梦空间开发，使用过程中有问题请联系管理员。\r\n以下是该系统的使用帮助：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "警告";
            // 
            // PicArrow３
            // 
            this.PicArrow３.BackColor = System.Drawing.Color.Transparent;
            this.PicArrow３.BackgroundImage = global::PrinterManager.Properties.Resources.arrow;
            this.PicArrow３.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicArrow３.Location = new System.Drawing.Point(226, 345);
            this.PicArrow３.Name = "PicArrow３";
            this.PicArrow３.Size = new System.Drawing.Size(55, 40);
            this.PicArrow３.TabIndex = 50;
            this.PicArrow３.TabStop = false;
            // 
            // Timer_Now
            // 
            this.Timer_Now.Enabled = true;
            this.Timer_Now.Interval = 1000;
            this.Timer_Now.Tick += new System.EventHandler(this.Timer_Now_Tick);
            // 
            // LMain_tableLayout
            // 
            this.LMain_tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.LMain_tableLayout.ColumnCount = 1;
            this.LMain_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LMain_tableLayout.Controls.Add(this.BtnPrint, 0, 1);
            this.LMain_tableLayout.Controls.Add(this.BtnHistory, 0, 2);
            this.LMain_tableLayout.Controls.Add(this.BtnInfo, 0, 3);
            this.LMain_tableLayout.Controls.Add(this.BtnQuit, 0, 7);
            this.LMain_tableLayout.Controls.Add(this.Lbl_Info_name, 0, 4);
            this.LMain_tableLayout.Controls.Add(this.Lbl_Info_username, 0, 5);
            this.LMain_tableLayout.Location = new System.Drawing.Point(52, 9);
            this.LMain_tableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.LMain_tableLayout.Name = "LMain_tableLayout";
            this.LMain_tableLayout.RowCount = 8;
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LMain_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LMain_tableLayout.Size = new System.Drawing.Size(155, 750);
            this.LMain_tableLayout.TabIndex = 54;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrint.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnPrint.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnPrint.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnPrint.DownBack")));
            this.BtnPrint.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnPrint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(22, 112);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrint.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnPrint.MouseBack")));
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnPrint.NormlBack")));
            this.BtnPrint.Radius = 12;
            this.BtnPrint.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnPrint.Size = new System.Drawing.Size(110, 40);
            this.BtnPrint.TabIndex = 20;
            this.BtnPrint.Text = "证书列表";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnHistory.BackColor = System.Drawing.Color.Transparent;
            this.BtnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnHistory.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnHistory.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnHistory.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnHistory.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnHistory.DownBack")));
            this.BtnHistory.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnHistory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHistory.ForeColor = System.Drawing.Color.White;
            this.BtnHistory.Location = new System.Drawing.Point(22, 224);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnHistory.MouseBack")));
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnHistory.NormlBack")));
            this.BtnHistory.Radius = 12;
            this.BtnHistory.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnHistory.Size = new System.Drawing.Size(110, 40);
            this.BtnHistory.TabIndex = 21;
            this.BtnHistory.Text = "打印历史";
            this.BtnHistory.UseVisualStyleBackColor = false;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnInfo.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnInfo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnInfo.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnInfo.DownBack")));
            this.BtnInfo.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.Location = new System.Drawing.Point(22, 336);
            this.BtnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInfo.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnInfo.MouseBack")));
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnInfo.NormlBack")));
            this.BtnInfo.Radius = 12;
            this.BtnInfo.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnInfo.Size = new System.Drawing.Size(110, 40);
            this.BtnInfo.TabIndex = 49;
            this.BtnInfo.Text = "使用帮助";
            this.BtnInfo.UseVisualStyleBackColor = false;
            // 
            // BtnQuit
            // 
            this.BtnQuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnQuit.BackColor = System.Drawing.Color.Salmon;
            this.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnQuit.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnQuit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnQuit.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnQuit.DownBack")));
            this.BtnQuit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnQuit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(22, 673);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQuit.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnQuit.MouseBack")));
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnQuit.NormlBack")));
            this.BtnQuit.Radius = 12;
            this.BtnQuit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnQuit.Size = new System.Drawing.Size(110, 40);
            this.BtnQuit.TabIndex = 48;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // Lbl_Info_name
            // 
            this.Lbl_Info_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_Info_name.AutoSize = true;
            this.Lbl_Info_name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Info_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Info_name.ForeColor = System.Drawing.Color.White;
            this.Lbl_Info_name.Location = new System.Drawing.Point(3, 475);
            this.Lbl_Info_name.Name = "Lbl_Info_name";
            this.Lbl_Info_name.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_Info_name.Size = new System.Drawing.Size(106, 20);
            this.Lbl_Info_name.TabIndex = 2;
            this.Lbl_Info_name.Text = "姓名：陈 X X";
            // 
            // Lbl_Info_username
            // 
            this.Lbl_Info_username.AutoSize = true;
            this.Lbl_Info_username.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Info_username.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Info_username.ForeColor = System.Drawing.Color.White;
            this.Lbl_Info_username.Location = new System.Drawing.Point(3, 523);
            this.Lbl_Info_username.Name = "Lbl_Info_username";
            this.Lbl_Info_username.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Lbl_Info_username.Size = new System.Drawing.Size(130, 20);
            this.Lbl_Info_username.TabIndex = 0;
            this.Lbl_Info_username.Text = "学号：41216020";
            // 
            // FrmHelp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PrinterManager.Properties.Resources.MainBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.LMain_tableLayout);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.PanelTips);
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.PicArrow３);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHelp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            this.PanelTips.ResumeLayout(false);
            this.PanelTips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tips)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrow３)).EndInit();
            this.LMain_tableLayout.ResumeLayout(false);
            this.LMain_tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox PicArrow３;
        private System.Windows.Forms.Label Lbl_Time;
        private CCWin.SkinControl.SkinPanel PanelTips;
        private CCWin.SkinControl.SkinLabel Lbl_Tips;
        private CCWin.SkinControl.SkinPanel MainLayoutPanel;
        private CCWin.SkinControl.SkinPictureBox Pic_Tips;
        private Timer Timer_Now;
        private TableLayoutPanel LMain_tableLayout;
        private CCWin.SkinControl.SkinButton BtnPrint;
        private CCWin.SkinControl.SkinButton BtnHistory;
        private CCWin.SkinControl.SkinButton BtnInfo;
        private CCWin.SkinControl.SkinButton BtnQuit;
        private Label Lbl_Info_name;
        private Label Lbl_Info_username;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label12;
    }
}