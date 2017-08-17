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
using System.Text.RegularExpressions;

namespace GSTSoft_windows
{
    public partial class Purchase : Form
    {
        private String currentID;
        public Purchase()
        {
            InitializeComponent();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            // EmptyForm();
            btn_New.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Print.Enabled = false;
            btn_Close.Text = "&Cancel";
            txt_OtherCharges.Text="00.00";
            lbl_CGST.Text = "0.00";
            lbl_SGST.Text = "0.00";
            lbl_PurchaseTotal.Text = "0.00";
            ProgressBar.Value = 5;
            statusbar.Text = "Generating new invoice ID";
            // txt_invoicedate.Text=DateTime.Now()
            //get the list of customers
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command1 = new SqlCommand("SELECT count(PurchaseNo) FROM PurchaseSummary;", con);
            try
            {
                reader = command1.ExecuteReader();
                reader.Read();
                PurchaseID.Text = (int.Parse(reader[0].ToString()) + 1).ToString();
            }
            catch
            {
                PurchaseID.Text = "1";
            }
            //  InvoiceID.Text = "INV2017/" + (int.Parse(reader[0].ToString())+1);

           // reader = null;
            ProgressBar.Value = 25;
            statusbar.Text = "Loading the list of customers";
            ProgressBar.Value = 30;
            reader.Close();
            SqlCommand command = new SqlCommand("SELECT distinct(CompanyName),CustomerName, ID FROM SupplierInfo", con);
            cmb_Customer.Items.Clear();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() != "")
                {
                    cmb_Customer.Items.Add(reader[0].ToString());
                }
                else
                {
                    cmb_Customer.Items.Add(reader[1].ToString());
                }

            }
           // reader = null;
            ProgressBar.Value = 50;
            dataGridView1.Visible = true;
            statusbar.Text = "Loading the list of products";
            //  SqlCommand command2 = new SqlCommand("SELECT distinct(CustomerName) FROM CustomerInfo", con);
            reader.Close();
            SqlCommand command2 = new SqlCommand("SELECT distinct(ProductName),ProductSize FROM ProductInfo WHERE ValidInd='Y' AND isPurchaseProduct='Y'", con);
            SqlDataReader reader1 = null;
            reader1 = command2.ExecuteReader();
            cmb_Item.Items.Clear();
            while (reader1.Read())
            {
                cmb_Item.Items.Add(reader1[0].ToString());
            }
            //dgvCmb.HeaderText = "Item Description";
            //dgvCmb.Name= "Product Name";

            //dataGridView1.Columns.Add(dgvCmb);
            // dataGridView1.Columns["Product Name"].Width = 200;
            //dataGridView1.Columns["Product Name"].DisplayIndex = 1;
            //dataGridView1.Columns["SrNo"].Width = 50;
            // LoadSerial();
            //ProgressBar.Value = 90;

            reader.Close();
            reader1.Close();
            ProgressBar.Value = 100;
            con.Close();
            cmb_Customer.Focus();

            cmb_Customer.DroppedDown = true;
            statusbar.Text = "Choose Customer Name";

        }




        private void LoadSerial()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["SrNo"].Value = i; i++;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (btn_Close.Text == "&Cancel")
            {
                // EmptyForm();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Print.Enabled = true;
                btn_Close.Text = "&Close";
                EmptyForm();
            }
            else
            {
                this.Close();

            }
        }

        private void cmb_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Customer.Text != "")
            {
                statusbar.Text = "Please wait! Loading Customer Details";
                statusbar.ForeColor = Color.Red;
                ProgressBar.Value = 10;
                SqlDataReader reader = null;
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                ProgressBar.Value = 20;
                con.Open();
                SqlCommand command = new SqlCommand("SELECT GSTNumber, Address, Taluka, District, State, PostCode,PhoneNo FROM SupplierInfo WHERE CustomerName='" + cmb_Customer.Text+"';", con);
                ProgressBar.Value = 30;
                reader = command.ExecuteReader();
               // reader.Read();
                if (!reader.HasRows)
                {
                    reader.Close();
                   // reader.Close();

                    SqlCommand command1 = new SqlCommand("SELECT GSTNumber, Address, Taluka, District, State, PostCode,PhoneNo FROM SupplierInfo WHERE CompanyName='" + cmb_Customer.Text + "';", con);
                    ProgressBar.Value = 30;
                    SqlDataReader reader1 = command1.ExecuteReader();
                    ProgressBar.Value = 40;
                    reader1.Read();
                    ProgressBar.Value = 50;
                    
                    lbl_GST.Text = readerValueorNull(reader1, "GSTNumber");
                    ProgressBar.Value = 70;
                    lbl_address.Text = reader1[1].ToString() + "\nTaluka :" + reader1[2].ToString().Trim() + ", District : " + reader1[3].ToString().Trim() + "\n" + reader1[4].ToString().Trim() + " - " + reader1[5].ToString().Trim();
                    lbl_ContactNumber.Text = reader1[6].ToString();
                    ProgressBar.Value = 90;
                    statusbar.ForeColor = Color.Green;
                    statusbar.Text = "Please choose product and proceed with Bill";

                }
                else
                {
                    ProgressBar.Value = 40;
                    reader.Read();

                    ProgressBar.Value = 50;
                    lbl_GST.Text = reader[0].ToString();
                    ProgressBar.Value = 70;
                    lbl_address.Text = reader[1].ToString() + "\nTaluka :" + reader[2].ToString() + ", District : " + reader[3].ToString() + "\n" + reader[4].ToString() + " - " + reader[5].ToString();
                    lbl_ContactNumber.Text = reader[6].ToString();
                    ProgressBar.Value = 90;
                    statusbar.ForeColor = Color.Green;
                    statusbar.Text = "Please choose product and proceed with Bill";
                }
                con.Close();

                ProgressBar.Value = 100;
                PanelItemDetails.Enabled = true;

                txt_ItemRate.Text = "0.00";
            }
        }

        private String readerValueorNull(IDataReader reader, String ColName)
        {
            if (reader[ColName] == DBNull.Value)
            {
                return "";
            }
            else
            {
                return reader[ColName].ToString();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void ItemAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void cmb_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            String productCode;

                SqlCommand command1 = new SqlCommand("SELECT ProductRate,Product_RateCurrency,HSNCode,ID FROM ProductInfo WHERE ProductName='" + cmb_Item.Text + "';", con);
            

            reader = command1.ExecuteReader();
            reader.Read();
            txt_ItemRate.Text = reader[0].ToString().Trim();
            HSNCode.Text = reader[2].ToString().Trim();
            lbl_productID.Text = reader[3].ToString().Trim();
            reader.Close();
           
            con.Close();
            txt_quantity.Text = "1";
            txt_Discount.Text = "0.00";
            Calculate();
        }
        public void Calculate()
        {
            if (txt_quantity.Text != "" || txt_ItemRate.Text != "" || txt_Discount.Text != "")
            {
                double rate = Convert.ToDouble(txt_ItemRate.Text);
                double quantity = Convert.ToDouble(this.txt_quantity.Text);
                double discount = Convert.ToDouble(this.txt_Discount.Text);

                txt_TaxableValue.Text = ((rate * quantity) - discount).ToString("N2");
                txt_ItemCGST.Text = ((double.Parse(this.txt_TaxableValue.Text) * double.Parse(txt_CGSTRate.Text) / 100)).ToString("N2");
                txt_ItemSGST.Text = ((double.Parse(txt_TaxableValue.Text) * double.Parse(txt_CGSTRate.Text) / 100)).ToString("N2");
                txt_TotalItemValue.Text = ((double.Parse(txt_TaxableValue.Text)) + (double.Parse(txt_ItemCGST.Text)) + (double.Parse(txt_ItemSGST.Text))).ToString("N2");
            }
        }
        private void Calculatetotal()
        {
            double Totalcgst = 0;
            double Totalsgst = 0;
            double TotalAmount = 0;
            double otherCharges = Convert.ToDouble(txt_OtherCharges.Text);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               
                Totalcgst += Convert.ToDouble(dataGridView1.Rows[i].Cells["CGST"].Value);
                Totalsgst += Convert.ToDouble(dataGridView1.Rows[i].Cells["SGST"].Value);
                TotalAmount += Convert.ToDouble(dataGridView1.Rows[i].Cells["TotalValue"].Value)+otherCharges;
            }

            lbl_CGST.Text = Totalcgst.ToString("N2");
            lbl_SGST.Text = Totalsgst.ToString("N2");
            lbl_PurchaseTotal.Text = (TotalAmount).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, HSNCode.Text, cmb_Item.Text, txt_ItemRate.Text, txt_quantity.Text, txt_Discount.Text, txt_TaxableValue.Text, txt_ItemCGST.Text, txt_ItemSGST.Text, txt_TotalItemValue.Text,txt_CGSTRate.Text,txt_SGSTRate.Text,"",lbl_productID.Text);
            cmb_Item.Text = "";
          //  dataGridView1.Rows.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            txt_ItemRate.Text = "0.00";
            txt_Discount.Text = "0.00";
            txt_quantity.Text = "0";
            Calculatetotal();
            DialogResult dialog = MessageBox.Show("Do you want to add another product?", "Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                cmb_Item.Focus();
                cmb_Item.DroppedDown = true;
            }
            else
            {
                txt_OtherCharges.Focus();
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.Text == "")
            {
                txt_quantity.Text = "0";
                Calculate();
            }
            else
            {
                Calculate();
            }
        }

        private void txt_ItemRate_TextChanged(object sender, EventArgs e)
        {
            if (txt_ItemRate.Text == "")
            {
                txt_ItemRate.Text = "0.00";
                Calculate();
            }
            else
            {
                Calculate();
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            btn_Print.Enabled = false;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Inserting Bill Summary
            if (dataGridView1.RowCount <= 0 || cmb_Customer.Text == "")
            {
                MessageBox.Show("Please add atleast one product");
            }
            else
            {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand();
                try
                {
                    con.Open();
                    String PurchaseSummary = "INSERT INTO PurchaseSummary(ID,PurchaseNo, PurchaseYear,PurchaseCreatedBy, PurchaseDate, CustomerName, CustomerAddress, CustomerGSTNumber, CustomerContactNumber, CompanyID, TotalCGST, TotalSGST, OtherTaxes, TotalTax, TotalPurchaseValue) VALUES (" + int.Parse(PurchaseID.Text) + ",'" + PurchaseID.Text + "'," + DateTime.Today.Year + ",'" + this.Name.Trim() + "','" + dateTimePicker1.Value.Date + "','" + cmb_Customer.Text + "','" + lbl_address.Text + "','" + lbl_GST.Text + "','" + lbl_ContactNumber.Text + "','1','" + lbl_CGST.Text + "','" + lbl_SGST.Text + "','" + txt_OtherCharges.Text + "','" + (double.Parse(lbl_CGST.Text) + double.Parse(lbl_SGST.Text)).ToString("N2") + "','" + lbl_PurchaseTotal.Text + "');";
                    cmd.CommandText = PurchaseSummary;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        String StrQuery = @"INSERT INTO PurchaseDetails(ID,PurchaseNo,ProductID,ProductName,Quantity,Rate,Discount,TaxableValue,CGST,SGST,TotalValue,CGSTRate,SGSTRate) VALUES ('" + int.Parse(PurchaseID.Text) + "_" + i + "'," + int.Parse(PurchaseID.Text) + ",'"
                            + dataGridView1.Rows[i].Cells["ItemCode"].Value + "','"
                            + dataGridView1.Rows[i].Cells["Itemdesc"].Value + "','"
                            + dataGridView1.Rows[i].Cells["Quantity"].Value + "','"
                            + dataGridView1.Rows[i].Cells["Rate"].Value + "','"
                            + dataGridView1.Rows[i].Cells["Discount"].Value + "','"
                            + dataGridView1.Rows[i].Cells["TaxableValue"].Value + "','"
                            + dataGridView1.Rows[i].Cells["CGST"].Value + "','"
                            + dataGridView1.Rows[i].Cells["SGST"].Value + "','"
                            + dataGridView1.Rows[i].Cells["TotalValue"].Value + "','"
                            + dataGridView1.Rows[i].Cells["CGSTRATE"].Value + "','"
                            + dataGridView1.Rows[i].Cells["SGSTRATE"].Value + "');";
                        con.Close();
                        con.Open();

                        cmd.CommandText = StrQuery;
                        cmd.ExecuteNonQuery();


                        //Update Stock

                        // SqlDataReader reader = command.ExecuteReader();
                        //   reader.Read();
                        
                        
                        con.Close();

                        MessageBox.Show("New Purchase Created");
                        btn_Print.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to Save.");
                }
            }

        }
        

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintInvoice Invoice1 = new PrintInvoice();
            Invoice1.Name = PurchaseID.Text;
            Invoice1.ShowDialog();
            // EmptyForm();
            btn_New.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Print.Enabled = false;
            btn_Close.Text = "&Close";
            EmptyForm();
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_Discount.Text == "")
            {
                txt_Discount.Text = "0.00";
                Calculate();
            }
            else
            {
                Calculate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Calculatetotal();
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to delete this row?", "Delete row?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if ((response == DialogResult.No))
            {
                e.Cancel = true;
            }
            Calculatetotal();
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            Calculatetotal();

        }

        private void EmptyForm()
        {
            PurchaseID.Clear();
            cmb_Customer.Items.Clear();
            lbl_GST.Text = "";
            lbl_address.Text = "";
            lbl_ContactNumber.Text = "";
            lbl_CGST.Text = "0.00";
            lbl_SGST.Text = "0.00";
            lbl_PurchaseTotal.Text = "0.00";
            txt_Discount.Text = "0.00";
         //   lbl_Stock.Text = "";
            txt_ItemCGST.Text = "0.00";
            txt_ItemRate.Text = "0.00";
            txt_ItemSGST.Text = "0.00";
            dataGridView1.Rows.Clear();
        }

     

        private void txt_OtherCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
                if (txt_OtherCharges.Text == "")
                {
                    txt_OtherCharges.Text = "0.00";
                    Calculatetotal();
                    btn_Save.Focus();
                }
                else
                {
                    Calculatetotal();
                }
            }
            else if (e.KeyChar== (char)Keys.Tab)
            {
                if (txt_OtherCharges.Text == "")
                {
                    txt_OtherCharges.Text = "0.00";
                    Calculatetotal();
                    btn_Save.Focus();
                }
                else
                {
                    Calculatetotal();
                }
            }
            else
            {

            }
        }

      
    }
    }
