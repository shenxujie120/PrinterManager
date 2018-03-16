using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrinterManager.SDK;

using System.Globalization;
using System.Threading;

namespace PrinterManager
{
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            //ExtraFun.ShowWindow();
            InitializeComponent();
            SetStyles();
            
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

        //Load加载参数设置
        //DataTable dt = new DataTable();//所有数据
        DataTable Temp = new DataTable();//筛选所需数据，临时变量

        int RowsCount = 0;     //总记录数
        int RowsSet = 10;
        int pageCount = 1;    //页数＝总记录数/每页显示行数
        int pageCurrent = 1;   //当前页号
        int currentRow = 0;      //当前记录行
        int nStartPos = 0;   //当前页面开始记录行
        int nEndPos = 5;     //当前页面结束记录行

        //减少闪烁方法
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

        //证书打印列表放入表中
        private void FrmHistory_Load(object sender, EventArgs e)
        {
            Lbl_Tips.Text = "选择查询日期可查看";
            Lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
            TopMost = true;
            Frm_History_Init();
            //while(label01.Text=="");
        }

        ////声明一个delegate（委托）类型：ReadDataDelegate，该类型可以搭载返回值为空，无参数的方法。 
        //public delegate void ReadDataDelegate();
        ////声明一个ReadDataDelegate类型的对象。
        //public ReadDataDelegate ReadDataThread;        

        void Frm_History_Init()
        {
            MyInfo.History_Results.Columns.Clear();
            MyInfo.History_Results.Rows.Clear();
            //历史打印证书存入DataTable
            if (MyInfo.History_Results.Rows.Count == 0)
            {
                MyInfo.History_Results.Columns.Add("createdate");
                MyInfo.History_Results.Columns.Add("no");
                MyInfo.History_Results.Columns.Add("printaddress");
            }    
            
            //日期区间
            Txt_TimeStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Txt_TimeEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");

            Lbl_Info_name.Text = "姓名：" + MyInfo.MyUserInfo.UserName;
            Lbl_Info_username.Text = "学号：" + MyInfo.MyUserInfo.UserNo;

            //启动新线程
            //ReadDataThread=new ReadDataDelegate(CalTotal);
            //Thread Readhistory = new Thread(new ThreadStart(ReadDataThread));
            //Readhistory.Start();
            //while (Readhistory.ThreadState == ThreadState.Running) ;

            //与服务器连接，读取历史证书
            //计算翻页参数RowsCount、生成总DataTable
            CalTotal();
            
            DataRow[] dr = MyInfo.History_Results.Select();
            TempInit(dr);
            List_Data(Temp);//显示当前页的内容，Temp为所有的
            //}
            //catch { }
            //while (label01.Text == "1") ;
            //FrmWelcome.isHistoryShow = true;
        }

        private void btn_Seekfor_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            
            //日期区间
            string MaxValue = DateTime.Parse(Txt_TimeEnd.Text).ToString("yyyy-MM-dd");
            string MinValue = DateTime.Parse(Txt_TimeStart.Text).ToString("yyyy-MM-dd");
            if (DateTime.Parse(MinValue) > DateTime.Parse(MaxValue))
            {
                FrmErro datemsg = new FrmErro();
                datemsg.Show("截止日期小于起始日期", FrmErro.CYException.DateEx, FrmErro.CYButtons.OK, FrmErro.CYIcon.Warning);
            }
            MaxValue = DateTime.Parse(Txt_TimeEnd.Text).AddDays(+1).ToString("yyyy-MM-dd");
            
            //生成查询期间列表,刚打印证书不会生成
            //CalTotal();

            DataRow[] dr = MyInfo.History_Results.Select("createdate >= '" + MinValue + "' and createdate <= '" + MaxValue + "'", "createdate desc");

            TempInit(dr);
            RowsCount = dr.Length;
            //MessageBox.Show(RowsCount.ToString());
            pageCount = (RowsCount / RowsSet);
            if ((RowsCount % RowsSet) > 0)
            {
                pageCount++;
            }
            if (pageCount == 0)
                pageCount = 1;

            pageCurrent = 1;
            currentRow = RowsSet * (pageCurrent - 1);

            List_Data(Temp);
        }

        //把成绩转存入临时变量Temp
        void TempInit(DataRow [] dr)
        {
            Temp = MyInfo.History_Results.Clone();
            Temp.Rows.Clear();

            for (int i = 0; i < dr.Length; i++)
            {
                Temp.ImportRow(dr[i]);
            }
        }

        //计算翻页参数RowsCount、生成DataTable
        void CalTotal()
        {
            try
            {
                int i = 0;//开始记录数
                int pagetotal = 0;//当前页面记录数
                do
                {
                    RowsCount += pagetotal;
                    if (LoadHistoryData(i))
                    {
                        pagetotal = MyInfo.MyUserInfo.print_list.Count();
                        if (pagetotal != 0)
                        {
                            Data_binding(MyInfo.MyUserInfo.print_list);
                        }
                        //MyInfo.MyUserInfo.print_list[]
                        //ProcessResult = false;
                    }
                    i += RowsSet;
                }
                while (pagetotal == RowsSet);
                RowsCount += pagetotal;
                RowsCount = MyInfo.History_Results.Rows.Count;          
                
                //计算页数
                pageCount = (RowsCount / RowsSet);
                if ((RowsCount % RowsSet) > 0)
                {
                    pageCount++;
                }
                if (pageCount == 0)
                    pageCount = 1;

                //当前页数从1开始
                pageCurrent = 1;
                //当前记录数从0开始
                currentRow = 0;       
            }
            catch { }
        }

        bool LoadHistoryData(int i)
        {
            if (InternetStatus.IsConnectInternet())
            {
                string start = new DateTime(2016, 8, 30).ToString("yyyyMMddHHmmss");
                string end = DateTime.Now.ToString("yyyyMMddHHmmss");
                Print05 Print05param = new Print05();
                Print05param.SetBody(MyInfo.MyUserInfo.UserID, i, RowsSet, start, end);
                string JsonData = DictConvert.RequestJson<Print05>(Print05param);            //post数据包;
                string result = AccessAPI.PostHttp(MyInfo.URL, JsonData, "application/json");            //解析Json数据
                string type = Function.SelectOutPrint<Print05Out>(result);//判断接口类型
                //返回Json内容判断
                bool ProcessResult = DictConvert.JsonToList(type, result);
                return ProcessResult;
            }
            else
            {
                FrmErro netmsg = new FrmErro();
                netmsg.Show("网络连接不畅", FrmErro.CYException.NetConnect, FrmErro.CYButtons.OK, FrmErro.CYIcon.Warning);
                this.Focus();
                return false;
            }
        }
        
        //将读取的数据置入表History_Results中
        void Data_binding(List<print_list> mlist)
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

        //标签显示当前页的历史打印记录Temp
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
                    TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + i.ToString(), true)[0];
                    TLP.Visible = true;
                    Label lbl1 = (Label)this.Controls.Find("Label" + i.ToString() + "1", true)[0];
                    int rowIndex = Convert.ToInt32(lbl1.Name.Substring(5, 1));
                    string stringValue = m_dt.Rows[nStartPos + i]["createdate"].ToString().Substring(0, 8); // 得到日期字符串
                    DateTime datetime = DateTime.ParseExact(stringValue, format, cultureInfo); // 将字符串转换成日期
                    lbl1.Text = /*"打印日期： " + */ datetime.ToString("yyyy-MM-dd");

                    Label lbl2 = (Label)this.Controls.Find("Label" + i.ToString() + "2", true)[0];
                    lbl2.Text = /*"成绩编号： "+ */ m_dt.Rows[nStartPos + i]["no"].ToString();

                    Label lbl3 = (Label)this.Controls.Find("Label" + i.ToString() + "3", true)[0];
                    lbl3.Text = /*"打印地址： "+ */ m_dt.Rows[nStartPos + i]["printaddress"].ToString();
                }
                    for (int j = nEndPos; j < RowsSet*pageCurrent; j++)
                    {
                        HideTLP(j-nStartPos);
                    }
            }
            catch { }
        }

        private void HideTLP(int index)
        {
            TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + index.ToString(), true)[0];
            TLP.Visible = false;
        }

        //标签点击重回打印界面
        //单击标签
        private void TLP_Click(object sender, EventArgs e)
        {
            int row = 1;
            try
            {
                //判断单击的控件,Label OR panel
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
                
                string resultsno = lblview.Text;
                string url="";
                string printnum = "";
                GetInfo(resultsno,out url,out printnum);
                DownFile.DownloadFile(url);
                FrmView view = new FrmView(this, resultsno, MyInfo.DownloadPath + System.IO.Path.GetFileName(url)/*".pdf"*/, printnum);
                view.ShowDialog();
            }
            catch { }
        }

        //返回下载地址，已打印次数
        private void GetInfo(string Gradeno,out string url,out string printnum)
        {
            DataRow[] geturl = MyInfo.All_Results.Select("no = '" + Gradeno + "'");//选择该行
            url = geturl[0]["url"].ToString();
            printnum = geturl[0]["printnum"].ToString();
        }
        
        //光标移动
        private void TLP_MouseLeave(object sender, EventArgs e)
        {
            TableLayoutPanel TLPsel = sender as TableLayoutPanel;
            TLPsel.BackgroundImage = Properties.Resources.frame_unselect;
            TLPsel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void TLP_MouseEnter(object sender, EventArgs e)
        {
            TableLayoutPanel TLPsel = sender as TableLayoutPanel;
            TLPsel.BackgroundImage = Properties.Resources.frame_select;
            TLPsel.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        //自助打印界面
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_button();
            FrmMain main = new FrmMain();
            FrmWait.LoadAndRun(main);
            //main.ShowDialog();
            this.Dispose();
        }
        
        //使用帮助界面
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_button();
            //loading等待界面

            //WaitWnd.WaitWndFun waitForm = new WaitWnd.WaitWndFun();
            //waitForm.Show(this);
            //if (!FrmWelcome.isHelpShow)
            //{
            FrmHelp SysHelp = new FrmHelp();
                //FrmWait.LoadAndRun(SysHelp);
            SysHelp.ShowDialog();
            //}
            this.Dispose();
        }

        //查询时间选择
        private void Txt_TimeStart_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time=DateTime.Parse(Txt_TimeStart.Text);
            }
            catch (System.Exception){
                Txt_TimeStart.Text=DateTime.Now.ToString();
            }
            finally{
                DateTime time = DateTime.Parse(Txt_TimeStart.Text);
                FrmCalendar calendar = new FrmCalendar(time.Year.ToString(), time.Month.ToString(), time.Day.ToString());
                calendar.ShowDialog();  //必须使用ShowDialog()函数,否则不能正常进行参数传递  
                Txt_TimeStart.Text = DateTime.Parse(calendar.SetYear + "-" + calendar.SetMonth + "-" + calendar.SetDay).ToString("yyyy-MM-dd");
            }
            
        }

        private void Txt_TimeEnd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time = DateTime.Parse(Txt_TimeEnd.Text);
            }
            catch (System.Exception){
                Txt_TimeEnd.Text = DateTime.Now.ToString();
            }
            finally{
                DateTime time = DateTime.Parse(Txt_TimeEnd.Text);
                FrmCalendar calendar = new FrmCalendar(time.Year.ToString(), time.Month.ToString(), time.Day.ToString());
                calendar.ShowDialog();  //必须使用ShowDialog()函数,否则不能正常进行参数传递  
                Txt_TimeEnd.Text = DateTime.Parse(calendar.SetYear + "-" + calendar.SetMonth + "-" + calendar.SetDay).ToString("yyyy-MM-dd");
            }
        }
        
        //时间显示
        private void Timer_Now_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
        }

        //下一页
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            //是否超出页面范围
            pageCurrent++;
            if (pageCurrent > pageCount)
            {
                //使用异常处理类
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

        }

        //首页
        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = 1;
            currentRow = RowsSet * (pageCurrent - 1);
            List_Data(Temp);
        }
        
        //末页
        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = pageCount;
            currentRow = RowsSet * (pageCurrent - 1);
            List_Data(Temp);
        }
        
        //上一页
        private void BtnFrontPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent--;
            if (pageCurrent <= 0)
            {
                FrmErro pagemsg = new FrmErro();
                if (pagemsg.Show("已经是第一页！", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Information) == DialogResult.OK)
                    this.Focus();
                pageCurrent = 1;
                return;
            }
            else
            {
                currentRow = RowsSet * (pageCurrent - 1);
                List_Data(Temp);
            }

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                ExtraFun.Sound_stop();
                FrmErro outmsg = new FrmErro();
                if (outmsg.Show("确定退出用户？", FrmErro.CYException.Normal, FrmErro.CYButtons.OKReturn, FrmErro.CYIcon.Information) == DialogResult.OK)
                {
                    ExtraFun.Quit();
                    //this.Dispose();
                }
            }
            catch { }
        }

    }
}
