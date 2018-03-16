using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

using System.Printing;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace PrinterManager
{
    public class GetPrinterStatus
    {
        private static FileStream fs = null;
        [DllImport("kernel32.dll")]//调用系统API打印函数
        public static extern IntPtr CreateFile
            (
            string FileName,          // file name
            uint DesiredAccess,       // access mode
            uint ShareMode,           // share mode
            uint SecurityAttributes,  // Security Attributes
            uint CreationDisposition, // how to create
            uint FlagsAndAttributes,  // file attributes
            int hTemplateFile         // handle to template file
            );
       

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct StructPrinterDefaults
        {
            [MarshalAs(UnmanagedType.LPTStr)]
            public String pDatatype;
            public IntPtr pDevMode;
            [MarshalAs(UnmanagedType.I4)]
            public int DesiredAccess;
        };

        public struct PRINTER_INFO_2
        {
            public string pServerName;
            public string pPrinterName;
            public string pShareName;
            public string pPortName;
            public string pDriverName;
            public string pComment;
            public string pLocation;
            public IntPtr pDevMode;
            public string pSepFile;
            public string pPrintProcessor;
            public string pDatatype;
            public string pParameters;
            public IntPtr pSecurityDescriptor;
            public UInt32 Attributes;
            public UInt32 Priority;
            public UInt32 DefaultPriority;
            public UInt32 StartTime;
            public UInt32 UntilTime;
            public UInt32 Status;
            public UInt32 cJobs;
            public UInt32 AveragePPM;
        }

        public static bool CancelPrintJob()
        {
            // Variable declarations.            
            bool isActionPerformed = false;
            string searchQuery;
            String jobName;
            char[] splitArr;
            int prntJobID;
            ManagementObjectSearcher searchPrintJobs;
            ManagementObjectCollection prntJobCollection;
            try
            {
                // Query to get all the queued printer jobs.                
                searchQuery = "SELECT * FROM Win32_PrintJob";
                // Create an object using the above query.                
                searchPrintJobs = new ManagementObjectSearcher(searchQuery);
                // Fire the query to get the collection of the printer jobs.                
                prntJobCollection = searchPrintJobs.Get();
                // Look for the job you want to delete/cancel.                
                foreach (ManagementObject prntJob in prntJobCollection)
                {
                    jobName = prntJob.Properties["Name"].Value.ToString();
                    //MessageBox.Show(jobName);
                    // Job name would be of the format [Printer name], [Job ID]                    
                    splitArr = new char[1];
                    splitArr[0] = Convert.ToChar(",");
                    // Get the job ID.                    
                    prntJobID = Convert.ToInt32(jobName.Split(splitArr)[1]);
                    // If the Job Id equals the input job Id, then cancel the job.  
                    prntJob.Delete();
                    //MessageBox.Show(prntJobID.ToString());
                    //if (prntJobID == printJobID)
                    //{
                    //    // Performs a action similar to the cancel                        
                    //    // operation of windows print console                        
                    //    prntJob.Delete();
                    //    isActionPerformed = true;
                    //    break;
                    //}
                }
                isActionPerformed = true;
                return isActionPerformed;
            }
            catch 
            {
                // Log the exception.                
                return false;
            }
        }

        /// <summary>
        /// 开始打印，本地打印机ltp1 端口打印 调用方法：PrintPos.PrintPage("dsdfdsfdsfsdfdsfsdfdsfs");
        /// </summary>
        /// <param name="strPos"></param>
        /// <returns></returns>
        public static string PrintPage(string strPos)
        {
            IntPtr iHandle = CreateFile("dsdfdsfdsfsdfdsfsdfdsfs", 0x40000000, 0, 0, 3, 0, 0);
            //判断是否连接上打印机 -1为false
            if (iHandle.ToInt32() == -1)
            {
                return "没有连接到打印机";
            }
            else
            {
                //fs = new FileStream(iHandle, FileAccess.ReadWrite);

                //StreamReader sr = new StreamReader(fs);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.WriteLine(strPos, 0, 500);
                sw.Close();
                fs.Close();
                return "已经成功连接打印机";
            }
        }

        /// <summary>
        /// 获取打印机当前状态
        /// </summary>
        /// <param name="PrinterName">打印设备名称</param>
        /// <returns></returns>
        public static string GetStatus(string PrinterName)
        {
            PrinterStatus ret = 0;
            string path = @"win32_printer.DeviceId='" + PrinterName + "'";
            try
            {
                ManagementObject printer = new ManagementObject(path);
                printer.Get();
                PropertyDataCollection.PropertyDataEnumerator pde = printer.Properties.GetEnumerator();
                string strRow = "";
                string strRet = "";
                string devicestate;
                while (pde.MoveNext())
                {
                    strRow += pde.Current.Name + " : " + pde.Current.Value + "\r\n";
                    //显示的是 属性名 : 属性值 的形式
                }
                    ret = (PrinterStatus)Convert.ToInt32(printer.Properties["PrinterStatus"].Value);//空闲

                    string aTmp = printer.Properties["WorkOffline"].Value.ToString();//离线 true

                    switch (Convert.ToInt32(printer.Properties["PrinterState"].Value))
                    {
                        case 0:
                            strRet = "准备就绪（Ready）";
                            devicestate = "1";
                            break;
                        case 0x00000200:
                            strRet = "忙(Busy）";
                            devicestate = "1";
                            break;
                        case 0x00400000:
                            strRet = "被打开（Printer Door Open）";
                            devicestate = "0";
                            break;
                        case 0x00000002:
                            strRet = "错误(Printer Error）";
                            devicestate = "0";
                            break;
                        case 0x0008000:
                            strRet = "初始化(Initializing）";
                            devicestate = "1";
                            break;
                        case 0x00000100:
                            strRet = "正在输入,输出（I/O Active）";
                            devicestate = "1";
                            break;
                        case 0x00000020:
                            strRet = "手工送纸（Manual Feed）";
                            devicestate = "0";
                            break;
                        case 0x00040000:
                            strRet = "无墨粉（No Toner）";
                            devicestate = "0";
                            break;
                        case 0x00001000:
                            strRet = "不可用（Not Available）";
                            devicestate = "0";
                            break;
                        case 0x00000080:
                            strRet = "脱机（Off Line）";
                            devicestate = "0";
                            break;
                        case 0x00200000:
                            strRet = "内存溢出（Out of Memory）";
                            devicestate = "0";
                            break;
                        case 0x00000800:
                            strRet = "输出口已满（Output Bin Full）";
                            devicestate = "0";
                            break;
                        case 0x00080000:
                            strRet = "当前页无法打印（Page Punt）";
                            devicestate = "0";
                            break;
                        case 0x00000008:
                            strRet = "塞纸（Paper Jam）";
                            devicestate = "0";
                            break;
                        case 0x00000010:
                            strRet = "打印纸用完（Paper Out）";
                            devicestate = "0";
                            break;
                        case 0x00000040:
                            strRet = "纸张问题（Page Problem）";
                            devicestate = "0";
                            break;
                        case 0x00000001:
                            strRet = "暂停（Paused）";
                            devicestate = "0";
                            break;
                        case 0x00000004:
                            strRet = "正在删除（Pending Deletion）";
                            devicestate = "1";
                            break;
                        case 0x00000400:
                            strRet = "正在打印（Printing）";
                            devicestate = "1";
                            break;
                        case 0x00004000:
                            strRet = "正在处理（Processing）";
                            devicestate = "1";
                            break;
                        case 0x00020000:
                            strRet = "墨粉不足（Toner Low）";
                            devicestate = "0";
                            break;
                        case 0x00100000:
                            strRet = "需要用户干预（User Intervention）";
                            devicestate = "0";
                            break;
                        case 0x20000000:
                            strRet = "等待（Waiting）";
                            devicestate = "1";
                            break;
                        case 0x00010000:
                            strRet = "热机中（Warming Up）";
                            devicestate = "1";
                            break;
                        default:
                            strRet = "未知状态（Unknown Status）";
                            devicestate = "0";
                            break;
                    }
                //MyInfo.MyDeviceInfo.Devicestate = devicestate;
                return strRet;
            }
            catch
            {
                //MyInfo.MyDeviceInfo.Devicestate = "0";
                return "未安装打印机";
            }
               
        }

        //状态枚举
        [FlagsAttribute]
        internal enum PrinterStatu
        {
            PRINTER_STATUS_BUSY = 0x00000200,
            PRINTER_STATUS_DOOR_OPEN = 0x00400000,
            PRINTER_STATUS_ERROR = 0x00000002,
            PRINTER_STATUS_INITIALIZING = 0x00008000,
            PRINTER_STATUS_IO_ACTIVE = 0x00000100,
            PRINTER_STATUS_MANUAL_FEED = 0x00000020,
            PRINTER_STATUS_NO_TONER = 0x00040000,
            PRINTER_STATUS_NOT_AVAILABLE = 0x00001000,
            PRINTER_STATUS_OFFLINE = 0x00000080,
            PRINTER_STATUS_OUT_OF_MEMORY = 0x00200000,
            PRINTER_STATUS_OUTPUT_BIN_FULL = 0x00000800,
            PRINTER_STATUS_PAGE_PUNT = 0x00080000,
            PRINTER_STATUS_PAPER_JAM = 0x00000008,
            PRINTER_STATUS_PAPER_OUT = 0x00000010,
            PRINTER_STATUS_PAPER_PROBLEM = 0x00000040,
            PRINTER_STATUS_PAUSED = 0x00000001,
            PRINTER_STATUS_PENDING_DELETION = 0x00000004,
            PRINTER_STATUS_PRINTING = 0x00000400,
            PRINTER_STATUS_PROCESSING = 0x00004000,
            PRINTER_STATUS_TONER_LOW = 0x00020000,
            PRINTER_STATUS_USER_INTERVENTION = 0x00100000,
            PRINTER_STATUS_WAITING = 0x20000000,
            PRINTER_STATUS_WARMING_UP = 0x00010000
        }

        enum PrinterStatus
        {
            其他状态 = 1,
            暂停,
            空闲,
            正在打印,
            预热,
            停止打印,
            打印中,
            离线
        }

    }
}
