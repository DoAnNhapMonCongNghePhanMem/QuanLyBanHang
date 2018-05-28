using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_Quan
    {
        private int idQuan;
        private string tenQuan;

        public DTO_Quan()
        {

        }
        public DTO_Quan(int id,string ten)
        {
            this.idQuan = id;
            this.tenQuan = ten;
        }

        public int IdQuan
        {
            get
            {
                return idQuan;
            }

            set
            {
                idQuan = value;
            }
        }

        public string TenQuan
        {
            get
            {
                return tenQuan;
            }

            set
            {
                tenQuan = value;
            }
        }
    }
}
