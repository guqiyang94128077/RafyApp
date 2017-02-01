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
            //_appContext = appContext;//
            
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
            //构造函数的另一个重载可传入自定义等待窗体的实例
            //using (BackgroundWorkerUI bgwUI = new BackgroundWorkerUI(/*new MyWaitForm()*/))
            //{
            //    bgwUI.WorkerSupportsCancellation = true;//允许取消任务

            //    bgwUI.DoWork += bgwUI_DoWork;
            //    //bgwUI.ProgressChanged += bgwUI_ProgressChanged;//虽然不需要，但仍可注册ProgressChanged事件做其它事
            //    bgwUI.RunWorkerCompleted += bgwUI_RunWorkerCompleted;//亦可注册RunWorkerCompleted事件

            //    bgwUI.RunWorkerAsync();
            //}
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
        //void bgwUI_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorkerUI bgwUI = sender as BackgroundWorkerUI;

        //    //可以通过bgwUI的一组公开属性和方法更新等待窗体
        //    //bgwUI.CancelControlVisible = true;//设置取消任务的控件的可见性，默认该属性会根据WorkerSupportsCancellation设置，但仍可以自由设置
        //    bgwUI.BarStyle = ProgressBarStyle.Continuous;//设置滚动条样式（默认是Marquee：循环梭动式）
        //    bgwUI.BarMaximum = 100;      //设置滚动条值上限（默认是100）
        //    bgwUI.BarMinimum = 0;        //设置滚动条值下限（默认是0）
        //    bgwUI.BarStep = 1;           //设置滚动条步进幅度（默认是10）
        //    bgwUI.BarVisible = true;     //设置滚动条是否可见（默认是true：可见）

        //    int i;
        //    for (i = Convert.ToInt32(e.Argument); i <= 100; i++)
        //    {
        //        if (bgwUI.CancellationPending)//老样子，访问CancellationPending获知用户是否取消任务
        //        {
        //            e.Cancel = true;
        //            return;
        //        }

        //        //更新等待窗体不需要调用ReportProgress()，也不需要WorkerReportsProgress支持
        //        bgwUI.WorkMessage = i.ToString();//设置任务进度描述
        //        bgwUI.BarValue = i;              //设置任务进度值

        //        //CancelControlVisible可以反复设置，不受WorkerSupportsCancellation限制
        //        //if (i % 10 == 0) { bgw.CancelControlVisible = false; }
        //        //else if (i % 5 == 0) { bgw.CancelControlVisible = true; }

        //        Thread.Sleep(50);
        //    }
        //    e.Result = i;
        //}

        //void bgwUI_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    if (e.Cancelled)
        //    {
        //        MessageBox.Show("任务已取消！");
        //    }
        //    else if (e.Error != null)
        //    {
        //        MessageBox.Show("任务有异常！" + e.Error.Message);
        //    }
        //    else
        //    {
        //        MessageBox.Show("任务完成。" + e.Result);
        //    }
        //}
    }
}
