using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using Rafy;
using Rafy.ComponentModel;
using Rafy.Domain;
using Rafy.Domain.ORM;
using Rafy.Domain.Validation;
using Rafy.MetaModel;
using Rafy.MetaModel.Attributes;
using Rafy.MetaModel.View;
using Rafy.ManagedProperty;

namespace Rafy.Sys.Domain
{
    [Serializable]
    public abstract class SysDomainEntity : LongEntity
    {
        #region 构造函数

        protected SysDomainEntity() { }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        protected SysDomainEntity(SerializationInfo info, StreamingContext context) : base(info, context) { }

        #endregion
    }

    [Serializable]
    public abstract class SysDomainEntityList : EntityList { }

    public abstract class SysDomainEntityRepository : EntityRepository
    {
        protected SysDomainEntityRepository() { }
    }

    [DataProviderFor(typeof(SysDomainEntityRepository))]
    public class SysDomainEntityRepositoryDataProvider : RdbDataProvider
    {
        protected override string ConnectionStringSettingName
        {
            get { return SysDomainPlugin.DbSettingName; }
        }
    }

    public abstract class DomainEntityConfig<TEntity> : EntityConfig<TEntity> { }
}