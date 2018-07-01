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
namespace QuanLyDaiLy

{
    public partial class phieuxuathang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public phieuxuathang()
        {
            InitializeComponent();
            list();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void list()
        {
            listdl();
            
        }
        void listdl()
        {
            cmblistdl.DataSource = BUS_DaiLy.DsDaiLy();
            cmblistdl.DisplayMember = "TenDaiLy";
        }
        void listphieuxuat()
        {
            int iddl = (cmblistdl.SelectedItem as DTO_DaiLy).IdDL;
            dtgvdl.DataSource = BUS_PhieuXuat.Dsphieuxuat(iddl);
        }

        private void load_Click(object sender, EventArgs e)
        {
            listphieuxuat();
            int sc = dtgvdl.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc; i++)
                thanhtien += float.Parse(dtgvdl.Rows[i].Cells["ThanhTien"].Value.ToString());
            txttontien.Text =Convert.ToString(thanhtien);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void cmblistdl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txttontien_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {

        }

        private void dtgvdl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}