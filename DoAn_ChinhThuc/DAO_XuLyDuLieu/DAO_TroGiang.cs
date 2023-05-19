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
   public class DAO_TroGiang
    {
        static SqlConnection conn;
        public static List<DTO_TroGiang> LayDSTroGiang()
        {
            string sTruyVan = "select * from Table_TroGiang";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_TroGiang> lstTroGiang = new List<DTO_TroGiang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_TroGiang nv = new DTO_TroGiang();
                nv.MaTG1 = dt.Rows[i]["MaTG"].ToString();
                nv.TenTG1 = dt.Rows[i]["TenTG"].ToString();
                nv.GioiTinh1 = dt.Rows[i]["GioiTinh"].ToString();
                nv.NgaySinh1 = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.DiaChi1 = dt.Rows[i]["DiaChi"].ToString();
                nv.SDT1 = dt.Rows[i]["SDT"].ToString();
                nv.CCCD1 = dt.Rows[i]["CCCD"].ToString();

                lstTroGiang.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstTroGiang;
        }
        public static bool ThemTroGiang(DTO_TroGiang nv)
        {
            string sTruyVan = string.Format(@"insert into Table_TroGiang values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')"
                , nv.MaTG1, nv.TenTG1, nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.SDT1, nv.CCCD1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaTroGiang(DTO_TroGiang nv)
        {
            string sTruyVan = string.Format(@"update Table_TroGiang set TenTG=N'{0}',
            GioiTinh=N'{1}', NgaySinh =N'{2}', DiaChi=N'{3}', SDT='{4}', CCCD=N'{5}'
            where MaTG=N'{6}'", nv.TenTG1, nv.GioiTinh1, nv.NgaySinh1, nv.DiaChi1, nv.SDT1, nv.CCCD1, nv.MaTG1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaTroGiang(DTO_TroGiang nv)
        {
            string sTruyVan = string.Format(@"delete from Table_TroGiang
            where MaTG='{0}'", nv.MaTG1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_TroGiang TimTroGiangTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_TroGiang where MaTG=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_TroGiang nv = new DTO_TroGiang();
            nv.MaTG1 = dt.Rows[0]["MaTG"].ToString();
            nv.TenTG1 = dt.Rows[0]["TenTG"].ToString();
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

