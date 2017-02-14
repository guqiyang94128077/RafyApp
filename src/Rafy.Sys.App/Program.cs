using Rafy.Accounts;
using Rafy.DbMigration;
using Rafy.Domain;
using Rafy.Domain.ORM.DbMigration;
using Rafy.RBAC.DataPermissionManagement;
using Rafy.RBAC.GroupManagement;
using Rafy.RBAC.RoleManagement;
using Rafy.RBAC.UserRoleManagement;
using Rafy.Sys.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Taskbar.Core;

namespace Rafy.Sys.App
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            TaskbarAssistantCore.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //连接WCF服务
            //new RafyApp().Startup();
            //客户端直连
            new ClientDomainApp().Startup();

            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            if (fl.DialogResult == DialogResult.OK)
            {
                //frmMain frm = new frmMain();
                //frm.User = fl._userInfo;
                Application.Run(new frmMain());
            }
            else
            {
                return;
            }
        }
    }

    /// <summary>
    /// 通过数据库直连方式启动
    /// </summary>
    public class ClientDomainApp : DomainApp
    {
        protected override void InitEnvironment()
        {
            RafyEnvironment.DomainPlugins.Add(new SysDomainPlugin());
            //添加RBAC插件到 Rafy 应用程序集中。
            RafyEnvironment.DomainPlugins.Add(new AccountsPlugin());
            RafyEnvironment.DomainPlugins.Add(new RoleManagementPlugin());
            RafyEnvironment.DomainPlugins.Add(new GroupManagementPlugin());
            RafyEnvironment.DomainPlugins.Add(new UserRoleManagementPlugin());
            RafyEnvironment.DomainPlugins.Add(new DataPermissionManagementPlugin());
            base.InitEnvironment();
        }
        protected override void OnRuntimeStarting()
        {
            base.OnRuntimeStarting();
            DbSettingNames.RafyPlugins = DbSettingNames.DbMigrationHistory
                = SysDomainPlugin.DbSettingName;//将所有配置统一在一个数据库中
            RafyEnvironment.Location.IsWPFUI = true;
            RafyEnvironment.Location.DataPortalMode = DataPortalMode.ConnectDirectly;
            //if (ConfigurationHelper.GetAppSettingOrDefault("AutoUpdateDb", false))
            //{
            //    var svc = ServiceFactory.Create<MigrateService>();
            //    svc.Options = new MigratingOptions
            //    {
            //        ReserveHistory = true,//ReserveHistory 表示是否需要保存所有数据库升级的历史记录
            //        RunDataLossOperation = DataLossOperation.All,//要禁止数据库表、字段的删除操作，请使用 DataLossOperation.None 值。
            //        Databases = new string[] { SysDomainPlugin.DbSettingName }
            //    };
            //    svc.Invoke();
            //}
        }
    }

    /// <summary>
    /// 通过WCF服务的方式启动
    /// </summary>
    class RafyApp : DomainApp
    {
        protected override void InitEnvironment()
        {
            RafyEnvironment.DomainPlugins.Add(new SysDomainPlugin());
            //添加RBAC插件到 Rafy 应用程序集中。
            RafyEnvironment.DomainPlugins.Add(new AccountsPlugin());
            RafyEnvironment.DomainPlugins.Add(new RoleManagementPlugin());
            RafyEnvironment.DomainPlugins.Add(new GroupManagementPlugin());
            RafyEnvironment.DomainPlugins.Add(new UserRoleManagementPlugin());
            RafyEnvironment.DomainPlugins.Add(new DataPermissionManagementPlugin());
            base.InitEnvironment();
        }

        protected override void OnRuntimeStarting()
        {
            base.OnRuntimeStarting();
            //DbSettingNames.RafyPlugins = DbSettingNames.DbMigrationHistory
            //    = SysDomainPlugin.DbSettingName;//将所有配置统一在一个数据库中
            RafyEnvironment.Location.IsWPFUI = true;
            RafyEnvironment.Location.DataPortalMode = DataPortalMode.ThroughService;
            //if (ConfigurationHelper.GetAppSettingOrDefault("AutoUpdateDb", false))
            //{
            //    var svc = ServiceFactory.Create<MigrateService>();
            //    svc.Options = new MigratingOptions
            //    {
            //        ReserveHistory = true,//ReserveHistory 表示是否需要保存所有数据库升级的历史记录
            //        RunDataLossOperation = DataLossOperation.All,//要禁止数据库表、字段的删除操作，请使用 DataLossOperation.None 值。
            //        Databases = new string[] { SysDomainPlugin.DbSettingName }
            //    };
            //    svc.Invoke();
            //}
        }
    }
}
