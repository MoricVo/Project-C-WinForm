using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
using System.Data;
using System.Data.SqlClient;
namespace DAO_XuLyDuLieu
{
   public class DAO_MaLopHoc
    {
        static SqlConnection conn;
        public static List<DTO_MaLopHoc> LayDSMaLopHoc()
        {
            string sTruyVan = "select * from Table_LoaiLopHoc";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_MaLopHoc> lstMaLopHoc = new List<DTO_MaLopHoc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_MaLopHoc nv = new DTO_MaLopHoc();
                nv.MaLopHoc1 = dt.Rows[i]["MaLoaiLop"].ToString();
                nv.TenLopHoc1 = dt.Rows[i]["TenLoaiLop"].ToString();
                nv.NgayThanhLap1 = DateTime.Parse(dt.Rows[i]["NgayThanhLap"].ToString());


                lstMaLopHoc.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstMaLopHoc;
        }
        public static bool ThemMaLopHoc(DTO_MaLopHoc nv)
        {
            string sTruyVan = string.Format(@"insert into Table_LoaiLopHoc values(N'{0}', N'{1}',N'{2}')"
                , nv.MaLopHoc1, nv.TenLopHoc1, nv.NgayThanhLap1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaMaLopHoc(DTO_MaLopHoc nv)
        {
            string sTruyVan = string.Format(@"update Table_LoaiLopHoc set TenLoaiLop=N'{0}',
            NgayThanhLap=N'{1}' where MaLoaiLop=N'{2}'", nv.TenLopHoc1, nv.NgayThanhLap1, nv.MaLopHoc1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaMaLop(DTO_MaLopHoc nv)
        {
            string sTruyVan = string.Format(@"delete from Table_LoaiLopHoc
            where MaLoaiLop='{0}'", nv.MaLopHoc1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_MaLopHoc TimMaLopTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_LoaiLopHoc where MaLoaiLop=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_MaLopHoc nv = new DTO_MaLopHoc();
            nv.MaLopHoc1 = dt.Rows[0]["MaLoaiLop"].ToString();
            nv.TenLopHoc1 = dt.Rows[0]["TenLoaiLop"].ToString();
            nv.NgayThanhLap1 = DateTime.Parse(dt.Rows[0]["NgayThanhLap"].ToString());
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
