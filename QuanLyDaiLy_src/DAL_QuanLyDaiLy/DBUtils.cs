using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLyDaiLy
{
    class DBUtils
    {
        //private static DBUtils DBConnection;
        private string dataSource;
        private string database;
        private string userName;
        private string pass;

        public string DataSource
        {
            get
            {
                return dataSource;
            }

            set
            {
                dataSource = value;
            }
        }

        public string Database
        {
            get
            {
                return database;
            }

            set
            {
                database = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public DBUtils()
        {

        }

        public DBUtils(string dataSource, string database, string userName, string pass)
        {
            this.dataSource = dataSource;
            this.database = database;
            this.userName = userName;
            this.pass = pass;
        }

        public static SqlConnection GetDBConnection()
        {

           
            //string serverName = ConfigurationManager.AppSettings["Server"].ToString();
            //string databaseName = ConfigurationManager.AppSettings["Database"].ToString();
            //string userName = ConfigurationManager.AppSettings["Username"].ToString();
            //string passWord = ConfigurationManager.AppSettings["Password"].ToString();

            return DBSqlServerUtils.GetDBConnection();
        }
       

    }
}
