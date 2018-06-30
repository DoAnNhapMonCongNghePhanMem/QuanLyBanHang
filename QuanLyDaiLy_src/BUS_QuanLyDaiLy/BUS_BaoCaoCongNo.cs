using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using System.Collections;

namespace BUS_QuanLyDaiLy
{
    public class BUS_BaoCaoCongNo
    {
        public static ArrayList GetCongNo(int thang)
        {
            return DAL_CongNo.CongNo(thang);
        }
    }
}
