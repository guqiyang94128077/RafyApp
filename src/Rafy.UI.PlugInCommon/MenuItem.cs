using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rafy.UI.PlugInCommon
{
    /// <summary>
    /// 主菜单
    /// </summary>
    [XmlRoot("Main", IsNullable = false)]
    public class AppMenu
    {
        [XmlElement("MenuItem", IsNullable = false)]
        public List<MenuItem> MenuItems { get; set; }
    }

    /// <summary>
    /// 菜单项
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        [XmlElement("MenuName", IsNullable = false)]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单ID
        /// </summary>
        [XmlElement("ID", IsNullable = false)]
        public string MenuId { get; set; }

        /// <summary>
        /// 插件
        /// </summary>
        [XmlElement("PlugIn")]
        public string PlugIn { get; set; }

        /// <summary>
        /// 插件所在路径
        /// </summary>
        [XmlElement("PlugInPath")]
        public string PlugInPath { get; set; }

        /// <summary>
        /// 子菜单
        /// </summary>
        [XmlElement("MenuItem")]
        public List<MenuItem> SubMenus { get; set; }
    }
}
