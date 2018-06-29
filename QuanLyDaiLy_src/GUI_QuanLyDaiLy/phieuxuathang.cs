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
    }
}