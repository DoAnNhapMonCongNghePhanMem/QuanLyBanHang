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
    public class BUS_BaoCaoDoanhSo
    {
        public static ArrayList GetDoanhSo(int thang)
        {
            foreach(DTO_DoanhSo ds in DAL_DoanhSo.DoanhSo(7))
            {
                Console.WriteLine(ds.IdDaiLy);
            }
            return DAL_DoanhSo.DoanhSo(thang);
        }
    }
}
