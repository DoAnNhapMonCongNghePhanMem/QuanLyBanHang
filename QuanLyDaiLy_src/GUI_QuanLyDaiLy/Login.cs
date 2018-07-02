using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        DTO_NhanVienQuanLy nhanVien;
        DTO_ThongTinTaiKhoan taiKhoan;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string user = txtuserName.Text.ToString();
            string pass = txtPassWord.Text.ToString();
            Console.WriteLine(user + " " + pass);
            int login = BUS_QuanLyTaiKhoan.KiemTraLogin(user, pass);
            if (login == 0)
            {
                taiKhoan = BUS_QuanLyTaiKhoan.GetTaiKhoan(user,pass);
                nhanVien = BUS_NhanVien.GetNhanVien(taiKhoan.Cmnd);
                this.Hide();
                TrangChuQuanLy f = new TrangChuQuanLy(taiKhoan,nhanVien);
                f.Show();
                
            }
            else if (login == 1)
            {
                MessageBox.Show("Tên user không chính xác");
            }
            else if (login == 2)
            {
                MessageBox.Show("Mật khẩu không chính xác");
            }
            else
            {
                MessageBox.Show("Tài khoản đã bị block bởi admin");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}