using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLyDaiLy
{
    public class DAL_QuanLyTaiKhoan
    {
        private SqlConnection conn=DBUtils.GetDBConnection();


        public DAL_QuanLyTaiKhoan()
        {

        }
        public int KiemTraKetNoi(string userName,string pass)
        {
            SqlCommand cmd = new SqlCommand("PR_CheckLogin", conn);
            //cmd.CommandText = "PR_CheckLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@OutPut", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@OutPut"].Value;
                return kq;
            }
            finally
            {
                conn.Close();
            }
            
        }
        
       
    }
}
