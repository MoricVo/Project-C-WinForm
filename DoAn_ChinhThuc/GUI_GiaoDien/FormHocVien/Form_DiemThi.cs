using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_DuLieu;
using BUS_XuLyNghiepVu;
namespace GUI_GiaoDien.FormHocVien
{
    public partial class Form_DiemThi : Form
    {
        public Form_DiemThi()
        {
            InitializeComponent();
        }

        private void Form_DiemThi_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            HienThiHocVienLenCombobox();
            DiemTB();
        }
        private void HienThiHocVienLenCombobox()
        {
            List<DTO_HocVien> lstChucVu = BUS_HocVien.LayDSHocVien();
            cboHocVien.DataSource = lstChucVu;
            cboHocVien.DisplayMember = "TenHV1";
            cboHocVien.ValueMember = "MaHV1";
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_DiemThi> lstNhanVien = BUS_DiemThi.LayDSDiemThi();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaHV1"].HeaderText = "Mã số";
            dataGridView1.Columns["DiemThucHanh1"].HeaderText = "Diểm thực hành";
            dataGridView1.Columns["DiemTracNghiem1"].HeaderText = "Điểm trắc nghiệm";
            dataGridView1.Columns["DiemTuDuyLogic1"].HeaderText = "Điểm tư duy logic";
            dataGridView1.Columns["DiemGiangVienDanhGia1"].HeaderText = "Điểm giảng viên đánh giá";
            dataGridView1.Columns["DiemTB1"].HeaderText = "Điểm trung bình";
            dataGridView1.Columns["XepLoai1"].HeaderText = "Xếp loại";
            dataGridView1.Columns["ChungChi1"].HeaderText = "Chứng chỉ";
          


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                cboHocVien.SelectedValue = r.Cells["MaHV1"].Value.ToString();
                txtDiemTH.Text = r.Cells["DiemThucHanh1"].Value.ToString();
                txtDiemTN.Text = r.Cells["DiemTracNghiem1"].Value.ToString();
                txtDiemTD.Text = r.Cells["DiemTuDuyLogic1"].Value.ToString();
                txtDiemGV.Text = r.Cells["DiemGiangVienDanhGia1"].Value.ToString();
                txtDiemTB.Text = r.Cells["DiemTB1"].Value.ToString();


              txtXepLoai.Text = r.Cells["XepLoai1"].Value.ToString();
                 cboChungChi.Text= r.Cells["ChungChi1"].Value.ToString();
               



            }
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiemTH.Text == "" || txtDiemTN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            //if (txtSDT.Text.Length > 5)
            //{
            //    MessageBox.Show("Số điện thoại phải trên 5 số!");
            //    return;
            //}
            // Kiểm tra mã nhân viên có bị trùng không
            //if (NhanVienBUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            //{
            //    MessageBox.Show("Mã nhân viên đã tồn tại!");
            //    return;
            //}
           
            DTO_DiemThi nv = new DTO_DiemThi();
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.DiemThucHanh1 = float.Parse(txtDiemTH.Text.ToString());
            nv.DiemTracNghiem1 = float.Parse(txtDiemTN.Text.ToString());
            nv.DiemTuDuyLogic1 = float.Parse(txtDiemTD.Text.ToString());
            nv.DiemGiangVienDanhGia1 = float.Parse(txtDiemGV.Text.ToString());
            nv.DiemTB1 = float.Parse(txtDiemTB.Text.ToString());
            nv.XepLoai1 = txtXepLoai.Text;
           
            nv.ChungChi1 = cboChungChi.Text;
            
            if (BUS_DiemThi.ThemDiemThi(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm điểm thi!.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_DiemThi nv = new DTO_DiemThi();
                nv.MaHV1 = cboHocVien.SelectedValue.ToString();
                if (BUS_DiemThi.XoaDiemThi(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa điểm thi.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDiemTH.Text == "" || txtDiemTN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            //if (txtSDT.Text.Length > 5)
            //{
            //    MessageBox.Show("Số điện thoại phải trên 5 số!");
            //    return;
            //}
            // Kiểm tra mã nhân viên có bị trùng không
            //if (NhanVienBUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            //{
            //    MessageBox.Show("Mã nhân viên đã tồn tại!");
            //    return;
            //}
            DTO_DiemThi nv = new DTO_DiemThi();
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.DiemThucHanh1 = float.Parse(txtDiemTH.Text.ToString());
            nv.DiemTracNghiem1 = float.Parse(txtDiemTN.Text.ToString());
            nv.DiemTuDuyLogic1 = float.Parse(txtDiemTD.Text.ToString());
            nv.DiemGiangVienDanhGia1 = float.Parse(txtDiemGV.Text.ToString());
            nv.DiemTB1 = float.Parse(txtDiemTB.Text.ToString());
            nv.XepLoai1 = txtXepLoai.Text;
            nv.ChungChi1 = cboChungChi.Text;

            if (BUS_DiemThi.SuaDiemThi(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm điểm thi!.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboHocVien.SelectedValue = 1;
            txtDiemTH.Clear();
            txtDiemTN.Clear();
            txtDiemTD.Clear();
            txtDiemGV.Clear();
            txtXepLoai.Clear();
            cboChungChi.Text = "";
        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void DiemTB()
        {
            txtDiemTB.Enabled = false;
        }

      

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            List<DTO_DiemThi> ds = BUS_DiemThi.LayDSDiemThi();
            List<DTO_DiemThi> kq = (from nv in ds
                                    where nv.MaHV1.Contains(txtTimMaHV.Text)
                                    // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                    select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được cập nhật!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
