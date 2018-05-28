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
        private float noDau, noCuoi, phatSinh;

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

        public DTO_CongNo()
        {
            
        }
        public DTO_CongNo(int id,int thang,float nodau,float nocuoi,float phatsinh)
        {
            this.IdDaiLy = id;
            this.Thang = thang;
            this.NoDau = nodau;
            this.NoCuoi = nocuoi;
            this.PhatSinh = phatsinh;
        }
       
    }
}
