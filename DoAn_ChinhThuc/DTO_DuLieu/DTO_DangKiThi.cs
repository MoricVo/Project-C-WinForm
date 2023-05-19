using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
  public class DTO_DangKiThi
    {
        private string MaHV;
        private DateTime NgayThi;
        private string GioThi;
        private string CaThi;
        private string MaLop;

        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public DateTime NgayThi1 { get => NgayThi; set => NgayThi = value; }
        public string GioThi1 { get => GioThi; set => GioThi = value; }
        public string CaThi1 { get => CaThi; set => CaThi = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
    }
}
