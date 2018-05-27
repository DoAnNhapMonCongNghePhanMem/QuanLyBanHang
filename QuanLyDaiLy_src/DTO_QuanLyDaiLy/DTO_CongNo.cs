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
        private DateTime thang;
        private float noDau, noCuoi, phatSinh;

        public DTO_CongNo()
        {

        }
        public DTO_CongNo(int id,DateTime thang,float nodau,float nocuoi,float phatsinh)
        {
            this.idDaiLy = id;
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

        public DateTime Thang
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

        public float NoDau
        {
            get
            {
                return noDau;
            }

            set
            {
                noDau = value;
            }
        }

        public float NoCuoi
        {
            get
            {
                return noCuoi;
            }

            set
            {
                noCuoi = value;
            }
        }

        public float PhatSinh
        {
            get
            {
                return phatSinh;
            }

            set
            {
                phatSinh = value;
            }
        }
    }
}
