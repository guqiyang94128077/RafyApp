namespace Rafy.Sys.App
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.UserNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.PwdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPwd = new DevExpress.XtraLayout.LayoutControlItem();
            this.IsRememberPasswordCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForIsRememberPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.BtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExt = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.loginModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsRememberPasswordCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsRememberPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginModelBindingSource)).BeginInit();
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnExt);
            this.dataLayoutControl1.Controls.Add(this.BtnLogin);
            this.dataLayoutControl1.Controls.Add(this.UserNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PwdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsRememberPasswordCheckEdit);
            this.dataLayoutControl1.DataSource = this.loginModelBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(95, 41);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(477, 171);
            this.dataLayoutControl1.StyleController = this.SharedstyleController;
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(477, 171);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserName,
            this.ItemForPwd,
            this.ItemForIsRememberPassword,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(451, 145);
            // 
            // UserNameTextEdit
            // 
            this.UserNameTextEdit.EnterMoveNextControl = true;
            this.UserNameTextEdit.Location = new System.Drawing.Point(95, 16);
            this.UserNameTextEdit.Name = "UserNameTextEdit";
            this.UserNameTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.UserNameTextEdit.Size = new System.Drawing.Size(310, 26);
            this.UserNameTextEdit.StyleController = this.dataLayoutControl1;
            this.UserNameTextEdit.TabIndex = 4;
            // 
            // ItemForUserName
            // 
            this.ItemForUserName.Control = this.UserNameTextEdit;
            this.ItemForUserName.Location = new System.Drawing.Point(0, 0);
            this.ItemForUserName.Name = "ItemForUserName";
            this.ItemForUserName.Size = new System.Drawing.Size(395, 32);
            this.ItemForUserName.Text = "用户名";
            this.ItemForUserName.TextSize = new System.Drawing.Size(75, 18);
            // 
            // PwdTextEdit
            // 
            this.PwdTextEdit.EnterMoveNextControl = true;
            this.PwdTextEdit.Location = new System.Drawing.Point(95, 48);
            this.PwdTextEdit.Name = "PwdTextEdit";
            this.PwdTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.PwdTextEdit.Size = new System.Drawing.Size(310, 26);
            this.PwdTextEdit.StyleController = this.dataLayoutControl1;
            this.PwdTextEdit.TabIndex = 5;
            // 
            // ItemForPwd
            // 
            this.ItemForPwd.Control = this.PwdTextEdit;
            this.ItemForPwd.Location = new System.Drawing.Point(0, 32);
            this.ItemForPwd.Name = "ItemForPwd";
            this.ItemForPwd.Size = new System.Drawing.Size(395, 32);
            this.ItemForPwd.Text = "密码";
            this.ItemForPwd.TextSize = new System.Drawing.Size(75, 18);
            // 
            // IsRememberPasswordCheckEdit
            // 
            this.IsRememberPasswordCheckEdit.EnterMoveNextControl = true;
            this.IsRememberPasswordCheckEdit.Location = new System.Drawing.Point(95, 80);
            this.IsRememberPasswordCheckEdit.Name = "IsRememberPasswordCheckEdit";
            this.IsRememberPasswordCheckEdit.Properties.Caption = "Is Remember Password";
            this.IsRememberPasswordCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IsRememberPasswordCheckEdit.Size = new System.Drawing.Size(140, 19);
            this.IsRememberPasswordCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsRememberPasswordCheckEdit.TabIndex = 6;
            // 
            // ItemForIsRememberPassword
            // 
            this.ItemForIsRememberPassword.Control = this.IsRememberPasswordCheckEdit;
            this.ItemForIsRememberPassword.Location = new System.Drawing.Point(0, 64);
            this.ItemForIsRememberPassword.Name = "ItemForIsRememberPassword";
            this.ItemForIsRememberPassword.Size = new System.Drawing.Size(225, 25);
            this.ItemForIsRememberPassword.Text = "记住用户名";
            this.ItemForIsRememberPassword.TextSize = new System.Drawing.Size(75, 18);
            // 
            // BtnLogin
            // 
            this.BtnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnLogin.Location = new System.Drawing.Point(16, 105);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(219, 25);
            this.BtnLogin.StyleController = this.dataLayoutControl1;
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "登陆";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnLogin;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 89);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(225, 56);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnExt
            // 
            this.btnExt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExt.Location = new System.Drawing.Point(241, 105);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(220, 25);
            this.btnExt.StyleController = this.dataLayoutControl1;
            this.btnExt.TabIndex = 8;
            this.btnExt.Text = "退出";
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExt;
            this.layoutControlItem2.Location = new System.Drawing.Point(225, 89);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(226, 56);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(395, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(56, 32);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(395, 32);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(56, 32);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(225, 64);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(226, 25);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // loginModelBindingSource
            // 
            this.loginModelBindingSource.DataSource = typeof(Rafy.Sys.App.LoginModel);
            // 
            // frmLogin
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 273);
            this.Controls.Add(this.dataLayoutControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登陆";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SharedstyleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsRememberPasswordCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsRememberPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnExt;
        private DevExpress.XtraEditors.SimpleButton BtnLogin;
        private DevExpress.XtraEditors.TextEdit UserNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PwdTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsRememberPasswordCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPwd;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsRememberPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        internal System.Windows.Forms.BindingSource loginModelBindingSource;
    }
}