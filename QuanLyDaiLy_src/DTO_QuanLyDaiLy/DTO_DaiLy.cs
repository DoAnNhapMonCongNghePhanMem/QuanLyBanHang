using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_DaiLy
    {
        private int idDL, idLoaiDL,idQuan;
        float tienNo;
        private string tenDaiLy, sdt, diaChi, cmnd;
        DateTime ngayNhan;

        public string TenDaiLy
        {
            get
            {
                return tenDaiLy;
            }

            set
            {
                tenDaiLy = value;
            }
        }
        



        public string Sdt
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

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public DateTime NgayNhan
        {
            get
            {
                return ngayNhan;
            }

            set
            {
                ngayNhan = value;
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
        public int IdDL
        {
            get
            {
                return idDL;
            }

            set
            {
                idDL = value;
            }
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

       

        public DTO_DaiLy()
        {

        }
        public DTO_DaiLy(int idDL, int idLoaiDL, string tenDaiLy, string sdt, string diaChi, int idquan, DateTime ngayNhan, string cmnd, float tienNo)
        {
            this.IdDL = idDL;
            this.IdLoaiDL = idLoaiDL;
            this.TenDaiLy = tenDaiLy;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.NgayNhan = ngayNhan;
            this.Cmnd = cmnd;
            this.IdQuan = idquan;
            this.TienNo = tienNo;
        }
        

    }
}
