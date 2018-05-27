using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyDaiLy
{
    public class DAL_LoaiDaiLy
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList GetLoaiDL()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM LoaiDaiLy ");
            int id;
            string ten;
            foreach (DataRow r in dt.Rows)
            {
                id = (int)r["IdLoaiDL"];
                ten = r["TenLoaiDL"].ToString();
                DTO_LoaiDL loaiDL = new DTO_LoaiDL(id, ten);
                arrList.Add(loaiDL);
            }

            return arrList;
        }
    }
}
