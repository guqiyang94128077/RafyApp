using DevExpress.XtraGrid.Views.Grid;
using Rafy.Domain;
using Rafy.Sys.Domain;
using Rafy.UI.PlugInCommon;
using System;
using System.Windows.Forms;

namespace Rafy.Sys.Modules
{
    
    public partial class frmModules : BaseForm
    {
        
        internal ModulesList _ModulesList { set; get; }
        public frmModules()
        {
            InitializeComponent();
            if (!DesignMode) {
                IniEditGridView(this.gridView1);
            }
        }
        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="appContext"></param>
        public frmModules(IAppContext appContext) : this()
        {
            _appContext = appContext;//

        }
        
        private void frmModules_Load(object sender, EventArgs e)
        {
            try
            {
                var repo = RF.ResolveInstance<ModulesRepository>();
                _ModulesList = repo.GetAll();
                BindUI(_ModulesList);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Name == "tlSave")
            {
                Save();
            }
            if (e.Item.Name == "tlEdit")
            {
                MessageDxUtil.ShowWarning("登陆用户："+_appContext.User.UserName);
            }
            if (e.Item.Name == "tlAdd")
            {
                var repo = RF.ResolveInstance<ModulesRepository>();
                Rafy.Sys.Domain.Modules entity = repo.New();
                _ModulesList.Add(entity);
            }
            if (e.Item.Name == "tlDelete")
            {
                BindUI(_ModulesList);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {
            
            this.gridView1.PostEditor();
            var repo = RF.ResolveInstance<ModulesRepository>();
            _ModulesList = this.modulesGridControl.DataSource as ModulesList;
            _ModulesList = repo.Save(_ModulesList) as ModulesList;
            BindUI(_ModulesList);
        }

        private void BindUI(ModulesList list) {
            this.modulesGridControl.DataSource = list;
            this.gridView1.RefreshData();
        }

        private void frmModules_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (_ModulesList.IsDirty) {

                if (MessageDxUtil.ShowYesNoAndWarning("窗体【" + this.Text + "】有数据没有保存，是否放弃保存并且关闭窗体？")==DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        
    }
}
