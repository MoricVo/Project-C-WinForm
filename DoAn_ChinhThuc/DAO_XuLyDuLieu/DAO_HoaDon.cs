using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
namespace DAO_XuLyDuLieu
{
  public class DAO_HoaDon
    {
        static SqlConnection conn;
        public static List<DTO_HoaDon> LayDSHoaDon()
        {
            string sTruyVan = "select * from Table_HoaDon";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HoaDon> lstKhoaHoc = new List<DTO_HoaDon>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_HoaDon nv = new DTO_HoaDon();
                nv.MaHD1 = dt.Rows[i]["MaHD"].ToString();
                nv.NgayLapHD1 = DateTime.Parse(dt.Rows[i]["NgayLapHD"].ToString());
                nv.MaNV1 = dt.Rows[i]["MaNV"].ToString();
                nv.MaHV1 = dt.Rows[i]["MaHV"].ToString();
                nv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                nv.TienHP1 =int.Parse(dt.Rows[i]["TienHP"].ToString());

                lstKhoaHoc.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstKhoaHoc;
        }
     
        public static bool ThemHoaDon(DTO_HoaDon nv)
        {
            string sTruyVan = string.Format(@"insert into Table_HoaDon values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                , nv.MaHD1, nv.NgayLapHD1, nv.MaNV1, nv.MaHV1, nv.MaLop1,nv.TienHP1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaHoaDon(DTO_HoaDon nv)
        {
            string sTruyVan = string.Format(@"update Table_HoaDon set NgayLapHD=N'{0}',MaNV=N'{1}',MaHV=N'{2}',MaLop=N'{3}',TienHP=N'{4}'
            where MaHD=N'{5}'", nv.NgayLapHD1, nv.MaNV1, nv.MaHV1, nv.MaLop1, nv.TienHP1, nv.MaHD1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaHoaDon(DTO_HoaDon nv)
        {
            string sTruyVan = string.Format(@"delete from Table_HoaDon
            where MaHD='{0}'", nv.MaHD1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_HoaDon TimHoaDonTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_HoaDon where MaHD=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_HoaDon nv = new DTO_HoaDon();
            nv.MaHD1 = dt.Rows[0]["MaHD"].ToString();
            nv.NgayLapHD1 = DateTime.Parse(dt.Rows[0]["NgayLapHD"].ToString());
            nv.MaNV1 = dt.Rows[0]["MaNV"].ToString();
            nv.MaHV1 = dt.Rows[0]["MaHV"].ToString();
            nv.MaLop1 = dt.Rows[0]["MaLop"].ToString();
            nv.TienHP1 = int.Parse(dt.Rows[0]["TienHP"].ToString());
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
