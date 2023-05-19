using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
  public class DTO_HocVien
    {
        private string MaHV;
        private string TenHV;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string DiaChi;
        private string SDT;
        private string MaLoaiLop;
        private string MaLop;
        private string MaKhoaHoc;

        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string TenHV1 { get => TenHV; set => TenHV = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string MaLoaiLop1 { get => MaLoaiLop; set => MaLoaiLop = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string MaKhoaHoc1 { get => MaKhoaHoc; set => MaKhoaHoc = value; }
    }
}
