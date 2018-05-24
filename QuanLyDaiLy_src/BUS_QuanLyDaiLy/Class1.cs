using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyDaiLy
{
    class Class1
    {
	public int KiemTraTaiKhoan(string user,string pass)
        {
            DAL_QuanLyTaiKhoan kt = new DAL_QuanLyTaiKhoan();
            int a=kt.KiemTraKetNoi(user, pass);
            return a;
        }
    }
}
