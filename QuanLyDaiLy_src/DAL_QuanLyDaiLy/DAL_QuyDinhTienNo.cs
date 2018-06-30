using DTO_QuanLyDaiLy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyDaiLy
{
    public class DAL_QuyDinhTienNo
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static int CapNhatQuyDinhTienNo(DTO_QuyDinhTienNo qd)
        {
            string query = "update QuyDinhTienNo set TienNoToiDa="+qd.TienNoToiDa+" where IdLoaiDL="+qd.IdLoaiDL;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static ArrayList QDTienNo()
        {
            ArrayList arr = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM QuyDinhTienNo");
            foreach (DataRow r in dt.Rows)
            {
                DTO_QuyDinhTienNo qd = new DTO_QuyDinhTienNo();
                qd.IdLoaiDL = (int)r["IdLoaiDL"];
                qd.TienNoToiDa = (float) Convert.ToDouble(r["TienNoToiDa"]);
                arr.Add(qd);
            }
            return arr;
        }

    }
}
