using DevExpress.XtraGrid.Views.Grid;
using Rafy.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rafy.UI.PlugInCommon
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 上下文
        /// </summary>
        public AppContext _appContext = null;
        public BaseForm()
        {
            InitializeComponent();
        }
        public BaseForm(AppContext appContext) //:  this()
        {
            InitializeComponent();
            _appContext = appContext;
        }
        /// <summary>
        /// 初始化编辑表格
        /// </summary>
        /// <param name="dgv"></param>
        public void IniEditGridView(GridView dgv)
        {
            dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;//在底层新增行
            dgv.OptionsNavigation.AutoFocusNewRow = true;//自动定位到新行
            dgv.OptionsNavigation.AutoMoveRowFocus = true;
            dgv.OptionsNavigation.EnterMoveNextColumn = true;//回车键跳转到下一列
            dgv.OptionsView.ColumnAutoWidth = true;
        }
        /// <summary>
        /// 初始化显示表格
        /// </summary>
        /// <param name="dgv"></param>
        public void IniShowGridView(GridView dgv)
        {
            dgv.OptionsBehavior.Editable = false;
            dgv.OptionsSelection.MultiSelect = true;
            dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;


        }
    }
}
