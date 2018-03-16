using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace PrinterManager
{
    static class DownFile
    {
        /// <summary>
        /// 下载文件
        /// </summary>
        public static void DownloadFile(string URLAddress, string LocalPath)
        {
            WebClient client = new WebClient();
            if (!File.Exists(LocalPath))
            {
                string[] dirArray = LocalPath.Split('\\');
                string temp = string.Empty;
                for (int i = 0; i < dirArray.Length - 1; i++)
                {
                    temp += dirArray[i].Trim() + "\\";
                    if (!Directory.Exists(temp))
                        Directory.CreateDirectory(temp);
                }
            }
            if (!File.Exists(LocalPath + System.IO.Path.GetFileName(URLAddress)))
                client.DownloadFile(URLAddress, LocalPath + System.IO.Path.GetFileName(URLAddress));
        }
    }
}
