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
namespace GUI_GiaoDien.FormNhanVien
{
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<DTO_NhanVien> lstNhanVien = BUS_NhanVien.LayDSNhanVien1();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaNhanVien1"].HeaderText = "Mã số";
            dataGridView1.Columns["TenNhanVien1"].HeaderText = "Họ và tên";
            dataGridView1.Columns["TaiKhoan1"].HeaderText = "Tài khoản";
            dataGridView1.Columns["MatKhau1"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["GioiTinh1"].HeaderText = "Giới tính";
            dataGridView1.Columns["NgaySinh1"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["DiaChi1"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["AnhDaiDien1"].HeaderText = "Link ảnh";
            dataGridView1.Columns["Sdt1"].HeaderText = "SDT";
            dataGridView1.Columns["QuyenHan1"].HeaderText = "Quyền hạn";
            dataGridView1.Columns["LoaiNhanVien1"].HeaderText = "Loại nhân viên";
            dataGridView1.Columns["MaQuyenHan1"].HeaderText = "Mã Quyền Hạn";
            dataGridView1.Columns["MaNhanVien1"].Width = 60;
            dataGridView1.Columns["TenNhanVien1"].Width = 60;
            dataGridView1.Columns["TaiKhoan1"].Width = 60;
            dataGridView1.Columns["MatKhau1"].Width = 60;
            dataGridView1.Columns["GioiTinh1"].Width = 60;
            dataGridView1.Columns["NgaySinh1"].Width = 60;
            dataGridView1.Columns["DiaChi1"].Width = 60;
            dataGridView1.Columns["AnhDaiDien1"].Width = 60;
            dataGridView1.Columns["Sdt1"].Width = 60;
            dataGridView1.Columns["QuyenHan1"].Width = 60;
            dataGridView1.Columns["LoaiNhanVien1"].Width = 60;
            dataGridView1.Columns["MaQuyenHan1"].Width = 60;

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];            
                txtMaNhanVien.Text = r.Cells["MaNhanVien1"].Value.ToString();
                txtTenNhanVien.Text = r.Cells["TenNhanVien1"].Value.ToString();
                txtTaiKhoan.Text = r.Cells["TaiKhoan1"].Value.ToString();
                txtMatKhau.Text = r.Cells["MatKhau1"].Value.ToString();
                if (r.Cells["GioiTinh1"].Value.ToString() == "1")
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                dtpNgaySinh.Value = (DateTime)r.Cells["NgaySinh1"].Value;
                txtDiaChi.Text = r.Cells["DiaChi1"].Value.ToString();
                txtDuongDan.Text = r.Cells["AnhDaiDien1"].Value.ToString();
                txtSDT.Text = r.Cells["Sdt1"].Value.ToString();
                cboQuyenHan.Text = r.Cells["QuyenHan1"].Value.ToString();
                cboLoaiNhanVien.Text = r.Cells["LoaiNhanVien1"].Value.ToString();
                txtMaQuyenHan.Text =r.Cells["MaQuyenHan1"].Value.ToString();
                if (txtDuongDan.Text.Trim() != "")
                {
                    try
                    {
                        picHinh.Image = Image.FromFile(txtDuongDan.Text);
                    }
                    catch
                    {
                        picHinh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\55393-200.png");
                    }
                }
                
                
            }
        }

        private void picHinh_Click(object sender, EventArgs e)
        {
           
        }

        private void txtDuongDan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTimHoNV_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtTimHoNV_Leave(object sender, EventArgs e)
        {
        }

        private void txtTimHoNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimTenNV_Leave(object sender, EventArgs e)
        {
        }

        private void txtTimTenNV_Enter(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.MaNhanVien1 = txtMaNhanVien.Text;
            if (BUS_NhanVien.XoaNhanVien(nv) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã xóa nhân viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtDuongDan.Clear();
            txtSDT.Clear();
            cboQuyenHan.Text="";
            cboLoaiNhanVien.Text="";
            txtMaQuyenHan.Clear();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            List<DTO_NhanVien> ds = BUS_NhanVien.LayDSNhanVien1();
            List<DTO_NhanVien> kq = (from nv in ds
                                     where nv.MaNhanVien1.Contains(txtTimHoNV.Text)
                                     // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                     select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void picHinh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 5;
            // dlgOpen.InitialDirectory = Application.StartupPath + "\\Resources\\Image_khohang";
            dlgOpen.Title = "Chọn ảnh cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {

                //txtAnh.Text = dlgOpen.FileName;               
                txtDuongDan.Text = dlgOpen.FileName;
                picHinh.Image = Image.FromFile(txtDuongDan.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click_2(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "")
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
            //Kiểm tra mã nhân viên có bị trùng không
            //if (BUS_NhanVien.TimNhanVienTheoMa(txtMaNhanVien.Text) != null)
            //{
            //    MessageBox.Show("Mã nhân viên đã tồn tại!");
            //    return;
            //}
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.MaNhanVien1 = txtMaNhanVien.Text;
            nv.TenNhanVien1 = txtTenNhanVien.Text;
            nv.TaiKhoan1 = txtTaiKhoan.Text;
            nv.MatKhau1 = txtMatKhau.Text;
            if (rdNam.Checked == true)
            {
                nv.GioiTinh1 = "Nam";
            }
            else
            {
                nv.GioiTinh1 = "Nữ";
            }
            nv.NgaySinh1 = DateTime.Parse(dtpNgaySinh.Text);
            nv.DiaChi1 = txtDiaChi.Text;
            nv.AnhDaiDien1 = txtDuongDan.Text;
            nv.Sdt1 = txtSDT.Text;
            nv.QuyenHan1 = cboQuyenHan.Text.ToString();
            nv.LoaiNhanVien1 = cboLoaiNhanVien.Text.ToString();
            nv.MaQuyenHan1 = int.Parse(txtMaQuyenHan.Text.ToString());
            if (BUS_NhanVien.SuaNhanVien(nv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa nhân viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.MaNhanVien1 = txtMaNhanVien.Text;
                if (BUS_NhanVien.XoaNhanVien(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa nhân viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Clear();
            txtDuongDan.Clear();
            txtSDT.Clear();
            cboQuyenHan.Text = "";
            cboLoaiNhanVien.Text = "";
            txtMaQuyenHan.Clear();
        }

        private void btnThem_Click_2(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "")
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
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.MaNhanVien1 = txtMaNhanVien.Text;
            nv.TenNhanVien1 = txtTenNhanVien.Text;
            nv.TaiKhoan1 = txtTaiKhoan.Text;
            nv.MatKhau1 = txtMatKhau.Text;
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
            nv.AnhDaiDien1 = txtDuongDan.Text;
            nv.Sdt1 = txtSDT.Text;
            nv.QuyenHan1 = cboQuyenHan.Text.ToString();
            nv.LoaiNhanVien1 = cboLoaiNhanVien.Text.ToString();
            nv.MaQuyenHan1 = int.Parse(txtMaQuyenHan.Text.ToString());
            if (BUS_NhanVien.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được cập nhật!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
