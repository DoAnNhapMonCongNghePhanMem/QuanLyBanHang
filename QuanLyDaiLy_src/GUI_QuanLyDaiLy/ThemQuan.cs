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
    public partial class ThemQuan : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable tb;
        private ArrayList dsQuan;
        private int id = -1;
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        public ThemQuan()
        {
            InitializeComponent();
            Load();
        }
        public ThemQuan(DTO_ThongTinTaiKhoan tk, DTO_NhanVienQuanLy nv)
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

            dsQuan = BUS_Quan.DSquan();


            gvQuan.DataSource = tb;

            foreach(DTO_Quan q in dsQuan)
            {
                tb.Rows.Add(q.IdQuan, q.TenQuan);
            }
        }
        private void updateGV()
        {
            tb.Rows.Clear();
           foreach (DTO_Quan q in dsQuan)
            {
                tb.Rows.Add(q.IdQuan, q.TenQuan);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string quan=txtQuan.Text;
            if (quan.Equals("") == false)
            {
                int kq=BUS_Quan.ThemQuan(quan);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    dsQuan = BUS_Quan.DSquan();
                    updateGV();
                }else if (kq == 2)
                {
                    MessageBox.Show("số lượng quận vượt quy định");
                }
                else if (kq == 3)
                {
                    MessageBox.Show("tên quận đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
         //       1:thành công
         //*2:số lượng quận vượt quy định
         //*3:tên quận đã tồn tại

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtQuan.Text.Equals("") == false)
            {
                int kq = BUS_Quan.XoaQuan(id);
                if (kq == 1)
                {
                    MessageBox.Show("Xoá thành công");
                    dsQuan = BUS_Quan.DSquan();
                    updateGV();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            
        }

        private void gvQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if(hang>=0 && hang < tb.Rows.Count)
            {
                id =int.Parse(tb.Rows[hang][0].ToString());
                txtQuan.Text = tb.Rows[hang][1].ToString();
            }
        }
    }
}
