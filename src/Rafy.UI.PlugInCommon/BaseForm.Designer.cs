namespace Rafy.UI.PlugInCommon
{
    partial class BaseForm
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
            this.SharedstyleController = new DevExpress.XtraEditors.StyleController();
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).BeginInit();
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
            this.SharedstyleController.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.SharedstyleController.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(568, 361);
            this.Name = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.StyleController SharedstyleController;
    }
}
