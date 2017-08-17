using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTSoft_windows
{
    public partial class StockEntry : Form
    {
        private String productID;
        private String CurrentStock;
        private String ProductionStock;
        private String SaleStock;
        private String FinalStock;
        private String CurrentID;
        public StockEntry()
        {
            InitializeComponent();
        }

        private void StockEntry_Load(object sender, EventArgs e)
        {
            
                btn_New.Enabled = true;
                btn_Close.Text = "&Close";
                btn_Update.Enabled = false;
                productDetails.Enabled = false;
                cmb_ProductName.Items.Clear();
                txt_ProductionStock.Text = "0";
                txt_Stock.Text = "0";
            }

        private void btn_New_Click(object sender, EventArgs e)
        {
            productDetails.Enabled = true;
            btn_Update.Enabled = true;
            btn_New.Enabled = false;
            btn_Close.Text = "&Cancel";
            //Load Product Names
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT distinct(ProductName),ProductSize FROM ProductInfo", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_ProductName.Items.Add(reader[0].ToString());
            }
         //   cmb_ProductName.BackColor = Color.BlanchedAlmond;
        }

        private void cmb_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT ID FROM ProductInfo WHERE ProductName='"+cmb_ProductName.Text+"';", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader[0].ToString() !="")
            {
                
                productID = reader[0].ToString();
                reader.Close();
                SqlCommand command1 = new SqlCommand("SELECT CurrentStock,ProductionStock,SaleStock,FinalStock,ID FROM StockInfo WHERE ID='" + productID + "';", con);
                //  reader.Close();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Read();
                if (!reader1.HasRows)
                {
                    CurrentStock = "0";
                    ProductionStock = "0";
                    SaleStock = "0";
                    FinalStock = "0";
                    CurrentID = "";
                    txt_Stock.Text = "0";
                }
                else
                {
                    CurrentStock = reader1[0].ToString();
                    ProductionStock = reader1[1].ToString();
                    SaleStock = reader1[2].ToString();
                    FinalStock = reader1[3].ToString();
                    CurrentID = reader1[4].ToString();
                    txt_Stock.Text = reader1[3].ToString();
                }
            }

            txt_Stock.BackColor = Color.Coral;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                if (txt_ProductionStock.Text != "")
                {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                    SqlCommand command = new SqlCommand("INSERT INTO StockInfo (ID,CurrentStock,ProductionStock,SaleStock,FinalStock) VALUES ( '" + productID + "','" + FinalStock + "','" + txt_ProductionStock.Text + "','0','" + (Convert.ToDouble(FinalStock) + Convert.ToDouble(txt_ProductionStock.Text)) + "');", con);
                   con.Open();
                    // SqlDataReader reader = command.ExecuteReader();
                    //   reader.Read();
                   
                    //UpdateEarlier entry
                    if (CurrentID != "")
                    {
                        SqlCommand command1 = new SqlCommand("UPDATE StockInfo SET CurrentStock=" + int.Parse(FinalStock) + ",ProductionStock='" + int.Parse(txt_ProductionStock.Text)+ "',SaleStock=0,FinalStock="+(Convert.ToInt16(FinalStock) + Convert.ToInt16(txt_ProductionStock.Text))+" WHERE ID =" + CurrentID + ";", con);
                        //  con.Open();

                        command1.ExecuteNonQuery();
                    }
                    else {
                    command.ExecuteNonQuery();
                }
                    con.Close();
                    MessageBox.Show("New Stock Details Added");
                    btn_New.Enabled = true;
                    btn_Close.Text = "&Close";
                    btn_Update.Enabled = false;
                    productDetails.Enabled = false;
                    cmb_ProductName.Items.Clear();
                    cmb_ProductName.Text = "";
                    txt_ProductionStock.Text = "0";
                    txt_Stock.Text = "0";
            }
                else
                {
                    MessageBox.Show("Nothing to save");
                }
          /*  }
            catch
            {
                MessageBox.Show("Nothing to save");
            }*/
                
        }

        private void txt_ProductionStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (btn_Close.Text == "&Close") { this.Close(); }
            else
            {
                btn_New.Enabled = true;
                btn_Close.Text = "&Close";
                btn_Update.Enabled = false;
                productDetails.Enabled = false;
                cmb_ProductName.Items.Clear();
                txt_ProductionStock.Text = "0";
                txt_Stock.Text = "0";
            }
        }
    }
}
