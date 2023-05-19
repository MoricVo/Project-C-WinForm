using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_LopHoc
    {

        public static List<DTO_LopHoc> LayDSLopHoc()
        {
            return DAO_LopHoc.LayDSLopHoc();
        }
        public static bool ThemLopHoc(DTO_LopHoc nv)
        {
            

            return DAO_LopHoc.ThemLopHoc(nv);
        }
        public static bool XoaLopHoc(DTO_LopHoc nv)
        {
            return DAO_LopHoc.XoaLopHoc(nv);
        }
        public static bool SuaLopHoc(DTO_LopHoc nv)
        {
            return DAO_LopHoc.SuaLopHoc(nv);
        }


        public static DTO_LopHoc TimLopHocTheoMa(string ma)
        {
            return DAO_LopHoc.TimLopHocTheoMa(ma);
        }
    }
}
