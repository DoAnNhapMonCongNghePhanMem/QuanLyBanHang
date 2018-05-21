using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_LoaiDL
    {
        private int idLoaiDL;
        private string tenLoaiDL;
        public DTO_LoaiDL()
        {

        }
        public DTO_LoaiDL(int idLoaiDL , string tenLoaiDL)
        {
            this.IdLoaiDL = idLoaiDL;
            this.TenLoaiDL = tenLoaiDL;
        }

        public int IdLoaiDL
        {
            get
            {
                return idLoaiDL;
            }

            set
            {
                idLoaiDL = value;
            }
        }

        public string TenLoaiDL
        {
            get
            {
                return tenLoaiDL;
            }

            set
            {
                tenLoaiDL = value;
            }
        }
    }
}
