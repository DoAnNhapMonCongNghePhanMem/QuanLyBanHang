using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_TGPhieuXuat
    {
        string tenmh,donvi;
        int soluong;
        float dongia, thanhtien;
        public DTO_TGPhieuXuat(string tenmh,string donvi,int soluong,float dongia,float thanhtien)
        {
            this.tenmh = tenmh;
            this.donvi = donvi;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }

        public string TenMatHang
        {
            get
            {
                return tenmh;
            }

            set
            {
                tenmh = value;
            }
        }
        public string DonViTinh
        {
            get
            {
                return donvi;
            }

            set
            {
                donvi = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
        public float DonGia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }
        public float ThanhTien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }
    }
}
