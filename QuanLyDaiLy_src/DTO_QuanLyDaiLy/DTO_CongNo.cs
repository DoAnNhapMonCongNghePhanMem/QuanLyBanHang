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
        private float noDau;
        private float noCuoi;

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

        public DTO_CongNo(int Id,int Thang,float NoDau,float NoCuoi)
        {
            this.IdDaiLy = Id;
            this.Thang = Thang;
            this.NoDau = NoDau;
            this.NoCuoi = NoCuoi;
        }

      
    }
}
