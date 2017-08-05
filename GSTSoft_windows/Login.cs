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
            
            string cmdText = "select Count(*) from Login where UserName=? and PassWord=?";
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST"))
            {
                using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@p1", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox1.Text);  // <- is this a variable or a textbox?
                    int result = (int)cmd.ExecuteScalar();
                    con.Close();
                    if (result > 0) {

                        MessageBox.Show("Login Successful");
                        String cmdText1 = "select OperatorName from Login where UserName='"+textBox2.Text+"';";
                        con.Open();
                        OleDbCommand cmd1 = new OleDbCommand(cmdText1, con);
                        //cmd.Parameters.AddWithValue("@u", textBox2.Text);
                        String OperatorName = (String)cmd1.ExecuteScalar();
                        con.Close();
                        this.Hide();
                        Main MDIForm = new Main();
                        MDIForm.Name = OperatorName;
                        MDIForm.Text = OperatorName + " Welcome to Gajanan Tea Depot Billing System";
                        MDIForm.Show();
                        

                    }
               else {
                        MessageBox.Show("Invalid Credentials, Please Re-Enter");
                        textBox2.Clear();
                        textBox1.Clear();
                    }
                }
            }

           // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
           // OleDbCommand command = new OleDbCommand("SELECT distinct(CustomerName) FROM CustomerInfo", con);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
            
        }
    }
}
