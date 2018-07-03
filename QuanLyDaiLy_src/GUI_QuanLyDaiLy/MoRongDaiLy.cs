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
    public partial class MoRongDaiLy : DevExpress.XtraEditors.XtraUserControl
    {
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public MoRongDaiLy()
        {
            InitializeComponent();
            ThemLoaiDaiLy q = new ThemLoaiDaiLy(taiKhoan, nhanVien);
            pnlMoRong.Controls.Clear();
            pnlMoRong.Controls.Add(q);
            q.Show();
        }
        public MoRongDaiLy(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
            ThemLoaiDaiLy q = new ThemLoaiDaiLy(taiKhoan, nhanVien);
            pnlMoRong.Controls.Clear();
            pnlMoRong.Controls.Add(q);
            q.Show();
        }

        private void btnThemQuan_Click(object sender, EventArgs e)
        {
            ThemQuan q = new ThemQuan(taiKhoan, nhanVien);
            pnlMoRong.Controls.Clear();
            pnlMoRong.Controls.Add(q);
            q.Show();
        }

        private void btnThemLoaiDL_Click(object sender, EventArgs e)
        {
            ThemLoaiDaiLy q = new ThemLoaiDaiLy(taiKhoan, nhanVien);
            pnlMoRong.Controls.Clear();
            pnlMoRong.Controls.Add(q);
            q.Show();
        }
    }
}
