using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_QuanLyDaiLy
{
    class DBSqlServerUtils
    {
        public static SqlConnection GetDBConnection()
        {

            //string dataSource,string database,string userName,string pass)
            //Data Source=DESKTOP-KG1KAOQ;Initial Catalog=QuanLyDaiLy;Integrated Security=True
            //Data Source=.;Initial Catalog=QuanLyDaiLy;Integrated Security=True
            //Data Source=DESKTOP-S7IROOQ;Initial Catalog=QuanLyDaiLy;User ID=sa;Password=123
            string connString = @"Data Source=.;Initial Catalog=QuanLyDaiLy;Integrated Security=True";
            //string connString = @"Data Source="+ dataSource + ";Initial Catalog="+database+ ";User ID="+userName+";Password="+pass;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
