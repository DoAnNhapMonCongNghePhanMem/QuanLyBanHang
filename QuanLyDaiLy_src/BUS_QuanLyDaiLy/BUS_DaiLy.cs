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
    public class BUS_DaiLy
    {
        public static ArrayList DsDaiLy()
        {
            ArrayList al = DAL_DaiLy.DsDaiLy();
            return al;
        }
        public static ArrayList Search(string t)
        {
            ArrayList al = DAL_DaiLy.search(t);
            return al;
        }
        public static int Themdaily(DTO_DaiLy dl)
        {
            int a = DAL_DaiLy.ThemDaiLy(dl);
            return a;
        }
        public static int XoaDaiLy(int id)
        {
            int a = DAL_DaiLy.XoaDaiLy(id);
            return a;
        }
        public static int SuaDaiLy(DTO_DaiLy dl)
        {
            int a = DAL_DaiLy.SuaDaiLy(dl);
            return a;
        }
        public static string GetTenById(int id)
        {
            return DAL_DaiLy.GetTen(id);
        }
        public static int UpdateTienNo(int idDL,float tienNo)
        {
            return DAL_DaiLy.UpdateTienNo(idDL, tienNo);
        }
        public static float GetTienNo(int id)
        {
            return DAL_DaiLy.GetTienNo(id);
        }
    }
}
