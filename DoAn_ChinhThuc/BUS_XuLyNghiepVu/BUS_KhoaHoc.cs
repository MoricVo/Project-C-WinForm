using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_XuLyDuLieu;
using DTO_DuLieu;
namespace BUS_XuLyNghiepVu
{
    public class BUS_KhoaHoc
    {
        public static List<DTO_KhoaHoc> LayDSKhoaHoc()
        {
            return DAO_KhoaHoc.LayDSKhoaHoc();
        }
        public static bool ThemKhoaHoc(DTO_KhoaHoc nv)
        {
            return DAO_KhoaHoc.ThemKhoaHoc(nv);
        }
        public static bool XoaKhoaHoc(DTO_KhoaHoc nv)
        {
            return DAO_KhoaHoc.XoaKhoaHoc(nv);
        }
        public static bool SuaKhoaHoc(DTO_KhoaHoc nv)
        {
            return DAO_KhoaHoc.SuaKhoaHoc(nv);
        }


        public static DTO_KhoaHoc TimKhoaHocTheoMa(string ma)
        {
            return DAO_KhoaHoc.TimKhoaHocTheoMa(ma);
        }
    }
}
