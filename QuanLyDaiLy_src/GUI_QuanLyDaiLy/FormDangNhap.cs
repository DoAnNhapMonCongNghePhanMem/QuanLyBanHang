using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QuanLyDaiLy;

namespace QuanLyDaiLy
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;

        private void FormDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void FormDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            int login = DAL_QuanLyTaiKhoan.KiemTraDangNhap(user, pass);
            if (login == 0)
            {
                FormChuongTrinhQLDL f = new FormChuongTrinhQLDL();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (login == 1)
            {
                MessageBox.Show("user khong chinh xac");
            }
            else if(login == 2)
            {
                MessageBox.Show("pass khonh chinh xac");
            }
            else
            {
                MessageBox.Show("ban bi kich boi admin");
            }

        }
    }
}
