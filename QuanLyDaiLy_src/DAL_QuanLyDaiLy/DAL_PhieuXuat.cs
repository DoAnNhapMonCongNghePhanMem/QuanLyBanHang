using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyDaiLy;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DAL_QuanLyDaiLy
{
    public class DAL_PhieuXuat
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSPhieuXuat()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM PhieuXuatHang ");
            int idPhieuXuat;
            DateTime ngayXuat;
            int idDaiLy;
            string cmnd;
            foreach (DataRow r in dt.Rows)
            {
                idPhieuXuat = (int)r["IdPhieuXuat"];
                ngayXuat = Convert.ToDateTime(r["NgayXuat"]);
                idDaiLy= (int)r["IdDaiLy"];
                cmnd = r["CMND"].ToString();

                DTO_PhieuXuatHang phieuXuat = new DTO_PhieuXuatHang(idPhieuXuat,ngayXuat,idDaiLy,cmnd);
                arrList.Add(phieuXuat);
            }

            return arrList;
        }
        /*
         * ThemPhieuXuat trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int ThemPhieuXuat(DTO_PhieuXuatHang pxh)
        {
            int kq = 0;
            string ngayXuatSql = pxh.NgayXuat.ToString("yyyy-MM-dd");
            string query = "insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('" + ngayXuatSql + "'," + pxh.IdDaiLy + ",'" + pxh.Cmnd + "')";
            kq = ResultQuery.GetResultQuery(conn, query);
            return kq;

        }
        public static int ThemPhieuXuatTraVeId(DTO_PhieuXuatHang px)
        {
        
             int kq;
            string ngayXuatSql = px.NgayXuat.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("PR_InsertPhieuXuat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = ngayXuatSql;
            cmd.Parameters.Add("@IdDaiLy", SqlDbType.Int).Value = px.IdDaiLy;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = px.Cmnd;
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
         * XoaPhieuXuat trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int XoaPhieuXuat(int idPhieuXuat)
        {
            string query = "delete PhieuXuatHang where IdPhieuXuat=" + idPhieuXuat;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static int XoaByIdDl(int id)
        {
            string query = "delete PhieuThuTien where IdDaiLy=" + id;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        //public void Xoapxbyid(int id)
        //{
        //    string query = "delete PhieuXuatHang where IdPhieuXuat=" + id;
        //}
        /*
         * CapNhatPhieuXuat trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int CapNhatPhieuXuat(DTO_PhieuXuatHang pxh)
        {
            string ngayXuatSql = pxh.NgayXuat.ToString("yyyy-MM-dd");
            string query = "update PhieuXuatHang set NgayXuat ='" +ngayXuatSql + "',IdDaiLy="+pxh.IdDaiLy+" ,CMND='"+pxh.Cmnd+ "' where IdPhieuXuat=" + pxh.IdPhieuXuat;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
       
    }
}
