
using PrinterManager;
using System;
using System.Windows.Forms;
using System.Xml;

namespace PrinterManager
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void Frm_Welcome_Load(object sender, EventArgs e)
        {
            Function.ShowWindow();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackgroundImage = global::PrinterManager.Properties.Resources.Welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Focus();
            System.Threading.Thread.Sleep(500);                
        }

        #region 减少闪烁方法
        private void SetStyles()
        {
            //设置自定义控件Style
            this.SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时重绘
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// 双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);// 禁止擦除背景.
            this.SetStyle(ControlStyles.UserPaint, true);//自行绘制
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
        }
        #endregion

        #region 进入登录界面
        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            if (!Function.CheckForPrinter())
                return;
                try
                {
                    FrmLogin login = new FrmLogin();
                    login.Show();
                }
                catch //(Exception e)  
                { }            
        }
        #endregion

        #region 设置界面
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            //管理员密码输入
            Function.Readadmin(Data.AppConfig.Deviceno);
            FrmAdminPwd adminpwd = new FrmAdminPwd();
            adminpwd.ShowDialog();
 
        }
        #endregion
        
    }
}
