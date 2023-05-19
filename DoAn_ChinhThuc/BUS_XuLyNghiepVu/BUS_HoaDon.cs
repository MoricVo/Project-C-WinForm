using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_HoaDon
    {
        public static List<DTO_HoaDon> LayDSHoaDon()
        {
            return DAO_HoaDon.LayDSHoaDon();
        }
        public static bool ThemHoaDon(DTO_HoaDon nv)
        {
            return DAO_HoaDon.ThemHoaDon(nv);
        }
        public static bool XoaHoaDon(DTO_HoaDon nv)
        {
            return DAO_HoaDon.XoaHoaDon(nv);
        }
        public static bool SuaHoaDon(DTO_HoaDon nv)
        {
            return DAO_HoaDon.SuaHoaDon(nv);
        }


        public static DTO_HoaDon TimHoaDonTheoMa(string ma)
        {
            return DAO_HoaDon.TimHoaDonTheoMa(ma);
        }
    }
}
