using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyDaiLy
{
    public partial class LoginDatabase : DevExpress.XtraEditors.XtraForm
    {
        public LoginDatabase()
        {
            InitializeComponent();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            string server=txtServer.Text;
            string dbName = txtDBName.Text;
            string user = txtUserName.Text;
            string pass = txtPass.Text;
            if(server.Equals("")==false && dbName.Equals("") == false && user.Equals("") == false
                && pass.Equals("") == false)
            {
                
            }
        }
    }
}