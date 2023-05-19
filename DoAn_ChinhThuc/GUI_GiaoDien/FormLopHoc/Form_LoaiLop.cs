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
    public partial class Form_LoaiLop : Form
    {
        public Form_LoaiLop()
        {
            InitializeComponent();
        }

        private void Form_LoaiLop_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_MaLopHoc> lstKhoaHoc = BUS_MaLopHoc.LayDSMaLop();
            dataGridView1.DataSource = lstKhoaHoc;
            dataGridView1.Columns["MaLopHoc1"].HeaderText = "Mã lớp học";
            dataGridView1.Columns["TenLopHoc1"].HeaderText = "Tên lớp học";
            dataGridView1.Columns["NgayThanhLap1"].HeaderText = "Ngày lập";



            dataGridView1.Columns["MaLopHoc1"].Width = 300;
            dataGridView1.Columns["TenLopHoc1"].Width = 300;
            dataGridView1.Columns["NgayThanhLap1"].Width = 300;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaLopHoc.Text = r.Cells["MaLopHoc1"].Value.ToString();
                txtTenLopHoc.Text = r.Cells["TenLopHoc1"].Value.ToString();
                dtpNgayLap.Value = (DateTime)r.Cells["NgayThanhLap1"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLopHoc.Text == "" || txtTenLopHoc.Text == "")
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
            DTO_MaLopHoc nv = new DTO_MaLopHoc();
            nv.MaLopHoc1 = txtMaLopHoc.Text;
            nv.TenLopHoc1 = txtTenLopHoc.Text;
            nv.NgayThanhLap1 = (DateTime)dtpNgayLap.Value;
            if (BUS_MaLopHoc.ThemMaLop(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm lớp học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_MaLopHoc nv = new DTO_MaLopHoc();
                nv.MaLopHoc1 = txtMaLopHoc.Text;
                if (BUS_MaLopHoc.XoaMaLop(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa mã lớp.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLopHoc.Text == "" || txtTenLopHoc.Text == "")
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
            DTO_MaLopHoc nv = new DTO_MaLopHoc();
            nv.MaLopHoc1 = txtMaLopHoc.Text;
            nv.TenLopHoc1 = txtTenLopHoc.Text;
            nv.NgayThanhLap1 = (DateTime)dtpNgayLap.Value;
            if (BUS_MaLopHoc.SuaMaLop(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa lớp học.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<DTO_MaLopHoc> ds = BUS_MaLopHoc.LayDSMaLop();
            List<DTO_MaLopHoc> kq = (from nv in ds
                                    where nv.MaLopHoc1.Contains(txtTim.Text)
                                    // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                    select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLopHoc.Clear();
            txtTenLopHoc.Clear();
            dtpNgayLap.Value = DateTime.Today;
        }
    }
}
