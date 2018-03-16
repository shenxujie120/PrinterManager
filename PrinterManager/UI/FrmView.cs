using PdfPrintingNet;
using PrinterManager.SDK;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace PrinterManager
{
    public partial class FrmView : CCWin.CCSkinMain
    {
        Form fs = new Form();

        string address;
        string no;
        public string printnum;//
        static int printpapertnum;
        bool ProcessResult = false;

        public FrmView(Form f, string _no, string fileaddress, string m_PrintNum)
        {
            InitializeComponent();
            SetStyles();
            fs = f;

            address = fileaddress;
            no = _no;
            printnum = m_PrintNum;
            PDFView.Visible = false;
            PDFView.setPageMode("thumbs");
            PDFView.setPageMode("none");
            PDFView.LoadFile(address);
            PDFView.Visible = true;
            btn_Print.Focus();
        }

        private void Frm_View_Load(object sender, EventArgs e)
        {
            int iActulaWidth = Screen.PrimaryScreen.Bounds.Width;
            int iActulaHeight = Screen.PrimaryScreen.Bounds.Height;
            //this.Height = iActulaHeight;
            //this.Width = iActulaWidth / 2;
            this.Location = new Point(iActulaWidth / 4, 0);
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

        
        #region 按键功能
        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region 更新成绩Printnum和历史记录
        public void UpdateAllData(string no)
        {
            if (ProcessResult)
            {
                try
                {
                    string createdate = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string printaddress = MyInfo.MyDeviceInfo.AdminAddress;

                    DataRow dr = MyInfo.History_Results.NewRow();
                    dr["createdate"] = createdate;
                    dr["no"] = no;
                    dr["printaddress"] = printaddress;
                    //MessageBox.Show(MyInfo.History_Results.Rows.Count.ToString());
                    MyInfo.History_Results.Rows.Add(dr);
                    MyInfo.History_Results.DefaultView.Sort = "createdate DESC";
                    //MessageBox.Show(MyInfo.History_Results.Rows.Count.ToString());

                    DataRow result_dr = MyInfo.All_Results.Select("no='" + no + "'")[0];
                    result_dr.BeginEdit();
                    //MessageBox.Show(result_dr["no"].ToString() +" "+result_dr["printnum"].ToString());
                    result_dr["printnum"] = Convert.ToInt32(printnum) + 1;
                    //MessageBox.Show(result_dr["no"].ToString() + " " + result_dr["printnum"].ToString());
                    result_dr.EndEdit();
                    MyInfo.All_Results.AcceptChanges();

                    //更新剩余打印次数
                    MyInfo.PrintParameter.DidPrintNum++;
                    MyInfo.PrintParameter.RemainNum--;

                }
                catch { }
            }
            else
                return;
        }
        #endregion
    }
}
