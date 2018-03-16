using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PrinterManager
{
    public partial class FrmErro : CCWin.CCSkinMain
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);

        public FrmErro()
        {
            InitializeComponent();
        }

        private void FrmErro_Load(object sender, EventArgs e)
        {
        }
        
        #region [减少闪烁方法]
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

        #region[异常信息定义]
        public enum CYIcon
        {
            Information,
            Warning
        }
        #endregion

        public void InfoStatements(string _msg1)
        {
            Btn_Return.Visible = false;
            Lbl_AnotherTip.Text = "";
            switch (_msg1)
            {
                case "40007":
                    Btn_Return.Visible = true;
                    Lbl_AnotherTip.Text = "请联系管理员 " + Data.deviceInfo.data.adminname + " " + Data.deviceInfo.data.address;
                    break;
                case "30000":
                    Lbl_AnotherTip.Text = "请联系管理员 " + Data.deviceInfo.data.adminname + " " + Data.deviceInfo.data.address;
                    break;
                case "30002":
                    Lbl_AnotherTip.Text = "请联系管理员 " + Data.deviceInfo.data.adminname + " " + Data.deviceInfo.data.address;
                    break;
                default:
                    Lbl_AnotherTip.Text = "";
                    break;
            }
            Lbl_Erro.Text = _msg1;
        }

        #region [信息显示]
        public DialogResult Show(string Msg,CYIcon MIcon)
        {
            this.TopMost = true;
            InfoStatements(Msg);
            IconStatements(MIcon);
            ShowDialog();
            return DialogResult;
        }
        #endregion

        #region [信息图标确认]
        public void IconStatements(CYIcon MIcon)
        {
            if (MIcon == CYIcon.Information)
            {
                MessageBeep(0);
                Pic_Icon.BackgroundImage = Properties.Resources.Info;
                Pic_Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (MIcon == CYIcon.Warning)
            {
                Function.Sound_stop();
                Pic_Icon.BackgroundImage = Properties.Resources.Warning;
                Pic_Icon.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        #endregion

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Return_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
