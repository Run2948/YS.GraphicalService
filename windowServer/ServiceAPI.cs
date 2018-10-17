/* ==============================================================================
* 命名空间：windowServer
* 类 名 称：ServiceAPI
* 创 建 者：Qing
* 创建时间：2018-10-17 15:08:15
* CLR 版本：4.0.30319.42000
* 保存的文件名：ServiceAPI
* 文件版本：V1.0.0.0
*
* 功能描述：N/A 
*
* 修改历史：
*
*
* ==============================================================================
*         CopyRight @ 班纳工作室 2018. All rights reserved
* ==============================================================================*/



using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace windowServer
{
    public class ServiceApi
    {
        /// <summary>  
        /// 检查服务存在的存在性  
        /// </summary>  
        /// <param name="nameService">服务名</param>  
        /// <returns>存在返回 true,否则返回 false;</returns>  
        public static bool IsServiceIsExisted(string nameService)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController s in services)
            {
                if (s.ServiceName.ToLower() == nameService.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>  
        /// 安装Windows服务  
        /// </summary>  
        /// <param name="stateSaver">集合</param>  
        /// <param name="filepath">程序文件路径</param>  
        public static void InstallService(IDictionary stateSaver, string filepath)
        {
            AssemblyInstaller assemblyInstaller1 = new AssemblyInstaller {UseNewContext = true, Path = filepath};
            assemblyInstaller1.Install(stateSaver);
            assemblyInstaller1.Commit(stateSaver);
            assemblyInstaller1.Dispose();
        }
        /// <summary>  
        /// 卸载Windows服务  
        /// </summary>  
        /// <param name="filepath">程序文件路径</param>  
        public static void UnInstallService(string filepath)
        {
            AssemblyInstaller assemblyInstaller1 = new AssemblyInstaller {UseNewContext = true, Path = filepath};
            assemblyInstaller1.Uninstall(null);
            assemblyInstaller1.Dispose();
        }

        /// <summary>  
        /// 启动服务  
        /// </summary>  
        /// <param name="nameService">服务名</param>
        /// <returns>存在返回 true,否则返回 false;</returns>  
        public static bool RunService(string nameService)
        {
            bool bo = true;
            try
            {
                ServiceController sc = new ServiceController(nameService);
                if (sc.Status.Equals(ServiceControllerStatus.Stopped) || sc.Status.Equals(ServiceControllerStatus.StopPending))
                {
                    sc.Start();
                }
            }
            catch (Exception ex)
            {
                bo = false;
                LogApi.WriteLog(ex.Message);
            }

            return bo;
        }

        /// <summary>  
        /// 停止服务  
        /// </summary>  
        /// <param name="nameService">服务名</param>  
        /// <returns>存在返回 true,否则返回 false;</returns>  
        public static bool StopService(string nameService)
        {
            bool bo = true;
            try
            {
                ServiceController sc = new ServiceController(nameService);
                if (!sc.Status.Equals(ServiceControllerStatus.Stopped))
                {
                    sc.Stop();
                }
            }
            catch (Exception ex)
            {
                bo = false;
                LogApi.WriteLog(ex.Message);
            }

            return bo;
        }

        /// <summary>  
        /// 获取服务状态  
        /// </summary>  
        /// <param name="nameService">服务名</param>
        /// <returns>返回服务状态</returns>  
        public static int GetServiceStatus(string nameService)
        {
            int ret = 0;
            try
            {
                ServiceController sc = new ServiceController(nameService);
                ret = Convert.ToInt16(sc.Status);
            }
            catch (Exception ex)
            {
                ret = 0;
                LogApi.WriteLog(ex.Message);
            }

            return ret;
        }

        /// <summary>  
        /// 获取服务安装路径  
        /// </summary>  
        /// <param name="serviceName"></param>  
        /// <returns></returns>  
        public static string GetWindowsServiceInstallPath(string serviceName)
        {
            string path = "";
            try
            {
                string key = @"SYSTEM\CurrentControlSet\Services\" + serviceName;
                path = Registry.LocalMachine.OpenSubKey(key)?.GetValue("ImagePath").ToString();
                if (path != null)
                {
                    path = path.Replace("\"", string.Empty); //替换掉双引号    
                    var fi = new FileInfo(path);
                    path = fi.Directory?.ToString();
                }
            }
            catch (Exception ex)
            {
                path = "";
                LogApi.WriteLog(ex.Message);
            }
            return path;
        }

        /// <summary>  
        /// 获取指定服务的版本号  
        /// </summary>  
        /// <param name="serviceName">服务名称</param>  
        /// <returns></returns>  
        public static string GetServiceVersion(string serviceName)
        {
            if (string.IsNullOrEmpty(serviceName))
            {
                return string.Empty;
            }
            try
            {
                string path = GetWindowsServiceInstallPath(serviceName) + "\\" + serviceName + ".exe";
                Assembly assembly = Assembly.LoadFile(path);
                AssemblyName assemblyName = assembly.GetName();
                Version version = assemblyName.Version;
                return version.ToString();
            }
            catch (Exception ex)
            {
                LogApi.WriteLog(ex.Message);
                return string.Empty;
            }
        }
    }
}
