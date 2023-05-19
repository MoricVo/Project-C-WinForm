using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_HocVien
    {
        public static List<DTO_HocVien> LayDSHocVien()
        {
            return DAO_HocVien.LayDSHocVien();
        }
        public static bool ThemHocVien(DTO_HocVien nv)
        {


            return DAO_HocVien.ThemHocVien(nv);
        }
        public static bool XoaHocVien(DTO_HocVien nv)
        {
            return DAO_HocVien.XoaHocVien(nv);
        }
        public static bool SuaLopHoc(DTO_HocVien nv)
        {
            return DAO_HocVien.SuaHocVien(nv);
        }


        public static DTO_HocVien TimHocVienTheoMa(string ma)
        {
            return DAO_HocVien.TimHocVienTheoMa(ma);
        }
    }
}
