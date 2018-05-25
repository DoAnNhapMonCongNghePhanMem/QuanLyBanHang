﻿using DAL_QuanLyDaiLy;
using DTO_QuanLyDaiLy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDangNhap());
            Console.WriteLine("khánh-------------------------------");

            //DAL_QuanLyTaiKhoan d = new DAL_QuanLyTaiKhoan();
            //int a = d.KiemTraKetNoi("LE CONG KHANH","khanh181097");
            //Console.WriteLine(a);

            DAL_TiepNhanDL tn = new DAL_TiepNhanDL();
            ArrayList arrList = tn.GetLoaiDL();

            foreach (DTO_LoaiDL item in arrList)
            {
                Console.WriteLine(item.IdLoaiDL + " " + item.TenLoaiDL);
            }
            //int kq=tn.ThemDaiLy("đại lý 4", "09092222", "ktx khu a ", "2018-2-20", "Loại 2", "206014565", "Quận 9");
            //Console.WriteLine(kq);

        }
    }
}
