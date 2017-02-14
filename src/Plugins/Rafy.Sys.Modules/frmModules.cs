using Rafy.Domain;
using Rafy.Sys.Domain;
using Rafy.UI.PlugInCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Rafy.Sys.Modules
{

    public partial class frmModules : BaseForm
    {

        internal ModulesList _CurrModulesList { set; get; }
        internal Rafy.Sys.Domain.Modules _CurrModules { set; get; }
        public frmModules()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                IniEditGridView(this.gridView1);
            }
        }



        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="appContext"></param>
        public frmModules(IAppContext appContext)
            : this()
        {
            _appContext = appContext;//

        }

        private void frmModules_Load(object sender, EventArgs e)
        {
            try
            {
                var repo = RF.ResolveInstance<ModulesRepository>();
                _CurrModulesList = repo.GetAll();
                this.modulesListBindingSource.DataSource = _CurrModulesList;
                //BindUI(_CurrModulesList);
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
                MessageDxUtil.ShowWarning("登陆用户：" + _appContext.User.UserName);
            }
            if (e.Item.Name == "tlAdd")
            {
                var repo = RF.ResolveInstance<ModulesRepository>();
                Rafy.Sys.Domain.Modules entity = repo.New();
                _CurrModulesList.Add(entity);
            }
            if (e.Item.Name == "tlDelete")
            {
                //BindUI(_CurrModulesList);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {

            this.gridView1.PostEditor();
            var repo = RF.ResolveInstance<ModulesRepository>();
            _CurrModulesList = this.modulesListBindingSource.DataSource as ModulesList;
            _CurrModulesList = repo.Save(_CurrModulesList) as ModulesList;
            //BindUI(_CurrModulesList);
        }

        //private void BindUI(ModulesList list)
        //{
            
        //    this.modulesListBindingSource.DataSource = list;
        //}

        private void frmModules_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (_CurrModulesList.IsDirty)
            {

                if (MessageDxUtil.ShowYesNoAndWarning("窗体【" + this.Text + "】有数据没有保存，是否放弃保存并且关闭窗体？") == DialogResult.Yes)
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
