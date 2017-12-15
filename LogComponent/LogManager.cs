using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace LogComponent
{
    public class LogManager
    {
        //插入一条数据库的日志记录
        public static void InsertDBLog(string user,int type, int category, string  state, string description, string ip)
        {
            DBLogger.AddLog(user,type, category, state, description, ip);
        }
        //插入一条文本的日志记录
        public static void InsertTxtLog(string description)
        {
            TxtLogger.InsertTextLog(description);
        }
    }
}