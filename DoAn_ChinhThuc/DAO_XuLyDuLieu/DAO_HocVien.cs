using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_DuLieu;
using System.Data.SqlClient;
using System.Data;
namespace DAO_XuLyDuLieu
{
   public class DAO_HocVien
    {
        static SqlConnection conn;
        public static List<DTO_HocVien> LayDSHocVien()
        {
            string sTruyVan = "select * from Table_HocVien";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_HocVien> lstNhanVien = new List<DTO_HocVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_HocVien nv = new DTO_HocVien();
                nv.MaHV1 = dt.Rows[i]["MaHV"].ToString();
                nv.TenHV1 = dt.Rows[i]["TenHV"].ToString();
                nv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                nv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.DiaChi1 = dt.Rows[i]["DiaChi"].ToString();
                nv.SDT1 = dt.Rows[i]["SDT"].ToString();
                nv.MaLoaiLop1 = dt.Rows[i]["MaLoaiLop"].ToString();
                nv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                nv.MaKhoaHoc1 = dt.Rows[i]["MaKhoaHoc"].ToString();
               
                lstNhanVien.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstNhanVien;
        }

        public static bool ThemHocVien(DTO_HocVien nv)
        {
            string sTruyVan = string.Format(@"insert into Table_HocVien values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}')"
                , nv.MaHV1, nv.TenHV1, nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.SDT1, nv.MaLoaiLop1, nv.MaLop1, nv.MaKhoaHoc1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaHocVien(DTO_HocVien nv)
        {
            string sTruyVan = string.Format(@"update Table_HocVien set TenHV=N'{0}',
             GioiTinh =N'{1}',NgaySinh=N'{2}',DiaChi=N'{3}', SDT=N'{4}',MaLoaiLop=N'{5}', MaLop=N'{6}',MaKhoaHoc=N'{7}'
            where MaHV=N'{8}'", nv.TenHV1, nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.SDT1, nv.MaLoaiLop1, nv.MaLop1, nv.MaKhoaHoc1,nv.MaHV1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaHocVien(DTO_HocVien nv)
        {
            string sTruyVan = string.Format(@"delete from Table_HocVien
            where MaHV='{0}'", nv.MaHV1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_HocVien TimHocVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_HocVien where MaHV=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_HocVien nv = new DTO_HocVien();
            nv.MaHV1 = dt.Rows[0]["MaHV"].ToString();
            nv.TenHV1 = dt.Rows[0]["TenHV"].ToString();
            nv.GioiTinh1 = dt.Rows[0]["GioiTinh"].ToString();
            nv.NgaySinh1 = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            nv.DiaChi1 = dt.Rows[0]["DiaChi"].ToString();
            nv.SDT1 = dt.Rows[0]["SDT"].ToString();
            nv.MaLoaiLop1 = dt.Rows[0]["MaLoaiLop"].ToString();
            nv.MaLop1 = dt.Rows[0]["MaLop"].ToString();
            nv.MaKhoaHoc1 = dt.Rows[0]["MaKhoaHoc"].ToString();
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
