using Rafy.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy.UI.PlugInCommon
{
    public class SysAppContext : IAppContext<User>
    {
        public User User
        {
            get;

            set;
        }
    }
}
