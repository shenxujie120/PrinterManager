using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using PdfPrintingNet;
using System.Runtime.InteropServices;
using System.Media;
using System.Xml;

namespace PrinterManager
{
    class Function
    {
        
        #region [异常初始化]
        public static void ExceptionInit()
        {
            //string XmlPath=Application.StartupPath.Substring(0,Application.StartupPath.LastIndexOf(@"\"))+"\\error_info.xml";
            string XmlPath=Application.StartupPath +"\\error_info.xml";
            if (File.Exists(XmlPath))
            {
                XmlFiles errorFile = new XmlFiles(XmlPath);
                XmlNodeList NodeList = errorFile.GetNodeList("errors");
                for (int i = 0; i < NodeList.Count; i++)
                {
                    string _type = NodeList.Item(i).Attributes["type"].Value.Trim();
                    string _msg = NodeList.Item(i).Attributes["msg"].Value.Trim();
                    if (_type != null && _msg != null)
                        Data.ExceptionMessage.Add(_type, _msg);
                }
            }
        }
        #endregion

        #region [输出异常]
        public static DialogResult ExceptionOut(string err,FrmErro.CYIcon icon)
        {
            FrmErro ing = new FrmErro();
            return ing.Show(Data.ExceptionMessage[err],icon);
        }
        #endregion

        #region [初始化设置读取]
        public static void ReadConfig()
        {
            Data.AppConfig.Deviceno = ConfigurationManager.ReadSetting("deviceno");
            Data.AppConfig.PrinterName = ConfigurationManager.ReadSetting("printer");
            Data.AppConfig.DownloadPath = Application.StartupPath + "\\Download\\";//当前目录即可
            Data.AppConfig.ServerIP = ConfigurationManager.ReadSetting("serverIP");
            Data.AppConfig.PrinterName = LocalPrinter.DefaultPrinter();//默认打印机
            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();//程序集版本
            //ConfigurationManager.ModifySetting("curversion", strVersion[0] + "." + strVersion[1]);
            Data.AppConfig.curVersion = strVersion;
            Data.AppConfig.IsAutoRun = Convert.ToBoolean(ConfigurationManager.ReadSetting("IsAutoRun"));
            Data.AppConfig.IsAutoUpdate = Convert.ToBoolean(ConfigurationManager.ReadSetting("IsAutoUpdate"));
        }
        #endregion

        #region [服务器接口]

            #region [设备码信息读取]
        public static bool Readadmin(string newdeviceno)
        {
            string GetMngInfo_respond = "";
            GetMngInfo_respond = ServerInterface.GetMngInfo_post(newdeviceno);
            var jObj = JObject.Parse(GetMngInfo_respond);
            IEnumerable<JProperty> properties = jObj.Properties();
            foreach (JProperty item in properties)
            {
                if (item.Name == "code")//找到字段code
                {
                    if (item.Value.ToString() == "100")
                    {
                        Data.deviceInfo = JsonConvert.DeserializeObject<Data.DataJson<Data.DeviceInfo>>(GetMngInfo_respond);
                        ConfigurationManager.ModifySetting("deviceno", Data.AppConfig.Deviceno);
                        Data.AppConfig.AdminPwd = Data.deviceInfo.data.password;
                        return true;
                    }
                }
            }
            Data.errorInfo = JsonConvert.DeserializeObject<Data.ErrorJson>(GetMngInfo_respond);
            Function.ExceptionOut("40003", FrmErro.CYIcon.Warning);
            return false;
        }
        #endregion

            #region [打印机状态回传]
        public static bool UpdPrinterInfo(string status)
        {
            try
            {
                string UpdPrinterInfo_respond = ServerInterface.UpdPrinterInfo_post(Data.deviceInfo.data.id.ToString(), Data.AppConfig.Deviceno, status);
                var jObj = JObject.Parse(UpdPrinterInfo_respond);
                IEnumerable<JProperty> properties = jObj.Properties();
                foreach (JProperty item in properties)
                {
                    if (item.Name == "code")//找到字段code
                    {
                        if (item.Value.ToString() == "100")
                        {
                            return true;
                        }
                        else
                        {
                            Data.errorInfo = JsonConvert.DeserializeObject<Data.ErrorJson>(UpdPrinterInfo_respond);
                            Function.ExceptionOut(Data.errorInfo.code, FrmErro.CYIcon.Warning);
                            break;
                        }
                    }
                }
                return false;
            }
            catch
            {
                Function.ExceptionOut("40006", FrmErro.CYIcon.Warning);
                //FrmErro netmsg = new FrmErro();
                //netmsg.Show("网络连接异常", FrmErro.CYException.NetConnect, FrmErro.CYIcon.Warning);
                return false;
            }
        }
        #endregion

            #region [成绩单打印结果回传]
        public static bool UpdPrinterStatus(Data.DataJson<Data.ResultInfo> resultInfo,int isFailed)
        {
            string UpdPrinterStatus_respond = "";
            UpdPrinterStatus_respond = ServerInterface.UpdPrinterStatus_post(Data.AppConfig.Deviceno, Data.resultInfo.data.id, Data.resultInfo.data.resultno, Data.resultInfo.data.printnum, Data.resultInfo.data.printtime, isFailed.ToString());

            var jObj = JObject.Parse(UpdPrinterStatus_respond);
            IEnumerable<JProperty> properties = jObj.Properties();
            foreach (JProperty item in properties)
            {
                if (item.Name == "code")//找到字段code
                {
                    if (item.Value.ToString() == "100")
                    {
                        return true;
                    }
                    else
                    {
                        Data.errorInfo = JsonConvert.DeserializeObject<Data.ErrorJson>(UpdPrinterStatus_respond);
                        Function.ExceptionOut(Data.errorInfo.code, FrmErro.CYIcon.Warning);
                    }
                }
            }
            return false;
        }
        #endregion

            #region [二维码校验]
        public static bool QrCodeLoadDataFunc(string qrcode) 
        {
            try
            {
                string QueryQRCode_respond = ServerInterface.QueryQRCode_post(qrcode.ToString(), Data.AppConfig.Deviceno);
                var jObj = JObject.Parse(QueryQRCode_respond);
                IEnumerable<JProperty> properties = jObj.Properties();
                foreach (JProperty item in properties)
                {
                    if (item.Name == "code")//找到字段code
                    {
                        if (item.Value.ToString() == "100")
                        {
                            Data.resultInfo = JsonConvert.DeserializeObject<Data.DataJson<Data.ResultInfo>>(QueryQRCode_respond);
                            return true;
                        }
                        else
                        {
                            Data.errorInfo = JsonConvert.DeserializeObject<Data.ErrorJson>(QueryQRCode_respond);
                            Function.ExceptionOut(Data.errorInfo.code, FrmErro.CYIcon.Warning);
                            break;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

            #region [随机码校验]
        public static bool CheckRandomCode(string phone,string randcode)
        {
            string Checkphone_respond,Checkrandomcode_respond;
            //手机号
            Checkphone_respond = ServerInterface.CheckPhone_post(phone, Data.AppConfig.Deviceno);
            //随机码
            Checkrandomcode_respond = ServerInterface.CheckRandomCode_post( phone,randcode);

            //解析数据包
            var jObj = JObject.Parse(Checkrandomcode_respond);
            IEnumerable<JProperty> properties = jObj.Properties();
            foreach (JProperty item in properties)
            {
                if (item.Name == "code")//找到字段code
                {
                    if (item.Value.ToString() == "100")
                    {
                        Data.resultInfo = JsonConvert.DeserializeObject<Data.DataJson<Data.ResultInfo>>(Checkrandomcode_respond);
                        return true;
                    }
                    else
                    {
                        Data.errorInfo = JsonConvert.DeserializeObject<Data.ErrorJson>(Checkrandomcode_respond);
                        Function.ExceptionOut(Data.errorInfo.code, FrmErro.CYIcon.Warning);
                        break;
                    }
                }
            }
            return false;
        }
        #endregion

            #region [版本校验]
        public static bool QueryPrintVersion()
        {
            string deviceno=Data.AppConfig.Deviceno;
            string curVer = Data.AppConfig.curVersion;
            string QueryPrintVersion_respond;
            //版本号
            QueryPrintVersion_respond = ServerInterface.QueryPrintVersion_post(deviceno, curVer);

            //解析数据包
            var jObj = JObject.Parse(QueryPrintVersion_respond);
            IEnumerable<JProperty> properties = jObj.Properties();
            foreach (JProperty item in properties)
            {
                if (item.Name == "code")//找到字段code
                {
                    if (item.Value.ToString() == "100")
                    {
                        Data.DataJson<Data.VersionInfo> versionInfo = JsonConvert.DeserializeObject<Data.DataJson<Data.VersionInfo>>(QueryPrintVersion_respond);
                        string UpdatePath = Application.StartupPath + "\\" + "Update.xml";
                        XmlFiles LocalXmlFiles = new XmlFiles(UpdatePath);
                        if (versionInfo.data.url != null && versionInfo.data.url!="")
                            LocalXmlFiles.SetUrlValue(UpdatePath,versionInfo.data.url);
                        return true;
                    }
                    else
                    {
                        Data.errorInfo = JsonConvert.DeserializeObject<Data.ErrorJson>(QueryPrintVersion_respond);
                        Function.ExceptionOut(Data.errorInfo.code, FrmErro.CYIcon.Warning);
                        break;
                    }
                }
            }
            return false;
        }
        #endregion

        #endregion

        #region [执行更新程序]
        public static bool Update_RunOrNot()
        {
            if (Function.QueryPrintVersion())//已更新
            {
                Function.ExceptionOut("40005", FrmErro.CYIcon.Information);
                return true;
            }
            else//未更新
            {
                if (Function.ExceptionOut("40007", FrmErro.CYIcon.Information) == DialogResult.OK)
                {
                    string path = Application.StartupPath + @"\Update.exe";
                    System.Diagnostics.Process.Start(path);
                    Application.Exit();
                    return true;
                }

                return false;
            }
        }
        #endregion

        #region [打印设备检测]
        public static bool CheckForPrinter()
        {
            LocalPrinter.GetStatus(LocalPrinter.DefaultPrinter(),out Data.AppConfig.PrinterStatus);
            if (Data.AppConfig.PrinterStatus!="30001")
            {
                Function.ExceptionOut(Data.AppConfig.PrinterStatus, FrmErro.CYIcon.Warning);
                //FrmErro PrinterDown = new FrmErro();
                //PrinterDown.Show(Data.deviceInfo.data.status.ToString(), FrmErro.CYIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion

        #region [任务栏显示/隐藏]
        private const int SW_HIDE = 0;  //隐藏任务栏
        private const int SW_RESTORE = 9;//显示任务栏

        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        private static extern Int32 MciSendString(String lpstrCommand, String lpstrReturnString, Int32 uReturnLength, Int32 hwndCallback);

        static public void HideWindow()
        {
            ShowWindow(FindWindow("Shell_TrayWnd", null), SW_HIDE);
            ShowWindow(FindWindow("Button", null), SW_HIDE);
        }
        static public void ShowWindow()
        {
            ShowWindow(FindWindow("Shell_TrayWnd", null), SW_RESTORE);
            ShowWindow(FindWindow("Button", null), SW_RESTORE);
        }
        #endregion

        #region [警告音效]
        static public void Sound_stop()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("_Stop"));
            simpleSound.Play();
            //string tem_Value = tem_VoicePath + @"_Stop.mp3";//获取当前路径
            //tem_Value = tem_Value.Replace(@"\", @"\\");
            //sound(tem_Value);
        }
        #endregion

        #region [更新程序启动]
        static public void UpdateRun()
        {

        }
        #endregion
    }

}
