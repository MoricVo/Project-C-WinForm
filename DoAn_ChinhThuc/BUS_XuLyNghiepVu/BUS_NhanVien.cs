using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;

namespace BUS_XuLyNghiepVu
{
    public class BUS_NhanVien
    {
        public static List<DTO_NhanVien> LayDSNhanVien1()
        {
            return DAO_NhanVien.LayDSNhanVien();
        }
        public static bool ThemNhanVien(DTO_NhanVien nv)
        {
            // ma hoa
          
          
            return DAO_NhanVien.ThemNhanVien(nv);
        }
        public static bool XoaNhanVien(DTO_NhanVien nv)
        {
            return DAO_NhanVien.XoaNhanVien(nv);
        }
        public static bool SuaNhanVien(DTO_NhanVien nv)
        {
            return DAO_NhanVien.SuaNhanVien(nv);
        }


        public static DTO_NhanVien TimNhanVienTheoMa(string ma)
        {
            return DAO_NhanVien.TimNhanVienTheoMa(ma);
        }


       
       


    }
}
