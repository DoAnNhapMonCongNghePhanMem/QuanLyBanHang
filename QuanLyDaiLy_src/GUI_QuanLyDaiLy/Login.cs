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
using BUS_QuanLyDaiLy;

namespace QuanLyDaiLy
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string user = txtPassWord.Text;
            string pass = txtuserName.Text;
            int login = BUS_Login.kiemtradangnhap(user, pass);
            if (login == 0)
            {
                TrangChuQuanLy f = new TrangChuQuanLy();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (login == 1)
            {
                MessageBox.Show("user khong chinh xac");
            }
            else if (login == 2)
            {
                MessageBox.Show("pass khonh chinh xac");
            }
            else
            {
                MessageBox.Show("ban bi kich boi admin");
            }
        }
    }
}