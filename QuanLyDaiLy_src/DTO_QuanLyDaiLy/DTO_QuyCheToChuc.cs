using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyDaiLy
{
    public class DTO_QuyCheToChuc
    {
        private int soLoaiDaiLy;
        private int soDaiLyToiDa;
        private int soMatHang;
        private int soQuan;

        public int SoLoaiDaiLy
        {
            get
            {
                return soLoaiDaiLy;
            }

            set
            {
                soLoaiDaiLy = value;
            }
        }

        public int SoDaiLyToiDa
        {
            get
            {
                return soDaiLyToiDa;
            }

            set
            {
                soDaiLyToiDa = value;
            }
        }

        public int SoMatHang
        {
            get
            {
                return soMatHang;
            }

            set
            {
                soMatHang = value;
            }
        }

        public int SoQuan
        {
            get
            {
                return soQuan;
            }

            set
            {
                soQuan = value;
            }
        }

        public DTO_QuyCheToChuc(int SoLoaiDaiLy,int SoDaiLyToiDa,int SoMatHang,int SoQuan)
        {
            this.SoLoaiDaiLy = SoLoaiDaiLy;
            this.SoDaiLyToiDa = SoDaiLyToiDa;
            this.SoMatHang = SoMatHang;
            this.SoQuan = SoQuan;

        }
        public DTO_QuyCheToChuc()
        {
            this.SoLoaiDaiLy = SoLoaiDaiLy;
            this.SoDaiLyToiDa = SoDaiLyToiDa;
            this.SoMatHang = SoMatHang;
            this.SoQuan = SoQuan;

        }
    }
}
