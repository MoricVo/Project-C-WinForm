using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
  public class DTO_TroGiang
    {
        private string MaTG;
        private string TenTG;
        private string GioiTinh;
        private DateTime NgaySinh;
        private string DiaChi;
        private string SDT;
        private string CCCD;

        public string MaTG1 { get => MaTG; set => MaTG = value; }
        public string TenTG1 { get => TenTG; set => TenTG = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
    }
}
