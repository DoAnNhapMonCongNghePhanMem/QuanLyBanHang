using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using System.Collections;

namespace QuanLyDaiLy
{
    public partial class hosodl : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public object cmbloaidl { get; private set; }

        public hosodl()
        {
            InitializeComponent();
            Loadlist();
        }

        private void grcontrol_Click(object sender, EventArgs e)
        {

        }
        void Loadlist()
        {
            LoadListDL();
            Loadloaidl();
            LoadlListQuan();
        }
        void LoadListDL()
        {

            dtgvdl1.DataSource = BUS_DaiLy.DsDaiLy();
            //p1 = new BindingList<DAL_DaiLy>();
            dtgvdl1.Columns["IdDL"].HeaderText = "Mã Đại Lý";
            dtgvdl1.Columns["IdLoaiDL"].HeaderText = "LoạiĐL";
            dtgvdl1.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dtgvdl1.Columns["Sdt"].HeaderText = "SDT";
            dtgvdl1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgvdl1.Columns["NgayNhan"].HeaderText = "Ngày Nhận";
            dtgvdl1.Columns["Cmnd"].HeaderText = "CMND";
            dtgvdl1.Columns["IdQuan"].HeaderText = "Quận";
            dtgvdl1.Columns["TienNo"].HeaderText = "Tiền Nợ";

        }
        void LoadlListQuan()
        {
            cmbquan.DataSource = BUS_Quan.DSquan();
            cmbquan.DisplayMember = "TenQuan";
        }
        void Loadloaidl()
        {
            cmbdl.DataSource = BUS_LoaiDL.DsLoaiDL();
            cmbdl.DisplayMember = "TenLoaiDL";
            //cmbloaidl.ValueMember = "IdLoaiDL ";
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tendl = txttendl.Text;
            String sdt = txtsdl.Text;
            string diachi = txtdiachi.Text;
            int quan = (cmbquan.SelectedItem as DTO_Quan).IdQuan;
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int loaidl = (cmbdl.SelectedItem as DTO_LoaiDL).IdLoaiDL;
            string cmnd = txtcmnd.Text;
            float tienno = (float)Convert.ToDouble(txttien.Text);
            DTO_DaiLy dl = new DTO_DaiLy(1, loaidl, tendl, sdt, diachi, quan, ngay, cmnd, tienno);


            if (BUS_DaiLy.Themdaily(dl) == 1)
            {
                MessageBox.Show("Them thanh cong");
                LoadListDL();
            }
            else
            {
                MessageBox.Show("co loi");
            }
        }

       

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //  int rowindex = dtgvdl.CurrentCell.RowIndex;
            int id = Convert.ToInt32(txtmadl.Text);
            if (BUS_DaiLy.XoaDaiLy(id) == 1)
            {
                //dtgvdl.Rows.RemoveAt(rowindex);
                MessageBox.Show("Xoa thanh cong");
                LoadListDL();
            }
            else
            {
                MessageBox.Show("Loi");
            }


            LoadListDL();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string t = txtsearch.Text;
            ArrayList al = BUS_DaiLy.Search(t);
            if (al.Count == 0)
            {
                return;
            }
            dtgvdl1.DataSource = BUS_DaiLy.Search(t);            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = (int)Convert.ToInt32(txtmadl.Text);
            string tendl = txttendl.Text;
            String sdt = txtsdl.Text;
            string diachi = txtdiachi.Text;
            int quan = (cmbquan.SelectedItem as DTO_Quan).IdQuan;
            DateTime ngay = Convert.ToDateTime(txtngay.Text);
            int loaidl = (cmbdl.SelectedItem as DTO_LoaiDL).IdLoaiDL;
            string cmnd = txtcmnd.Text;
            float tienno = (float)Convert.ToDouble(txttien.Text);
            DTO_DaiLy dl = new DTO_DaiLy(id, loaidl, tendl, sdt, diachi, quan, ngay, cmnd, tienno);

            // Console.WriteLine(iddl + " " + tendl + "" + sdt + " " + diachi + " " + quan + " " + ngay + " " + loaidl + " " + cmnd + " " + tienno);
            if (BUS_DaiLy.SuaDaiLy(dl) == 1)
            {
                MessageBox.Show("Sua thanh cong");
                LoadListDL();
            }
            else
            {
                MessageBox.Show("Co loi");
            }
        }
    

        private void dtgvdl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            DataGridViewRow row = this.dtgvdl1.Rows[e.RowIndex];
            txtmadl.Text = row.Cells[6].Value.ToString();
            cmbdl.Text = row.Cells[7].Value.ToString();
            cmbquan.Text = row.Cells[8].Value.ToString();
            txttien.Text = row.Cells[5].Value.ToString();
            txttendl.Text = row.Cells[0].Value.ToString();
            txtsdl.Text = row.Cells[1].Value.ToString();
            txtdiachi.Text = row.Cells[2].Value.ToString();
            txtcmnd.Text = row.Cells[3].Value.ToString();
            DateTime ngay = (DateTime)row.Cells[4].Value;
            txtngay.Text = ngay.ToString("yyyy/MM/dd");
            
        }

        
    }
    
    

}