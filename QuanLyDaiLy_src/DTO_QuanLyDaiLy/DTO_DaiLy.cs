using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_DaiLy
    {
        private int idDL, idLoaiDL;
        float tienNo;
        private string tenDaiLy, sdt, diaChi, ngayNhan, cmnd, quan;
        public DTO_DaiLy()
        {

        }
        public DTO_DaiLy(int idDL, int idLoaiDL, string tenDaiLy, string sdt, string diaChi, string ngayNhan, string cmnd, string quan, float tienNo)
        {
            this.idDL = idDL;
            this.idLoaiDL = idLoaiDL;
            this.tenDaiLy = tenDaiLy;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.ngayNhan = ngayNhan;
            this.cmnd = cmnd;
            this.quan = quan;
            this.tienNo = tienNo;
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

        public string NgayNhan
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

        public string Quan
        {
            get
            {
                return quan;
            }

            set
            {
                quan = value;
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

    }
}
