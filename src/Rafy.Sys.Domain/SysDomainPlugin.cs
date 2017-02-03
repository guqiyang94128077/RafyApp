using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rafy;
using Rafy.ComponentModel;
using Rafy.DbMigration;
using Rafy.Domain;
using Rafy.Domain.ORM.DbMigration;

namespace Rafy.Sys.Domain
{
    /// <summary>
    /// 系统管理所用的领域实体插件
    /// </summary>
    public class SysDomainPlugin : DomainPlugin
    {
        public static string DbSettingName = "SysDomain";

        public override void Initialize(IApp app)
        {

        }
    }
}
