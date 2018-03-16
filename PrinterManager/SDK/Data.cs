using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterManager
{
    class Data
    {
        public enum PrintStatus
        {
            未打印   = 0,
            打印成功 = 1,
            打印失败 = 2
        }

        public static class AppConfig
        {
            public static string ServerIP;
            public static string Deviceno;
            
            public static string DownloadPath="";
            public static string PrinterName = "";
            public static string AdminPwd = "";
            public static string curVersion = "";

            public static string PrinterStatus="30001";
            public static bool Limit = false;
            //自动更新
            public static bool IsAutoRun = true;
            public static bool IsAutoUpdate = true;
            
        }

        public class ResultInfo
        {
            public string id;
            public string resultno;
            public string printnum;
            public string printtime;
            public string url;
            public string printstatus;
        }

        public class DeviceInfo
        {
            public int id;
            public string status;//网络打印机状态
            public string adminname;
            public string phone;
            public string address;
            public string password;
            public string affiliation;
        }

        public class VersionInfo
        {
            public string url;//版本状态
            public string version;
        }

        public class NoBackInfo
        {
            public string result;//无返回值
        }

        //手机校验、打印回传、故障回传 {"code":"100","data":{"result":"0"},"actionSheet":{"type":"1","content":"处理成功","button":[{"title":"确定","color":"#333333"}]}}
        //登陆 {"code":"100","data":{"id":"690","resultno":"20171108000706","printnum":"1","printtime":"20180112155151","url":"http://jingcai-test.oss-cn-shanghai.aliyuncs.com/upload/cer_1510120499138.pdf","printstatus":"0"},"actionSheet":{"type":"1","content":"处理成功","title":"0","button":[{"title":"确定","color":"#333333"}]}}
        //设备信息 {"code":"100","data":{"id":"54","status":"30001","adminname":"马云","address":"多看看书看书","phone":"18612341234","password":"123123","affiliation":"到梦大学"},"actionSheet":{"type":"1","content":"处理成功","title":"0","button":[{"title":"确定","color":"#333333"}]}}
        //版本信息 {"code":"100","data":{"url":"http://5idream.oss-cn-beijing.aliyuncs.com/idream/update.xml","version":"测试版本号"},"actionSheet":{"type":"1","content":"处理成功","title":"0","button":}

        //接口的实体类
        public class JsonParser
        {
            public string code { get; set; }
        }

        public class ErrorJson : JsonParser
        {
            public string msg { get; set; }
            public Actionsheet actionsheet;
        }

        public class DataJson<T> : JsonParser
        {
            public T data;//成绩单接口
            public Actionsheet actionsheet;
        }

        public class Actionsheet
        {
            public int type;
            public string title;
            public string content;
            public List<Button> button;
        }

        public class Button
        {
            public string title;
            public string color;
            public string action;
        }

        public static ErrorJson errorInfo;//错误类
        public static DataJson<DeviceInfo> deviceInfo;//证书信息类 需要跨窗体传递，传值进入下一个窗体
        public static DataJson<ResultInfo> resultInfo;//成绩信息类 
        public static Dictionary<string, string> ExceptionMessage = new Dictionary<string, string>();//异常类
    }
}
