namespace QuanLyDaiLy
{
    partial class PhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTienCon = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTienTra = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.gvhang = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDaiLy = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhang)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gvhang);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 542);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.txtTienCon);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtSoTienTra);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(342, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 206);
            this.panel3.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Location = new System.Drawing.Point(154, 16);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Size = new System.Drawing.Size(220, 30);
            this.txtTongTien.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(209, 133);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 55);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Xuất";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTienCon
            // 
            this.txtTienCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienCon.Location = new System.Drawing.Point(154, 97);
            this.txtTienCon.Name = "txtTienCon";
            this.txtTienCon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTienCon.Properties.Appearance.Options.UseFont = true;
            this.txtTienCon.Size = new System.Drawing.Size(220, 30);
            this.txtTienCon.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số tiền trả";
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienTra.Location = new System.Drawing.Point(154, 59);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSoTienTra.Properties.Appearance.Options.UseFont = true;
            this.txtSoTienTra.Size = new System.Drawing.Size(220, 30);
            this.txtSoTienTra.TabIndex = 27;
            this.txtSoTienTra.EditValueChanged += new System.EventHandler(this.txtSoTienTra_EditValueChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Còn lại";
            // 
            // gvhang
            // 
            this.gvhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvhang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvhang.Location = new System.Drawing.Point(0, 78);
            this.gvhang.Name = "gvhang";
            this.gvhang.Size = new System.Drawing.Size(810, 249);
            this.gvhang.TabIndex = 22;
            this.gvhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvhang_CellContentClick_1);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.dtNgayLap);
            this.panel9.Location = new System.Drawing.Point(428, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(382, 40);
            this.panel9.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày lập phiếu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtNgayLap.Location = new System.Drawing.Point(189, 6);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(187, 22);
            this.dtNgayLap.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDaiLy);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 40);
            this.panel2.TabIndex = 20;
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbDaiLy.FormattingEnabled = true;
            this.cbDaiLy.Location = new System.Drawing.Point(104, 5);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Size = new System.Drawing.Size(232, 32);
            this.cbDaiLy.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.MaximumSize = new System.Drawing.Size(86, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 24);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Đại lý  ";
            // 
            // PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "PhieuXuat";
            this.Size = new System.Drawing.Size(816, 548);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhang)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvhang;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDaiLy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTienCon;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtSoTienTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
