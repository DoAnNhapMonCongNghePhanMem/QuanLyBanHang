namespace QuanLyDaiLy
{
    partial class Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoiPass = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangKi = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAmin = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pnlAmin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 558);
            this.panel1.TabIndex = 1;
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnDoiPass.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoiPass.Appearance.Options.UseFont = true;
            this.btnDoiPass.Appearance.Options.UseForeColor = true;
            this.btnDoiPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiPass.ImageOptions.Image")));
            this.btnDoiPass.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDoiPass.Location = new System.Drawing.Point(1, 243);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(196, 143);
            this.btnDoiPass.TabIndex = 1;
            this.btnDoiPass.Text = "Đổi mật khẩu";
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnDangKi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangKi.Appearance.Options.UseFont = true;
            this.btnDangKi.Appearance.Options.UseForeColor = true;
            this.btnDangKi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKi.ImageOptions.Image")));
            this.btnDangKi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDangKi.Location = new System.Drawing.Point(0, 99);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(196, 138);
            this.btnDangKi.TabIndex = 0;
            this.btnDangKi.Text = "Đăng kí tài khoản";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDoiPass);
            this.panel2.Controls.Add(this.btnDangKi);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 551);
            this.panel2.TabIndex = 2;
            // 
            // pnlAmin
            // 
            this.pnlAmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAmin.Location = new System.Drawing.Point(210, 4);
            this.pnlAmin.Name = "pnlAmin";
            this.pnlAmin.Size = new System.Drawing.Size(716, 551);
            this.pnlAmin.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(932, 564);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDoiPass;
        private DevExpress.XtraEditors.SimpleButton btnDangKi;
        private System.Windows.Forms.Panel pnlAmin;
        private System.Windows.Forms.Panel panel2;
    }
}
