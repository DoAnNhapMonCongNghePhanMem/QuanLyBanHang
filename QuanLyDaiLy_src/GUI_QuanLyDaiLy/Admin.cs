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
using DTO_QuanLyDaiLy;

namespace QuanLyDaiLy
{
    public partial class Admin : DevExpress.XtraEditors.XtraUserControl
    {
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(DTO_ThongTinTaiKhoan tk, DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
            DoiMatKhau mk = new DoiMatKhau(taiKhoan, nhanVien);
            pnlAmin.Controls.Clear();
            pnlAmin.Controls.Add(mk);
            mk.Show();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoancs mk = new DangKyTaiKhoancs(taiKhoan,nhanVien);
            pnlAmin.Controls.Clear();
            pnlAmin.Controls.Add(mk);
            mk.Show();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            DoiMatKhau mk = new DoiMatKhau(taiKhoan, nhanVien);
            pnlAmin.Controls.Clear();
            pnlAmin.Controls.Add(mk);
            mk.Show();
        }
    }
}
