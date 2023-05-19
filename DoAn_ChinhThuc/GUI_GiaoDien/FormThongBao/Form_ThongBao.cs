using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace GUI_GiaoDien.FormThongBao
{
    public partial class Form_ThongBao : Form
    {
        public Form_ThongBao()
        {
            InitializeComponent();
        }

        private void Form_ThongBao_Load(object sender, EventArgs e)
        {
            SqlConnection ketnoi = new SqlConnection
             ("Data Source= DESKTOP-HD4HHJ3\\SQLEXPRESS;  Initial Catalog=CSDL_DoAn_LTQL; Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Table_HoaDon", ketnoi);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoaDon");
            ReportDataSource report = new ReportDataSource();
            report.Name = "DataSet1";
            report.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_GiaoDien.ReportHoaDon.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.RefreshReport();
        }
    }
}
