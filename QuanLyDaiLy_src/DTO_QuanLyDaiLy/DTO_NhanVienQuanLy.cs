using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_NhanVienQuanLy
    {
        private int idNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string queQuan;
        private string sdt;

        public int idNV1
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

        public DTO_NhanVienQuanLy()
        {

        }
        public DTO_NhanVienQuanLy(int idNV,string tenNV,DateTime ngaySinh,string queQuan,string sdt)
        {
            this.idNV1 = idNV;
            this.tenNV1 = tenNV;
            this.ngaySinh1 = ngaySinh;
            this.queQuan1 = queQuan;
            this.sdt1 = sdt;
        }

    }
}
