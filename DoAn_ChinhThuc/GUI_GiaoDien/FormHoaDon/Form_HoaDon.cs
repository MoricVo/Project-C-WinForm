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
namespace GUI_GiaoDien.FormHoaDon
{
    public partial class Form_HoaDon : Form
    {
        public Form_HoaDon()
        {
            InitializeComponent();
            HienThiDSNhanVienLenDatagrid();
           
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienLenDatagrid();
            HienThiMaLoaiLopLenCombobox();
            HienThiHocVienLenCombobox();
            HienThiMaNVLenCombobox();
        }
        private void HienThiMaLoaiLopLenCombobox()
        {
            List<DTO_LopHoc> lstChucVu = BUS_LopHoc.LayDSLopHoc();
            cboMaLop.DataSource = lstChucVu;
            cboMaLop.DisplayMember = "TenLop1";
            cboMaLop.ValueMember = "MaLop1";
            
        }
        private void HienThiMaNVLenCombobox()
        {
            List<DTO_NhanVien> lstChucVu = BUS_NhanVien.LayDSNhanVien1();
            cboNhanVien.DataSource = lstChucVu;
            cboNhanVien.DisplayMember = "TenNhanVien1";
            cboNhanVien.ValueMember = "MaNhanVien1";
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
            List<DTO_HoaDon> lstNhanVien = BUS_HoaDon.LayDSHoaDon();
            dataGridView1.DataSource = lstNhanVien;
            dataGridView1.Columns["MaHD1"].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns["NgayLapHD1"].HeaderText = "Ngày lập hóa đơn";
            dataGridView1.Columns["MaNV1"].HeaderText = "Nhân viên lập";
            dataGridView1.Columns["MaHV1"].HeaderText = "Học viên";
            dataGridView1.Columns["MaLop1"].HeaderText = "Mã lớp";
            dataGridView1.Columns["TienHP1"].HeaderText = "Học phí";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = this.dataGridView1.Rows[e.RowIndex];
                txtMaHD.Text = r.Cells["MaHD1"].Value.ToString();
                dtpNgayLap.Text = r.Cells["NgayLapHD1"].Value.ToString();
                cboNhanVien.SelectedValue = r.Cells["MaNV1"].Value.ToString();
                cboHocVien.SelectedValue = r.Cells["MaHV1"].Value.ToString();
                cboMaLop.SelectedValue = r.Cells["MaLop1"].Value.ToString();
                txtTienHP.Text = r.Cells["TienHP1"].Value.ToString();







            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtTienHP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
         
            DTO_HoaDon nv = new DTO_HoaDon();
            nv.MaHD1 = txtMaHD.Text;
            nv.NgayLapHD1 = (DateTime)dtpNgayLap.Value;
            nv.MaNV1 = cboNhanVien.SelectedValue.ToString();
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.MaLop1 = cboMaLop.SelectedValue.ToString();

            nv.TienHP1=int.Parse(txtTienHP.Text.ToString());

            if (BUS_HoaDon.ThemHoaDon(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm hóa đơn.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Xóa",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_HoaDon nv = new DTO_HoaDon();
                nv.MaHD1 = txtMaHD.Text;
                if (BUS_HoaDon.XoaHoaDon(nv) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa hóa đơn.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtTienHP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            DTO_HoaDon nv = new DTO_HoaDon();
            nv.MaHD1 = txtMaHD.Text;
            nv.NgayLapHD1 = (DateTime)dtpNgayLap.Value;
            nv.MaNV1 = cboNhanVien.SelectedValue.ToString();
            nv.MaHV1 = cboHocVien.SelectedValue.ToString();
            nv.MaLop1 = cboMaLop.SelectedValue.ToString();

            nv.TienHP1 = int.Parse(txtTienHP.Text.ToString());

            if (BUS_HoaDon.SuaHoaDon(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã sửa hóa đơn.", "Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            dtpNgayLap.Value = DateTime.Now;
            cboNhanVien.SelectedValue = -1;
            cboHocVien.SelectedValue = -1;
            cboMaLop.SelectedValue = -1;
            txtTienHP.Clear();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<DTO_HoaDon> ds = BUS_HoaDon.LayDSHoaDon();
            List<DTO_HoaDon> kq = (from nv in ds
                                     where nv.MaHD1.Contains(txtTimMaHV.Text)
                                     // where nv.TaiKhoan1.Contains(txtTimTenNV.Text)
                                     select nv).ToList();
            dataGridView1.DataSource = kq;
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            FormThongBao.Form_ThongBao tb = new FormThongBao.Form_ThongBao();
            tb.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
