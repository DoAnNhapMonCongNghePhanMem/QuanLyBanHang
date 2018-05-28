using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_PhieuXuatHang
    {
        private int idPhieuXuat;
        private DateTime ngayXuat;
        private int idDaiLy;
        private string cmnd;

        public int IdPhieuXuat
        {
            get
            {
                return idPhieuXuat;
            }

            set
            {
                idPhieuXuat = value;
            }
        }

        public DateTime NgayXuat
        {
            get
            {
                return ngayXuat;
            }

            set
            {
                ngayXuat = value;
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

        public DTO_PhieuXuatHang()
        {

        }
        public DTO_PhieuXuatHang(int idPhieuXuat, DateTime ngayXuat, int idDaiLy, string cmnd)
        {
            this.IdPhieuXuat = idPhieuXuat;
            this.NgayXuat = ngayXuat;
            this.IdDaiLy = idDaiLy;
            this.Cmnd = cmnd;
        }
    }
}
