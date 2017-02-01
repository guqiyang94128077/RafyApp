using Rafy.UI.PlugInCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyPlugIn1
{
    public partial class MyPlugInForm : BaseForm
    {
        /// <summary>
        /// 上下文
        /// </summary>
        IAppContext _appContext = null;
        public MyPlugInForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="appContext"></param>
        public MyPlugInForm(IAppContext appContext) : this()
        {
            _appContext = appContext;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_appContext != null)
            {
                MessageBox.Show(this, "我是插件,登录用户：" + _appContext.User.UserName);
            }
            else
            {
                MessageBox.Show(this, "插件无法获取用户信息.");
            }
        }
    }
}
