using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_NhanVienQuanLy
    {
        private string cmnd;
        private string tenNV;
        private DateTime ngaySinh;
        private string queQuan;
        private string sdt;

        

        public string tenNV1
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public DateTime ngaySinh1
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string queQuan1
        {
            get
            {
                return queQuan;
            }

            set
            {
                queQuan = value;
            }
        }

        public string sdt1
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
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

        public DTO_NhanVienQuanLy()
        {

        }
        public DTO_NhanVienQuanLy(string Cmnd,string TenNV,DateTime NgaySinh,string QueQuan,string Sdt)
        {
            this.cmnd = Cmnd;
            this.tenNV1 = TenNV;
            this.ngaySinh1 = NgaySinh;
            this.queQuan1 = QueQuan;
            this.sdt1 = Sdt;
        }

    }
}
