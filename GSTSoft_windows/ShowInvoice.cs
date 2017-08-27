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

namespace GSTSoft_windows
{
    public partial class PrintInvoice1 : Form
    {
        public PrintInvoice1()
        {
            InitializeComponent();
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            String InvoiceNo = this.Name;
            reportViewer1.LocalReport.ReportPath = System.Configuration.ConfigurationManager.ConnectionStrings["ReportPath"].ConnectionString+@"\DetailedInvoice - update.rdlc";
            reportViewer1.ProcessingMode = ProcessingMode.Local;



            reportViewer1.LocalReport.DataSources.Clear();

            string cmdText = "select * from BillSummary WHERE InvoiceNo='" +InvoiceNo + "';";
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ds.Tables[0]));

                        using (SqlDataAdapter da1 = new SqlDataAdapter("Select * from BillDetails WHERE InvoiceNo='" + InvoiceNo + "';", con))
                        {
                            DataSet ds1 = new DataSet();
                            da1.Fill(ds1);
                            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds1.Tables[0]));
                        }
                        // Add the reportviewer to the form
                    }
                    con.Close();
                }
            }
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
    
}
