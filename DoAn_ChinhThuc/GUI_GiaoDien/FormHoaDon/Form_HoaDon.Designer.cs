
namespace GUI_GiaoDien.FormHoaDon
{
    partial class Form_HoaDon
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
            this.cboMaLop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboHocVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTienHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimTenHocVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimMaHV = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboMaLop);
            this.panel1.Controls.Add(this.cboHocVien);
            this.panel1.Controls.Add(this.cboNhanVien);
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Controls.Add(this.txtTienHP);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 893);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboMaLop
            // 
            this.cboMaLop.BackColor = System.Drawing.Color.Transparent;
            this.cboMaLop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cboMaLop.BorderRadius = 8;
            this.cboMaLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.cboMaLop.FocusedColor = System.Drawing.Color.Empty;
            this.cboMaLop.FocusedState.Parent = this.cboMaLop;
            this.cboMaLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLop.ForeColor = System.Drawing.Color.White;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.HoverState.Parent = this.cboMaLop;
            this.cboMaLop.ItemHeight = 30;
            this.cboMaLop.ItemsAppearance.Parent = this.cboMaLop;
            this.cboMaLop.Location = new System.Drawing.Point(7, 284);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.ShadowDecoration.Parent = this.cboMaLop;
            this.cboMaLop.Size = new System.Drawing.Size(266, 36);
            this.cboMaLop.TabIndex = 42;
            // 
            // cboHocVien
            // 
            this.cboHocVien.BackColor = System.Drawing.Color.Transparent;
            this.cboHocVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.cboHocVien.Location = new System.Drawing.Point(7, 226);
            this.cboHocVien.Name = "cboHocVien";
            this.cboHocVien.ShadowDecoration.Parent = this.cboHocVien;
            this.cboHocVien.Size = new System.Drawing.Size(266, 36);
            this.cboHocVien.TabIndex = 41;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cboNhanVien.BorderRadius = 8;
            this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.cboNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhanVien.FocusedState.Parent = this.cboNhanVien;
            this.cboNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.ForeColor = System.Drawing.Color.White;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.HoverState.Parent = this.cboNhanVien;
            this.cboNhanVien.ItemHeight = 30;
            this.cboNhanVien.ItemsAppearance.Parent = this.cboNhanVien;
            this.cboNhanVien.Location = new System.Drawing.Point(6, 162);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.ShadowDecoration.Parent = this.cboNhanVien;
            this.cboNhanVien.Size = new System.Drawing.Size(266, 36);
            this.cboNhanVien.TabIndex = 40;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CheckedState.Parent = this.dtpNgayLap;
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.FillColor = System.Drawing.Color.Red;
            this.dtpNgayLap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.ForeColor = System.Drawing.Color.White;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.HoverState.Parent = this.dtpNgayLap;
            this.dtpNgayLap.Location = new System.Drawing.Point(7, 83);
            this.dtpNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.ShadowDecoration.Parent = this.dtpNgayLap;
            this.dtpNgayLap.Size = new System.Drawing.Size(266, 40);
            this.dtpNgayLap.TabIndex = 9;
            this.dtpNgayLap.Value = new System.DateTime(2022, 4, 9, 19, 2, 13, 482);
            // 
            // txtTienHP
            // 
            this.txtTienHP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTienHP.BorderRadius = 8;
            this.txtTienHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienHP.DefaultText = "";
            this.txtTienHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienHP.DisabledState.Parent = this.txtTienHP;
            this.txtTienHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienHP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTienHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienHP.FocusedState.Parent = this.txtTienHP;
            this.txtTienHP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienHP.ForeColor = System.Drawing.Color.White;
            this.txtTienHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienHP.HoverState.Parent = this.txtTienHP;
            this.txtTienHP.Location = new System.Drawing.Point(7, 338);
            this.txtTienHP.Margin = new System.Windows.Forms.Padding(6);
            this.txtTienHP.Name = "txtTienHP";
            this.txtTienHP.PasswordChar = '\0';
            this.txtTienHP.PlaceholderText = "Học phí";
            this.txtTienHP.SelectedText = "";
            this.txtTienHP.ShadowDecoration.Parent = this.txtTienHP;
            this.txtTienHP.Size = new System.Drawing.Size(266, 40);
            this.txtTienHP.TabIndex = 35;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.SlateBlue;
            this.btnLamMoi.FillColor2 = System.Drawing.Color.DimGray;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(41, 691);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(185, 45);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.SlateBlue;
            this.btnSua.FillColor2 = System.Drawing.Color.DimGray;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(41, 619);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(185, 45);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.SlateBlue;
            this.btnXoa.FillColor2 = System.Drawing.Color.DimGray;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(41, 543);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(185, 45);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa thông tin";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.SlateBlue;
            this.btnThem.FillColor2 = System.Drawing.Color.DimGray;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(41, 469);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(185, 45);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm thông tin";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtMaHD.BorderRadius = 8;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.Parent = this.txtMaHD;
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.FocusedState.Parent = this.txtMaHD;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.White;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.HoverState.Parent = this.txtMaHD;
            this.txtMaHD.Location = new System.Drawing.Point(7, 17);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "Mã hóa đơn";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.ShadowDecoration.Parent = this.txtMaHD;
            this.txtMaHD.Size = new System.Drawing.Size(266, 40);
            this.txtMaHD.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.guna2GradientButton6);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.txtTimTenHocVien);
            this.panel2.Controls.Add(this.txtTimMaHV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(310, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 139);
            this.panel2.TabIndex = 7;
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 8;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // btnTim
            // 
            this.btnTim.BorderRadius = 8;
            this.btnTim.CheckedState.Parent = this.btnTim;
            this.btnTim.CustomImages.Parent = this.btnTim;
            this.btnTim.FillColor = System.Drawing.Color.Yellow;
            this.btnTim.FillColor2 = System.Drawing.Color.Lime;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.HoverState.Parent = this.btnTim;
            this.btnTim.Location = new System.Drawing.Point(402, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShadowDecoration.Parent = this.btnTim;
            this.btnTim.Size = new System.Drawing.Size(180, 45);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimTenHocVien
            // 
            this.txtTimTenHocVien.BorderColor = System.Drawing.Color.Red;
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
            this.txtTimTenHocVien.PlaceholderText = "Nhập mã học viên cần tìm?";
            this.txtTimTenHocVien.SelectedText = "";
            this.txtTimTenHocVien.ShadowDecoration.Parent = this.txtTimTenHocVien;
            this.txtTimTenHocVien.Size = new System.Drawing.Size(354, 44);
            this.txtTimTenHocVien.TabIndex = 5;
            // 
            // txtTimMaHV
            // 
            this.txtTimMaHV.BorderColor = System.Drawing.Color.Red;
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
            this.txtTimMaHV.PlaceholderText = "Nhập mã hóa đơn cần tìm?";
            this.txtTimMaHV.SelectedText = "";
            this.txtTimMaHV.ShadowDecoration.Parent = this.txtTimMaHV;
            this.txtTimMaHV.Size = new System.Drawing.Size(354, 44);
            this.txtTimMaHV.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(5)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(310, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1215, 754);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bảng hóa đơn!";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
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
            this.dataGridView1.Size = new System.Drawing.Size(1209, 728);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đơn vị tính:VND";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 893);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_HoaDon";
            this.Text = "Bảng hóa đơn!";
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtTienHP;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnIn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton btnTim;
        private Guna.UI2.WinForms.Guna2TextBox txtTimTenHocVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTimMaHV;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaLop;
        private Guna.UI2.WinForms.Guna2ComboBox cboHocVien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}