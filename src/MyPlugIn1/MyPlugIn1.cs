using Rafy.UI.PlugInCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlugIn1
{
    /// <summary>
    /// 插件
    /// </summary>
    public class MyPlugIn1 : IPlugIn
    {
        private IAppContext _app;

        public IAppContext AppContext
        {
            get { return _app; }
            set { _app = value; }
        }

        public BaseForm CreatePlugInForm()
        {
            return new MyPlugInForm(AppContext);
        }
    }
}
