using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QuanLyDaiLy;

namespace GUI_QuanLyDaiLy
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
            // Application.Run(new Form1());
            Console.WriteLine("khaa-------------------------------");

            DAL_QuanLyTaiKhoan d = new DAL_QuanLyTaiKhoan();
            int a = d.KiemTraKetNoi("LE CONG KHANH","khanh181097");
            Console.WriteLine(a);
        }
    }
}
