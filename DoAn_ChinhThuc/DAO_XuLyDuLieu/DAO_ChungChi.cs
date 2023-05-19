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
   public class DAO_ChungChi
    {
        static SqlConnection conn;
        public static List<DTO_ChungChi> LayDSChungChi()
        {
            string sTruyVan = "select * from Table_ChungChi";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_ChungChi> lstKhoaHoc = new List<DTO_ChungChi>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_ChungChi nv = new DTO_ChungChi();
                nv.MaCC1 = dt.Rows[i]["MaCC"].ToString();
                nv.TenCC1 = dt.Rows[i]["TenCC"].ToString();
                nv.MaHV1 = dt.Rows[i]["MaHV"].ToString();
                nv.NgayCap1 = DateTime.Parse(dt.Rows[i]["NgayCap"].ToString());
                nv.LoaiHinhDaoTao1 = dt.Rows[i]["LoaiHinhDaoTao"].ToString();


                lstKhoaHoc.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstKhoaHoc;
        }
        public static bool ThemChungChi(DTO_ChungChi nv)
        {
            string sTruyVan = string.Format(@"insert into Table_ChungChi values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')"
                , nv.MaCC1, nv.TenCC1, nv.MaHV1,nv.NgayCap1,nv.LoaiHinhDaoTao1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaChungChi(DTO_ChungChi nv)
        {
            string sTruyVan = string.Format(@"update Table_ChungChi set TenCC=N'{0}',MaHV=N'{1}',NgayCap=N'{2}',LoaiHinhDaoTao=N'{3}'
            where MaCC=N'{4}'", nv.TenCC1, nv.MaHV1, nv.NgayCap1, nv.LoaiHinhDaoTao1,nv.MaCC1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaChungChi(DTO_ChungChi nv)
        {
            string sTruyVan = string.Format(@"delete from Table_ChungChi
            where MaCC='{0}'", nv.MaCC1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_ChungChi TimChungChiTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_ChungChi where MaCC=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_ChungChi nv = new DTO_ChungChi();
            nv.MaCC1 = dt.Rows[0]["MaCC"].ToString();
            nv.TenCC1 = dt.Rows[0]["TenCC"].ToString();
            nv.MaHV1 = dt.Rows[0]["MaHV"].ToString();
            nv.NgayCap1 = DateTime.Parse(dt.Rows[0]["NgayCap"].ToString());
            nv.LoaiHinhDaoTao1 = dt.Rows[0]["LoaiHinhDaoTao"].ToString();
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
