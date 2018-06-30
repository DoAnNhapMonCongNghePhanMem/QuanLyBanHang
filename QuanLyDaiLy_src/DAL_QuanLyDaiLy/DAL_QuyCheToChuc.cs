using DTO_QuanLyDaiLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyDaiLy
{
    public class DAL_QuyCheToChuc
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        /*
         * trả về 0: update không thành không
         * trả về #0 : thành công
         */
        public static int SuaQuyChe(DTO_QuyCheToChuc qc)
        {
            string query = "update QuyCheToChuc set SoLoaiDaiLy=" + qc.SoLoaiDaiLy + ",SoDaiLyToiDa=" + qc.SoDaiLyToiDa +
                ",SoMatHang=" + qc.SoMatHang + ",SoQuan=" + qc.SoMatHang;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static DTO_QuyCheToChuc GetQuyChe()
        {
            DTO_QuyCheToChuc qc = new DTO_QuyCheToChuc();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM QuyCheToChuc");
            foreach (DataRow r in dt.Rows)
            {
                qc.SoLoaiDaiLy = (int)r["SoLoaiDaiLy"];
                qc.SoDaiLyToiDa = (int)r["SoDaiLyToiDa"];
                qc.SoMatHang = (int)r["SoMatHang"];
                qc.SoQuan = (int)r["SoQuan"];
            }
            return qc;
        }
    }

}
