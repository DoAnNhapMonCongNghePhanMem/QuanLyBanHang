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
    public partial class page_HoSo : UserControl
    {
        //BindingList<DAL_DaiLy> p1;
        public page_HoSo()
        {
            InitializeComponent();
            Loadlist();
        }
        void Loadlist()
        {
            LoadListDL();
            Loadloaidl();
            Loadloaidl();
            LoadlListQuan();
        }
        void LoadListDL()
        {
            
            dtgvdl.DataSource = DAL_DaiLy.DsDaiLy();
           // p1 = new BindingList<DAL_DaiLy>();

        }   
        void LoadlListQuan()
        {
            cmbquan.DataSource = DAL_Quan.DSQuan();
            cmbquan.DisplayMember = "TenQuan";
        }
        void Loadloaidl()
        {
            cmbloaidl.DataSource = DAL_LoaiDaiLy.DSLoaiDaiLy();
            cmbloaidl.DisplayMember = "TenLoaiDL";
        }
        


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //int iddl = Convert.ToInt32(txtmadl.Text)
            //int iddl = Convert.ToInt32(txtmadl.Text);
            string tendl = txttendl.Text;
            String sdt = txtdienthoai.Text;
            string diachi = txtdiachi.Text;
            int quan = (cmbquan.SelectedItem as DTO_Quan).IdQuan;
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int loaidl = (cmbloaidl.SelectedItem as DTO_LoaiDL).IdLoaiDL;
            string cmnd = txtcmnd.Text;         
            float tienno = (float)nmtienno.Value;
            DTO_DaiLy dl = new DTO_DaiLy(1, loaidl, tendl, sdt, diachi, quan, ngay, cmnd, tienno);

            // Console.WriteLine(iddl + " " + tendl + "" + sdt + " " + diachi + " " + quan + " " + ngay + " " + loaidl + " " + cmnd + " " + tienno);
            if (DAL_DaiLy.ThemDaiLy(dl)==1)
            {
                MessageBox.Show("them thanh cong");
                LoadListDL();
            }
            else
            {
                MessageBox.Show("co loi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(txtmadl.Text);
            //if (DAL_DaiLy.XoaDaiLy(id) == 1)
            //{
            //    MessageBox.Show("xoa thanh cong");
            //    LoadListDL();
            //}
            //else
            //{
            //    MessageBox.Show("loi");
            //}

            int rowindex = dtgvdl.CurrentCell.RowIndex;

            if (DAL_DaiLy.XoaDaiLy(rowindex) == 1)
            {
                dtgvdl.Rows.RemoveAt(rowindex);
                MessageBox.Show("xoa thanh cong");
                LoadListDL();
            }
            else
            {
                MessageBox.Show("loi");
            }
            

            LoadListDL();
        }

        private void Txtmadl_(object sender, EventArgs e)
        {
            
        }

        
    }
}
