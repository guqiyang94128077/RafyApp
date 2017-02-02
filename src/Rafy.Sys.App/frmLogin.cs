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
using System.Runtime.InteropServices;

namespace Rafy.Sys.App
{
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(Form_MouseUp);
        }
        public User _userInfo;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var repo = RF.ResolveInstance<UserRepository>();

            var controller = DomainControllerFactory.Create<AccountController>();
            controller.IdentityMode = UserIdentityMode.Email | UserIdentityMode.UserName;
            _userInfo = null;
            
            var reslogin = controller.LoginByUserName(UserNameTextEdit.Text.Trim(), PwdTextEdit.Text.Trim(), out _userInfo);
            if (reslogin.Success)
            {
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                this.Close();    //关闭登录窗口
            }
            else
            {
                MessageDxUtil.ShowError(reslogin.Message);
                this.UserNameTextEdit.Focus();
            }
        }

        
        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region 无边框窗体拖动
        //-------------------无边框窗体拖动---------------------------
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                (((System.Windows.Forms.Form)sender)).Location = mouseSet;
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        //------------------------end 无边框窗体拖动-----------------------------------
        #endregion

    }
    /// <summary>
    /// 登陆类
    /// </summary>
    public class LoginModel {
        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { set; get; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { set; get; }
    }
}