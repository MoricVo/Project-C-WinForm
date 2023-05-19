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
using System.Data.SqlClient;

namespace GUI_GiaoDien
{
    public partial class FormChinh : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public bool bDangNhap; // kiem tra dang nhap;
        Form_DangNhap dangNhap = null;
        public static string hoVaTen = "";
        string TenDangNhap = "";
        public static string HinhAnh;
     
        public FormChinh()
        {
            InitializeComponent();
            random = new Random();
            DongPanel();
        }
        private Color SelectThemeColor
        {
            get
            {
                int index = random.Next(ThemeColor.ColorList.Count);
                while (tempIndex == index)
                {
                    index = random.Next(ThemeColor.ColorList.Count);
                }
                tempIndex = index;
                string color = ThemeColor.ColorList[index];
                return ColorTranslator.FromHtml(color);
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                   // pnTieuDe.BackColor = color;
                   // pnLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                   // txtDangNhap.FillColor = color;
                    //txtThoiGian.FillColor = color;
                    guna2TextBox2.FillColor = color;


                }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnMenuMain.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(21,2,40);
                    previousBtn.ForeColor = Color.Gainsboro;
                    
                }
            }
        }
        private void DongPanel()
        {
            pnGiangVien.Visible = false;
            pnHocVien.Visible = false;
            pnHoaDon.Visible = false;
            pnLopHoc.Visible = false;
            pnNhanVien.Visible = false;
            pnThongKe.Visible = false;

        }
        private void MoPanel()
        {
            if (pnGiangVien.Visible == true)
                pnGiangVien.Visible = false;
            if (pnHocVien.Visible == true)
                pnHocVien.Visible = false;
            if (pnHoaDon.Visible == true)
                pnHoaDon.Visible = false;
            if (pnLopHoc.Visible == true)
                pnLopHoc.Visible = false;
            if (pnNhanVien.Visible == true)
                pnNhanVien.Visible = false;
            if (pnThongKe.Visible == true)
                pnThongKe.Visible = false;

        }
        private void ShowMenu(Panel HienThiMenu)
        {
            if (HienThiMenu.Visible == false)
            {
                MoPanel();
                HienThiMenu.Visible = true;
            }
            else
                HienThiMenu.Visible = false;

        }
        private new Form ActiveForm = null;
        private void OpenShortForm(Form Shortform)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();

            }
            ActiveForm = Shortform;
            Shortform.TopLevel = false;
            Shortform.FormBorderStyle = FormBorderStyle.None;
            Shortform.Dock = DockStyle.Fill;
            this.pnChildForm.Controls.Add(Shortform);
            this.pnChildForm.Tag = Shortform;
            Shortform.BringToFront();
            Shortform.Show();
            guna2TextBox2.Text = Shortform.Text;

        }

        private void btnNhanVienBig_Click(object sender, EventArgs e)
        {
           
            ShowMenu(pnNhanVien);
            ActivateButton(sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormNhanVien.Form_NhanVien());
            MoPanel();
           // ActivateButton(sender);
        }

        private void btnGiangVienBig_Click(object sender, EventArgs e)
        {
            
            ShowMenu(pnGiangVien);
            ActivateButton(sender);
        }

        private void btnGiangVienChinh_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormTroGiang.Form_GiangVienChinh());
            MoPanel();
           // ActivateButton(sender);
        }

        private void btnTroGiang_Click(object sender, EventArgs e)
        {
            
            OpenShortForm(new FormTroGiang.Form_TroGiang());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnLopHocBig_Click(object sender, EventArgs e)
        {
            
            ShowMenu(pnLopHoc);
            ActivateButton(sender);
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormLopHoc.Form_KhoaHoc());
            MoPanel();
           // ActivateButton(sender);
        }

        private void btnLoaiLopHoc_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormLopHoc.Form_LoaiLop());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormLopHoc.Form_LopHoc());
            MoPanel();
           // ActivateButton(sender);
        }

        private void btnHocVienBig_Click(object sender, EventArgs e)
        {
          
            ShowMenu(pnHocVien);
            ActivateButton(sender);
        }

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            
            OpenShortForm(new FormHocVien.Form_HocVien());
            MoPanel();
           // ActivateButton(sender);
        }

        private void btnDiemThi_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormHocVien.Form_DiemThi());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnChungChi_Click(object sender, EventArgs e)
        {
            
            OpenShortForm(new FormHocVien.Form_ChungChi());
            MoPanel();
           // ActivateButton(sender);
        }

        private void btnDangKiThi_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormHocVien.Form_DangKiThi());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnHoaDonBig_Click(object sender, EventArgs e)
        {
          
            ShowMenu(pnHoaDon);
            ActivateButton(sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            
            OpenShortForm(new FormHoaDon.Form_HoaDon());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           

            ShowMenu(pnThongKe);
            ActivateButton(sender);
        }

        private void btnDoanhThuThang_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormThongKe.Form_ThongKeThang());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnDoanhThuNam_Click(object sender, EventArgs e)
        {
            
            OpenShortForm(new FormThongKe.Form_ThongKeNam());
            MoPanel();
            //ActivateButton(sender);
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormHoTro.Form_HoTro());
            MoPanel();
            ActivateButton(sender);
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
           
            OpenShortForm(new FormThongBao.Form_ThongBao());
            MoPanel();
             ActivateButton(sender);
        }
       
        private void FormChinh_Load(object sender, EventArgs e)
        {
              chuadangnhap();
             DangNhap();
             FormFlash flash = new FormFlash();
             flash.ShowDialog();
            Day();
            //label6.Visible = false;
            //label7.Visible = false;
            //label17.Visible = false;
            //label18.Visible = false;
        

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label6.Text = "Bây giờ là:"+ DateTime.Now.ToString("HH:mm:ss");
            //label7.Text ="Hôm nay ngày:"+ DateTime.Now.ToString("MM/dd/yyyy");
            txtTG1.Text = "Now:" + DateTime.Now.ToString("HH:mm:ss");

        }
       
       

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap();
          
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Quantrivien()
        {
            btnHoaDonBig.Enabled = false;
            btnHocVienBig.Enabled = false;
            btnNhanVienBig.Enabled = true;
            btnGiangVienBig.Enabled = true;
            btnLopHocBig.Enabled = false;
            btnThongKe.Enabled = true;
            btnThongBao.Enabled = false;
            labelQuyenHan.Text = "Quản trị viên!";
            lbl2.Text = "" + hoVaTen.ToString();
            picPicture.Image = Image.FromFile(HinhAnh);
        }
        private void NhanVien()
        {
            btnHoaDonBig.Enabled =true;
            btnHocVienBig.Enabled = true;
            btnNhanVienBig.Enabled = false;
            btnGiangVienBig.Enabled = false;
            btnLopHocBig.Enabled = true;
            btnThongKe.Enabled = true;
            btnThongBao.Enabled = true;
            labelQuyenHan.Text = "Nhân viên!";
            lbl2.Text = "" + hoVaTen.ToString();
            picPicture.Image = Image.FromFile(HinhAnh);
        }
        private void chuadangnhap()
        {
            btnHoaDonBig.Enabled =false;
            btnHocVienBig.Enabled = false;
            btnNhanVienBig.Enabled = false;
            btnGiangVienBig.Enabled = false;
            btnLopHocBig.Enabled = false;
            btnThongKe.Enabled = false;
            btnThongBao.Enabled = false;
            labelQuyenHan.Text = "Chưa đăng nhập!";
           
        }
        private void GiamDoc()
        {
            btnHoaDonBig.Enabled = true;
            btnHocVienBig.Enabled = true;
            btnNhanVienBig.Enabled = true;
            btnGiangVienBig.Enabled = true;
            btnLopHocBig.Enabled = true;
            btnThongKe.Enabled = true;
            btnThongBao.Enabled = true;
            labelQuyenHan.Text = "Giám đốc!";
            lbl2.Text = "" + hoVaTen.ToString();
            //picPicture.Image = Image.FromFile(HinhAnh);
        }
      
     





        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new Form_DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                if (dangNhap.txtThemTK.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtThemTK.Focus();
                    goto LamLai;
                }
                else if (dangNhap.txtThemMK.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtThemMK.Focus();
                    goto LamLai;
                }
                else
                {
                    LopDuLieuDungChung dataTable = new LopDuLieuDungChung();
                    dataTable.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Table_NhanVien WHERE TaiKhoan = @TTK AND MatKhau = @MK");
                    cmd.Parameters.Add("@TTK", SqlDbType.NVarChar, 50).Value = dangNhap.txtThemTK.Text;
                    cmd.Parameters.Add("@MK", SqlDbType.NVarChar, 50).Value = dangNhap.txtThemMK.Text;
                   
                    dataTable.Fill(cmd);
                    if (dataTable.Rows.Count > 0)
                    {

                        hoVaTen = dataTable.Rows[0]["TenNV"].ToString();
                        string ChucVu = dataTable.Rows[0]["QuyenHan"].ToString();
                        TenDangNhap = dataTable.Rows[0]["TaiKhoan"].ToString();
                        HinhAnh = dataTable.Rows[0]["AnhDaiDien"].ToString();
                        if (ChucVu == "NhanVien")
                        {
                            MessageBox.Show("Đăng nhập thành công!Quyền Nhân Viên", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            NhanVien();
                        }
                        else if (ChucVu == "QuanTriVien")
                        {
                            MessageBox.Show("Đăng nhập thành công!Quyền Quản trị viên", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                             Quantrivien();
                        }
                        else if (ChucVu == "GiamDoc")
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           GiamDoc();
                        }
                       
                        else
                            chuadangnhap();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtThemTK.Focus();
                        goto LamLai;
                    }
                }
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            lbl2.Text = "";
            picPicture.Image = Image.FromFile(Application.StartupPath + "\\Resources\\55393-200.png");
            chuadangnhap();
        }

        private void pnTieuDe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DoiMatKhau doiMatKhau = new Form_DoiMatKhau(TenDangNhap);
            doiMatKhau.ShowDialog();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenShortForm(new FomDanhSach.Form_DSLop());
        }

       

     

    

      

      

        private void tạoGhiChúToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenShortForm(new FormNhacNho.Form_NhacNho());
        }

        private void tạoLịchLàmViệcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenShortForm(new FormNhacNho.Form_TaoGhiChu());
        }

        private void danhSáchHọcViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenShortForm(new FomDanhSach.Form_DSHocVien());
        }

        private void danhSáchĐiểmThiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenShortForm(new FomDanhSach.Form_DSDangKiThi());
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenShortForm(new FomDanhSach.Form_DSChungChi());
        }

        private void pnMenuMain_SystemColorsChanged(object sender, EventArgs e)
        {
            //pnMenuMain.BorderColor = Color.Red;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_DoubleClick(object sender, EventArgs e)
        {
            pnMenuMain.Visible = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            pnMenuMain.Visible =true;
        }

        private void FormChinh_MinimumSizeChanged(object sender, EventArgs e)
        {
           


        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ControlBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //label6.Visible = true;
            //label7.Visible = true;
            //label17.Visible = true;
            //label18.Visible = true;
        }

        private void guna2ControlBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        DateTime d1 = DateTime.Now;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }
        private void Day()
        {
            guna2Button1.Text = ("" + d1.Day);
            guna2Button2.Text = ("" + d1.Month);
            guna2Button3.Text = ("" + d1.Year);
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HDSD.chm");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form_ThongTin tt = new Form_ThongTin();
            tt.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void picPicture_Click(object sender, EventArgs e)
        {

        }

        private void txtTG1_Click(object sender, EventArgs e)
        {
          
        }
    }
    
}
