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
    public partial class ThemLoaiDaiLy : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable tb;
        private ArrayList dsLoaiDL;
        private int id = -1;
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public ThemLoaiDaiLy()
        {
            InitializeComponent();
            Load();
        }
        public ThemLoaiDaiLy(DTO_ThongTinTaiKhoan tk, DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
            Load();
        }
        private void Load()
        {
            tb = new DataTable();
            tb.Columns.Add("id", typeof(int));
            tb.Columns.Add("ten", typeof(string));

            dsLoaiDL = BUS_LoaiDL.DsLoaiDL();


            gvLoaiDL.DataSource = tb;

            foreach (DTO_LoaiDL q in dsLoaiDL)
            {
                tb.Rows.Add(q.IdLoaiDL, q.TenLoaiDL);
            }
        }
        private void updateGV()
        {
            tb.Rows.Clear();
            foreach (DTO_LoaiDL q in dsLoaiDL)
            {
                tb.Rows.Add(q.IdLoaiDL, q.TenLoaiDL);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            if (ten.Equals("") == false)
            {
                int kq = BUS_LoaiDL.ThemLoaiDL(ten);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    dsLoaiDL = BUS_LoaiDL.DsLoaiDL();
                    updateGV();
                }else if (kq == 2)
                {
                    MessageBox.Show("số loại đại lý vượt quá quy định");
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Tên loại đại lý đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("") == false)
            {
                int kq = BUS_LoaiDL.XoaLoaiDL(id);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    dsLoaiDL = BUS_LoaiDL.DsLoaiDL();
                    updateGV();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void gvLoaiDL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang >= 0 && hang < tb.Rows.Count)
            {
                id = int.Parse(tb.Rows[hang][0].ToString());
                txtTen.Text = tb.Rows[hang][1].ToString();
            }
        }
    }
}
