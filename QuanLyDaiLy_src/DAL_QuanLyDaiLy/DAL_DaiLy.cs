using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyDaiLy;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DAL_QuanLyDaiLy
{
    public class DAL_DaiLy
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public DAL_DaiLy()
        {

        }
        /*
         * 1 thêm thành công
         * 0 tên đại lý tồn tại
         * 
         */
        public static int ThemDaiLy(DTO_DaiLy daiLy)
        {
            int kq;
            string ngayNhanSql = daiLy.NgayNhan.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("PR_InsertDl", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDL", SqlDbType.NVarChar).Value = daiLy.TenDaiLy;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = daiLy.Sdt;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = daiLy.DiaChi;
            cmd.Parameters.Add("@NgayTiepNhan", SqlDbType.Date).Value = ngayNhanSql;
            cmd.Parameters.Add("@IdLoaiDL", SqlDbType.Int).Value = daiLy.IdLoaiDL;
            cmd.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = daiLy.Cmnd;
            cmd.Parameters.Add("@IdQuan", SqlDbType.Int).Value = daiLy.IdQuan;
            try
            {
                conn.Open();
                kq=cmd.ExecuteNonQuery();
                return kq;
            }
            finally
            {
                conn.Close();
            }
        }
        /*
         *SuaDaiLy trả về 
         * 0 : sửa thất bại
         * 1 : sửa thành công
         */
        public static int SuaDaiLy(DTO_DaiLy newDaiLy)
        {
            int result;
            int idDaiLy = newDaiLy.IdDL;
            string tenDL = newDaiLy.TenDaiLy;
            string sdt = newDaiLy.Sdt;
            string diaChi = newDaiLy.DiaChi;
            int idQuan = newDaiLy.IdQuan;
            string ngayNhan= newDaiLy.NgayNhan.ToString("yyyy-MM-dd");
            int idLoaiDL = newDaiLy.IdLoaiDL;
            string cmnd = newDaiLy.Cmnd;
            
            string query = "UPDATE DaiLy SET TenDaiLy = N'" + tenDL + "', SDT = '" + sdt + "',DiaChi=N'" + diaChi + "',NgayTiepNhan='" + ngayNhan + "',IdLoaiDL='" + idLoaiDL + "',CMND='" + cmnd + "',IdQuan=" + idQuan + " WHERE IdDaiLy=" + idDaiLy;
            result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }

        public static int ThemDaiLy(DAL_DaiLy dl)
        {
            throw new NotImplementedException();
        }

        /*
*XoaDaiLy trả về 
* 0 : sửa thất bại
* 1 : sửa thành công
*/

        public static  int XoaDaiLy(int idDaiLy)
        {
            string query = "delete from DaiLy where IdDaiLy=" + idDaiLy;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static ArrayList DsDaiLy()
        {
            ArrayList al = new ArrayList();
            string query = "select * from DaiLy";
            DataTable tb = ResultQuery.GetTableResult(conn, query);
            foreach (DataRow r in tb.Rows)
            {
                int id = (int)r["IdDaiLy"];
                string tenDL = r["TenDaiLy"].ToString();
                string sdt = r["SDT"].ToString();
                string diaChi = r["DiaChi"].ToString();
                int idquan =(int) r["IdQuan"];
                DateTime ngayNhan = Convert.ToDateTime(r["NgayTiepNhan"]);
                int idLoaiDL = (int)r["IdLoaiDL"];
                string cmnd = r["CMND"].ToString();
                float tienNo = (float) Convert.ToDouble(r["TienNo"]);
                DTO_DaiLy dl = new DTO_DaiLy(id,idLoaiDL,tenDL,sdt,diaChi,idquan,ngayNhan,cmnd,tienNo);
                al.Add(dl);
            }
            return al;
        }

    }
}
