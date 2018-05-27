using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            SqlCommand cmd = new SqlCommand("PR_CheckLogin", conn);
            //cmd.CommandText = "PR_CheckLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@OutPut", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                int kq = (int)cmd.Parameters["@OutPut"].Value;
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


    }
}
