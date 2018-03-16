using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;


namespace PrinterManager
{

    static class Program
    {
        //[DllImport("kernel32.dll")]
        //public static extern Boolean AllocConsole();
        //[DllImport("kernel32.dll")]
        //public static extern Boolean FreeConsole();  

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            ThreadPool.RegisterWaitForSingleObject(new AutoResetEvent(true), new WaitOrTimerCallback(TryStartSpooler), null, 30000, false);
            Function.ReadConfig();
            Function.ExceptionInit();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmWelcome welcome = new FrmWelcome();
            Application.Run(welcome);
        }     

        static private void RunPDF()
        {
            bool flag;
            Mutex mutex = new Mutex(true, "Acrobat", out flag);//判断进程是否已启动
            if (!flag)
            {
                RegistryKey appPath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\Acrobat.exe");
                try
                {
                    string s1 = appPath.GetValue("path").ToString();//将path的值转型为String
                    Process[] temp = Process.GetProcessesByName(s1 + "Acrobat.exe");
                    if (temp.Length > 0)
                        return;
                    else
                    {
                        Process p = new Process();
                        p.StartInfo.FileName = (s1 + "Acrobat.exe");
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;//默认最小化
                        p.Start();//运行安装目录重的WinWord程序，启动完成，s1是文件夹，WINWORD.exe是文件夹下的程序，如果s1是exe的绝对路径的话，则可以省略后面的+"程序名称"
                    }
                }
                catch //异常抛出，如果没有找到该注册表值，执行下面的代码            
                {
                    Function.ExceptionOut("40001", FrmErro.CYIcon.Warning);
                    //FrmErro PDFmsg = new FrmErro();
                    //PDFmsg.Show("请安装Adobe Acrobat", FrmErro.CYException.Normal,);
                }
            }
        }

        static private void AutoRun()
        {
            //获取程序执行路径..
            try
            {
                string starupPath = Application.ExecutablePath;
                //class Micosoft.Win32.RegistryKey. 表示Window注册表中项级节点,此类是注册表装.
                RegistryKey loca = Registry.LocalMachine;
                RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");

                //SetValue:存储值的名称
                //if (IsAutoRun == false) run.SetValue("WinForm", false);//取消开机运行
                //else 
                run.SetValue("PrinterManager", starupPath);//设置开机运行
                loca.Close();
            }
            catch
            { }
        }

        public static void InstallService()
        {
            string sysDisk = System.Environment.SystemDirectory.Substring(0, 3);
            string dotNetPath = sysDisk + @"WINDOWS\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe";//因为当前用的是4.0的环境  
            string serviceEXEPath = Application.StartupPath + @"\AutoRunPrinter.exe";//把服务的exe程序拷贝到了当前运行目录下，所以用此路径  
            string serviceInstallCommand = string.Format(@"{0}  {1}", dotNetPath, serviceEXEPath);//安装服务时使用的dos命令  
            string serviceUninstallCommand = string.Format(@"{0} -U {1}", dotNetPath, serviceEXEPath);//卸载服务时使用的dos命令  
            try
            {
                if (File.Exists(dotNetPath))
                {
                    string[] cmd = new string[] { serviceUninstallCommand };
                    string ss = Cmd(cmd);
                    CloseProcess("cmd.exe");
                }
            }
            catch
            {
            }
            Thread.Sleep(1000);
            try
            {
                if (File.Exists(dotNetPath))
                {
                    string[] cmd = new string[] { serviceInstallCommand };
                    string ss = Cmd(cmd);
                    CloseProcess("cmd.exe");
                }
            }
            catch
            {
            }
            try
            {
                Thread.Sleep(3000);
                ServiceController sc = new ServiceController("AutoRun");
                if (sc != null && (sc.Status.Equals(ServiceControllerStatus.Stopped)) || (sc.Status.Equals(ServiceControllerStatus.StopPending)))
                {
                    sc.Start();
                }
                sc.Refresh();
            }
            catch
            {
            }
        }

        /// <summary>  
        /// 运行CMD命令  
        /// </summary>  
        /// <param name="cmd">命令</param>  
        /// <returns></returns>  
        public static string Cmd(string[] cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.AutoFlush = true;
            for (int i = 0; i < cmd.Length; i++)
            {
                p.StandardInput.WriteLine(cmd[i].ToString());
            }
            p.StandardInput.WriteLine("exit");
            string strRst = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return strRst;
        }

        /// <summary>  
        /// 关闭进程  
        /// </summary>  
        /// <param name="ProcName">进程名称</param>  
        /// <returns></returns>  
        public static bool CloseProcess(string ProcName)
        {
            bool result = false;
            System.Collections.ArrayList procList = new System.Collections.ArrayList();
            string tempName = "";
            int begpos;
            int endpos;
            foreach (System.Diagnostics.Process thisProc in System.Diagnostics.Process.GetProcesses())
            {
                tempName = thisProc.ToString();
                begpos = tempName.IndexOf("(") + 1;
                endpos = tempName.IndexOf(")");
                tempName = tempName.Substring(begpos, endpos - begpos);
                procList.Add(tempName);
                if (tempName == ProcName)
                {
                    if (!thisProc.CloseMainWindow())
                        thisProc.Kill(); // 当发送关闭窗口命令无效时强行结束进程  
                    result = true;
                }
            }
            return result;
        }
        
        #region [启动服务]
        public static void ServiceStart(string serviceName)
        {
            ////获得服务集合
            //var serviceControllers = ServiceController.GetServices();
            ////遍历服务集合，打印服务名和服务状态
            //foreach (var service in serviceControllers)
            //{
            //    //Console.WriteLine("ServiceName:{0}\t\tServiceStatus:{1}", service.ServiceName, service.Status);
            //}
            //获取指定服务，若服务状态不是Runing就Start该服务
            ServiceController serviceController = new ServiceController(serviceName);
            if (serviceController != null && serviceController.Status != ServiceControllerStatus.Running)
            {
                serviceController.Start();
            }
        } 
        #endregion

        private static void TryStartSpooler(object state, bool timedout)
        {
            ServiceStart("Spooler");
        }
    }
}
