namespace Update
{
    partial class Frm_Update
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
            this.lvUpdateList = new System.Windows.Forms.ListView();
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_file = new System.Windows.Forms.Label();
            this.pbDownFile = new System.Windows.Forms.ProgressBar();
            this.lbState = new System.Windows.Forms.Label();
            this.lbl_versionInfo = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUpdateList
            // 
            this.lvUpdateList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFileName,
            this.chProgress});
            this.lvUpdateList.Location = new System.Drawing.Point(216, 12);
            this.lvUpdateList.Name = "lvUpdateList";
            this.lvUpdateList.Size = new System.Drawing.Size(260, 120);
            this.lvUpdateList.TabIndex = 6;
            this.lvUpdateList.UseCompatibleStateImageBehavior = false;
            this.lvUpdateList.View = System.Windows.Forms.View.Details;
            this.lvUpdateList.Visible = false;
            // 
            // chFileName
            // 
            this.chFileName.Text = "文件";
            this.chFileName.Width = 155;
            // 
            // chProgress
            // 
            this.chProgress.Text = "进度";
            this.chProgress.Width = 100;
            // 
            // lbl_file
            // 
            this.lbl_file.BackColor = System.Drawing.Color.Transparent;
            this.lbl_file.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_file.Location = new System.Drawing.Point(158, 180);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(350, 25);
            this.lbl_file.TabIndex = 7;
            this.lbl_file.Text = "   ";
            // 
            // pbDownFile
            // 
            this.pbDownFile.BackColor = System.Drawing.Color.White;
            this.pbDownFile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbDownFile.Location = new System.Drawing.Point(31, 208);
            this.pbDownFile.Name = "pbDownFile";
            this.pbDownFile.Size = new System.Drawing.Size(437, 24);
            this.pbDownFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDownFile.TabIndex = 5;
            // 
            // lbState
            // 
            this.lbState.BackColor = System.Drawing.Color.Transparent;
            this.lbState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbState.Location = new System.Drawing.Point(37, 180);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(204, 25);
            this.lbState.TabIndex = 4;
            this.lbState.Text = "检查更新中……";
            // 
            // lbl_versionInfo
            // 
            this.lbl_versionInfo.AutoSize = true;
            this.lbl_versionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_versionInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_versionInfo.Location = new System.Drawing.Point(103, 199);
            this.lbl_versionInfo.Name = "lbl_versionInfo";
            this.lbl_versionInfo.Size = new System.Drawing.Size(234, 21);
            this.lbl_versionInfo.TabIndex = 8;
            this.lbl_versionInfo.Text = "您当前使用的客户端是最新版本";
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Transparent;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_return.ForeColor = System.Drawing.Color.White;
            this.btn_return.Location = new System.Drawing.Point(401, 193);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 33);
            this.btn_return.TabIndex = 10;
            this.btn_return.Text = "知道了";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Frm_Update
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.lbl_versionInfo);
            this.Controls.Add(this.lvUpdateList);
            this.Controls.Add(this.pbDownFile);
            this.Controls.Add(this.lbState);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动更新";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUpdateList;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chProgress;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.ProgressBar pbDownFile;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbl_versionInfo;
        private System.Windows.Forms.Button btn_return;

    }
}