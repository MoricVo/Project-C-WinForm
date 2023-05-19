using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_DuLieu;
using System.Data;
namespace DAO_XuLyDuLieu
{
  public class DAO_KhoaHoc
    {
        static SqlConnection conn;
        public static List<DTO_KhoaHoc> LayDSKhoaHoc()
        {
            string sTruyVan = "select * from Table_KhoaHoc";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_KhoaHoc> lstKhoaHoc = new List<DTO_KhoaHoc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_KhoaHoc nv = new DTO_KhoaHoc();
                nv.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();
                nv.TenKhoaHoc1 = dt.Rows[i]["TenKhoaHoc"].ToString();
                nv.NgayLap1 = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
               

                lstKhoaHoc.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstKhoaHoc;
        }
        public static bool ThemKhoaHoc(DTO_KhoaHoc nv)
        {
            string sTruyVan = string.Format(@"insert into Table_KhoaHoc values(N'{0}', N'{1}',N'{2}')"
                , nv.MaKhoaHoc1,nv.TenKhoaHoc1,nv.NgayLap1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaKhoaHoc(DTO_KhoaHoc nv)
        {
            string sTruyVan = string.Format(@"update Table_KhoaHoc set TenKhoaHoc=N'{0}',NgayLap=N'{1}'
            where MaKhoaHoc=N'{2}'", nv.TenKhoaHoc1,nv.NgayLap1,nv.MaKhoaHoc1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaKhoaHoc(DTO_KhoaHoc nv)
        {
            string sTruyVan = string.Format(@"delete from Table_KhoaHoc
            where MaKhoaHoc='{0}'", nv.MaKhoaHoc1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_KhoaHoc TimKhoaHocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_KhoaHoc where MaKhoaHoc=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_KhoaHoc nv = new DTO_KhoaHoc();
            nv.MaKhoaHoc1 = dt.Rows[0]["MaKhoaHoc"].ToString();
            nv.TenKhoaHoc1 = dt.Rows[0]["TenKhoaHoc"].ToString();
            nv.NgayLap1 = DateTime.Parse(dt.Rows[0]["NgayLap"].ToString());
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
