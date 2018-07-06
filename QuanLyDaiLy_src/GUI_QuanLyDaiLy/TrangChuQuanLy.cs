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
            btnBack.Visible = false;
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
            btnBack.Visible = false;
            rbTrangChu.AutoHideEmptyItems = true;

            taiKhoan = tk;
            nhanVien = nv;
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTrangChu.Hide();
            PhieuThu hs = new PhieuThu(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Phiếu thu tiền";
            hs.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTrangChu.Hide();
            BaoCaoCongNo ds = new BaoCaoCongNo();
            ds.Width = pnlTrangChu.Width;
            ds.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(ds);
            lbTieuDe.Text = "Báo cáo công nợ";
            btnBack.Visible = true;
            //ds.Show();
        }

        private void Hu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void G_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTrangChu.Hide();
            QuyChe ds = new QuyChe();
            ds.Width = pnlTrangChu.Width;
            ds.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(ds);
            lbTieuDe.Text = "Quy chế tổ chức";
            btnBack.Visible = true;
            ds.Show();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
            //tbTrangChu.Hide();
            QuanLyDaiLy hs = new QuanLyDaiLy(taiKhoan,nhanVien);
            //hs.Anchor = AnchorStyles.Bottom;
            //hs.Anchor = AnchorStyles.Left;
            //hs.Anchor = AnchorStyles.Right;
            //hs.Anchor = AnchorStyles.Top;
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
        

            pnlTrangChu.Controls.RemoveAt(0);
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Quản lý đại lý";
            //hs.Show();
            //pnlTrangChu.Padding = new Padding(50, 0, 50, 0);
            


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            QuanLyMatHang hs = new QuanLyMatHang(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Quản lý mặt hàng";
            hs.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoCaoDS_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            BaoCaoDoanhSo ds = new BaoCaoDoanhSo();
            ds.Width = pnlTrangChu.Width;
            ds.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(ds);
            lbTieuDe.Text = "Báo cáo doanh số";
            btnBack.Visible = true;
            ds.Show();
        }

        private void btnBaoCaoCN_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            BaoCaoCongNo ds = new BaoCaoCongNo();
            ds.Width = pnlTrangChu.Width;
            ds.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(ds);
            lbTieuDe.Text = "Báo cáo công nợ";
            btnBack.Visible = true;
            //ds.Show();
        }

        private void btnQuyChe_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            QuyChe ds = new QuyChe();
            ds.Width = pnlTrangChu.Width;
            ds.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(ds);
            lbTieuDe.Text = "Quy chế tổ chức";
            btnBack.Visible = true;
            ds.Show();
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            //pnlTieuDe.Hide();
            MuaHang hs = new MuaHang(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            lbTieuDe.Text = "Giao dịch";
            btnBack.Visible = true; ;
            hs.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlTieuDe.Show();
            
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(tbTrangChu);
            btnBack.Visible = false;
            tbTrangChu.Show();
            lbTieuDe.Text = "Trang chủ";
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            tbTrangChu.Hide();
            PhieuThu hs = new PhieuThu(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Phiếu thu tiền";
            hs.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //tbTrangChu.Hide();
            Admin hs = new Admin(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "ADMIN";
            hs.Show();
            //if (taiKhoan.PhanQuyen == 0)
            //{

            //}else
            //{
            //    //Chỉ admin mới truy cập được
            //}
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MoRongDaiLy hs = new MoRongDaiLy(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Mở rộng đại lý";
            hs.Show();
        }

        private void tbTrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //tbTrangChu.Hide();
            QuanLyDaiLy hs = new QuanLyDaiLy(taiKhoan, nhanVien);
            //hs.Anchor = AnchorStyles.Bottom;
            //hs.Anchor = AnchorStyles.Left;
            //hs.Anchor = AnchorStyles.Right;
            //hs.Anchor = AnchorStyles.Top;
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;


            pnlTrangChu.Controls.RemoveAt(0);
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Quản lý đại lý";
            //hs.Show();
            //pnlTrangChu.Padding = new Padding(50, 0, 50, 0);

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTrangChu.Hide();
            QuanLyMatHang hs = new QuanLyMatHang(taiKhoan, nhanVien);
            hs.Width = pnlTrangChu.Width;
            hs.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(hs);
            btnBack.Visible = true;
            lbTieuDe.Text = "Quản lý mặt hàng";
            hs.Show();
        }

        private void Bao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbTrangChu.Hide();
            BaoCaoDoanhSo ds = new BaoCaoDoanhSo();
            ds.Width = pnlTrangChu.Width;
            ds.Height = pnlTrangChu.Height;
            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(ds);
            lbTieuDe.Text = "Báo cáo doanh số";
            btnBack.Visible = true;
            ds.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlTieuDe.Show();

            pnlTrangChu.Controls.Clear();
            pnlTrangChu.Controls.Add(tbTrangChu);
            btnBack.Visible = false;
            tbTrangChu.Show();
            lbTieuDe.Text = "Trang chủ";
        }
    }
}