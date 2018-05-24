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
    public partial class FormTroGiup : Form
    {
        public FormTroGiup()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            page_GioiThieu1.BringToFront();
        }

        private void btnHuongDanSuDung_Click(object sender, EventArgs e)
        {
            page_HuongDanSuDung1.BringToFront();
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            page_DoiMatKhau1.BringToFront();
        }

        private void FormTroGiup_Load(object sender, EventArgs e)
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
