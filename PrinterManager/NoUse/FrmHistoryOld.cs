using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PrintClass;
using PrinterManager.SDK;
using System.Globalization;

namespace PrinterManager
{
    public partial class FrmHistoryOld : Form
    {
        DataTable dt = new DataTable();//所有数据
        DataTable Temp = new DataTable();//筛选所需数据，临时变量
        int RowsCount = 0;     //总记录数
        int RowsSet = 8;
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号
        int currentRow = 0;      //当前记录行
        int nStartPos = 0;   //当前页面开始记录行
        int nEndPos = 5;     //当前页面结束记录行
        bool ProcessResult;

        public FrmHistoryOld()
        {
            InitializeComponent();
            SetStyles();            
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

        private void Frm_History_Load(object sender, EventArgs e)
        {
            SetStyles();
            Frm_History_Init();
        }

        public void Frm_History_Init()
        {
            try
            {
                Txt_TimeStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
                Txt_TimeEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");
                //标签框绘制
                for (int i = 0; i < RowsSet; i++)
                {
                    TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + (i + 1).ToString(), true)[0];
                    TLP.BackgroundImage = Properties.Resources.frame_select;
                    TLP.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (MyInfo.History_Results.Rows.Count == 0)
                {
                    MyInfo.History_Results.Columns.Clear();
                    MyInfo.History_Results.Rows.Clear();
                    MyInfo.History_Results.Columns.Add("createdate");
                    MyInfo.History_Results.Columns.Add("no");
                    MyInfo.History_Results.Columns.Add("printaddress");
                }
                //CalTotal();
                RowsCount = MyInfo.History_Results.Rows.Count;
                Temp.Rows.Clear();
                pageCount = (RowsCount / RowsSet);
                if ((RowsCount % RowsSet) > 0)
                {
                    pageCount++;
                }
                if (pageCount == 0)
                    pageCount = 1;
                pageCurrent = 1;    //当前页数从1开始
                currentRow = 0;       //当前记录数从0开始
                DataRow[] dr = MyInfo.History_Results.Select();
                Temp = MyInfo.History_Results.Clone();
                TempInit(dr);
                List_Data(Temp);
            }
            catch { }
        }

        #region 网络正常时发送jason并接收
        public void LoadHistoryData(int i)
        {
            if (InternetStatus.IsConnectInternet())
            {
                try
                {
                    string start = new DateTime(2016, 8, 30).ToString("yyyyMMddHHmmss");
                    string end = DateTime.Now.ToString("yyyyMMddHHmmss");
                    Print05 Print05param = new Print05();
                    Print05param.SetBody(MyInfo.MyUserInfo.UserID, i, RowsSet, start, end);
                    string JsonData = DictConvert.RequestJson<Print05>(Print05param);            //post数据包;
                    string result = AccessAPI.PostHttp(MyInfo.URL, JsonData, "application/json");            //解析Json数据
                    string type = Function.SelectOutPrint<Print05Out>(result);//判断接口类型
                    ProcessResult = DictConvert.JsonToList(type, result);
                }
                catch { }
            }
            else
            {
                FrmErro netmsg = new FrmErro();
                netmsg.Show("网络连接不畅", FrmErro.CYException.NetConnect, FrmErro.CYButtons.OK, FrmErro.CYIcon.Warning);
                this.Focus();
                ProcessResult = false;
            }
        }
    #endregion

        #region 空表时联网读取成绩打印历史的字段
        public void CalTotal()//计算总数、生成DataTable
        {
            try
            {
                int i = 0;
                int pagetotal = 0;
                do
                    {
                        RowsCount += pagetotal;
                        LoadHistoryData(i);

                        if (ProcessResult)
                        {
                            pagetotal = MyInfo.MyUserInfo.print_list.Count();
                            Data_binding(MyInfo.MyUserInfo.print_list);
                            //MyInfo.MyUserInfo.print_list[]
                            ProcessResult = false;
                        }
                        i += RowsSet;
                    }
                    while (pagetotal == RowsSet);
                RowsCount += pagetotal;
                RowsCount = MyInfo.History_Results.Rows.Count;
                //Console.WriteLine(RowsCount);
            }
            catch { }
        }
        #endregion

        #region dt表格标签显示
        void List_Data(DataTable m_dt)
        {
            try
            {
                if (pageCurrent == pageCount)
                {
                    nEndPos = RowsCount;
                }
                else
                {
                    nEndPos = RowsSet * pageCurrent;
                }
                nStartPos = currentRow;
                Lbl_CurPageValue.Text = pageCurrent.ToString() + "/" + pageCount.ToString();

                CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
                string format = "yyyyMMdd";

                for (int i = 0; i < (nEndPos - nStartPos); i++)
                {
                    Label lbl1 = (Label)this.Controls.Find("Label" + (i + 1).ToString() + "1", true)[0];
                    int rowIndex = Convert.ToInt32(lbl1.Name.Substring(5, 1));
                    string stringValue = m_dt.Rows[nStartPos + i]["createdate"].ToString().Substring(0, 8); // 得到日期字符串
                    DateTime datetime = DateTime.ParseExact(stringValue, format, cultureInfo); // 将字符串转换成日期
                    lbl1.Text = datetime.ToString("yyyy-MM-dd");
                    //lbl1.Text = DateTime.ParseExact(m_dt.Rows[nStartPos + i]["createdate"].ToString(), "yyyyMMddHHmmss", null).ToString("yyyy-MM-dd");
                    Label lbl2 = (Label)this.Controls.Find("Label" + (i + 1).ToString() + "2", true)[0];
                    lbl2.Text = m_dt.Rows[nStartPos+i]["no"].ToString();
                    Label lbl3 = (Label)this.Controls.Find("Label" + (i + 1).ToString() + "3", true)[0];
                    lbl3.Text = m_dt.Rows[nStartPos+i]["printaddress"].ToString();
                }
                for (int j = (nEndPos - nStartPos); j < RowsSet; j++)
                {
                    Label lbl1 = (Label)this.Controls.Find("Label" + (j + 1).ToString() + "1", true)[0];
                    int rowIndex = Convert.ToInt32(lbl1.Name.Substring(5, 1));
                    lbl1.Text = "";
                    Label lbl2 = (Label)this.Controls.Find("Label" + (j + 1).ToString() + "2", true)[0];
                    lbl2.Text = "";
                    Label lbl3 = (Label)this.Controls.Find("Label" + (j + 1).ToString() + "3", true)[0];
                    lbl3.Text = "";
                }
            }
            catch { }
        }
        #endregion

        private void TempInit(DataRow[] m_dr)
        {

            for (int i = 0; i < m_dr.Length; i++)
            {
                Temp.ImportRow(m_dr[i]);
            }
            
        }

        #region 字段绑定到表格
        public void Data_binding(List<print_list> mlist)
        {
            try
            {
                foreach (var print_list in mlist)
                {
                    DataRow dr = MyInfo.History_Results.NewRow();
                    dr["createdate"] = print_list.createdate;
                    dr["no"] = print_list.no;
                    dr["printaddress"] = print_list.printaddress;
                    MyInfo.History_Results.Rows.Add(dr);
                }
            }
            catch { }
        }
        #endregion

        #region 查询日期区间成绩单
        private void Btn_Seekfor_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            //try
            //{
            string MaxValue = DateTime.Parse(Txt_TimeEnd.Text).ToString("yyyy-MM-dd");
            string MinValue = DateTime.Parse(Txt_TimeStart.Text).ToString("yyyy-MM-dd");
            if (DateTime.Parse(MinValue) > DateTime.Parse(MaxValue))
                {
                FrmErro datemsg = new FrmErro();
                    datemsg.Show("截止日期小于起始日期", FrmErro.CYException.DateEx, FrmErro.CYButtons.OK, FrmErro.CYIcon.Warning);
                };
                MaxValue = DateTime.Parse(Txt_TimeEnd.Text).AddDays(+1).ToString("yyyy-MM-dd");
                CalTotal();
                Temp.Clear();
                DataRow[] dr = MyInfo.History_Results.Select("createdate >= '" + MinValue + "' and createdate <= '" + MaxValue + "'", "createdate desc");
                RowsCount = dr.Length;
                pageCount = (RowsCount / RowsSet);
                if ((RowsCount % RowsSet) > 0)
                {
                    pageCount++;
                }
                if (pageCount == 0)
                    pageCount = 1;
                pageCurrent = 1;    //当前页数从1开始
                currentRow = 0;       //当前记录数从0开始
                TempInit(dr);
                List_Data(Temp);
            //}
        //    catch { }
        }
        #endregion

        #region 翻页按钮
        private void Lbl_Next_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent++;
            if (pageCurrent > pageCount)
            {
                FrmErro pagemsg = new FrmErro();
                if (pagemsg.Show("已经是最后一页！", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Information) == DialogResult.OK)
                    this.Focus();
                pageCurrent = pageCount;
                return;
            }
            else
            {
                currentRow = RowsSet * (pageCurrent - 1);
                List_Data(Temp);
            }
            
        }//下一页

        private void Lbl_Front_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = 1;
            currentRow = RowsSet * (pageCurrent - 1);
            List_Data(Temp); 
        }//首页

        private void Lbl_Final_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = pageCount;
            currentRow = RowsSet * (pageCurrent - 1);
            List_Data(Temp);
        }//末页

        private void Lbl_Back_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent--;
            if (pageCurrent <= 0)
            {
                FrmErro pagemsg = new FrmErro();
                if (pagemsg.Show("已经是第一页！", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Information) == DialogResult.OK)
                    this.Focus();
                pageCurrent=1;
                return;
            }
            else
            {
                currentRow = RowsSet * (pageCurrent - 1);
                List_Data(Temp);
            }
            
        }
    #endregion
        
        #region 标签点击重回打印界面
        //单击标签
        private void TLP_Click(object sender, EventArgs e)
        {
            int row=1;
            try
            {
                if (typeof(TableLayoutPanel).IsInstanceOfType(sender))
                {
                    TableLayoutPanel TLPsel = sender as TableLayoutPanel;
                    row = Convert.ToInt32(TLPsel.Name.Substring(16, 1));
                }
                if (typeof(Label).IsInstanceOfType(sender))
                {
                    Label Lblsel = sender as Label;
                    row = Convert.ToInt32(Lblsel.Name.Substring(5, 1));
                }

                Label lblview = (Label)this.Controls.Find("label" + row.ToString() + "2", true)[0];
                string resultsno = "";
                string m_printnum = "";
                resultsno = lblview.Text;
                m_printnum = GetPrintnum(resultsno);
                DownFile.DownloadFile(GetUrl(resultsno));
                FrmView view = new FrmView(this, resultsno, MyInfo.DownloadPath + System.IO.Path.GetFileName(GetUrl(resultsno))/*".pdf"*/, m_printnum);
                view.ShowDialog();
            }
            catch { }
        }

        //返回下载地址
        private string GetUrl(string Gradeno)
        {
            DataRow[] geturl = MyInfo.All_Results.Select("no = '" + Gradeno + "'");//选择该行
            string m_url = geturl[0]["url"].ToString();
            return m_url;
        }

        //返回打印份数
        private string GetPrintnum(string Gradeno)
        {
         
            DataRow[] geturl = MyInfo.All_Results.Select("no = '" + Gradeno + "'");//选择该行
            string m_printnum = geturl[0]["printnum"].ToString();
            return m_printnum;
        }
        
        private void TLP_MouseLeave(object sender, EventArgs e)
        {   
            int row=0;
            try
            {
                if (typeof(Label).IsInstanceOfType(sender))
                {
                    Label lblsel = sender as Label;
                    row = Convert.ToInt32(lblsel.Name.Substring(5, 1));
                }
                if (typeof(TableLayoutPanel).IsInstanceOfType(sender))
                {
                    TableLayoutPanel TLPsel = sender as TableLayoutPanel;
                    row = Convert.ToInt32(TLPsel.Name.Substring(16, 1));
                }
            }
            catch { }
            TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + row.ToString(), true)[0];
            TLP.BackgroundImage = Properties.Resources.frame_select;
            TLP.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void TLP_MouseEnter(object sender, EventArgs e)
        {
            int row = 0;
            try
            {
                if (typeof(Label).IsInstanceOfType(sender))
                {
                    Label lblsel = sender as Label;
                    row = Convert.ToInt32(lblsel.Name.Substring(5, 1));
                }
                if (typeof(TableLayoutPanel).IsInstanceOfType(sender))
                {
                    TableLayoutPanel TLPsel = sender as TableLayoutPanel;
                    row = Convert.ToInt32(TLPsel.Name.Substring(16, 1));
                }
            }
            catch { }
            TableLayoutPanel TLPselect = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + row.ToString(), true)[0];
            TLPselect.BackgroundImage = Properties.Resources.frame_unselect;
            TLPselect.BackgroundImageLayout = ImageLayout.Stretch;
        }

        #endregion

        private void Txt_TimeStart_Click(object sender, EventArgs e)
        {
            FrmCalendar calendar = new FrmCalendar(DateTime.Parse(Txt_TimeStart.Text).Year.ToString(), DateTime.Parse(Txt_TimeStart.Text).Month.ToString(), DateTime.Parse(Txt_TimeStart.Text).Day.ToString());
            calendar.ShowDialog();  //必须使用ShowDialog()函数,否则不能正常进行参数传递  
            Txt_TimeStart.Text = DateTime.Parse(calendar.SetYear + "-" + calendar.SetMonth + "-" + calendar.SetDay).ToString("yyyy-MM-dd");
        }

        private void Txt_TimeEnd_Click(object sender, EventArgs e)
        {
            FrmCalendar calendar = new FrmCalendar(DateTime.Parse(Txt_TimeEnd.Text).Year.ToString(), DateTime.Parse(Txt_TimeEnd.Text).Month.ToString(), DateTime.Parse(Txt_TimeEnd.Text).Day.ToString());
            calendar.ShowDialog();  //必须使用ShowDialog()函数,否则不能正常进行参数传递  
            Txt_TimeEnd.Text = DateTime.Parse(calendar.SetYear + "-" + calendar.SetMonth + "-" + calendar.SetDay).ToString("yyyy-MM-dd");
        }

        private void Label02_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
