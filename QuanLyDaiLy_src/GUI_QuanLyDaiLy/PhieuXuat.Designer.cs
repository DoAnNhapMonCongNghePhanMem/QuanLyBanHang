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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.txtTienCon = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienTra = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gvhang = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDaiLy = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienCon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhang)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTongTien);
            this.panelControl1.Controls.Add(this.txtTienCon);
            this.panelControl1.Controls.Add(this.txtSoTienTra);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.gvhang);
            this.panelControl1.Controls.Add(this.panel9);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 546);
            this.panelControl1.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(634, 368);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 20);
            this.txtTongTien.TabIndex = 19;
            // 
            // txtTienCon
            // 
            this.txtTienCon.Location = new System.Drawing.Point(634, 458);
            this.txtTienCon.Name = "txtTienCon";
            this.txtTienCon.Size = new System.Drawing.Size(150, 20);
            this.txtTienCon.TabIndex = 18;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(634, 411);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Size = new System.Drawing.Size(150, 20);
            this.txtSoTienTra.TabIndex = 17;
            this.txtSoTienTra.EditValueChanged += new System.EventHandler(this.txtSoTienTra_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(502, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Còn lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(502, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số tiền trả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(510, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(656, 495);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 43);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Xuất";
            this.btnThem.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // gvhang
            // 
            this.gvhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvhang.Location = new System.Drawing.Point(5, 68);
            this.gvhang.Name = "gvhang";
            this.gvhang.Size = new System.Drawing.Size(798, 224);
            this.gvhang.TabIndex = 8;
            this.gvhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvhang_CellContentClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtNgayLap);
            this.panel9.Controls.Add(this.labelControl8);
            this.panel9.Location = new System.Drawing.Point(442, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(361, 40);
            this.panel9.TabIndex = 7;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtNgayLap.Location = new System.Drawing.Point(155, 10);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(187, 22);
            this.dtNgayLap.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(9, 10);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.MaximumSize = new System.Drawing.Size(129, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(122, 19);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Ngày lập phiếu  :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDaiLy);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 40);
            this.panel2.TabIndex = 4;
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.FormattingEnabled = true;
            this.cbDaiLy.Location = new System.Drawing.Point(87, 10);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Size = new System.Drawing.Size(232, 21);
            this.cbDaiLy.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.MaximumSize = new System.Drawing.Size(86, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Đại lý  :";
            // 
            // PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "PhieuXuat";
            this.Size = new System.Drawing.Size(817, 549);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
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

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDaiLy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DataGridView gvhang;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.TextEdit txtTienCon;
        private DevExpress.XtraEditors.TextEdit txtSoTienTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
