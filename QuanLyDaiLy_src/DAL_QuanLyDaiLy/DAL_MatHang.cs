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
        public static ArrayList DSLoaiDaiLyL()
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
            DataTable dt = new DataTable();
            string query = "select * from DaiLy where TenMatHang like '%" + name + "%'";
            DataTable tb = ResultQuery.GetTableResult(conn, query);
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
        /*
         * ThemMatHang trả về
         * 1:thành công
         * 0:thất bại
         */
        public static int ThemMatHang(string tenMatHang)
        {
            int kq = 0;
            SqlCommand cmd = new SqlCommand("PR_InsertMatHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = tenMatHang;
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

    }
}
