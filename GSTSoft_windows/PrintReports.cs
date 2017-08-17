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
using System.IO;
using System.Net.Mail;
using System.Net;

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
            reportViewer1.Visible = true;
            
            if (this.Name=="Invoice")
                {
                reportViewer1.LocalReport.ReportPath = System.Configuration.ConfigurationManager.ConnectionStrings["ReportPath"].ConnectionString+@"\DetailedInvoice - update.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;



                reportViewer1.LocalReport.DataSources.Clear();

             /*   string cmdText = "select * from BillSummary WHERE InvoiceNo='"+txt_invoiceNumber.Text + "';";
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

                            using (SqlDataAdapter da1 = new SqlDataAdapter("Select * from BillDetails WHERE InvoiceNo='"+ + "';", con))
                            {
                                DataSet ds1 = new DataSet();
                                da1.Fill(ds1);
                                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds1.Tables[0]));
                            }
                            
                        }
                        con.Close();
                    }
                }
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();*/
            }
            else
            {

                reportViewer1.LocalReport.ReportPath = System.Configuration.ConfigurationManager.ConnectionStrings["ReportPath"].ConnectionString+this.Name+".rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;



                reportViewer1.LocalReport.DataSources.Clear();
                string cmdText = "";
                if (this.Name == "Sale Summary")
                {
                    cmdText = "select * from BillSummary WHERE [InvoiceDate] > = '" + FromDate1.Value.Date + "' AND [InvoiceDate] < =' " + Todate1.Value.Date + "';";
                }
                else
                {
                    cmdText = "select * from PurchaseSummary WHERE [PurchaseDate] > = '" + FromDate1.Value.Date + "' AND [PurchaseDate] < =' " + Todate1.Value.Date + "';";
                }
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
                            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));

                            /*ReportParameter[] parameter= new ReportParameter[2];

                            parameter[0] = new ReportParameter("FromDate", FromDate1.Text.ToString());
                            parameter[1] = new ReportParameter("ToDate", Todate1.Text.ToString());

                            reportViewer1.LocalReport.SetParameters(parameter);*/
                            // reportViewer1.LocalReport.SetParameters(ToDate);

                            List<ReportParameter> rp = new List<ReportParameter>();
                            rp.Add(new ReportParameter("FromDate", FromDate1.Text)); // If you want a value in the parameter
                            rp.Add(new ReportParameter("ToDate", Todate1.Text)); // If you want null in the parameter
                            reportViewer1.LocalReport.SetParameters(rp);
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

           
            DateTime now = DateTime.Now;
            int month = now.Month;

            FromDate1.Text = FirstDayOfMonth();
            Todate1.Text = LastDayOfMonth();

        }

        private String FirstDayOfMonth()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString();
        }

        private String CurrentDateTime()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString();
        }
        private String LastDayOfMonth()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1).ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void cmb_reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            //save report to local
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            string typeofFile=null;
            string extensionforfile=null;
            Boolean processemail = false;

            if (rdo_Excel.Checked)
            {
                typeofFile="Excel";
                extensionforfile = ".xls";
                processemail = true;
            }
            else if (rdo_PDF.Checked)
            {
                typeofFile="PDF";
                extensionforfile = ".pdf";
                processemail = true;

            }
            else if (rdo_Word.Checked)
            {
                typeofFile="Word";
                extensionforfile = ".doc";
                processemail = true;
            }
            else
            {
                MessageBox.Show("Choose attachment type");
                processemail = false;
            }
            if (!processemail)
            {

            }
            else
            {
                byte[] bytes = reportViewer1.LocalReport.Render(
                    typeofFile, null, out mimeType, out encoding, out filenameExtension,
                    out streamids, out warnings);
                String FileName = System.Configuration.ConfigurationManager.ConnectionStrings["ReportPath"].ConnectionString + "\\"+this.Name+DateTime.Now.Day.ToString()+ DateTime.Now.Month.ToString()+ DateTime.Now.Year.ToString()+ DateTime.Now.Hour.ToString()+ DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString() + extensionforfile;
                using (FileStream fs = new FileStream(FileName, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                //Send Email

                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    message.From = new MailAddress("ravindra.kulkarni1@gmail.com", "Gajanan Tea Depot");
                    
                    message.To.Add(new MailAddress(txt_MailTO.Text));
                    if (this.Name == "Invoice")
                    {

                      //  message.Subject = "Gajanan Tea Depot - " + cmb_reportType.Text + " ID - INV/" + cmb_InvYear.Text + "/" + txt_invoiceNumber.Text;
                        String body = "<h3>Greetings,</h3><p>Thanks for being our loyal customer, we appreciate it.</p><p>Please find attached copy of your recent trasanction with us. Should you have any quaries/questions please contact us via email -&nbsp;<a href='mailto: Aaghate19 @gmail.com'>Aaghate19@gmail.com</a>&nbsp;or ring us on <strong>09823052863</strong>.</p><p><strong>Please keep a copy of this invoice stored.</strong></p><p><strong>Regards</strong></p><p><strong>Gajanan Tea Depot&nbsp;</strong></p>";
                        message.Attachments.Add(new Attachment(FileName));
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body);
                        htmlView.ContentType = new System.Net.Mime.ContentType("text/html");
                        message.AlternateViews.Add(htmlView);

                    }
                    else
                    {
                        message.Subject = "Gajanan Tea Depot - " + this.Name + " From Date : " + FromDate1.Text + " To Date : " + Todate1.Text;
                        String body="<h3>Greetings,</h3><p>Please find attached copy of " + this.Name + " From Date " + FromDate1.Text + " To Date " + Todate1.Text + ", Should you have any quaries/questions please contact us via email -&nbsp;<a href='mailto: Aaghate19 @gmail.com'>Aaghate19@gmail.com</a>&nbsp;or ring us on <strong>09823052863</strong>.</p><p><strong>Regards</strong></p><p><strong>Gajanan Tea Depot&nbsp;</strong></p>";
                        message.Attachments.Add(new Attachment(FileName));
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body);
                        htmlView.ContentType = new System.Net.Mime.ContentType("text/html");
                        message.AlternateViews.Add(htmlView);
                    }


                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("ravindra.kulkarni1@gmail.com", "donbhai31$");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    Application.UseWaitCursor = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("err: " + ex.Message);
                    Application.UseWaitCursor = false;
                }
            }
        }

       
    }
}
