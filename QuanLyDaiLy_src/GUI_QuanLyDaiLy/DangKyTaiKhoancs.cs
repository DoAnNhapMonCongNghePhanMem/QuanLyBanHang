using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class DangKyTaiKhoancs : DevExpress.XtraEditors.XtraUserControl
    {
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public DangKyTaiKhoancs()
        {
            InitializeComponent();
        }
        public DangKyTaiKhoancs( DTO_ThongTinTaiKhoan tk, DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string passAgain = txtPassAgain.Text;
            if (pass.Equals(passAgain))
            {
                string ten = txtHoten.Text;
                string cmnd = txtCmnd.Text;
                string ngaySinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");
                string queQuan = txtQue.Text;
                string sdt = txtSdt.Text;
                int quyen = int.Parse(txtQuyen.Text);
                int trangThai = 0;
                int kq = BUS_QuanLyTaiKhoan.DangKi(cmnd, ten, ngaySinh, queQuan, sdt, user, pass, quyen, trangThai);
                if (kq == 0)
                {
                    //0 dangki thanh cong
                    MessageBox.Show("Tài khoản đã được tạo");
                }
                else if (kq == 1)
                {
                    MessageBox.Show("User đã tồn tại");
                    // 1 trung user,
                }
                else if (kq == 2)
                {
                    MessageBox.Show("Nhân viên này đã có tài khoản");
                    //2 nhan vien da co tai khoan,
                }
                else
                {
                    MessageBox.Show("Lỗi");
                    //,3 loi
                }
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
           txtPass.Text="";
           txtPassAgain.Text="";
           txtHoten.Text = "";
           txtCmnd.Text = "";
           dtNgaySinh.Value=DateTime.Now;
           txtQue.Text = "";
           txtSdt.Text = "";
            txtQuyen.Text = "";
       }
    }
}
