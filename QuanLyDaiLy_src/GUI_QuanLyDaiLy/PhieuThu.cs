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
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using System.Collections;

namespace QuanLyDaiLy
{
    public partial class PhieuThu : DevExpress.XtraEditors.XtraUserControl
    {
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        private DataTable tb;
        private ArrayList dsDaiLy;
        private ArrayList dsPhieuThu;
        private int[] dsIdDL;
        public PhieuThu()
        {
            InitializeComponent();
        }
        public PhieuThu(DTO_ThongTinTaiKhoan tk,DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            this.nhanVien = nv;
            Load();
        }

        private void Load()
        {
            tb = new DataTable();
            dsDaiLy = BUS_DaiLy.DsDaiLy();
            txtDiaChi.Modified = false;
            txtNguoiThu.Modified = false;
            txtSdt.Modified = false;
            txtTienNo.Modified = false;
            dsIdDL = new int[dsDaiLy.Count];
            int i = 0;
            tb = new DataTable();
            tb.Columns.Add("idDL", typeof(int));
            tb.Columns.Add("diachi", typeof(string));
            tb.Columns.Add("sdt", typeof(string));
            tb.Columns.Add("tienno", typeof(float));

            foreach (DTO_DaiLy dl in dsDaiLy)
            {
                dsIdDL[i] = dl.IdDL;
                string tendaily = BUS_DaiLy.GetTenById(dl.IdDL);
                cbDaiLy.Items.Add(tendaily);
                tb.Rows.Add(dl.IdDL, dl.DiaChi, dl.Sdt, dl.TienNo);
                i++;
            }
            cbDaiLy.SelectedIndex = 0;
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if (txtTienThu.Text.Equals("") == false)
            {
                float tienNo = (float)Convert.ToDouble(txtTienNo.Text);
                float tienThu = (float)Convert.ToDouble(txtTienThu.Text);
                if (tienThu <= tienNo)
                {
                    int id = dsIdDL[cbDaiLy.SelectedIndex];
                    DateTime ngayThu = dtNgayThu.Value;
                    float soTienThu = (float)Convert.ToDouble(txtTienThu.Text);
                    string cmnd = nhanVien.Cmnd;
                    DTO_PhieuThuTien pt = new DTO_PhieuThuTien(0, ngayThu, soTienThu, id, cmnd);
                    BUS_PhieuThuTien.ThemPhieuThu(pt);
                    float tienNoMoi = tienNo - tienThu;
                    BUS_DaiLy.UpdateTienNo(id, tienNoMoi);
                }
                
            }
        }

        private void cbDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDaiLy.SelectedIndex;
            txtDiaChi.Text = tb.Rows[index][1].ToString();
            txtSdt.Text = tb.Rows[index][2].ToString();
            txtTienNo.Text= tb.Rows[index][3].ToString();
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            if (txtTienThu.Text.Equals("") == false)
            {
                float tienNo = (float)Convert.ToDouble(txtTienNo.Text);
                float tienThu = (float)Convert.ToDouble(txtTienThu.Text);
                if (tienThu <= tienNo)
                {
                    int id = dsIdDL[cbDaiLy.SelectedIndex];
                    DateTime ngayThu = dtNgayThu.Value;
                    float soTienThu = (float)Convert.ToDouble(txtTienThu.Text);
                    string cmnd = nhanVien.Cmnd;
                    DTO_PhieuThuTien pt = new DTO_PhieuThuTien(0, ngayThu, soTienThu, id, cmnd);
                    BUS_PhieuThuTien.ThemPhieuThu(pt);
                    float tienNoMoi = tienNo - tienThu;
                    int kq=BUS_DaiLy.UpdateTienNo(id, tienNoMoi);
                    if(kq == 1)
                    {
                        MessageBox.Show("Thu thành công");
                        txtTienNo.Text = BUS_DaiLy.GetTienNo(id).ToString();
                        txtTienThu.Text = "";
                    }else if (kq == 2)
                    {
                        MessageBox.Show("tiền nợ vượt quá quy định");
                    }
                    else
                    {
                        MessageBox.Show("Thu thất bại");
                    }
                }

            }
        }

        private void cbDaiLy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = cbDaiLy.SelectedIndex;
            txtDiaChi.Text = tb.Rows[index][1].ToString();
            txtSdt.Text = tb.Rows[index][2].ToString();
            txtTienNo.Text = tb.Rows[index][3].ToString();
        }
    }
}
