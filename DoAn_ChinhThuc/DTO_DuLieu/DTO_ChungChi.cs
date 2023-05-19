using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
   public class DTO_ChungChi
    {
        private string MaCC;
        private string TenCC;
        private string MaHV;
        private DateTime NgayCap;
        private string LoaiHinhDaoTao;

        public string MaCC1 { get => MaCC; set => MaCC = value; }
        public string TenCC1 { get => TenCC; set => TenCC = value; }
        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public DateTime NgayCap1 { get => NgayCap; set => NgayCap = value; }
        public string LoaiHinhDaoTao1 { get => LoaiHinhDaoTao; set => LoaiHinhDaoTao = value; }
    }
}
