using DAL_QuanLyDaiLy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyDaiLy;
namespace BUS_QuanLyDaiLy
{
    public class BUS_QuyDinhTienNo
    {
        public static ArrayList GetQuyDinhTienNo()
        {
             return DAL_QuyDinhTienNo.QDTienNo();
        }
        public static int CapNhatQuyDinh(DTO_QuyDinhTienNo qd)
        {
            return DAL_QuyDinhTienNo.CapNhatQuyDinhTienNo(qd);
        }
    }
}
