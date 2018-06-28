namespace QuanLyDaiLy
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbcUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtuserName = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lbcPassWord = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtuserName.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(21, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 141);
            this.panel1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(168, 91);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show PassWord";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(225, 115);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(72, 26);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Exit";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(128, 113);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(73, 26);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbcUserName);
            this.panel2.Controls.Add(this.txtuserName);
            this.panel2.Location = new System.Drawing.Point(5, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 41);
            this.panel2.TabIndex = 0;
            // 
            // lbcUserName
            // 
            this.lbcUserName.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcUserName.Appearance.Options.UseFont = true;
            this.lbcUserName.Location = new System.Drawing.Point(12, 5);
            this.lbcUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbcUserName.Name = "lbcUserName";
            this.lbcUserName.Size = new System.Drawing.Size(102, 22);
            this.lbcUserName.TabIndex = 1;
            this.lbcUserName.Text = "UserName:";
            // 
            // txtuserName
            // 
            this.txtuserName.EditValue = "admin";
            this.txtuserName.Location = new System.Drawing.Point(125, 11);
            this.txtuserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(180, 20);
            this.txtuserName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPassWord);
            this.panel3.Controls.Add(this.lbcPassWord);
            this.panel3.Location = new System.Drawing.Point(5, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 38);
            this.panel3.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(125, 9);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(181, 21);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // lbcPassWord
            // 
            this.lbcPassWord.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcPassWord.Appearance.Options.UseFont = true;
            this.lbcPassWord.Location = new System.Drawing.Point(21, 8);
            this.lbcPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbcPassWord.Name = "lbcPassWord";
            this.lbcPassWord.Size = new System.Drawing.Size(100, 22);
            this.lbcPassWord.TabIndex = 1;
            this.lbcPassWord.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 168);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtuserName.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lbcUserName;
        private DevExpress.XtraEditors.TextEdit txtuserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassWord;
        private DevExpress.XtraEditors.LabelControl lbcPassWord;
    }
}