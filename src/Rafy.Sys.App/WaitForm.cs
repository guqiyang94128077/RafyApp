using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AhDung.WinForm
{
    /// <summary>
    /// 等待窗体
    /// </summary>
    ///<remarks>IWaitForm的默认实现</remarks>
    public class WaitForm : Form, IWaitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.IContainer components = null;

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
            this.lbMsg = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMsg
            // 
            this.lbMsg.Location = new System.Drawing.Point(10, 20);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(386, 55);
            this.lbMsg.TabIndex = 0;
            this.lbMsg.Text = "正在处理，请稍候...";
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(12, 78);
            this.bar.Name = "bar";
            this.bar.Step = 1;
            this.bar.Size = new System.Drawing.Size(384, 16);
            this.bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.bar.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // FmWaitForDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 155);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.lbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FmWaitForDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请稍候...";
            this.ResumeLayout(false);
        }

        #endregion

        System.Windows.Forms.Label lbMsg;
        System.Windows.Forms.Button btnCancel;
        System.Windows.Forms.ProgressBar bar;

        public WaitForm()
        {
            InitializeComponent();

            btnCancel.Click += btnCancel_Click;//注册取消按钮单击事件
        }

        #region 将【取消】按钮点击、窗体关闭等行为视为触发【取消任务】事件

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //阻止用户关闭窗体并触发UserCancelling事件
            //加Visible是因为调用Hide()也会触发该事件，为了避免再次OnUserCancelling为之
            if (e.CloseReason == CloseReason.UserClosing && this.Visible)
            {
                e.Cancel = true;
                this.OnUserCancelling();
            }
            base.OnFormClosing(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.OnUserCancelling();
        }

        protected virtual void OnUserCancelling()
        {
            if (UserCancelling != null) { UserCancelling(this, EventArgs.Empty); }
        }

        //屏蔽窗体关闭按钮
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible) { AhDung.WinForm.WinFormHelper.DisableCloseButton(this); }
        }
        #endregion

        #region 实现接口

        public string WorkMessage
        {
            get { return lbMsg.Text; }
            set { lbMsg.Text = value; }
        }

        public bool BarVisible
        {
            get { return bar.Visible; }
            set { bar.Visible = value; }
        }

        public ProgressBarStyle BarStyle
        {
            get { return bar.Style; }
            set { bar.Style = value; }
        }

        public int BarValue
        {
            get { return bar.Value; }
            set { bar.Value = value; }
        }

        public int BarStep
        {
            get { return bar.Step; }
            set { bar.Step = value; }
        }

        public void BarPerformStep()
        {
            bar.PerformStep();
        }

        public bool CancelControlVisible
        {
            get { return btnCancel.Visible; }
            set { btnCancel.Visible = value; }
        }

        public int BarMaximum
        {
            get { return bar.Maximum; }
            set { bar.Maximum = value; }
        }

        public int BarMinimum
        {
            get { return bar.Minimum; }
            set { bar.Minimum = value; }
        }

        public event EventHandler UserCancelling;
        #endregion
    }

    /// <summary>
    /// 等待窗体规范
    /// </summary>
    public interface IWaitForm
    {
        #region 用于操作等待窗体UI表现的属性和方法，实现时不用操心线程问题，让客户端（任务执行器）去操心

        /// <summary>
        /// 获取或设置进度描述
        /// </summary>
        /// <remarks>建议默认值为“请稍候...”之类的字眼</remarks>
        string WorkMessage { get; set; }

        /// <summary>
        /// 获取或设置进度条的可见性
        /// </summary>
        /// <remarks>建议默认值为true</remarks>
        bool BarVisible { get; set; }

        /// <summary>
        /// 获取或设置进度条的动画样式
        /// </summary>
        /// <remarks>建议默认值为Marquee</remarks>
        ProgressBarStyle BarStyle { get; set; }

        /// <summary>
        /// 获取或设置进度条的值
        /// </summary>
        /// <remarks>建议默认值为0</remarks>
        int BarValue { get; set; }

        /// <summary>
        /// 获取或设置进度条的步进幅度
        /// </summary>
        int BarStep { get; set; }

        /// <summary>
        /// 使进度条步进
        /// </summary>
        void BarPerformStep();

        /// <summary>
        /// 获取或设置取消任务的控件的可见性
        /// </summary>
        /// <remarks>建议默认值为false</remarks>
        bool CancelControlVisible { get; set; }

        /// <summary>
        /// 获取或设置进度条的值上限
        /// </summary>
        /// <remarks>建议默认值为100</remarks>
        int BarMaximum { get; set; }

        /// <summary>
        /// 获取或设置进度条的值下限
        /// </summary>
        /// <remarks>建议默认值为0</remarks>
        int BarMinimum { get; set; }

        #endregion

        /// <summary>
        /// 显示模式等待窗体
        /// </summary>
        /// <remarks>建议使用Form类的默认实现</remarks>
        DialogResult ShowDialog();

        #region Invoke相关，供客户端在跨线程操作窗体UI

        /// <summary>
        /// 指示是否需要使用Invoke操作窗体控件
        /// </summary>
        /// <remarks>建议使用Form类的默认实现</remarks>
        bool InvokeRequired { get; }

        /// <summary>
        /// 窗体Invoke方法
        /// </summary>
        /// <remarks>建议使用Form类的默认实现</remarks>
        object Invoke(Delegate method);

        /// <summary>
        /// 窗体BeginInvoke方法
        /// </summary>
        /// <remarks>建议使用Form类的默认实现</remarks>
        IAsyncResult BeginInvoke(Delegate method);

        #endregion

        /// <summary>
        /// 隐藏等待窗体
        /// </summary>
        /// <remarks>建议使用Form类的默认实现</remarks>
        void Hide();

        /// <summary>
        /// 当用户请求取消任务时
        /// </summary>
        /// <remarks>应在用户交互取消控件、关闭窗体时触发该事件</remarks>
        event EventHandler UserCancelling;
    }

    /// <summary>
    /// 等候窗体为空
    /// </summary>
    public class WaitFormNullException : ApplicationException
    {
        public WaitFormNullException() : base("等待窗体不能为null！") { }
    }
    public static class WinFormHelper
    {
        [DllImport("User32.dll ")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32.dll ")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        const int MF_REMOVE = 0x1000;
        //const int SC_RESTORE = 0xF120;     //还原 
        //const int SC_MOVE = 0xF010;   //移动 
        //const int SC_SIZE = 0xF000;   //大小 
        //const int SC_MINIMIZE = 0xF020;   //最小化 
        //const int SC_MAXIMIZE = 0xF030;   //最大化 
        const int SC_CLOSE = 0xF060;   //关闭 

        /// <summary>
        /// 屏蔽窗体关闭功能
        /// </summary>
        public static void DisableCloseButton(IWin32Window form)
        {
            IntPtr hMenu = GetSystemMenu(form.Handle, false);
            RemoveMenu(hMenu, SC_CLOSE, MF_REMOVE);
        }
    }
}