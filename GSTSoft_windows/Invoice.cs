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
    public partial class Invoice : Form
    {
        private static String currentID;
        private static bool EditMode=false;
        private static bool addnew = false;
        int indexRow;
        public Invoice()
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
            lbl_InvoiceTotal.Text = "0.00";
            ProgressBar.Value = 5;
            statusbar.Text = "Generating new invoice ID";
            loadinvoiceyear();
            dataGridView1.AllowUserToDeleteRows = false;

            // txt_invoicedate.Text=DateTime.Now()
            //get the list of customers
            SqlDataReader reader = null;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command1 = new SqlCommand("SELECT count(InvoiceNo) FROM BillSummary;", con);
            try
            {
                reader = command1.ExecuteReader();
                reader.Read();
                InvoiceID.Text = (int.Parse(reader[0].ToString()) + 1).ToString();
            }
            catch
            {
                InvoiceID.Text = "1";
            }
            //  InvoiceID.Text = "INV2017/" + (int.Parse(reader[0].ToString())+1);

           // reader = null;
            ProgressBar.Value = 25;
            statusbar.Text = "Loading the list of customers";
            ProgressBar.Value = 30;
            reader.Close();
            SqlCommand command = new SqlCommand("SELECT distinct(CompanyName),CustomerName, ID FROM CustomerInfo", con);
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
            con.Close();
            fillProductDetails();
            //dgvCmb.HeaderText = "Item Description";
            //dgvCmb.Name= "Product Name";

            //dataGridView1.Columns.Add(dgvCmb);
            // dataGridView1.Columns["Product Name"].Width = 200;
            //dataGridView1.Columns["Product Name"].DisplayIndex = 1;
            //dataGridView1.Columns["SrNo"].Width = 50;
            // LoadSerial();
            //ProgressBar.Value = 90;

         //   reader.Close();
           
            ProgressBar.Value = 100;
          
            cmb_Customer.Focus();

            cmb_Customer.DroppedDown = true;
            statusbar.Text = "Choose Customer Name";

        }

        public void fillProductDetails()
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
            con.Open();
            SqlCommand command2 = new SqlCommand("SELECT distinct(ProductName),ProductSize FROM ProductInfo WHERE ValidInd='Y'", con);
            SqlDataReader reader1 = null;
            reader1 = command2.ExecuteReader();
            cmb_Item.Items.Clear();
            while (reader1.Read())
            {
                cmb_Item.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
            con.Close();
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
                EditMode = false;
                // EmptyForm();
                btn_New.Enabled = true;
                btn_Edit.Enabled = true;
                btn_Print.Enabled = true;
                btn_AddNewItem.Visible = false;
                btn_ItemDelete.Visible = false;
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
            if (!EditMode)
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
                    SqlCommand command = new SqlCommand("SELECT GSTNumber, Address, Taluka, District, State, PostCode,PhoneNo FROM CustomerInfo WHERE CustomerName='" + cmb_Customer.Text + "';", con);
                    ProgressBar.Value = 30;
                    reader = command.ExecuteReader();
                    // reader.Read();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        // reader.Close();

                        SqlCommand command1 = new SqlCommand("SELECT GSTNumber, Address, Taluka, District, State, PostCode,PhoneNo FROM CustomerInfo WHERE CompanyName='" + cmb_Customer.Text + "';", con);
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
            if (!EditMode)
            {
                if (cmb_Item.Text != "")
                {
                    SqlDataReader reader = null;
                    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                    con.Open();
                    //String productCode;

                    SqlCommand command1 = new SqlCommand("SELECT ProductRate,Product_RateCurrency,HSNCode,ID FROM ProductInfo WHERE ProductName='" + cmb_Item.Text + "';", con);


                    reader = command1.ExecuteReader();
                    reader.Read();
                    txt_ItemRate.Text = reader[0].ToString().Trim();
                    HSNCode.Text = reader[2].ToString().Trim();
                    lbl_productID.Text = reader[3].ToString().Trim();
                    reader.Close();
                    SqlCommand command2 = new SqlCommand("SELECT FinalStock FROM StockInfo WHERE ID='" + lbl_productID.Text + "';", con);
                    SqlDataReader reader1 = command2.ExecuteReader();
                    reader1.Read();
                    if (!reader1.HasRows)
                    {
                        lbl_Stock.Text = "0";
                        //  currentID = reader1[1].ToString();

                    }
                    else
                    {
                        lbl_Stock.Text = reader1[0].ToString();
                        //   currentID = reader1[1].ToString();

                    }
                    con.Close();
                    txt_quantity.Text = "1";
                    txt_Discount.Text = "0.00";
                    Calculate();
                }
            }
            else
            {
                if (addnew) {

                    SqlDataReader reader = null;
                    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                    con.Open();
                    //String productCode;

                    SqlCommand command1 = new SqlCommand("SELECT ProductRate,Product_RateCurrency,HSNCode,ID FROM ProductInfo WHERE ProductName='" + cmb_Item.Text + "';", con);


                    reader = command1.ExecuteReader();
                    reader.Read();
                    txt_ItemRate.Text = reader[0].ToString().Trim();
                    HSNCode.Text = reader[2].ToString().Trim();
                    lbl_productID.Text = reader[3].ToString().Trim();
                    reader.Close();
                    SqlCommand command2 = new SqlCommand("SELECT FinalStock FROM StockInfo WHERE ID='" + lbl_productID.Text + "';", con);
                    SqlDataReader reader1 = command2.ExecuteReader();
                    reader1.Read();
                    if (!reader1.HasRows)
                    {
                        lbl_Stock.Text = "0";
                        //  currentID = reader1[1].ToString();

                    }
                    else
                    {
                        lbl_Stock.Text = reader1[0].ToString();
                        //   currentID = reader1[1].ToString();

                    }
                    con.Close();
                    txt_quantity.Text = "1";
                    txt_Discount.Text = "0.00";
                    Calculate();
                }
                else
                {
                    if (cmb_Item.Text != "")
                    {

                        SqlDataReader dtr = null;
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();

                        String commandtext = "SELECT ID,FinalStock FROM StockInfo  WHERE ID = (SELECT ID FROM ProductInfo WHERE ProductName = '" + cmb_Item.Text + "'  AND isPurchaseProduct='N');";
                        SqlCommand command1 = new SqlCommand(commandtext, con);
                        dtr=command1.ExecuteReader();
                        dtr.Read();
                        lbl_Stock.Text = dtr[1].ToString();
                        lbl_productID.Text = dtr[0].ToString();
                        con.Close();
                    }
                }

            }
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
                txt_ItemSGST.Text = ((double.Parse(txt_TaxableValue.Text) * double.Parse(txt_SGSTRate.Text) / 100)).ToString("N2");
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
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                {

                }
                else
                {
                    Totalcgst += Convert.ToDouble(dataGridView1.Rows[i].Cells["CGST"].Value);
                    Totalsgst += Convert.ToDouble(dataGridView1.Rows[i].Cells["SGST"].Value);
                    TotalAmount += Convert.ToDouble(dataGridView1.Rows[i].Cells["TotalValue"].Value) + otherCharges;
                }
            }

            lbl_CGST.Text = Totalcgst.ToString("N2");
            lbl_SGST.Text = Totalsgst.ToString("N2");
            lbl_InvoiceTotal.Text = (TotalAmount).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, HSNCode.Text, cmb_Item.Text, txt_ItemRate.Text, txt_quantity.Text, txt_Discount.Text, txt_TaxableValue.Text, txt_ItemCGST.Text, txt_ItemSGST.Text, txt_TotalItemValue.Text, txt_CGSTRate.Text, txt_SGSTRate.Text, lbl_Stock.Text, lbl_productID.Text);
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
            else
            {
                if (!addnew)
                {

                    DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                     dataGridView1.Rows[indexRow].Cells[0].Value= currentID;
                    dataGridView1.Rows[indexRow].Cells[1].Value = HSNCode.Text;
                    dataGridView1.Rows[indexRow].Cells[2].Value = cmb_Item.Text;

                    dataGridView1.Rows[indexRow].Cells[3].Value = txt_ItemRate.Text;
                    dataGridView1.Rows[indexRow].Cells[4].Value = txt_quantity.Text;
                    dataGridView1.Rows[indexRow].Cells[5].Value = txt_Discount.Text;
                    dataGridView1.Rows[indexRow].Cells[6].Value = txt_TaxableValue.Text;
                    dataGridView1.Rows[indexRow].Cells[7].Value = txt_ItemCGST.Text;
                    dataGridView1.Rows[indexRow].Cells[8].Value = txt_ItemSGST.Text;
                    dataGridView1.Rows[indexRow].Cells[10].Value = txt_CGSTRate.Text;
                    dataGridView1.Rows[indexRow].Cells[11].Value = txt_SGSTRate.Text;
                    dataGridView1.Rows[indexRow].Cells[9].Value = txt_TotalItemValue.Text;
                    dataGridView1.Rows[indexRow].Cells[12].Value = lbl_Stock.Text;
                    dataGridView1.Rows[indexRow].Cells[13].Value = lbl_productID.Text;
                    dataGridView1.Rows[indexRow].DefaultCellStyle.BackColor = Color.Blue;

                }
                else
                {
                    addnew = false;
                    
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, HSNCode.Text, cmb_Item.Text, txt_ItemRate.Text, txt_quantity.Text, txt_Discount.Text, txt_TaxableValue.Text, txt_ItemCGST.Text, txt_ItemSGST.Text, txt_TotalItemValue.Text, txt_CGSTRate.Text, txt_SGSTRate.Text, lbl_Stock.Text, lbl_productID.Text);
                    //dataGridView1.Rows[dataGridView1.Rows.Count]
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[1];
                    cmb_Item.Text = "";
                    //  dataGridView1.Rows.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    txt_ItemRate.Text = "0.00";
                    txt_Discount.Text = "0.00";
                    txt_quantity.Text = "0";
                    Calculatetotal();
                   // dataGridView1.Rows[indexRow].DefaultCellStyle.BackColor = Color.IndianRed;
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
              //  txt_ItemRate.Text = "0.00";
               // Calculate();
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

        public void loadinvoiceyear()
        {
            String cmdText = "Select distinct(InvoiceYear) from BillSummary;";
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    // reader.Read();
                    cmb_InvoiceYear.Text = DateTime.Now.Year.ToString();
                    while (reader.Read())
                    {
                        cmb_InvoiceYear.Items.Add(reader[0].ToString());
                    }



                }

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "&Save")//Inserting Bill Summary
            {
                if (dataGridView1.RowCount <= 0 || cmb_Customer.Text == "")
                {
                    MessageBox.Show("Please add atleast one product");
                }
                else
                {
                    if (lbl_InvoiceTotal.Text != "0.00" || lbl_InvoiceTotal.Text != "")
                    {
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        SqlCommand cmd = new SqlCommand();
                        //   try
                        //  {
                        con.Open();
                        String billSummary = "INSERT INTO BillSummary(ID,InvoiceNo, InvoiceYear,InvoiceCreatedBy, InvoiceDate, CustomerName, CustomerAddress, CustomerGSTNumber, CustomerContactNumber, CompanyID, TotalCGST, TotalSGST, OtherTaxes, TotalTax, TotalInvoiceValue) VALUES (" + int.Parse(InvoiceID.Text) + ",'" + InvoiceID.Text + "'," + cmb_InvoiceYear.Text + ",'" + this.Name.Split('-')[0] + "','" + dateTimePicker1.Value.Date + "','" + cmb_Customer.Text + "','" + lbl_address.Text + "','" + lbl_GST.Text + "','" + lbl_ContactNumber.Text + "','1','" + lbl_CGST.Text + "','" + lbl_SGST.Text + "','" + txt_OtherCharges.Text + "','" + (double.Parse(lbl_CGST.Text) + double.Parse(lbl_SGST.Text)).ToString("N2") + "','" + lbl_InvoiceTotal.Text + "');";
                        cmd.CommandText = billSummary;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            String StrQuery = @"INSERT INTO BillDetails(ID,InvoiceNo,ProductID,ProductName,Quantity,Rate,Discount,TaxableValue,CGST,SGST,TotalValue,CGSTRate,SGSTRate,InvoiceYear) VALUES ('" + int.Parse(InvoiceID.Text) + "_" + i + "'," + int.Parse(InvoiceID.Text) + ",'"
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
                                + dataGridView1.Rows[i].Cells["SGSTRATE"].Value + "','"
                                + cmb_InvoiceYear.Text + "');";
                            con.Close();
                            con.Open();

                            cmd.CommandText = StrQuery;
                            cmd.ExecuteNonQuery();


                            //Update Stock

                            // SqlDataReader reader = command.ExecuteReader();
                            //   reader.Read();
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = con;


                            string StockQuery;
                            //UpdateEarlier entry
                            if (dataGridView1.Rows[i].Cells["ExistingStock"].Value.ToString() == "0")
                            {

                                //  con.Open();

                                StockQuery = "INSERT INTO StockInfo(ID, CurrentStock, ProductionStock, SaleStock, FinalStock) VALUES('" + dataGridView1.Rows[i].Cells["ProduceCode"].Value + "','" + dataGridView1.Rows[i].Cells["ExistingStock"].Value + "', '0', '" + dataGridView1.Rows[i].Cells["Quantity"].Value + "', '" + (Convert.ToDouble(dataGridView1.Rows[i].Cells["ExistingStock"].Value) - Convert.ToDouble(dataGridView1.Rows[i].Cells["Quantity"].Value)) + "'); ";

                            }
                            else
                            {
                                StockQuery = "UPDATE StockInfo SET CurrentStock = " + int.Parse(dataGridView1.Rows[i].Cells["ExistingStock"].Value.ToString()) + ",ProductionStock = 0,SaleStock = " + Convert.ToUInt16(dataGridView1.Rows[i].Cells["Quantity"].Value) + ",FinalStock = " + (Convert.ToInt16(dataGridView1.Rows[i].Cells["ExistingStock"].Value.ToString()) - Convert.ToInt16(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString())) + " WHERE ID = '" + dataGridView1.Rows[i].Cells["ProduceCode"].Value + "';";
                            }
                            cmd1.CommandText = StockQuery;
                            cmd1.ExecuteNonQuery();
                            con.Close();

                          
                        }
                        MessageBox.Show("New Invoice Created");
                        btn_Print.Enabled = true;
                    }
                    //}
                    /*  catch
                      {
                          MessageBox.Show("Unable to Save.");
                      }*/
                }
            }
            if (btn_Save.Text == "&Update")
            {
                EditMode = false;
                if (dataGridView1.RowCount <= 0 || cmb_Customer.Text == "")
                {
                    MessageBox.Show("Please add atleast one product");
                }
                else
                {
                    if (lbl_InvoiceTotal.Text == "0.00" || lbl_InvoiceTotal.Text == "")
                    {
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        SqlCommand cmd = new SqlCommand();
                        //   try
                        //  {
                        con.Open();
                        String billSummary = "INSERT INTO BillSummary(ID,InvoiceNo, InvoiceYear,InvoiceCreatedBy, InvoiceDate, CustomerName, CustomerAddress, CustomerGSTNumber, CustomerContactNumber, CompanyID, TotalCGST, TotalSGST, OtherTaxes, TotalTax, TotalInvoiceValue) VALUES (" + int.Parse(InvoiceID.Text) + ",'" + InvoiceID.Text + "'," + dateTimePicker1.Value.Year.ToString() + ",'" + this.Name.Split('-')[0] + "','" + dateTimePicker1.Value.Date + "','" + cmb_Customer.Text + "','" + lbl_address.Text + "','" + lbl_GST.Text + "','" + lbl_ContactNumber.Text + "','1','" + lbl_CGST.Text + "','" + lbl_SGST.Text + "','" + txt_OtherCharges.Text + "','" + (double.Parse(lbl_CGST.Text) + double.Parse(lbl_SGST.Text)).ToString("N2") + "','" + lbl_InvoiceTotal.Text + "');";
                        cmd.CommandText = billSummary;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            String StrQuery = @"INSERT INTO BillDetails(ID,InvoiceNo,ProductID,ProductName,Quantity,Rate,Discount,TaxableValue,CGST,SGST,TotalValue,CGSTRate,SGSTRate,InvoiceYear) VALUES ('" + int.Parse(InvoiceID.Text) + "_" + i + "'," + int.Parse(InvoiceID.Text) + ",'"
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
                                + dataGridView1.Rows[i].Cells["SGSTRATE"].Value + "','"
                                + dateTimePicker1.Value.Year.ToString() + "');";
                            con.Close();
                            con.Open();

                            cmd.CommandText = StrQuery;
                            cmd.ExecuteNonQuery();


                            //Update Stock

                            // SqlDataReader reader = command.ExecuteReader();
                            //   reader.Read();
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = con;


                            string StockQuery;
                            //UpdateEarlier entry
                            if (dataGridView1.Rows[i].Cells["ExistingStock"].Value.ToString() == "0")
                            {

                                //  con.Open();

                                StockQuery = "INSERT INTO StockInfo(ID, CurrentStock, ProductionStock, SaleStock, FinalStock) VALUES('" + dataGridView1.Rows[i].Cells["ProduceCode"].Value + "','" + dataGridView1.Rows[i].Cells["ExistingStock"].Value + "', '0', '" + dataGridView1.Rows[i].Cells["Quantity"].Value + "', '" + (Convert.ToDouble(dataGridView1.Rows[i].Cells["ExistingStock"].Value) - Convert.ToDouble(dataGridView1.Rows[i].Cells["Quantity"].Value)) + "'); ";

                            }
                            else
                            {
                                StockQuery = "UPDATE StockInfo SET CurrentStock = " + int.Parse(dataGridView1.Rows[i].Cells["ExistingStock"].Value.ToString()) + ",ProductionStock = 0,SaleStock = " + Convert.ToUInt16(dataGridView1.Rows[i].Cells["Quantity"].Value) + ",FinalStock = " + (Convert.ToInt16(dataGridView1.Rows[i].Cells["ExistingStock"].Value.ToString()) - Convert.ToInt16(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString())) + " WHERE ID = '" + dataGridView1.Rows[i].Cells["ProduceCode"].Value + "';";
                            }
                            cmd1.CommandText = StockQuery;
                            cmd1.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("New Invoice Created");
                            btn_Print.Enabled = true;
                        }
                    }
                    //}
                    /*  catch
                      {
                          MessageBox.Show("Unable to Save.");
                      }*/
                }
            }

        }
        

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintInvoice1 Invoice1 = new PrintInvoice1();
            Invoice1.Name = InvoiceID.Text;
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
            if (EditMode)
            {

            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this row?", "Delete row?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if ((response == DialogResult.No))
                {
                    e.Cancel = true;
                }
                Calculatetotal();
            }
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            Calculatetotal();

        }

        private void EmptyForm()
        {
            InvoiceID.Clear();
            cmb_InvoiceYear.Items.Clear();
            cmb_Customer.Items.Clear();
            cmb_Customer.Text = "";
            cmb_Item.Text = "";
            cmb_Item.Items.Clear();
            lbl_GST.Text = "";
            lbl_address.Text = "";
            lbl_ContactNumber.Text = "";
            lbl_CGST.Text = "0.00";
            lbl_SGST.Text = "0.00";
            lbl_InvoiceTotal.Text = "0.00";
            txt_Discount.Text = "0.00";
            lbl_Stock.Text = "";
            txt_ItemCGST.Text = "0.00";
            txt_ItemRate.Text = "0.00";
            txt_ItemSGST.Text = "0.00";
            dataGridView1.Rows.Clear();
        }
        private void EmptyForm_EditMode()
        {
          //  InvoiceID.Clear();
            cmb_Customer.Items.Clear();
            cmb_Customer.Text = "";
            cmb_Item.Text = "";
            cmb_Item.Items.Clear();
            lbl_GST.Text = "";
            lbl_address.Text = "";
            lbl_ContactNumber.Text = "";
            lbl_CGST.Text = "0.00";
            lbl_SGST.Text = "0.00";
            lbl_InvoiceTotal.Text = "0.00";
            txt_Discount.Text = "0.00";
            lbl_Stock.Text = "";
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

        private void txt_CGSTRate_TextChanged(object sender, EventArgs e)
        {
            if (txt_CGSTRate.Text == "")
            {
                txt_CGSTRate.Text = "0.00";
                Calculate();
            }
            else
            {
                Calculate();
            }
        }

        private void txt_SGSTRate_TextChanged(object sender, EventArgs e)
        {
            if (txt_SGSTRate.Text == "")
            {
                txt_SGSTRate.Text = "0.00";
                Calculate();
            }
            else
            {
                Calculate();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            InvoiceID.Enabled = true;
            EditMode = true;
            btn_Save.Text = "&Update";
            btn_Print.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Close.Text = "&Cancel";
            btn_New.Enabled = false;
            btn_AddNewItem.Visible = true;
            PanelItemDetails.Enabled = true;
            loadinvoiceyear();
            btn_ItemDelete.Visible=true;
            dataGridView1.AllowUserToDeleteRows = false;
            InvoiceID.Focus();

        }

        private void InvoiceID_TextChanged(object sender, EventArgs e)
        {

            if (EditMode)
            {
                if(InvoiceID.Text.Trim() != "") { 
                toolStripStatusLabel1.Text = "Loading Bill Details";
                Application.UseWaitCursor = true;
                    if (InvoiceID.Text != "" || cmb_InvoiceYear.Text != "")
                    {
                        
                        EmptyForm_EditMode();
                        SqlDataReader reader = null;
                        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["GTDConnectionString"].ConnectionString);
                        con.Open();
                        SqlCommand command = new SqlCommand("SELECT ID ,InvoiceNo ,InvoiceYear ,InvoiceDate,CustomerName ,CustomerAddress ,CustomerGSTNumber ,CustomerContactNumber ,CompanyID ,TotalCGST ,TotalSGST ,OtherTaxes ,TotalTax ,TotalInvoiceValue ,ValidInd FROM dbo.BillSummary Where InvoiceNo='" + InvoiceID.Text + "' And InvoiceYear='" + cmb_InvoiceYear.Text + "' AND ValidInd='Y';", con);
                          try
                          {
                        reader = command.ExecuteReader();
                        reader.Read();
                        cmb_Customer.Items.Clear();

                        cmb_Customer.Text = reader[4].ToString().Trim();
                        lbl_address.Text = reader[5].ToString().Trim();
                        lbl_GST.Text = reader[6].ToString().Trim();
                        lbl_ContactNumber.Text = reader[7].ToString().Trim();
                        dateTimePicker1.Text = reader[3].ToString().Trim();
                        lbl_CGST.Text = reader[9].ToString().Trim();
                        lbl_SGST.Text = reader[10].ToString().Trim();
                        lbl_InvoiceTotal.Text = reader[13].ToString().Trim();
                        txt_OtherCharges.Text = reader[11].ToString().Trim();
                        con.Close();
                        con.Open();
                        SqlDataReader reader1 = null;
                        SqlCommand command1 = new SqlCommand("SELECT [Id] ,[ProductID] ,[ProductName] ,[Rate] ,[Quantity] ,[Discount] ,[TaxableValue] ,[CGST] ,[SGST] ,[TotalValue] ,[CGSTRate] ,[SGSTRate] ,[InvoiceYear] ,[ValidInd] FROM [dbo].[BillDetails] WHERE [InvoiceNo] = " + InvoiceID.Text + " AND [InvoiceYear] = '" + cmb_InvoiceYear.Text + "' AND [ValidInd] = 'Y';", con);
                        reader1 = command1.ExecuteReader();
                            while (reader1.Read())
                            {
                                dataGridView1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim(), reader1[3].ToString().Trim(), reader1[4].ToString().Trim(), reader1[5].ToString().Trim(), reader1[6].ToString().Trim(), reader1[7].ToString().Trim(), reader1[8].ToString().Trim(), reader1[9].ToString().Trim(), reader1[10].ToString().Trim(), reader1[11].ToString().Trim());
                            }
                        con.Close();


                        //InvoiceID.Text = (int.Parse(reader[0].ToString()) + 1).ToString();


                         }
                        catch
                        {
                            MessageBox.Show("Invalid Invoice Number", "Invoice");
                            InvoiceID.Clear();
                            
                            }
                        Application.UseWaitCursor = false;
                    }
                }
                }
            }
        private void FillProductFormfromDG(object sender, EventArgs e)
        {
            if (EditMode)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                indexRow= dataGridView1.CurrentCell.RowIndex; 
                currentID = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                HSNCode.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                cmb_Item.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                
                txt_ItemRate.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                txt_quantity.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                txt_Discount.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                txt_TaxableValue.Text = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
                txt_ItemCGST.Text = dataGridView1.Rows[rowindex].Cells[7].Value.ToString();
                txt_ItemSGST.Text = dataGridView1.Rows[rowindex].Cells[8].Value.ToString();
                txt_CGSTRate.Text = dataGridView1.Rows[rowindex].Cells[10].Value.ToString();
                txt_SGSTRate.Text = dataGridView1.Rows[rowindex].Cells[11].Value.ToString();
                txt_TotalItemValue.Text = dataGridView1.Rows[rowindex].Cells[9].Value.ToString();
            }
        }

        private void btn_ItemDelete_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (currentID.Contains("_"))
                {
                    DialogResult dg = MessageBox.Show("Do you really want to Delete this Item?", "Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dg == DialogResult.Yes)
                    {
                        if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DefaultCellStyle.BackColor == Color.Red)
                        {
                            MessageBox.Show("This Row is already marked for Deletion", "Invoice",MessageBoxButtons.OK);
                        }
                        else
                        {
                            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                            Calculatetotal();
                        }
                    }
                }
                else
                {
                    DialogResult dg =MessageBox.Show("Do you really want to Delete this Item?", "Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dg == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    }
                    
                }
            }
        }

        public void DeleteProductRowandrevertStock(String CurrentOrder,String BillID,String ProductCode)
        {

        }

        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
           // cmb_Item.Items.Clear();
            txt_quantity.Text = "0";
            txt_Discount.Text = "0.00";
            lbl_Stock.Text = "";
            txt_ItemCGST.Text = "0.00";
            txt_ItemRate.Text = "0.00";
            txt_ItemSGST.Text = "0.00";
            fillProductDetails();
            addnew = true;

        }
    }

   
         
    }
    
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          