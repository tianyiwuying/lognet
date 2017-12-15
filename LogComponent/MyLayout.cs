using System;
using System.Collections.Generic;
using System.Text;
using log4net.Layout.Pattern;
using log4net.Layout;
using log4net.Core;
using System.Reflection;

namespace LogComponent
{
    class MyLayout : PatternLayout
    {
        //把我们定义的属性转换为log4net所能识别的属性
        public MyLayout()
        {
            this.AddConverter("property", typeof(MyMessagePatternConverter));
        }
    }

}