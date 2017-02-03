using Rafy;
using Rafy.Sys.Domain;
using Rafy.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace RafyApp.WCFPortal
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RafyEnvironment.Provider.IsDebuggingEnabled = HttpContext.Current.IsDebuggingEnabled;
            RafyEnvironment.Provider.DllRootDirectory = Path.Combine(RafyEnvironment.Provider.RootDirectory, "Bin");

            //RafyEnvironment.DomainPlugins.Add(new UnitTestPlugin());
            //RafyEnvironment.DomainPlugins.Add(new SysDomainPlugin());
            var app = new RafyApp();
            app.Startup();
            using (ServiceHost serviceHost = new ServiceHost(typeof(Rafy.Domain.DataPortal.WCF.ServerPortal)))
            {
                serviceHost.Open();
            }
        }
        public override void Init()
        {
            base.Init();
            //new RafyWebApp().Startup();
            
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}