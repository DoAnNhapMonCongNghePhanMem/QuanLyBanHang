using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_QuanLyTaiKhoan
    {
        
        public static DTO_ThongTinTaiKhoan GetTaiKhoan(string user,string pass)
        {
            return DAL_QuanLyTaiKhoan.GetTaiKhoan(user, pass);
        }
        public static int KiemTraLogin(string user,string pass)
        {
            return DAL_QuanLyTaiKhoan.KiemTraDangNhap(user, pass);
        }
        public static int CapNhatMatKhau(string user,string passCu,string passMoi)
        {
            return DAL_QuanLyTaiKhoan.CapNhatMatKhau(user, passCu, passMoi);
        }
        public static int DangKi(string cmnd, string tenNV, string ngaySinh, string queQuan, string sdt, string userName, string pass, int phanQuyen, int trangThai)
        {
            return DAL_QuanLyTaiKhoan.KiemTraDangKy( cmnd,  tenNV,  ngaySinh,  queQuan,  sdt,  userName,  pass, phanQuyen, trangThai);
        }

    }
}
