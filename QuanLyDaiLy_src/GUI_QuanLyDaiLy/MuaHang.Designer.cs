namespace QuanLyDaiLy
{
    partial class MuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuaHang));
            this.pnlMatHang = new System.Windows.Forms.Panel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbGiaoDich = new DevExpress.XtraEditors.LabelControl();
            this.pnlGiaoDich = new DevExpress.XtraEditors.PanelControl();
            this.cbMatHang = new System.Windows.Forms.ComboBox();
            this.btnXuatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gvHang = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pnlMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGiaoDich)).BeginInit();
            this.pnlGiaoDich.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMatHang
            // 
            this.pnlMatHang.Controls.Add(this.panelControl2);
            this.pnlMatHang.Controls.Add(this.pnlGiaoDich);
            this.pnlMatHang.Location = new System.Drawing.Point(0, 0);
            this.pnlMatHang.Name = "pnlMatHang";
            this.pnlMatHang.Size = new System.Drawing.Size(751, 576);
            this.pnlMatHang.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbGiaoDich);
            this.panelControl2.Location = new System.Drawing.Point(4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(744, 66);
            this.panelControl2.TabIndex = 10;
            // 
            // lbGiaoDich
            // 
            this.lbGiaoDich.Appearance.Font = new System.Drawing.Font("Tahoma", 25F);
            this.lbGiaoDich.Appearance.Options.UseFont = true;
            this.lbGiaoDich.Location = new System.Drawing.Point(239, 5);
            this.lbGiaoDich.Name = "lbGiaoDich";
            this.lbGiaoDich.Size = new System.Drawing.Size(231, 41);
            this.lbGiaoDich.TabIndex = 0;
            this.lbGiaoDich.Text = "Chọn mặt hàng";
            // 
            // pnlGiaoDich
            // 
            this.pnlGiaoDich.Controls.Add(this.cbMatHang);
            this.pnlGiaoDich.Controls.Add(this.btnXuatHang);
            this.pnlGiaoDich.Controls.Add(this.btnThem);
            this.pnlGiaoDich.Controls.Add(this.gvHang);
            this.pnlGiaoDich.Controls.Add(this.txtThanhTien);
            this.pnlGiaoDich.Controls.Add(this.labelControl6);
            this.pnlGiaoDich.Controls.Add(this.labelControl2);
            this.pnlGiaoDich.Controls.Add(this.txtDonGia);
            this.pnlGiaoDich.Controls.Add(this.labelControl1);
            this.pnlGiaoDich.Controls.Add(this.labelControl4);
            this.pnlGiaoDich.Controls.Add(this.txtDonViTinh);
            this.pnlGiaoDich.Controls.Add(this.nbSoLuong);
            this.pnlGiaoDich.Controls.Add(this.labelControl3);
            this.pnlGiaoDich.Location = new System.Drawing.Point(4, 76);
            this.pnlGiaoDich.Name = "pnlGiaoDich";
            this.pnlGiaoDich.Size = new System.Drawing.Size(747, 500);
            this.pnlGiaoDich.TabIndex = 9;
            // 
            // cbMatHang
            // 
            this.cbMatHang.FormattingEnabled = true;
            this.cbMatHang.Location = new System.Drawing.Point(314, 20);
            this.cbMatHang.Name = "cbMatHang";
            this.cbMatHang.Size = new System.Drawing.Size(207, 21);
            this.cbMatHang.TabIndex = 14;
            this.cbMatHang.SelectedIndexChanged += new System.EventHandler(this.cbMatHang_SelectedIndexChanged);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatHang.ImageOptions.Image")));
            this.btnXuatHang.Location = new System.Drawing.Point(586, 332);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(156, 50);
            this.btnXuatHang.TabIndex = 13;
            this.btnXuatHang.Text = "Lập phiếu xuất hàng";
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(379, 231);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 37);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gvHang
            // 
            this.gvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHang.Location = new System.Drawing.Point(125, 289);
            this.gvHang.Name = "gvHang";
            this.gvHang.Size = new System.Drawing.Size(396, 150);
            this.gvHang.TabIndex = 11;
            this.gvHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(314, 187);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(207, 21);
            this.txtThanhTien.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(119, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Thành tiền";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(128, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(314, 147);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(207, 21);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(125, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mặt hàng";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(118, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(314, 106);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(207, 21);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Location = new System.Drawing.Point(314, 60);
            this.nbSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(72, 21);
            this.nbSoLuong.TabIndex = 6;
            this.nbSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSoLuong.ValueChanged += new System.EventHandler(this.nbSoLuong_ValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(122, 155);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Đơn giá";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMatHang);
            this.Name = "MuaHang";
            this.Size = new System.Drawing.Size(754, 579);
            this.pnlMatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGiaoDich)).EndInit();
            this.pnlGiaoDich.ResumeLayout(false);
            this.pnlGiaoDich.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMatHang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl pnlGiaoDich;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbGiaoDich;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnXuatHang;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DataGridView gvHang;
        private System.Windows.Forms.ComboBox cbMatHang;
    }
}
