using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyDaiLy;

namespace DAL_QuanLyDaiLy
{
    public class DAL_QuanLyTaiKhoan
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();

        public DAL_QuanLyTaiKhoan()
        {

        }

        /*
         * hàm KiemTraDangNhap trả lại
         * 0 : cho phép đăng nhập
         * 1 : UserName không chính xác
         * 2 : Pass không chính xác
         * 3 : Tài khoản bị block bới Admin
         */
        public static int KiemTraDangNhap(string userName, string pass)
        {
            int kq;
            SqlCommand cmd = new SqlCommand("PR_CheckLogin", conn);
            //cmd.CommandText = "PR_CheckLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
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
         * hàm KiemTraDangKy trả về
         * 0 : dangki thanh cong
         * 1 : UserName đã tồn tại
         * 2 : nhan vien đã co tai khoan
         * 3 : Lỗi khi insert 
         */
        public static int KiemTraDangKy(string cmnd, string tenNV, string ngaySinh, string queQuan, string sdt, string userName, string pass, int phanQuyen, int trangThai)
        {
            int result;
            SqlCommand cmd = new SqlCommand("PR_DangKi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = tenNV;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = queQuan;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@PhanQuyen", SqlDbType.Int).Value = phanQuyen;
            cmd.Parameters.Add("@TrangThai", SqlDbType.Int).Value = trangThai;
            cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                result = (int)cmd.Parameters["@result"].Value;
                return result;
            }
            finally
            {
                conn.Close();
            }
        }
        public static string GetTenNhanVien(string cmnd)
        {
            string query= "select TenNV from NhanVienQL where CMND="+cmnd;
            DataTable dt = ResultQuery.GetTableResult(conn, query);
            DataRow r = dt.Rows[0];
            return r["TenNV"].ToString();
        }
        public static DTO_ThongTinTaiKhoan GetTaiKhoan(string user,string pass)
        {

            string query = "select* from ThongTinTaiKhoan where UserName = '"+user+"' and Pass = '"+pass+"'";
            DataTable dt = ResultQuery.GetTableResult(conn, query);
            DataRow r = dt.Rows[0];
             string cmnd = r["CMND"].ToString();
                int phanQuyen = (int) r["PhanQuyen"];
                int trangThai = (int)r["PhanQuyen"];
            DTO_ThongTinTaiKhoan tk = new DTO_ThongTinTaiKhoan(user, pass, cmnd, phanQuyen, trangThai);
            return tk;
 
        }
        public static DTO_NhanVienQuanLy GetNhanVien(string cmnd)
        {

            string query = "select * from NhanVienQL where CMND='"+cmnd+"'";
            DataTable dt = ResultQuery.GetTableResult(conn, query);
            DataRow r = dt.Rows[0];
            string ten = r["TenNV"].ToString();
            DateTime ngaySinh = Convert.ToDateTime(r["NgaySinh"]);

            string queQuan = r["QueQuan"].ToString();
            string sdt = r["SDT"].ToString();

            DTO_NhanVienQuanLy tk = new DTO_NhanVienQuanLy(cmnd,ten,ngaySinh,queQuan,sdt);
            return tk;
         
        }

        public static int CapNhatMatKhau(string user,string passCu,string passMoi)
        {
            int result;
            SqlCommand cmd = new SqlCommand("PR_UpdatePass", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@passCu", SqlDbType.VarChar).Value = passCu;
            cmd.Parameters.Add("@passMoi", SqlDbType.VarChar).Value = passMoi;
            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@out", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                result = (int)cmd.Parameters["@out"].Value;
                return result;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
