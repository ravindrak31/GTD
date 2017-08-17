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

namespace GSTSoft_windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // string cmdText = "select Count(*) from Login where UserName=? and PassWord=?";
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select Name from LoginInfo where Username ='" + textBox2.Text + "' and Password ='" + textBox1.Text + "';", con))
                {
                    con.Open();

                    String OperatorName = (String)cmd.ExecuteScalar();
                    con.Close();
                    if (OperatorName != null)
                    {

                        // MessageBox.Show("Login Successful");

                        this.Hide();
                        Main MDIForm = new Main();
                        MDIForm.Name = OperatorName;
                        MDIForm.Text = "Gajanan Tea Depot Billing System";
                        MDIForm.Show();


                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials, Please Re-Enter");
                        textBox2.Clear();
                        textBox1.Clear();
                    }
                }
            }

         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
            
        }
    }
}
