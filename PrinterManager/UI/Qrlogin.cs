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

namespace PrinterManager
{
    public partial class Qrlogin : CCWin.CCSkinMain
    {
        //int i = 0;
        SynchronizationContext m_SyncContext = null;
        //delegate void LoginCallback(string text);
        
        //扫码判断
        private volatile bool canStop = false;
        TimeSpan ts = new TimeSpan(0, 0, 5);

        public Qrlogin()
        {
            InitializeComponent();
            SetStyles();
            m_SyncContext = SynchronizationContext.Current;
            TopMost = true;
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

        /// <summary>
        /// 线程的主体方法
        /// </summary>
        private void ThreadProcSafePost()
        {
            //...执行线程任务

            //在线程中更新UI（通过UI线程同步上下文m_SyncContext）
            m_SyncContext.Post(SetUIPost, "This text was set safely by SynchronizationContext-Post.");

            //...执行线程其他任务
        }

        /// <summary>
        /// 更新文本框内容的方法
        /// </summary>
        /// <param name="text"></param>
        private void SetUIPost(object text)
        {
            pictureBox_yes.Visible = true;
            btn_Qrlogin.Visible = true;
            timer_Check.Enabled = true;
            canStop = true;
        }

        private void QrCodeInit()
        {

        }

        private Image TransparentImage(Image srcImage, float opacity)
        {
            float[][] nArray ={ new float[] {1, 0, 0, 0, 0},  
                        new float[] {0, 1, 0, 0, 0},  
                        new float[] {0, 0, 1, 0, 0},  
                        new float[] {0, 0, 0, opacity, 0},  
                        new float[] {0, 0, 0, 0, 1}};
            ColorMatrix matrix = new ColorMatrix(nArray);
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Bitmap resultImage = new Bitmap(srcImage.Width, srcImage.Height);
            Graphics g = Graphics.FromImage(resultImage);
            g.DrawImage(srcImage, new Rectangle(0, 0, srcImage.Width, srcImage.Height), 0, 0, srcImage.Width, srcImage.Height, GraphicsUnit.Pixel, attributes);

            return resultImage;
        }  
        //透明度调节

        private void Qrlogin_Load(object sender, EventArgs e)
        {
            pictureBox_yes.Visible = false;
            btnfreshQrCode.Visible = false;
            QrCodeInit();
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; 
            pictureBox1.Enabled = false;
            btn_QrQuit.Visible = true;
            btn_Qrlogin.Visible = false;
        }

        private void Timer_Check_Tick(object sender, EventArgs e)
        {
            String str = "扫码成功 ("+ ts.Seconds.ToString()+")s";
            label_tip.Text = str;//label17用来显示剩余的时间
            ts = ts.Subtract(new TimeSpan(0, 0, 1));//每隔一秒减去一秒
            if (ts.TotalSeconds < 0.0)//当倒计时完毕
            {
                timer_Check.Enabled = false;
                MessageBox.Show("请重新扫码");//提示时间到
                this.Dispose();
            }
        }

        private void Btn_Qrlogin_Click(object sender, EventArgs e)
        {
            string qrcode="";//解析二维码获得
            try
            {
                if (Function.QrCodeLoadDataFunc(qrcode)) 
                {
                    string QueryQRCode_respond = ServerInterface.QueryQRCode_post(qrcode.ToString(), Data.AppConfig.Deviceno);
                    FrmResultInfo m_result = new FrmResultInfo();
                    m_result.ShowDialog();
                }

            }
            catch { }
            this.Dispose();
        }

        private void Btn_QrQuit_Click(object sender, EventArgs e)
        {
            canStop = true;
            timer_Check.Enabled = false;
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }


    }
}
