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
    public class BUS_LoaiDL
    {
        public static ArrayList DsLoaiDL()
        {
            ArrayList al = DAL_LoaiDaiLy.DSLoaiDaiLy();
            return al;
        }
        public static string GetTenById(int id)
        {
            return DAL_LoaiDaiLy.GetTenById(id);
        }
        public static int ThemLoaiDL(string ten)
        {
            return DAL_LoaiDaiLy.ThemLoaiDaiLy(ten);
        }
        public static int XoaLoaiDL(int id)
        {
            return DAL_LoaiDaiLy.XoaLoaiDaiLy(id);
        }
        public static int CapNhatLoaiDL(DTO_LoaiDL l)
        {
            return DAL_LoaiDaiLy.CapNhatLoaiDaiLy(l);
        }

    }
}
