using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
using DAO_XuLyDuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_MaLopHoc
    {
        public static List<DTO_MaLopHoc> LayDSMaLop()
        {
            return DAO_MaLopHoc.LayDSMaLopHoc();
        }
        public static bool ThemMaLop(DTO_MaLopHoc nv)
        {
            return DAO_MaLopHoc.ThemMaLopHoc(nv);
        }
        public static bool XoaMaLop(DTO_MaLopHoc nv)
        {
            return DAO_MaLopHoc.XoaMaLop(nv);
        }
        public static bool SuaMaLop(DTO_MaLopHoc nv)
        {
            return DAO_MaLopHoc.SuaMaLopHoc(nv);
        }


        public static DTO_MaLopHoc TimMaLopTheoMa(string ma)
        {
            return DAO_MaLopHoc.TimMaLopTheoMa(ma);
        }
    }
}
