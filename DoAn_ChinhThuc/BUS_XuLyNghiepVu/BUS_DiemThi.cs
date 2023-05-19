using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
using DAO_XuLyDuLieu;
namespace BUS_XuLyNghiepVu
{
    public class BUS_DiemThi
    {
        public static List<DTO_DiemThi> LayDSDiemThi()
        {
            return DAO_DiemThi.LayDSDiemThi();
        }
        public static bool ThemDiemThi(DTO_DiemThi nv)
        {


            return DAO_DiemThi.ThemDiemThi(nv);
        }
        public static bool XoaDiemThi(DTO_DiemThi nv)
        {
            return DAO_DiemThi.XoaDiemThi(nv);
        }
        public static bool SuaDiemThi(DTO_DiemThi nv)
        {
            return DAO_DiemThi.SuaDiemThi(nv);
        }


        public static DTO_DiemThi TimDiemThiTheoMa(string ma)
        {
            return DAO_DiemThi.TimDiemThiTheoMa(ma);
        }
    }
}
