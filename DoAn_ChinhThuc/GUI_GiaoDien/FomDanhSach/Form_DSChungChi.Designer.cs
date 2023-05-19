
namespace GUI_GiaoDien.FomDanhSach
{
    partial class Form_DSChungChi
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.lbDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMuc.ForeColor = System.Drawing.Color.White;
            this.lbDanhMuc.FormattingEnabled = true;
            this.lbDanhMuc.ItemHeight = 20;
            this.lbDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(261, 752);
            this.lbDanhMuc.TabIndex = 3;
            this.lbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.lbDanhMuc_SelectedIndexChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(61)))));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Controls.Add(this.txtTim);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(11)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(261, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1211, 136);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Thông tin!";
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.Transparent;
            this.txtTim.BorderColor = System.Drawing.Color.Red;
            this.txtTim.BorderRadius = 9;
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.Parent = this.txtTim;
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(182)))));
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
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhMuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhMuc.FullRowSelect = true;
            this.lvDanhMuc.GridLines = true;
            this.lvDanhMuc.HideSelection = false;
            this.lvDanhMuc.Location = new System.Drawing.Point(261, 136);
            this.lvDanhMuc.Name = "lvDanhMuc";
            this.lvDanhMuc.Size = new System.Drawing.Size(1211, 616);
            this.lvDanhMuc.TabIndex = 5;
            this.lvDanhMuc.UseCompatibleStateImageBehavior = false;
            this.lvDanhMuc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã chứng chỉ";
            this.columnHeader1.Width = 223;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên chứng chỉ";
            this.columnHeader2.Width = 217;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã học viên";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại hình đào tạo";
            this.columnHeader4.Width = 363;
            // 
            // Form_DSChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 752);
            this.Controls.Add(this.lvDanhMuc);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lbDanhMuc);
            this.Name = "Form_DSChungChi";
            this.Text = "Bảng DS chứng chỉ!";
            this.Load += new System.EventHandler(this.Form_DSChungChi_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhMuc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private System.Windows.Forms.ListView lvDanhMuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}