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
    public partial class Form_DSDangKiThi : Form
    {
        public Form_DSDangKiThi()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi = null;
        string strketnoi = "Data Source= DESKTOP-HD4HHJ3\\SQLEXPRESS;  Initial Catalog=CSDL_DoAn_LTQL; Integrated Security=True";
        private void Form_DSDangKiThi_Load(object sender, EventArgs e)
        {
            if (ketnoi == null)
                ketnoi = new SqlConnection(strketnoi);
            if (ketnoi.State == ConnectionState.Closed)
                ketnoi.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Table_HocVien";
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
            command.CommandText = "select * from Table_DangKiThi where MaHV=@mqq";
            command.Connection = ketnoi;
            SqlParameter parameter = new SqlParameter("@mqq", SqlDbType.NVarChar);
            parameter.Value = ma;
            command.Parameters.Add(parameter);
            lvDanhMuc.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            int m = 0;

            while (reader.Read())//Có Dữ Liệu
            {
                string MaHV = reader.GetString(0);
                string GioThi = reader.GetString(2);
                //  string SiSo = reader.GetString(4);
                //string CMND = reader.GetString(3);
                string CaThi = reader.GetString(3);
                string  MaLop= reader.GetString(4);
             
                ;
                ListViewItem lvi = new ListViewItem(MaHV + "");
                lvi.SubItems.Add(GioThi);
                // lvi.SubItems.Add(SiSo);
                lvi.SubItems.Add(CaThi);
               
                lvi.SubItems.Add(MaLop);
               


                lvDanhMuc.Items.Add(lvi);
                m++;



            }
            if (m > 0)
            {
                txtTim.Text = "HỌC VIÊN CÓ MÃ "+ma+" ĐÃ ĐĂNG KÝ THI";
            }
            else
            {
                txtTim.Text = "HỌC VIÊN NÀY CHƯA ĐANG KÝ THI!";
            }
            reader.Close();
        }
    }
}
