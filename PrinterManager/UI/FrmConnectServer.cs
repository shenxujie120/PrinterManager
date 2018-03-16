using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using PrinterManager.SDK;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace PrinterManager.UI
{
    public partial class FrmConnectServer : Form
    {
        int dotnum = 3;

        public FrmConnectServer()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            ExtraFun.HideWindow();
        }

        private void ConnectServer_Load(object sender, EventArgs e)
        {
            loadingCircle.SetCircleAppearance(18, 4, 10, 20);
            loadingCircle.Active = true;
            Timer_dot.Enabled = true;
            Timer_total.Enabled = true;
        }


        private void Start(string str)
        {
            lbl_loading.Text = str;
        }

        public void KillMe()
        {
            this.Close();
            this.Dispose();
        }

          private void Timer_dot_Tick(object sender, EventArgs e)
          {
              label1.Text += ".";
              if (label1.Text.Length > dotnum)
                  label1.Text = "";
          }

          private void Timer_total_Tick(object sender, EventArgs e)
          {
              if (InternetStatus.IsConnectInternet() == false)
              {
                  //Frm_Msg netmsg = new Frm_Msg();
                  //netmsg.Show("网络连接不畅", Frm_Msg.CYException.NetConnect, Frm_Msg.CYButtons.OK, Frm_Msg.CYIcon.Stop);
                  Start("网络连接不畅,请重试");
                  lbl_loading.ForeColor = Color.Red;
                  Thread.Sleep(500);
              }
              else
              {
                  //Start("网络连接正常");
                  Thread.Sleep(500);
                  KillMe();
              }
          }



    }
}
