using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_ChiTietXuat
    {
        private int idPhieuXuat;
        private int idMatHang;
        private int soLuong;
        private float donGia;
        private string donViTinh;
        private float thanhTien;

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

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
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

        public float ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        public DTO_ChiTietXuat()
        {

        }
        public DTO_ChiTietXuat(int idPhieuXuat,int idMatHang,int soLuong,float donGia,string donViTinh, float thanhTien)
        {
            this.IdPhieuXuat = idPhieuXuat;
            this.IdMatHang = idMatHang;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.DonViTinh = donViTinh;
            this.ThanhTien = thanhTien;
        }
    }
}
