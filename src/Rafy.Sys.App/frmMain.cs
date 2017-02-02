using DevExpress.XtraBars.Navigation;
using Rafy.UI.PlugInCommon;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Rafy.Sys.App
{
    public partial class frmMain : Form, IAppContext
    {
        public UserInfo User { set; get; }
        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += FrmMain_FormClosing;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageDxUtil.ShowYesNoAndWarning("是否退出系统？") == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 设置显示的系统信息
            this.tslLoginName.Text += RafyEnvironment.Principal.Identity.Name;
            this.tslGroupName.Text += "Group";
            switch (RafyEnvironment.Location.DataPortalMode)
            {
                case DataPortalMode.ConnectDirectly:
                    this.tslDataPortalMode.Text += "数据库直连模式";
                    break;
                case DataPortalMode.ThroughService:
                    this.tslDataPortalMode.Text += "WCF服务模式";
                    break;
                default:
                    this.tslDataPortalMode.Text += "未知";
                    break;
            }
            
            #endregion
            AccordionControlElement elem = new AccordionControlElement();
            elem.Text= "菜单组";
            elem.Name = "菜单组";
            elem.Style = ElementStyle.Group;
            accordionControl1.Elements.Add(elem);
            AccordionControlElement elem1 = new AccordionControlElement();
            elem1.Text = "测试菜单";
            elem1.Name = "菜单";
            elem1.Style = ElementStyle.Item;
            elem1.Tag = "MyPlugIn1.MyPlugIn1,MyPlugIn1.dll";
            elem1.Click += Elem_Click;
            elem.Elements.Add(elem1);

            AccordionControlElement elem2 = new AccordionControlElement();
            elem2.Text = "模块管理";
            elem2.Name = "ModulesPlugin";
            elem2.Style = ElementStyle.Item;
            elem2.Tag = "Rafy.Sys.Modules.ModulesPlugin,Rafy.Sys.Modules.dll";
            elem2.Click += Elem_Click;
            elem.Elements.Add(elem2);
        }

        private void Elem_Click(object sender, EventArgs e)
        {
            AccordionControlElement tooStripMenu = sender as AccordionControlElement;
            if (tooStripMenu == null)
            {
                return;
            }
            string  tag = tooStripMenu.Tag as string ;
            if (string .IsNullOrWhiteSpace(tag))
                return;
            //获取插件目录
            string Pluginspath = ConfigurationHelper.GetAppSettingOrDefault("PluginsPath", @"\plugins\");
            //获取插件对象
            IPlugIn plugIn = LoadPlugIn(Pluginspath + tag.Split(',')[1], tag.Split(',')[0]);
            
            //创建子窗体并显示
            BaseForm plugInForm = plugIn.CreatePlugInForm();
            plugInForm.MdiParent = this;
            plugInForm.Show();
        }
        /// <summary>
        /// 加载插件
        /// </summary>
        /// <param name="dllPath">插件所在路径</param>
        /// <param name="fullName">插件全名：namespace+className</param>
        /// <returns>具体插件</returns>
        public IPlugIn LoadPlugIn(string dllPath, string fullName)
        {
            Assembly pluginAssembly = null;
            string path = System.IO.Directory.GetCurrentDirectory() + dllPath;
            try
            {
                //加载程序集
                pluginAssembly = Assembly.LoadFile(path);
            }
            catch (Exception ex)
            {
                return null;
            }
            Type[] types = pluginAssembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.FullName == fullName && type.GetInterface("IPlugIn") != null)
                {   
                    //仅是需要加载的对象才创建插件的实例
                    IPlugIn plugIn = (IPlugIn)Activator.CreateInstance(type);
                    plugIn.AppContext = this;
                    return plugIn;
                }
            }
            return null;
        }
       
        
    }
}
