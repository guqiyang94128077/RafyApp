using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using Rafy;
using Rafy.ComponentModel;
using Rafy.Data;
using Rafy.Domain;
using Rafy.Domain.ORM;
using Rafy.Domain.ORM.Query;
using Rafy.Domain.Validation;
using Rafy.ManagedProperty;
using Rafy.MetaModel;
using Rafy.MetaModel.Attributes;
using Rafy.MetaModel.View;

namespace Rafy.Sys.Domain
{
    /// <summary>
    /// 系统界面模块名称
    /// </summary>
    [RootEntity, Serializable, Label("系统管理 - 模块")]
    public partial class Modules : SysDomainEntity
    {
        #region 构造函数

        public Modules() { }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        protected Modules(SerializationInfo info, StreamingContext context) : base(info, context) { }

        #endregion

        #region 引用属性

        #endregion

        #region 组合子属性

        #endregion

        #region 一般属性
        public static readonly Property<string> ModuleNameProperty = P<Modules>.Register(e => e.ModuleName);
        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName
        {
            get { return this.GetProperty(ModuleNameProperty); }
            set { this.SetProperty(ModuleNameProperty, value); }
        }
        public static readonly Property<string> AssemblyProperty = P<Modules>.Register(e => e.ModuleAssembly);
        /// <summary>
        /// 模块所属的程序集
        /// </summary>
        public string ModuleAssembly
        {
            get { return this.GetProperty(AssemblyProperty); }
            set { this.SetProperty(AssemblyProperty, value); }
        }
        public static readonly Property<string> ModuleTypeProperty = P<Modules>.Register(e => e.ModuleType);
        /// <summary>
        /// 模块命名空间
        /// </summary>
        public string ModuleType
        {
            get { return this.GetProperty(ModuleTypeProperty); }
            set { this.SetProperty(ModuleTypeProperty, value); }
        }
        public static readonly Property<string> DescriptionProperty = P<Modules>.Register(e => e.Description);
        /// <summary>
        /// 模块说明
        /// </summary>
        public string Description
        {
            get { return this.GetProperty(DescriptionProperty); }
            set { this.SetProperty(DescriptionProperty, value); }
        }
        public static readonly Property<string> ModuleGuidProperty = P<Modules>.Register(e => e.ModuleGuid);
        /// <summary>
        /// 模块标识
        /// </summary>
        public string ModuleGuid
        {
            get { return this.GetProperty(ModuleGuidProperty); }
            set { this.SetProperty(ModuleGuidProperty, value); }
        }
        #endregion

        #region 只读属性

        #endregion


    }

    /// <summary>
    /// 实体的领域名称 列表类。
    /// </summary>
    [Serializable]
    public partial class ModulesList : SysDomainEntityList { }

    /// <summary>
    /// 实体的领域名称 仓库类。
    /// 负责 实体的领域名称 类的查询、保存。
    /// </summary>
    public partial class ModulesRepository : SysDomainEntityRepository
    {
        /// <summary>
        /// 单例模式，外界不可以直接构造本对象。
        /// </summary>
        protected ModulesRepository() { }
    }

    /// <summary>
    /// 实体的领域名称 配置类。
    /// 负责 实体的领域名称 类的实体元数据的配置。
    /// </summary>
    internal class ModulesConfig : DomainEntityConfig<Modules>
    {
        /// <summary>
        /// 配置实体的元数据
        /// </summary>
        protected override void ConfigMeta()
        {
            //配置实体的所有属性都映射到数据表中。
            Meta.MapTable().MapAllProperties();
        }
        protected override void AddValidations(IValidationDeclarer rules)
        {
            rules.AddRule(Modules.ModuleGuidProperty, new RequiredRule());
            rules.AddRule(Modules.ModuleNameProperty, new RequiredRule());
            rules.AddRule(Modules.ModuleTypeProperty, new RequiredRule());
            rules.AddRule(Modules.AssemblyProperty, new RequiredRule());
        }
    }
}