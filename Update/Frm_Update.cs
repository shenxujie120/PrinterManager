using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PrinterManager;
using System.Collections;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Net;

namespace Update
{
    public partial class Frm_Update : Form
    {
        //调用API
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow(); //获得本窗体的句柄
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);//设置此窗体为活动窗体

        public Frm_Update()
        {
            //Is_Updated = Updated;
            InitializeComponent();
        }
        //private bool Is_AutoUpdate;
        //private string Is_Updated;
        private string updateUrl = string.Empty;
        private string tempUpdatePath = string.Empty;
        XmlFiles updaterXmlFiles = null;
        private int availableUpdate = 0;
        string mainAppExe = "";

        #region Load事件
        private void FrmUpdate_Load(object sender, System.EventArgs e)
        {
            this.TopMost = true;
            SetForegroundWindow(this.Handle);
            this.BackgroundImage = global::Update.Properties.Resources.Update;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            AutoUpdate();
        }
        #endregion

        private void AutoUpdate()
        {
            btn_return.Visible = false;
            lbl_versionInfo.Visible = false;
            lbState.Visible = true;
            lbl_file.Visible = true;

            string localXmlFile = Application.StartupPath + "\\Update.xml";
            Control.CheckForIllegalCrossThreadCalls = false;
            string serverXmlFile = string.Empty;

            try
            {
                //从本地读取更新配置文件信息
                updaterXmlFiles = new XmlFiles(localXmlFile);
            }
            catch
            {
                UpdateError("本地配置文件出错!");
            }
            //获取服务器地址
            updateUrl = updaterXmlFiles.GetNodeValue("//Url");
            AppUpdater appUpdater = new AppUpdater();
            appUpdater.UpdaterUrl = updateUrl + "Update.xml";
            //与服务器连接,下载更新配置文件
            try
            {
                tempUpdatePath = Environment.GetEnvironmentVariable("Temp") + "\\" + "_" + updaterXmlFiles.FindNode("//Application").Attributes["applicationId"].Value + "\\";
                int Error = appUpdater.DownAutoUpdateFile(tempUpdatePath);
                if (Error == 0)
                {
                    UpdateError("无法连接至服务器！");
                }
                if (Error == 1)
                {
                    UpdateError("服务器配置文件提交错误！");
                }
            }
            catch 
            {
            }

            //获取更新文件列表
            Hashtable htUpdateFile = new Hashtable();
            serverXmlFile = tempUpdatePath + "Update.xml";            
            if (!File.Exists(serverXmlFile))
            {
                return;
                //this.Close();
            }
            XmlFiles serverXmlFiles = new XmlFiles(serverXmlFile);
            availableUpdate = appUpdater.CheckForUpdate(serverXmlFile, localXmlFile, out htUpdateFile);

            if (availableUpdate > 0)
            {
                for (int i = 0; i < htUpdateFile.Count; i++)
                {
                    string[] fileArray = (string[])htUpdateFile[i];
                    //0-名称 1-进度
                    lvUpdateList.Items.Add(new ListViewItem(fileArray));
                }
                pbDownFile.Visible = true;
                Thread threadDown = new Thread(new ThreadStart(DownUpdateFile));
                threadDown.IsBackground = true;
                threadDown.Start();
            }
            else
            {
                UpdateError("服务器更新文件未上传!");
            }
        }

        private void DownUpdateFile()
        {
            this.Cursor = Cursors.WaitCursor;

            WebClient wcClient = new WebClient();
            for (int i = 0; i < this.lvUpdateList.Items.Count; i++)
            {
                string UpdateFile = lvUpdateList.Items[i].Text.Trim();
                string updateFileUrl = updateUrl + lvUpdateList.Items[i].Text.Trim();
                long fileLength = 0;
                WebRequest webReq = WebRequest.Create(updateFileUrl);
                WebResponse webRes = webReq.GetResponse();
                fileLength = webRes.ContentLength;
                lbState.Text = "正在下载";
                pbDownFile.Value = 0;
                pbDownFile.Maximum = (int)fileLength;

                try
                {
                    Stream srm = webRes.GetResponseStream();
                    StreamReader srmReader = new StreamReader(srm);
                    byte[] bufferbyte = new byte[fileLength];
                    int allByte = (int)bufferbyte.Length;
                    int startByte = 0;
                    while (fileLength > 0)
                    {
                        Application.DoEvents();
                        int downByte = srm.Read(bufferbyte, startByte, allByte);
                        if (downByte == 0) { break; };
                        startByte += downByte;
                        allByte -= downByte;
                        pbDownFile.Value += downByte;

                        float part = (float)startByte / 1024;
                        float total = (float)bufferbyte.Length / 1024;
                        int percent = Convert.ToInt32((part / total) * 100);
                        lbl_file.Text = this.lvUpdateList.Items[i].SubItems[0].Text + " " + percent.ToString() + "%";

                    }

                    string tempPath = tempUpdatePath + UpdateFile;
                    CreateDirtory(tempPath);
                    FileStream fs = new FileStream(tempPath, FileMode.OpenOrCreate, FileAccess.Write);
                    fs.Write(bufferbyte, 0, bufferbyte.Length);
                    srm.Close();
                    srmReader.Close();
                    fs.Close();
                }
                catch (WebException ex)
                {
                    UpdateError("更新文件下载失败！" + ex.Message.ToString());
                }
            }
            lbState.Text = "正在拷贝至本地目录……";
            UpdateError("更新完成");
            this.Cursor = Cursors.Default;
        }

        private void UpdateError(string msg)
        {
            pbDownFile.Visible = false;
            lbl_file.Visible = false;
            lbState.Visible = false;
            lbl_versionInfo.Visible = true;
            if (msg == "更新完成")
            {
                btn_return.Visible = true;
            }
            else
                btn_return.Visible = true;
            lbl_versionInfo.Text = msg;
             
        }

        //创建目录
        private void CreateDirtory(string path)
        {
            if (!File.Exists(path))
            {
                string[] dirArray = path.Split('\\');
                string temp = string.Empty;
                for (int i = 0; i < dirArray.Length - 1; i++)
                {
                    temp += dirArray[i].Trim() + "\\";
                    if (!Directory.Exists(temp))
                        Directory.CreateDirectory(temp);
                }
            }
        }

        //复制文件;
        public void CopyFile(string sourcePath, string objPath)
        {
            //			char[] split = @"\".ToCharArray();
            if (!Directory.Exists(objPath))
            {
                Directory.CreateDirectory(objPath);
            }
            string[] files = Directory.GetFiles(sourcePath);
            for (int i = 0; i < files.Length; i++)
            {
                string[] childfile = files[i].Split('\\');
                File.Copy(files[i], objPath + @"\" + childfile[childfile.Length - 1], true);
            }
            string[] dirs = Directory.GetDirectories(sourcePath);
            for (int i = 0; i < dirs.Length; i++)
            {
                string[] childdir = dirs[i].Split('\\');
                CopyFile(dirs[i], objPath + @"\" + childdir[childdir.Length - 1]);
            }
        }

        //点击完成复制更新文件到应用程序目录
        private void unZipFile()
        {
            mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
            //压缩文件地址
            string AppName=mainAppExe.Substring(0,mainAppExe.LastIndexOf("."));
            string AppZipPath=Directory.GetCurrentDirectory()+"\\"+AppName+".zip";
            Ziphelper.UnZip(AppZipPath,Directory.GetCurrentDirectory());
            System.IO.File.Delete(AppZipPath);
        }

        //点击完成复制更新文件到应用程序目录
        private void CopyFile()
        {
            try
            {
                CopyFile(tempUpdatePath, Directory.GetCurrentDirectory());
                System.IO.Directory.Delete(tempUpdatePath, true);
            }
            catch (Exception ex)
            {
                UpdateError(ex.Message.ToString());
            }
        }


        //判断主应用程序是否正在运行
        private bool IsMainAppRun()
        {
            string mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
            bool isRun = false;
            Process[] allProcess = Process.GetProcesses();
            foreach (Process p in allProcess)
            {

                if (p.ProcessName.ToLower() + ".exe" == mainAppExe.ToLower())
                {
                    isRun = true;
                    //break;
                }
            }
            return isRun;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (lbl_versionInfo.Text == "更新完成")
            {
                CopyFile();
                unZipFile();
            }
            this.Close();
            string mainAppExe = updaterXmlFiles.GetNodeValue("//EntryPoint");
            try
            {
                Process.Start(mainAppExe);
            }
            catch { }
            Application.Exit();
        }

    }
}