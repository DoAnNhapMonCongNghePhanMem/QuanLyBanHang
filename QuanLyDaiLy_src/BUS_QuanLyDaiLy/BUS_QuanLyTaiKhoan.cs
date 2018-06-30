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
    }
}
