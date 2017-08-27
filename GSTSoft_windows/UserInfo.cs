using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSTSoft_windows
{
    public partial class UserInfo : Form
    {
        static String UserID;
        public UserInfo()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Close.Text = "&Cancel";
            button2.Enabled = true;
            //get the last product id
            dataGridView1.Enabled = false;
             refreshGrid();
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT count(ID) FROM LoginInfo;", con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            ID.Text = (Convert.ToInt16(reader[0].ToString())+1).ToString();
            con.Close();
            pnl_Userinfo.Enabled = true;
            button2.Text = "&Save";
            clearform();
            txt_Name.Focus();


        }

        public void clearform()
        {
            txt_LoginUserName.Text= "";
            txt_LoginPassword.Text = "";
            txt_Name.Text = "";
            txt_EmailID.Text = "";
            txt_EmailPassword.Text = "";
            UserID = "";
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
        //    refreshGrid();
        }

        private void refreshGrid()
        {

            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT ID, Username,Password,Name,EmailID,EmailPassword FROM LoginInfo WHERE ValidInd='Y';", con);
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
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.Width = 70;
            }

        }
        public void fillgridtoFrom(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                UserID= dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                txt_LoginUserName.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                txt_LoginPassword.Text = Base64Decode(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                txt_Name.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                txt_EmailID.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                txt_EmailPassword.Text = Base64Decode(dataGridView1.Rows[rowindex].Cells[5].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Please select User from list");
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (btn_Close.Text == "&Cancel")
            {
                clearform();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                button2.Enabled = false;
                btn_Close.Text = "&Close";
                button2.Text = "&Save";
                pnl_Userinfo.Enabled = false;
            }
            else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_EmailPassword.Text, "UserInfo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (button2.Text == "&Save")
                {
                    if (txt_Name.Text != "" || txt_LoginUserName.Text != "" || txt_LoginPassword.Text != "" || txt_EmailID.Text != ""| txt_EmailPassword.Text != "")
                    {
                        

                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO LoginInfo ( ID,Username,Password,Name,EmailID,EmailPassword,ValidInd) Values ("+Convert.ToInt16(ID.Text)+",'" +txt_LoginUserName.Text + "','" +Base64Encode(txt_LoginPassword.Text) + "','" + txt_Name.Text + "','" + txt_EmailID.Text + "','"+Base64Encode(txt_EmailPassword.Text)+"','Y');", con);

                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("New User Added Successfully", "UserInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_New.Enabled = true;
                        btn_Edit.Enabled = true;
                        btn_Delete.Enabled = true;
                        btn_Close.Text = "&Close";
                        clearform();

                    }
                }
                else if (button2.Text == "&Update")
                {
                    if (txt_Name.Text != "" || txt_LoginUserName.Text != "" || txt_LoginPassword.Text != "" || txt_EmailID.Text != "" | txt_EmailPassword.Text != "")
                    {
                      
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE LoginInfo SET Name='" + txt_Name.Text + "',Username='" + txt_LoginUserName.Text + "', Password='" + Base64Encode(txt_LoginPassword.Text) + "',EmailID='" + txt_EmailID.Text + "',EmailPassword='" + Base64Encode(txt_EmailPassword.Text) + "',ValidInd='Y' WHERE ID="+Convert.ToInt16(UserID)+";", con);

                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User Details Updated Successfully", "UserInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_New.Enabled = true;
                        btn_Edit.Enabled = true;
                        btn_Delete.Enabled = true;
                        button2.Text = "&Save";
                        btn_Close.Text = "&Close";
                        clearform();
                        refreshGrid();
                    }
                }
                else
                {

                    if (txt_Name.Text != "" || txt_LoginUserName.Text != "" || txt_LoginPassword.Text != "" || txt_EmailID.Text != "" | txt_EmailPassword.Text != "")
                    {
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE LoginInfo SET ValidInd='N' Where ID=" + int.Parse(UserID) + ";", con);

                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User Deleted Successfully", "Userinfo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_New.Enabled = true;
                        btn_Edit.Enabled = true;
                        btn_Delete.Enabled = true;
                        button2.Text = "&Save";
                        button2.Enabled = false;
                        btn_Close.Text = "&Close";
                        clearform();
                        refreshGrid();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong", "UserInfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            refreshGrid();
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Close.Text = "&Cancel";
            button2.Text = "&Update";
            button2.Enabled = true;
            pnl_Userinfo.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            refreshGrid();
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Close.Text = "&Cancel";
            button2.Text = "&Delete";
            button2.Enabled = true;
            //get the last product id
            dataGridView1.Enabled = true;
            pnl_Userinfo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_LoginPassword.Text, "UserInfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
