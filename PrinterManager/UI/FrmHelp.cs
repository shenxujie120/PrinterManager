using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrinterManager.SDK;


namespace PrinterManager
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_button();

            FrmMain main = new FrmMain();
            FrmWait.LoadAndRun(main);
            //main.ShowDialog();
            this.Dispose();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            Lbl_Tips.Text = "如仍有问题，请登录到梦空间官网 http://www.5idream.net";
            Lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");

            TopMost = true;
            //FrmWelcome.isHelpShow = true;
        }

        private void Timer_Now_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                ExtraFun.Sound_stop();
                FrmErro outmsg = new FrmErro();
                if (outmsg.Show("确定退出用户？", FrmErro.CYException.Normal, FrmErro.CYButtons.OKReturn, FrmErro.CYIcon.Information) == DialogResult.OK)
                {
                    //ExtraFun.Quit();
                }
            }
            catch { }
        }
    }
}
