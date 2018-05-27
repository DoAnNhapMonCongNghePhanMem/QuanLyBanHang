using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_MatHang
    {
        private int idMatHang;
        private string tenMatHang;

        public DTO_MatHang()
        {

        }
        public DTO_MatHang(int id,string ten)
        {
            this.idMatHang = id;
            this.tenMatHang = ten;
        }
        public int IdMatHang
        {
            get
            {
                return idMatHang;
            }

            set
            {
                idMatHang = value;
            }
        }

        public string TenMatHang
        {
            get
            {
                return tenMatHang;
            }

            set
            {
                tenMatHang = value;
            }
        }
    }
}
