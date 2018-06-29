using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using System.Collections;

namespace QuanLyDaiLy

{
    public partial class phieuthutien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public phieuthutien()
        {
            InitializeComponent();
            list();
        }

        void list()
        {
            listdl();
            listphieuthu();
        }
      
        void listdl()
        {
            cmblistdl.DataSource = BUS_DaiLy.DsDaiLy();
            cmblistdl.DisplayMember = "TenDaiLy";
        }
        void listphieuthu()
        {          
            dtgvdl.DataSource = BUS_PhieuThuTien.DsDaiLy();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iddl = (cmblistdl.SelectedItem as DTO_DaiLy).IdDL;
            DateTime ngaythu = Convert.ToDateTime(txtngaythu.Text);
            float tienthu = (float)Convert.ToDouble(txtsotien.Text);
            string cmnd = txtcmnd.Text;
            DTO_PhieuThuTien pt = new DTO_PhieuThuTien(1, ngaythu, tienthu, iddl, cmnd);
            if (BUS_PhieuThuTien.ThemPhieuThu(pt) == 1)
            {
                MessageBox.Show("Them thanh cong");
                listphieuthu();
            }
            else
            {
                MessageBox.Show("co loi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtmaphieu.Text);
            if (BUS_PhieuThuTien.XoaPhieuThu(id) == 1)
            {
                //dtgvdl.Rows.RemoveAt(rowindex);
                MessageBox.Show("xoa thanh cong");
                listphieuthu();
            }
            else
            {
                MessageBox.Show("loi");
            }


            listphieuthu();
        }

    private void dtgvdl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = this.dtgvdl.Rows[e.RowIndex];
            txtmaphieu.Text = row.Cells[0].Value.ToString();
            txtsotien.Text = row.Cells[1].Value.ToString();
            DateTime ngay = (DateTime)row.Cells[2].Value;
            txtngaythu.Text = ngay.ToString("dd//MM/yyyy");
            txtcmnd.Text = row.Cells[3].Value.ToString();
            txtsdt.Text = row.Cells[4].Value.ToString();
            txtdiachi.Text = row.Cells[5].Value.ToString();
            cmblistdl.Text = row.Cells[6].Value.ToString();        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string t = txtsearch.Text;
            ArrayList al = BUS_PhieuThuTien.search(t);
            if (al.Count == 0)
            {
                return;
            }
            dtgvdl.DataSource = BUS_PhieuThuTien.search(t);
        }
    }
}