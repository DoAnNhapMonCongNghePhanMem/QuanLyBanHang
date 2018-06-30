namespace QuanLyDaiLy
{
    partial class QuyChe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pnlQuyChe = new DevExpress.XtraEditors.PanelControl();
            this.btnQDTienNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnQDMatHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnToChuc = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlQuyChe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlQuyChe);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 522);
            this.panel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnToChuc);
            this.panelControl1.Controls.Add(this.btnQDMatHang);
            this.panelControl1.Controls.Add(this.btnQDTienNo);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(201, 522);
            this.panelControl1.TabIndex = 0;
            // 
            // pnlQuyChe
            // 
            this.pnlQuyChe.Location = new System.Drawing.Point(207, 0);
            this.pnlQuyChe.Name = "pnlQuyChe";
            this.pnlQuyChe.Size = new System.Drawing.Size(601, 519);
            this.pnlQuyChe.TabIndex = 1;
            // 
            // btnQDTienNo
            // 
            this.btnQDTienNo.Location = new System.Drawing.Point(5, 28);
            this.btnQDTienNo.Name = "btnQDTienNo";
            this.btnQDTienNo.Size = new System.Drawing.Size(196, 138);
            this.btnQDTienNo.TabIndex = 0;
            this.btnQDTienNo.Text = "Quy định tiền nợ";
            this.btnQDTienNo.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnQDMatHang
            // 
            this.btnQDMatHang.Location = new System.Drawing.Point(4, 185);
            this.btnQDMatHang.Name = "btnQDMatHang";
            this.btnQDMatHang.Size = new System.Drawing.Size(196, 143);
            this.btnQDMatHang.TabIndex = 1;
            this.btnQDMatHang.Text = "Quy định mặt hàng";
            this.btnQDMatHang.Click += new System.EventHandler(this.btnQDMatHang_Click);
            // 
            // btnToChuc
            // 
            this.btnToChuc.Location = new System.Drawing.Point(3, 350);
            this.btnToChuc.Name = "btnToChuc";
            this.btnToChuc.Size = new System.Drawing.Size(197, 144);
            this.btnToChuc.TabIndex = 2;
            this.btnToChuc.Text = "Quy chế tổ chức";
            this.btnToChuc.Click += new System.EventHandler(this.btnToChuc_Click);
            // 
            // QuyChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "QuyChe";
            this.Size = new System.Drawing.Size(814, 525);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlQuyChe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pnlQuyChe;
        private DevExpress.XtraEditors.SimpleButton btnToChuc;
        private DevExpress.XtraEditors.SimpleButton btnQDMatHang;
        private DevExpress.XtraEditors.SimpleButton btnQDTienNo;
    }
}
