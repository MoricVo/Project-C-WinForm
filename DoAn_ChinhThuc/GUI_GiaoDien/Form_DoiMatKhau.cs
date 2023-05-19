using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_DuLieu;
using BUS_XuLyNghiepVu;
namespace GUI_GiaoDien
{
    public partial class Form_DoiMatKhau : Form
    {
        string TenTaiKhoan = "";
        LopDuLieuDungChung datable = new LopDuLieuDungChung();
        public Form_DoiMatKhau(string tk)
        {
            TenTaiKhoan = tk;
            datable.OpenConnection();
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.Text == txtXacNhan.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Table_NhanVien SET MatKhau=@mk WHERE TaiKhoan=@tk");
                cmd.Parameters.Add("@tk", SqlDbType.NVarChar).Value = TenTaiKhoan;
                cmd.Parameters.Add("@mk", SqlDbType.NVarChar).Value = txtMKMoi.Text;
                datable.Update(cmd);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();

            }
            else
            {
                MessageBox.Show("Mật khẩu sai!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTen.Text ="Người dùng: "+ FormChinh.hoVaTen;
            
        }
    }
}
