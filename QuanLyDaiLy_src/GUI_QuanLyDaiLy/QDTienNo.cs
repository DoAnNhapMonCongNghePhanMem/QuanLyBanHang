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
    public partial class QDTienNo : DevExpress.XtraEditors.XtraUserControl
    {
        private ArrayList dsQuyDinh;
        private DataTable tb = new DataTable();
        private int idLoaiDL = -1;
        public QDTienNo()
        {
            InitializeComponent();
            tb.Columns.Add(new DataColumn("Id", typeof(int)));
            tb.Columns.Add(new DataColumn("Loại Đại Lý", typeof(string)));
            tb.Columns.Add(new DataColumn("Tiền nợ", typeof(float)));
            Load();
        }
        private void Load()
        {
            dsQuyDinh = BUS_QuyDinhTienNo.GetQuyDinhTienNo();
            cbLoaiDL.Items.Clear();
            tb.Clear();
            string ten = "";
            foreach (DTO_QuyDinhTienNo l in dsQuyDinh)
            {
                ten = BUS_LoaiDL.GetTenById(l.IdLoaiDL);
                cbLoaiDL.Items.Add(ten);
                tb.Rows.Add(l.IdLoaiDL, ten, l.TienNoToiDa);
            }
            gvQuyDinh.DataSource = tb;
            gvQuyDinh.Columns["Id"].Visible = false;

        }

        private void cbLoaiDL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cbLoaiDL.SelectedItem.Equals(" ") == false && txtSoTienNo.Equals(" ") == false
                && idLoaiDL != -1)
            {
                int tien = int.Parse(txtSoTienNo.Text.ToString());
                DTO_QuyDinhTienNo qd = new DTO_QuyDinhTienNo(idLoaiDL, tien);

                if (BUS_QuyDinhTienNo.CapNhatQuyDinh(qd) == 0)
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
                idLoaiDL = int.Parse(gvQuyDinh.Rows[hang].Cells[0].Value.ToString());
                cbLoaiDL.SelectedItem = gvQuyDinh.Rows[hang].Cells[1].Value.ToString();
                txtSoTienNo.Text = gvQuyDinh.Rows[hang].Cells[2].Value.ToString();
            }
            
        }
    }
}
