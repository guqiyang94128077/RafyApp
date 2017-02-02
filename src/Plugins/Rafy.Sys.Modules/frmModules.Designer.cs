namespace Rafy.Sys.Modules
{
    partial class frmModules
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModules));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.tlAdd = new DevExpress.XtraBars.BarButtonItem();
            this.tlEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tlDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tlSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tlAdd,
            this.tlDelete,
            this.tlEdit,
            this.tlSave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barManager1_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.tlAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.tlEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.tlDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.tlSave)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // tlAdd
            // 
            this.tlAdd.Caption = "新增";
            this.tlAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("tlAdd.Glyph")));
            this.tlAdd.Id = 0;
            this.tlAdd.Name = "tlAdd";
            this.tlAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // tlEdit
            // 
            this.tlEdit.Caption = "修改";
            this.tlEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tlEdit.Glyph")));
            this.tlEdit.Id = 2;
            this.tlEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tlEdit.LargeGlyph")));
            this.tlEdit.Name = "tlEdit";
            this.tlEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // tlDelete
            // 
            this.tlDelete.Caption = "删除";
            this.tlDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tlDelete.Glyph")));
            this.tlDelete.Id = 1;
            this.tlDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tlDelete.LargeGlyph")));
            this.tlDelete.Name = "tlDelete";
            this.tlDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // tlSave
            // 
            this.tlSave.Caption = "保存";
            this.tlSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tlSave.Glyph")));
            this.tlSave.Id = 3;
            this.tlSave.Name = "tlSave";
            this.tlSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1296, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Size = new System.Drawing.Size(1296, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 594);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1296, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 594);
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataSource = typeof(Rafy.Sys.Domain.Modules);
            // 
            // modulesGridControl
            // 
            this.modulesGridControl.DataSource = this.modulesBindingSource;
            this.modulesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulesGridControl.Location = new System.Drawing.Point(0, 50);
            this.modulesGridControl.MainView = this.gridView1;
            this.modulesGridControl.MenuManager = this.barManager1;
            this.modulesGridControl.Name = "modulesGridControl";
            this.modulesGridControl.Size = new System.Drawing.Size(1296, 594);
            this.modulesGridControl.TabIndex = 5;
            this.modulesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.modulesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmModules
            // 
            this.ClientSize = new System.Drawing.Size(1296, 644);
            this.Controls.Add(this.modulesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模块管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModules_FormClosing);
            this.Load += new System.EventHandler(this.frmModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem tlAdd;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tlDelete;
        private DevExpress.XtraBars.BarButtonItem tlEdit;
        private DevExpress.XtraBars.BarButtonItem tlSave;
        private DevExpress.XtraGrid.GridControl modulesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal System.Windows.Forms.BindingSource modulesBindingSource;
    }
}
