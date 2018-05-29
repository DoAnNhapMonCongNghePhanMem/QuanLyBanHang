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
           
            string tendl = txttendl.Text;
            String sdt = txtdienthoai.Text;
            string diachi = txtdiachi.Text;
            int quan = (cmbquan.SelectedItem as DTO_Quan).IdQuan;
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int loaidl = (cmbloaidl.SelectedItem as DTO_LoaiDL).IdLoaiDL;
            string cmnd = txtcmnd.Text;         
            float tienno = (float)Convert.ToDouble(txttien.Text);
            DTO_DaiLy dl = new DTO_DaiLy(1, loaidl, tendl, sdt, diachi, quan, ngay, cmnd, tienno);

      
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


            //  int rowindex = dtgvdl.CurrentCell.RowIndex;
            int id = Convert.ToInt32(txtmadl.Text);
            if (DAL_DaiLy.XoaDaiLy(id) == 1)
            {
                //dtgvdl.Rows.RemoveAt(rowindex);
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

        private void dtgvdl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string idDL = dtgvdl.Rows[e.RowIndex].Cells[0].Value.ToString();
            string idLoaiDL = dtgvdl.Rows[e.RowIndex].Cells[1].Value.ToString();
            string idLQ = dtgvdl.Rows[e.RowIndex].Cells[2].Value.ToString();
            string tienNo = dtgvdl.Rows[e.RowIndex].Cells[3].Value.ToString();
            string tenDL = dtgvdl.Rows[e.RowIndex].Cells[4].Value.ToString();
            string sdt = dtgvdl.Rows[e.RowIndex].Cells[5].Value.ToString();
            string diaChi = dtgvdl.Rows[e.RowIndex].Cells[6].Value.ToString();
            string cmnd = dtgvdl.Rows[e.RowIndex].Cells[7].Value.ToString();
            DateTime ngayTiepNhan =(DateTime) dtgvdl.Rows[e.RowIndex].Cells[8].Value;
            string day = ngayTiepNhan.ToString("dd/MM/yyyy");
            txtmadl.Text = idDL;
            cmbloaidl.Text = idLoaiDL;
            cmbquan.Text = idLQ;
            txttien.Text = tienNo;
            txttendl.Text = tenDL;
            txtdienthoai.Text = sdt;
            txtdiachi.Text = diaChi;
            txtcmnd.Text = cmnd;
            txtngay.Text = day;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int id = (int)Convert.ToInt64(txtmadl.Text);
            string tendl = txttendl.Text;
            String sdt = txtdienthoai.Text;
            string diachi = txtdiachi.Text;
            int quan = (cmbquan.SelectedItem as DTO_Quan).IdQuan;
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int loaidl = (cmbloaidl.SelectedItem as DTO_LoaiDL).IdLoaiDL;
            string cmnd = txtcmnd.Text;
            float tienno = (float)Convert.ToDouble(txttien.Text);
            DTO_DaiLy dl = new DTO_DaiLy(id, loaidl, tendl, sdt, diachi, quan, ngay, cmnd, tienno);

            // Console.WriteLine(iddl + " " + tendl + "" + sdt + " " + diachi + " " + quan + " " + ngay + " " + loaidl + " " + cmnd + " " + tienno);
            if (DAL_DaiLy.SuaDaiLy(dl) == 1)
            {
                MessageBox.Show("sua thanh cong");
                LoadListDL();
            }
            else
            {
                MessageBox.Show("co loi");
            }
        }
       // DataTable dt = new DataTable();
        
        //private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar==(char)13)

        //    {

        //        DataView dv = dt.DefaultView;
        //        dv.RowFilter = string.Format("TenDaiLy like '%{0}%'", txtsearch.Text);
        //        dtgvdl.DataSource = dv.ToTable();
        //    }
        //}

        //private void txtsearch_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtsearch.Text))
        //    {
        //        (dtgvdl.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        //    }
        //    else
        //    {
        //        (dtgvdl.DataSource as DataTable).DefaultView.RowFilter = string.Format("select * form DaiLy where TenDaiLy LIKE '%{0}%'", txtsearch.Text);
        //    }
        //}
      

        private void btnTim_Click(object sender, EventArgs e)
        {
            string t = txtsearch.Text;
            dtgvdl.DataSource = DAL_DaiLy.search(t);

        }
    }

    
}
