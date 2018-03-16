using CCWin.SkinClass;

using PrinterManager.SDK;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using PdfPrintingNet;

namespace PrinterManager
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);
        //string[] Tips = {"\"证书列表\"查询日期区间内生成的成绩单","点选复选框可批量打印成绩单","请注意您的打印次数，避免影响您的体验","\"历史查询\"界面中可再次选择打印的成绩单","如有操作问题，请参照操作指南视频","设备提示故障时，请您不要操作，及时联系管理员"};
        //resizeForm resize = new resizeForm();
        
        //FrmResults results=new FrmResults();
        //FrmHistoryOld history=new FrmHistoryOld();

        //FrmWait loading = new FrmWait();
        //Button[] btnlist = new Button[5];

        public FrmMain()
        {
            InitializeComponent();
            SetStyles();
        }
        
        ////等待窗体线程服务
        //int times;
        //private void ExecWaitForm()
        //{
        //    try
        //    {
        //        WaitFormService.Show();



        //        times++;

        //        for (int i = 0; i < 10000; i++)
        //        {
        //            WaitFormService.SetText(times.ToString() + "正在执行 ，请耐心等待...." + i.ToString());
        //        }

        //        WaitFormService.Close();
        //        if (times == 3)
        //        {
        //            //button1.Enabled = true;
        //            return;
        //        }
        //        ExecWaitForm();


        //    }
        //    catch (Exception ex)
        //    {
        //        WaitFormService.Close();
        //    }
        //}

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

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

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //关闭SplashScreen
            SplashScreen.SetTitleString("加载完毕");
            SplashScreen.SetCommentaryString("..请您稍等");
            System.Threading.Thread.Sleep(500);
            SplashScreen.EndDisplay();
            TopMost = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //加载显示
            System.Threading.Thread.Sleep(500);

            SplashScreen.SetCommentaryString("..加载用户成绩");
            System.Threading.Thread.Sleep(500);

            SplashScreen.SetCommentaryString("..加载用户历史信息");
            System.Threading.Thread.Sleep(500);
            //history.Frm_History_Init();

            SplashScreen.SetCommentaryString("..加载窗体控件");
            System.Threading.Thread.Sleep(500);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //获取网络时间
            //Lbl_Time.Text = GetNetTime.GMT2Local(GetNetTime.GetNetDate()).ToString();
            Lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
            if (!MyInfo.PrintParameter.Limit)
                flowLayoutPanel_PaperLimit.Visible = false;
            if (MyInfo.Temp_Print.Columns.Count==0)
            {
                MyInfo.Temp_Print.Columns.Add("createdate");
                MyInfo.Temp_Print.Columns.Add("no");
                MyInfo.Temp_Print.Columns.Add("printaddress");
            }

            Lbl_Info_name.Text = "姓名：" + MyInfo.MyUserInfo.UserName;
            Lbl_Info_username.Text = "学号：" + MyInfo.MyUserInfo.UserNo;
            
            Lbl_Tips.Text = "点选复选框可选择打印成绩单";
            TopMost = true;

            FrmMain_Init();
            //label11.Text = "201608894823657834657";
            //label12.Text = "生成日期：12429373";
            //FrmWelcome.isMainShow = true;
            //FrmWelcome.isMainShow = true;
        }

        void FrmMain_Init()
        {
            if (!MyInfo.All_Results.Columns.Contains("url"))
            {
                MyInfo.All_Results.Columns.Clear();
                MyInfo.All_Results.Rows.Clear();
                MyInfo.All_Results.Columns.Add("no");
                MyInfo.All_Results.Columns.Add("url");
                MyInfo.All_Results.Columns.Add("createdate");
                MyInfo.All_Results.Columns.Add("printnum");
                MyInfo.All_Results.Columns.Add("freeprintnum");
            }
            CalTotal();
            dtInit();
            //隐藏选框
            pageCurrent = 1;    //当前页数从1开始
            currentRow = 0;
            List_data(dt);

            //if (MyInfo.PrintParameter.Limit != true)
            //{
            //    lbl_freeprintnum.Visible = false;
            //    label3.Visible = false;
            //    label8.Visible = false;
            //    lbl_Left.Visible = false;
            //    timer1.Enabled = false;
            //}
            //else
            //{
            //    label3.Visible = true;
            //    label8.Visible = true;
            //    lbl_freeprintnum.Visible = true;
            //    lbl_Left.Visible = true;
            //    timer1.Enabled = true;
            //}
        }

        private void dtInit()//所有成绩
        {
            dt = MyInfo.All_Results.Clone();
            dt.Rows.Clear();
            for (int i = 0; i < MyInfo.All_Results.Rows.Count; i++)
            {
                dt.ImportRow(MyInfo.All_Results.Rows[i]);
            }
        }

        private void CalTotal()
        {
            int i = 0;
            int pagetotal = 0;
            //if (MyInfo.All_Results.Rows.Count == 0)
            //{
            //ThreadStart threadStart = new ThreadStart(delegate()
            //{
            do
            {
                totalCount += pagetotal;
                LoadReusltsData(i);
                if (ProcessResult)
                {
                    pagetotal = MyInfo.MyUserInfo.quality_list.Count;
                    Data_binding(MyInfo.MyUserInfo.quality_list);
                    ProcessResult = false;
                }

                i += pageSize;
            } while (pagetotal == pageSize);

            //});
            //Thread thread = new Thread(threadStart)
            //{
            //    IsBackground = true
            //};
            //thread.Start();//多线程启动匿名方法
            //等待线程结束
            //while (thread.ThreadState != ThreadState.Stopped)
            //{
            //    //Thread.Sleep(10);
            //}
            totalCount += pagetotal;
            //}
            //totalCount = MyInfo.All_Results.Rows.Count;
            pageCount = (totalCount / pageSize);
            if ((totalCount % pageSize) > 0)
            {
                pageCount++;
            }
            Lbl_Totalval.Text = totalCount.ToString();

            //MyInfo.PrintParameter.LimitNum = Convert.ToInt32(MyInfo.All_Results.Rows[0]["freeprintnum"]);
        }

        private void List_data(DataTable Temp)
        {
            //try
            //{
            if (pageCurrent == pageCount)
            {
                nEndPos = totalCount;
            }
            else
            {
                nEndPos = pageSize * pageCurrent;
            }
            nStartPos = currentRow;
            label6.Text = pageCurrent.ToString() + "/" + pageCount.ToString();
            if (totalCount != 0)
            {
                for (int i = 0; i < (nEndPos - nStartPos); i++)
                {
                    TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (i + 1).ToString(), true)[0];
                    TLP.Visible = true;
                    Label lbl1 = (Label)this.Controls.Find("Label" + (i + 1).ToString() + "1", true)[0];
                    lbl1.Text = "    成绩编号：" + Temp.Rows[nStartPos + i]["no"].ToString();
                    int printnum = Convert.ToInt32(Temp.Rows[nStartPos + i]["printnum"]);
                    Label lbl2 = (Label)this.Controls.Find("Label" + (i + 1).ToString() + "2", true)[0];
                    string creatdate = DateTime.ParseExact(Temp.Rows[nStartPos + i]["createdate"].ToString().Substring(0, 14), "yyyyMMddHHmmss", null).ToString("yyyy-MM-dd hh:mm:ss");
                    lbl2.Text = "      生成时间：   " + creatdate + "   已打印次数 : " + printnum.ToString();
                }
                for (int i = nEndPos; i < pageSize*pageCurrent; i++)
                {
                    HideTLP(i-nStartPos);
                }
            }
        }

        private void HideTLP(int index)
        {
                TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (index + 1).ToString(), true)[0];
                TLP.Visible = false;
        }

        //POST请求获取Json数据，i开始记录数
        //private void LoadReusltsData(int i)
        //{
        //    try
        //    {
        //        Print04 Print04param = new Print04();
        //        Print04param.SetBody(MyInfo.MyUserInfo.UserID, i, pageSize);
        //        string JsonData = DictConvert.RequestJson<Print04>(Print04param);            //post数据包;
        //        string result = AccessAPI.PostHttp(MyInfo.URL, JsonData, "application/json");            //解析Json数据
        //        string type = Function.SelectOutPrint<Print04Out>(result);//判断接口类型
        //        ProcessResult = DictConvert.JsonToList(type, result);
        //    }
        //    catch
        //    {
        //        FrmErro netmsg = new FrmErro();
        //        if (netmsg.Show("网络连接异常", FrmErro.CYException.NetConnect, FrmErro.CYButtons.OK, FrmErro.CYIcon.Error) == DialogResult.OK)
        //            this.Focus();
        //        ProcessResult = false;
        //    }
        //}

        //private void Data_binding(List<quality_list> mlist)
        //{
        //    if (mlist.Count!=0)
        //    {
        //        foreach (var quality_list in mlist)
        //        {
        //            DataRow dr = MyInfo.All_Results.NewRow();
        //            dr["createdate"] = quality_list.createdate;
        //            dr["freeprintnum"] = quality_list.freeprintnum;
        //            dr["no"] = quality_list.no;
        //            dr["url"] = quality_list.url;
        //            dr["printnum"] = quality_list.printnum;
        //            MyInfo.All_Results.Rows.Add(dr);
        //            MyInfo.All_Results.DefaultView.Sort = "createdate DESC";
        //        }
        //    }
            
        //}



        //纸张判断
        private bool LackPaper()
        {
            if (MyInfo.MyDeviceInfo.Surplusprintpapernum < 20)
            {
                //FrmErro lackmsg = new FrmErro();
                //lackmsg.Show("", Frm_Msg.CYException.LackPaper, Frm_Msg.CYButtons.OK, Frm_Msg.CYIcon.Warning);
                return true;
            }
            else
                return false;
        }
        
        public delegate void HistoryInit();

        //证书参数
        //CheckBox[] CBlist = new CheckBox[6];
        DataTable dt = new DataTable();//所有数据

        int pageSize = 6;     //每页显示行数
        int totalCount = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号
        int currentRow = 0;      //当前记录行
        int nStartPos = 0;   //当前页面开始记录行
        int nEndPos = 5;     //当前页面结束记录行
        int pageSelectCount = 0;
        bool ProcessResult;
        //resizeForm resize = new resizeForm();
        string File_Adress = "";//证书的url

        //pageSelectCount = 0;
        //GradeNo记录证书编号，从表内提取
        //string GradeNo = "";

        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            if (pageCurrent == 0)
                pageCurrent = 1;
            //string m_PrintNum = "";
            
            CheckBox CB_Select = sender as CheckBox;
            int SelectIndex = Convert.ToInt32(CB_Select.Name.Substring(2, 1))-1;
            if (CB_Select.Checked)
            {
                CB_Select.BackgroundImage = Properties.Resources.Select;
                pageSelectCount++;
                //DoPrint(SelectIndex);
                SelectTLP(SelectIndex);
            }
            else
            {
                CB_Select.BackgroundImage = Properties.Resources.UnSelect;
                pageSelectCount--;
                TLPInit(SelectIndex);
            }
            int CurSelRow = (pageCurrent - 1) * pageSize + SelectIndex;

            lbl_ResultCount.Text = pageSelectCount.ToString();
        }
        
        //批量打印的表单
        List<doprint_list> templist = new List<doprint_list>();

        public List<doprint_list> Readtemp()
        {
            return templist;
        }

        //置入批量打印的表单中
        public void DoPrint()
        {
            for (int i = 0; i < 6; i++)
            {
                CheckBox CB_Select = (CheckBox)this.Controls.Find("CB" + (i + 1).ToString(), true)[0];
                if (CB_Select.Checked)
                {
                    int CurrentSelectRow = (pageCurrent - 1) * pageSize + i;

                    string url = dt.Rows[CurrentSelectRow]["url"].ToString();
                    DownFile.DownloadFile(url);
                    string LocalAddress = MyInfo.DownloadPath + System.IO.Path.GetFileName(url);

                    //计算文件页数
                    PdfPrint pdfPrinter = new PdfPrint("", "")
                    {
                        PrinterName = MyInfo.MyDeviceInfo.PrinterName
                    };
                    int PrintPapertNum = pdfPrinter.GetNumberOfPages(LocalAddress);

                    doprint_list item = new doprint_list()
                    {
                        no = dt.Rows[CurrentSelectRow]["no"].ToString(),
                        papernum = PrintPapertNum,
                        printaddress = LocalAddress,
                        printnum = dt.Rows[CurrentSelectRow]["printnum"].ToString(),
                    };
                    templist.Add(item);
                }
            }            

        }

        //TLP选择
        private void SelectTLP(int index)
        {
            TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (index + 1).ToString(), true)[0];
            //TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + (index + 1).ToString(), true)[0];
            TLP.BackgroundImage = global::PrinterManager.Properties.Resources.frame_select;
            TLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //tableLayoutPanel.BackColor = Color.Transparent;
        }
        
        //TLP未选
        private void TLPInit(int index)
        {
            TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (index + 1).ToString(), true)[0];
            TLP.BackgroundImage = global::PrinterManager.Properties.Resources.frame_unselect;
            TLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // 代理定义，可以在Invoke时传入相应的参数  
        //private delegate void funHandle(int nValue);
        //private funHandle myHandle = null; 
        //private FrmWait progressForm = new FrmWait();

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            //FrmWelcome.isMainShow = false;
            ExtraFun.Sound_button();
            //times = 0;
            //Thread th = new Thread(new ThreadStart(this.ExecWaitForm));
            //th.Start();

            //Splash
            //SplashScreen.Instance.Font = new Font("幼圆", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //SplashScreen.Instance.ForeColor = Color.White;
            //SplashScreen.Instance.Location = new Point(0, 0);
            //Image loading = Properties.Resources.Wait;
            //SplashScreen.SetBackgroundImage(loading);
            //SplashScreen.SetTitleString("正在加载");
            //SplashScreen.BeginDisplay();

            //FrmWait loading = new FrmWait();
            //loading.Show();

            ////启动线程  
            //Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadFun));
            //thread.Start();
            FrmHistory history = new FrmHistory();
            //if (!FrmWelcome.isHistoryShow)
            //{
            //FrmWait.LoadAndRun(history);
            history.ShowDialog();
            //}
            this.Dispose();
        }

        ///// <summary>  
        ///// 线程函数中调用的函数  
        ///// </summary>  
        //private void ShowProgressBar()
        //{
        //    myHandle = new funHandle(progressForm.SetProgressValue);
        //    progressForm.ShowDialog();
        //}

         /// <summary>
         /// //线程函数，用于处理调用  
         /// </summary>
         /// 
        //private void ThreadFun()
        //{
        //    MethodInvoker mi = new MethodInvoker(ShowProgressBar);
        //    this.BeginInvoke(mi);

        //    System.Threading.Thread.Sleep(1000); // sleep to show window  

        //    for (int i = 0; i < 1000; ++i)
        //    {
        //        System.Threading.Thread.Sleep(5);
        //        // 这里直接调用代理  
        //        this.Invoke(this.myHandle, new object[] { (i / 10) });
        //    }
        //}  

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            //FrmWelcome.isMainShow = false;
            ExtraFun.Sound_button();
            //if (!FrmWelcome.isHelpShow)
            //{
            FrmHelp SysHelp = new FrmHelp();
                //FrmWait.LoadAndRun(SysHelp);
            SysHelp.ShowDialog();
            //}
            this.Dispose();
        }

        private void BtnQuit_Click(object sender, EventArgs e)//退出账户并关闭pdf文件
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

        //批量打印，上传日志
        private void Btn_PrintAny_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_button();
            DoPrint();
            //MessageBox.Show(Readtemp().Count.ToString());
            if (Readtemp().Count == 0)
            {
                FrmErro msg = new FrmErro();
                msg.Show("未选择打印成绩单", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Warning);
                {
                    this.Focus();
                    return;
                }
            }

            //批量打印的证书表单
            for (int i = 0; i < Readtemp().Count; i++)
            {
                MyInfo.MyUserInfo.doprint_list = Readtemp();
                MyInfo.MyUserInfo.doprint_list[i].no = Readtemp()[i].no;
                MyInfo.MyUserInfo.doprint_list[i].papernum = System.Math.Abs(Readtemp()[i].papernum);
                MyInfo.MyUserInfo.doprint_list[i].printaddress = Readtemp()[i].printaddress;
                //MyInfo.MyUserInfo.doprint_list[i].printtime = Readtemp()[i].printtime;
                MyInfo.MyUserInfo.doprint_list[i].printnum = Readtemp()[i].printnum;
                FrmMsg _PrintAny = new FrmMsg();
                DialogResult _PrintResponse = _PrintAny.Show(i.ToString(), FrmMsg.CYException.PrintMessage, FrmMsg.CYButtons.OKSkipReturn, FrmMsg.CYIcon.Print);
                if (_PrintResponse == DialogResult.OK)
                {
                    FrmView view = new FrmView(this, MyInfo.MyUserInfo.doprint_list[i].no, MyInfo.MyUserInfo.doprint_list[i].printaddress, MyInfo.MyUserInfo.doprint_list[i].printnum);
                    if (view.IsPrintLimit())
                        return;
                    if (view.UpdatePrint(MyInfo.MyUserInfo.doprint_list[i].no))
                    {
                        view.UpdateAllData(MyInfo.MyUserInfo.doprint_list[i].no);
                        view.PrintPDF(MyInfo.MyUserInfo.doprint_list[i].no, MyInfo.MyUserInfo.doprint_list[i].printaddress);
                    }
                }
            }
        }

        //动态显示时间        
        private void Timer_Now_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(GetNetTime.GetNetDate().ToString());
            //Lbl_Time.Text = GetNetTime.GMT2Local(GetNetTime.GetNetDate()).ToString();
            Lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss dddd");
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();

            string m_PrintNum = "";
            string GradeNo = "";
            Button btnview = sender as Button;
            for (int i = 0; i < (nEndPos - nStartPos); i++)
            {
                if (btnview.Name == "btnview" + (i + 1).ToString())
                {
                    int CurSelRow = (pageCurrent - 1) * pageSize + i;
                    File_Adress = Convert.ToString(dt.Rows[CurSelRow]["url"].ToString());
                    GradeNo = dt.Rows[CurSelRow]["no"].ToString();
                    m_PrintNum = dt.Rows[CurSelRow]["printnum"].ToString();
                    MyInfo.PrintParameter.LimitNum = Convert.ToInt32(dt.Rows[CurSelRow]["freeprintnum"].ToString());
                    DownFile.DownloadFile(File_Adress);
                }
            }
            FrmView view = new FrmView(this, GradeNo, MyInfo.DownloadPath + System.IO.Path.GetFileName(File_Adress)/*".pdf"*/, m_PrintNum);
            view.ShowDialog();
            this.Focus();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            FrmSelectResult SelectResults = new FrmSelectResult();
            SelectResults.ShowDialog();
        }

        //首页
        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = 1;
            currentRow = pageSize * (pageCurrent - 1);
            List_data(dt);
        }

        //末页
        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = pageCount;
            currentRow = pageSize * (pageCurrent - 1);
            List_data(dt);
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
                currentRow = pageSize * (pageCurrent - 1);
                List_data(dt);
            }

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
                currentRow = pageSize * (pageCurrent - 1);
                List_data(dt);
            }

        }       

    }
}
