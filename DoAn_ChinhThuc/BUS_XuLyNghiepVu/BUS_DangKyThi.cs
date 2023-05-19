using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_DangKyThi
    {
        public static List<DTO_DangKiThi> LayDSDangKiThi()
        {
            return DAO_DangKyThi.LayDSDKThi();
        }
        public static bool ThemDangKiThi(DTO_DangKiThi nv)
        {
            return DAO_DangKyThi.ThemDangKyThi(nv);
        }
        public static bool XoaDangKiThi(DTO_DangKiThi nv)
        {
            return DAO_DangKyThi.XoaDangKyThi(nv);
        }
        public static bool SuaDangKiThi(DTO_DangKiThi nv)
        {
            return DAO_DangKyThi.SuaChungChi(nv);
        }


        public static DTO_DangKiThi TimChungChiTheoMa(string ma)
        {
            return DAO_DangKyThi.TimDangKiThiTheoMa(ma);
        }
    }
}
