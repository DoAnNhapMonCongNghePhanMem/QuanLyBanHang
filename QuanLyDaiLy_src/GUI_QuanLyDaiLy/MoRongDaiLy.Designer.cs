namespace QuanLyDaiLy
{
    partial class MoRongDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoRongDaiLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemQuan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiDL = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMoRong = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pnlMoRong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 541);
            this.panel1.TabIndex = 1;
            // 
            // btnThemQuan
            // 
            this.btnThemQuan.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnThemQuan.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemQuan.Appearance.Options.UseFont = true;
            this.btnThemQuan.Appearance.Options.UseForeColor = true;
            this.btnThemQuan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemQuan.ImageOptions.Image")));
            this.btnThemQuan.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThemQuan.Location = new System.Drawing.Point(5, 247);
            this.btnThemQuan.Name = "btnThemQuan";
            this.btnThemQuan.Size = new System.Drawing.Size(193, 120);
            this.btnThemQuan.TabIndex = 1;
            this.btnThemQuan.Text = "Thêm quận";
            this.btnThemQuan.Click += new System.EventHandler(this.btnThemQuan_Click);
            // 
            // btnThemLoaiDL
            // 
            this.btnThemLoaiDL.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnThemLoaiDL.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemLoaiDL.Appearance.Options.UseFont = true;
            this.btnThemLoaiDL.Appearance.Options.UseForeColor = true;
            this.btnThemLoaiDL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiDL.ImageOptions.Image")));
            this.btnThemLoaiDL.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThemLoaiDL.Location = new System.Drawing.Point(5, 82);
            this.btnThemLoaiDL.Name = "btnThemLoaiDL";
            this.btnThemLoaiDL.Size = new System.Drawing.Size(196, 124);
            this.btnThemLoaiDL.TabIndex = 0;
            this.btnThemLoaiDL.Text = "Thêm loại đại lý";
            this.btnThemLoaiDL.Click += new System.EventHandler(this.btnThemLoaiDL_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemQuan);
            this.panel2.Controls.Add(this.btnThemLoaiDL);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 534);
            this.panel2.TabIndex = 2;
            // 
            // pnlMoRong
            // 
            this.pnlMoRong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMoRong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMoRong.Location = new System.Drawing.Point(208, 4);
            this.pnlMoRong.Name = "pnlMoRong";
            this.pnlMoRong.Size = new System.Drawing.Size(648, 534);
            this.pnlMoRong.TabIndex = 3;
            // 
            // MoRongDaiLy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "MoRongDaiLy";
            this.Size = new System.Drawing.Size(862, 547);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThemQuan;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiDL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMoRong;
    }
}
