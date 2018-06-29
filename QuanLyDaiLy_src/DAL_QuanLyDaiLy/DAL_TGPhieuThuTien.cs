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
    public class DAL_TGPhieuThuTien
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSPhieuThu()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "select d.TenDaiLy,d.DiaChi,d.SDT,p.NgayThu,p.SoTienThu,p.CMND,p.IdPhieuThu from PhieuThuTien as p, DaiLy as d where p.IdDaiLy = d.IdDaiLy ");
            string tendaily;
            DateTime ngayThu;
            float soTienThu;
            string diachi;
            string cmnd;
            string sdt;
            int idpt;

            foreach (DataRow r in dt.Rows)
            {
                idpt = (int)r["IdPhieuThu"];
                tendaily = (string)r["TenDaiLy"];
                ngayThu = Convert.ToDateTime(r["NgayThu"]);
                soTienThu = (float)Convert.ToDouble(r["SoTienThu"]);
                diachi = (string)r["DiaChi"];
                sdt = (string)r["SDT"];

                cmnd = (string)r["CMND"];
                
                DTO_TGPhieuThuTien phieuThu = new DTO_TGPhieuThuTien(idpt,tendaily, ngayThu, soTienThu, diachi, cmnd,sdt);
                arrList.Add(phieuThu);
            }
            return arrList;
        }
        public static ArrayList search(string name)
        {
            ArrayList al = new ArrayList();
            string query = "select d.TenDaiLy,d.DiaChi,d.SDT,p.NgayThu,p.SoTienThu,p.CMND,p.IdPhieuThu from PhieuThuTien as p, DaiLy as d where p.IdDaiLy = d.IdDaiLy and d.TenDaiLy like '%" + name + "%'";
            DataTable tb = ResultQuery.GetTableResult(conn, query);
            string tendaily;
            DateTime ngayThu;
            float soTienThu;
            string diachi;
            string cmnd;
            string sdt;
            int idpt;
            foreach (DataRow r in tb.Rows)
            {
                idpt = (int)r["IdPhieuThu"];
                tendaily = (string)r["TenDaiLy"];
                ngayThu = Convert.ToDateTime(r["NgayThu"]);
                soTienThu = (float)Convert.ToDouble(r["SoTienThu"]);
                diachi = (string)r["DiaChi"];
                sdt = (string)r["SDT"];

                cmnd = (string)r["CMND"];

                DTO_TGPhieuThuTien phieuThu = new DTO_TGPhieuThuTien(idpt, tendaily, ngayThu, soTienThu, diachi, cmnd, sdt);
                al.Add(phieuThu);
            }
            return al;
        }
    }
}
