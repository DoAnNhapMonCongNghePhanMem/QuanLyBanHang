using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class FormChuongTrinhQLDL : Form
    {
        public FormChuongTrinhQLDL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormToChuc f = new FormToChuc();
            f.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FormLuuTru f = new FormLuuTru();
            f.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FormKetXuat f = new FormKetXuat();
            f.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            FormTroGiup f = new FormTroGiup();
            f.Show();
        }

        private void FormChuongTrinhQLDL_Load(object sender, EventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
