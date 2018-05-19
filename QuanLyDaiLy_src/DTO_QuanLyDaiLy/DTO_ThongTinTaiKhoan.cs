using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    class DTO_ThongTinTaiKhoan
    {
        private string userName;
        private string pass;
        private int idNV;
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

        public int IdNV
        {
            get
            {
                return idNV;
            }

            set
            {
                idNV = value;
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

        public DTO_ThongTinTaiKhoan()
        {

        }
        public DTO_ThongTinTaiKhoan(string userName,string pass,int idNV,int phanQuyen,int trangThai)
        {
            this.UserName = userName;
            this.Pass = pass;
            this.IdNV = idNV;
            this.PhanQuyen = phanQuyen;
            this.TrangThai = trangThai;
        }

    }
}
