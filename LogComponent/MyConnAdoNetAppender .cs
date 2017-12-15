using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Appender;

namespace LogComponent
{
    public class MyConnAdoNetAppender : AdoNetAppender 
    {
        private static ILog _Log;

        /// <summary> 
        /// Gets the log. 
        /// </summary> 
        /// <value>The log.</value> 
        protected static ILog Log
        {
            get
            {
                if (_Log == null)
                    _Log = log4net.LogManager.GetLogger("myUserLogger");
                return _Log;
            }
        }

        private static string _ConnectionStringName;
        public override void ActivateOptions()
        {
            PopulateConnectionString();
            base.ActivateOptions();
        }
        private void PopulateConnectionString()
        {      
            if (!String.IsNullOrEmpty(ConnectionString)) return;

            if (String.IsNullOrEmpty(ConnectionStringName)) return;

            ConnectionString = _ConnectionStringName; 
        }

        /// <summary> 
        /// Gets or sets the name of the connection string. 
        /// </summary> 
        /// <value>The name of the connection string.</value> 
        public static string ConnectionStringName
        {
            get { return _ConnectionStringName; }
            set { _ConnectionStringName = value; }
        } 
    }
}
