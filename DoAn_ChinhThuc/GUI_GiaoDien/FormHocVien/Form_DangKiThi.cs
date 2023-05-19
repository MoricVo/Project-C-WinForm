using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_XuLyNghiepVu;
using DTO_DuLieu;
namespace GUI_GiaoDien.FormHocVien
{
    public partial class Form_DangKiThi : Form
    {
        public Form_DangKiThi()
        {
            InitializeComponent();
        }

        private void Form_DangKiThi_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            HienThiMaLopLenCombobox();
            HienThiHocVienLenCombobox();
        }
        private void HienThiHocVienLenCombobox()
        {
            List<DTO_HocVien> lstChucVu = BUS_HocVien.LayDSHocVien();
            cboHocVien.DataSource = lstChucVu;
            cboHocVien.DisplayMember = "TenHV1";
            cboHocVien.ValueMember = "MaHV1";
        }
        private void HienThiMaLopLenCombobox()
        {
            List<DTO_LopHoc> lstChucVu = BUS_LopHoc.LayDSLopHoc();
            cboMaLop.DataSource = lstChucVu;
            cboMaLop.DisplayMember = "TenLop1";
            cboMaLop.ValueMember = "MaLop1";
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_DangKiThi> lstNhanVien = BUS_DangKyThi.LayDSDangKiThi();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaHV1"].HeaderText = "Mã số";
            dataGridView1.Columns["NgayThi1"].HeaderText = "Ngày thi";
            dataGridView1.Columns["GioThi1"].HeaderText = "Giờ thi";
            dataGridView1.Columns["CaThi1"].HeaderText = "Ca thi";
            dataGridView1.Columns["MaLop1"].HeaderText = "Mã lớp";




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                cboHocVien.SelectedValue = r.Cells["MaHV1"].Value.ToString();
                dtpNgayThi.Text = r.Cells["NgayThi1"].Value.ToString();
                txtGioThi.Text = r.Cells["GioThi1"].Value.ToString();
                txtCaThi.Text = r.Cells["CaThi1"].Value.ToString();
                cboMaLop.SelectedValue = r.Cells["MaLop1"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGioThi.Text == "" || txtCaThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không l)
            //{
            //    MessageBox.Show("Mã nhân viên đã tồn tại!");
            //    return;
            //}
            DTO_DangKiThi nv = new DTO_DangKiThi();
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.NgayThi1 = (DateTime)dtpNgayThi.Value;
            nv.GioThi1 = txtGioThi.Text;
            nv.CaThi1 = txtCaThi.Text;
            nv.MaLop1 = cboMaLop.SelectedValue.ToString();

            if (BUS_DangKyThi.ThemDangKiThi(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm lịch thi.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_DangKiThi nv = new DTO_DangKiThi();
                nv.MaHV1 = cboHocVien.SelectedValue.ToString();
                if (BUS_DangKyThi.XoaDangKiThi(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa lịch thi.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtGioThi.Text == "" || txtCaThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không l)
            //{
            //    MessageBox.Show("Mã nhân viên đã tồn tại!");
            //    return;
            //}
            DTO_DangKiThi nv = new DTO_DangKiThi();
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.NgayThi1 = (DateTime)dtpNgayThi.Value;
            nv.GioThi1 = txtGioThi.Text;
            nv.CaThi1 = txtCaThi.Text;
            nv.MaLop1 = cboMaLop.SelectedValue.ToString();

            if (BUS_DangKyThi.SuaDangKiThi(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa lịch thi.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboHocVien.SelectedValue = -1;
            dtpNgayThi.Value = DateTime.Now;
            txtGioThi.Clear();
            txtCaThi.Clear();
            cboMaLop.SelectedValue = -1;
        }

      

        private void btnTim_Click_1(object sender, EventArgs e)
        {

            List<DTO_DangKiThi> ds = BUS_DangKyThi.LayDSDangKiThi();
            List<DTO_DangKiThi> kq = (from nv in ds
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
