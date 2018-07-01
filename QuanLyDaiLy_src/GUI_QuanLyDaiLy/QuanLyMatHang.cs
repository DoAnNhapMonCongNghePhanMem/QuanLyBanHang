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
    

    public partial class QuanLyMatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private ArrayList dsMatHang;
        private DataTable tb;
        private int id = -1;
        public QuanLyMatHang()
        {
            InitializeComponent();
            Load();
        }
        public QuanLyMatHang(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            dsMatHang = BUS_MatHang.DsMatHang();
            tb = new DataTable();
            tb.Columns.Add("Id", typeof(int));
            tb.Columns.Add("Tên mặt hàng", typeof(string));
            gvMatHang.DataSource = tb;
            upDateGV();
        }
        private void upDateGV()
        {
            ResetGV();
            foreach(DTO_MatHang mh in dsMatHang)
            {
                tb.Rows.Add(mh.IdMatHang, mh.TenMatHang);
            }
        }
        private void ResetGV()
        {
            tb.Rows.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("")==false)
            {
                string ten = txtTen.Text;
                int kq = BUS_MatHang.ThemMatHang(ten);
                dsMatHang = BUS_MatHang.DsMatHang();
                upDateGV();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                int kq = BUS_MatHang.Xoa(id);
                if (kq == 1)
                {

                }
                dsMatHang = BUS_MatHang.DsMatHang();
                upDateGV();
            }
            
        }

        private void gvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("") == false)
            {
                DTO_MatHang mh = new DTO_MatHang(id, txtTen.Text);
                int kq = BUS_MatHang.CapNhat(mh);
                 if (kq == 1) {
                }
                dsMatHang = BUS_MatHang.DsMatHang();
                upDateGV();

            }
        }


        private void txtTim_EditValueChanged(object sender, EventArgs e)
        {
            
            if (txtTim.Text.Equals("") == false)
            {
                dsMatHang = BUS_MatHang.Search(txtTim.Text);
                upDateGV();
            }
            else
            {
                dsMatHang = BUS_MatHang.DsMatHang();
                upDateGV();

            }
        }

        private void gvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && hang < dsMatHang.Count)
            {
                txtTen.Text = gvMatHang.Rows[hang].Cells[1].Value.ToString();
                id = int.Parse(gvMatHang.Rows[hang].Cells[0].Value.ToString());

            }
        }
    }
}
