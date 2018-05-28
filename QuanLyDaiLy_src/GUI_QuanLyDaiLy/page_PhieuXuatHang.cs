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
        }
        void LoadListpxh()
        {
            DtgvPXH.DataSource = DAL_PhieuXuat.DSPhieuXuat();
        }
        void Loadloaidl()
        {
            cbMaDaiLyPXH.DataSource = DAL_LoaiDaiLy.DSLoaiDaiLy();
            cbMaDaiLyPXH.DisplayMember = "TenLoaiDL";
        }
    }
}
