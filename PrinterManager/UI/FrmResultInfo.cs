

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using PdfPrintingNet;

namespace PrinterManager
{
    public partial class FrmResultInfo : CCWin.CCSkinMain
    {
        string pdflocalPath;

        public FrmResultInfo()
        {
            InitializeComponent();
        }

        private void Frm_RusultInfo_Load(object sender, EventArgs e)
        {
            Pic_title.BackgroundImage = Properties.Resources.doctor;
            Pic_title.BackgroundImageLayout = ImageLayout.Stretch;
            this.TopMost = true;
            DownFile.DownloadFile(Data.resultInfo.data.url,Data.AppConfig.DownloadPath);//下载
            pdflocalPath = Data.AppConfig.DownloadPath + System.IO.Path.GetFileName(Data.resultInfo.data.url);
            
            //加载缩略图
            Pic_view.setPageMode("thumbs");
            Pic_view.setPageMode("none");
            Pic_view.LoadFile(pdflocalPath);

            ShowResultInfo();
            //pdfpreview view = new pdfpreview(pdflocalPath);
        }

        private void ShowResultInfo()
        {
            Txt_ResultNo.Text = Data.resultInfo.data.resultno;
            Txt_PrinterStatus.Text = Enum.GetName(typeof(Data.PrintStatus), Convert.ToInt32(Data.resultInfo.data.printstatus)) + "(" + Data.resultInfo.data.printnum + "份)";
            DateTime dt = DateTime.ParseExact(Data.resultInfo.data.printtime, "yyyyMMddHHmmss", CultureInfo.CurrentCulture);
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
            string format = "yyyy-MM-dd HH:mm";
            Txt_CreateTime.Text = DateTime.Now.ToString(format, cultureInfo);
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            if (Data.resultInfo.data.printstatus == "0")
            {
                for (int i = 0; i < Convert.ToInt32(Data.resultInfo.data.printnum); i++)
                {
                    PdfPrint pdfPrinter = new PdfPrint("", "");
                    pdfPrinter.PrinterName = Data.AppConfig.PrinterName;
                    int numberOfPages = pdfPrinter.GetNumberOfPages(pdflocalPath);
                    var status = pdfPrinter.Print(pdflocalPath);
                    string strRet=LocalPrinter.GetStatus(Data.AppConfig.PrinterName, out Data.AppConfig.PrinterStatus);
                    if (Data.AppConfig.PrinterStatus != "30001")
                    {
                        Function.UpdPrinterStatus(Data.resultInfo, 2);
                        Function.UpdPrinterInfo(Data.AppConfig.PrinterStatus);
                        Function.ExceptionOut("40009", FrmErro.CYIcon.Warning);
                        break;
                    }
                    else if (status == PdfPrint.Status.OK)
                    { 
                        Function.UpdPrinterStatus(Data.resultInfo, 1);//打印成功
                    }
                    else
                    {
                        Function.UpdPrinterStatus(Data.resultInfo, 2);//打印失败
                        Function.UpdPrinterInfo(Data.AppConfig.PrinterStatus);
                        Function.ExceptionOut("40009", FrmErro.CYIcon.Warning);
                    }
                }
            }
            this.Dispose();
        }

        private void Btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
