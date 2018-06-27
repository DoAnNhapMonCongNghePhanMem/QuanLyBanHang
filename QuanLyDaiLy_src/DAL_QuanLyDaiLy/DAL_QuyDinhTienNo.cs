using DTO_QuanLyDaiLy;
using System;
using System.Collections.Generic;
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
    }
}
