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
using DTO_QuanLyDaiLy;
using BUS_QuanLyDaiLy;
namespace QuanLyDaiLy
{
    public partial class QCToChuc : DevExpress.XtraEditors.XtraUserControl
    {
        DTO_QuyCheToChuc qctc = BUS_QuyCheToChuc.GetQuyChe();
        public QCToChuc()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            txtSoLoaiDL.Text = qctc.SoLoaiDaiLy.ToString();
            txtSoDLToiDa.Text = qctc.SoDaiLyToiDa.ToString();
            txtSLMatHang.Text = qctc.SoMatHang.ToString();
            txtSoQuan.Text = qctc.SoQuan.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int soLoaiDL = int.Parse(txtSoLoaiDL.Text);
            int soDLToiDa = int.Parse(txtSoDLToiDa.Text);
            int soQuan = int.Parse(txtSoQuan.Text);
            int soLuongMH = int.Parse(txtSLMatHang.Text);
            DTO_QuyCheToChuc qc = new DTO_QuyCheToChuc(soLoaiDL, soDLToiDa, soLuongMH, soQuan);
            if (BUS_QuyCheToChuc.CapNhatQuyChe(qc) == 0)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
