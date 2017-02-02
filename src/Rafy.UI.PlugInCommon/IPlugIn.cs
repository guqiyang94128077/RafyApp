using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy.UI.PlugInCommon
{
    /// <summary>
    /// 插件接口
    /// </summary>
    public interface IPlugIn
    {
        /// <summary>
        /// 应用程序上下文
        /// </summary>
        IAppContext AppContext
        {
            get;
            set;
        }

        /// <summary>
        /// 创建子窗体
        /// </summary>
        /// <returns></returns>
        BaseForm CreatePlugInForm();
    }
}
