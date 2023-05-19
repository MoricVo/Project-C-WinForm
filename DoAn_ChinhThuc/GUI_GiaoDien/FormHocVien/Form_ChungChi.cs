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
    public partial class Form_ChungChi : Form
    {
        public Form_ChungChi()
        {
            InitializeComponent();
            //HienThiDSNhanVienLenDatagrid();
        }

        private void Form_ChungChi_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            HienThiHocVienLenCombobox();
            
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
            List<DTO_ChungChi> lstNhanVien = BUS_ChungChi.LayDSChungChi();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaCC1"].HeaderText = "Mã số";
            dataGridView1.Columns["TenCC1"].HeaderText = "Tên chứng chỉ";
            dataGridView1.Columns["MaHV1"].HeaderText = "Học viên";
            dataGridView1.Columns["NgayCap1"].HeaderText = "Ngày cấp";
            dataGridView1.Columns["LoaiHinhDaoTao1"].HeaderText = "Loại hình đào tạo";
          //  dataGridView1.Columns["MaCC1"].Width = 75;
           //for(int i =0; i<dataGridView1.RowCount; i++)
           // {
           //     dataGridView1.Rows[i].Height = 35;
           // }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text == "" || txtTenCC.Text == "")
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
            DTO_ChungChi nv = new DTO_ChungChi();
            nv.MaCC1 = txtMaCC.Text;
            nv.TenCC1 = txtTenCC.Text;
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.NgayCap1 = (DateTime)dtpNgayLap.Value;
            nv.LoaiHinhDaoTao1= txtHinhThuc.Text;
          
            if (BUS_ChungChi.ThemChungChi(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            btnLamMoi_Click(sender, e);
            MessageBox.Show("Đã thêm chứng chỉ.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_ChungChi nv = new DTO_ChungChi();
                nv.MaCC1 = txtMaCC.Text;
                if (BUS_ChungChi.XoaChungChi(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa chứng chỉ.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text == "" || txtTenCC.Text == "")
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
            DTO_ChungChi nv = new DTO_ChungChi();
            nv.MaCC1 = txtMaCC.Text;
            nv.TenCC1 = txtTenCC.Text;
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.NgayCap1 = (DateTime)dtpNgayLap.Value;
            nv.LoaiHinhDaoTao1 = txtHinhThuc.Text;

            if (BUS_ChungChi.SuaChungChi(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm chứng chỉ.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaCC.Clear();
            txtTenCC.Clear();
            cboHocVien.SelectedValue = -1;
            dtpNgayLap.Value = DateTime.Now;
            txtHinhThuc.Clear();
        }

       

        private void btnTim_Click_1(object sender, EventArgs e)
        {

            List<DTO_ChungChi> ds = BUS_ChungChi.LayDSChungChi();
            List<DTO_ChungChi> kq = (from nv in ds
                                     where nv.MaCC1.Contains(txtTimMaHV.Text)
                                     // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                     select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaCC.Text = r.Cells["MaCC1"].Value.ToString();
                txtTenCC.Text = r.Cells["TenCC1"].Value.ToString();
                cboHocVien.SelectedValue = r.Cells["MaHV1"].Value.ToString();
                dtpNgayLap.Text = r.Cells["NgayCap1"].Value.ToString();
                txtHinhThuc.Text = r.Cells["LoaiHinhDaoTao1"].Value.ToString();







            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này chưa được cập nhật!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
