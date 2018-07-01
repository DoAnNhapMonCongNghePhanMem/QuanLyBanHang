using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyDaiLy;
using System.Data;
using System.Collections;
using DTO_QuanLyDaiLy;

namespace BUS_QuanLyDaiLy
{
    public class BUS_PhieuThuTien
    {
        public static ArrayList DsPhieuThu()
        {
            ArrayList al = DAL_TGPhieuThuTien.DSPhieuThu();
            return al;
        }
        public static int ThemPhieuThu(DTO_PhieuThuTien p)
        {
            int al = DAL_PhieuThuTien.ThemPhieuThu(p);
            return al;
        }
        public static int XoaPhieuThu(int p)
        {
            int al = DAL_PhieuThuTien.XoaByIdDl(p);
            return al;
        }
        public static ArrayList search(string t)
        {
            ArrayList al = DAL_TGPhieuThuTien.search(t);
            return al;
        }
    }
}
