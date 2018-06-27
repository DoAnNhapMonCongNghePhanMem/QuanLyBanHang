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
    public class DAL_DoanhSo
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        //public static ArrayList DSDoanhSo()
        //{
        //    ArrayList arrList = new ArrayList();
        //    DataTable dt = new DataTable();
        //    dt = ResultQuery.GetTableResult(conn, "SELECT * FROM DoanhSo ");
        //    int idDaiLy;
        //    int thang;
        //    float tongDoanhSo;
        //    int soPhieuXuat;
        //    float tiLe;

        //    foreach (DataRow r in dt.Rows)
        //    {
        //        idDaiLy = (int)r["IdDaiLy"];
        //        thang = (int)r["Thang"];
        //        tongDoanhSo = (float)Convert.ToDouble(r["TongDoanhSo"]);
        //        soPhieuXuat = (int)r["SoPhieuXuat"];
        //        tiLe = (float)Convert.ToDouble(r["TyLe"]);
        //        DTO_DoanhSo phieuThu = new DTO_DoanhSo(idDaiLy, thang, tongDoanhSo, soPhieuXuat, tiLe);
        //        arrList.Add(phieuThu);
        //    }
        //    return arrList;
        //}
        ///*
        // * ThemDoanhSo trả về 
        // * 1:thành công
        // * 0:thất bại
        // */
        //public static int ThemDoanhSo(DTO_DoanhSo ds)
        //{
        //    int kq = 0;
        //    string query = " insert into DoanhSo(IdDaiLy, Thang, TongDoanhSo, SoPhieuXuat, TyLe) values("+ds.IdDaiLy+","+ds.Thang+","+ds.TongDoanhSo+","+ds.SoPhieuXuat+","+ds.TiLe+")";
        //    kq = ResultQuery.GetResultQuery(conn, query);
        //    return kq;
        //}
        ///*
        // * XoaDoanhSo trả về 
        // * 1:thành công
        // * 0:thất bại
        // */
        //public static int XoaDoanhSo(int idDaiLy)
        //{
        //    string query = "delete DoanhSo where IdDaiLy=" + idDaiLy;
        //    int result = ResultQuery.GetResultQuery(conn, query);
        //    return result;
        //}
        ///*
        // * CapNhatDoanhSo trả về 
        // * 1:thành công
        // * 0:thất bại
        // */
        //public static int CapNhatDoanhSo(DTO_DoanhSo ds)
        //{
        //    string query = "update DoanhSo set Thang =" + ds.Thang + ",TongDoanhSo=" + ds.TongDoanhSo + ",SoPhieuXuat=" +ds.SoPhieuXuat + " ,TyLe=" + ds.TiLe + " where IdDaiLy=" + ds.IdDaiLy;
        //    int result = ResultQuery.GetResultQuery(conn, query);
        //    return result;
        //}

        public static ArrayList DoanhSo(int thang)
        {
            ArrayList arrList = new ArrayList();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("PR_BaoCaoDoanhSo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow r in dt.Rows)
                {
                    int idDL = (int)r["idDL"];
                    float TongTien = (float)Convert.ToDouble(r["TongTien"]);
                    int SoPhieuXuat = (int)r["SoPhieuXuat"];
                    float tyle = (float)Convert.ToDouble(r["tyle"]);
                    int Thang = (int)r["Thang"];
                    DTO_DoanhSo dso = new DTO_DoanhSo(idDL, Thang, TongTien,SoPhieuXuat, tyle);
                    arrList.Add(dso);
                }
                return arrList;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
