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
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraUserControl
    {
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        public DoiMatKhau(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
        }
        private void btnCapNhatPass_Click(object sender, EventArgs e)
        {
            string passCu = txtPassCu.Text;
            string passMoi = txtPassMoi.Text;
            string passMoiNhapLai = txtPassNhapLai.Text;
            if(passCu.Equals("")==false && passMoi.Equals("")==false && passMoiNhapLai.Equals("") == false)
            {
                if (passMoi.Equals(passMoiNhapLai)==true)
                {
                    int kq = BUS_QuanLyTaiKhoan.CapNhatMatKhau(taiKhoan.UserName, passCu, passMoi);
                    if (kq == 1)
                    {
                        //thanfh cong
                        MessageBox.Show("Thay đổi thành công");
                    }else
                    {
                        //khongthanhcong
                        MessageBox.Show("Thay đổi thất bại");
                    }
                }
                else
                {
                    //passCU vaf pass cu nhap lai ko trung
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThi.Checked == true)
            {
               
            }
        }
    }
}
