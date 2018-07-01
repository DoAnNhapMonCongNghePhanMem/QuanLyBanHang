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
    public class DAL_MatHang
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSMatHang()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM MatHang");
            int id;
            string ten;
            foreach (DataRow r in dt.Rows)
            {
                id = (int)r["IdMatHang"];
                ten = r["TenMatHang"].ToString();
                DTO_MatHang matHang = new DTO_MatHang(id, ten);
                arrList.Add(matHang);
            }

            return arrList;
        }
        public static ArrayList search(string name)
        {
            ArrayList arrList = new ArrayList();
            string query = "select * from MatHang where TenMatHang like N'%" + name + "%'";
            DataTable tb = ResultQuery.GetTableResult(conn, query);
            foreach (DataRow r in tb.Rows)
            {
                int id = (int)r["IdMatHang"];
                string ten = r["TenMatHang"].ToString();
                DTO_MatHang matHang = new DTO_MatHang(id, ten);
                arrList.Add(matHang);
            }

            return arrList; 
        }
        /*
         * ThemMatHang trả về
         * 1:thành công
         * 2:Số lượng mặt hàng vượt quy định
         * 3:tên mặt hàng đã tồn tại
         */
        public static int ThemMatHang(string tenMatHang)
        {
            int kq = 0;
            SqlCommand cmd = new SqlCommand("PR_InsertMatHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = tenMatHang;
            cmd.Parameters.Add("@Out", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                kq=(int)cmd.Parameters["@Out"].Value;
                return kq;
            }
            finally
            {
                conn.Close();
            }
        }
        /*
         * XoaMatHang trả về
         * 1:thành công
         * 0:thất bại
         */
        public static int XoaMatHang(int id)
        {
            DAL_ChiTietXuat.XoaChiTietXuat(id);
            string query = "delete MatHang where IdMatHang=" + id;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        /*
         * CapNhatMatHang trả về
         * 1:thành công
         * 0:thất bại
         */
        public static int CapNhatMatHang(DTO_MatHang matHang)
        {
            string query = "update MatHang set TenMatHang=N'"+matHang.TenMatHang+"' where IdMatHang="+matHang.IdMatHang;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static string GetTen(int id)
        {
            string ten = "";
            DataTable tb = ResultQuery.GetTableResult(conn, "select TenMatHang from MatHang where IdMatHang=" + id);
            foreach (DataRow r in tb.Rows)
            {
                ten = r["TenMatHang"].ToString();
            }
            return ten;
        }

    }
}
