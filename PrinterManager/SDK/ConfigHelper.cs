using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Xml;
using System.Windows.Forms;

namespace PrinterManager
{
    public static class ConfigHelper
    {
        #region 读取配置文件
        /// <summary>
        /// 修改xml文件节点值
        /// </summary>
        /// <param name="node">节点名</param>
        /// <param name="value">修改值</param>
        public static bool resetNode(string path, string node, string value)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);
                XmlNodeList list = xDoc.SelectSingleNode("Configuration").ChildNodes;
                foreach (XmlNode nod in list)
                {
                    for (int i = 0; i < node.Length; i++)
                    {
                        if (nod.Name == node)
                        {
                            nod.InnerText = value;
                        }
                    }
                }
                xDoc.Save(path);
                return (true);
            }
            catch
            {
                return (false);
            }
        }

        /// <summary>
        /// 读取配置文件信息
        /// </summary>
        /// <param name="node">读取节点</param>
        /// <returns></returns>
        public static string GetNodeText(string path, string node)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);
                XmlNodeList list = xDoc.SelectSingleNode("Configuration").ChildNodes;
                foreach (XmlNode nod in list)
                {
                    if (nod.Name == node)
                    {
                        return nod.InnerText;
                    }
                }
                return ("-1");
            }
            catch
            {
                return ("-1");
            }
        }
        #endregion
    }
}