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
namespace GUI_GiaoDien.FormLopHoc
{
    public partial class Form_LopHoc : Form
    {
        public Form_LopHoc()
        {
            InitializeComponent();
        }

        private void Form_LopHoc_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            HienThiMaLoaiLopLenCombobox();
            HienThiMaGiangVienLenCombobox();
            HienThiMaTroGiangLenCombobox();
            HienThiKhoaHocLenCombobox();
        }
        private void HienThiMaLoaiLopLenCombobox()
        {
            List<DTO_MaLopHoc> lstChucVu = BUS_MaLopHoc.LayDSMaLop();
            cboMaLoaiLop.DataSource = lstChucVu;
            cboMaLoaiLop.DisplayMember = "TenLopHoc1";
            cboMaLoaiLop.ValueMember = "MaLopHoc1";
        }
        private void HienThiMaGiangVienLenCombobox()
        {
            List<DTO_GiangVienChinh> lstChucVu = BUS_GiangVienChinh.LayDSNhanVien1();
            cboMaGiangVien.DataSource = lstChucVu;
            cboMaGiangVien.DisplayMember = "TenGV1";
            cboMaGiangVien.ValueMember = "MaGV1";
        }
        private void HienThiMaTroGiangLenCombobox()
        {
            List<DTO_TroGiang> lstChucVu = BUS_TroGiang.LayDSTroGiang();
            cboMaTroGiang.DataSource = lstChucVu;
            cboMaTroGiang.DisplayMember = "TenTG1";
            cboMaTroGiang.ValueMember = "MaTG1";
        }
        private void HienThiKhoaHocLenCombobox()
        {
            List<DTO_KhoaHoc> lstChucVu = BUS_KhoaHoc.LayDSKhoaHoc();
            cboMaKhoaHoc.DataSource = lstChucVu;
            cboMaKhoaHoc.DisplayMember = "TenKhoaHoc1";
            cboMaKhoaHoc.ValueMember = "MaKhoaHoc1";
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_LopHoc> lstNhanVien = BUS_LopHoc.LayDSLopHoc();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaLop1"].HeaderText = "Mã số";
            dataGridView1.Columns["TenLop1"].HeaderText = "Tên lớp";
            dataGridView1.Columns["SiSo1"].HeaderText = "Sỉ số";
            dataGridView1.Columns["NgayBatDau1"].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns["GioHoc1"].HeaderText = "Giờ học";
            dataGridView1.Columns["NgayHoc1"].HeaderText = "Ngày học";
            dataGridView1.Columns["SoPhong1"].HeaderText = "Số phòng";
            dataGridView1.Columns["MaLoaiLop1"].HeaderText = "Mã loại lớp";
            dataGridView1.Columns["MaGV1"].HeaderText = "Tên giảng viên";
            dataGridView1.Columns["MaTG1"].HeaderText = "Tên trợ giảng";
            dataGridView1.Columns["MaKH1"].HeaderText = "Khóa học";
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaLopHoc.Text = r.Cells["MaLop1"].Value.ToString();
                txtTenLop.Text = r.Cells["TenLop1"].Value.ToString();
                txtSiSo.Text = r.Cells["SiSo1"].Value.ToString();
                dtpNgayBD.Value = (DateTime)r.Cells["NgayBatDau1"].Value;
                txtGioHoc.Text = r.Cells["GioHoc1"].Value.ToString();
                txtNgayHoc.Text = r.Cells["NgayHoc1"].Value.ToString();
                txtSoPhong.Text = r.Cells["SoPhong1"].Value.ToString();
                cboMaLoaiLop.SelectedValue = r.Cells["MaLoaiLop1"].Value.ToString();
                cboMaGiangVien.SelectedValue = r.Cells["MaGV1"].Value.ToString();
                cboMaTroGiang.SelectedValue = r.Cells["MaTG1"].Value.ToString();
                cboMaKhoaHoc.SelectedValue = r.Cells["MaKH1"].Value.ToString();


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLopHoc.Text == "" || txtTenLop.Text == "")
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
            DTO_LopHoc nv = new DTO_LopHoc();
            nv.MaLop1 = txtMaLopHoc.Text;
            nv.TenLop1 = txtTenLop.Text;
            nv.SiSo1 = txtSiSo.Text;
            nv.NgayBatDau1 = (DateTime)dtpNgayBD.Value;
            nv.GioHoc1 = txtGioHoc.Text;
            nv.NgayHoc1 = txtNgayHoc.Text;
            nv.SoPhong1 = txtSoPhong.Text;
            nv.MaLoaiLop1 = cboMaLoaiLop.SelectedValue.ToString();
            nv.MaGV1 = cboMaGiangVien.SelectedValue.ToString();
            nv.MaTG1 = cboMaTroGiang.SelectedValue.ToString();
            nv.MaKH1 = cboMaKhoaHoc.SelectedValue.ToString();
            if (BUS_LopHoc.ThemLopHoc(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm lớp học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_LopHoc nv = new DTO_LopHoc();
                nv.MaLop1 = txtMaLopHoc.Text;
                if (BUS_LopHoc.XoaLopHoc(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa lớp học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLopHoc.Text == "" || txtTenLop.Text == "")
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
            DTO_LopHoc nv = new DTO_LopHoc();
            nv.MaLop1 = txtMaLopHoc.Text;
            nv.TenLop1 = txtTenLop.Text;
            nv.SiSo1 = txtSiSo.Text;
            nv.NgayBatDau1 = (DateTime)dtpNgayBD.Value;
            nv.GioHoc1 = txtGioHoc.Text;
            nv.NgayHoc1 = txtNgayHoc.Text;
            nv.SoPhong1 = txtSoPhong.Text;
            nv.MaLoaiLop1 = cboMaLoaiLop.SelectedValue.ToString();
            nv.MaGV1 = cboMaGiangVien.SelectedValue.ToString();
            nv.MaTG1 = cboMaTroGiang.SelectedValue.ToString();
            nv.MaKH1 = cboMaKhoaHoc.SelectedValue.ToString();
            if (BUS_LopHoc.SuaLopHoc(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm lớp học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLopHoc.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
            dtpNgayBD.Value = DateTime.Now;
            txtGioHoc.Clear();
            txtNgayHoc.Clear();
            txtSoPhong.Clear();
            cboMaGiangVien.SelectedValue = -1;
            cboMaTroGiang.SelectedValue = -1;
            cboMaLoaiLop.SelectedValue = -1;
            cboMaKhoaHoc.SelectedValue = -1;

        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {

            List<DTO_LopHoc> ds = BUS_LopHoc.LayDSLopHoc();
            List<DTO_LopHoc> kq = (from nv in ds
                                   where nv.MaLop1.Contains(txtTimMaLop.Text)
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
    }
}
