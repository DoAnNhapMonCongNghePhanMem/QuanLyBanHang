namespace QuanLyDaiLy
{
    partial class QuanLyDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDaiLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvDaiLy = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnReMove = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtsearch = new DevExpress.XtraEditors.TextEdit();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbLoaiDL = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtTienNo = new DevExpress.XtraEditors.TextEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNguoiNhan = new DevExpress.XtraEditors.TextEdit();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbQuan = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSdt = new DevExpress.XtraEditors.TextEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenDaiLy = new DevExpress.XtraEditors.TextEdit();
            this.dtNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDaiLy)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienNo.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiNhan.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaiLy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.gvDaiLy);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gvDaiLy
            // 
            resources.ApplyResources(this.gvDaiLy, "gvDaiLy");
            this.gvDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDaiLy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDaiLy.Name = "gvDaiLy";
            this.gvDaiLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDaiLy_CellClick);
            this.gvDaiLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDaiLy_CellContentClick);
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Controls.Add(this.btnReMove);
            this.panel11.Controls.Add(this.panelControl1);
            this.panel11.Controls.Add(this.btnSua);
            this.panel11.Controls.Add(this.btnXoa);
            this.panel11.Controls.Add(this.btnThem);
            this.panel11.Name = "panel11";
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // btnReMove
            // 
            this.btnReMove.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnReMove.Appearance.Font")));
            this.btnReMove.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("btnReMove.Appearance.ForeColor")));
            this.btnReMove.Appearance.Options.UseFont = true;
            this.btnReMove.Appearance.Options.UseForeColor = true;
            this.btnReMove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReMove.ImageOptions.Image")));
            this.btnReMove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            resources.ApplyResources(this.btnReMove, "btnReMove");
            this.btnReMove.Name = "btnReMove";
            this.btnReMove.Click += new System.EventHandler(this.btnReMove_Click);
            // 
            // panelControl1
            // 
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.panelControl1.Controls.Add(this.txtsearch);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // txtsearch
            // 
            resources.ApplyResources(this.txtsearch, "txtsearch");
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtsearch.Properties.Appearance.Font")));
            this.txtsearch.Properties.Appearance.Options.UseFont = true;
            this.txtsearch.EditValueChanged += new System.EventHandler(this.txtsearch_EditValueChanged_1);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSua.Appearance.Font")));
            this.btnSua.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("btnSua.Appearance.ForeColor")));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            resources.ApplyResources(this.btnSua, "btnSua");
            this.btnSua.Name = "btnSua";
            this.btnSua.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnXoa.Appearance.Font")));
            this.btnXoa.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("btnXoa.Appearance.ForeColor")));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnThem.Appearance.Font")));
            this.btnThem.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("btnThem.Appearance.ForeColor")));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            resources.ApplyResources(this.btnThem, "btnThem");
            this.btnThem.Name = "btnThem";
            this.btnThem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cbLoaiDL);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cbLoaiDL
            // 
            resources.ApplyResources(this.cbLoaiDL, "cbLoaiDL");
            this.cbLoaiDL.FormattingEnabled = true;
            this.cbLoaiDL.Name = "cbLoaiDL";
            this.cbLoaiDL.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDL_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.dtNgayNhan);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.txtTienNo);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // txtTienNo
            // 
            resources.ApplyResources(this.txtTienNo, "txtTienNo");
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTienNo.Properties.Appearance.Font")));
            this.txtTienNo.Properties.Appearance.Options.UseFont = true;
            this.txtTienNo.EditValueChanged += new System.EventHandler(this.txttien_EditValueChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtNguoiNhan);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txtNguoiNhan
            // 
            resources.ApplyResources(this.txtNguoiNhan, "txtNguoiNhan");
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtNguoiNhan.Properties.Appearance.Font")));
            this.txtNguoiNhan.Properties.Appearance.Options.UseFont = true;
            this.txtNguoiNhan.EditValueChanged += new System.EventHandler(this.txtNguoiNhan_EditValueChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.cbQuan);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // cbQuan
            // 
            resources.ApplyResources(this.cbQuan, "cbQuan");
            this.cbQuan.FormattingEnabled = true;
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.SelectedIndexChanged += new System.EventHandler(this.cbQuan_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtSdt);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txtSdt
            // 
            resources.ApplyResources(this.txtSdt, "txtSdt");
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtSdt.Properties.Appearance.Font")));
            this.txtSdt.Properties.Appearance.Options.UseFont = true;
            this.txtSdt.EditValueChanged += new System.EventHandler(this.txtSdt_EditValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtDiaChi);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtDiaChi
            // 
            resources.ApplyResources(this.txtDiaChi, "txtDiaChi");
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtDiaChi.Properties.Appearance.Font")));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.EditValueChanged += new System.EventHandler(this.txtDiaChi_EditValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenDaiLy);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtTenDaiLy
            // 
            resources.ApplyResources(this.txtTenDaiLy, "txtTenDaiLy");
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTenDaiLy.Properties.Appearance.Font")));
            this.txtTenDaiLy.Properties.Appearance.Options.UseFont = true;
            this.txtTenDaiLy.EditValueChanged += new System.EventHandler(this.txtTenDaiLy_EditValueChanged);
            // 
            // dtNgayNhan
            // 
            resources.ApplyResources(this.dtNgayNhan, "dtNgayNhan");
            this.dtNgayNhan.Name = "dtNgayNhan";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // QuanLyDaiLy
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDaiLy";
            resources.ApplyResources(this, "$this");
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDaiLy)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtsearch.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienNo.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiNhan.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDaiLy.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTienNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbLoaiDL;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbQuan;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.TextEdit txtNguoiNhan;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.TextEdit txtSdt;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtTenDaiLy;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraEditors.TextEdit txtsearch;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DataGridView gvDaiLy;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
