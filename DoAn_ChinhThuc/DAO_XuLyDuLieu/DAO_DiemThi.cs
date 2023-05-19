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
   public class DAO_DiemThi
    {
        static SqlConnection conn;
        public static List<DTO_DiemThi> LayDSDiemThi()
        {
            string sTruyVan = "select * from Table_DiemThiKetThuc";
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DTO_DiemThi> lstNhanVien = new List<DTO_DiemThi>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DTO_DiemThi nv = new DTO_DiemThi();
                nv.MaHV1 = dt.Rows[i]["MaHV"].ToString();
                nv.DiemThucHanh1 = float.Parse(dt.Rows[i]["DiemThucHanh"].ToString());
                nv.DiemTracNghiem1 = float.Parse(dt.Rows[i]["DiemTracNghiem"].ToString());
                nv.DiemTuDuyLogic1 = float.Parse(dt.Rows[i]["DiemTuDuyLogic"].ToString());
                nv.DiemGiangVienDanhGia1 = float.Parse(dt.Rows[i]["DiemGiangVienDanhGia"].ToString());
                nv.DiemTB1 = float.Parse(dt.Rows[i]["DiemTB"].ToString());
                nv.XepLoai1 = dt.Rows[i]["XepLoai"].ToString();
                nv.ChungChi1 = dt.Rows[i]["ChungChi"].ToString();


                lstNhanVien.Add(nv);
            }
            MyDataTable.DongKetNoi(conn);
            return lstNhanVien;
        }

        public static bool ThemDiemThi(DTO_DiemThi nv)
        {
            string sTruyVan = string.Format(@"insert into Table_DiemThiKetThuc values(N'{0}', N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}',N'{7}')"
                , nv.MaHV1, nv.DiemThucHanh1, nv.DiemTracNghiem1, nv.DiemTuDuyLogic1, nv.DiemGiangVienDanhGia1, nv.DiemTB1, nv.XepLoai1, nv.ChungChi1
                );

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);

            MyDataTable.DongKetNoi(conn);
            return kq;

        }
        public static bool SuaDiemThi(DTO_DiemThi nv)
        {
            string sTruyVan = string.Format(@"update Table_DiemThiKetThuc set DiemThucHanh=N'{0}',
             DiemTracNghiem =N'{1}',DiemTuDuyLogic=N'{2}',DiemGiangVienDanhGia=N'{3}', DiemTB=N'{4}',XepLoai=N'{5}', ChungChi=N'{6}'
            where MaHV=N'{7}'", nv.DiemThucHanh1, nv.DiemTracNghiem1, nv.DiemTuDuyLogic1, nv.DiemGiangVienDanhGia1, nv.DiemTB1, nv.XepLoai1, nv.ChungChi1, nv.MaHV1);
            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static bool XoaDiemThi(DTO_DiemThi nv)
        {
            string sTruyVan = string.Format(@"delete from Table_DiemThiKetThuc
            where MaHV='{0}'", nv.MaHV1);

            conn = MyDataTable.MoKetNoi();
            bool kq = MyDataTable.TruyVanKhongLayDuLieu(sTruyVan, conn);
            MyDataTable.DongKetNoi(conn);
            return kq;
        }
        public static DTO_DiemThi TimDiemThiTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from Table_DiemThiKetThuc where MaHV=N'{0}'", ma);
            conn = MyDataTable.MoKetNoi();
            DataTable dt = MyDataTable.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            DTO_DiemThi nv = new DTO_DiemThi();
            nv.MaHV1 = dt.Rows[0]["MaHV"].ToString();
            nv.DiemThucHanh1 = float.Parse(dt.Rows[0]["DiemThucHanh"].ToString());
            nv.DiemTracNghiem1 = float.Parse(dt.Rows[0]["DiemTracNghiem"].ToString());
            nv.DiemTuDuyLogic1 = float.Parse(dt.Rows[0]["DiemTuDuyLogic"].ToString());
            nv.DiemGiangVienDanhGia1 = float.Parse(dt.Rows[0]["DiemGiangVienDanhGia"].ToString());
            nv.DiemTB1 = float.Parse(dt.Rows[0]["DiemTB"].ToString());
            nv.XepLoai1 = dt.Rows[0]["XepLoai"].ToString();
            nv.ChungChi1 = dt.Rows[0]["ChungChi"].ToString();
            MyDataTable.DongKetNoi(conn);
            return nv;
        }
    }
}
