using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
using DAO_XuLyDuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_TroGiang
    {
        public static List<DTO_TroGiang> LayDSTroGiang()
        {
            return DAO_TroGiang.LayDSTroGiang();
        }
        public static bool ThemTroGiang(DTO_TroGiang nv)
        {
            return DAO_TroGiang.ThemTroGiang(nv);
        }
        public static bool XoaTroGiang(DTO_TroGiang nv)
        {
            return DAO_TroGiang.XoaTroGiang(nv);
        }
        public static bool SuaTroGiang(DTO_TroGiang nv)
        {
            return DAO_TroGiang.SuaTroGiang(nv);
        }


        public static DTO_TroGiang TimTroGiangTheoMa(string ma)
        {
            return DAO_TroGiang.TimTroGiangTheoMa(ma);
        }
    }
}
