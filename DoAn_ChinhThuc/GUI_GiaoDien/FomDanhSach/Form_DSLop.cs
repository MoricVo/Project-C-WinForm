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

namespace GUI_GiaoDien.FomDanhSach
{
    public partial class Form_DSLop : Form
    {
        public Form_DSLop()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = null;
        string strketnoi = "Data Source= DESKTOP-HD4HHJ3\\SQLEXPRESS;  Initial Catalog=CSDL_DoAn_LTQL; Integrated Security=True";

        private void Form_DSLop_Load(object sender, EventArgs e)
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Table_GiangVienChinh";
            command.Connection = ketnoi;
            lbDanhMuc.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            int n = 0;
            while (reader.Read())//Có Dữ Liệu
            {

                n++;
                string Line = reader.GetString(0) + "-" + reader.GetString(1);
                lbDanhMuc.Items.Add("STT." + n);
                lbDanhMuc.Items.Add(Line);

            }
            reader.Close();
        }

        private void lbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDanhMuc.SelectedIndex == -1)

                return;

            string line = lbDanhMuc.SelectedItem.ToString();
            string[] arr = line.Split('-');
            string ma = (arr[0]);
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Table_LopHoc where MaGV=@mqq";
            command.Connection = ketnoi;
            SqlParameter parameter = new SqlParameter("@mqq", SqlDbType.NVarChar);
            parameter.Value = ma;
            command.Parameters.Add(parameter);
            lvDanhMuc.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            int m = 0;
           
            while (reader.Read())//Có Dữ Liệu
            {
                string MaLop = reader.GetString(0);
                string TenLop = reader.GetString(1);
                string SiSo = reader.GetString(2);
                //string CMND = reader.GetString(3);
                string GioHoc = reader.GetString(4);
                string NgayHoc = reader.GetString(5);
                string SoPhong = reader.GetString(6);
                string MaLoaiLop = reader.GetString(7);
                string GV = reader.GetString(8);
                string TG = reader.GetString(9);
                string KhoaHoc = reader.GetString(10);
                ListViewItem lvi = new ListViewItem(MaLop + "");
                lvi.SubItems.Add(TenLop);
                lvi.SubItems.Add(SiSo);
                lvi.SubItems.Add(GioHoc);
                // lvi.SubItems.Add(GioiTinh);
                lvi.SubItems.Add(NgayHoc);
                lvi.SubItems.Add(SoPhong);
                lvi.SubItems.Add(MaLoaiLop);
                lvi.SubItems.Add(GV);
                lvi.SubItems.Add(TG);
                lvi.SubItems.Add(KhoaHoc);
           
                lvDanhMuc.Items.Add(lvi);
                m++;



            }
            if (m > 0)
            {
                txtTim.Text = "CÓ " + m + " GIẢNG VIÊN ĐANG CÒN GIẢNG DẠY CÓ MÃ SỐ LÀ " + ma + " ";
            }
            else
            {
                txtTim.Text = "GIẢNG VIÊN NÀY CHƯA CÓ TRONG DANH SÁCH GIẢNG DẠY!";
            }    
            reader.Close();

        }
    }
}
