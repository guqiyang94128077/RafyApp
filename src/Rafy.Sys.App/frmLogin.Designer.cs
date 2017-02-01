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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExt = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÓÃ»§Ãû";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(139, 78);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(218, 26);
            this.txtPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÃÜÂë";
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLogin.Location = new System.Drawing.Point(139, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "µÇÂ½";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExt
            // 
            this.btnExt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExt.Location = new System.Drawing.Point(275, 130);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(82, 25);
            this.btnExt.TabIndex = 4;
            this.btnExt.Text = "ÍË³ö";
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 213);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "µÇÂ½";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnExt;
    }
}