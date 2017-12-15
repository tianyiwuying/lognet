using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogComponent
{
    public class TxtLogger
    {
        static log4net.ILog textLogger = log4net.LogManager.GetLogger("myTextLogger");
        
         ///<summary>
         ///把日志记录插入到文本
         ///</summary>
         ///<param name="msg"></param>
        public static void InsertTextLog(string msg) 
        {
            textLogger.Info(msg);
        }
    }
}
