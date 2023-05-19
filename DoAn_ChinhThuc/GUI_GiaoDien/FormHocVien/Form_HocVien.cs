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
    public partial class Form_HocVien : Form
    {
        public Form_HocVien()
        {
            InitializeComponent();
        }

        private void Form_HocVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            HienThiMaLoaiLopLenCombobox();
            HienThiMaLopLenCombobox();
            HienThiKhoaHocLenCombobox();
        }
        private void HienThiMaLoaiLopLenCombobox()
        {
            List<DTO_MaLopHoc> lstChucVu = BUS_MaLopHoc.LayDSMaLop();
            cboMaLoaiLop.DataSource = lstChucVu;
            cboMaLoaiLop.DisplayMember = "TenLopHoc1";
            cboMaLoaiLop.ValueMember = "MaLopHoc1";
        }
        private void HienThiMaLopLenCombobox()
        {
            List<DTO_LopHoc> lstChucVu = BUS_LopHoc.LayDSLopHoc();
            cboMaLop.DataSource = lstChucVu;
            cboMaLop.DisplayMember = "TenLop1";
            cboMaLop.ValueMember = "MaLop1";
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
            List<DTO_HocVien> lstNhanVien = BUS_HocVien.LayDSHocVien();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaHV1"].HeaderText = "Mã số";
            dataGridView1.Columns["TenHV1"].HeaderText = "Tên học viên";
            dataGridView1.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView1.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["DiaChi1"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["SDT1"].HeaderText = "SDT";
            dataGridView1.Columns["MaLoaiLop1"].HeaderText = "Mã loại lớp";
            dataGridView1.Columns["MaLop1"].HeaderText = "Mã lớp";
            dataGridView1.Columns["MaKhoaHoc1"].HeaderText = "Khóa học";


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaHocVien.Text = r.Cells["MaHV1"].Value.ToString();
                txtTenHocVien.Text = r.Cells["TenHV1"].Value.ToString();
                if (r.Cells["GioiTinh1"].Value.ToString() == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                dtpNgaySinh.Value = (DateTime)r.Cells["NgaySinh1"].Value;
                txtDiaChi.Text = r.Cells["DiaChi1"].Value.ToString();
                txtSDT.Text = r.Cells["Sdt1"].Value.ToString();
                cboMaLoaiLop.SelectedValue = r.Cells["MaLoaiLop1"].Value.ToString();
                cboMaLop.SelectedValue = r.Cells["MaLop1"].Value.ToString();
                cboMaKhoaHoc.SelectedValue = r.Cells["MaKhoaHoc1"].Value.ToString();



            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHocVien.Text == "" || txtTenHocVien.Text == "")
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
            DTO_HocVien nv = new DTO_HocVien();
            nv.MaHV1 = txtMaHocVien.Text;
            nv.TenHV1 = txtTenHocVien.Text;
            if (rdNam.Checked == true)
            {
                nv.GioiTinh1 = "Nam";
            }
            else
            {
                nv.GioiTinh1 = "Nữ";
            }
            nv.NgaySinh1 = (DateTime)dtpNgaySinh.Value;
            nv.DiaChi1 = txtDiaChi.Text;
            nv.SDT1 = txtSDT.Text;
            nv.MaLoaiLop1 = cboMaLoaiLop.SelectedValue.ToString();
            nv.MaLop1 = cboMaLop.SelectedValue.ToString();
            nv.MaKhoaHoc1 = cboMaKhoaHoc.SelectedValue.ToString();
            if (BUS_HocVien.ThemHocVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm học viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_HocVien nv = new DTO_HocVien();
                nv.MaHV1 = txtMaHocVien.Text;
                if (BUS_HocVien.XoaHocVien(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa học viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHocVien.Text == "" || txtTenHocVien.Text == "")
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
            DTO_HocVien nv = new DTO_HocVien();
            nv.MaHV1 = txtMaHocVien.Text;
            nv.TenHV1 = txtTenHocVien.Text;
            if (rdNam.Checked == true)
            {
                nv.GioiTinh1 = "Nam";
            }
            else
            {
                nv.GioiTinh1 = "Nữ";
            }
            nv.NgaySinh1 = (DateTime)dtpNgaySinh.Value;
            nv.DiaChi1 = txtDiaChi.Text;
            nv.SDT1 = txtSDT.Text;
            nv.MaLoaiLop1 = cboMaLoaiLop.SelectedValue.ToString();
            nv.MaLop1 = cboMaLop.SelectedValue.ToString();
            nv.MaKhoaHoc1 = cboMaKhoaHoc.SelectedValue.ToString();
            if (BUS_HocVien.SuaLopHoc(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa học viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHocVien.Clear();
            txtTenHocVien.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtSDT.Clear();
            cboMaLoaiLop.SelectedValue = -1;
            cboMaLop.SelectedValue = -1;
            cboMaKhoaHoc.SelectedValue = -1;
        }

      
      
        private void btnTim_Click_1(object sender, EventArgs e)
        {
            List<DTO_HocVien> ds = BUS_HocVien.LayDSHocVien();
            List<DTO_HocVien> kq = (from nv in ds
                                    where nv.MaHV1.Contains(txtTimMaHocVien.Text)
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
            Report_Form.Report_HocVien rp = new Report_Form.Report_HocVien();
            rp.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
