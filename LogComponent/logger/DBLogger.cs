using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogComponent
{
    public class DBLogger
    {
        static log4net.ILog dbLogger1 = log4net.LogManager.GetLogger("myUserLogger");


        /// <summary>
        /// 添加数据库日志记录
        /// </summary>
        /// <param name="user">操作人</param>
        /// <param name="type">日志类型，1,：用户操作日志；2：系统日志</param>
        /// <param name="category">日志分类(操作类型)，1：用户系统登录；2：系统操作</param>
        /// <param name="state">日志状态，1：成功:2：失败:3：异常</param>
        /// <param name="description">日志信息描述</param>
        /// <param name="ip">客户端IP地址</param>
        public static void AddLog(string user, int type, int category, string state, string description, string ip)
        {
            dbLogger1.Info(new LogContent(type, category, user, ip, state, description));
        }
    }
}
