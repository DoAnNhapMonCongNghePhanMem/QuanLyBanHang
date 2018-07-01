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

        public static int ThemDaiLy()
        {
            throw new NotImplementedException();
        }

        /*
* 1 thêm thành công
* 2 số lượng đại lý tại quận đó đã đủ theo quy định nên không thể thêm
* 3 tên đại lý tồn tại
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
         * Sửa đại lý
         * 1:Sửa thành công
         * 2:tiền nợ vượt quy định cho phép
         * 
         */
        public static int SuaDaiLy(DTO_DaiLy daiLy)
        {
            int kq;
            string ngayNhanSql = daiLy.NgayNhan.ToString("yyyy-MM-dd");
            SqlCommand cmd = new SqlCommand("PR_UpdateDL", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDaiLy", SqlDbType.NVarChar).Value = daiLy.TenDaiLy;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = daiLy.Sdt;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = daiLy.DiaChi;
            cmd.Parameters.Add("@IdQuan", SqlDbType.Int).Value = daiLy.IdQuan;
            cmd.Parameters.Add("@NgayTiepNhan", SqlDbType.Date).Value = ngayNhanSql;
            cmd.Parameters.Add("@IdLoaiDL", SqlDbType.Int).Value = daiLy.IdLoaiDL;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = daiLy.Cmnd;
            cmd.Parameters.Add("@TienNo", SqlDbType.Float).Value = daiLy.Cmnd;
            cmd.Parameters.Add("@IdDaiLy", SqlDbType.Int).Value = daiLy.IdDL;
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
*XoaDaiLy trả về 
* 0 : sửa thất bại
* 1 : sửa thành công
*/

        public static  int XoaDaiLy(int idDaiLy)
        {
            //DAL_ChiTietXuat.XoaChiTietXuat(idDaiLy);
            //DAL_PhieuXuat.XoaByIdDl(idDaiLy);
            //DAL_PhieuThuTien.XoaByIdDl(idDaiLy);
            //DAL_CongNo.XoaCongNo(idDaiLy);
            //DAL_DoanhSo.XoaDoanhSo(idDaiLy);
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
        
        public static ArrayList search(string name)
        {
            ArrayList al = new ArrayList();
            string query = "select * from DaiLy where TenDaiLy like N'%"+name+"%'";
            DataTable tb = ResultQuery.GetTableResult(conn, query);
            foreach (DataRow r in tb.Rows)
            {
                int id = (int)r["IdDaiLy"];
                string tenDL = r["TenDaiLy"].ToString();
                string sdt = r["SDT"].ToString();
                string diaChi = r["DiaChi"].ToString();
                int idquan = (int)r["IdQuan"];
                DateTime ngayNhan = Convert.ToDateTime(r["NgayTiepNhan"]);
                int idLoaiDL = (int)r["IdLoaiDL"];
                string cmnd = r["CMND"].ToString();
                float tienNo = (float)Convert.ToDouble(r["TienNo"]);
                DTO_DaiLy dl = new DTO_DaiLy(id, idLoaiDL, tenDL, sdt, diaChi, idquan, ngayNhan, cmnd, tienNo);
                al.Add(dl);
            }
            return al;
        }
        public static string GetTen(int id)
        {
            string ten = "";
            DataTable tb = ResultQuery.GetTableResult(conn, "select TenDaiLy from DaiLy where IdDaiLy="+id);
            foreach (DataRow r in tb.Rows)
            {
                ten = r["TenDaiLy"].ToString();
            }
            return ten;
        }

        /*
         * trả về 
         * 1:update thành công
         * 2:tiền nợ vượt quá quy định
         */
        public static int UpdateTienNo(int idDL,float tienNo)
        {
            int kq = 0;
            SqlCommand cmd = new SqlCommand("PR_UpdateTienNo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idDL", SqlDbType.Int).Value = idDL;
            cmd.Parameters.Add("@tienNo", SqlDbType.Float).Value = tienNo;
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
        public static float GetTienNo(int id)
        {
            float tien=0;
            DataTable tb = ResultQuery.GetTableResult(conn, "select TienNo from DaiLy where IdDaiLy=" + id);
            foreach (DataRow r in tb.Rows)
            {
                tien =(float) Convert.ToDouble(r["TienNo"].ToString());
            }
            return tien;
        }
    }
}
