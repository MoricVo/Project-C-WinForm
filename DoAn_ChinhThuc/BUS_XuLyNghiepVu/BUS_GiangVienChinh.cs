using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;
namespace BUS_XuLyNghiepVu
{
    public class BUS_GiangVienChinh
    {
        public static List<DTO_GiangVienChinh> LayDSNhanVien1()
        {
            return DAO_GiangVienChinh.LayDSGiangVien();
        }
        public static bool ThemGiangVien(DTO_GiangVienChinh nv)
        {
            return DAO_GiangVienChinh.ThemGiangVien(nv);
        }
        public static bool XoaGiangVien(DTO_GiangVienChinh nv)
        {
            return DAO_GiangVienChinh.XoaGiangVien(nv);
        }
        public static bool SuaGiangVien(DTO_GiangVienChinh nv)
        {
            return DAO_GiangVienChinh.SuaGiangVien(nv);
        }


        public static DTO_GiangVienChinh TimGiangVienTheoMa(string ma)
        {
            return DAO_GiangVienChinh.TimGiangVienTheoMa(ma);
        }
    }
}
