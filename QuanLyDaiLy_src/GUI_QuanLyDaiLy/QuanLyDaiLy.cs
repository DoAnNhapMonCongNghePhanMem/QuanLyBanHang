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
using System.Collections;

namespace QuanLyDaiLy
{
    public partial class QuanLyDaiLy : DevExpress.XtraEditors.XtraUserControl
    {
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        private DataTable tb = new DataTable();
        private ArrayList dsDaiLy;
        private ArrayList dsLoaiDL;
        private ArrayList dsQuan;
        private int[] arrIdDL;
        private int[] arrIdLDL;
        private int[] arrIdQuan;
        private int idDL=-1, idLoaiDL=-1, idQuan=-1;

        public QuanLyDaiLy()
        {
            //InitializeComponent();
            //tb.Columns.Add("IdDL", typeof(int));
            //tb.Columns.Add("IdLoaiDL", typeof(int));
            //tb.Columns.Add("IdQuan", typeof(int));
            //tb.Columns.Add("Tên đại lý", typeof(string));
            //tb.Columns.Add("Loại đại lý", typeof(string));
            //tb.Columns.Add("Số điện thoại", typeof(string));
            //tb.Columns.Add("Quận", typeof(string));
            //tb.Columns.Add("Ngày tiếp nhận", typeof(string));
            //tb.Columns.Add("Người tiếp nhận", typeof(string));
            //tb.Columns.Add("Tiền nợ", typeof(string));
            //tb.Columns.Add("Địa chỉ", typeof(string));
            //Load();
        }
        public QuanLyDaiLy(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
   
            taiKhoan = tk;
            nhanVien = nv;
            tb.Columns.Add("IdDL", typeof(int));
            tb.Columns.Add("IdLoaiDL", typeof(int));
            tb.Columns.Add("IdQuan", typeof(int));
            tb.Columns.Add("Tên đại lý", typeof(string));
            tb.Columns.Add("Loại đại lý", typeof(string));
            tb.Columns.Add("Số điện thoại", typeof(string));
            tb.Columns.Add("Quận", typeof(string));
            tb.Columns.Add("Ngày tiếp nhận", typeof(string));
            tb.Columns.Add("Người tiếp nhận", typeof(string));
            tb.Columns.Add("Tiền nợ", typeof(string));
            tb.Columns.Add("Địa chỉ", typeof(string));
            Load();
        }
        private void Load()
        {
           
           
            idDL = -1;
            idLoaiDL = -1;
            idQuan = -1;
            txtTenDaiLy.Text = "";
            cbLoaiDL.SelectedItem ="";
            txtSdt.Text = "";
            cbQuan.SelectedItem = "";
            dtNgayNhan.Value = DateTime.Now;
            txtNguoiNhan.Text = "";
            txtTienNo.Text = "";
            txtDiaChi.Text = "";
            //txtNguoiNhan.Enabled = false;
            dsDaiLy = BUS_DaiLy.DsDaiLy();
            dsQuan = BUS_Quan.DSquan();
            dsLoaiDL = BUS_LoaiDL.DsLoaiDL();

            arrIdDL = new int[dsDaiLy.Count];
            arrIdLDL = new int[dsLoaiDL.Count];
            arrIdQuan = new int[dsQuan.Count];
            int i = 0;
            foreach (DTO_LoaiDL ldl in dsLoaiDL)
            {
                cbLoaiDL.Items.Add(ldl.TenLoaiDL);
                arrIdLDL[i] = ldl.IdLoaiDL;
                i++;
            }
            int j = 0;
            foreach (DTO_Quan ldl in dsQuan)
            {
                cbQuan.Items.Add(ldl.TenQuan);
                arrIdQuan[j] = ldl.IdQuan;
                j++;
            }
            gvDaiLy.DataSource = tb;
            gvDaiLy.Columns["IdDL"].Visible = false;
            gvDaiLy.Columns["IdLoaiDL"].Visible = false;
            gvDaiLy.Columns["IdQuan"].Visible = false;

            UpdateGvDaiLy();
            
        }
        private void ResetTable()
        {
            tb.Rows.Clear();
            arrIdDL = new int[dsDaiLy.Count];
            //gvDaiLy.Columns["IdQuan"].Visible = false;
            //gvDaiLy.Columns["IdLoaiDL"].Visible = false;
            //gvDaiLy.Columns["IdDL"].Visible = false;
        }
        private void UpdateGvDaiLy()
        {
            ResetTable();
            int t = 0;
            foreach (DTO_DaiLy dl in dsDaiLy)
            {
                arrIdDL[t] = dl.IdDL;
                t++;
                string tenDL = BUS_DaiLy.GetTenById(dl.IdDL);
                string tenQuan = BUS_Quan.GetTen(dl.IdQuan);
                string tenLoaiDL = BUS_LoaiDL.GetTenById(dl.IdLoaiDL);
                string tenNV = BUS_NhanVien.GetTenNV(dl.Cmnd);
                string ngay = dl.NgayNhan.ToString("dd/MM/yyyy");
                tb.Rows.Add(dl.IdDL, dl.IdLoaiDL, dl.IdQuan, tenDL, tenLoaiDL, dl.Sdt, tenQuan,
                    ngay, tenNV, dl.TienNo, dl.DiaChi);
            }
        }

        private void txttien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BUS_DaiLy.XoaDaiLy(idDL) == 0)
            {

            }else
            {
                dsDaiLy= BUS_DaiLy.DsDaiLy();
                UpdateGvDaiLy();
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(idDL!=-1 && arrIdLDL[cbLoaiDL.SelectedIndex]>=0 && arrIdQuan[cbQuan.SelectedIndex]>=0 &&
                txtTienNo.Text.Equals("")==false && txtTenDaiLy.Text.Equals("") == false &&
                txtSdt.Text.Equals("") == false && txtDiaChi.Text.Equals("") == false)
            {

                DTO_DaiLy dl = new DTO_DaiLy();
                dl.IdDL = idDL;
                dl.IdLoaiDL = arrIdLDL[cbLoaiDL.SelectedIndex];
                dl.IdQuan = arrIdQuan[cbQuan.SelectedIndex];
                dl.TienNo = (float)Convert.ToDouble(txtTienNo.Text);
                dl.TenDaiLy = txtTenDaiLy.Text;
                dl.Sdt = txtSdt.Text;
                dl.DiaChi = txtDiaChi.Text;
                dl.Cmnd = nhanVien.Cmnd;
                dl.NgayNhan = DateTime.Now;

                int kq = BUS_DaiLy.SuaDaiLy(dl);

                if (kq == 1)
                {
                    dsDaiLy = BUS_DaiLy.DsDaiLy();
                    UpdateGvDaiLy();
                    MessageBox.Show("Cập nhật thành công");
                }
                else if (kq == 3)
                {
                    MessageBox.Show("Loại đại lý đã đủ số lượng");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }


        }

        private void btnTim(object sender, EventArgs e)
        {

        }


        private void btnReMove_Click(object sender, EventArgs e)
        {
            idDL = -1;
            txtSdt.Text = "";
            txtNguoiNhan.Text = "";
            idLoaiDL = -1;
            idQuan = -1;
            txtTenDaiLy.Text = "";
            cbLoaiDL.SelectedItem = "";
            txtTienNo.Text = "";
            txtDiaChi.Text = "";
            cbQuan.SelectedItem = "";
            txtTienNo.Text = "";
        }

        private void txtsearch_EditValueChanged(object sender, EventArgs e)
        {
           
            if (txtsearch.Text.Equals("") == false)
            {
                dsDaiLy = BUS_DaiLy.Search(txtsearch.Text);
                UpdateGvDaiLy();
            }
            else
            {
                dsDaiLy = BUS_DaiLy.DsDaiLy();
                UpdateGvDaiLy();

            }
        }

        private void gvDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_EditValueChanged_1(object sender, EventArgs e)
        {
            if (txtsearch.Text.Equals("") == false)
            {
                dsDaiLy = BUS_DaiLy.Search(txtsearch.Text);
                UpdateGvDaiLy();
            }
            else
            {
                dsDaiLy = BUS_DaiLy.DsDaiLy();
                UpdateGvDaiLy();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbLoaiDL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNgayTiepNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void txtNguoiNhan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenDaiLy_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idDL != -1 && arrIdLDL[cbLoaiDL.SelectedIndex] >= 0 && arrIdQuan[cbQuan.SelectedIndex] >= 0 &&
                txtTienNo.Text.Equals("") == false && txtTenDaiLy.Text.Equals("") == false &&
                txtSdt.Text.Equals("") == false && txtDiaChi.Text.Equals("") == false)
            {

                DTO_DaiLy dl = new DTO_DaiLy();
                dl.IdDL = 1;
                dl.IdLoaiDL = arrIdLDL[cbLoaiDL.SelectedIndex];
                dl.IdQuan = arrIdQuan[cbQuan.SelectedIndex];
                dl.TenDaiLy = txtTenDaiLy.Text;
                dl.Sdt = txtSdt.Text;
                dl.Cmnd = nhanVien.Cmnd;
                dl.DiaChi = txtDiaChi.Text;
                dl.NgayNhan = DateTime.Now;
                dl.TienNo = 0;
                if (BUS_DaiLy.Themdaily(dl) == 0)
                {

                }
                else
                {
                    dsDaiLy = BUS_DaiLy.DsDaiLy();
                    UpdateGvDaiLy();
                }
            }
        }

        private void gvDaiLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (0<=hang &&hang< dsDaiLy.Count)
            {
                
                idDL = int.Parse(gvDaiLy.Rows[hang].Cells[0].Value.ToString());
                idLoaiDL = int.Parse(gvDaiLy.Rows[hang].Cells[1].Value.ToString());
                idQuan = int.Parse(gvDaiLy.Rows[hang].Cells[2].Value.ToString());
                txtTenDaiLy.Text = gvDaiLy.Rows[hang].Cells[3].Value.ToString();
                cbLoaiDL.SelectedItem = gvDaiLy.Rows[hang].Cells[4].Value.ToString();
                txtSdt.Text = gvDaiLy.Rows[hang].Cells[5].Value.ToString();
                cbQuan.SelectedItem = gvDaiLy.Rows[hang].Cells[6].Value.ToString();
                dtNgayNhan.Value = (DateTime) Convert.ToDateTime(gvDaiLy.Rows[hang].Cells[7].Value.ToString());
                txtNguoiNhan.Text = gvDaiLy.Rows[hang].Cells[8].Value.ToString();
                txtTienNo.Text = gvDaiLy.Rows[hang].Cells[9].Value.ToString();
                txtDiaChi.Text = gvDaiLy.Rows[hang].Cells[10].Value.ToString();
            }

        }
    }
}
