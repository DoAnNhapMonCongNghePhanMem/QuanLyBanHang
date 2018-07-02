namespace QuanLyDaiLy
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCapNhatPass = new DevExpress.XtraEditors.SimpleButton();
            this.cbHienThi = new System.Windows.Forms.CheckBox();
            this.txtPassCu = new System.Windows.Forms.TextBox();
            this.txtPassMoi = new System.Windows.Forms.TextBox();
            this.txtPassNhapLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCapNhatPass);
            this.panelControl1.Controls.Add(this.cbHienThi);
            this.panelControl1.Controls.Add(this.txtPassCu);
            this.panelControl1.Controls.Add(this.txtPassMoi);
            this.panelControl1.Controls.Add(this.txtPassNhapLai);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(4, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(620, 398);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCapNhatPass
            // 
            this.btnCapNhatPass.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnCapNhatPass.Appearance.Options.UseFont = true;
            this.btnCapNhatPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatPass.ImageOptions.Image")));
            this.btnCapNhatPass.Location = new System.Drawing.Point(320, 266);
            this.btnCapNhatPass.Name = "btnCapNhatPass";
            this.btnCapNhatPass.Size = new System.Drawing.Size(139, 59);
            this.btnCapNhatPass.TabIndex = 8;
            this.btnCapNhatPass.Text = "Cập nhật";
            this.btnCapNhatPass.Click += new System.EventHandler(this.btnCapNhatPass_Click);
            // 
            // cbHienThi
            // 
            this.cbHienThi.AutoSize = true;
            this.cbHienThi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbHienThi.Location = new System.Drawing.Point(297, 211);
            this.cbHienThi.Name = "cbHienThi";
            this.cbHienThi.Size = new System.Drawing.Size(189, 28);
            this.cbHienThi.TabIndex = 7;
            this.cbHienThi.Text = "Hiển thị mật khẩu";
            this.cbHienThi.UseVisualStyleBackColor = true;
            this.cbHienThi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPassCu
            // 
            this.txtPassCu.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPassCu.Location = new System.Drawing.Point(297, 49);
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.Size = new System.Drawing.Size(189, 32);
            this.txtPassCu.TabIndex = 6;
            // 
            // txtPassMoi
            // 
            this.txtPassMoi.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPassMoi.Location = new System.Drawing.Point(297, 103);
            this.txtPassMoi.Name = "txtPassMoi";
            this.txtPassMoi.Size = new System.Drawing.Size(189, 32);
            this.txtPassMoi.TabIndex = 5;
            this.txtPassMoi.UseSystemPasswordChar = true;
            // 
            // txtPassNhapLai
            // 
            this.txtPassNhapLai.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPassNhapLai.Location = new System.Drawing.Point(297, 162);
            this.txtPassNhapLai.Name = "txtPassNhapLai";
            this.txtPassNhapLai.Size = new System.Drawing.Size(189, 32);
            this.txtPassNhapLai.TabIndex = 4;
            this.txtPassNhapLai.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(79, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(79, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "DoiMatKhau";
            this.Size = new System.Drawing.Size(627, 401);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtPassCu;
        private System.Windows.Forms.TextBox txtPassMoi;
        private System.Windows.Forms.TextBox txtPassNhapLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatPass;
        private System.Windows.Forms.CheckBox cbHienThi;
    }
}
