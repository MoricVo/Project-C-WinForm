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

namespace GUI_GiaoDien.FormThongKe
{
    public partial class Form_ThongKeNam : Form
    {
        public Form_ThongKeNam()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = null;
        string strketnoi = "Data Source= DESKTOP-HD4HHJ3\\SQLEXPRESS;  Initial Catalog=CSDL_DoAn_LTQL; Integrated Security=True";

        private void Form_ThongKeNam_Load(object sender, EventArgs e)
        {
            TongNhanVien();
            TongGiangVien();
            TongLopHoc();
            TongHocVien();
            TongHoaDon();
            TongChungChi();
            TongKhoaHoc();
        }
        public void TongNhanVien()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_NhanVien  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtNV.Text = "CÓ TẤT CẢ " + n + " NHÂN VIÊN";

        }
        public void TongGiangVien()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_GiangVienChinh  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtGiangVien.Text = "CÓ TẤT CẢ " + n + " GIẢNG VIÊN";

        }
        public void TongLopHoc()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_LopHoc  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtLopHoc1.Text = "CÓ TẤT CẢ " + n + " LỚP HỌC";

        }
        public void TongHocVien()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_HocVien  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtHocVien.Text = "CÓ TẤT CẢ " + n + " HỌC VIÊN";

        }
        public void TongHoaDon()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_HoaDon  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtHoaDon.Text = "CÓ TẤT CẢ " + n + " HÓA ĐƠN";

        }
        public void TongChungChi()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_ChungChi  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtChungChi.Text = "CÓ TẤT CẢ " + n + " CHỨNG CHỈ";

        }
        public void TongKhoaHoc()
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select count (*) from Table_KhoaHoc  ";
            command.Connection = ketnoi;
            object data = command.ExecuteScalar();
            int n = (int)data;
            txtKhoaHoc.Text = "CÓ TẤT CẢ " + n + " KHÓA HỌC";

        }

        private void txtNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
