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

namespace QuanLyDaiLy
{
    public partial class page_HoSo : UserControl
    {
        public page_HoSo()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            LoadListDL();
            Loadloaidl();
            Loadloaidl();
        }
        void LoadListDL()
        {
            dtgvdl.DataSource = DAL_DaiLy.DsDaiLy();
            
        }   
        void Loadloaidl()
        {
            cmbloaidl.DataSource = DAL_LoaiDaiLy.DSLoaiDaiLy();
            cmbloaidl.DisplayMember = "TenLoaiDL";
        }
        void LoadQuan()
        {
            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
