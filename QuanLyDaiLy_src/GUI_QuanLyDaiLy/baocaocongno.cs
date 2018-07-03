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
	public partial class BaoCaoCongNo: DevExpress.XtraEditors.XtraUserControl
	{
        private ArrayList congNo;
        private DataTable tb = new DataTable();
        public BaoCaoCongNo()
		{
            InitializeComponent();
            tb.Columns.Add("ID", typeof(int));
            tb.Columns.Add("Đại lý", typeof(string));
            tb.Columns.Add("Nợ đầu", typeof(float));
            tb.Columns.Add("Nợ cuối", typeof(float));
            Load();
		}

        private void cbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb.Clear();

            if (cbCN.SelectedIndex != -1)
            {
                int thang = int.Parse(cbCN.SelectedItem.ToString());
                congNo = BUS_BaoCaoCongNo.GetCongNo(thang);
                foreach (DTO_CongNo dso in congNo)
                {
                
                    string tendl = BUS_DaiLy.GetTenById(dso.IdDaiLy);
                    tb.Rows.Add(dso.IdDaiLy, tendl, dso.NoDau,dso.NoCuoi);
                }
                gvCN.DataSource = tb;

            }
        }
        private void Load()
        {
            int[] dsThang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cbCN.DataSource = dsThang;
            gvCN.DataSource = tb;
            gvCN.Columns["Id"].Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
