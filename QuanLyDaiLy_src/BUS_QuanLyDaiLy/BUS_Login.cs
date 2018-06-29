using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;


namespace BUS_QuanLyDaiLy
{
    public class BUS_Login
    {

        public static int kiemtradangnhap(string user,string pass)
        {

            return DAL_QuanLyTaiKhoan.KiemTraDangNhap(user, pass);
        }
            

    }
}
