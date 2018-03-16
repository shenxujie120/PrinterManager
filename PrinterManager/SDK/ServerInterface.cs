using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PrinterManager
{
    class ServerInterface
    {
        Dictionary<string, string> content;//表单
        string name;
        string uri;//接口地址
        string result;//输出数据包

        /**************参数表单**********************/
        //public static Dictionary<string, string> ToDictionary(string[] parameters)
        //{
        //    Dictionary<string, string> Info_sheet = new Dictionary<string, string>();

        //    return Info_sheet;
        //}

        /**************post请求**********************/
        //public static void Info_post(ServerInterface api, string[] apiParams)
        //{
        //    api.content=ToDictionary(apiParams);
        //    postrequest(api.content, api.uri);
        //}

        static string postrequest(Dictionary<string, string> dic, string api)
        {
            HttpClient myHttpClient = new HttpClient();
            myHttpClient.BaseAddress = new Uri(Data.AppConfig.ServerIP);
            var content = new FormUrlEncodedContent(dic);

            HttpResponseMessage response = myHttpClient.PostAsync(api, content).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                return result;
            }
            return "invalid";
        }

        //管理员信息
        public static string GetMngInfo_post(string deviceno)
        {
            Dictionary<string, string> getMngInfo_sheet = new Dictionary<string, string>()
            {
            {"deviceno",deviceno}
            };
            return postrequest(getMngInfo_sheet, "order/printer/getMngInfo");
        }

        //手机校验
        public static string CheckPhone_post(string phone, string deviceno)
        {
            Dictionary<string, string> Checkphone_sheet = new Dictionary<string, string>()
            {
            {"phonenumber",phone},
            {"deviceno",deviceno},
            };
            return postrequest(Checkphone_sheet, "order/printer/checkPhone");
        }

        //随机码校验
        public static string CheckRandomCode_post(string phone,string randcode)
        {
            Dictionary<string, string> Checkrandomcode_sheet = new Dictionary<string, string>()
            {
                {"randomcode",randcode},
                {"phonenumber",phone}
            };
            return postrequest(Checkrandomcode_sheet, "order/printer/checkRanomCode");
        }

        //二维码登陆
        public static string QueryQRCode_post(string qrcode,string deviceno)
        {
            Dictionary<string, string> queryQRCode_sheet = new Dictionary<string, string>()
            {
            {"code",qrcode},
            {"deviceno",deviceno},
            };
            return postrequest(queryQRCode_sheet, "order/printer/queryQRCode");
        }

        //打印回传
        public static string UpdPrinterStatus_post(string deviceno,string id,string resultno, string printnum, string printtime, string printstatus)
        {
            Dictionary<string, string> updPrinterStatus_sheet = new Dictionary<string, string>()
            {
                {"deviceno",deviceno},
                {"id",id},
                {"resultno",resultno},
                {"printnum",printnum},
                {"printtime",printtime},
                {"printerstate",printstatus},
            };
            return postrequest(updPrinterStatus_sheet, "order/printer/updPrinterStatus");
        }

        //运行状态
        public static string UpdPrinterInfo_post(string id,string deviceno, string status)
        {
            string message = Enum.GetName(typeof(LocalPrinter.PrinterStatus), status);
            Dictionary<string, string> updPrinterInfo_sheet = new Dictionary<string, string>()
            {
                {"id",id},
                {"deviceno",deviceno},
                {"status",status},
                {"message",message}
            };
            return postrequest(updPrinterInfo_sheet, "order/printer/updPrinterInfo");
        }
        
        //版本更新
        public static string QueryPrintVersion_post(string deviceno, string version)
        {
            Dictionary<string, string> queryPrintVersion_sheet = new Dictionary<string, string>()
            {
            {"deviceno",deviceno},
            {"version",version}
            };
            return postrequest(queryPrintVersion_sheet, "order/printer/queryPrintVersion");
        }
    }
}
