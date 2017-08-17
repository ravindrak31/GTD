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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // this.MdiParent = Main;
            refreshgrid();
            dataGridView1.Enabled = false;
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT distinct(District) FROM LocationList WHERE State='"+comboBox3.Text+"';",con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_District.Items.Add(reader[0].ToString().TrimEnd());
            }
            con.Close();
            panel_data.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_District_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_District.Text != "") { 
            SqlDataReader reader = null;
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT distinct(Taluka) FROM LocationList Where District='" + cmb_District.Text + "';", con);
            reader = command.ExecuteReader();
                cmb_Taluka.Items.Clear();
            while (reader.Read())
            {

                    cmb_Taluka.Items.Add(reader[0].ToString().TrimEnd());
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
            if (txt_CustomerName.Text != "" || txt_address.Text != "" || txt_PhoneNumber.Text != "" || cmb_Taluka.Text != "" || cmb_District.Text != "")
            {
                //SqlDataReader reader = null;
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select Count(*) from SupplierInfo;", con);
                
                    
                    // cmd.Parameters.AddWithValue("@p1", textBox2.Text);
                    //  cmd.Parameters.AddWithValue("@p2", textBox1.Text);  // <- is this a variable or a textbox?
                    int result = (int)cmd.ExecuteScalar();

                SqlCommand command = new SqlCommand();
                /*   SqlCommand command = new SqlCommand("INSERT INTO SupplierInfo(CompanyName, CustomerName, GSTNumber, PhoneNo, EmailID, Address, Taluka, District, State, Country, Comment, SendEmail, SendSMS, PostCode) Values('" + txt_Company.Text + "', '" + txt_CustomerName.Text + "', '" + txt_GSTNumber.Text + "', '" + txt_PhoneNumber.Text + "', '" + txt_Email.Text + "', '" + txt_address.Text + "', '" + cmb_Taluka.Text + "', '" + cmb_District.Text + "', '" + comboBox3.Text + "', 'India', '" + txt_Comment.Text + "', 'Yes', 'Yes', '" + txt_PostCode.Text + "'); ",con);*/
                if (txt_Company.Text !=null)
                {
                    command.CommandText = "INSERT INTO SupplierInfo (ID,CompanyName, CustomerName, GSTNumber,PANNumber, PhoneNo, EmailID, Address, Taluka, District, State, Country, Comment, SendEmail, SendSMS,PostCode) Values(" + result + 1 + ",'" + txt_Company.Text + "','" + txt_CustomerName.Text + "','" + txt_GSTNumber.Text + "','" + txt_PANNumber.Text + "','" + txt_PhoneNumber.Text + "','" + txt_Email.Text + "','" + txt_address.Text + "','" + cmb_Taluka.Text + "','" + cmb_District.Text + "','" + comboBox3.Text + "','India','" + txt_Comment.Text + "','Yes','Yes','" + txt_PostCode.Text + "');";
                    command.Connection = con;
                }
                else
                {
                    command.CommandText = "INSERT INTO SupplierInfo (ID,CompanyName, CustomerName, GSTNumber,PANNumber, PhoneNo, EmailID, Address, Taluka, District, State, Country, Comment, SendEmail, SendSMS,PostCode) Values(" + result + 1 + ",'" + txt_CustomerName.Text + "','" + txt_CustomerName.Text + "','" + txt_GSTNumber.Text + "','" + txt_PANNumber.Text + "','" + txt_PhoneNumber.Text + "','" + txt_Email.Text + "','" + txt_address.Text + "','" + cmb_Taluka.Text + "','" + cmb_District.Text + "','" + comboBox3.Text + "','India','" + txt_Comment.Text + "','Yes','Yes','" + txt_PostCode.Text + "');";
                    command.Connection = con;
                }
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("New Customer Added");
                refreshgrid();
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
            panel_data.Enabled = true;
            EmptyForm();
            dataGridView1.Enabled = true;
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
           
            btn_Close.Text = "&Cancel";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (btn_Close.Text == "&Cancel")
            {
                dataGridView1.Enabled = true;
                EmptyForm();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Close.Text = "&Close";
                button2.Enabled = false;
            }
            else
            {
                this.Close();

            }
        }

        private void cmb_CustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                txt_Company.Focus();
           
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            panel_data.Enabled = true;
            dataGridView1.Enabled = true;
            EmptyForm();
            button2.Enabled = true;
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            refreshgrid();
            btn_Close.Text = "&Cancel";
        }

        private void refreshgrid()
        {
            dataGridView1.Font = new Font("Arial", 9);
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT [CompanyName] ,[CustomerName] ,[GSTNumber] ,[PANNumber] ,[PhoneNo] ,[EmailID] ,[Address] ,[Taluka] ,[District] ,[State],[PostCode],[Comment] FROM SupplierInfo;", con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.Refresh();
                dataGridView1.DataSource = dt;

                //show_description();
            }
            else
            {
                dataGridView1.Refresh();
            }
        }

        public void fillgridtoFrom(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                txt_Company.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                txt_CustomerName.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
                txt_Comment.Text = dataGridView1.Rows[rowindex].Cells[11].Value.ToString();
                txt_Email.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                txt_GSTNumber.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                txt_PANNumber.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                txt_PhoneNumber.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                txt_PostCode.Text = dataGridView1.Rows[rowindex].Cells[10].Value.ToString();
                cmb_District.Text = dataGridView1.Rows[rowindex].Cells[8].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[rowindex].Cells[9].Value.ToString();
                cmb_Taluka.Text = dataGridView1.Rows[rowindex].Cells[7].Value.ToString();

                /*
                 * 
                 * 
                                cmb_ProductID.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                                ProductName1.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                                HSNCode.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                                ProductRate.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();*/
            }
            catch
            {
                MessageBox.Show("Please select product from list");
            }
        }


    }
}
