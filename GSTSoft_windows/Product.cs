using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GSTSoft_windows
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

            if (btn_Close.Text == "&Cancel")
            {
                // EmptyForm();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
                button2.Enabled = false;
                btn_Close.Text = "&Close";
                button2.Text = "&Save";
            }
            else
            {
                this.Close();

            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Close.Text = "&Cancel";
            button2.Enabled = true;
            //get the last product id
            productDetails.Enabled = true;
            button2.Text = "&Save";


            cmb_ProductID.BackColor = Color.LightGray;
            cmb_ProductID.Enabled = false;
           
           SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT RIGHT('000'+ CONVERT(VARCHAR,count(ID)),3) FROM ProductInfo", con);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader[0].ToString() != "0")
            {
                cmb_ProductID.Text ="00"+(int.Parse(reader[0].ToString())+1);
            }
            else
            {
                cmb_ProductID.Text = "001";
            }
            con.Close();
            ProductName1.Focus();
            //

        }

        private void Product_Load(object sender, EventArgs e)
        {
            System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
            string syb = objRegInfo.CurrencySymbol;
            lbl_Rate.Text = "Rate in " + syb + " : ";
            btn_New.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            button2.Enabled = false;
            productDetails.Enabled = false;



        }

        private void cmb_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (button2.Text == "&Save")
                {
                    if (ProductName1.Text != "" || HSNCode.Text != "")
                    {
                        String Purchaseproductstring = "N";

                        if (!isPurchaseProduct.Checked)
                        {
                            Purchaseproductstring = "N";
                        }else
                        {
                            Purchaseproductstring = "Y";
                        }
                        
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO ProductInfo (ID, ProductName,HSNCode,ProductRate, ValidInd, Product_RateCurrency,isPurchaseProduct) Values (" + int.Parse(cmb_ProductID.Text) + ",'" + ProductName1.Text + "','" + HSNCode.Text + "','" + ProductRate.Text + "','Y','RS','"+Purchaseproductstring+"');", con);

                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("New Product Added Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_New.Enabled = true;
                        btn_Edit.Enabled = true;
                        btn_Delete.Enabled = true;
                        btn_Close.Text = "&Close";
                        cmb_ProductID.Text = "";
                        ProductName1.Text = "";
                        ProductRate.Text = "";
                        HSNCode.Text = "";

                    }
                }
                else if(button2.Text=="&Update")
                {
                    if (ProductName1.Text != "" || HSNCode.Text != "")
                    {
                        String Purchaseproductstring = "N";

                        if (!isPurchaseProduct.Checked)
                        {
                            Purchaseproductstring = "N";
                        }
                        else
                        {
                            Purchaseproductstring = "Y";
                        }
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE ProductInfo SET ProductName='" + ProductName1.Text + "',HSNCode='" + HSNCode.Text + "', ProductRate='" + ProductRate.Text + "', ValidInd='Y', Product_RateCurrency='RS',isPurchaseProduct='"+Purchaseproductstring+"'  Where ID=" + int.Parse(cmb_ProductID.Text) + ";", con);
                            
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Updated Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_New.Enabled = true;
                        btn_Edit.Enabled = true;
                        btn_Delete.Enabled = true;
                        button2.Text = "&Save";
                        btn_Close.Text = "&Close";
                        cmb_ProductID.Text = "";
                        ProductName1.Text = "";
                        ProductRate.Text = "";
                        HSNCode.Text = "";
                        refreshGrid();
                    }
                }
                else
                {

                    if (ProductName1.Text != "" || HSNCode.Text != "")
                    {
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("UPDATE ProductInfo SET ValidInd='N' Where ID=" + int.Parse(cmb_ProductID.Text) + ";", con);

                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Deleted Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btn_New.Enabled = true;
                        btn_Edit.Enabled = true;
                        btn_Delete.Enabled = true;
                        button2.Text = "&Save";
                        button2.Enabled = false;
                        btn_Close.Text = "&Close";
                        cmb_ProductID.Text = "";
                        ProductName1.Text = "";
                        ProductRate.Text = "";
                        HSNCode.Text = "";
                        refreshGrid();
                    }
                }
            
            }
            catch
            {
                MessageBox.Show("Product Details Not Added", "Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //get the last product id
            productDetails.Enabled = true;
        }
        private void refreshGrid()
        {
            
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT ID, ProductName,HSNCode,ProductRate FROM ProductInfo WHERE ValidInd='Y';", con);
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
        public void fillgridtoFrom(object sender,EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                cmb_ProductID.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                ProductName1.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                HSNCode.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                ProductRate.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Please select product from list");
            }
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
            productDetails.Enabled = true;
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            refreshGrid();
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Close.Text = "&Cancel";
            button2.Text = "&Delete";
            button2.Enabled = true;
            //get the last product id
            productDetails.Enabled = true;
        }
    }
}
