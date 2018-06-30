using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_QuyDinhTienNo
    {
        private int idLoaiDL;
	    private float tienNoToiDa;
        public DTO_QuyDinhTienNo(int IdLoaiDL,float TienNoToiDa)
        {
            this.IdLoaiDL = IdLoaiDL;
            this.TienNoToiDa = TienNoToiDa;
        }
        public DTO_QuyDinhTienNo()
        {
            this.IdLoaiDL = IdLoaiDL;
            this.TienNoToiDa = TienNoToiDa;
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

        public float TienNoToiDa
        {
            get
            {
                return tienNoToiDa;
            }

            set
            {
                tienNoToiDa = value;
            }
        }
    }
}
