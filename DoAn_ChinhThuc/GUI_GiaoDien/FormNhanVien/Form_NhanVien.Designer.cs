
namespace GUI_GiaoDien.FormNhanVien
{
    partial class Form_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHinh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnIn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTimTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimHoNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaQuyenHan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboLoaiNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboQuyenHan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDuongDan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.picHinh);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.guna2GradientButton6);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTimTenNV);
            this.panel1.Controls.Add(this.txtTimHoNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 139);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picHinh
            // 
            this.picHinh.BackColor = System.Drawing.Color.White;
            this.picHinh.BorderRadius = 5;
            this.picHinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinh.Location = new System.Drawing.Point(899, 13);
            this.picHinh.Name = "picHinh";
            this.picHinh.ShadowDecoration.Parent = this.picHinh;
            this.picHinh.Size = new System.Drawing.Size(174, 114);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.TabIndex = 9;
            this.picHinh.TabStop = false;
            this.picHinh.Click += new System.EventHandler(this.picHinh_Click_1);
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 8;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.HoverState.Parent = this.btnTim;
            this.btnTim.Image = global::GUI_GiaoDien.Properties.Resources.icons8_search1;
            this.btnTim.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTim.Location = new System.Drawing.Point(402, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShadowDecoration.Parent = this.btnTim;
            this.btnTim.Size = new System.Drawing.Size(180, 45);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // txtTimTenNV
            // 
            this.txtTimTenNV.BorderColor = System.Drawing.Color.Aqua;
            this.txtTimTenNV.BorderRadius = 15;
            this.txtTimTenNV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtTimTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTenNV.DefaultText = "";
            this.txtTimTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTenNV.DisabledState.Parent = this.txtTimTenNV;
            this.txtTimTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimTenNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTimTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTenNV.FocusedState.Parent = this.txtTimTenNV;
            this.txtTimTenNV.ForeColor = System.Drawing.Color.White;
            this.txtTimTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimTenNV.HoverState.Parent = this.txtTimTenNV;
            this.txtTimTenNV.Location = new System.Drawing.Point(7, 83);
            this.txtTimTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimTenNV.Name = "txtTimTenNV";
            this.txtTimTenNV.PasswordChar = '\0';
            this.txtTimTenNV.PlaceholderText = "Nhập tên nhân viên cân tìm?";
            this.txtTimTenNV.SelectedText = "";
            this.txtTimTenNV.ShadowDecoration.Parent = this.txtTimTenNV;
            this.txtTimTenNV.Size = new System.Drawing.Size(354, 44);
            this.txtTimTenNV.TabIndex = 5;
            // 
            // txtTimHoNV
            // 
            this.txtTimHoNV.BorderColor = System.Drawing.Color.Aqua;
            this.txtTimHoNV.BorderRadius = 15;
            this.txtTimHoNV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtTimHoNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimHoNV.DefaultText = "";
            this.txtTimHoNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimHoNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimHoNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimHoNV.DisabledState.Parent = this.txtTimHoNV;
            this.txtTimHoNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimHoNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTimHoNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimHoNV.FocusedState.Parent = this.txtTimHoNV;
            this.txtTimHoNV.ForeColor = System.Drawing.Color.White;
            this.txtTimHoNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimHoNV.HoverState.Parent = this.txtTimHoNV;
            this.txtTimHoNV.Location = new System.Drawing.Point(7, 13);
            this.txtTimHoNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimHoNV.Name = "txtTimHoNV";
            this.txtTimHoNV.PasswordChar = '\0';
            this.txtTimHoNV.PlaceholderText = "Nhập mã nhân viên cầm tìm?";
            this.txtTimHoNV.SelectedText = "";
            this.txtTimHoNV.ShadowDecoration.Parent = this.txtTimHoNV;
            this.txtTimHoNV.Size = new System.Drawing.Size(354, 44);
            this.txtTimHoNV.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(324, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 934);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 795);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1095, 795);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 769);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(207)))), ((int)(((byte)(236)))));
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 934);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.panel4.Controls.Add(this.txtMaQuyenHan);
            this.panel4.Controls.Add(this.txtSDT);
            this.panel4.Controls.Add(this.btnLamMoi);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.cboLoaiNhanVien);
            this.panel4.Controls.Add(this.cboQuyenHan);
            this.panel4.Controls.Add(this.txtDuongDan);
            this.panel4.Controls.Add(this.txtDiaChi);
            this.panel4.Controls.Add(this.dtpNgaySinh);
            this.panel4.Controls.Add(this.rdNu);
            this.panel4.Controls.Add(this.rdNam);
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Controls.Add(this.txtTaiKhoan);
            this.panel4.Controls.Add(this.txtTenNhanVien);
            this.panel4.Controls.Add(this.txtMaNhanVien);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 908);
            this.panel4.TabIndex = 10;
            // 
            // txtMaQuyenHan
            // 
            this.txtMaQuyenHan.BorderColor = System.Drawing.Color.Aqua;
            this.txtMaQuyenHan.BorderRadius = 8;
            this.txtMaQuyenHan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaQuyenHan.DefaultText = "";
            this.txtMaQuyenHan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaQuyenHan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaQuyenHan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaQuyenHan.DisabledState.Parent = this.txtMaQuyenHan;
            this.txtMaQuyenHan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaQuyenHan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtMaQuyenHan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaQuyenHan.FocusedState.Parent = this.txtMaQuyenHan;
            this.txtMaQuyenHan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuyenHan.ForeColor = System.Drawing.Color.White;
            this.txtMaQuyenHan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaQuyenHan.HoverState.Parent = this.txtMaQuyenHan;
            this.txtMaQuyenHan.Location = new System.Drawing.Point(23, 553);
            this.txtMaQuyenHan.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtMaQuyenHan.Name = "txtMaQuyenHan";
            this.txtMaQuyenHan.PasswordChar = '\0';
            this.txtMaQuyenHan.PlaceholderText = "Mã quyền hạn";
            this.txtMaQuyenHan.SelectedText = "";
            this.txtMaQuyenHan.ShadowDecoration.Parent = this.txtMaQuyenHan;
            this.txtMaQuyenHan.Size = new System.Drawing.Size(266, 40);
            this.txtMaQuyenHan.TabIndex = 32;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.Aqua;
            this.txtSDT.BorderRadius = 8;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.White;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(24, 402);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "Số điện thoại";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(266, 40);
            this.txtSDT.TabIndex = 31;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLamMoi.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(58, 759);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(178, 45);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(58, 708);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(178, 45);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_2);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(58, 657);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(178, 45);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa thông tin";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_2);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(58, 606);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(178, 45);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm thông tin";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_2);
            // 
            // cboLoaiNhanVien
            // 
            this.cboLoaiNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiNhanVien.BorderColor = System.Drawing.Color.Aqua;
            this.cboLoaiNhanVien.BorderRadius = 8;
            this.cboLoaiNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.cboLoaiNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoaiNhanVien.FocusedState.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiNhanVien.ForeColor = System.Drawing.Color.White;
            this.cboLoaiNhanVien.FormattingEnabled = true;
            this.cboLoaiNhanVien.HoverState.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.ItemHeight = 30;
            this.cboLoaiNhanVien.Items.AddRange(new object[] {
            "Vip",
            "Thường",
            "Phổ thông",
            "Cao cấp"});
            this.cboLoaiNhanVien.ItemsAppearance.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.Location = new System.Drawing.Point(24, 504);
            this.cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            this.cboLoaiNhanVien.ShadowDecoration.Parent = this.cboLoaiNhanVien;
            this.cboLoaiNhanVien.Size = new System.Drawing.Size(266, 36);
            this.cboLoaiNhanVien.TabIndex = 27;
            // 
            // cboQuyenHan
            // 
            this.cboQuyenHan.BackColor = System.Drawing.Color.Transparent;
            this.cboQuyenHan.BorderColor = System.Drawing.Color.Aqua;
            this.cboQuyenHan.BorderRadius = 8;
            this.cboQuyenHan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyenHan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.cboQuyenHan.FocusedColor = System.Drawing.Color.Empty;
            this.cboQuyenHan.FocusedState.Parent = this.cboQuyenHan;
            this.cboQuyenHan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuyenHan.ForeColor = System.Drawing.Color.White;
            this.cboQuyenHan.FormattingEnabled = true;
            this.cboQuyenHan.HoverState.Parent = this.cboQuyenHan;
            this.cboQuyenHan.ItemHeight = 30;
            this.cboQuyenHan.Items.AddRange(new object[] {
            "QuanTriVien",
            "NhanVien",
            "GiamDoc"});
            this.cboQuyenHan.ItemsAppearance.Parent = this.cboQuyenHan;
            this.cboQuyenHan.Location = new System.Drawing.Point(24, 453);
            this.cboQuyenHan.Name = "cboQuyenHan";
            this.cboQuyenHan.ShadowDecoration.Parent = this.cboQuyenHan;
            this.cboQuyenHan.Size = new System.Drawing.Size(266, 36);
            this.cboQuyenHan.TabIndex = 20;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.BorderColor = System.Drawing.Color.Aqua;
            this.txtDuongDan.BorderRadius = 8;
            this.txtDuongDan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuongDan.DefaultText = "";
            this.txtDuongDan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDuongDan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDuongDan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuongDan.DisabledState.Parent = this.txtDuongDan;
            this.txtDuongDan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuongDan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtDuongDan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuongDan.FocusedState.Parent = this.txtDuongDan;
            this.txtDuongDan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.ForeColor = System.Drawing.Color.White;
            this.txtDuongDan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDuongDan.HoverState.Parent = this.txtDuongDan;
            this.txtDuongDan.Location = new System.Drawing.Point(24, 347);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '\0';
            this.txtDuongDan.PlaceholderText = "Đường dẫn";
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.ShadowDecoration.Parent = this.txtDuongDan;
            this.txtDuongDan.Size = new System.Drawing.Size(266, 40);
            this.txtDuongDan.TabIndex = 26;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.Aqua;
            this.txtDiaChi.BorderRadius = 8;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.White;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(24, 293);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "Địa chỉ";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(266, 40);
            this.txtDiaChi.TabIndex = 25;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.Aqua;
            this.dtpNgaySinh.BorderRadius = 8;
            this.dtpNgaySinh.CheckedState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.ForeColor = System.Drawing.Color.Red;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.HoverState.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Location = new System.Drawing.Point(24, 246);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.ShadowDecoration.Parent = this.dtpNgaySinh;
            this.dtpNgaySinh.Size = new System.Drawing.Size(265, 37);
            this.dtpNgaySinh.TabIndex = 19;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 3, 29, 14, 12, 19, 218);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNu.CheckedState.BorderThickness = 0;
            this.rdNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdNu.CheckedState.InnerOffset = -4;
            this.rdNu.Location = new System.Drawing.Point(106, 217);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(52, 23);
            this.rdNu.TabIndex = 17;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdNu.UncheckedState.BorderThickness = 2;
            this.rdNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNam.CheckedState.BorderThickness = 0;
            this.rdNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdNam.CheckedState.InnerOffset = -4;
            this.rdNam.Location = new System.Drawing.Point(23, 217);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(64, 23);
            this.rdNam.TabIndex = 16;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdNam.UncheckedState.BorderThickness = 2;
            this.rdNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.Aqua;
            this.txtMatKhau.BorderRadius = 8;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.Location = new System.Drawing.Point(21, 168);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(6);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderText = "Mật khẩu";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(266, 40);
            this.txtMatKhau.TabIndex = 24;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.Aqua;
            this.txtTaiKhoan.BorderRadius = 8;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoan.DefaultText = "";
            this.txtTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.DisabledState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.FocusedState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txtTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.HoverState.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Location = new System.Drawing.Point(23, 116);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(6);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.PasswordChar = '\0';
            this.txtTaiKhoan.PlaceholderText = "Tài khoản";
            this.txtTaiKhoan.SelectedText = "";
            this.txtTaiKhoan.ShadowDecoration.Parent = this.txtTaiKhoan;
            this.txtTaiKhoan.Size = new System.Drawing.Size(266, 40);
            this.txtTaiKhoan.TabIndex = 23;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BorderColor = System.Drawing.Color.Aqua;
            this.txtTenNhanVien.BorderRadius = 8;
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.DisabledState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.FocusedState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.ForeColor = System.Drawing.Color.White;
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.HoverState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Location = new System.Drawing.Point(21, 64);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderText = "Tên nhân viên";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.ShadowDecoration.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Size = new System.Drawing.Size(266, 40);
            this.txtTenNhanVien.TabIndex = 22;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BorderColor = System.Drawing.Color.Aqua;
            this.txtMaNhanVien.BorderRadius = 8;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.DisabledState.Parent = this.txtMaNhanVien;
            this.txtMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(2)))), ((int)(((byte)(58)))));
            this.txtMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.FocusedState.Parent = this.txtMaNhanVien;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.White;
            this.txtMaNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.HoverState.Parent = this.txtMaNhanVien;
            this.txtMaNhanVien.Location = new System.Drawing.Point(19, 14);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.PlaceholderText = "Mã nhân viên";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.ShadowDecoration.Parent = this.txtMaNhanVien;
            this.txtMaNhanVien.Size = new System.Drawing.Size(266, 40);
            this.txtMaNhanVien.TabIndex = 21;
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 934);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_NhanVien";
            this.Text = "BẢNG NHÂN VIÊN!";
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox picHinh;
        private Guna.UI2.WinForms.Guna2GradientButton btnIn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton btnTim;
        private Guna.UI2.WinForms.Guna2TextBox txtTimTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtTimHoNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txtMaQuyenHan;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2GradientButton btnLamMoi;
        private Guna.UI2.WinForms.Guna2GradientButton btnSua;
        private Guna.UI2.WinForms.Guna2GradientButton btnXoa;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiNhanVien;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuyenHan;
        private Guna.UI2.WinForms.Guna2TextBox txtDuongDan;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private Guna.UI2.WinForms.Guna2RadioButton rdNu;
        private Guna.UI2.WinForms.Guna2RadioButton rdNam;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}