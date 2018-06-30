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
    public class DAL_LoaiDaiLy
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSLoaiDaiLy()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM LoaiDaiLy ");
            int id;
            string ten;
            foreach (DataRow r in dt.Rows)
            {
                id = (int)r["IdLoaiDL"];
                ten = r["TenLoaiDL"].ToString();
                DTO_LoaiDL loaiDL = new DTO_LoaiDL(id, ten);
                arrList.Add(loaiDL);
            }

            return arrList;
        }
        //public List<DAL_DaiLy> search(string name)
        //{
        //    List<DAL_DaiLy> arrList = new List<DAL_DaiLy>();
        //    DataTable dt = new DataTable();
        //    string query = "select * from DaiLy where TenDaiLy =" + name;
        //    dt = ResultQuery.GetTableResult(conn, query);
        //    int id;
        //    string ten;
        //    foreach (DataRow r in dt.Rows)
        //    {
        //        id = (int)r["IdLoaiDL"];
        //        ten = r["TenLoaiDL"].ToString();
        //        DTO_LoaiDL loaiDL = new DTO_LoaiDL(id, ten);
        //        arrList.Add(loaiDL);
        //    }

        //    return arrList;
        //}

        /*
         * ThemLoaiDaiLy trả về 
         * 1:thành công
         * 2:số loại đại lý vượt quá quy định
         * 3:Tên loại đại lý đã tồn tại
         */
        public static int ThemLoaiDaiLy(string tenLoaiDL)
        {
            int kq;
            SqlCommand cmd = new SqlCommand("PR_InsertLoaiDaiLy", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenLoaiDL", SqlDbType.NVarChar).Value = tenLoaiDL;
            cmd.Parameters.Add("@out", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                kq = (int)cmd.Parameters["@out"].Value;
                return kq;
            }
            finally
            {
                conn.Close();
            }
        }
        /*
         * XoaLoaiDaiLy trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int XoaLoaiDaiLy(int id)
        {
            string query = "delete LoaiDaiLy where IdLoaiDL=" + id;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        /*
         * CapNhatLoaiDaiLy trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int CapNhatLoaiDaiLy(DTO_LoaiDL loaiDL)
        {
            string query = "update LoaiDaiLy set TenLoaiDL =N'" + loaiDL.TenLoaiDL + "' where IdLoaiDL=" +loaiDL.IdLoaiDL;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }

        public static string GetTenById(int id)
        {
            //DTO_LoaiDL loaidl = null;
            string query = "select TenLoaiDL from LoaiDaiLy where IdLoaiDL=" + id;
            DataTable dt = ResultQuery.GetTableResult(conn,query);
            //foreach (DataRow item in dt.Rows)
            //{
            //    loaidl = new DTO_LoaiDL(item);
            //    return loaidl;
            //}
            //return loaidl;
            DataRow r = dt.Rows[0];
            return r["TenLoaiDL"].ToString();
        }
    }
}
