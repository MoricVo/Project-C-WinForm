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
    public class DAO_NhanVien
    {
        static SqlConnection conn;
        public static List<DTO_NhanVien> LayDSNhanVien()
        {
            string sTruyVan = "select * from Table_NhanVien";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_NhanVien> lstNhanVien = new List<DTO_NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.MaNhanVien1 = dt.Rows[i]["MaNV"].ToString();
                nv.TenNhanVien1 = dt.Rows[i]["TenNV"].ToString();
                nv.TaiKhoan1 = dt.Rows[i]["TaiKhoan"].ToString();
                nv.MatKhau1 = dt.Rows[i]["MatKhau"].ToString();
                nv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                nv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.DiaChi1 = dt.Rows[i]["DiaChi"].ToString();
                nv.AnhDaiDien1 = dt.Rows[i]["AnhDaiDien"].ToString();
                nv.Sdt1 = dt.Rows[i]["SDT"].ToString();
                nv.QuyenHan1 = dt.Rows[i]["QuyenHan"].ToString();
                nv.LoaiNhanVien1 = dt.Rows[i]["LoaiNV"].ToString();
                nv.MaQuyenHan1 = int.Parse(dt.Rows[i]["MaQuyenHan"].ToString());
                lstNhanVien.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstNhanVien;
        }
     
        public static bool ThemNhanVien(DTO_NhanVien nv)
        {
            string sTruyVan = string.Format(@"insert into Table_NhanVien values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}')"
                , nv.MaNhanVien1,nv.TenNhanVien1, nv.TaiKhoan1, nv.MatKhau1,nv.GioiTinh1,nv.NgaySinh1,nv.DiaChi1,nv.AnhDaiDien1,nv.Sdt1,nv.QuyenHan1,nv.LoaiNhanVien1,nv.MaQuyenHan1
                );
            
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaNhanVien(DTO_NhanVien nv)
        {
            string sTruyVan = string.Format(@"update Table_NhanVien set TenNV=N'{0}',
            TaiKhoan=N'{1}', MatKhau =N'{2}', GioiTinh=N'{3}', NgaySinh='{4}', DiaChi=N'{5}', AnhDaiDien=N'{6}', SDT='{7}', QuyenHan=N'{8}',LoaiNV=N'{9}',MaQuyenHan='{10}'
            where MaNV=N'{11}'",nv.TenNhanVien1 ,nv.TaiKhoan1, nv.MatKhau1, nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.AnhDaiDien1, nv.Sdt1, nv.QuyenHan1, nv.LoaiNhanVien1,nv.MaQuyenHan1,nv.MaNhanVien1);
            conn =MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
             MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaNhanVien(DTO_NhanVien nv)
        {
            string sTruyVan = string.Format(@"delete from Table_NhanVien
            where MaNV='{0}'", nv.MaNhanVien1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_NhanVien TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_NhanVien where MaNV=N'{0}'", ma);
            conn =MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.MaNhanVien1 = dt.Rows[0]["MaNV"].ToString();
            nv.TenNhanVien1 = dt.Rows[0]["TenNV"].ToString();
            nv.TaiKhoan1 = dt.Rows[0]["TaiKhoan"].ToString();
            nv.MatKhau1 = dt.Rows[0]["MatKhau"].ToString();
            nv.GioiTinh1 = dt.Rows[0]["GioiTinh"].ToString();
            nv.NgaySinh1 = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            nv.DiaChi1 = dt.Rows[0]["DiaChi"].ToString();
            nv.AnhDaiDien1 = dt.Rows[0]["AnhDaiDien"].ToString();
            nv.Sdt1 = dt.Rows[0]["SDT"].ToString();
            nv.QuyenHan1 = dt.Rows[0]["QuyenHan"].ToString();
            nv.LoaiNhanVien1 = dt.Rows[0]["LoaiNV"].ToString();
            nv.MaQuyenHan1 = int.Parse(dt.Rows[0]["MaQuyenHan"].ToString());
            MyDataTable.DongKetNoi(conn);
            return nv;
        }

    }
}
