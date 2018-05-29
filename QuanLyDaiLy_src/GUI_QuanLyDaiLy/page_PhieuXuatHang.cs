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
    public partial class page_PhieuXuatHang : UserControl
    {
        public page_PhieuXuatHang()
        {
            InitializeComponent();
            Loadloaidl();
            LoadListpxh();
        }
        void LoadListpxh()
        {
            DtgvPXH.DataSource = DAL_PhieuXuat.DSPhieuXuat();
        }
        void Loadloaidl()
        {
            //cbMaDaiLyPXH.DataSource = DAL_LoaiDaiLy.DSLoaiDaiLy();
            //cbMaDaiLyPXH.DisplayMember = "TenLoaiDL";
        }

        private void btnXoaPXH_Click(object sender, EventArgs e)
        {
            //int rowindex = DtgvPXH.CurrentCell.RowIndex;

            //if (DAL_PhieuXuat.XoaPhieuXuat(rowindex) == 1)
            //{
            //    DtgvPXH.Rows.RemoveAt(rowindex);
            //    MessageBox.Show("xoa thanh cong");
            //    LoadListpxh();
            //}
            //else
            //{
            //    MessageBox.Show("loi");
            //}

            

            //int idphieuxuat = Convert.ToInt32(txtmadl.Text);

            //if(DAL_PhieuXuat.XoaPhieuXuat(idphieuxuat)==1)
            //{
            //    MessageBox.Show("xoa thanh cong");
            //    LoadListpxh();
            //}
            //else
            //{
            //    MessageBox.Show("loi xoa");
            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
