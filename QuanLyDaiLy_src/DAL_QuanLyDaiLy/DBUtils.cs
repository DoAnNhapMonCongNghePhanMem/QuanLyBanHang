using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyDaiLy
{
    class DBUtils
    {
        private static DBUtils DBConnection;


        public DBUtils()
        {

        }

        public static SqlConnection GetDBConnection()
        {
            string datasource = @"";
            string database = "";
            string username = "";
            string password = "";

            return DBSqlServerUtils.GetDBConnection(datasource,database,username,password);
        }
       

    }
}
