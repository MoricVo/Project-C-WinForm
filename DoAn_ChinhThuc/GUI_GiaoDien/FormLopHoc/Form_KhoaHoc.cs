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
    public partial class Form_KhoaHoc : Form
    {
        public Form_KhoaHoc()
        {
            InitializeComponent();
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_KhoaHoc> lstKhoaHoc = BUS_KhoaHoc.LayDSKhoaHoc();
            dataGridView1.DataSource = lstKhoaHoc;
            dataGridView1.Columns["MaKhoaHoc1"].HeaderText = "Mã khóa học";
            dataGridView1.Columns["TenKhoaHoc1"].HeaderText = "Tên khóa học";
            dataGridView1.Columns["NgayLap1"].HeaderText = "Ngày lập";
         


            dataGridView1.Columns["MaKhoaHoc1"].Width = 300;
            dataGridView1.Columns["TenKhoaHoc1"].Width = 300;
            dataGridView1.Columns["NgayLap1"].Width = 300;
          


        }

        private void Form_KhoaHoc_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaKhoaHoc.Text = r.Cells["MaKhoaHoc1"].Value.ToString();
                txtTenKhoaHoc.Text = r.Cells["TenKhoaHoc1"].Value.ToString();
                dtpNgayLap.Value = (DateTime)r.Cells["NgayLap1"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoaHoc.Text == "" || txtTenKhoaHoc.Text == "")
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
            DTO_KhoaHoc nv = new DTO_KhoaHoc();
            nv.MaKhoaHoc1 = txtMaKhoaHoc.Text;
            nv.TenKhoaHoc1 = txtTenKhoaHoc.Text;
            nv.NgayLap1 = (DateTime)dtpNgayLap.Value;
            if (BUS_KhoaHoc.ThemKhoaHoc(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm khóa học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_KhoaHoc nv = new DTO_KhoaHoc();
                nv.MaKhoaHoc1 = txtMaKhoaHoc.Text;
                if (BUS_KhoaHoc.XoaKhoaHoc(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa khóa học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoaHoc.Text == "" || txtTenKhoaHoc.Text == "")
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
            DTO_KhoaHoc nv = new DTO_KhoaHoc();
            nv.MaKhoaHoc1 = txtMaKhoaHoc.Text;
            nv.TenKhoaHoc1 = txtTenKhoaHoc.Text;
            nv.NgayLap1 = (DateTime)dtpNgayLap.Value;
            if (BUS_KhoaHoc.SuaKhoaHoc(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa khóa học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được cập nhật!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<DTO_KhoaHoc> ds = BUS_KhoaHoc.LayDSKhoaHoc();
            List<DTO_KhoaHoc> kq = (from nv in ds
                                           where nv.MaKhoaHoc1.Contains(txtTim.Text)
                                           // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                           select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhoaHoc.Clear();
            txtTenKhoaHoc.Clear();
            dtpNgayLap.Value = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
