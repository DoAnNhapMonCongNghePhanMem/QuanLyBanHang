namespace QuanLyDaiLy
{
    partial class QDTienNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QDTienNo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLoaiDL = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoTienNo = new DevExpress.XtraEditors.TextEdit();
            this.gvQuyDinh = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 546);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.cbLoaiDL);
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.txtSoTienNo);
            this.panel3.Controls.Add(this.gvQuyDinh);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 540);
            this.panel3.TabIndex = 1;
            // 
            // cbLoaiDL
            // 
            this.cbLoaiDL.Font = new System.Drawing.Font("Tahoma", 15F);
            this.cbLoaiDL.FormattingEnabled = true;
            this.cbLoaiDL.Location = new System.Drawing.Point(375, 14);
            this.cbLoaiDL.Name = "cbLoaiDL";
            this.cbLoaiDL.Size = new System.Drawing.Size(158, 32);
            this.cbLoaiDL.TabIndex = 9;
            this.cbLoaiDL.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDL_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(271, 396);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(139, 63);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoTienNo.Location = new System.Drawing.Point(375, 94);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSoTienNo.Properties.Appearance.Options.UseFont = true;
            this.txtSoTienNo.Size = new System.Drawing.Size(158, 30);
            this.txtSoTienNo.TabIndex = 5;
            // 
            // gvQuyDinh
            // 
            this.gvQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvQuyDinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvQuyDinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQuyDinh.Location = new System.Drawing.Point(155, 176);
            this.gvQuyDinh.Name = "gvQuyDinh";
            this.gvQuyDinh.Size = new System.Drawing.Size(414, 180);
            this.gvQuyDinh.TabIndex = 4;
            this.gvQuyDinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQuyDinh_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(151, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền nợ tối đa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(151, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại đại lý";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QDTienNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QDTienNo";
            this.Size = new System.Drawing.Size(755, 552);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuyDinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLoaiDL;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.TextEdit txtSoTienNo;
        private System.Windows.Forms.DataGridView gvQuyDinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
