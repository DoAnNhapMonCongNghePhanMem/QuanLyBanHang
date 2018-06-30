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
    public class DAL_PhieuThuTien
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSPhieuThu()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM PhieuThuTien ");
            int idPhieuThu;
            DateTime ngayThu;
            float soTienThu;
            int idDaiLy;
            string cmnd;

            foreach (DataRow r in dt.Rows)
            {
                idPhieuThu = (int)r["IdPhieuXuat"];
                ngayThu = Convert.ToDateTime(r["NgayThu"]);
                soTienThu =(float) Convert.ToDouble(r["SoTienThu"]);
                idDaiLy = (int)r["IdDaiLy"];
                cmnd = r["CMND"].ToString();

                DTO_PhieuThuTien phieuThu = new DTO_PhieuThuTien(idPhieuThu, ngayThu, soTienThu, idDaiLy, cmnd);
                arrList.Add(phieuThu);
            }
            return arrList;
        }
        /*
         * ThemPhieuThu trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int ThemPhieuThu(DTO_PhieuThuTien ptt)
        {
            int kq = 0;
            string ngayThuSql = ptt.NgayThu.ToString("yyyy-MM-dd");
            string query = "insert into PhieuThuTien(NgayThu, SoTienThu, IdDaiLy, CMND) values('" + ngayThuSql + "'," + ptt.SoTienThu + "," + ptt.IdDaiLy + ",'"+ptt.Cmnd+"')";
            kq = ResultQuery.GetResultQuery(conn, query);
            return kq;           
        }
        /*
         * XoaPhieuThu trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int XoaByIdDl(int idPhieuThu)
        {
            string query = "delete PhieuThuTien where IdPhieuThu=" + idPhieuThu;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        public static int XoaByIdDL(int idDl)
        {
            string query = "delete PhieuThuTien where IdDaiLy=" +idDl;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
        /*
         * CapNhatPhieuThu trả về 
         * 1:thành công
         * 0:thất bại
         */
        //public static int CapNhatPhieuThu(DTO_PhieuThuTien ptt)
        //{
        //    string ngayThuSql = ptt.NgayThu.ToString("yyyy-MM-dd");
        //    string query = "update PhieuThuTien set NgayThu ='" + ngayThuSql + "',SoTienThu=" + ptt.SoTienThu+ ",IdDaiLy="+ptt.IdDaiLy+" ,CMND='" + ptt.Cmnd + "' where IdPhieuThu=" + ptt.IdPhieuThu;
        //    int result = ResultQuery.GetResultQuery(conn, query);
        //    return result;
        //}
    }
}
