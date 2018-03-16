using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using PrintClass;
using PrinterManager.SDK;
using System.Data;
using System.Text.RegularExpressions;

namespace PrinterManager.SDK
{
    public class DictConvert 
    {

        #region json转换为DataTable
        /// <summary>
        /// 将json转换为DataTable
        /// </summary>
        /// <param name="strJson">得到的json</param>
        /// <returns></returns>
        public static DataTable JsonToDataTable(string strJson)
        {
            //转换json格式
            strJson = strJson.Replace(",\"", "*\"").Replace("\":", "\"#").ToString();
            //取出表名   
            var rg = new Regex(@"(?<={)[^:]+(?=:\[)", RegexOptions.IgnoreCase);
            string strName = rg.Match(strJson).Value;
            DataTable tb = null;
            //去除表名   
            strJson = strJson.Substring(strJson.IndexOf("[") + 1);
            strJson = strJson.Substring(0, strJson.IndexOf("]"));

            //获取数据   
            rg = new Regex(@"(?<={)[^}]+(?=})");
            MatchCollection mc = rg.Matches(strJson);
            for (int i = 0; i < mc.Count; i++)
            {
                string strRow = mc[i].Value;
                string[] strRows = strRow.Split('*');

                //创建表   
                if (tb == null)
                {
                    tb = new DataTable()
                    {
                        TableName = strName
                    };
                    foreach (string str in strRows)
                    {
                        var dc = new DataColumn();
                        string[] strCell = str.Split('#');

                        if (strCell[0].Substring(0, 1) == "\"")
                        {
                            int a = strCell[0].Length;
                            dc.ColumnName = strCell[0].Substring(1, a - 2);
                        }
                        else
                        {
                            dc.ColumnName = strCell[0];
                        }
                        tb.Columns.Add(dc);
                    }
                    tb.AcceptChanges();
                }

                //增加内容   
                DataRow dr = tb.NewRow();
                for (int r = 0; r < strRows.Length; r++)
                {
                    dr[r] = strRows[r].Split('#')[1].Trim().Replace("，", ",").Replace("：", ":").Replace("\"", "");
                }
                tb.Rows.Add(dr);
                tb.AcceptChanges();
            }

            return tb;
        }
        #endregion

        //生成Json请求
        /// <summary>
        /// 生成Json请求
        /// 根据 不同类的参数生成Json
        /// </summary>
        public static string RequestJson<T>(T PrintCode)where T:Print
        {
            string requesttime=DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string usertype="1";
            string JsonBody=PrintCode.GetBody();
            string buff = JsonBody + MyInfo.Parameter.Curchannel + MyInfo.Parameter.SECRET_KEY;
            //buff = Encrypt.getMd5Hash(buff);//加密sign码
            PrintCode.SetHeader(requesttime, MyInfo.MyDeviceInfo.Version, usertype, MyInfo.Parameter.Curchannel, buff);
            string JsonHead = PrintCode.GetHeader();
            string JsonData = "{\"head\":" + JsonHead + ",\"body\":"+JsonBody+"}";
            return JsonData;
        }

        //解析Json为对象，并处理信息
        public static bool JsonToList(string str, string json)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();   //实例化一个能够序列化数据的类
            bool flag=true;
            switch (str.Substring(16, 2))
            {
                case "01":
                    Print01Out Response01 = js.Deserialize<Print01Out>(json);    //将json数据转化为对象类型并赋值给list
                    flag = Function.JudgeProcess(Response01.result.code, Response01.result.message);
                    if (flag)
                    {
                        MyInfo.MyUserInfo.UserID = Response01.body.userid;
                        MyInfo.MyUserInfo.UserName = Response01.body.username;
                        MyInfo.MyUserInfo.UserNo = Response01.body.userno;
                    }
                    return flag;

                case "02":
                        Print02Out Response02 = js.Deserialize<Print02Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response02.result.code, Response02.result.message);
                        return flag;

                case "03":
                        Print03Out Response03 = js.Deserialize<Print03Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response03.result.code, Response03.result.message);
                        if (flag)
                        {
                            MyInfo.MyUserInfo.UserID = Response03.body.userid;
                            MyInfo.MyUserInfo.UserName = Response03.body.username;
                            MyInfo.MyUserInfo.UserNo = Response03.body.userno;
                        }
                        return flag;

                case"04":
                        Print04Out Response04 = js.Deserialize<Print04Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response04.result.code, Response04.result.message);
                        if (flag)
                        {
                            MyInfo.MyUserInfo.quality_list = Response04.body.quality_list;
                        }
                        return flag;

                case"05":
                        Print05Out Response05 = js.Deserialize<Print05Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response05.result.code, Response05.result.message);
                        if (flag)
                        {
                            MyInfo.MyUserInfo.print_list = Response05.body.print_list;
                        }
                        return flag;
                case"06":
                        Print06Out Response06 = js.Deserialize<Print06Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response06.result.code, Response06.result.message);
                        if (flag)
                        {
                            MyInfo.MyDeviceInfo.Adminname = Response06.body.adminname;
                            MyInfo.MyDeviceInfo.AdminPhone = Response06.body.phone;
                            MyInfo.MyDeviceInfo.AdminAddress = Response06.body.address;
                            MyInfo.MyDeviceInfo.AdminPwd = Response06.body.password;//管理员密码需要解密
                            //ConfigHelper.resetNode(MyInfo.AppPath, "Adminname", MyInfo.MyDeviceInfo.Adminname);
                            //ConfigHelper.resetNode(MyInfo.AppPath, "AdminPhone", MyInfo.MyDeviceInfo.AdminPhone);
                            //ConfigHelper.resetNode(MyInfo.AppPath, "AdminAddress", MyInfo.MyDeviceInfo.AdminAddress);
                            if (MyInfo.MyDeviceInfo.Adminname == null || MyInfo.MyDeviceInfo.AdminAddress == null || MyInfo.MyDeviceInfo.AdminPhone == null || MyInfo.MyDeviceInfo.AdminPwd == null)
                            {
                                FrmErro PrinterBind = new FrmErro();
                                PrinterBind.Show("绑定打印机不存在，请更改设备码", FrmErro.CYException.Normal, FrmErro.CYButtons.OK, FrmErro.CYIcon.Error);
                                flag = false;
                            }
                        }
                        return flag;//请求处理问题
                case"07":
                        Print07Out Response07 = js.Deserialize<Print07Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response07.result.code, Response07.result.message);
                        return flag;
                case"08":
                        Print08Out Response08 = js.Deserialize<Print08Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response08.result.code, Response08.result.message);
                        return flag;
                case"09":
                        Print09Out Response09 = js.Deserialize<Print09Out>(json);    //将json数据转化为对象类型并赋值给list
                        flag = Function.JudgeProcess(Response09.result.code, Response09.result.message);
                        if (Response09.body == null)
                        {
                            flag = false;
                            Console.WriteLine("Response09.body == null");
                        }
                        if (flag)
                        {
                            MyInfo.MyDeviceInfo.Serverversion = Response09.body.version;
                            MyInfo.MyDeviceInfo.UpdateUrl = Response09.body.url;
                        }
                        return flag;
                default:
                        return flag;
            };
        }

    }
}

