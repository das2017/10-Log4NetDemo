using System;
using System.Reflection;
using log4net;

namespace Log4NetDemo
{
    /// <summary>
    /// 说明：本程序演示如何利用log4net记录应用程序日志信息
    /// </summary>
    public class MainClass
    {
        private static ILog log = LogManager.GetLogger("FileLogger");
     
        public static void Main(string[] args)
        {
            log.Debug("调试信息的日志");     
            log.Info("一般信息的日志");       
            log.Warn("警告信息的日志");          
            log.Error("错误信息的日志", new Exception("发生了一个异常"));         
            log.Fatal("致命错误的日志", new Exception("发生了一个致命错误"));

            Console.WriteLine("日志记录完毕。");
            Console.Read();
        }
    }
}
