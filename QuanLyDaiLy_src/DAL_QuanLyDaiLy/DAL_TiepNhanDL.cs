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
    public class DAL_TiepNhanDL
    {
        private SqlConnection conn = DBUtils.GetDBConnection();
        public DAL_TiepNhanDL()
        {

        }
        public ArrayList GetLoaiDL()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt=ResultQuery.GetTableResult(conn, "SELECT * FROM LoaiDaiLy ");
            int id;
            string ten;
            foreach (DataRow r in dt.Rows)
            {
                id = (int)r["IdLoaiDL"];
                ten = r["TenLoaiDL"].ToString();
                DTO_LoaiDL loaiDL = new DTO_LoaiDL(id, ten);
                arrList.Add(loaiDL);
            }

            return arrList;
        }
        public int ThemDaiLy(string tenDL, string sdt, string diaChi, string ngayNhan, string loaiDL, string cmnd, string quan)
        {
            int kq;
            SqlCommand cmd = new SqlCommand("PR_InsertDl", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDL", SqlDbType.NVarChar).Value = tenDL;
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("@NgayTiepNhan", SqlDbType.Date).Value = ngayNhan;
            cmd.Parameters.Add("@TenLoaiDL", SqlDbType.NVarChar).Value = loaiDL;
            cmd.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = cmnd;
            cmd.Parameters.Add("@Quan", SqlDbType.NVarChar).Value = quan;
            cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                kq = (int)cmd.Parameters["@result"].Value;
                return kq;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
