using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_TGPhieuThuTien
    {

        private string tendaily, sdt, diachi, cmnd;
        private DateTime ngayThu;
        private float soTienThu;
        private int idPhieuThu;
        public DTO_TGPhieuThuTien(int id, string ten, DateTime ngayThu, float soTienThu, string diachi, string cmnd,string sdt)
        {
            this.idPhieuThu = id;
            this.tendaily = ten;
            this.NgayThu = ngayThu;
            this.SoTienThu = soTienThu;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.sdt = sdt;
        }
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
        public string CMND
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
        public string SDT
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
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }
        public string TenDaiLy
        {
            get
            {
                return tendaily;
            }

            set
            {
                tendaily = value;
            }
        }
    }
}
