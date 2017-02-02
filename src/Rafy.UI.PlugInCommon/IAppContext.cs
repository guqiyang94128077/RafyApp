using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy.UI.PlugInCommon
{
    /// <summary>
    /// 上下文
    /// </summary>
    public interface IAppContext<TUser>
    {
        TUser User { get; set; }

        //还可以定义很多需要的属性
    }
}
