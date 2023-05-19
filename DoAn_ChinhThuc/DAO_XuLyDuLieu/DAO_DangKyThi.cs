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
  public class DAO_DangKyThi
    {
        static SqlConnection conn;
        public static List<DTO_DangKiThi> LayDSDKThi()
        {
            string sTruyVan = "select * from Table_DangKiThi";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_DangKiThi> lstKhoaHoc = new List<DTO_DangKiThi>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_DangKiThi nv = new DTO_DangKiThi();
                nv.MaHV1 = dt.Rows[i]["MaHV"].ToString();
                nv.NgayThi1 = DateTime.Parse(dt.Rows[i]["NgayThi"].ToString());
                nv.GioThi1 = dt.Rows[i]["GioThi"].ToString();
                nv.CaThi1 = dt.Rows[i]["CaThi"].ToString();
                nv.MaLop1 = dt.Rows[i]["MaLop"].ToString();


                lstKhoaHoc.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstKhoaHoc;
        }
        public static bool ThemDangKyThi(DTO_DangKiThi nv)
        {
            string sTruyVan = string.Format(@"insert into Table_DangKiThi values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')"
                , nv.MaHV1, nv.NgayThi1, nv.GioThi1, nv.CaThi1, nv.MaLop1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaChungChi(DTO_DangKiThi nv)
        {
            string sTruyVan = string.Format(@"update Table_DangKiThi set NgayThi=N'{0}',GioThi=N'{1}',CaThi=N'{2}',MaLop=N'{3}'
            where MaHV=N'{4}'", nv.NgayThi1, nv.GioThi1, nv.CaThi1, nv.MaLop1, nv.MaHV1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaDangKyThi(DTO_DangKiThi nv)
        {
            string sTruyVan = string.Format(@"delete from Table_DangKiThi
            where MaHV=N'{0}'", nv.MaHV1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_DangKiThi TimDangKiThiTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_DangKiThi where MaHV=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_DangKiThi nv = new DTO_DangKiThi();
            nv.MaHV1 = dt.Rows[0]["MaHV"].ToString();
            nv.NgayThi1 = DateTime.Parse(dt.Rows[0]["NgayThi"].ToString());
            nv.GioThi1 = dt.Rows[0]["GioThi"].ToString();
            nv.CaThi1 = dt.Rows[0]["CaThi"].ToString();
            nv.MaLop1 = dt.Rows[0]["MaLop"].ToString();
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
