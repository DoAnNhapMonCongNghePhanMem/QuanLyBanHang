using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO_QuanLyDaiLy;
using BUS_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class QuyCheToChuc : DevExpress.XtraEditors.XtraForm
    {
        DTO_QuyCheToChuc qctc = BUS_QuyCheToChuc.GetQuyChe();
        public QuyCheToChuc()
        {
            InitializeComponent();
            txtSoLoaiDL.Text = qctc.SoLoaiDaiLy.ToString();
            txtSoDLToiDa.Text = qctc.SoDaiLyToiDa.ToString();
            txtSLMatHang.Text = qctc.SoMatHang.ToString();
            txtSoQuan.Text = qctc.SoQuan.ToString();
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int soLoaiDL = int.Parse(txtSoLoaiDL.Text);
            int soDLToiDa = int.Parse(txtSoDLToiDa.Text);
            int soQuan = int.Parse(txtSoQuan.Text);
            int soLuongMH = int.Parse(txtSLMatHang.Text);
            DTO_QuyCheToChuc qc = new DTO_QuyCheToChuc(soLoaiDL, soDLToiDa, soLuongMH, soQuan);
            if (BUS_QuyCheToChuc.CapNhatQuyChe(qc)==0)
            {

            }else
            {
 
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLoaiDL_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoDLToiDa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSLMatHang_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSoQuan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}