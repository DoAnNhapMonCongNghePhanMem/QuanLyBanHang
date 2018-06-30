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
    public class DAL_QuyDinhMatHang
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();

        /*
         * trả về 0:update thất bại
         * trả về 1:update thành công
         */
        public static int CapNhatQuyDinhMatHang(DTO_QuyDinhMatHang qd)
        {
            string query = "update QuyDinhMatHang set DonViTinh=N'"+qd.DonViTinh+"',DonGia="+qd.DonGia+" where IdMatHang="+qd.IdMatHang;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static ArrayList QDMatHang()
        {
            ArrayList arr = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM QuyDinhMatHang");
            foreach (DataRow r in dt.Rows)
            {
                DTO_QuyDinhMatHang qd = new DTO_QuyDinhMatHang();
                qd.IdMatHang = (int)r["IdMatHang"];
                qd.DonViTinh=r["DonViTinh"].ToString();
                qd.DonGia = (float)Convert.ToDouble(r["DonGia"]);
                arr.Add(qd);
            }
            return arr;
        }
        public static string getDonViTinh(int idMatHang)
        {
            string query = "select DonViTinh from QuyDinhMatHang where IdMatHang ="+idMatHang;
            DataTable dt = ResultQuery.GetTableResult(conn, query);
            DataRow r = dt.Rows[0];
            return r["DonViTinh"].ToString();
        }
        public static string getDonGia(int idMatHang)
        {
            string query = "select DonGia from QuyDinhMatHang where IdMatHang =" + idMatHang;
            DataTable dt = ResultQuery.GetTableResult(conn, query);
            DataRow r = dt.Rows[0];
            return r["DonGia"].ToString();
        }

    }
}
