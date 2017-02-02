using Rafy.UI.PlugInCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy.Sys.Modules
{
    [Module("E7562E20-6A31-4468-BC52-1091F549B57B", "模块管理", "窗体模块功能测试")]
    public class ModulesPlugin : IPlugIn
    {
        private IAppContext _app;

        public IAppContext AppContext
        {
            get { return _app; }
            set { _app = value; }
        }


        public BaseForm CreatePlugInForm()
        {
            return new frmModules(AppContext);
        }
    }
}
