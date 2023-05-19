
namespace GUI_GiaoDien.FomDanhSach
{
    partial class Form_DSHocVien
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
            this.lbDanhMuc = new System.Windows.Forms.ListBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.lvDanhMuc = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(103)))));
            this.lbDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMuc.ForeColor = System.Drawing.Color.White;
            this.lbDanhMuc.FormattingEnabled = true;
            this.lbDanhMuc.ItemHeight = 20;
            this.lbDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(213, 767);
            this.lbDanhMuc.TabIndex = 1;
            this.lbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lbDanhMuc_SelectedIndexChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Controls.Add(this.txtTim);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(213, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1295, 136);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Thông tin!";
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.Transparent;
            this.txtTim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTim.BorderRadius = 9;
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.Parent = this.txtTim;
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(149)))), ((int)(((byte)(13)))));
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.FocusedState.Parent = this.txtTim;
            this.txtTim.ForeColor = System.Drawing.Color.White;
            this.txtTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.HoverState.Parent = this.txtTim;
            this.txtTim.Location = new System.Drawing.Point(78, 60);
            this.txtTim.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.PasswordChar = '\0';
            this.txtTim.PlaceholderText = "";
            this.txtTim.SelectedText = "";
            this.txtTim.ShadowDecoration.Parent = this.txtTim;
            this.txtTim.Size = new System.Drawing.Size(526, 55);
            this.txtTim.TabIndex = 0;
            // 
            // lvDanhMuc
            // 
            this.lvDanhMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1});
            this.lvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhMuc.FullRowSelect = true;
            this.lvDanhMuc.GridLines = true;
            this.lvDanhMuc.HideSelection = false;
            this.lvDanhMuc.Location = new System.Drawing.Point(213, 136);
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(1295, 631);
            this.lvDanhMuc.TabIndex = 3;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lvDanhMuc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã học viên";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên học viên";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số điện thoại";
            this.columnHeader4.Width = 182;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã loại lớp";
            this.columnHeader9.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã lớp";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khóa học";
            this.columnHeader1.Width = 150;
            // 
            // Form_DSHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 767);
            this.Controls.Add(this.lvDanhMuc);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lbDanhMuc);
            this.Name = "Form_DSHocVien";
            this.Text = "Bảng DS học viên!";
            this.Load += new System.EventHandler(this.Form_DSHocVien_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhMuc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}