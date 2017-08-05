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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
           // this.MdiParent = Main;
            this.BackColor = Color.Aquamarine;
            OleDbDataReader reader = null;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
            con.Open();
            OleDbCommand command = new OleDbCommand("SELECT distinct(District) FROM LocationList WHERE State='"+comboBox3.Text+"';",con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_District.Items.Add(reader[0].ToString());
            }
            con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_District_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_District.Text != "") { 
            OleDbDataReader reader = null;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
            con.Open();
            OleDbCommand command = new OleDbCommand("SELECT distinct(Taluka) FROM LocationList Where District='" + cmb_District.Text + "';", con);
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
             
                cmb_Taluka.Items.Add(reader[0].ToString());
            }
            con.Close();
            }
            

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            
        }

        public void EmptyForm()
        {
            txt_Company.Clear();
            txt_CustomerName.Clear();
            txt_address.Clear();
            txt_Comment.Clear();
            txt_Email.Clear();
            txt_GSTNumber.Clear();
            txt_PANNumber.Clear();
            txt_PhoneNumber.Clear();
            txt_PostCode.Clear();
            cmb_District.Text = "";
            cmb_Taluka.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_CustomerName.Text != "" || txt_GSTNumber.Text != "" || txt_address.Text != "" || txt_PhoneNumber.Text != "" || cmb_Taluka.Text != "" || cmb_District.Text != "")
            {
                //OleDbDataReader reader = null;
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
                con.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO CustomerInfo (CompanyName, CustomerName, GSTNumber,PANNumber, PhoneNo, EmailID, Address, Taluka, District, State, Country, Comment, SendEmail, SendSMS,PostCode) Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);", con);
                /*   OleDbCommand command = new OleDbCommand("INSERT INTO CustomerInfo(CompanyName, CustomerName, GSTNumber, PhoneNo, EmailID, Address, Taluka, District, State, Country, Comment, SendEmail, SendSMS, PostCode) Values('" + txt_Company.Text + "', '" + txt_CustomerName.Text + "', '" + txt_GSTNumber.Text + "', '" + txt_PhoneNumber.Text + "', '" + txt_Email.Text + "', '" + txt_address.Text + "', '" + cmb_Taluka.Text + "', '" + cmb_District.Text + "', '" + comboBox3.Text + "', 'India', '" + txt_Comment.Text + "', 'Yes', 'Yes', '" + txt_PostCode.Text + "'); ",con);*/
                command.Parameters.AddWithValue("@CompanyName", txt_Company.Text);
                command.Parameters.AddWithValue("@CustomerName", txt_CustomerName.Text);
                command.Parameters.AddWithValue("@GSTNumber", txt_GSTNumber.Text);
                command.Parameters.AddWithValue("@PanNumber", txt_PANNumber.Text);
                command.Parameters.AddWithValue("@PhoneNo", txt_PhoneNumber.Text);
                command.Parameters.AddWithValue("@EmailID", txt_Email.Text);
                command.Parameters.AddWithValue("@Address", txt_address.Text);
                command.Parameters.AddWithValue("@Taluka", cmb_Taluka.Text);
                command.Parameters.AddWithValue("@District", cmb_District.Text);
                command.Parameters.AddWithValue("@State", comboBox3.Text);
                command.Parameters.AddWithValue("@Country", "India");
                command.Parameters.AddWithValue("@Comment", txt_Comment.Text);
                command.Parameters.AddWithValue("@SendEmail", "Yes");
                command.Parameters.AddWithValue("@SendSMS", "Yes");
                command.Parameters.AddWithValue("@PostCode", txt_PostCode.Text);
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("New Customer Added");

                EmptyForm();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Close.Text = "&Close";

            }
            else
            {
                MessageBox.Show("Please Enter All Mandatory Details", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            EmptyForm();
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Close.Text = "&Cancel";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (btn_Close.Text == "&Cancel")
            {
                EmptyForm();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Close.Text = "&Close";
            }
            else
            {
                this.Close();

            }
        }

      
    }
}
