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
using System.Data.OleDb;

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
                btn_Close.Text = "&Close";
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

            //get the last product id

           

            cmb_ProductID.BackColor = Color.LightGray;
            cmb_ProductID.Enabled = false;
           
            OleDbDataReader reader = null;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
            con.Open();
            OleDbCommand command = new OleDbCommand("SELECT count(ProductID) FROM ProductInfo", con);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader[0].ToString() != null)
            {
                cmb_ProductID.Text = "P00" + (int.Parse(reader[0].ToString()) + 1);
            }
            else
            {
                cmb_ProductID.Text = "P001";
            }
            con.Close();
            ProductName.Focus();
            //

        }

        private void Product_Load(object sender, EventArgs e)
        {
            System.Globalization.RegionInfo objRegInfo = new RegionInfo("en-IN");
            string syb = objRegInfo.CurrencySymbol;
            lbl_Rate.Text = "Rate in " + syb + " : ";

           

        }

        private void cmb_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (ProductName.Text != "" || ProductSize.Text != "" || cmb_size.Text != "")
                {
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
                    con.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO ProductInfo (ProductID, ProductName, ProductSize,ProductRate, ValidInd, Product_RateCurrency) Values (?,?,?,?,?,?);", con);
                    command.Parameters.AddWithValue("@ProductID", cmb_ProductID.Text);
                    command.Parameters.AddWithValue("@Name", ProductName.Text);
                    command.Parameters.AddWithValue("@size", ProductSize.Text + cmb_size.Text);
                    command.Parameters.AddWithValue("@rate", ProductRate.Text);
                    command.Parameters.AddWithValue("@ValidInd", "Y");
                    command.Parameters.AddWithValue("@Product_RateCurrency", "RS");
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Product Added Successfully", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    btn_New.Enabled = true;
                    btn_Edit.Enabled = true;
                    btn_Delete.Enabled = true;
                    btn_Close.Text = "&Close";
                    cmb_ProductID.Text = "";
                    ProductName.Text = "";
                    ProductRate.Text = "";
                    ProductSize.Text = "";

                }
            }
            catch (Exception e1){
                MessageBox.Show("Product Details Not Added", "Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
