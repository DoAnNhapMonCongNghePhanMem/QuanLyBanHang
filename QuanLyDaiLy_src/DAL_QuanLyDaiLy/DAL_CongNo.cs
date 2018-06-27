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
        public DAL_CongNo()
        {
          
        }
        private static SqlConnection conn = DBUtils.GetDBConnection();
        //public static ArrayList DSCongNo()
        //{
        //    ArrayList arrList = new ArrayList();
        //    DataTable dt = new DataTable();
        //    dt = ResultQuery.GetTableResult(conn, "SELECT * FROM CongNo");
        //    int id;
        //    int thang;
        //    float noDau;
        //    float noCuoi;
        //    float phatSinh;
        //    foreach (DataRow r in dt.Rows)
        //    {
        //        id = (int)r["IdMatHang"];
        //        thang = (int)(r["TenMatHang"]);
        //        noDau = (float)Convert.ToDouble(r["NoDau"]);
        //        noCuoi= (float)Convert.ToDouble(r["NoCuoi"]);
        //        phatSinh= (float)Convert.ToDouble(r["PhatSinh"]);
        //        DTO_CongNo congNo = new DTO_CongNo(id, thang, noDau, noCuoi, phatSinh);
        //        arrList.Add(congNo);
        //    }

        //    return arrList;
        //}
        ///*
        // * ThemCongNo trả về
        // * 1:thành công
        // * 0:thất bại
        // */
        //public static int ThemCongNo(DTO_CongNo congNo)
        //{
        //    int kq ;

        //    SqlCommand cmd = new SqlCommand("PR_InsertCongNo", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@IdDaiLy", SqlDbType.Int).Value = congNo.IdDaiLy;
        //    cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = congNo.Thang;
        //    cmd.Parameters.Add("@NoDau", SqlDbType.Float).Value = congNo.NoDau;
        //    cmd.Parameters.Add("@NoCuoi", SqlDbType.Float).Value = congNo.NoCuoi;
        //    cmd.Parameters.Add("@PhatSinh", SqlDbType.Float).Value = congNo.PhatSinh;
        //    try
        //    {
        //        conn.Open();
        //        kq = cmd.ExecuteNonQuery();
        //        return kq;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        ///*
        // * CapNhatCongNo trả về
        // * 1:thành công
        // * 0:thất bại
        // */
        //public static int CapNhatCongNo(DTO_CongNo congNo)
        //{
        //    string query = "update CongNo set Thang=" + congNo.Thang + ",NoDau=" + congNo.NoDau + ",NoCuoi=" + congNo.NoCuoi + ",PhatSinh=" + congNo.PhatSinh + " where IdDaiLy = " + congNo.IdDaiLy;
        //    int result = ResultQuery.GetResultQuery(conn, query);
        //    return result;
        //}
        ///*
        // * XoaCongNo trả về
        // * 1:thành công
        // * 0:thất bại
        // */
        //public static int XoaCongNo(int idDL)
        //{
        //    string query = "delete CongNo where IdDaiLy=" + idDL;
        //    int result = ResultQuery.GetResultQuery(conn, query);
        //    return result;
        //}

        public static ArrayList CongNo(int Thang)
        {
            ArrayList arr = new ArrayList();
            DataTable tb = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PR_BaoCaoCongNo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = Thang;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(tb);
                foreach(DataRow r in tb.Rows)
                {
                    int idDL = (int)r["IdDL"];
                    float noDau = (float)Convert.ToDouble(r["NoDau"]);
                    float noCuoi= (float)Convert.ToDouble(r["NoCuoi"]);
                    DTO_CongNo cn = new DTO_CongNo(idDL, Thang, noDau,noCuoi);
                    arr.Add(cn);
                }
                return arr;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
