using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
using DAO_XuLyDuLieu;
namespace BUS_XuLyNghiepVu
{
   public class BUS_ChungChi
    {
        public static List<DTO_ChungChi> LayDSChungChi()
        {
            return DAO_ChungChi.LayDSChungChi();
        }
        public static bool ThemChungChi(DTO_ChungChi nv)
        {
            return DAO_ChungChi.ThemChungChi(nv);
        }
        public static bool XoaChungChi(DTO_ChungChi nv)
        {
            return DAO_ChungChi.XoaChungChi(nv);
        }
        public static bool SuaChungChi(DTO_ChungChi nv)
        {
            return DAO_ChungChi.SuaChungChi(nv);
        }


        public static DTO_ChungChi TimChungChiTheoMa(string ma)
        {
            return DAO_ChungChi.TimChungChiTheoMa(ma);
        }
    }
}
