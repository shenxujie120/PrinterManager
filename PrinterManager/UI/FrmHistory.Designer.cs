using System.Drawing;
using System.Windows.Forms;
using System;
namespace PrinterManager
{
    partial class FrmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.PanelTips = new CCWin.SkinControl.SkinPanel();
            this.Pic_Tips = new CCWin.SkinControl.SkinPictureBox();
            this.Lbl_Tips = new CCWin.SkinControl.SkinLabel();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.MainLayoutPanel = new CCWin.SkinControl.SkinPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel0 = new System.Windows.Forms.TableLayoutPanel();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.btn_Seekfor = new CCWin.SkinControl.SkinButton();
            this.Txt_TimeEnd = new System.Windows.Forms.TextBox();
            this.Txt_TimeStart = new System.Windows.Forms.TextBox();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.BtnNextPage = new CCWin.SkinControl.SkinButton();
            this.BtnFrontPage = new CCWin.SkinControl.SkinButton();
            this.BtnFirstPage = new CCWin.SkinControl.SkinButton();
            this.BtnLastPage = new CCWin.SkinControl.SkinButton();
            this.Lbl_CurPage = new System.Windows.Forms.Label();
            this.Lbl_CurPageValue = new System.Windows.Forms.Label();
            this.PicArrow2 = new CCWin.SkinControl.SkinPictureBox();
            this.Lbl_Info_username = new System.Windows.Forms.Label();
            this.Lbl_Info_name = new System.Windows.Forms.Label();
            this.BtnQuit = new CCWin.SkinControl.SkinButton();
            this.BtnInfo = new CCWin.SkinControl.SkinButton();
            this.BtnHistory = new CCWin.SkinControl.SkinButton();
            this.BtnPrint = new CCWin.SkinControl.SkinButton();
            this.LMain_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Timer_Now = new System.Windows.Forms.Timer(this.components);
            this.PanelTips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tips)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrow2)).BeginInit();
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
            this.Pic_Tips.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.Lbl_Tips.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel9);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel8);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel7);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel6);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel5);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel4);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel3);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel2);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainLayoutPanel.Controls.Add(this.tableLayoutPanel0);
            this.MainLayoutPanel.Controls.Add(this.btn_Seekfor);
            this.MainLayoutPanel.Controls.Add(this.Txt_TimeEnd);
            this.MainLayoutPanel.Controls.Add(this.Txt_TimeStart);
            this.MainLayoutPanel.Controls.Add(this.lbl_EndTime);
            this.MainLayoutPanel.Controls.Add(this.lbl_StartTime);
            this.MainLayoutPanel.Controls.Add(this.BtnNextPage);
            this.MainLayoutPanel.Controls.Add(this.BtnFrontPage);
            this.MainLayoutPanel.Controls.Add(this.BtnFirstPage);
            this.MainLayoutPanel.Controls.Add(this.BtnLastPage);
            this.MainLayoutPanel.Controls.Add(this.Lbl_CurPage);
            this.MainLayoutPanel.Controls.Add(this.Lbl_CurPageValue);
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
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel9.BackgroundImage")));
            this.tableLayoutPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel9.Controls.Add(this.label91, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label92, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label93, 2, 0);
            this.tableLayoutPanel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(45, 471);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel9.TabIndex = 95;
            this.tableLayoutPanel9.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel9.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel9.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label91
            // 
            this.label91.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.Transparent;
            this.label91.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label91.Location = new System.Drawing.Point(100, 9);
            this.label91.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(0, 21);
            this.label91.TabIndex = 0;
            this.label91.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.Transparent;
            this.label92.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label92.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label92.Location = new System.Drawing.Point(421, 9);
            this.label92.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(0, 21);
            this.label92.TabIndex = 1;
            this.label92.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label93
            // 
            this.label93.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.Transparent;
            this.label93.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label93.Location = new System.Drawing.Point(742, 9);
            this.label93.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(0, 21);
            this.label93.TabIndex = 2;
            this.label93.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel8.BackgroundImage")));
            this.tableLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.Controls.Add(this.label81, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label82, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label83, 2, 0);
            this.tableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(45, 426);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel8.TabIndex = 94;
            this.tableLayoutPanel8.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel8.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel8.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label81
            // 
            this.label81.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label81.Location = new System.Drawing.Point(100, 9);
            this.label81.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(0, 21);
            this.label81.TabIndex = 0;
            this.label81.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label82
            // 
            this.label82.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label82.AutoSize = true;
            this.label82.BackColor = System.Drawing.Color.Transparent;
            this.label82.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label82.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label82.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label82.Location = new System.Drawing.Point(421, 9);
            this.label82.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(0, 21);
            this.label82.TabIndex = 1;
            this.label82.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label83
            // 
            this.label83.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label83.Location = new System.Drawing.Point(742, 9);
            this.label83.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(0, 21);
            this.label83.TabIndex = 2;
            this.label83.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel7.BackgroundImage")));
            this.tableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.Controls.Add(this.label71, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label72, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label73, 2, 0);
            this.tableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(45, 381);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel7.TabIndex = 93;
            this.tableLayoutPanel7.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel7.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel7.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label71
            // 
            this.label71.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label71.Location = new System.Drawing.Point(100, 9);
            this.label71.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(0, 21);
            this.label71.TabIndex = 0;
            this.label71.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label72
            // 
            this.label72.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label72.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label72.Location = new System.Drawing.Point(421, 9);
            this.label72.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(0, 21);
            this.label72.TabIndex = 1;
            this.label72.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label73
            // 
            this.label73.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label73.Location = new System.Drawing.Point(742, 9);
            this.label73.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(0, 21);
            this.label73.TabIndex = 2;
            this.label73.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel6.BackgroundImage")));
            this.tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.label61, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label62, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label63, 2, 0);
            this.tableLayoutPanel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(45, 336);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel6.TabIndex = 92;
            this.tableLayoutPanel6.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel6.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel6.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label61.Location = new System.Drawing.Point(100, 9);
            this.label61.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(0, 21);
            this.label61.TabIndex = 0;
            this.label61.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label62.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label62.Location = new System.Drawing.Point(421, 9);
            this.label62.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(0, 21);
            this.label62.TabIndex = 1;
            this.label62.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label63.Location = new System.Drawing.Point(742, 9);
            this.label63.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(0, 21);
            this.label63.TabIndex = 2;
            this.label63.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel5.BackgroundImage")));
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.label51, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label52, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label53, 2, 0);
            this.tableLayoutPanel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(45, 291);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel5.TabIndex = 91;
            this.tableLayoutPanel5.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel5.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel5.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label51
            // 
            this.label51.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label51.Location = new System.Drawing.Point(100, 9);
            this.label51.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(0, 21);
            this.label51.TabIndex = 0;
            this.label51.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label52.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label52.Location = new System.Drawing.Point(421, 9);
            this.label52.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(0, 21);
            this.label52.TabIndex = 1;
            this.label52.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label53.Location = new System.Drawing.Point(742, 9);
            this.label53.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(0, 21);
            this.label53.TabIndex = 2;
            this.label53.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel4.BackgroundImage")));
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label42, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label43, 2, 0);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(45, 246);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel4.TabIndex = 90;
            this.tableLayoutPanel4.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel4.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel4.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label41.Location = new System.Drawing.Point(100, 9);
            this.label41.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(0, 21);
            this.label41.TabIndex = 0;
            this.label41.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label42.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label42.Location = new System.Drawing.Point(421, 9);
            this.label42.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(0, 21);
            this.label42.TabIndex = 1;
            this.label42.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label43.Location = new System.Drawing.Point(742, 9);
            this.label43.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(0, 21);
            this.label43.TabIndex = 2;
            this.label43.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel3.BackgroundImage")));
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label32, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label33, 2, 0);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(45, 201);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel3.TabIndex = 89;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel3.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel3.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Location = new System.Drawing.Point(100, 9);
            this.label31.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 21);
            this.label31.TabIndex = 0;
            this.label31.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.Location = new System.Drawing.Point(421, 9);
            this.label32.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 21);
            this.label32.TabIndex = 1;
            this.label32.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label33.Location = new System.Drawing.Point(742, 9);
            this.label33.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 21);
            this.label33.TabIndex = 2;
            this.label33.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label22, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label23, 2, 0);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(45, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel2.TabIndex = 88;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel2.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(100, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 21);
            this.label21.TabIndex = 0;
            this.label21.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(421, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 21);
            this.label22.TabIndex = 1;
            this.label22.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(742, 9);
            this.label23.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 21);
            this.label23.TabIndex = 2;
            this.label23.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel1.TabIndex = 87;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(100, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 21);
            this.label11.TabIndex = 0;
            this.label11.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(421, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 21);
            this.label12.TabIndex = 1;
            this.label12.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(742, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 21);
            this.label13.TabIndex = 2;
            this.label13.Click += new System.EventHandler(this.TLP_Click);
            // 
            // tableLayoutPanel0
            // 
            this.tableLayoutPanel0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel0.BackgroundImage")));
            this.tableLayoutPanel0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel0.ColumnCount = 3;
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel0.Controls.Add(this.label01, 0, 0);
            this.tableLayoutPanel0.Controls.Add(this.label02, 1, 0);
            this.tableLayoutPanel0.Controls.Add(this.label03, 2, 0);
            this.tableLayoutPanel0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel0.Location = new System.Drawing.Point(45, 66);
            this.tableLayoutPanel0.Name = "tableLayoutPanel0";
            this.tableLayoutPanel0.RowCount = 1;
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel0.Size = new System.Drawing.Size(964, 40);
            this.tableLayoutPanel0.TabIndex = 86;
            this.tableLayoutPanel0.Click += new System.EventHandler(this.TLP_Click);
            this.tableLayoutPanel0.MouseEnter += new System.EventHandler(this.TLP_MouseEnter);
            this.tableLayoutPanel0.MouseLeave += new System.EventHandler(this.TLP_MouseLeave);
            // 
            // label01
            // 
            this.label01.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label01.AutoSize = true;
            this.label01.BackColor = System.Drawing.Color.Transparent;
            this.label01.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label01.Location = new System.Drawing.Point(100, 9);
            this.label01.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(0, 21);
            this.label01.TabIndex = 0;
            this.label01.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label02
            // 
            this.label02.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label02.AutoSize = true;
            this.label02.BackColor = System.Drawing.Color.Transparent;
            this.label02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label02.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label02.Location = new System.Drawing.Point(421, 9);
            this.label02.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(0, 21);
            this.label02.TabIndex = 1;
            this.label02.Click += new System.EventHandler(this.TLP_Click);
            // 
            // label03
            // 
            this.label03.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label03.AutoSize = true;
            this.label03.BackColor = System.Drawing.Color.Transparent;
            this.label03.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label03.Location = new System.Drawing.Point(742, 9);
            this.label03.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(0, 21);
            this.label03.TabIndex = 2;
            this.label03.Click += new System.EventHandler(this.TLP_Click);
            // 
            // btn_Seekfor
            // 
            this.btn_Seekfor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Seekfor.BackColor = System.Drawing.Color.Transparent;
            this.btn_Seekfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Seekfor.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.btn_Seekfor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Seekfor.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Seekfor.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_Seekfor.DownBack")));
            this.btn_Seekfor.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Seekfor.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Seekfor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Seekfor.ForeColor = System.Drawing.Color.White;
            this.btn_Seekfor.Location = new System.Drawing.Point(920, 13);
            this.btn_Seekfor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Seekfor.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_Seekfor.MouseBack")));
            this.btn_Seekfor.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Seekfor.Name = "btn_Seekfor";
            this.btn_Seekfor.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_Seekfor.NormlBack")));
            this.btn_Seekfor.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_Seekfor.Size = new System.Drawing.Size(90, 35);
            this.btn_Seekfor.TabIndex = 85;
            this.btn_Seekfor.Text = "查询";
            this.btn_Seekfor.UseVisualStyleBackColor = false;
            this.btn_Seekfor.Click += new System.EventHandler(this.btn_Seekfor_Click);
            // 
            // Txt_TimeEnd
            // 
            this.Txt_TimeEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_TimeEnd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_TimeEnd.Location = new System.Drawing.Point(284, 19);
            this.Txt_TimeEnd.Name = "Txt_TimeEnd";
            this.Txt_TimeEnd.Size = new System.Drawing.Size(100, 29);
            this.Txt_TimeEnd.TabIndex = 84;
            this.Txt_TimeEnd.Click += new System.EventHandler(this.Txt_TimeEnd_Click);
            // 
            // Txt_TimeStart
            // 
            this.Txt_TimeStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Txt_TimeStart.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_TimeStart.Location = new System.Drawing.Point(124, 19);
            this.Txt_TimeStart.Name = "Txt_TimeStart";
            this.Txt_TimeStart.Size = new System.Drawing.Size(100, 29);
            this.Txt_TimeStart.TabIndex = 83;
            this.Txt_TimeStart.Click += new System.EventHandler(this.Txt_TimeStart_Click);
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EndTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_EndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.lbl_EndTime.Location = new System.Drawing.Point(231, 19);
            this.lbl_EndTime.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(44, 21);
            this.lbl_EndTime.TabIndex = 82;
            this.lbl_EndTime.Text = "——";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StartTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_StartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.lbl_StartTime.Location = new System.Drawing.Point(42, 23);
            this.lbl_StartTime.Margin = new System.Windows.Forms.Padding(30, 3, 0, 3);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(74, 21);
            this.lbl_StartTime.TabIndex = 81;
            this.lbl_StartTime.Text = "查询日期";
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
            this.BtnNextPage.TabIndex = 79;
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
            this.BtnFrontPage.TabIndex = 78;
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
            this.BtnFirstPage.TabIndex = 77;
            this.BtnFirstPage.Text = "首页";
            this.BtnFirstPage.UseVisualStyleBackColor = false;
            this.BtnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
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
            this.BtnLastPage.TabIndex = 80;
            this.BtnLastPage.Text = "末页";
            this.BtnLastPage.UseVisualStyleBackColor = false;
            this.BtnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // Lbl_CurPage
            // 
            this.Lbl_CurPage.AutoSize = true;
            this.Lbl_CurPage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_CurPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
            this.Lbl_CurPage.Location = new System.Drawing.Point(840, 531);
            this.Lbl_CurPage.Name = "Lbl_CurPage";
            this.Lbl_CurPage.Size = new System.Drawing.Size(129, 21);
            this.Lbl_CurPage.TabIndex = 56;
            this.Lbl_CurPage.Text = "当前页/总页数：";
            // 
            // Lbl_CurPageValue
            // 
            this.Lbl_CurPageValue.AutoSize = true;
            this.Lbl_CurPageValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_CurPageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_CurPageValue.Location = new System.Drawing.Point(975, 531);
            this.Lbl_CurPageValue.Name = "Lbl_CurPageValue";
            this.Lbl_CurPageValue.Size = new System.Drawing.Size(35, 21);
            this.Lbl_CurPageValue.TabIndex = 57;
            this.Lbl_CurPageValue.Text = "1/1";
            // 
            // PicArrow2
            // 
            this.PicArrow2.BackColor = System.Drawing.Color.Transparent;
            this.PicArrow2.BackgroundImage = global::PrinterManager.Properties.Resources.arrow;
            this.PicArrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicArrow2.Location = new System.Drawing.Point(226, 233);
            this.PicArrow2.Name = "PicArrow2";
            this.PicArrow2.Size = new System.Drawing.Size(55, 40);
            this.PicArrow2.TabIndex = 50;
            this.PicArrow2.TabStop = false;
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
            this.LMain_tableLayout.TabIndex = 53;
            // 
            // Timer_Now
            // 
            this.Timer_Now.Enabled = true;
            this.Timer_Now.Interval = 1000;
            this.Timer_Now.Tick += new System.EventHandler(this.Timer_Now_Tick);
            // 
            // FrmHistory
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
            this.Controls.Add(this.PicArrow2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            this.PanelTips.ResumeLayout(false);
            this.PanelTips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Tips)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel0.ResumeLayout(false);
            this.tableLayoutPanel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicArrow2)).EndInit();
            this.LMain_tableLayout.ResumeLayout(false);
            this.LMain_tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox PicArrow2;
        private System.Windows.Forms.Label Lbl_Time;
        private CCWin.SkinControl.SkinPanel PanelTips;
        private CCWin.SkinControl.SkinLabel Lbl_Tips;
        private CCWin.SkinControl.SkinPanel MainLayoutPanel;
        private Label Lbl_Info_username;
        private Label Lbl_Info_name;
        private CCWin.SkinControl.SkinButton BtnQuit;
        private CCWin.SkinControl.SkinButton BtnInfo;
        private CCWin.SkinControl.SkinButton BtnHistory;
        private CCWin.SkinControl.SkinButton BtnPrint;
        private TableLayoutPanel LMain_tableLayout;
        private CCWin.SkinControl.SkinPictureBox Pic_Tips;
        private Timer Timer_Now;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label91;
        private Label label92;
        private Label label93;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label81;
        private Label label82;
        private Label label83;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label71;
        private Label label72;
        private Label label73;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label61;
        private Label label62;
        private Label label63;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label51;
        private Label label52;
        private Label label53;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label41;
        private Label label42;
        private Label label43;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label31;
        private Label label32;
        private Label label33;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label21;
        private Label label22;
        private Label label23;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label label12;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel0;
        private Label label01;
        private Label label02;
        private Label label03;
        private CCWin.SkinControl.SkinButton btn_Seekfor;
        private TextBox Txt_TimeEnd;
        private TextBox Txt_TimeStart;
        private Label lbl_EndTime;
        private Label lbl_StartTime;
        private CCWin.SkinControl.SkinButton BtnNextPage;
        private CCWin.SkinControl.SkinButton BtnFrontPage;
        private CCWin.SkinControl.SkinButton BtnFirstPage;
        private CCWin.SkinControl.SkinButton BtnLastPage;
        private Label Lbl_CurPage;
        private Label Lbl_CurPageValue;
    }
}