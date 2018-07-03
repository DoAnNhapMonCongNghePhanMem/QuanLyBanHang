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
    public partial class PhieuXuat : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable tb;
        private DTO_ThongTinTaiKhoan taiKhoan;
        private DTO_NhanVienQuanLy nhanVien;
        private ArrayList dsDaiLy;
        private int[] dsIdDL;
        private float tongTien;
        public PhieuXuat()
        {
            InitializeComponent();
        }
        public PhieuXuat(DataTable Tb, DTO_ThongTinTaiKhoan tk, DTO_NhanVienQuanLy nv)
        {
            InitializeComponent();
            this.tb = Tb;
            taiKhoan = tk;
            nhanVien = nv;
          
            Load();
        }

        private void Load()
        {
            tongTien = 0;
            //tb = new DataTable();
            dsDaiLy = BUS_DaiLy.DsDaiLy();
            dsIdDL = new int[dsDaiLy.Count];

            foreach (DataRow r in tb.Rows)
            {
                tongTien = tongTien +(float)Convert.ToDouble(r[5].ToString());
            }
            int i = 0;
            foreach(DTO_DaiLy dl in dsDaiLy)
            {
                cbDaiLy.Items.Add(dl.TenDaiLy);
                dsIdDL[i] = dl.IdDL;
                i++;
            }
            cbDaiLy.SelectedIndex = 0;
            gvhang.DataSource = tb;
            txtTongTien.Text = tongTien.ToString();


            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gvhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < tb.Rows.Count)
            {
               
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            int idDaiLy = dsIdDL[cbDaiLy.SelectedIndex];
            DateTime ngayXuat = dtNgayLap.Value;
            //Console.WriteLine(ngayXuat.ToString("yyyy-MM-dd"));
            float tienCon = (float)Convert.ToDouble(txtTienCon.Text);
            float tienNo = BUS_DaiLy.GetTienNo(idDaiLy);
            float tienNoMoi = tienCon + tienNo;
            int kqUpdate = BUS_DaiLy.UpdateTienNo(idDaiLy, tienNoMoi);
            if (kqUpdate == 1)
            {
                string cmnd = taiKhoan.Cmnd;
                DTO_PhieuXuatHang phieuXuatHang = new DTO_PhieuXuatHang(0, ngayXuat, idDaiLy, cmnd);
                int idPhieuXuat = BUS_PhieuXuat.ThemPhieuXuatGetId(phieuXuatHang);
                foreach (DataRow r in tb.Rows)
                {
                    DTO_ChiTietXuat ctx = new DTO_ChiTietXuat(idPhieuXuat, (int)r[0], (int)r[2], (float)r[4], r[3].ToString(), (float)r[5]);
                    BUS_ChiTietXuat.ThemChiTietXuat(ctx);
                }
            }
            else
            {

            }


        }

        private void txtSoTienTra_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gvhang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < tb.Rows.Count)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTienCon.Text.Equals("") == false)
            {
                int idDaiLy = dsIdDL[cbDaiLy.SelectedIndex];
                DateTime ngayXuat = dtNgayLap.Value;
                //Console.WriteLine(ngayXuat.ToString("yyyy-MM-dd"));
                float tienCon = (float)Convert.ToDouble(txtTienCon.Text);
                float tienNo = BUS_DaiLy.GetTienNo(idDaiLy);
                Console.WriteLine(tienNo);
                float tienNoMoi = tienCon + tienNo;
                int kqUpdate = BUS_DaiLy.UpdateTienNo(idDaiLy, tienNoMoi);
                if (kqUpdate == 1)
                {
                    string cmnd = taiKhoan.Cmnd;
                    DTO_PhieuXuatHang phieuXuatHang = new DTO_PhieuXuatHang(0, ngayXuat, idDaiLy, cmnd);
                    int idPhieuXuat = BUS_PhieuXuat.ThemPhieuXuatGetId(phieuXuatHang);
                    foreach (DataRow r in tb.Rows)
                    {
                        int idMatHang = (int)r[0];
                        int soLuong =int.Parse(r[2].ToString());
                        float donGia = (float)Convert.ToDouble(r[4]);
                        string donViTinh = r[3].ToString();
                        float thanhTien = (float)Convert.ToDouble(r[5]);
                        // DTO_ChiTietXuat ctx = new DTO_ChiTietXuat(idPhieuXuat, (int)r[0], (int)r[2], (float)Convert.ToDouble(r[4]), r[3].ToString(), (float)Convert.ToDouble(r[5]));
                        DTO_ChiTietXuat ctx = new DTO_ChiTietXuat(idPhieuXuat,idMatHang, soLuong, donGia,donViTinh, thanhTien);
                        BUS_ChiTietXuat.ThemChiTietXuat(ctx);
                    }
                    MessageBox.Show("Xuất thành công");
                }else if (kqUpdate == 2)
                {
                    MessageBox.Show("Số tiền còn lại cộng với nợ cũ vượt quy định");
                }
                else
                {
                    MessageBox.Show("Xuất thất bại");
                }

                //tb.Columns.Add("Id", typeof(int));
                //tb.Columns.Add("Mặt hàng", typeof(string));
                //tb.Columns.Add("Số lượng", typeof(string));
                //tb.Columns.Add("đơn vị tính", typeof(string));
                //tb.Columns.Add("Đơn giá", typeof(string));
                //tb.Columns.Add("Thành tiền", typeof(string));
            }
            

        }

        private void txtSoTienTra_EditValueChanged_1(object sender, EventArgs e)
        {
            if(txtSoTienTra.Text.Equals("") == false && txtTongTien.Text.Equals("") == false)
            {
                float tongTien = (float)Convert.ToDouble(txtTongTien.Text);
                float tienTra = (float)Convert.ToDouble(txtSoTienTra.Text);
                if (txtSoTienTra.Text.Equals("") == false && tienTra <= tongTien)
                {
                    float tiencon = tongTien - tienTra;
                    txtTienCon.Text = tiencon.ToString();
                }
            }
            else
            {
                txtTienCon.Text = "";
            }
            
        }
    }
}
