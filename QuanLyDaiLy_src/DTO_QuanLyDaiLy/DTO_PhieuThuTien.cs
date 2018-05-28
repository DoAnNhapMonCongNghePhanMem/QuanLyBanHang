using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_PhieuThuTien
    {
        private int idPhieuThu;
        private DateTime ngayThu;
        private float soTienThu;
        private int idDaiLy;
        private string cmnd;

        public int IdPhieuThu
        {
            get
            {
                return idPhieuThu;
            }

            set
            {
                idPhieuThu = value;
            }
        }

        public DateTime NgayThu
        {
            get
            {
                return ngayThu;
            }

            set
            {
                ngayThu = value;
            }
        }

        public float SoTienThu
        {
            get
            {
                return soTienThu;
            }

            set
            {
                soTienThu = value;
            }
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

        public DTO_PhieuThuTien()
        {

        }
        public DTO_PhieuThuTien(int idPhieuThu,DateTime ngayThu,float soTienThu, int idDaiLy,string cmnd)
        {
            this.IdPhieuThu = idPhieuThu;
            this.NgayThu = ngayThu;
            this.SoTienThu = soTienThu;
            this.IdDaiLy = idDaiLy;
            this.Cmnd = cmnd;
        }

    }
}
