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
using System.Collections;

namespace QuanLyDaiLy
{
    public partial class MuaHang : DevExpress.XtraEditors.XtraUserControl
    {
        private ArrayList qdMatHang;
        private DataTable tb;
        private int[] dsId;
        private int idMatHang=-1;
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public MuaHang()
        {
            InitializeComponent();
            Load();
        }
        public MuaHang(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
            Load();
        }

        private void Load()
        {
      
            txtDonGia.Modified = false;
            txtDonViTinh.Modified = false;
            txtThanhTien.Modified = false;

            tb = new DataTable();
            tb.Columns.Add("Id", typeof(int));
            tb.Columns.Add("Mặt hàng", typeof(string));
            tb.Columns.Add("Số lượng", typeof(string));
            tb.Columns.Add("đơn vị tính", typeof(string));
            tb.Columns.Add("Đơn giá", typeof(string));
            tb.Columns.Add("Thành tiền", typeof(string));
            gvHang.DataSource = tb;

            qdMatHang =BUS_QuyDinhMatHang.GetQuyDinhMatHang();
            dsId = new int[qdMatHang.Count];
            int i = 0;
            foreach(DTO_QuyDinhMatHang qd in qdMatHang)
            {
                dsId[i] = qd.IdMatHang;
                string ten = BUS_MatHang.GetTen(qd.IdMatHang);
                cbMatHang.Items.Add(ten);
                i++;
                
            }
                cbMatHang.SelectedIndex=0;
            idMatHang = dsId[0];
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

                tb.Rows.Add(idMatHang, cbMatHang.SelectedItem, (int)nbSoLuong.Value, txtDonViTinh.Text,
                txtDonGia.Text, txtThanhTien.Text);
            
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMatHang.SelectedItem.Equals("") == false)
            {
                idMatHang = dsId[cbMatHang.SelectedIndex];
                txtDonGia.Text = BUS_QuyDinhMatHang.GetDonGia(idMatHang);
                txtDonViTinh.Text = BUS_QuyDinhMatHang.GetDonViTinh(idMatHang);
                int soluong = int.Parse(nbSoLuong.Value.ToString());
                int dongia = int.Parse(txtDonGia.Text);
                int tien = soluong * dongia;
                txtThanhTien.Text = tien.ToString();
            }
        }

        private void nbSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (cbMatHang.SelectedItem.Equals("") == false)
            {
                int soluong = int.Parse(nbSoLuong.Value.ToString());
                int dongia = int.Parse(txtDonGia.Text);
                int tien = soluong * dongia;
                txtThanhTien.Text = tien.ToString();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            PhieuXuat p = new PhieuXuat(tb, taiKhoan,nhanVien);
            pnlGiaoDich.Controls.Clear();
            pnlGiaoDich.Controls.Add(p);
            //lbGiaoDich.Text = "Phiếu xuất";
            p.Show();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tb.Rows.Add(idMatHang, cbMatHang.SelectedItem, int.Parse(nbSoLuong.Value.ToString()), txtDonViTinh.Text,
                txtDonGia.Text, txtThanhTien.Text);
        }

        private void cbMatHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbMatHang.SelectedItem.Equals("") == false)
            {
                idMatHang = dsId[cbMatHang.SelectedIndex];
                txtDonGia.Text = BUS_QuyDinhMatHang.GetDonGia(idMatHang);
                txtDonViTinh.Text = BUS_QuyDinhMatHang.GetDonViTinh(idMatHang);
                int soluong = int.Parse(nbSoLuong.Value.ToString());
                int dongia = int.Parse(txtDonGia.Text);
                int tien = soluong * dongia;
                txtThanhTien.Text = tien.ToString();
            }
        }

        private void nbSoLuong_ValueChanged_1(object sender, EventArgs e)
        {
            if (cbMatHang.SelectedItem.Equals("") == false)
            {
                int soluong = int.Parse(nbSoLuong.Value.ToString());
                int dongia = int.Parse(txtDonGia.Text);
                int tien = soluong * dongia;
                txtThanhTien.Text = tien.ToString();
            }
        }

        private void btnXuatHang_Click_1(object sender, EventArgs e)
        {
            PhieuXuat p = new PhieuXuat(tb, taiKhoan, nhanVien);
            pnlGiaoDich.Controls.Clear();
            pnlGiaoDich.Controls.Add(p);
            //lbGiaoDich.Text = "Phiếu xuất";
            p.Show();
        }
    }
}
