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
    public partial class Form_GiangVienChinh : Form
    {
        public Form_GiangVienChinh()
        {
            InitializeComponent();
        }

        private void Form_GiangVienChinh_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_GiangVienChinh> lstGiangVien = BUS_GiangVienChinh.LayDSNhanVien1();
            dataGridView1.DataSource = lstGiangVien;
            dataGridView1.Columns["MaGV1"].HeaderText = "Mã số";
            dataGridView1.Columns["TenGV1"].HeaderText = "Họ và tên";
            dataGridView1.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView1.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["DiaChi1"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["SDT1"].HeaderText = "SDT";
            dataGridView1.Columns["CCCD1"].HeaderText = "CCCD";


            dataGridView1.Columns["MaGV1"].Width = 60;
            dataGridView1.Columns["TenGV1"].Width = 60;
            dataGridView1.Columns["GioiTinh1"].Width = 60;
            dataGridView1.Columns["NgaySinh1"].Width = 60;
            dataGridView1.Columns["DiaChi1"].Width = 60;
            dataGridView1.Columns["SDT1"].Width = 60;
            dataGridView1.Columns["CCCD1"].Width = 60;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaGiangVien.Text = r.Cells["MaGV1"].Value.ToString();
                txtTenGiangVien.Text = r.Cells["TenGV1"].Value.ToString();
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

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void txtTimTenGV_Leave(object sender, EventArgs e)
        {

        }

        private void txtTimTenGV_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaGiangVien.Text == "" || txtTenGiangVien.Text == "")
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
            DTO_GiangVienChinh nv = new DTO_GiangVienChinh();
            nv.MaGV1 = txtMaGiangVien.Text;
            nv.TenGV1 = txtTenGiangVien.Text;
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
            if (BUS_GiangVienChinh.ThemGiangVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm giảng viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_GiangVienChinh nv = new DTO_GiangVienChinh();
                nv.MaGV1 = txtMaGiangVien.Text;
                if (BUS_GiangVienChinh.XoaGiangVien(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa giảng viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txtMaGiangVien.Text == "" || txtTenGiangVien.Text == "")
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
            DTO_GiangVienChinh nv = new DTO_GiangVienChinh();
            nv.MaGV1 = txtMaGiangVien.Text;
            nv.TenGV1 = txtTenGiangVien.Text;
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
            if (BUS_GiangVienChinh.SuaGiangVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa giảng viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGiangVien.Clear();
            txtTenGiangVien.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
        }

       

        private void btnTim_Click_2(object sender, EventArgs e)
        {
            List<DTO_GiangVienChinh> ds = BUS_GiangVienChinh.LayDSNhanVien1();
            List<DTO_GiangVienChinh> kq = (from nv in ds
                                           where nv.TenGV1.Contains(txtTimHoGV.Text)
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
