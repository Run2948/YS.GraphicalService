using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowServer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //获取欲启动进程名  
            string strProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            //获得当前登录的Windows用户标示
            System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            ////获取版本号  
            //CommonData.VersionNumber = Application.ProductVersion;  
            //检查进程是否已经启动，已经启动则显示报错信息退出程序。  
            if (System.Diagnostics.Process.GetProcessesByName(strProcessName).Length > 1)
            {
                MessageBox.Show("程序已经运行。");
                Thread.Sleep(1000);
                Environment.Exit(1);
            }
            else
            {
                System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
                //判断当前登录用户是否为管理员
                if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                {
                    //如果是管理员，则直接运行 
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    //创建启动对象 
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    //设置运行文件 
                    startInfo.FileName = Application.ExecutablePath;
                    //设置启动参数 
                    startInfo.Arguments = string.Join(" ", args);
                    //设置启动动作,确保以管理员身份运行 
                    startInfo.Verb = "runas";
                    //如果不是管理员，则启动UAC 
                    System.Diagnostics.Process.Start(startInfo);
                    //退出 
                    Application.Exit();
                }
            }
        }
    }
}
