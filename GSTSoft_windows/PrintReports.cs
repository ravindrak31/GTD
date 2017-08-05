using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace GSTSoft_windows
{
    public partial class PrintReports : Form
    {
        public PrintReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_bill.Checked == true)
            {
                reportViewer1.LocalReport.ReportPath = @"C:\Users\Ravindra Kulkarni\Documents\Visual Studio 2015\Projects\GSTSoft_windows\GSTSoft_windows\Report2.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;



                reportViewer1.LocalReport.DataSources.Clear();

                string cmdText = "select * from BillSummary WHERE InvoiceNO='" + textBox2.Text+textBox1.Text + "';";
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

                            using (OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from BillDetails WHERE InvoiceNo='" + textBox2.Text + textBox1.Text + "';", con))
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
            else if (radio_report.Checked == true)
            {

                reportViewer1.LocalReport.ReportPath = @"C:\Users\Ravindra Kulkarni\Documents\Visual Studio 2015\Projects\GSTSoft_windows\GSTSoft_windows\Report1.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;



                reportViewer1.LocalReport.DataSources.Clear();

                string cmdText = "select * from BillSummary;";
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
                            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));
                            
                        }
                        con.Close();
                    }
                }
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
        }

        private void PrintReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DBDataSet.BillDetails' table. You can move, or remove it, as needed.
            this.BillDetailsTableAdapter.Fill(this.DBDataSet.BillDetails);
            // TODO: This line of code loads data into the 'DBDataSet.BillSummary' table. You can move, or remove it, as needed.
            this.BillSummaryTableAdapter.Fill(this.DBDataSet.BillSummary);
            // TODO: This line of code loads data into the 'DBDataSet.BillSummary' table. You can move, or remove it, as needed.
            //  this.BillSummaryTableAdapter.Fill(this.DBDataSet.BillSummary);
            // ConnectionInfo myConnectionInfo = new ConnectionInfo();
            // myConnectionInfo.UserID = "ADMIN";
            // myConnectionInfo.Password = "GST";
            //setDBLOGONforREPORT(myConnectionInfo);
            dateTimePicker1.Text = DateTime.Today.AddMonths(-1).ToShortDateString();
            dateTimePicker1.Text = DateTime.Today.ToShortDateString();
            /*  this.reportViewer1.RefreshReport();
              string cmdText = "select * from BillSummary;";
              using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST"))
              {
                  using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
                  {
                      con.Open();
                      using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                      {
                          DataSet ds = new DataSet();
                          da.Fill(ds);
                          reportViewer1.ProcessingMode = ProcessingMode.Local;
                          ReportDataSource rds = new ReportDataSource();
                          reportViewer1.LocalReport.DataSources.Clear();
                          reportViewer1.LocalReport.DataSources.Add(rds);
                          reportViewer1.LocalReport.Refresh();
                          reportViewer1.Refresh();
                      }

                  }
              }*/

            this.reportViewer1.RefreshReport();
        }
        private void radio_report_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_report.Checked==true)
            {
                textBox1.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void radio_bill_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_bill.Checked == true)
            {
                textBox1.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
