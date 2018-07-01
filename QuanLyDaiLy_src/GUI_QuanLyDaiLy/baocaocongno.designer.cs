namespace QuanLyDaiLy
{
	partial class BaoCaoCongNo
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvCN = new System.Windows.Forms.DataGridView();
            this.cbCN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 481);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvCN);
            this.panel3.Controls.Add(this.cbCN);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 475);
            this.panel3.TabIndex = 1;
            // 
            // gvCN
            // 
            this.gvCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCN.Location = new System.Drawing.Point(55, 111);
            this.gvCN.Name = "gvCN";
            this.gvCN.Size = new System.Drawing.Size(708, 260);
            this.gvCN.TabIndex = 2;
            // 
            // cbCN
            // 
            this.cbCN.FormattingEnabled = true;
            this.cbCN.Location = new System.Drawing.Point(127, 16);
            this.cbCN.Name = "cbCN";
            this.cbCN.Size = new System.Drawing.Size(121, 21);
            this.cbCN.TabIndex = 1;
            this.cbCN.SelectedIndexChanged += new System.EventHandler(this.cbCN_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // BaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoCongNo";
            this.Size = new System.Drawing.Size(769, 481);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCN)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gvCN;
        private System.Windows.Forms.ComboBox cbCN;
        private System.Windows.Forms.Label label2;
    }
}
