using DTO_QuanLyDaiLy;
using System;
using System.Collections.Generic;
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
    }
}
