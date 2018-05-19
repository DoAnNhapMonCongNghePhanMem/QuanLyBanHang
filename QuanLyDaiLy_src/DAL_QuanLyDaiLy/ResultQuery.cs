using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyDaiLy
{
    class ResultQuery
    {
        private ResultQuery getResult;

        internal ResultQuery GetResult
        {
            get
            {
                if (getResult == null)
                {
                    getResult = new ResultQuery();
                }
                return getResult;
            }

            set
            {
                getResult = value;
            }
        }
        public DataTable QueryGetDataTable(string query,Object[] arrParameter=null)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            string[] arrQuery = query.Split(' ');
            int i = 0;
            foreach(string items in arrQuery)
            {
                if (items.Contains('@'))
                {
                    cmd.Parameters.AddWithValue(items, arrParameter[i]);
                    i++;
                }
               
            }
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
