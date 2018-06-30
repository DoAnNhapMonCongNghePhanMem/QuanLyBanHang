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

namespace QuanLyDaiLy
{
    public partial class QuyChe : DevExpress.XtraEditors.XtraUserControl
    {
        public QuyChe()
        {
            InitializeComponent();
            QDTienNo qdtn = new QDTienNo();
            pnlQuyChe.Controls.Add(qdtn);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QDTienNo qdtn=new QDTienNo();
            pnlQuyChe.Controls.RemoveAt(0);
            pnlQuyChe.Controls.Add(qdtn);

            
        }

        private void btnQDMatHang_Click(object sender, EventArgs e)
        {
            QDMatHang qdtn = new QDMatHang();
            pnlQuyChe.Controls.RemoveAt(0);
            pnlQuyChe.Controls.Add(qdtn);
        }

        private void btnToChuc_Click(object sender, EventArgs e)
        {
            QCToChuc qdtn = new QCToChuc();
            pnlQuyChe.Controls.RemoveAt(0);
            pnlQuyChe.Controls.Add(qdtn);
        }
    }
}
