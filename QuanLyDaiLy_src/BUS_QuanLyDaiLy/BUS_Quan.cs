using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_Quan
    {
        public static ArrayList DSquan()
        {
            ArrayList al = DAL_Quan.DSQuan();
            return al;
        }
        public static string GetTen(int id)
        {
            return DAL_Quan.GetTenById(id);
        }
        public static int ThemQuan(string ten)
        {
            return DAL_Quan.ThemQuan(ten);
        }
        public static int XoaQuan(int id)
        {
            return DAL_Quan.XoaQuan(id);
        }
        public static int CapNhatQuan(DTO_Quan q)
        {
            return DAL_Quan.CapNhatQuan(q);
        }
    }
}
