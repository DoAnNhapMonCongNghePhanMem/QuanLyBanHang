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
        private  SqlConnection conn = DBUtils.GetDBConnection();
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
	public int SuaDaiLy(DTO_DaiLy newDaiLy)
        {
            int result;
            int idDaiLy = newDaiLy.IdDL;
            string tenDL = newDaiLy.TenDaiLy;
            string sdt = newDaiLy.Sdt;
            string diaChi = newDaiLy.DiaChi;
            string ngayNhan = newDaiLy.NgayNhan;
            int idLoaiDL = newDaiLy.IdLoaiDL;
            string cmnd = newDaiLy.Cmnd;
            string quan = newDaiLy.Quan;
            string query = "UPDATE DaiLy SET TenDaiLy = N'" + tenDL + "', SDT = '" + sdt + "',DiaChi=N'" + diaChi + "',NgayTiepNhan='" + ngayNhan + "',IdLoaiDL='" + idLoaiDL + "',CMND='" + cmnd + "',Quan=N'" + quan + "'WHERE IdDaiLy=" + idDaiLy;
            result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public int XoaDaiLy(int idDaiLy)
        {
            string query = "delete from DaiLy where IdDaiLy=" + idDaiLy;
            int result=ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public ArrayList DsDaiLy()
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
                string ngayNhan = r["NgayTiepNhan"].ToString();
                int idLoaiDL = (int)r["IdLoaiDL"];
                string cmnd = r["CMND"].ToString();
                string quan = r["Quan"].ToString();
                float tienNo = (float)r["TienNo"];
                DTO_DaiLy dl = new DTO_DaiLy(id, idLoaiDL, tenDL, sdt, diaChi, ngayNhan, cmnd, quan, tienNo);
                al.Add(dl);
            }
            return al;
        }
    }
}
