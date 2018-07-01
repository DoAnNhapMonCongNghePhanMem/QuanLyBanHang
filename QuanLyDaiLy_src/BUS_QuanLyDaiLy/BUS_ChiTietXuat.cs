using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_ChiTietXuat
    {
        public static int ThemChiTietXuat(DTO_ChiTietXuat ct)
        {
            return DAL_ChiTietXuat.ThemChiTietXuat(ct);
        }
    }
}
