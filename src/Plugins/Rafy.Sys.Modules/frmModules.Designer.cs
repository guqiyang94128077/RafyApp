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
            this.modulesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.assemblyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.modulesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.moduleGuidTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.moduleNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.moduleTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleGuidTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
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
            // modulesGridControl
            // 
            this.modulesGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.modulesGridControl.Location = new System.Drawing.Point(0, 50);
            this.modulesGridControl.MainView = this.gridView1;
            this.modulesGridControl.MenuManager = this.barManager1;
            this.modulesGridControl.Name = "modulesGridControl";
            this.modulesGridControl.Size = new System.Drawing.Size(1296, 207);
            this.modulesGridControl.TabIndex = 5;
            this.modulesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.modulesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.dataLayoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 257);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1296, 463);
            this.panelControl1.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(337, 331);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(216, 43);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.assemblyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.descriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.idSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.moduleGuidTextEdit);
            this.dataLayoutControl1.Controls.Add(this.moduleNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.moduleTypeTextEdit);
            this.dataLayoutControl1.Location = new System.Drawing.Point(310, 97);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(645, 228);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // assemblyTextEdit
            // 
            this.assemblyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulesViewModelBindingSource, "Assembly", true));
            this.assemblyTextEdit.Location = new System.Drawing.Point(115, 16);
            this.assemblyTextEdit.MenuManager = this.barManager1;
            this.assemblyTextEdit.Name = "assemblyTextEdit";
            this.assemblyTextEdit.Size = new System.Drawing.Size(514, 24);
            this.assemblyTextEdit.StyleController = this.dataLayoutControl1;
            this.assemblyTextEdit.TabIndex = 5;
            // 
            // modulesViewModelBindingSource
            // 
            this.modulesViewModelBindingSource.DataSource = typeof(Rafy.Sys.Modules.ModulesViewModel);
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulesViewModelBindingSource, "Description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(115, 46);
            this.descriptionTextEdit.MenuManager = this.barManager1;
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(514, 24);
            this.descriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.descriptionTextEdit.TabIndex = 7;
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulesViewModelBindingSource, "Id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(115, 76);
            this.idSpinEdit.MenuManager = this.barManager1;
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(514, 24);
            this.idSpinEdit.StyleController = this.dataLayoutControl1;
            this.idSpinEdit.TabIndex = 9;
            // 
            // moduleGuidTextEdit
            // 
            this.moduleGuidTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulesViewModelBindingSource, "ModuleGuid", true));
            this.moduleGuidTextEdit.Location = new System.Drawing.Point(115, 106);
            this.moduleGuidTextEdit.MenuManager = this.barManager1;
            this.moduleGuidTextEdit.Name = "moduleGuidTextEdit";
            this.moduleGuidTextEdit.Size = new System.Drawing.Size(514, 24);
            this.moduleGuidTextEdit.StyleController = this.dataLayoutControl1;
            this.moduleGuidTextEdit.TabIndex = 11;
            // 
            // moduleNameTextEdit
            // 
            this.moduleNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulesViewModelBindingSource, "ModuleName", true));
            this.moduleNameTextEdit.Location = new System.Drawing.Point(115, 136);
            this.moduleNameTextEdit.MenuManager = this.barManager1;
            this.moduleNameTextEdit.Name = "moduleNameTextEdit";
            this.moduleNameTextEdit.Size = new System.Drawing.Size(514, 24);
            this.moduleNameTextEdit.StyleController = this.dataLayoutControl1;
            this.moduleNameTextEdit.TabIndex = 13;
            // 
            // moduleTypeTextEdit
            // 
            this.moduleTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modulesViewModelBindingSource, "ModuleType", true));
            this.moduleTypeTextEdit.Location = new System.Drawing.Point(115, 166);
            this.moduleTypeTextEdit.MenuManager = this.barManager1;
            this.moduleTypeTextEdit.Name = "moduleTypeTextEdit";
            this.moduleTypeTextEdit.Size = new System.Drawing.Size(514, 24);
            this.moduleTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.moduleTypeTextEdit.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem12});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(645, 228);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.assemblyTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(619, 30);
            this.layoutControlItem2.Text = "Assembly:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.descriptionTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(619, 30);
            this.layoutControlItem4.Text = "Description:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.idSpinEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(619, 30);
            this.layoutControlItem6.Text = "Id:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.moduleGuidTextEdit;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(619, 30);
            this.layoutControlItem8.Text = "Module Guid:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(95, 18);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.moduleNameTextEdit;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(619, 30);
            this.layoutControlItem10.Text = "Module Name:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(95, 18);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.moduleTypeTextEdit;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(619, 52);
            this.layoutControlItem12.Text = "Module Type:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(95, 18);
            // 
            // frmModules
            // 
            this.ClientSize = new System.Drawing.Size(1296, 644);
            this.Controls.Add(this.panelControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assemblyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleGuidTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource modulesViewModelBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit assemblyTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.TextEdit moduleGuidTextEdit;
        private DevExpress.XtraEditors.TextEdit moduleNameTextEdit;
        private DevExpress.XtraEditors.TextEdit moduleTypeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
