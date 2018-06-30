using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_QuyDinhMatHang
    {
        public static ArrayList GetQuyDinhMatHang()
        {
            return DAL_QuyDinhMatHang.QDMatHang();
        }
        public static int CapNhatQuyDinh(DTO_QuyDinhMatHang qd)
        {
            return DAL_QuyDinhMatHang.CapNhatQuyDinhMatHang(qd);
        }
    }
}
