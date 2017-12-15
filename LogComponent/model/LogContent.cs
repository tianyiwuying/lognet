using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogComponent
{
    /// <summary>
    /// LogContent 的摘要说明
    /// </summary>
    public class LogContent
    {
        public LogContent()
        {
            LogType = 1;
            LogCategory = 1;
            LogOperator = "user";
            LogIp = "127.0.0.1";
            LogState ="1";
            LogDescription = "登录成功";
        }

        public LogContent(int logType, int logCategory, string logOperator, string logIP, string logState, string logDescription)
        {
            LogType = logType;
            LogCategory = logCategory;
            LogOperator = logOperator;
            LogIp = logIP;
            LogState = logState;
            LogDescription = logDescription;
        }

        public int LogType
        {
            get;
            set;
        }

        public int LogCategory
        {
            get;
            set;
        }

        public string LogOperator
        {
            get;
            set;
        }

        public string LogIp
        {
            get;
            set;
        }

        public string LogState
        {
            get;
            set;
        }

        public string LogDescription 
        {
            get;
            set;
        }
    }

}
