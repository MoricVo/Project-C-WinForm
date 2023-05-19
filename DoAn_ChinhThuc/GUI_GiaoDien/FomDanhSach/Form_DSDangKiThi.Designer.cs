
namespace GUI_GiaoDien.FomDanhSach
{
    partial class Form_DSDangKiThi
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(6)))), ((int)(((byte)(101)))));
            this.lbDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMuc.ForeColor = System.Drawing.Color.White;
            this.lbDanhMuc.FormattingEnabled = true;
            this.lbDanhMuc.ItemHeight = 20;
            this.lbDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(261, 736);
            this.lbDanhMuc.TabIndex = 2;
            this.lbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lbDanhMuc_SelectedIndexChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Controls.Add(this.txtTim);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(74)))), ((int)(((byte)(22)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(261, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1119, 136);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Thông tin!";
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.Transparent;
            this.txtTim.BorderColor = System.Drawing.Color.Aqua;
            this.txtTim.BorderRadius = 9;
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.Parent = this.txtTim;
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(88)))), ((int)(((byte)(154)))));
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
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11});
            this.lvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhMuc.FullRowSelect = true;
            this.lvDanhMuc.GridLines = true;
            this.lvDanhMuc.HideSelection = false;
            this.lvDanhMuc.Location = new System.Drawing.Point(261, 136);
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(1119, 600);
            this.lvDanhMuc.TabIndex = 4;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lvDanhMuc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã học viên";
            this.columnHeader6.Width = 251;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giờ thi";
            this.columnHeader7.Width = 218;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ca thi";
            this.columnHeader8.Width = 236;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã lớp";
            this.columnHeader11.Width = 347;
            // 
            // Form_DSDangKiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 736);
            this.Controls.Add(this.lvDanhMuc);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lbDanhMuc);
            this.Name = "Form_DSDangKiThi";
            this.Text = "Bảng DS đăng kí thi!";
            this.Load += new System.EventHandler(this.Form_DSDangKiThi_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhMuc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}