using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyDaiLy;

namespace DAL_QuanLyDaiLy
{
    public class DAL_CongNo
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSCongNo()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM CongNo");
            int id;
            DateTime thang;
            float noDau;
            float noCuoi;
            float phatSinh;
            foreach (DataRow r in dt.Rows)
            {
                id = (int)r["IdMatHang"];
                thang =(DateTime) Convert.ToDateTime(r["TenMatHang"]);
                noDau = (float)Convert.ToDouble(r["NoDau"]);
                noCuoi= (float)Convert.ToDouble(r["NoCuoi"]);
                phatSinh= (float)Convert.ToDouble(r["PhatSinh"]);
                DTO_CongNo congNo = new DTO_CongNo(id, thang, noDau, noCuoi, phatSinh);
                arrList.Add(congNo);
            }

            return arrList;
        }
        /*
         * ThemCongNo trả về
         * 1:thành công
         * 0:thất bại
         */
        public static int ThemCongNo(int id,DateTime thang,float noDau,float noCuoi,float phatSinh)
        {
            int kq ;
           // string thangSql= thang.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("PR_InsertCongNo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdDaiLy", SqlDbType.Int).Value = id;

            //SqlParameter nameParameter = new SqlParameter("@Thang", SqlDbType.Date);
            //nameParameter.Direction = ParameterDirection.Input;
            //nameParameter.Value = Convert.ToDateTime(row["Thang"]);

            //cmd.Parameters.Add("@Thang", SqlDbType.Date).Value = thang;
            cmd.Parameters.Add("@NoDau", SqlDbType.Float).Value = noDau;
            cmd.Parameters.Add("@NoCuoi", SqlDbType.Float).Value = noCuoi;
            cmd.Parameters.Add("@PhatSinh", SqlDbType.Float).Value = phatSinh;
            try
            {
                conn.Open();
                kq = cmd.ExecuteNonQuery();
                return kq;
            }
            finally
            {
                conn.Close();
            }
        }
        
        /*
         * CapNhatCongNo trả về
         * 1:thành công
         * 0:thất bại
         */
        public static int CapNhatCongNo(DTO_CongNo congNo)
        {
            DateTime thang = congNo.Thang;
            string thangSql = thang.ToString("yyyy-MM-dd");
            string query = "update CongNo set Thang='" + thangSql + "',NoDau=" + congNo.NoDau + ",NoCuoi=" + congNo.NoCuoi + ",PhatSinh=" + congNo.PhatSinh + " where IdDaiLy = " + congNo.IdDaiLy;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }

    }
}
