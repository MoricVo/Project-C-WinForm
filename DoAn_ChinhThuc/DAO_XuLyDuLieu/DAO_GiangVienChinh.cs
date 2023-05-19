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
    public class DAO_GiangVienChinh
    {
        static SqlConnection conn;
        public static List<DTO_GiangVienChinh> LayDSGiangVien()
        {
            string sTruyVan = "select * from Table_GiangVienChinh";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_GiangVienChinh> lstGiangVien = new List<DTO_GiangVienChinh>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_GiangVienChinh nv = new DTO_GiangVienChinh();
                nv.MaGV1 = dt.Rows[i]["MaGV"].ToString();
                nv.TenGV1 = dt.Rows[i]["TenGV"].ToString();
                nv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                nv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.DiaChi1 = dt.Rows[i]["DiaChi"].ToString();
                nv.SDT1 = dt.Rows[i]["SDT"].ToString();
                nv.CCCD1 = dt.Rows[i]["CCCD"].ToString();
               
                lstGiangVien.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstGiangVien;
        }
        public static bool ThemGiangVien(DTO_GiangVienChinh nv)
        {
            string sTruyVan = string.Format(@"insert into Table_GiangVienChinh values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')"
                , nv.MaGV1, nv.TenGV1, nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.SDT1, nv.CCCD1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaGiangVien(DTO_GiangVienChinh nv)
        {
            string sTruyVan = string.Format(@"update Table_GiangVienChinh set TenGV=N'{0}',
            GioiTinh=N'{1}', NgaySinh =N'{2}', DiaChi=N'{3}', SDT='{4}', CCCD=N'{5}'
            where MaGV=N'{6}'", nv.TenGV1,nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.SDT1, nv.CCCD1,nv.MaGV1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaGiangVien(DTO_GiangVienChinh nv)
        {
            string sTruyVan = string.Format(@"delete from Table_GiangVienChinh
            where MaGV='{0}'", nv.MaGV1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_GiangVienChinh TimGiangVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_GiangVienChinh where MaGV=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_GiangVienChinh nv = new DTO_GiangVienChinh();
            nv.MaGV1 = dt.Rows[0]["MaGV"].ToString();
            nv.TenGV1 = dt.Rows[0]["TenGV"].ToString();
            nv.GioiTinh1 = dt.Rows[0]["GioiTinh"].ToString();
            nv.NgaySinh1 = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            nv.DiaChi1 = dt.Rows[0]["DiaChi"].ToString();
            nv.SDT1 = dt.Rows[0]["SDT"].ToString();
            nv.CCCD1 = dt.Rows[0]["CCCD"].ToString();
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
