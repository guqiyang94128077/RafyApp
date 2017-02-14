using Rafy;
using Rafy.Accounts;
using Rafy.DbMigration;
using Rafy.Domain;
using Rafy.Domain.ORM.DbMigration;
using Rafy.RBAC.DataPermissionManagement;
using Rafy.RBAC.GroupManagement;
using Rafy.RBAC.RoleManagement;
using Rafy.RBAC.UserRoleManagement;
using Rafy.Sys.Domain;
using Rafy.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RafyApp.WCFPortal
{
    public class RafyApp : DomainApp
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
            RafyEnvironment.Provider.IsDebuggingEnabled = ConfigurationHelper.GetAppSettingOrDefault("IsDebuggingEnabled", false);
            //RafyEnvironment.Location.DataPortalMode = DataPortalMode.ThroughService;
            //RafyEnvironment.Location.IsWPFUI = false;
            //RafyEnvironment.Location.DataPortalMode = DataPortalMode.ConnectDirectly;
            DbSettingNames.RafyPlugins = DbSettingNames.DbMigrationHistory
                = SysDomainPlugin.DbSettingName;//将所有配置统一在一个数据库中
            if (ConfigurationHelper.GetAppSettingOrDefault("AutoUpdateDb", false))
            {
                var svc = ServiceFactory.Create<MigrateService>();
                svc.Options = new MigratingOptions
                {
                    ReserveHistory = true,//ReserveHistory 表示是否需要保存所有数据库升级的历史记录
                    RunDataLossOperation = DataLossOperation.All,//要禁止数据库表、字段的删除操作，请使用 DataLossOperation.None 值。
                    Databases = new string[] { SysDomainPlugin.DbSettingName }
                };
                svc.Invoke();
            }
        }
    }
}