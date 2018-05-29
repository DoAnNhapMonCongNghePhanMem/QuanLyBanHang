using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;

namespace QuanLyDaiLy
{
    public partial class page_MatHang : UserControl
    {
        public page_MatHang()
        {
            InitializeComponent();
            LoadlistHang();
        }
        void LoadlistHang()
        {
            dtgvMatHang.DataSource = DAL_MatHang.DSLoaiDaiLyL();
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            string mh = txbTenMatHang.Text;
            
            if (DAL_MatHang.ThemMatHang(mh) == 1)
            {
                MessageBox.Show("them thanh cong");
                LoadlistHang();
            }
            else
            {
                MessageBox.Show("co loi");
            }
        }

        private void btnCapNhatMatHang_Click(object sender, EventArgs e)
        {
            int id = (int)Convert.ToInt64(txbMaMatHang.Text);
            string mh = txbTenMatHang.Text;
            DTO_MatHang d = new DTO_MatHang(id, mh);
            if (DAL_MatHang.CapNhatMatHang(d) == 1)
            {
                MessageBox.Show("sua thanh cong");
                LoadlistHang();
            }
            else
            {
                MessageBox.Show("co loi");
            }
        }

        private void btnXoaMatHang_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbMaMatHang.Text);
            if (DAL_MatHang.XoaMatHang(id) == 1)
            {
                MessageBox.Show("xoa thanh cong");
                LoadlistHang();
            }
            else
            {
                MessageBox.Show("loi");
            }
        }

        private void dtgvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string idDL = dtgvMatHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenDL = dtgvMatHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbTenMatHang.Text = tenDL;
            txbMaMatHang.Text = idDL;
        }

        private void btnTimMatHang_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            dtgvMatHang.DataSource = DAL_MatHang.search(name);
        }
    }
}
