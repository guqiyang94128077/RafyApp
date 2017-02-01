using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AhDung.WinForm
{
    /// <summary>
    /// 带等待窗体的BackgroundWorker。报告进度用一组UI操作方法
    /// </summary>
    public class BackgroundWorkerUI : BackgroundWorker
    {
        readonly IWaitForm waitForm;//等待窗体
        Form activeForm;//等待窗体显示前的活动窗体
        bool formClosed;//指示等待窗体是否已被关闭

        #region 一组操作等候窗体UI的属性/方法

        /// <summary>
        /// 获取或设置进度描述
        /// </summary>
        public string WorkMessage
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return waitForm.Invoke(new Func<string>(() => waitForm.WorkMessage)) as string;
                }
                return waitForm.WorkMessage;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.WorkMessage = value));
                    return;
                }
                waitForm.WorkMessage = value;
            }
        }

        /// <summary>
        /// 获取或设置进度条可见性
        /// </summary>
        public bool BarVisible
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return Convert.ToBoolean(waitForm.Invoke(new Func<bool>(() => waitForm.BarVisible)));
                }
                return waitForm.BarVisible;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.BarVisible = value));
                    return;
                }
                waitForm.BarVisible = value;
            }
        }

        /// <summary>
        /// 获取或设置进度条动画样式
        /// </summary>
        public ProgressBarStyle BarStyle
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return (ProgressBarStyle)(waitForm.Invoke(new Func<ProgressBarStyle>(() => waitForm.BarStyle)));
                }
                return waitForm.BarStyle;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.BarStyle = value));
                    return;
                }
                waitForm.BarStyle = value;
            }
        }

        /// <summary>
        /// 获取或设置进度值
        /// </summary>
        public int BarValue
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return Convert.ToInt32(waitForm.Invoke(new Func<int>(() => waitForm.BarValue)));
                }
                return waitForm.BarValue;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.BarValue = value));
                    return;
                }
                waitForm.BarValue = value;
            }
        }

        /// <summary>
        /// 获取或设置进度条步进值
        /// </summary>
        public int BarStep
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return Convert.ToInt32(waitForm.Invoke(new Func<int>(() => waitForm.BarStep)));
                }
                return waitForm.BarStep;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.BarStep = value));
                    return;
                }
                waitForm.BarStep = value;
            }
        }

        /// <summary>
        /// 使进度条步进
        /// </summary>
        public void BarPerformStep()
        {
            if (waitForm.InvokeRequired)
            {
                waitForm.BeginInvoke(new Action(() => waitForm.BarPerformStep()));
                return;
            }
            waitForm.BarPerformStep();
        }

        /// <summary>
        /// 获取或设置进度条上限值
        /// </summary>
        public int BarMaximum
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return Convert.ToInt32(waitForm.Invoke(new Func<int>(() => waitForm.BarMaximum)));
                }
                return waitForm.BarMaximum;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.BarMaximum = value));
                    return;
                }
                waitForm.BarMaximum = value;
            }
        }

        /// <summary>
        /// 获取或设置进度条下限值
        /// </summary>
        public int BarMinimum
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return Convert.ToInt32(waitForm.Invoke(new Func<int>(() => waitForm.BarMinimum)));
                }
                return waitForm.BarMinimum;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.BarMinimum = value));
                    return;
                }
                waitForm.BarMinimum = value;
            }
        }

        /// <summary>
        /// 获取或设置取消任务的控件的可见性
        /// </summary>
        public bool CancelControlVisible
        {
            get
            {
                if (waitForm.InvokeRequired)
                {
                    return Convert.ToBoolean(waitForm.Invoke(new Func<bool>(() => waitForm.CancelControlVisible)));
                }
                return waitForm.CancelControlVisible;
            }
            set
            {
                if (waitForm.InvokeRequired)
                {
                    waitForm.BeginInvoke(new Action(() => waitForm.CancelControlVisible = value));
                    return;
                }
                waitForm.CancelControlVisible = value;
            }
        }

        #endregion

        /// <summary>
        /// 初始化组件
        /// </summary>
        public BackgroundWorkerUI()
            : this(new WaitForm())
        { }

        /// <summary>
        /// 初始化组件并指定等待窗体
        /// </summary>
        /// <param name="fmWait">等待窗体</param>
        public BackgroundWorkerUI(IWaitForm fmWait)
        {
            if (fmWait == null) { throw new WaitFormNullException(); }

            waitForm = fmWait;
            waitForm.UserCancelling += WaitForm_UserCancelling;//注册用户取消任务事件
        }

        /// <summary>
        /// 开始执行后台操作
        /// </summary>
        /// <param name="argument">要在DoWork事件处理程序中使用的参数</param>
        /// <remarks>通过可选参数可以同时覆盖基类无参RunWorkerAsync，一石二鸟</remarks>
        public new void RunWorkerAsync(object argument = null)
        {
            Form f;
            activeForm = (f = Form.ActiveForm) != null && f.IsMdiContainer ? f.ActiveMdiChild : f;//记录当时的活动窗体

            waitForm.CancelControlVisible = this.WorkerSupportsCancellation;
            formClosed = false;
            base.RunWorkerAsync(argument);

            //这里要判断一下，极端情况下有可能还没等ShowDialog，窗体就已经被关闭了
            if (!formClosed) { waitForm.ShowDialog(); }
        }

        /// <summary>
        /// 用户请求取消任务时
        /// </summary>
        private void WaitForm_UserCancelling(object sender, EventArgs e)
        {
            this.CancelAsync();
        }

        protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            waitForm.Hide();
            formClosed = true;

            //上面Hide后，原活动窗体会在该方法完成后才会重新获得焦点，所以必须加以干预让原窗体现在就获得焦点
            //否则随后的RunWorkerCompleted事件中弹出的模式窗体会有不正常的表现
            if (activeForm != null && !activeForm.IsDisposed) { activeForm.Activate(); }

            base.OnRunWorkerCompleted(e);
        }

        //资源释放
        protected override void Dispose(bool disposing)
        {
            IDisposable form;
            if (disposing && (form = waitForm as IDisposable) != null) { form.Dispose(); }

            base.Dispose(disposing);
        }
    }
}