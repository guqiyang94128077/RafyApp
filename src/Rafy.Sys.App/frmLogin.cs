using System;
using System.Drawing;
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
        
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            #region 验证
            if (UserNameTextEdit.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UserNameTextEdit, "登陆用户名不能为空！");
                return;
            }
            errorProvider1.Clear();
            if (PwdTextEdit.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(PwdTextEdit, "密码不能为空！");
                return;
            }
            errorProvider1.Clear();
            #endregion

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

        #region private void SaveLogOnInfo(BaseUserInfo userInfo) 将登录信息保存到XML文件中
        /// <summary>
        /// 将登录信息保存到XML文件中。
        /// 若不保存用户名密码，那就应该删除掉。
        /// </summary>
        /// <param name="userInfo">登录用户</param>
        private void SaveLogOnInfo(LoginModel userInfo)
        {
            //BaseSystemInfo.RememberPassword = this.chkRememberPassword.Checked;
            //if (this.chkRememberPassword.Checked)
            //{
            //    BaseSystemInfo.CurrentUserName = userInfo.UserName;
            //    // BaseSystemInfo.CurrentUserName = SecretUtil.Encrypt(userInfo.UserName);
            //    BaseSystemInfo.CurrentPassword = SecretUtil.Encrypt(this.txtPassword.Text);
            //}
            //else
            //{
            //    BaseSystemInfo.CurrentUserName = string.Empty;
            //    BaseSystemInfo.CurrentPassword = string.Empty;
            //}
            //// 保存用户的信息
            //UserConfigHelper.SaveConfig();

            /*
            // 写入注册表，有时候会没有权限，发生异常信息等，可以考虑写入XML文件
            RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(@"Software\" + BaseConfiguration.COMPANY_NAME + "\\" + BaseSystemInfo.SoftName);
            if (this.chkRememberPassword.Checked)
            {
                // 默认的信息写入注册表,呵呵需要改进一下
                registryKey.SetValue(BaseConfiguration.CURRENT_USERNAME, SecretUtil.Encrypt(userInfo.UserName));
                registryKey.SetValue(BaseConfiguration.CURRENT_PASSWORD, SecretUtil.Encrypt(this.txtPassword.Text));
            }
            else
            {
                registryKey.SetValue(BaseConfiguration.CURRENT_USERNAME, string.Empty);
                registryKey.SetValue(BaseConfiguration.CURRENT_PASSWORD, string.Empty);
            }
            */
        }
        #endregion
        private void btnExt_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
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
    /// 登陆信息模型类
    /// </summary>
    public class LoginModel
    {
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
        /// <summary>
        /// 是否记住密码
        /// </summary>
        public bool IsRememberPassword { set; get; }
    }
}