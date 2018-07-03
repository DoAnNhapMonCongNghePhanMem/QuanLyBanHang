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
using System.Collections;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class QDMatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private ArrayList dsQuyDinh;
        private DataTable tb = new DataTable();
        private int idMatHang = -1;
        public QDMatHang()
        {
            InitializeComponent();
            tb.Columns.Add(new DataColumn("IdMH", typeof(int)));
            tb.Columns.Add(new DataColumn("Mặt hàng", typeof(string)));
            tb.Columns.Add(new DataColumn("Đơn vị tính", typeof(string)));
            tb.Columns.Add(new DataColumn("Đơn giá", typeof(float)));
            Load();
        }

        private void Load()
        {
            dsQuyDinh = BUS_QuyDinhMatHang.GetQuyDinhMatHang();
            cbMatHang.Items.Clear();
            tb.Clear();
            string ten = "";
            foreach (DTO_QuyDinhMatHang l in dsQuyDinh)
            {
                ten = BUS_MatHang.GetTen(l.IdMatHang);
                cbMatHang.Items.Add(ten);
                tb.Rows.Add(l.IdMatHang, ten, l.DonViTinh,l.DonGia);
            }
            gvQuyDinh.DataSource = tb;
            gvQuyDinh.Columns["IdMH"].Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cbMatHang.SelectedItem.Equals(" ") == false && txtDonViTinh.Equals(" ") == false
                &&txtDonGia.Equals(" ")==false && idMatHang != -1)
            {
                int donGia = int.Parse(txtDonGia.Text.ToString());
                DTO_QuyDinhMatHang qd = new DTO_QuyDinhMatHang(idMatHang,txtDonViTinh.Text,donGia);

                if (BUS_QuyDinhMatHang.CapNhatQuyDinh(qd) == 0)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                    Load();
                }

            }
        }

        private void gvQuyDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < dsQuyDinh.Count)
            {
                idMatHang = int.Parse(gvQuyDinh.Rows[hang].Cells[0].Value.ToString());
                cbMatHang.SelectedItem = gvQuyDinh.Rows[hang].Cells[1].Value.ToString();
                txtDonViTinh.Text = gvQuyDinh.Rows[hang].Cells[2].Value.ToString();
                txtDonGia.Text= gvQuyDinh.Rows[hang].Cells[3].Value.ToString();
            }
        }

        private void cbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
