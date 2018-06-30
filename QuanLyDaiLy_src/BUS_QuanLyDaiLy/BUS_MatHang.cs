using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using BUS_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_MatHang
    {
        public static int ThemMatHang(string Ten)
        {
            return DAL_MatHang.ThemMatHang(Ten);
        }
        public static string GetTen(int id)
        {
            return DAL_MatHang.GetTen(id);
        }
    }
}
