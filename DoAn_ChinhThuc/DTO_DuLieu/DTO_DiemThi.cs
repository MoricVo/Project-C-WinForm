using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DuLieu
{
   public class DTO_DiemThi
    {
        private string MaHV;
        private float DiemThucHanh;
        private float DiemTracNghiem;
        private float DiemTuDuyLogic;
        private float DiemGiangVienDanhGia;
        private float DiemTB;
        private string XepLoai;
        private string ChungChi;

        public string MaHV1 { get => MaHV; set => MaHV = value; }
        public float DiemThucHanh1 { get => DiemThucHanh; set => DiemThucHanh = value; }
        public float DiemTracNghiem1 { get => DiemTracNghiem; set => DiemTracNghiem = value; }
        public float DiemTuDuyLogic1 { get => DiemTuDuyLogic; set => DiemTuDuyLogic = value; }
        public float DiemGiangVienDanhGia1 { get => DiemGiangVienDanhGia; set => DiemGiangVienDanhGia = value; }
        public float DiemTB1 { get => DiemTB=(DiemThucHanh1+DiemTracNghiem1+DiemTuDuyLogic1+DiemGiangVienDanhGia1)/4; set => DiemTB = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }
        public string ChungChi1 { get => ChungChi; set => ChungChi = value; }
    }
}
