namespace QuanLyDaiLy
{
    partial class FormKetXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKetXuat));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMatHang = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBaoCaoDoanhSo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.page_BaoCaoDoanhSo1 = new QuanLyDaiLy.page_BaoCaoDoanhSo();
            this.page_BaoCaoCongNo1 = new QuanLyDaiLy.page_BaoCaoCongNo();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnMatHang);
            this.panel2.Controls.Add(this.btnBaoCaoDoanhSo);
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 496);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnMatHang
            // 
            this.btnMatHang.ActiveBorderThickness = 1;
            this.btnMatHang.ActiveCornerRadius = 10;
            this.btnMatHang.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(147)))), ((int)(((byte)(3)))));
            this.btnMatHang.ActiveForecolor = System.Drawing.Color.White;
            this.btnMatHang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(147)))), ((int)(((byte)(3)))));
            this.btnMatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.btnMatHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMatHang.BackgroundImage")));
            this.btnMatHang.ButtonText = "Báo Cáo Công Nợ";
            this.btnMatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatHang.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMatHang.IdleBorderThickness = 1;
            this.btnMatHang.IdleCornerRadius = 10;
            this.btnMatHang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.btnMatHang.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMatHang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.btnMatHang.Location = new System.Drawing.Point(0, 144);
            this.btnMatHang.Margin = new System.Windows.Forms.Padding(5);
            this.btnMatHang.Name = "btnMatHang";
            this.btnMatHang.Size = new System.Drawing.Size(197, 90);
            this.btnMatHang.TabIndex = 4;
            this.btnMatHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMatHang.Click += new System.EventHandler(this.btnMatHang_Click);
            // 
            // btnBaoCaoDoanhSo
            // 
            this.btnBaoCaoDoanhSo.ActiveBorderThickness = 1;
            this.btnBaoCaoDoanhSo.ActiveCornerRadius = 10;
            this.btnBaoCaoDoanhSo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(147)))), ((int)(((byte)(3)))));
            this.btnBaoCaoDoanhSo.ActiveForecolor = System.Drawing.Color.White;
            this.btnBaoCaoDoanhSo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(147)))), ((int)(((byte)(3)))));
            this.btnBaoCaoDoanhSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.btnBaoCaoDoanhSo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDoanhSo.BackgroundImage")));
            this.btnBaoCaoDoanhSo.ButtonText = "Báo Cáo Doanh Số";
            this.btnBaoCaoDoanhSo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCaoDoanhSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoDoanhSo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBaoCaoDoanhSo.IdleBorderThickness = 1;
            this.btnBaoCaoDoanhSo.IdleCornerRadius = 10;
            this.btnBaoCaoDoanhSo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.btnBaoCaoDoanhSo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBaoCaoDoanhSo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.btnBaoCaoDoanhSo.Location = new System.Drawing.Point(0, 58);
            this.btnBaoCaoDoanhSo.Margin = new System.Windows.Forms.Padding(5);
            this.btnBaoCaoDoanhSo.Name = "btnBaoCaoDoanhSo";
            this.btnBaoCaoDoanhSo.Size = new System.Drawing.Size(197, 90);
            this.btnBaoCaoDoanhSo.TabIndex = 3;
            this.btnBaoCaoDoanhSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(852, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(884, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // page_BaoCaoDoanhSo1
            // 
            this.page_BaoCaoDoanhSo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.page_BaoCaoDoanhSo1.Location = new System.Drawing.Point(204, 31);
            this.page_BaoCaoDoanhSo1.Name = "page_BaoCaoDoanhSo1";
            this.page_BaoCaoDoanhSo1.Size = new System.Drawing.Size(719, 496);
            this.page_BaoCaoDoanhSo1.TabIndex = 9;
            // 
            // page_BaoCaoCongNo1
            // 
            this.page_BaoCaoCongNo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.page_BaoCaoCongNo1.Location = new System.Drawing.Point(204, 31);
            this.page_BaoCaoCongNo1.Name = "page_BaoCaoCongNo1";
            this.page_BaoCaoCongNo1.Size = new System.Drawing.Size(719, 496);
            this.page_BaoCaoCongNo1.TabIndex = 10;
            // 
            // FormKetXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(922, 526);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.page_BaoCaoDoanhSo1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.page_BaoCaoCongNo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKetXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKetXuat";
            this.Load += new System.EventHandler(this.FormKetXuat_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMatHang;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBaoCaoDoanhSo;
        private page_BaoCaoDoanhSo page_BaoCaoDoanhSo1;
        private page_BaoCaoCongNo page_BaoCaoCongNo1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}