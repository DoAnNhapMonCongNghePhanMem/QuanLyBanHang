using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_ThongTinTaiKhoan
    {
        private string userName;
        private string pass;
        private string cmnd;
        private int phanQuyen;
        private int trangThai;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        

        public int PhanQuyen
        {
            get
            {
                return phanQuyen;
            }

            set
            {
                phanQuyen = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public DTO_ThongTinTaiKhoan()
        {

        }
        public DTO_ThongTinTaiKhoan(string userName,string pass,string cmnd,int phanQuyen,int trangThai)
        {
            this.UserName = userName;
            this.Pass = pass;
            this.Cmnd = cmnd;
            this.PhanQuyen = phanQuyen;
            this.TrangThai = trangThai;
        }

    }
}
