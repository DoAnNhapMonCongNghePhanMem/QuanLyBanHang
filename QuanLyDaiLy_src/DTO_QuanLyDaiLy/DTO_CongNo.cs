using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_CongNo
    {
        private int idDaiLy;
        private int thang;
        private float tienNo;

       
        public DTO_CongNo(int id,int Thang,float tienno)
        {
            this.IdDaiLy = id;
            this.Thang = Thang;
            this.TienNo = tienno;
        }

        public int IdDaiLy
        {
            get
            {
                return idDaiLy;
            }

            set
            {
                idDaiLy = value;
            }
        }

        public int Thang
        {
            get
            {
                return thang;
            }

            set
            {
                thang = value;
            }
        }

        public float TienNo
        {
            get
            {
                return tienNo;
            }

            set
            {
                tienNo = value;
            }
        }
    }
}
