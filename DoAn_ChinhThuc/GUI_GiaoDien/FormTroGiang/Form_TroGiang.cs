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
namespace GUI_GiaoDien.FormTroGiang
{
    public partial class Form_TroGiang : Form
    {
        public Form_TroGiang()
        {
            InitializeComponent();
        }

        private void Form_TroGiang_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_TroGiang> lstTroGiang = BUS_TroGiang.LayDSTroGiang();
            dataGridView1.DataSource = lstTroGiang;
            dataGridView1.Columns["MaTG1"].HeaderText = "Mã số";
            dataGridView1.Columns["TenTG1"].HeaderText = "Họ và tên";
            dataGridView1.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView1.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["DiaChi1"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["SDT1"].HeaderText = "SDT";
            dataGridView1.Columns["CCCD1"].HeaderText = "CCCD";


            dataGridView1.Columns["MaTG1"].Width = 60;
            dataGridView1.Columns["TenTG1"].Width = 60;
            dataGridView1.Columns["GioiTinh1"].Width = 60;
            dataGridView1.Columns["NgaySinh1"].Width = 60;
            dataGridView1.Columns["DiaChi1"].Width = 60;
            dataGridView1.Columns["SDT1"].Width = 60;
            dataGridView1.Columns["CCCD1"].Width = 60;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaTroGiang.Text = r.Cells["MaTG1"].Value.ToString();
                txtTenTroGiang.Text = r.Cells["TenTG1"].Value.ToString();
                if (r.Cells["GioiTinh1"].Value.ToString() == "Nam")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                dtpNgaySinh.Value = (DateTime)r.Cells["NgaySinh1"].Value;
                txtDiaChi.Text = r.Cells["DiaChi1"].Value.ToString();
                txtSDT.Text = r.Cells["SDT1"].Value.ToString();
                txtCCCD.Text = r.Cells["CCCD1"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTroGiang.Text == "" || txtTenTroGiang.Text == "")
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
            DTO_TroGiang nv = new DTO_TroGiang();
            nv.MaTG1 = txtMaTroGiang.Text;
            nv.TenTG1 = txtTenTroGiang.Text;
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
            nv.CCCD1 = txtCCCD.Text;
            if (BUS_TroGiang.ThemTroGiang(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm trợ giảng.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_TroGiang nv = new DTO_TroGiang();
                nv.MaTG1 = txtMaTroGiang.Text;
                if (BUS_TroGiang.XoaTroGiang(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa trợ giảng.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTroGiang.Text == "" || txtTenTroGiang.Text == "")
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
            DTO_TroGiang nv = new DTO_TroGiang();
            nv.MaTG1 = txtMaTroGiang.Text;
            nv.TenTG1 = txtTenTroGiang.Text;
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
            nv.CCCD1 = txtCCCD.Text;
            if (BUS_TroGiang.SuaTroGiang(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa trợ giảng.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTroGiang.Clear();
            txtTenTroGiang.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
        }

      

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            List<DTO_TroGiang> ds = BUS_TroGiang.LayDSTroGiang();
            List<DTO_TroGiang> kq = (from nv in ds
                                     where nv.TenTG1.Contains(txtTimHoGV.Text)
                                     // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                     select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được cập nhật!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTimHoGV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
