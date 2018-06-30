using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_NhanVien
    {
        public static string GetTenNV(string cmnd)
        {
            return DAL_QuanLyTaiKhoan.GetTenNhanVien(cmnd);
        }
        public static DTO_NhanVienQuanLy GetNhanVien(string cmnd)
        {
            return DAL_QuanLyTaiKhoan.GetNhanVien(cmnd);
        }
    }
}
