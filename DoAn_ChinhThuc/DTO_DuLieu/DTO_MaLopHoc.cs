using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
   public class DTO_MaLopHoc
    {
        private string MaLopHoc;
        private string TenLopHoc;
        private DateTime NgayThanhLap;

        public string MaLopHoc1 { get => MaLopHoc; set => MaLopHoc = value; }
        public string TenLopHoc1 { get => TenLopHoc; set => TenLopHoc = value; }
        public DateTime NgayThanhLap1 { get => NgayThanhLap; set => NgayThanhLap = value; }
    }
}
