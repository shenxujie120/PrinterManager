using System;
using System.IO;
using System.Xml;


namespace PrinterManager
{
	/// <summary>
	/// XmlFiles 的摘要说明。
	/// </summary>
	public class XmlFiles:XmlDocument
	{
		#region 字段与属性
		private string _xmlFileName;
		public string XmlFileName
		{
			set{_xmlFileName = value;}
			get{return _xmlFileName;}
		}
		#endregion

		public XmlFiles(string xmlFile)
		{
			XmlFileName = xmlFile;
            this.Load(XmlFileName);
		}
		/// <summary>
		/// 给定一个节点的xPath表达式并返回一个节点
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public XmlNode FindNode(string xPath)
		{
			XmlNode xmlNode = this.SelectSingleNode(xPath);
			return xmlNode;
		}
		/// <summary>
		/// 给定一个节点的xPath表达式返回其值
		/// </summary>
		/// <param name="xPath"></param>
		/// <returns></returns>
		public string GetNodeValue(string xPath)
		{
			XmlNode xmlNode = this.SelectSingleNode(xPath);//5~1-a-s-p-x
			return xmlNode.InnerText;
		}
		/// <summary>
		/// 给定一个节点的表达式返回此节点下的孩子节点列表
		/// </summary>
		/// <param name="xPath"></param>
		/// <returns></returns>
		public XmlNodeList GetNodeList(string xPath)
		{
			XmlNodeList nodeList = this.SelectSingleNode(xPath).ChildNodes;
			return nodeList;
		}

        /// <summary>
        /// 设置一个节点xPath的值
        /// </summary>
        /// <param name="xPath"></param>
        /// <returns></returns>
        public void SetUrlValue(string xPath,string str)
        {
            //获取<Rule>节点的所有子节点
            XmlNodeList MyNodeList = this.SelectSingleNode("AutoUpdater/Updater").ChildNodes;
            //遍历InfoPage节点
            foreach (XmlNode MyNode in MyNodeList)
            {
                if (MyNode.Name == "Url")
                {
                    MyNode.InnerText = str;
                    break;
                }
            }
                this.Save(xPath); //保存
            }

	}
}
