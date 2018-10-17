/* ==============================================================================
* 命名空间：windowServer
* 类 名 称：LogAPI
* 创 建 者：Qing
* 创建时间：2018-10-17 15:06:06
* CLR 版本：4.0.30319.42000
* 保存的文件名：LogAPI
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowServer
{
    public class LogApi
    {
        private static string _myPath = "";
        private static string _myName = "";

        /// <summary>  
        /// 初始化日志文件  
        /// </summary>  
        /// <param name="logPath"></param>  
        /// <param name="logName"></param>  
        public static void InitLogApi(string logPath, string logName)
        {
            _myPath = logPath;
            _myName = logName;
        }

        /// <summary>  
        /// 写入日志  
        /// </summary>  
        /// <param name="ex">日志信息</param>  
        public static void WriteLog(string ex)
        {
            if (_myPath == "" || _myName == "")
                return;

            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString().PadLeft(2, '0');
            string day = DateTime.Now.Day.ToString().PadLeft(2, '0');

            //年月日文件夹是否存在，不存在则建立  
            if (!Directory.Exists(_myPath + "\\LogFiles\\" + year + "_" + month + "\\" + year + "_" + month + "_" + day))
            {
                Directory.CreateDirectory(_myPath + "\\LogFiles\\" + year + "_" + month + "\\" + year + "_" + month + "_" + day);
            }

            //写入日志UNDO,Exception has not been handle  
            string logFile = _myPath + "\\LogFiles\\" + year + "_" + month + "\\" + year + "_" + month + "_" + day + "\\" + _myName;
            if (!File.Exists(logFile))
            {
                var myFile = File.AppendText(logFile);
                myFile.Close();
            }

            while (true)
            {
                try
                {
                    StreamWriter sr = File.AppendText(logFile);
                    sr.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "  " + ex);
                    sr.Close();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    System.Threading.Thread.Sleep(50);
                    continue;
                }
            }

        }

    }
}
