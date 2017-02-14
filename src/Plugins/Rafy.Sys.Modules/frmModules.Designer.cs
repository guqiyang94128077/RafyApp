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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.modulesListGridControl = new DevExpress.XtraGrid.GridControl();
            this.modulesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ModuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModuleAss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModuleType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModuleGuid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulesListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SharedstyleController
            // 
            this.SharedstyleController.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.SharedstyleController.AppearanceDisabled.Options.UseBackColor = true;
            this.SharedstyleController.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SharedstyleController.AppearanceFocused.Options.UseBackColor = true;
            this.SharedstyleController.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SharedstyleController.AppearanceReadOnly.Options.UseBackColor = true;
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
            this.barDockControlTop.Size = new System.Drawing.Size(935, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 446);
            this.barDockControlBottom.Size = new System.Drawing.Size(935, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(935, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.modulesListGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(935, 396);
            this.panelControl1.TabIndex = 10;
            // 
            // modulesListGridControl
            // 
            this.modulesListGridControl.DataSource = this.modulesListBindingSource;
            this.modulesListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulesListGridControl.Location = new System.Drawing.Point(2, 2);
            this.modulesListGridControl.MainView = this.gridView1;
            this.modulesListGridControl.MenuManager = this.barManager1;
            this.modulesListGridControl.Name = "modulesListGridControl";
            this.modulesListGridControl.Size = new System.Drawing.Size(931, 392);
            this.modulesListGridControl.TabIndex = 0;
            this.modulesListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // modulesListBindingSource
            // 
            this.modulesListBindingSource.DataSource = typeof(Rafy.Domain.Entity);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ModuleName,
            this.ModuleAss,
            this.ModuleType,
            this.Description,
            this.ModuleGuid,
            this.Id});
            this.gridView1.GridControl = this.modulesListGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // ModuleName
            // 
            this.ModuleName.Caption = "窗体名称";
            this.ModuleName.FieldName = "ModuleName";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Visible = true;
            this.ModuleName.VisibleIndex = 1;
            // 
            // ModuleAss
            // 
            this.ModuleAss.Caption = "程序集";
            this.ModuleAss.FieldName = "ModuleAss";
            this.ModuleAss.Name = "ModuleAss";
            this.ModuleAss.Visible = true;
            this.ModuleAss.VisibleIndex = 2;
            // 
            // ModuleType
            // 
            this.ModuleType.Caption = "窗体插件类";
            this.ModuleType.FieldName = "ModuleType";
            this.ModuleType.Name = "ModuleType";
            this.ModuleType.Visible = true;
            this.ModuleType.VisibleIndex = 3;
            // 
            // Description
            // 
            this.Description.Caption = "窗体说明";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 4;
            // 
            // ModuleGuid
            // 
            this.ModuleGuid.Caption = "窗体标识";
            this.ModuleGuid.FieldName = "ModuleGuid";
            this.ModuleGuid.Name = "ModuleGuid";
            this.ModuleGuid.Visible = true;
            this.ModuleGuid.VisibleIndex = 5;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "程序集";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "程序集";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // frmModules
            // 
            this.ClientSize = new System.Drawing.Size(935, 446);
            this.Controls.Add(this.panelControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulesListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesListBindingSource)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl modulesListGridControl;
        private System.Windows.Forms.BindingSource modulesListBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ModuleName;
        private DevExpress.XtraGrid.Columns.GridColumn ModuleAss;
        private DevExpress.XtraGrid.Columns.GridColumn ModuleType;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn ModuleGuid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
