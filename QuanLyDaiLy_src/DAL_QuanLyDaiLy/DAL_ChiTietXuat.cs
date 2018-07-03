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
    public class DAL_ChiTietXuat
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        public static ArrayList DSPhieuXuat()
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            dt = ResultQuery.GetTableResult(conn, "SELECT * FROM ChiTietXuatHang ");
            int idPhieuXuat;
            int idMatHang;
            int soLuong;
            float donGia;
            string donViTinh;
            float thanhTien;

            foreach (DataRow r in dt.Rows)
            {
                idPhieuXuat = (int)r["IdPhieuXuat"];
                idMatHang = (int) r["IdMatHang"];
                soLuong = (int) r["SoLuong"];
                donGia = (float) Convert.ToDouble(r["DonGia"]);
                donViTinh = r["DonViTinh"].ToString();
                thanhTien= (float)Convert.ToDouble(r["ThanhTien"]);

                DTO_ChiTietXuat ctx = new DTO_ChiTietXuat(idPhieuXuat, idMatHang, soLuong, donGia, donViTinh, thanhTien);
                arrList.Add(ctx);
            }
            return arrList;
        }
        /*
         * ThemChiTietXuat trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int ThemChiTietXuat(DTO_ChiTietXuat ctx)
        {
            int kq = 0;
            string query = "insert into ChiTietXuatHang(IdPhieuXuat, IdMatHang, SoLuong, DonGia, DonViTinh, ThanhTien) values("+ctx.IdPhieuXuat+","+ctx.IdMatHang+","+ctx.SoLuong+","+ctx.DonGia+", N'"+
                ctx.DonViTinh+"', "+ctx.ThanhTien+")";
            kq = ResultQuery.GetResultQuery(conn, query);
            return kq;
        }
        /*
         * XoaChiTietXuat trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int XoaChiTietXuat(int idPhieuXuat)
        {

            string query = "delete ChiTietXuatHang where IdPhieuXuat=" + idPhieuXuat;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
        }
      
        /*
         * CapNhatChiTietXuat trả về 
         * 1:thành công
         * 0:thất bại
         */
        public static int CapNhatChiTietXuat(DTO_ChiTietXuat ctx)
        {
            string query = "update ChiTietXuatHang set IdMatHang =" + ctx.IdMatHang + ",SoLuong=" + ctx.SoLuong + ",DonGia=" + ctx.DonGia + " ,DonViTinh=" + ctx.DonViTinh + ",ThanhTien=" + ctx.ThanhTien + " where IdPhieuXuat=" + ctx.IdPhieuXuat;
            int result = ResultQuery.GetResultQuery(conn, query);
            return result;
            
        }
    }
}
