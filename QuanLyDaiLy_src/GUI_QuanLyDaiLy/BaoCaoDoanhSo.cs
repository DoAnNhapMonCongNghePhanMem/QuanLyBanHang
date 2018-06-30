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
using System.Collections;
using BUS_QuanLyDaiLy;
using DTO_QuanLyDaiLy;

namespace QuanLyDaiLy
{
    public partial class BaoCaoDoanhSo : DevExpress.XtraEditors.XtraUserControl
    {
        private ArrayList doanhSo;
        private DataTable tb=new DataTable();
        int id = -1;
        public BaoCaoDoanhSo()
        {
            InitializeComponent();
            tb.Columns.Add("ID", typeof(int));
            tb.Columns.Add("Đại lý", typeof(string));
            tb.Columns.Add("Số phiếu xuất", typeof(int));
            tb.Columns.Add("Tổng giá trị", typeof(float));
            tb.Columns.Add("tỷ lệ", typeof(string));
            Load();
        }

        private void Load()
        {
            //doanhSo= BUS_BaoCaoDoanhSo.GetDoanhSo(1);

            int[] dsThang= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cbThang.DataSource = dsThang;
            gvDoanhSo.DataSource = tb;
            gvDoanhSo.Columns["Id"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb.Clear();
         
            if (cbThang.SelectedIndex!=-1){
                int thang = int.Parse(cbThang.SelectedItem.ToString());
                doanhSo = BUS_BaoCaoDoanhSo.GetDoanhSo(thang);
                foreach (DTO_DoanhSo dso in doanhSo)
                {
                    string tendl = BUS_DaiLy.GetTenById(dso.IdDaiLy);
                    tb.Rows.Add(dso.IdDaiLy, tendl, dso.SoPhieuXuat, dso.TongDoanhSo, dso.TiLe+"%");
                }
                gvDoanhSo.DataSource = tb;

            }
            
        }

        private void cbThang_SelectedValueChanged(object sender, EventArgs e)
        {
           // Console.WriteLine(cbThang.SelectedItem);
        }
    }
}
