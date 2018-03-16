using System.Drawing;
using System.Windows.Forms;
using System;
namespace PrinterManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Timer_Now = new System.Windows.Forms.Timer(this.components);
            this.BtnPrint = new CCWin.SkinControl.SkinButton();
            this.BtnHistory = new CCWin.SkinControl.SkinButton();
            this.BtnPrintAny = new CCWin.SkinControl.SkinButton();
            this.BtnQuit = new CCWin.SkinControl.SkinButton();
            this.LMain_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnInfo = new CCWin.SkinControl.SkinButton();
            this.Lbl_Info_name = new System.Windows.Forms.Label();
            this.Lbl_Info_username = new System.Windows.Forms.Label();
            this.PanelTips = new CCWin.SkinControl.SkinPanel();
            this.Pic_Tips = new CCWin.SkinControl.SkinPictureBox();
            this.Lbl_Tips = new CCWin.SkinControl.SkinLabel();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.MainLayoutPanel = new CCWin.SkinControl.SkinPanel();
            this.flowLayoutPanel_PaperLimit = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_freeprintnum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Left = new System.Windows.Forms.Label();
            this.tableLP5 = new System.Windows.Forms.TableLayoutPanel();
            this.CB5 = new System.Windows.Forms.CheckBox();
            this.btnview5 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.btn_Select = new CCWin.SkinControl.SkinButton();
            this.tableLP2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnview2 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.tableLP1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnview1 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.tableLP3 = new System.Windows.Forms.TableLayoutPanel();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.btnview3 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.BtnNextPage = new CCWin.SkinControl.SkinButton();
            this.BtnFrontPage = new CCWin.SkinControl.SkinButton();
            this.BtnFirstPage = new CCWin.SkinControl.SkinButton();
            this.lbl_ResultCount = new System.Windows.Forms.Label();
            this.Lbl_TotalCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLP6 = new System.Windows.Forms.TableLayoutPanel();
            this.CB6 = new System.Windows.Forms.CheckBox();
            this.btnview6 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Totalval = new System.Windows.Forms.Label();
            this.tableLP4 = new System.Windows.Forms.TableLayoutPanel();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.btnview4 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.BtnLastPage = new CCWin.SkinControl.SkinButton();
            this.PicArrow1 = new CCWin.SkinControl.SkinPictureBox();
            this.LMain_tableLayout.SuspendLayout();
            this.PanelTips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tips)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.flowLayoutPanel_PaperLimit.SuspendLayout();
            this.tableLP5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLP2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLP1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLP3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLP6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLP4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrow1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Now
            // 
            this.Timer_Now.Enabled = true;
            this.Timer_Now.Interval = 1000;
            this.Timer_Now.Tick += new System.EventHandler(this.Timer_Now_Tick);
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
            // BtnPrintAny
            // 
            this.BtnPrintAny.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrintAny.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrintAny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPrintAny.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnPrintAny.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnPrintAny.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnPrintAny.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnPrintAny.DownBack")));
            this.BtnPrintAny.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnPrintAny.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPrintAny.ForeColor = System.Drawing.Color.White;
            this.BtnPrintAny.Location = new System.Drawing.Point(22, 598);
            this.BtnPrintAny.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrintAny.MouseBack = ((System.Drawing.Image)(resources.GetObject("BtnPrintAny.MouseBack")));
            this.BtnPrintAny.Name = "BtnPrintAny";
            this.BtnPrintAny.NormlBack = ((System.Drawing.Image)(resources.GetObject("BtnPrintAny.NormlBack")));
            this.BtnPrintAny.Radius = 12;
            this.BtnPrintAny.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnPrintAny.Size = new System.Drawing.Size(110, 40);
            this.BtnPrintAny.TabIndex = 23;
            this.BtnPrintAny.Text = "打印确认";
            this.BtnPrintAny.UseVisualStyleBackColor = false;
            this.BtnPrintAny.Click += new System.EventHandler(this.Btn_PrintAny_Click);
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
            // LMain_tableLayout
            // 
            this.LMain_tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.LMain_tableLayout.ColumnCount = 1;
            this.LMain_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LMain_tableLayout.Controls.Add(this.BtnPrint, 0, 1);
            this.LMain_tableLayout.Controls.Add(this.BtnHistory, 0, 2);
            this.LMain_tableLayout.Controls.Add(this.BtnInfo, 0, 3);
            this.LMain_tableLayout.Controls.Add(this.BtnQuit, 0, 7);
            this.LMain_tableLayout.Controls.Add(this.BtnPrintAny, 0, 6);
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
            this.LMain_tableLayout.TabIndex = 23;
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
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
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
            this.MainLayoutPanel.Controls.Add(this.flowLayoutPanel_PaperLimit);
            this.MainLayoutPanel.Controls.Add(this.tableLP5);
            this.MainLayoutPanel.Controls.Add(this.btn_Select);
            this.MainLayoutPanel.Controls.Add(this.tableLP2);
            this.MainLayoutPanel.Controls.Add(this.tableLP1);
            this.MainLayoutPanel.Controls.Add(this.tableLP3);
            this.MainLayoutPanel.Controls.Add(this.BtnNextPage);
            this.MainLayoutPanel.Controls.Add(this.BtnFrontPage);
            this.MainLayoutPanel.Controls.Add(this.BtnFirstPage);
            this.MainLayoutPanel.Controls.Add(this.lbl_ResultCount);
            this.MainLayoutPanel.Controls.Add(this.Lbl_TotalCount);
            this.MainLayoutPanel.Controls.Add(this.label1);
            this.MainLayoutPanel.Controls.Add(this.tableLP6);
            this.MainLayoutPanel.Controls.Add(this.label5);
            this.MainLayoutPanel.Controls.Add(this.label6);
            this.MainLayoutPanel.Controls.Add(this.Lbl_Totalval);
            this.MainLayoutPanel.Controls.Add(this.tableLP4);
            this.MainLayoutPanel.Controls.Add(this.BtnLastPage);
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
            // flowLayoutPanel_PaperLimit
            // 
            this.flowLayoutPanel_PaperLimit.Controls.Add(this.label3);
            this.flowLayoutPanel_PaperLimit.Controls.Add(this.lbl_freeprintnum);
            this.flowLayoutPanel_PaperLimit.Controls.Add(this.label8);
            this.flowLayoutPanel_PaperLimit.Controls.Add(this.lbl_Left);
            this.flowLayoutPanel_PaperLimit.Location = new System.Drawing.Point(483, 31);
            this.flowLayoutPanel_PaperLimit.Name = "flowLayoutPanel_PaperLimit";
            this.flowLayoutPanel_PaperLimit.Size = new System.Drawing.Size(282, 25);
            this.flowLayoutPanel_PaperLimit.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "本月免费次数：";
            // 
            // lbl_freeprintnum
            // 
            this.lbl_freeprintnum.AutoSize = true;
            this.lbl_freeprintnum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_freeprintnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_freeprintnum.Location = new System.Drawing.Point(122, 0);
            this.lbl_freeprintnum.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_freeprintnum.Name = "lbl_freeprintnum";
            this.lbl_freeprintnum.Size = new System.Drawing.Size(19, 21);
            this.lbl_freeprintnum.TabIndex = 67;
            this.lbl_freeprintnum.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(141, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 70;
            this.label8.Text = "剩余次数：";
            // 
            // lbl_Left
            // 
            this.lbl_Left.AutoSize = true;
            this.lbl_Left.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Left.Location = new System.Drawing.Point(231, 0);
            this.lbl_Left.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Left.Name = "lbl_Left";
            this.lbl_Left.Size = new System.Drawing.Size(19, 21);
            this.lbl_Left.TabIndex = 69;
            this.lbl_Left.Text = "0";
            // 
            // tableLP5
            // 
            this.tableLP5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLP5.BackgroundImage")));
            this.tableLP5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLP5.ColumnCount = 4;
            this.tableLP5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLP5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLP5.Controls.Add(this.CB5, 2, 0);
            this.tableLP5.Controls.Add(this.btnview5, 1, 0);
            this.tableLP5.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLP5.Location = new System.Drawing.Point(42, 370);
            this.tableLP5.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP5.Name = "tableLP5";
            this.tableLP5.RowCount = 1;
            this.tableLP5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP5.Size = new System.Drawing.Size(966, 66);
            this.tableLP5.TabIndex = 77;
            // 
            // CB5
            // 
            this.CB5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB5.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB5.AutoSize = true;
            this.CB5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB5.BackgroundImage")));
            this.CB5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.CB5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB5.ForeColor = System.Drawing.Color.White;
            this.CB5.Location = new System.Drawing.Point(879, 14);
            this.CB5.Name = "CB5";
            this.CB5.Size = new System.Drawing.Size(34, 37);
            this.CB5.TabIndex = 60;
            this.CB5.Text = "  ";
            this.CB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB5.UseVisualStyleBackColor = true;
            this.CB5.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // btnview5
            // 
            this.btnview5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnview5.BackColor = System.Drawing.Color.Transparent;
            this.btnview5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnview5.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnview5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnview5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnview5.DownBack = ((System.Drawing.Image)(resources.GetObject("btnview5.DownBack")));
            this.btnview5.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview5.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnview5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnview5.ForeColor = System.Drawing.Color.White;
            this.btnview5.Location = new System.Drawing.Point(740, 15);
            this.btnview5.Margin = new System.Windows.Forms.Padding(0);
            this.btnview5.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnview5.MouseBack")));
            this.btnview5.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview5.Name = "btnview5";
            this.btnview5.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnview5.NormlBack")));
            this.btnview5.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnview5.Size = new System.Drawing.Size(80, 35);
            this.btnview5.TabIndex = 59;
            this.btnview5.Text = "预览";
            this.btnview5.UseVisualStyleBackColor = false;
            this.btnview5.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label51, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label52, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.Location = new System.Drawing.Point(3, 4);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(0, 21);
            this.label51.TabIndex = 0;
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label52.ForeColor = System.Drawing.Color.Gray;
            this.label52.Location = new System.Drawing.Point(3, 35);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(0, 20);
            this.label52.TabIndex = 1;
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Select.BackColor = System.Drawing.Color.Transparent;
            this.btn_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Select.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btn_Select.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Select.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Select.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_Select.DownBack")));
            this.btn_Select.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Select.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Select.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.ForeColor = System.Drawing.Color.White;
            this.btn_Select.Location = new System.Drawing.Point(44, 17);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_Select.MouseBack")));
            this.btn_Select.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_Select.NormlBack")));
            this.btn_Select.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_Select.Size = new System.Drawing.Size(90, 35);
            this.btn_Select.TabIndex = 72;
            this.btn_Select.Text = "查询";
            this.btn_Select.UseVisualStyleBackColor = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // tableLP2
            // 
            this.tableLP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLP2.BackgroundImage")));
            this.tableLP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLP2.ColumnCount = 4;
            this.tableLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLP2.Controls.Add(this.btnview2, 1, 0);
            this.tableLP2.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLP2.Controls.Add(this.CB2, 2, 0);
            this.tableLP2.Location = new System.Drawing.Point(44, 145);
            this.tableLP2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP2.Name = "tableLP2";
            this.tableLP2.RowCount = 1;
            this.tableLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP2.Size = new System.Drawing.Size(966, 66);
            this.tableLP2.TabIndex = 60;
            // 
            // btnview2
            // 
            this.btnview2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnview2.BackColor = System.Drawing.Color.Transparent;
            this.btnview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnview2.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnview2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnview2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnview2.DownBack = ((System.Drawing.Image)(resources.GetObject("btnview2.DownBack")));
            this.btnview2.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnview2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnview2.ForeColor = System.Drawing.Color.White;
            this.btnview2.Location = new System.Drawing.Point(740, 15);
            this.btnview2.Margin = new System.Windows.Forms.Padding(0);
            this.btnview2.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnview2.MouseBack")));
            this.btnview2.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview2.Name = "btnview2";
            this.btnview2.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnview2.NormlBack")));
            this.btnview2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnview2.Size = new System.Drawing.Size(80, 35);
            this.btnview2.TabIndex = 56;
            this.btnview2.Text = "预览";
            this.btnview2.UseVisualStyleBackColor = false;
            this.btnview2.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(3, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 21);
            this.label21.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(3, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 20);
            this.label22.TabIndex = 1;
            // 
            // CB2
            // 
            this.CB2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB2.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB2.AutoSize = true;
            this.CB2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB2.BackgroundImage")));
            this.CB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.CB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB2.ForeColor = System.Drawing.Color.White;
            this.CB2.Location = new System.Drawing.Point(879, 14);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(34, 37);
            this.CB2.TabIndex = 57;
            this.CB2.Text = "  ";
            this.CB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB2.UseVisualStyleBackColor = true;
            this.CB2.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // tableLP1
            // 
            this.tableLP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLP1.BackgroundImage")));
            this.tableLP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLP1.ColumnCount = 4;
            this.tableLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLP1.Controls.Add(this.btnview1, 1, 0);
            this.tableLP1.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLP1.Controls.Add(this.CB1, 2, 0);
            this.tableLP1.Location = new System.Drawing.Point(44, 70);
            this.tableLP1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP1.Name = "tableLP1";
            this.tableLP1.RowCount = 1;
            this.tableLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP1.Size = new System.Drawing.Size(966, 66);
            this.tableLP1.TabIndex = 59;
            // 
            // btnview1
            // 
            this.btnview1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnview1.BackColor = System.Drawing.Color.Transparent;
            this.btnview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnview1.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnview1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnview1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnview1.DownBack = ((System.Drawing.Image)(resources.GetObject("btnview1.DownBack")));
            this.btnview1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnview1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnview1.ForeColor = System.Drawing.Color.White;
            this.btnview1.Location = new System.Drawing.Point(740, 15);
            this.btnview1.Margin = new System.Windows.Forms.Padding(0);
            this.btnview1.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnview1.MouseBack")));
            this.btnview1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview1.Name = "btnview1";
            this.btnview1.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnview1.NormlBack")));
            this.btnview1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnview1.Size = new System.Drawing.Size(80, 35);
            this.btnview1.TabIndex = 55;
            this.btnview1.Text = "预览";
            this.btnview1.UseVisualStyleBackColor = false;
            this.btnview1.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(3, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 1;
            // 
            // CB1
            // 
            this.CB1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB1.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB1.AutoSize = true;
            this.CB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB1.BackgroundImage")));
            this.CB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.CB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB1.ForeColor = System.Drawing.Color.White;
            this.CB1.Location = new System.Drawing.Point(879, 14);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(34, 37);
            this.CB1.TabIndex = 1;
            this.CB1.Text = "  ";
            this.CB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB1.UseVisualStyleBackColor = true;
            this.CB1.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // tableLP3
            // 
            this.tableLP3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLP3.BackgroundImage")));
            this.tableLP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLP3.ColumnCount = 4;
            this.tableLP3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLP3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLP3.Controls.Add(this.CB3, 2, 0);
            this.tableLP3.Controls.Add(this.btnview3, 1, 0);
            this.tableLP3.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLP3.Location = new System.Drawing.Point(44, 220);
            this.tableLP3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP3.Name = "tableLP3";
            this.tableLP3.RowCount = 1;
            this.tableLP3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP3.Size = new System.Drawing.Size(966, 66);
            this.tableLP3.TabIndex = 61;
            // 
            // CB3
            // 
            this.CB3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB3.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB3.AutoSize = true;
            this.CB3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB3.BackgroundImage")));
            this.CB3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.CB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB3.ForeColor = System.Drawing.Color.White;
            this.CB3.Location = new System.Drawing.Point(879, 14);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(34, 37);
            this.CB3.TabIndex = 58;
            this.CB3.Text = "  ";
            this.CB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB3.UseVisualStyleBackColor = true;
            this.CB3.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // btnview3
            // 
            this.btnview3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnview3.BackColor = System.Drawing.Color.Transparent;
            this.btnview3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnview3.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnview3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnview3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnview3.DownBack = ((System.Drawing.Image)(resources.GetObject("btnview3.DownBack")));
            this.btnview3.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnview3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnview3.ForeColor = System.Drawing.Color.White;
            this.btnview3.Location = new System.Drawing.Point(740, 15);
            this.btnview3.Margin = new System.Windows.Forms.Padding(0);
            this.btnview3.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnview3.MouseBack")));
            this.btnview3.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview3.Name = "btnview3";
            this.btnview3.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnview3.NormlBack")));
            this.btnview3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnview3.Size = new System.Drawing.Size(80, 35);
            this.btnview3.TabIndex = 57;
            this.btnview3.Text = "预览";
            this.btnview3.UseVisualStyleBackColor = false;
            this.btnview3.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(3, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 21);
            this.label31.TabIndex = 0;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.Color.Gray;
            this.label32.Location = new System.Drawing.Point(3, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 20);
            this.label32.TabIndex = 1;
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNextPage.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnNextPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnNextPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnNextPage.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnNextPage.DownBack")));
            this.BtnNextPage.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnNextPage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnNextPage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNextPage.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.Location = new System.Drawing.Point(273, 525);
            this.BtnNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNextPage.MouseBack = global::PrinterManager.Properties.Resources.btn_Mouse;
            this.BtnNextPage.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.NormlBack = global::PrinterManager.Properties.Resources.btn_norml;
            this.BtnNextPage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnNextPage.Size = new System.Drawing.Size(90, 35);
            this.BtnNextPage.TabIndex = 75;
            this.BtnNextPage.Text = "下一页";
            this.BtnNextPage.UseVisualStyleBackColor = false;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // BtnFrontPage
            // 
            this.BtnFrontPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnFrontPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnFrontPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFrontPage.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnFrontPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnFrontPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnFrontPage.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnFrontPage.DownBack")));
            this.BtnFrontPage.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFrontPage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnFrontPage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFrontPage.ForeColor = System.Drawing.Color.White;
            this.BtnFrontPage.Location = new System.Drawing.Point(160, 525);
            this.BtnFrontPage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFrontPage.MouseBack = global::PrinterManager.Properties.Resources.btn_Mouse;
            this.BtnFrontPage.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFrontPage.Name = "BtnFrontPage";
            this.BtnFrontPage.NormlBack = global::PrinterManager.Properties.Resources.btn_norml;
            this.BtnFrontPage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnFrontPage.Size = new System.Drawing.Size(90, 35);
            this.BtnFrontPage.TabIndex = 74;
            this.BtnFrontPage.Text = "上一页";
            this.BtnFrontPage.UseVisualStyleBackColor = false;
            this.BtnFrontPage.Click += new System.EventHandler(this.BtnFrontPage_Click);
            // 
            // BtnFirstPage
            // 
            this.BtnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFirstPage.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnFirstPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnFirstPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnFirstPage.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnFirstPage.DownBack")));
            this.BtnFirstPage.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFirstPage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnFirstPage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFirstPage.ForeColor = System.Drawing.Color.White;
            this.BtnFirstPage.Location = new System.Drawing.Point(46, 525);
            this.BtnFirstPage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFirstPage.MouseBack = global::PrinterManager.Properties.Resources.btn_Mouse;
            this.BtnFirstPage.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFirstPage.Name = "BtnFirstPage";
            this.BtnFirstPage.NormlBack = global::PrinterManager.Properties.Resources.btn_norml;
            this.BtnFirstPage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnFirstPage.Size = new System.Drawing.Size(90, 35);
            this.BtnFirstPage.TabIndex = 73;
            this.BtnFirstPage.Text = "首页";
            this.BtnFirstPage.UseVisualStyleBackColor = false;
            this.BtnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // lbl_ResultCount
            // 
            this.lbl_ResultCount.AutoSize = true;
            this.lbl_ResultCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ResultCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ResultCount.Location = new System.Drawing.Point(973, 31);
            this.lbl_ResultCount.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ResultCount.Name = "lbl_ResultCount";
            this.lbl_ResultCount.Size = new System.Drawing.Size(24, 21);
            this.lbl_ResultCount.TabIndex = 55;
            this.lbl_ResultCount.Text = " 0";
            // 
            // Lbl_TotalCount
            // 
            this.Lbl_TotalCount.AutoSize = true;
            this.Lbl_TotalCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_TotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.Lbl_TotalCount.Location = new System.Drawing.Point(714, 531);
            this.Lbl_TotalCount.Name = "Lbl_TotalCount";
            this.Lbl_TotalCount.Size = new System.Drawing.Size(90, 21);
            this.Lbl_TotalCount.TabIndex = 66;
            this.Lbl_TotalCount.Text = "总记录数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(923, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 65;
            this.label1.Text = "已选：";
            // 
            // tableLP6
            // 
            this.tableLP6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLP6.BackgroundImage")));
            this.tableLP6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLP6.ColumnCount = 4;
            this.tableLP6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLP6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLP6.Controls.Add(this.CB6, 2, 0);
            this.tableLP6.Controls.Add(this.btnview6, 1, 0);
            this.tableLP6.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLP6.Location = new System.Drawing.Point(42, 445);
            this.tableLP6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP6.Name = "tableLP6";
            this.tableLP6.RowCount = 1;
            this.tableLP6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP6.Size = new System.Drawing.Size(966, 66);
            this.tableLP6.TabIndex = 64;
            // 
            // CB6
            // 
            this.CB6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB6.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB6.AutoSize = true;
            this.CB6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB6.BackgroundImage")));
            this.CB6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.CB6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB6.ForeColor = System.Drawing.Color.White;
            this.CB6.Location = new System.Drawing.Point(879, 14);
            this.CB6.Name = "CB6";
            this.CB6.Size = new System.Drawing.Size(34, 37);
            this.CB6.TabIndex = 61;
            this.CB6.Text = "  ";
            this.CB6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB6.UseVisualStyleBackColor = true;
            this.CB6.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // btnview6
            // 
            this.btnview6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnview6.BackColor = System.Drawing.Color.Transparent;
            this.btnview6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnview6.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnview6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnview6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnview6.DownBack = ((System.Drawing.Image)(resources.GetObject("btnview6.DownBack")));
            this.btnview6.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview6.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnview6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnview6.ForeColor = System.Drawing.Color.White;
            this.btnview6.Location = new System.Drawing.Point(740, 15);
            this.btnview6.Margin = new System.Windows.Forms.Padding(0);
            this.btnview6.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnview6.MouseBack")));
            this.btnview6.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview6.Name = "btnview6";
            this.btnview6.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnview6.NormlBack")));
            this.btnview6.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnview6.Size = new System.Drawing.Size(80, 35);
            this.btnview6.TabIndex = 60;
            this.btnview6.Text = "预览";
            this.btnview6.UseVisualStyleBackColor = false;
            this.btnview6.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label61, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label62, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(3, 4);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(0, 21);
            this.label61.TabIndex = 0;
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.ForeColor = System.Drawing.Color.Gray;
            this.label62.Location = new System.Drawing.Point(3, 35);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(0, 20);
            this.label62.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(840, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "当前页/总页数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(975, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "1/1";
            // 
            // Lbl_Totalval
            // 
            this.Lbl_Totalval.AutoSize = true;
            this.Lbl_Totalval.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Totalval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_Totalval.Location = new System.Drawing.Point(807, 531);
            this.Lbl_Totalval.Name = "Lbl_Totalval";
            this.Lbl_Totalval.Size = new System.Drawing.Size(19, 21);
            this.Lbl_Totalval.TabIndex = 58;
            this.Lbl_Totalval.Text = "0";
            // 
            // tableLP4
            // 
            this.tableLP4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLP4.BackgroundImage")));
            this.tableLP4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLP4.ColumnCount = 4;
            this.tableLP4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLP4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLP4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLP4.Controls.Add(this.CB4, 2, 0);
            this.tableLP4.Controls.Add(this.btnview4, 1, 0);
            this.tableLP4.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLP4.Location = new System.Drawing.Point(44, 295);
            this.tableLP4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP4.Name = "tableLP4";
            this.tableLP4.RowCount = 1;
            this.tableLP4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLP4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLP4.Size = new System.Drawing.Size(966, 66);
            this.tableLP4.TabIndex = 62;
            // 
            // CB4
            // 
            this.CB4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CB4.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB4.AutoSize = true;
            this.CB4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CB4.BackgroundImage")));
            this.CB4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CB4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.CB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB4.ForeColor = System.Drawing.Color.White;
            this.CB4.Location = new System.Drawing.Point(879, 14);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(34, 37);
            this.CB4.TabIndex = 59;
            this.CB4.Text = "  ";
            this.CB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB4.UseVisualStyleBackColor = true;
            this.CB4.CheckedChanged += new System.EventHandler(this.CB_CheckedChanged);
            // 
            // btnview4
            // 
            this.btnview4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnview4.BackColor = System.Drawing.Color.Transparent;
            this.btnview4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnview4.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btnview4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnview4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnview4.DownBack = ((System.Drawing.Image)(resources.GetObject("btnview4.DownBack")));
            this.btnview4.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnview4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnview4.ForeColor = System.Drawing.Color.White;
            this.btnview4.Location = new System.Drawing.Point(740, 15);
            this.btnview4.Margin = new System.Windows.Forms.Padding(0);
            this.btnview4.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnview4.MouseBack")));
            this.btnview4.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnview4.Name = "btnview4";
            this.btnview4.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnview4.NormlBack")));
            this.btnview4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnview4.Size = new System.Drawing.Size(80, 35);
            this.btnview4.TabIndex = 58;
            this.btnview4.Text = "预览";
            this.btnview4.UseVisualStyleBackColor = false;
            this.btnview4.Click += new System.EventHandler(this.btnview_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label42, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(718, 60);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(3, 4);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 21);
            this.label41.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.ForeColor = System.Drawing.Color.Gray;
            this.label42.Location = new System.Drawing.Point(3, 35);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 20);
            this.label42.TabIndex = 1;
            // 
            // BtnLastPage
            // 
            this.BtnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.BtnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLastPage.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.BtnLastPage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.BtnLastPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BtnLastPage.DownBack = ((System.Drawing.Image)(resources.GetObject("BtnLastPage.DownBack")));
            this.BtnLastPage.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLastPage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BtnLastPage.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLastPage.ForeColor = System.Drawing.Color.White;
            this.BtnLastPage.Location = new System.Drawing.Point(387, 525);
            this.BtnLastPage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLastPage.MouseBack = global::PrinterManager.Properties.Resources.btn_Mouse;
            this.BtnLastPage.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLastPage.Name = "BtnLastPage";
            this.BtnLastPage.NormlBack = global::PrinterManager.Properties.Resources.btn_norml;
            this.BtnLastPage.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.BtnLastPage.Size = new System.Drawing.Size(90, 35);
            this.BtnLastPage.TabIndex = 76;
            this.BtnLastPage.Text = "末页";
            this.BtnLastPage.UseVisualStyleBackColor = false;
            this.BtnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // PicArrow1
            // 
            this.PicArrow1.BackColor = System.Drawing.Color.Transparent;
            this.PicArrow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicArrow1.BackgroundImage")));
            this.PicArrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicArrow1.Location = new System.Drawing.Point(226, 121);
            this.PicArrow1.Name = "PicArrow1";
            this.PicArrow1.Size = new System.Drawing.Size(55, 40);
            this.PicArrow1.TabIndex = 49;
            this.PicArrow1.TabStop = false;
            // 
            // FrmMain
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
            this.Controls.Add(this.PicArrow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.LMain_tableLayout.ResumeLayout(false);
            this.LMain_tableLayout.PerformLayout();
            this.PanelTips.ResumeLayout(false);
            this.PanelTips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tips)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.flowLayoutPanel_PaperLimit.ResumeLayout(false);
            this.flowLayoutPanel_PaperLimit.PerformLayout();
            this.tableLP5.ResumeLayout(false);
            this.tableLP5.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLP2.ResumeLayout(false);
            this.tableLP2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLP1.ResumeLayout(false);
            this.tableLP1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLP3.ResumeLayout(false);
            this.tableLP3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLP6.ResumeLayout(false);
            this.tableLP6.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLP4.ResumeLayout(false);
            this.tableLP4.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrow1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Now;
        private CCWin.SkinControl.SkinButton BtnPrint;
        private CCWin.SkinControl.SkinButton BtnHistory;
        private CCWin.SkinControl.SkinButton BtnPrintAny;
        private CCWin.SkinControl.SkinButton BtnQuit;
        private System.Windows.Forms.TableLayoutPanel LMain_tableLayout;
        private CCWin.SkinControl.SkinButton BtnInfo;
        private System.Windows.Forms.Label Lbl_Time;
        private CCWin.SkinControl.SkinPanel PanelTips;
        private CCWin.SkinControl.SkinPictureBox Pic_Tips;
        private CCWin.SkinControl.SkinLabel Lbl_Tips;
        private CCWin.SkinControl.SkinPictureBox PicArrow1;
        private CCWin.SkinControl.SkinPanel MainLayoutPanel;
        private System.Windows.Forms.Label Lbl_Info_name;
        private System.Windows.Forms.Label Lbl_Info_username;
        private CCWin.SkinControl.SkinButton btnview6;
        private CCWin.SkinControl.SkinButton btn_Select;
        private System.Windows.Forms.TableLayoutPanel tableLP2;
        private CCWin.SkinControl.SkinButton btnview2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLP1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private CCWin.SkinControl.SkinButton btnview1;
        private System.Windows.Forms.TableLayoutPanel tableLP3;
        private CCWin.SkinControl.SkinButton btnview3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private CCWin.SkinControl.SkinButton BtnNextPage;
        private CCWin.SkinControl.SkinButton BtnFrontPage;
        private CCWin.SkinControl.SkinButton BtnFirstPage;
        private System.Windows.Forms.Label lbl_ResultCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_freeprintnum;
        private System.Windows.Forms.Label Lbl_TotalCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLP6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_Totalval;
        private System.Windows.Forms.TableLayoutPanel tableLP4;
        private CCWin.SkinControl.SkinButton btnview4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private CCWin.SkinControl.SkinButton btnview5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private CCWin.SkinControl.SkinButton BtnLastPage;
        private System.Windows.Forms.TableLayoutPanel tableLP5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_PaperLimit;
        private System.Windows.Forms.CheckBox CB1;
        private CheckBox CB5;
        private CheckBox CB2;
        private CheckBox CB3;
        private CheckBox CB6;
        private CheckBox CB4;
    }
}