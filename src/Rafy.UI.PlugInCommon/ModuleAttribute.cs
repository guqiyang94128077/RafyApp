using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafy.UI.PlugInCommon
{
    /* 
     * 特性类本身用一个特性System.AttributeUsage来标记，只能用在特性上，不能应用到类上
     * 该特性主要标示定制特性可应用到哪些类型的程序元素上
     *  
     * AttributeTargets：指定定制特性可应用到哪些类型的程序元素上，可用"|"指定多个元素
     * AllowMultiple参数：表示一个特性是否可多次应用到同一项上
     * Inherited参数：表示应用到类，接口，方法，属性上的特性可自动应用到所有派生类，接口，方法，属性，重写版本上
     * 
     * 特性类派生于System.Attribute类
     */

    /***************** 定义特性类ModuleAttribute ******************/
    /// <summary>
    /// 窗口模块的信息
    /// </summary>
    /***************** 定义特性类SupportsWhatsNewAttribute，指示该特性仅用于程序集 ******************/
    //[AttributeUsage(AttributeTargets.Assembly)]
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class ModuleAttribute : Attribute
    {
        /// <summary>
        /// 模块标识
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 模块名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 模块说明
        /// </summary>
        public string Description { get; set; }


        public ModuleAttribute(string guid, string name, string description)
        {
            this.Guid = guid;
            this.Name = name;
            this.Description = description;
        }
        public ModuleAttribute(string guid, string name)
        {
            this.Guid = guid;
            this.Name = name;
            this.Description = name;
        }
    }
}
