using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace GSTSoft_windows
{
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            String InvoiceNo = this.Name;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Ravindra Kulkarni\Documents\Visual Studio 2015\Projects\GSTSoft_windows\GSTSoft_windows\Report2.rdlc";
            reportViewer1.ProcessingMode = ProcessingMode.Local;



            reportViewer1.LocalReport.DataSources.Clear();

            string cmdText = "select * from BillSummary WHERE InvoiceNO='" + InvoiceNo + "';";
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST"))
            {
                using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
                {
                    con.Open();
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", ds.Tables[0]));

                        using (OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from BillDetails WHERE InvoiceNo='" + InvoiceNo + "';", con))
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
            this.reportViewer1.RefreshReport();
        }
    }
    
}
