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
            #region ��֤
            if (UserNameTextEdit.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UserNameTextEdit, "��½�û�������Ϊ�գ�");
                return;
            }
            errorProvider1.Clear();
            if (PwdTextEdit.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(PwdTextEdit, "���벻��Ϊ�գ�");
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
                this.DialogResult = DialogResult.OK;    //����һ����¼�ɹ��ĶԻ���״̬
                this.Close();    //�رյ�¼����
            }
            else
            {
                MessageDxUtil.ShowError(reslogin.Message);
                this.UserNameTextEdit.Focus();
            }
        }

        #region private void SaveLogOnInfo(BaseUserInfo userInfo) ����¼��Ϣ���浽XML�ļ���
        /// <summary>
        /// ����¼��Ϣ���浽XML�ļ��С�
        /// ���������û������룬�Ǿ�Ӧ��ɾ������
        /// </summary>
        /// <param name="userInfo">��¼�û�</param>
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
            //// �����û�����Ϣ
            //UserConfigHelper.SaveConfig();

            /*
            // д��ע�����ʱ���û��Ȩ�ޣ������쳣��Ϣ�ȣ����Կ���д��XML�ļ�
            RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(@"Software\" + BaseConfiguration.COMPANY_NAME + "\\" + BaseSystemInfo.SoftName);
            if (this.chkRememberPassword.Checked)
            {
                // Ĭ�ϵ���Ϣд��ע���,�Ǻ���Ҫ�Ľ�һ��
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
        #region �ޱ߿����϶�
        //-------------------�ޱ߿����϶�---------------------------
        Point mouseOff;//����ƶ�λ�ñ���
        bool leftFlag;//��ǩ�Ƿ�Ϊ���
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //�õ�������ֵ
                leftFlag = true;                  //����������ʱ��עΪtrue;
            }
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //�����ƶ����λ��
                (((System.Windows.Forms.Form)sender)).Location = mouseSet;
            }
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//�ͷ������עΪfalse;
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
        //------------------------end �ޱ߿����϶�-----------------------------------
        #endregion

       
    }
    /// <summary>
    /// ��½��Ϣģ����
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// ��¼��
        /// </summary>
        public string UserName { set; get; }
        /// <summary>
        /// ����
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// ����
        /// </summary>
        public string Pwd { set; get; }
        /// <summary>
        /// �Ƿ��ס����
        /// </summary>
        public bool IsRememberPassword { set; get; }
    }
}