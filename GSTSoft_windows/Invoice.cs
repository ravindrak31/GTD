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
    public partial class Invoice : Form
    {
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
            
            lbl_CGST.Text = "0.00";
            lbl_SGST.Text = "0.00";
            lbl_InvoiceTotal.Text = "0.00";
            ProgressBar.Value = 5;
            statusbar.Text = "Generating new invoice ID";
           // txt_invoicedate.Text=DateTime.Now()
                //get the list of customers
            OleDbDataReader reader = null;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
            con.Open();
            OleDbCommand command1 = new OleDbCommand("SELECT count(InvoiceNo) FROM BillSummary;", con);
            try {
                reader = command1.ExecuteReader();
                reader.Read();
                InvoiceID.Text = "INV2017/" + (int.Parse(reader[0].ToString()) + 1);
            }
            catch
            {
                InvoiceID.Text = "INV2017/001";
            }
          //  InvoiceID.Text = "INV2017/" + (int.Parse(reader[0].ToString())+1);
          
            reader = null;
            ProgressBar.Value = 25;
            statusbar.Text = "Loading the list of customers";
            ProgressBar.Value = 30;
            OleDbCommand command = new OleDbCommand("SELECT distinct(CustomerName) FROM CustomerInfo", con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb_Customer.Items.Add(reader[0].ToString());
            }
            reader = null;
            ProgressBar.Value = 50;
            dataGridView1.Visible = true;
            statusbar.Text = "Loading the list of products";
            //  OleDbCommand command2 = new OleDbCommand("SELECT distinct(CustomerName) FROM CustomerInfo", con);
            OleDbCommand command2 = new OleDbCommand("SELECT distinct(ProductName),ProductSize FROM ProductInfo", con);
            reader = command2.ExecuteReader();
            while (reader.Read())
            { 
                cmb_Item.Items.Add(reader[0].ToString());
            }
            //dgvCmb.HeaderText = "Item Description";
            //dgvCmb.Name= "Product Name";
            
            //dataGridView1.Columns.Add(dgvCmb);
           // dataGridView1.Columns["Product Name"].Width = 200;
            //dataGridView1.Columns["Product Name"].DisplayIndex = 1;
            //dataGridView1.Columns["SrNo"].Width = 50;
           // LoadSerial();
            //ProgressBar.Value = 90;

            
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
                OleDbDataReader reader = null;
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
                ProgressBar.Value = 20;
                con.Open();
                OleDbCommand command = new OleDbCommand("SELECT GSTNumber, Address, Taluka, District, State, PostCode,PhoneNo FROM CustomerInfo WHERE CustomerName='" + cmb_Customer.Text + "';", con);
                ProgressBar.Value = 30;
                reader = command.ExecuteReader();
                ProgressBar.Value = 40;
                reader.Read();
                ProgressBar.Value = 50;
                lbl_GST.Text = reader[0].ToString();
                ProgressBar.Value = 70;
                lbl_address.Text = reader[1].ToString() + "\nTaluka :" + reader[2].ToString() + ", DIstrict : " + reader[3].ToString() + "\n" + reader[4].ToString() + " - " + reader[5].ToString();
                lbl_ContactNumber.Text = reader[6].ToString();
                ProgressBar.Value = 90;
                statusbar.ForeColor = Color.Green;
                statusbar.Text = "Please choose product and proceed with Bill";
                con.Close();

                ProgressBar.Value = 100;
            }
        }

        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void ItemAdd_Click(object sender, EventArgs e)
        {
            PanelItemDetails.Enabled = true;

            txt_ItemRate.Text = "0.00";
        }

        private void cmb_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataReader reader = null;
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
            con.Open();
            

            OleDbCommand command1 = new OleDbCommand("SELECT ProductRate,Product_RateCurrency,ProductID FROM ProductInfo WHERE ProductName='" + cmb_Item.Text+ "';", con);

            reader = command1.ExecuteReader();
            reader.Read();
            txt_ItemRate.Text = reader[0].ToString();
            ProductID.Text = reader[2].ToString();
            
            con.Close();
            txt_quantity.Text= "1";
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

                txt_TaxableValue.Text = ((rate * quantity) - discount).ToString();
                txt_ItemCGST.Text = ((double.Parse(this.txt_TaxableValue.Text) * 5 / 100)).ToString("N2");
                txt_ItemSGST.Text = ((double.Parse(txt_TaxableValue.Text) * 5 / 100)).ToString("N2");
                txt_TotalItemValue.Text = ((double.Parse(txt_TaxableValue.Text)) + (double.Parse(txt_ItemCGST.Text)) + (double.Parse(txt_ItemSGST.Text))).ToString("N2");
            }
        }
        public void Calculatetotal()
        {
            double Totalcgst = 0;
            double Totalsgst = 0;
            double TotalAmount = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Totalcgst += Convert.ToDouble(dataGridView1.Rows[i].Cells["CGST"].Value);
                Totalsgst += Convert.ToDouble(dataGridView1.Rows[i].Cells["SGST"].Value);
                TotalAmount += Convert.ToDouble(dataGridView1.Rows[i].Cells["TotalValue"].Value);
            }

            lbl_CGST.Text = Totalcgst.ToString("N2");
            lbl_SGST.Text = Totalsgst.ToString("N2");
            lbl_InvoiceTotal.Text = TotalAmount.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dataGridView1.Rows.Count+1, ProductID.Text, cmb_Item.Text,txt_ItemRate.Text, txt_quantity.Text, txt_Discount.Text, txt_TaxableValue.Text, txt_ItemCGST.Text, txt_ItemSGST.Text, txt_TotalItemValue.Text);
            cmb_Item.Text = "";
            txt_ItemRate.Text = "0.00";
            txt_Discount.Text = "0.00";
            txt_quantity.Text = "0";
            Calculatetotal();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt_ItemRate_TextChanged(object sender, EventArgs e)
        {
           // Calculate();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Inserting Bill Summary
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c:\DB.accdb;Jet OLEDB:Database Password=GST");
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                con.Open();
                String billSummary = "INSERT INTO BillSummary(InvoiceNo, InvoiceCreatedBy, InvoiceDate, CustomerName, CustomerAddress, CustomerGSTNumber, CustomerContactNumber, CompanyID, TotalCGST, TotalSGST, OtherTaxes, TotalTax, TotalInvoiceValue) VALUES ('" + InvoiceID.Text + "','" + this.Name + "','" + dateTimePicker1.Text + "','" + cmb_Customer.Text + "','" + lbl_address.Text + "','" + lbl_GST.Text + "','" + lbl_ContactNumber.Text + "','1','" + lbl_CGST.Text + "','" + lbl_SGST.Text + "','0.00','" + (double.Parse(lbl_CGST.Text) + double.Parse(lbl_SGST.Text)).ToString("N2") + "','" + lbl_InvoiceTotal.Text + "');";
                cmd.CommandText = billSummary;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String StrQuery = @"INSERT INTO BillDetails(InvoiceNo,ProductID,ProductName,Quantity,Rate,Discount,TaxableValue,CGST,SGST,TotalValue) VALUES ('" + InvoiceID.Text + "','"
                        + dataGridView1.Rows[i].Cells["ItemCode"].Value + "','"
                        + dataGridView1.Rows[i].Cells["Itemdesc"].Value + "','"
                        + dataGridView1.Rows[i].Cells["Quantity"].Value + "','"
                        + dataGridView1.Rows[i].Cells["Rate"].Value + "','"
                        + dataGridView1.Rows[i].Cells["Discount"].Value + "','"
                        + dataGridView1.Rows[i].Cells["TaxableValue"].Value + "','"
                        + dataGridView1.Rows[i].Cells["CGST"].Value + "','"
                        + dataGridView1.Rows[i].Cells["SGST"].Value + "','"
                        + dataGridView1.Rows[i].Cells["TotalValue"].Value + "');";
                    cmd.CommandText = StrQuery;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("New Invoice Created");
                btn_Print.Enabled = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Unable to Save.");
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintInvoice Invoice1 = new PrintInvoice();
            Invoice1.Name = InvoiceID.Text;
            Invoice1.ShowDialog();
            // EmptyForm();
            btn_New.Enabled = true;
            btn_Edit.Enabled = true;
            btn_Print.Enabled = true;
            btn_Close.Text = "&Close";
        }
    }
}
