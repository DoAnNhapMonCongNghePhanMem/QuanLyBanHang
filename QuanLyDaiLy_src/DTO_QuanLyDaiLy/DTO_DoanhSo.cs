using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_DoanhSo
    {
        private int idDaiLy;
        private int thang;
        private float tongDoanhSo;
        private int soPhieuXuat;
        private float tiLe;

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

        public float TongDoanhSo
        {
            get
            {
                return tongDoanhSo;
            }

            set
            {
                tongDoanhSo = value;
            }
        }

        public int SoPhieuXuat
        {
            get
            {
                return soPhieuXuat;
            }

            set
            {
                soPhieuXuat = value;
            }
        }

        public float TiLe
        {
            get
            {
                return tiLe;
            }

            set
            {
                tiLe = value;
            }
        }

        public DTO_DoanhSo()
        {

        }
        public DTO_DoanhSo(int idDaiLy,int thang,float tongDoanhSo,int soPhieuXuat,float tiLe)
        {
            this.idDaiLy = idDaiLy;
            this.thang = thang;
            this.tongDoanhSo = tongDoanhSo;
            this.soPhieuXuat = soPhieuXuat;
            this.tiLe = tiLe;
        }
    }
}
