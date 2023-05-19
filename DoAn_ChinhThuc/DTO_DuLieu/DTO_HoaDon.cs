using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
    public class DTO_HoaDon
    {
        private string MaHD;
        private DateTime NgayLapHD;
        private string MaNV;
        private string MaHV;
        private string MaLop;
        private int TienHP;

        public string MaHD1 { get => MaHD; set => MaHD = value; }
        public DateTime NgayLapHD1 { get => NgayLapHD; set => NgayLapHD = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public int TienHP1 { get => TienHP; set => TienHP = value; }
    }
}
