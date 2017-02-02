using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rafy.Domain;
using Rafy.Accounts;
using Rafy.Accounts.Controllers;
using Rafy.UI.PlugInCommon;

namespace Rafy.Sys.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public UserInfo _userInfo;
        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var repo = RF.ResolveInstance<UserRepository>();
           
            var controller = DomainControllerFactory.Create<AccountController>();
            controller.IdentityMode = UserIdentityMode.Email | UserIdentityMode.UserName;
            
            User user = null;
            var reslogin = controller.LoginByUserName(this.txtName.Text.Trim(), this.txtPwd.Text, out user);
            if (reslogin.Success) {
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                this._userInfo=new UserInfo() { UserId = 0, UserName = this.txtName.Text.Trim()};
                this.Close();    //关闭登录窗口
            }
            else
            {
                MessageDxUtil.ShowError(reslogin.Message);
            }
        }
    }
}