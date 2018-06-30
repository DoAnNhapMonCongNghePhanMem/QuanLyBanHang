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
using DTO_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class TrangChuQuanLy : DevExpress.XtraEditors.XtraForm
    {
        DTO_ThongTinTaiKhoan taiKhoan;
        DTO_NhanVienQuanLy nhanVien;
        public TrangChuQuanLy()
        {
            InitializeComponent();
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.FormBorderStyle = FormBorderStyle.Sizable;


            this.WindowState = FormWindowState.Maximized;
        }
        public TrangChuQuanLy(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            
            taiKhoan = tk;
            nhanVien = nv;
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Hu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void G_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
            tbTrangChu.Hide();
            QuanLyDaiLy hs = new QuanLyDaiLy(taiKhoan,nhanVien);
            this.pnlTrangChu.Controls.Add(hs);
            hs.Show();


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoCaoDS_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            BaoCaoDoanhSo ds = new BaoCaoDoanhSo();
            pnlTrangChu.Controls.Add(ds);
            ds.Show();
        }

        private void btnBaoCaoCN_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            BaoCaoCongNo ds = new BaoCaoCongNo();
            pnlTrangChu.Controls.Add(ds);
            ds.Show();
        }

        private void btnQuyChe_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            QuyChe ds = new QuyChe();
            pnlTrangChu.Controls.Add(ds);
            ds.Show();
        }
    }
}