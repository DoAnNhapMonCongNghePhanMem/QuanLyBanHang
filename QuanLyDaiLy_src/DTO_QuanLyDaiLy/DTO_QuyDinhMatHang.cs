using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_QuyDinhMatHang
    {
        private int idMatHang;
        private string donViTinh;
        private float donGia;

        public int IdMatHang
        {
            get
            {
                return idMatHang;
            }

            set
            {
                idMatHang = value;
            }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public DTO_QuyDinhMatHang(int IdMatHang,string DonViTinh,float DonGia)
        {
            this.IdMatHang = IdMatHang;
            this.DonViTinh = DonViTinh;
            this.DonGia = DonGia;
        }
        public DTO_QuyDinhMatHang()
        {
           
        }
    }
}
