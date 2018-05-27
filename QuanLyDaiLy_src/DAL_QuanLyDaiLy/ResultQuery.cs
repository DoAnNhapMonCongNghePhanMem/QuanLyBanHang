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

        public static int ProcGetResult(SqlConnection conn, string proc, string[] arrInQuery, string result, Object[] arrInParams)
        {
            int kq;
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            foreach (string itemsIn in arrInQuery)
            {
                cmd.Parameters.AddWithValue(itemsIn, arrInParams[i]);
                cmd.Parameters[itemsIn].Direction = ParameterDirection.Input;
                i++;
            }
            //for (int j = 0; j < arrInQuery.Length; j++)
            //{
            //    cmd.Parameters.AddWithValue(arrInQuery[j], arrInParams[j]);
            //    cmd.Parameters[arrInQuery[j]].Direction = ParameterDirection.Input;
            //    //cmd.Parameters.AddWithValue("@TenDL", tenDL);
            //    //cmd.Parameters["@TenDL"].Direction = ParameterDirection.Input;
            //}
            cmd.Parameters.Add(result, SqlDbType.Int).Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                kq = (int)cmd.Parameters[result].Value;
                return kq;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable GetTableResult(SqlConnection conn, string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            finally
            {
                conn.Close();
            }

        }
        public static int GetResultQuery(SqlConnection conn, string query, object[] values = null)
        {
            int result;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;
                //if (values != null)
                //{
                //    string[] listPara = query.Split(' ');
                //    int i = 0;
                //    foreach (string item in listPara)
                //    {
                //        if (item.Contains('@'))
                //        {
                //            cmd.Parameters.AddWithValue(item, values[i]);
                //            i++;
                //        }
                //    }
                //}
                result = cmd.ExecuteNonQuery();
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
////string proc = "PR_InsertDl";
////string[] arrInQuery = { "@TenDL", "@SDT", "@DiaChi", "@NgayTiepNhan", "@TenLoaiDL", "@CMND", "@Quan" };
////object result = "@result";
////Object[] arrInParams = { tenDL, sdt, diaChi, ngayNhan, tenDL, cmnd, quan };
////kq = ResultQuery.ProcGetResult(conn,proc, arrInQuery, result, arrInParams);
////Console.WriteLine(arrInQuery.Length + " " + arrInQuery[6]);
////return kq;

//cmd.Parameters.AddWithValue("@TenDL", tenDL);
//cmd.Parameters["@TenDL"].Direction = ParameterDirection.Input;
//cmd.Parameters.AddWithValue("@SDT", sdt);
//cmd.Parameters["@SDT"].Direction = ParameterDirection.Input;
//cmd.Parameters.AddWithValue("@DiaChi", diaChi);
//cmd.Parameters["@DiaChi"].Direction = ParameterDirection.Input;
//cmd.Parameters.AddWithValue("@NgayTiepNhan", ngayNhan);
//cmd.Parameters["@NgayTiepNhan"].Direction = ParameterDirection.Input;
//cmd.Parameters.AddWithValue("@TenLoaiDL", loaiDL);
//cmd.Parameters["@TenLoaiDL"].Direction = ParameterDirection.Input;
//cmd.Parameters.AddWithValue("@CMND", cmnd);
//cmd.Parameters["@CMND"].Direction = ParameterDirection.Input;
//cmd.Parameters.AddWithValue("@Quan", quan);
//cmd.Parameters["@Quan"].Direction = ParameterDirection.Input;
//cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
//try
//{
//    conn.Open();
//    cmd.ExecuteNonQuery();
//    kq = (int)cmd.Parameters["@result"].Value;
//    return kq;
//}
//finally
//{
//    conn.Close();
//}