using System;
using System.Net;

namespace PrinterManager.SDK
{
    class GetNetTime
    {
        /// <summary>    
        /// 本地时间转成GMT时间    
        /// string s = ToGMTString(DateTime.Now);  
        /// 本地时间为：2014-9-29 15:04:39  
        /// 转换后的时间为：Thu, 29 Sep 2014 07:04:39 GMT  
        /// </summary>    
        public static string ToGMTString(DateTime dt)
        {
            return dt.ToUniversalTime().ToString("r");
        }

        /// <summary>    
        /// 本地时间转成GMT格式的时间  
        /// string s = ToGMTFormat(DateTime.Now);  
        /// 本地时间为：2014-9-29 15:04:39  
        /// 转换后的时间为：Thu, 29 Sep 2014 15:04:39 GMT+0800  
        /// </summary>    
        public static string ToGMTFormat(DateTime dt)
        {
            return dt.ToString("r") + dt.ToString("zzz").Replace(":", "");
        }

        /// <summary>    
        /// GMT时间转成本地时间   
        /// DateTime dt1 = GMT2Local("Thu, 29 Sep 2014 07:04:39 GMT");  
        /// 转换后的dt1为：2014-9-29 15:04:39  
        /// DateTime dt2 = GMT2Local("Thu, 29 Sep 2014 15:04:39 GMT+0800");  
        /// 转换后的dt2为：2014-9-29 15:04:39  
        /// </summary>    
        /// <param name="gmt">字符串形式的GMT时间</param>    
        /// <returns></returns>    
        public static DateTime GMT2Local(string gmt)
        {
            DateTime dt = DateTime.MinValue;
            try
            {
                string pattern = "";
                if (gmt.IndexOf("+0") != -1)
                {
                    gmt = gmt.Replace("GMT", "");
                    pattern = "ddd, dd MMM yyyy HH':'mm':'ss zzz";
                }
                if (gmt.ToUpper().IndexOf("GMT") != -1)
                {
                    pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";
                }
                if (pattern != "")
                {
                    dt = DateTime.ParseExact(gmt, pattern, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal);
                    //dt = dt.ToLocalTime();
                }
                else
                {
                    //dt = Convert.ToDateTime(gmt);
                }
            }
            catch
            {
            }
            return dt;
        }

        /// <summary>  
        /// 获取国家授时中心网提供的时间。（授时中心连接经常出状况，暂时用百度网代替）  
        /// 通过分析网页报头，查找Date对应的值，获得GMT格式的时间。可通过GMT2Local(string gmt)方法转化为本地时间格式。  
        /// 用法 DateTime netTime = GetNetTime.GMT2Local(GetNetTime.GetNetDate());  
        /// </summary>  
        /// <returns></returns>  
        public static string GetNetDate()
        {
            try
            {
                //WebRequest request = WebRequest.Create("http://www.time.ac.cn");//国家授时中心经常连接不上  
                WebRequest request = WebRequest.Create("http://www.qq.com");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                WebHeaderCollection myWebHeaderCollection = response.Headers;
                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                {
                    string header = myWebHeaderCollection.GetKey(i);
                    string[] values = myWebHeaderCollection.GetValues(header);
                    if (header.Length <= 0 || header == null)
                    {
                        return null;
                    }
                    else if (header == "Date")
                    {
                        return values[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
