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
    public class BUS_MatHang
    {
        public static int ThemMatHang(string Ten)
        {
            return DAL_MatHang.ThemMatHang(Ten);
        }
        public static string GetTen(int id)
        {
            return DAL_MatHang.GetTen(id);
        }
        public static ArrayList DsMatHang()
        {
            return DAL_MatHang.DSMatHang();
        }
        public static int CapNhat(DTO_MatHang mh)
        {
            return DAL_MatHang.CapNhatMatHang(mh);
        }
        public static int Xoa(int id)
        {
            return DAL_MatHang.XoaMatHang(id);
        }
        public static ArrayList Search(string name)
        {
            return DAL_MatHang.search(name);
        }


    }
}
