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
   public class DAO_LopHoc
    {
        static SqlConnection conn;
        public static List<DTO_LopHoc> LayDSLopHoc()
        {
            string sTruyVan = "select * from Table_LopHoc";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_LopHoc> lstNhanVien = new List<DTO_LopHoc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_LopHoc nv = new DTO_LopHoc();
                nv.MaLop1 = dt.Rows[i]["MaLop"].ToString();
                nv.TenLop1 = dt.Rows[i]["TenLop"].ToString();
                nv.SiSo1 = dt.Rows[i]["SiSo"].ToString();
                nv.NgayBatDau1 = DateTime.Parse(dt.Rows[i]["NgayBD"].ToString());
                nv.GioHoc1 = dt.Rows[i]["GioHoc"].ToString();
                nv.NgayHoc1 = dt.Rows[i]["NgayHoc"].ToString();
                nv.SoPhong1 = dt.Rows[i]["SoPhong"].ToString();
                nv.MaLoaiLop1 = dt.Rows[i]["MaLoaiLop"].ToString();
                nv.MaGV1 = dt.Rows[i]["MaGV"].ToString();
                nv.MaTG1 = dt.Rows[i]["MaTG"].ToString();
                nv.MaKH1 = dt.Rows[i]["MaKhoaHoc"].ToString();

                lstNhanVien.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstNhanVien;
        }

        public static bool ThemLopHoc(DTO_LopHoc nv)
        {
            string sTruyVan = string.Format(@"insert into Table_LopHoc values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')"
                , nv.MaLop1, nv.TenLop1, nv.SiSo1, nv.NgayBatDau1, nv.GioHoc1, nv.NgayHoc1, nv.SoPhong1, nv.MaLoaiLop1, nv.MaGV1, nv.MaTG1, nv.MaKH1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaLopHoc(DTO_LopHoc nv)
        {
            string sTruyVan = string.Format(@"update Table_LopHoc set TenLop=N'{0}',
             SiSo =N'{1}',NgayBD=N'{2}', GioHoc=N'{3}', NgayHoc=N'{4}',SoPhong=N'{5}', MaLoaiLop=N'{6}', MaGV=N'{7}',MaTG=N'{8}',MaKhoaHoc=N'{9}'
            where MaLop=N'{10}'", nv.TenLop1, nv.SiSo1, nv.NgayBatDau1, nv.GioHoc1, nv.NgayHoc1, nv.SoPhong1, nv.MaLoaiLop1, nv.MaGV1, nv.MaTG1, nv.MaKH1, nv.MaLop1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaLopHoc(DTO_LopHoc nv)
        {
            string sTruyVan = string.Format(@"delete from Table_LopHoc
            where MaLop='{0}'", nv.MaLop1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_LopHoc TimLopHocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_LopHoc where MaLop=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_LopHoc nv = new DTO_LopHoc();
            nv.MaLop1 = dt.Rows[0]["MaLop"].ToString();
            nv.TenLop1 = dt.Rows[0]["TenLop"].ToString();
            nv.SiSo1 = dt.Rows[0]["SiSo"].ToString();
            nv.NgayBatDau1 = DateTime.Parse(dt.Rows[0]["NgayBD"].ToString());
            nv.GioHoc1 = dt.Rows[0]["GioHoc"].ToString();
            nv.NgayHoc1 = dt.Rows[0]["NgayHoc"].ToString();
            nv.SoPhong1 = dt.Rows[0]["SoPhong"].ToString();
            nv.MaLoaiLop1 = dt.Rows[0]["MaLoaiLop"].ToString();
            nv.MaGV1 = dt.Rows[0]["MaGV"].ToString();
            nv.MaTG1 = dt.Rows[0]["MaTG"].ToString();
            nv.MaKH1 = dt.Rows[0]["MaKhoaHoc"].ToString();
            MyDataTable.DongKetNoi(conn);
            return nv;
        }

    }
}
