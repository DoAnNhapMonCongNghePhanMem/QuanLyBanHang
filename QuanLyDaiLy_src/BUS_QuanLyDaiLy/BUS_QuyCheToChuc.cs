using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyDaiLy;
using DAL_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_QuyCheToChuc
    {
        public static int CapNhatQuyChe(DTO_QuyCheToChuc qc)
        {
            return DAL_QuyCheToChuc.SuaQuyChe(qc);
        }
        public static DTO_QuyCheToChuc GetQuyChe()
        {
            return DAL_QuyCheToChuc.GetQuyChe();
        }
    }
}
