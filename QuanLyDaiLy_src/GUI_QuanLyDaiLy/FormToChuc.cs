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
    public partial class FormToChuc : Form
    {
        public FormToChuc()
        {
            InitializeComponent();
        }

        private void page_HoSo1_Load(object sender, EventArgs e)
        {

        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            page_HoSo1.BringToFront();
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            page_MatHang1.BringToFront();
        }

        private void btnQuyChe_Click(object sender, EventArgs e)
        {
            page_QuyChe1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool mouseDown;
        private Point lastLocation;

        private void FormToChuc_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormTochuc_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FormToChuc_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void page_HoSo1_Load_1(object sender, EventArgs e)
        {

        }

        private void FormToChuc_Load(object sender, EventArgs e)
        {

        }
    }
}
