namespace QuanLyDaiLy
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(90, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 505);
            this.panel1.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpass.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtpass.HintText = "Mật khẩu";
            this.txtpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtpass.isPassword = true;
            this.txtpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.txtpass.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.txtpass.LineThickness = 3;
            this.txtpass.Location = new System.Drawing.Point(2, 235);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(261, 37);
            this.txtpass.TabIndex = 3;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // txtuser
            // 
            this.txtuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtuser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtuser.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtuser.HintText = "Tên người dùng";
            this.txtuser.isPassword = false;
            this.txtuser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.txtuser.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txtuser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.txtuser.LineThickness = 3;
            this.txtuser.Location = new System.Drawing.Point(0, 156);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.MaxLength = 32767;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(261, 37);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ActiveBorderThickness = 1;
            this.btnDangNhap.ActiveCornerRadius = 20;
            this.btnDangNhap.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(147)))), ((int)(((byte)(3)))));
            this.btnDangNhap.ActiveForecolor = System.Drawing.Color.White;
            this.btnDangNhap.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(147)))), ((int)(((byte)(3)))));
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
            this.btnDangNhap.ButtonText = "Đăng Nhập";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDangNhap.IdleBorderThickness = 1;
            this.btnDangNhap.IdleCornerRadius = 20;
            this.btnDangNhap.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.btnDangNhap.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDangNhap.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(19)))));
            this.btnDangNhap.Location = new System.Drawing.Point(1, 329);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(261, 60);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(45, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(405, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(373, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(443, 549);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDangNhap_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDangNhap_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDangNhap_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangNhap;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtuser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

