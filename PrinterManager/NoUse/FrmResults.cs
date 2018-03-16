using PdfPrintingNet;
using PrintClass;
using PrinterManager.SDK;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PrinterManager
{
    public partial class FrmResults : Form
    {
        CheckBox[] CBlist = new CheckBox[6];
        Label[] lbllist1 = new Label[6];
        Label[] lbllist2 = new Label[6];
        TableLayoutPanel[] TLPlist = new TableLayoutPanel[6];
        TableLayoutPanel[] tableLayoutPanellist = new TableLayoutPanel[6];

        int pageSize = 6;     //每页显示行数
        int total = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号
        int currentRow = 0;      //当前记录行
        int nStartPos = 0;   //当前页面开始记录行
        int nEndPos = 5;     //当前页面结束记录行
        int pageSelectCount = 0;
        bool ProcessResult;

        string File_Adress = "";
        DataTable dt = new DataTable();//所有数据

        public FrmResults()
        {
            InitializeComponent();
            SetStyles();
            
            MyInfo.PrintParameter.DidPrintNum = 0;
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

        private void Frm_Results_Load(object sender, EventArgs e)
        {
            SetStyles();
            if (MyInfo.All_Results.Rows.Count == 0)
            {
                MyInfo.All_Results.Columns.Clear();
                MyInfo.All_Results.Rows.Clear();
                MyInfo.All_Results.Columns.Add("no");
                MyInfo.All_Results.Columns.Add("url");
                MyInfo.All_Results.Columns.Add("createdate");
                MyInfo.All_Results.Columns.Add("printnum");
                MyInfo.All_Results.Columns.Add("freeprintnum");
            }
            try
            {
                CalTotal();
            }
            catch
            { }
                BindData();
                AddCheckBox();
                //隐藏选框
                pageCurrent = 1;    //当前页数从1开始
                currentRow = 0;
                List_data(dt);
                CBlist_Init();
                if (MyInfo.PrintParameter.Limit != true)
                {
                    lbl_freeprintnum.Visible = false;
                    label3.Visible = false;
                    label8.Visible = false;
                    lbl_Left.Visible = false;
                    timer1.Enabled = false;
                }
                else
                {
                    label3.Visible = true;
                    label8.Visible = true;
                    lbl_freeprintnum.Visible = true;
                    lbl_Left.Visible = true;
                    timer1.Enabled = true;
                }
        }

        #region TLP操作
        private void HideTLP()
        {
            //for (int i = 0; i < pageSize; i++)
            //{
            //    TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (i + 1).ToString(), true)[0];
            //    TLP.Visible = true;
            //}
            for (int i = nEndPos; i < pageSize * pageCurrent; i++)
            {
                TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (i + 1-nStartPos).ToString(), true)[0];
                TLP.Visible = false;
            }
        }

        private void SelectTLP(int index)
        {
            TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (index + 1).ToString(), true)[0];
            TableLayoutPanel tableLayoutPanel = (TableLayoutPanel)this.Controls.Find("tableLayoutPanel" + (index + 1).ToString(), true)[0];
            TLP.BackgroundImage = global::PrinterManager.Properties.Resources.frame_select;
            TLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tableLayoutPanel.BackColor = Color.Transparent;
        }

        private void TLPInit(int index)
        {
            TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (index + 1).ToString(), true)[0];
            TLP.BackgroundImage = global::PrinterManager.Properties.Resources.frame_unselect;
            TLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void Hidealltlp()
        {
            for (int i = 0; i < pageSize; i++)
            {
                TableLayoutPanel TLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (i + 1).ToString(), true)[0];
                TLP.Visible = false;
            }
        }

        #endregion 

        private void AddCheckBox()
        {
            //Thread Checkbox = new Thread(new ThreadStart(delegate
            //{
                for (int i = 0; i < pageSize; i++)
                {
                    CheckBox CB = new CheckBox()
                    {
                        Anchor = AnchorStyles.Right,
                        Appearance = Appearance.Button,
                        AutoSize = true,
                        CheckAlign = ContentAlignment.MiddleCenter,
                        FlatStyle = FlatStyle.Flat
                    };
                    CB.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(207)))), ((int)(((byte)(197)))));
                    CB.FlatAppearance.BorderSize = 1;
                    CB.Font = new Font("微软雅黑", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
                    CB.ForeColor = Color.White;
                    CB.BackgroundImage = Properties.Resources.UnSelect;
                    CB.BackgroundImageLayout = ImageLayout.Stretch;
                    CB.Name = "CB" + (i + 1).ToString();
                    CB.Size = new Size(47, 45);
                    CB.TabIndex = 1;
                    CB.Checked = false;
                    CB.Text = "  ";
                    CB.TextAlign = ContentAlignment.MiddleCenter;
                    CB.UseVisualStyleBackColor = true;
                    CB.CheckedChanged += new EventHandler(CB_CheckedChanged);
                    TableLayoutPanel TableLP = (TableLayoutPanel)this.Controls.Find("tableLP" + (i + 1).ToString(), true)[0];
                    CBlist[i] = CB;
                    TableLP.Controls.Add(CBlist[i], 2, 1);
                }
            //}));
            //Checkbox.Start();
        }
        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            if (pageCurrent == 0)
                pageCurrent = 1;
            pageSelectCount = 0;
            templist.Clear();
            for (int i = 0; i < pageSize; i++)
            {
                if (CBlist[i].Checked)
                {
                    CBlist[i].BackgroundImage = Properties.Resources.Select;
                    pageSelectCount++;
                    DoPrint(i);
                    SelectTLP(i);
                }
                else
                {
                    CBlist[i].BackgroundImage = Properties.Resources.UnSelect;
                    TLPInit(i);
                }
            }
            lbl_ResultCount.Text = pageSelectCount.ToString();
            if (pageSelectCount == 6)
            {
                btn_AllSelect.Text = "取消";
                btn_AllSelect.ForeColor = Color.Red;
            }
        }

        public enum ColorType
        {
            BlackAndWhite = 0,
            GrayScale = 1,
            Color = 2,
            Original = 3,
        }

        public void DoPrint(int i)
        {
            try
            {
                int currentselectrow = (pageCurrent - 1) * pageSize + i;
                //PDFPageCount pdfpage = new PDFPageCount();
                PdfPrint pdfPrinter = new PdfPrint("", "")
                {
                    PrinterName = MyInfo.MyDeviceInfo.PrinterName
                };
                DownFile.DownloadFile(dt.Rows[currentselectrow]["url"].ToString());
                string localaddress=MyInfo.DownloadPath+ System.IO.Path.GetFileName(dt.Rows[currentselectrow]["url"].ToString());
                //string imagesddress = MyInfo.DownloadPath + System.IO.Path.GetFileName(dt.Rows[currentselectrow]["url"].ToString())+".JPEG";
                int printpapertnum = pdfPrinter.GetNumberOfPages(localaddress);
                //MessageBox.Show(pdfPrinter.SavePdfPageAsImage(localaddress, imagesddress, printpapertnum, 1, 2479, 3508, (PdfPrint.ColorType)3, 100).ToString());
                //Console.WriteLine(printpapertnum.ToString());
                doprint_list item = new doprint_list()
                {
                    no = dt.Rows[currentselectrow]["no"].ToString(),
                    papernum = printpapertnum,
                    //item.printaddress = Application.StartupPath + "\\results\\" + item.no + ".pdf";
                    printaddress = localaddress,
                    printnum = dt.Rows[currentselectrow]["printnum"].ToString(),
                    //printtime = DateTime.Now.ToString("yyyy-MM-dd")
                };
                templist.Add(item);
            }
            catch
            { 
                //Console.WriteLine("Error is"+ex.ToString()); 
            }
        }

        private void CalTotal()
        {
            int i = 0;
            int pagetotal = 0;
            total = 0;
            //if (MyInfo.All_Results.Rows.Count == 0)
            //{
            //ThreadStart threadStart = new ThreadStart(delegate()
            //{
                do
                {
                    total += pagetotal;
                    LoadReusltsData(i);
                    if (ProcessResult)
                    {
                        pagetotal = MyInfo.MyUserInfo.quality_list.Count();
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
                    total += pagetotal;
            //}
            total = MyInfo.All_Results.Rows.Count;
            pageCount = (total / pageSize);
            if ((total % pageSize) > 0)
            {
                pageCount++;
            }
            label7.Text = total.ToString();
            MyInfo.PrintParameter.LimitNum = Convert.ToInt32(MyInfo.All_Results.Rows[0]["freeprintnum"]);
        }

        private void Islimit()
        {
            if (MyInfo.PrintParameter.Limit == true)
            {
                DateTime Nowaday = DateTime.Now;
                DateTime Yesterday = Nowaday.AddDays(-1);
                if (Nowaday.Month == Yesterday.Month)
                {
                    MyInfo.PrintParameter.DidPrintNum = 0;
                    for (int i = 0; i < MyInfo.All_Results.Rows.Count; i++)
                    {
                        MyInfo.PrintParameter.DidPrintNum += Convert.ToInt32(MyInfo.All_Results.Rows[i]["printnum"]);
                    }
                }
                else
                {
                    MyInfo.PrintParameter.DidPrintNum = 0;
                }

                lbl_freeprintnum.Text = MyInfo.PrintParameter.LimitNum.ToString();
                MyInfo.PrintParameter.RemainNum = (MyInfo.PrintParameter.LimitNum - MyInfo.PrintParameter.DidPrintNum);
                if (MyInfo.PrintParameter.RemainNum < 0)
                    lbl_Left.Text = "已超额" + Math.Abs(MyInfo.PrintParameter.RemainNum).ToString() + "次";
                else
                    lbl_Left.Text = MyInfo.PrintParameter.RemainNum.ToString();
            }
        }

        private void Data_binding(List<quality_list> mlist)
        {
            foreach (var quality_list in mlist)
            {
                DataRow dr = MyInfo.All_Results.NewRow();
                dr["createdate"] = quality_list.createdate;
                dr["freeprintnum"] = quality_list.freeprintnum;
                dr["no"] = quality_list.no;
                dr["url"] = quality_list.url;
                dr["printnum"] = quality_list.printnum;
                try
                {
                    MyInfo.All_Results.Rows.Add(dr);
                    MyInfo.All_Results.DefaultView.Sort = "createdate DESC";
                }
                catch { }
            }
        }

        private void LoadReusltsData(int i)
        {
            try
            {
                Print04 Print04param = new Print04();
                Print04param.SetBody(MyInfo.MyUserInfo.UserID, i, pageSize);
                string JsonData = DictConvert.RequestJson<Print04>(Print04param);            //post数据包;
                string result = AccessAPI.PostHttp(MyInfo.URL, JsonData, "application/json");            //解析Json数据
                string type = Function.SelectOutPrint<Print04Out>(result);//判断接口类型
                ProcessResult = DictConvert.JsonToList(type, result);
            }
            catch {
                FrmErro netmsg = new FrmErro();
                if (netmsg.Show("网络连接异常", FrmErro.CYException.NetConnect, FrmErro.CYButtons.OK, FrmErro.CYIcon.Error) == DialogResult.OK)
                    this.Focus();
                ProcessResult = false;
            }
        }

        private void BindData()//所有成绩
        {
            dt = MyInfo.All_Results.Clone();
            dt.Rows.Clear();
            for(int i=0;i<MyInfo.All_Results.Rows.Count;i++)
            {
                dt.ImportRow(MyInfo.All_Results.Rows[i]);
            }
        }

        private void List_data(DataTable Temp)
        {
            //try
            //{
                if (pageCurrent == pageCount)
                {
                    nEndPos = total;
                }
                else
                {
                    nEndPos = pageSize * pageCurrent;
                }
                nStartPos = currentRow;
                label6.Text = pageCurrent.ToString() + "/" + pageCount.ToString();
                Hidealltlp();
                if (total != 0)
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
                }
        }

        //下载后预览
        private void Btn_View_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            string m_PrintNum="";
            string GradeNo = "";
            Button btnview = sender as Button;
            for (int i = 0; i < (nEndPos - nStartPos); i++)
            {
                if (btnview.Name == "btnview" + (i + 1).ToString())
                {
                    int CurSelRow=(pageCurrent-1)*pageSize+i;
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

        List<doprint_list> templist = new List<doprint_list>();

        public List<doprint_list> Readtemp()
        {
            return templist;
        }

        private void CB_AllSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ExtraFun.Sound_fun();
                if (btn_AllSelect.Text == "全选")
                {
                    //ThreadStart threadStart = new ThreadStart(delegate
                    //    {
                    for (int i = 0; i < pageSize; i++)
                        CBlist[i].Checked = true;
                        //});
                    btn_AllSelect.Text = "取消";
                    btn_AllSelect.ForeColor = Color.Red;
                }
                else
                {
                    //ThreadStart threadStart = new ThreadStart(delegate
                    //{
                    for (int i = 0; i < pageSize; i++)
                        CBlist[i].Checked = false;
                    //});
                    btn_AllSelect.Text = "全选";
                    btn_AllSelect.ForeColor = Color.White;
                }
            }
            catch { }
        }

        private void CBlist_Init()
        {
            btn_AllSelect.Text = "全选";
            btn_AllSelect.ForeColor = Color.White;
            ThreadStart threadStart = new ThreadStart(delegate
            {
                for (int i = 0; i < (nEndPos - nStartPos); i++)
                {
                    CBlist[i].Checked = false;
                    CBlist[i].Text = "  ";
                }
            });
            
        }

        private void FrontPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent--;
            if (pageCurrent <= 0)
            {
                FrmErro pagemsg = new FrmErro();
                pagemsg.Show("已经是第一页！", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Information);
                Focus();
                pageCurrent = 1;
                return;
            }
            else
            {
                currentRow = pageSize * (pageCurrent - 1);
                //hidealltlp();
                BindData();
                List_data(dt);
                CBlist_Init();
                
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent++;
            if (pageCurrent > pageCount)
            {
                FrmErro pagemsg = new FrmErro();
                pagemsg.Show("已经是最后一页！", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Information);
                this.Focus();
                pageCurrent = pageCount;
                return;
            }
            else
            {
                currentRow = pageSize * (pageCurrent - 1);
                //hidealltlp();
                BindData();
                List_data(dt);
                CBlist_Init();
                //HideTLP();
            }
        }

        private void LastPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = pageCount;
            currentRow = pageSize * (pageCurrent - 1);
            //hidealltlp();
            BindData();
            List_data(dt);
            CBlist_Init();
        }

        private void FirstPage_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            pageCurrent = 1;
            currentRow = pageSize * (pageCurrent - 1);
            //hidealltlp();
            BindData();
            List_data(dt);
            CBlist_Init();
        }

        private void Lblmouse_enter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = FrmMsg._Blue;
        }

        private void Lblmouse_leave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.ForeColor = FrmMsg._Green;
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            ExtraFun.Sound_fun();
            FrmSelectResult SelectResults = new FrmSelectResult();
            SelectResults.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Islimit();
        }
    }
}
