using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

using System.Threading;
using System.Diagnostics;

using System.Runtime.InteropServices;

namespace PrinterManager
{

    public partial class FrmWait : Form
    {
        int dotnum = 3;

        public FrmWait()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //CheckForIllegalCrossThreadCalls = false;     
            //SetText("正在执行，请耐心等待....");  
            //ExtraFun.HideWindow();
        }

        private void Frm_Wait_Load(object sender, EventArgs e)
        {
            //loadingCircle.SetCircleAppearance(18, 4, 10, 20);
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer()
            {
                Enabled = true
            };
            timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            //loadingCircle.Active = true;
        }
        
        //public void SetProgressValue(int value)
        //{
        //    this.progressBar1.Value = value;
        //    this.label1.Text = "Progress :" + value.ToString() + "%";

        //    // 这里关闭，比较好，呵呵！  
        //    if (value == this.progressBar1.Maximum - 1) this.Close();
        //} 
  
        //private delegate void SetTextHandler(string text);  
        //public void SetText(string text)  
        //{  
        //    if (this.label1.InvokeRequired)  
        //    {  
        //        this.Invoke(new SetTextHandler(SetText), text);  
        //    }  
        //    else  
        //    {  
        //        lbl_loading.Text = text;
        //    }  
        //}

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text += ".";
            if (label1.Text.Length > dotnum)
                label1.Text = "";
        }

        public void KillMe(object o, EventArgs e)
        {
            //Thread.Sleep(1000);
            this.DialogResult = DialogResult.OK;
            //Invalidate(); 
            this.Dispose();
        }

        public static void LoadAndRun(Form form)
        {
            try
            {
                form.HandleCreated += delegate
                {
                    FrmWait loading = new FrmWait();
                    
                    //启动新线程来显示Splash窗体 
                    new Thread(new ThreadStart(delegate
                    {
                        //loading.ShowDialog();

                        //订阅主窗体的Shown事件 
                        //if(FrmWelcome.isHistoryShow||FrmWelcome.isHelpShow||FrmWelcome.isMainShow)
                        form.Shown += delegate
                        {
                            //通知Splash窗体关闭自身
                            
                            //Thread.Sleep(1000);
                            loading.Invoke(new EventHandler(loading.KillMe));
                            loading.Dispose();
                        };

                        //显示Splash窗体
                        //if (MyInfo.FirstLoad)
                        //{
                        //    MyInfo.FirstLoad = false;
                        //    loading.Show();
                        //}
                        //else
                        Application.Run(loading);    
                    })).Start();
                };
            }
            catch { }
            form.Show();
            //form.Focus();
        }

    }
}