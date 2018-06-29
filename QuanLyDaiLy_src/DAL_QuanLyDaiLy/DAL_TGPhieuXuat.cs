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
    public class DAL_TGPhieuXuat
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSPhieuXuat(int id)
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "select * from ChiTietXuatHang as c, PhieuXuatHang as p,DaiLy as d, MatHang as m where c.IdPhieuXuat = d.IdDaiLy and c.IdPhieuXuat = p.IdPhieuXuat and c.IdMatHang = m.IdMatHang and d.IdDaiLy = "+id+"");
            //string tendaily;
            //DateTime ngayThu;
            //float soTienThu;
            //string diachi;
            //string cmnd;
            //string sdt;
            //int idpt;
            string tenmh;
            string donvi;
            int soluong;
            float dongia;
            float thanhtien;

            foreach (DataRow r in dt.Rows)
            {
                //idpt = (int)r["IdPhieuThu"];
                //tendaily = (string)r["TenDaiLy"];
                //ngayThu = Convert.ToDateTime(r["NgayThu"]);
                //soTienThu = (float)Convert.ToDouble(r["SoTienThu"]);
                //diachi = (string)r["DiaChi"];
                //sdt = (string)r["SDT"];

                //cmnd = (string)r["CMND"];
                tenmh = (string)r["TenMatHang"];
                donvi = (string)r["DonViTinh"];
                soluong = (int)r["SoLuong"];
                dongia = (float)Convert.ToDouble(r["DonGia"]);
                thanhtien = (float)Convert.ToDouble(r["ThanhTien"]);


                DTO_TGPhieuXuat phieuThu = new DTO_TGPhieuXuat(tenmh,donvi,soluong,dongia,thanhtien);
                arrList.Add(phieuThu);
            }
            return arrList;
        }
    }
}
