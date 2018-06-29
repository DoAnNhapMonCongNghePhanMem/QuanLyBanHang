using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;


namespace BUS_QuanLyDaiLy
{
    public class BUS_LoaiDL
    {
        public static ArrayList DsLoaiDL()
        {
            ArrayList al = DAL_LoaiDaiLy.DSLoaiDaiLy();
            return al;
        }

    }
}
