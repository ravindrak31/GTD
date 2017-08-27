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
using System.Globalization;

namespace GSTSoft_windows
{
    public partial class PrintInvoice : Form
    {
        //static String UserName;
        public static string UserName;
        public PrintInvoice(String OperatorName)
        {
            InitializeComponent();
            UserName = OperatorName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                reportViewer1.Visible = true;

                if (this.Name == "Invoice")
                {
                    reportViewer1.LocalReport.ReportPath = System.Configuration.ConfigurationManager.ConnectionStrings["ReportPath"].ConnectionString + "Invoice.rdlc";
                    reportViewer1.ProcessingMode = ProcessingMode.Local;



                    reportViewer1.LocalReport.DataSources.Clear();

                    string cmdText = "SELECT ID ,InvoiceNo ,InvoiceYear ,InvoiceCreatedBy ,Convert(varchar,InvoiceDate,103) as InvoiceDate ,CustomerName ,CustomerAddress ,CustomerGSTNumber ,CustomerContactNumber ,CompanyID ,TotalCGST ,TotalSGST ,OtherTaxes ,TotalTax ,TotalInvoiceValue FROM BillSummary WHERE InvoiceNo='" + textBox1.Text + "' AND InvoiceYear='" + comboBox1.Text + "';";
                    using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            con.Open();
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                DataSet ds = new DataSet();
                                //     ds.Tables[0].Columns[4].DataType = typeof(String);
                                da.Fill(ds);


                                DataTable dt = new DataTable();

                                //   dt.Columns[4].DataType= typeof(String);
                                dt = ds.Tables[0];
                                
                                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceDetails", dt));

                                using (SqlDataAdapter da1 = new SqlDataAdapter("Select * from BillDetails WHERE InvoiceNo='" + textBox1.Text + "' AND InvoiceYear='" + comboBox1.Text + "';", con))
                                {
                                    DataSet ds1 = new DataSet();
                                    da1.Fill(ds1);
                                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("InvoiceDataSet", ds1.Tables[0]));
                                }

                            }
                            con.Close();
                        }
                    }
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
            }
            else
            {
                MessageBox.Show("Please enter invoice number and year", "Invoice Printing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintReports_Load(object sender, EventArgs e)
        {

            String cmdText = "Select distinct(InvoiceYear) from BillSummary;";
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    // reader.Read();
                    comboBox1.Text = DateTime.Now.Year.ToString();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader[0].ToString());
                    }
                  


                    }
                
            }
        }

        private String FirstDayOfMonth()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString();
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
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

                //Collect info from DB
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                con.Open();
                SqlCommand command = new SqlCommand("SELECT EmailID,EmailPassword FROM LoginInfo Where Name=+'"+UserName+"';", con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                String EmailID = reader[0].ToString();
                String EmailPassword = reader[1].ToString();
                con.Close();

                //Send Email

                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();

                    message.From = new MailAddress(EmailID, "Gajanan Tea Depot");
                    message.To.Add(new MailAddress(txt_MailTO.Text));
                    if (this.Name == "Invoice")
                    {

                       message.Subject = "Gajanan Tea Depot - " + this.Name + " ID - INV/" + comboBox1.Text + "/" + textBox1.Text;
                        String body = "<h3>Greetings,</h3><p>Thanks for being our loyal customer, we appreciate it.</p><p>Please find attached copy of your recent trasanction with us. Should you have any quaries/questions please contact us via email -&nbsp;<a href='mailto: Aaghate19 @gmail.com'>Aaghate19@gmail.com</a>&nbsp;or ring us on <strong>09823052863</strong>.</p><p><strong>Please keep a copy of this invoice stored.</strong></p><p><strong>Regards</strong></p><p><strong>Gajanan Tea Depot&nbsp;</strong></p>";
                        message.Attachments.Add(new Attachment(FileName));
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body);
                        htmlView.ContentType = new System.Net.Mime.ContentType("text/html");
                        message.AlternateViews.Add(htmlView);

                    }
                

                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(EmailID, Base64Decode(EmailPassword));
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    Application.UseWaitCursor = false;
                    MessageBox.Show("Email Sent Successfully","Email",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
