using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;

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
    }
}
