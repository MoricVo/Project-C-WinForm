
namespace GUI_GiaoDien.FormHocVien
{
    partial class Form_ChungChi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboHocVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtHinhThuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMaCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimTenHocVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimMaHV = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.cboHocVien);
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Controls.Add(this.txtHinhThuc);
            this.panel1.Controls.Add(this.txtTenCC);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaCC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 749);
            this.panel1.TabIndex = 3;
            // 
            // cboHocVien
            // 
            this.cboHocVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.cboHocVien.BorderColor = System.Drawing.Color.Yellow;
            this.cboHocVien.BorderRadius = 8;
            this.cboHocVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHocVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.cboHocVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboHocVien.FocusedState.Parent = this.cboHocVien;
            this.cboHocVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHocVien.ForeColor = System.Drawing.Color.White;
            this.cboHocVien.FormattingEnabled = true;
            this.cboHocVien.HoverState.Parent = this.cboHocVien;
            this.cboHocVien.ItemHeight = 30;
            this.cboHocVien.ItemsAppearance.Parent = this.cboHocVien;
            this.cboHocVien.Location = new System.Drawing.Point(6, 153);
            this.cboHocVien.Name = "cboHocVien";
            this.cboHocVien.ShadowDecoration.Parent = this.cboHocVien;
            this.cboHocVien.Size = new System.Drawing.Size(264, 36);
            this.cboHocVien.TabIndex = 40;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.BorderRadius = 7;
            this.dtpNgayLap.CheckedState.Parent = this.dtpNgayLap;
            this.dtpNgayLap.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayLap.FillColor = System.Drawing.Color.Red;
            this.dtpNgayLap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.ForeColor = System.Drawing.Color.White;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.HoverState.Parent = this.dtpNgayLap;
            this.dtpNgayLap.Location = new System.Drawing.Point(7, 223);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.ShadowDecoration.Parent = this.dtpNgayLap;
            this.dtpNgayLap.Size = new System.Drawing.Size(263, 44);
            this.dtpNgayLap.TabIndex = 9;
            this.dtpNgayLap.Value = new System.DateTime(2022, 4, 9, 19, 2, 13, 482);
            // 
            // txtHinhThuc
            // 
            this.txtHinhThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtHinhThuc.BorderColor = System.Drawing.Color.Yellow;
            this.txtHinhThuc.BorderRadius = 8;
            this.txtHinhThuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHinhThuc.DefaultText = "";
            this.txtHinhThuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHinhThuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHinhThuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHinhThuc.DisabledState.Parent = this.txtHinhThuc;
            this.txtHinhThuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHinhThuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtHinhThuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHinhThuc.FocusedState.Parent = this.txtHinhThuc;
            this.txtHinhThuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhThuc.ForeColor = System.Drawing.Color.White;
            this.txtHinhThuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHinhThuc.HoverState.Parent = this.txtHinhThuc;
            this.txtHinhThuc.Location = new System.Drawing.Point(7, 294);
            this.txtHinhThuc.Margin = new System.Windows.Forms.Padding(6);
            this.txtHinhThuc.Name = "txtHinhThuc";
            this.txtHinhThuc.PasswordChar = '\0';
            this.txtHinhThuc.PlaceholderText = "Loại hình đào tạo";
            this.txtHinhThuc.SelectedText = "";
            this.txtHinhThuc.ShadowDecoration.Parent = this.txtHinhThuc;
            this.txtHinhThuc.Size = new System.Drawing.Size(266, 40);
            this.txtHinhThuc.TabIndex = 38;
            // 
            // txtTenCC
            // 
            this.txtTenCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTenCC.BorderColor = System.Drawing.Color.Yellow;
            this.txtTenCC.BorderRadius = 8;
            this.txtTenCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCC.DefaultText = "";
            this.txtTenCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCC.DisabledState.Parent = this.txtTenCC;
            this.txtTenCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTenCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCC.FocusedState.Parent = this.txtTenCC;
            this.txtTenCC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCC.ForeColor = System.Drawing.Color.White;
            this.txtTenCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCC.HoverState.Parent = this.txtTenCC;
            this.txtTenCC.Location = new System.Drawing.Point(6, 87);
            this.txtTenCC.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenCC.Name = "txtTenCC";
            this.txtTenCC.PasswordChar = '\0';
            this.txtTenCC.PlaceholderText = "Tên chứng chỉ";
            this.txtTenCC.SelectedText = "";
            this.txtTenCC.ShadowDecoration.Parent = this.txtTenCC;
            this.txtTenCC.Size = new System.Drawing.Size(266, 40);
            this.txtTenCC.TabIndex = 35;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.FillColor2 = System.Drawing.Color.Red;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(53, 574);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(169, 45);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.FillColor2 = System.Drawing.Color.Red;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(53, 502);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(169, 45);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(53, 426);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(169, 45);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa thông tin";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.FillColor2 = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(53, 352);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(169, 45);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm thông tin";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaCC
            // 
            this.txtMaCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtMaCC.BorderColor = System.Drawing.Color.Yellow;
            this.txtMaCC.BorderRadius = 8;
            this.txtMaCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCC.DefaultText = "";
            this.txtMaCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCC.DisabledState.Parent = this.txtMaCC;
            this.txtMaCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtMaCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCC.FocusedState.Parent = this.txtMaCC;
            this.txtMaCC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCC.ForeColor = System.Drawing.Color.White;
            this.txtMaCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaCC.HoverState.Parent = this.txtMaCC;
            this.txtMaCC.Location = new System.Drawing.Point(7, 17);
            this.txtMaCC.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaCC.Name = "txtMaCC";
            this.txtMaCC.PasswordChar = '\0';
            this.txtMaCC.PlaceholderText = "Mã chứng chỉ";
            this.txtMaCC.SelectedText = "";
            this.txtMaCC.ShadowDecoration.Parent = this.txtMaCC;
            this.txtMaCC.Size = new System.Drawing.Size(266, 40);
            this.txtMaCC.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.guna2GradientButton6);
            this.panel2.Controls.Add(this.txtTimTenHocVien);
            this.panel2.Controls.Add(this.txtTimMaHV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1203, 139);
            this.panel2.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.BorderRadius = 8;
            this.btnTim.CheckedState.Parent = this.btnTim;
            this.btnTim.CustomImages.Parent = this.btnTim;
            this.btnTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(3)))), ((int)(((byte)(68)))));
            this.btnTim.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(42)))), ((int)(((byte)(3)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.HoverState.Parent = this.btnTim;
            this.btnTim.Image = global::GUI_GiaoDien.Properties.Resources.icons8_search1;
            this.btnTim.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTim.Location = new System.Drawing.Point(396, 45);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShadowDecoration.Parent = this.btnTim;
            this.btnTim.Size = new System.Drawing.Size(180, 45);
            this.btnTim.TabIndex = 10;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 8;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(691, 82);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(180, 45);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "Thoát nhanh";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.BorderRadius = 8;
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Location = new System.Drawing.Point(691, 12);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton6.TabIndex = 7;
            this.guna2GradientButton6.Text = "In thông tin";
            this.guna2GradientButton6.Click += new System.EventHandler(this.guna2GradientButton6_Click);
            // 
            // txtTimTenHocVien
            // 
            this.txtTimTenHocVien.BorderColor = System.Drawing.Color.Lime;
            this.txtTimTenHocVien.BorderRadius = 15;
            this.txtTimTenHocVien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtTimTenHocVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTenHocVien.DefaultText = "";
            this.txtTimTenHocVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimTenHocVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimTenHocVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTenHocVien.DisabledState.Parent = this.txtTimTenHocVien;
            this.txtTimTenHocVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTenHocVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTimTenHocVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTenHocVien.FocusedState.Parent = this.txtTimTenHocVien;
            this.txtTimTenHocVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTenHocVien.HoverState.Parent = this.txtTimTenHocVien;
            this.txtTimTenHocVien.Location = new System.Drawing.Point(7, 83);
            this.txtTimTenHocVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimTenHocVien.Name = "txtTimTenHocVien";
            this.txtTimTenHocVien.PasswordChar = '\0';
            this.txtTimTenHocVien.PlaceholderText = "Nhập tên học viên cần tìm?";
            this.txtTimTenHocVien.SelectedText = "";
            this.txtTimTenHocVien.ShadowDecoration.Parent = this.txtTimTenHocVien;
            this.txtTimTenHocVien.Size = new System.Drawing.Size(354, 44);
            this.txtTimTenHocVien.TabIndex = 5;
            // 
            // txtTimMaHV
            // 
            this.txtTimMaHV.BorderColor = System.Drawing.Color.Lime;
            this.txtTimMaHV.BorderRadius = 15;
            this.txtTimMaHV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtTimMaHV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimMaHV.DefaultText = "";
            this.txtTimMaHV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimMaHV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimMaHV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimMaHV.DisabledState.Parent = this.txtTimMaHV;
            this.txtTimMaHV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimMaHV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTimMaHV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimMaHV.FocusedState.Parent = this.txtTimMaHV;
            this.txtTimMaHV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimMaHV.HoverState.Parent = this.txtTimMaHV;
            this.txtTimMaHV.Location = new System.Drawing.Point(7, 13);
            this.txtTimMaHV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimMaHV.Name = "txtTimMaHV";
            this.txtTimMaHV.PasswordChar = '\0';
            this.txtTimMaHV.PlaceholderText = "Nhập mã học viên cần tìm?";
            this.txtTimMaHV.SelectedText = "";
            this.txtTimMaHV.ShadowDecoration.Parent = this.txtTimMaHV;
            this.txtTimMaHV.Size = new System.Drawing.Size(354, 44);
            this.txtTimMaHV.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(68)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(310, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(1203, 610);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bảng chứng chỉ!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(20, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1163, 550);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Form_ChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ChungChi";
            this.Text = "Bảng chứng chỉ!";
            this.Load += new System.EventHandler(this.Form_ChungChi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtHinhThuc;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCC;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtMaCC;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnIn;
        private Guna.UI2.WinForms.Guna2TextBox txtTimTenHocVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTimMaHV;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocVien;
        private Guna.UI2.WinForms.Guna2GradientButton btnTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
    }
}