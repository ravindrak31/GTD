namespace GSTSoft_windows
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InvoiceReference = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InvoiceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemAdd = new System.Windows.Forms.Button();
            this.PanelItemDetails = new System.Windows.Forms.Panel();
            this.ProductID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_TotalItemValue = new System.Windows.Forms.TextBox();
            this.txt_ItemSGST = new System.Windows.Forms.TextBox();
            this.txt_ItemCGST = new System.Windows.Forms.TextBox();
            this.txt_TaxableValue = new System.Windows.Forms.TextBox();
            this.txt_ItemRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.cmb_Item = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_InvoiceTotal = new System.Windows.Forms.Label();
            this.lbl_SGST = new System.Windows.Forms.Label();
            this.lbl_CGST = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxableValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_ContactNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Customer = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.InvoiceReference);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.InvoiceID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(23, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 56);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1036, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 28);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // InvoiceReference
            // 
            this.InvoiceReference.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceReference.Location = new System.Drawing.Point(585, 12);
            this.InvoiceReference.Name = "InvoiceReference";
            this.InvoiceReference.Size = new System.Drawing.Size(172, 28);
            this.InvoiceReference.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(441, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Reference No : ";
            // 
            // InvoiceID
            // 
            this.InvoiceID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceID.Location = new System.Drawing.Point(121, 12);
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.Size = new System.Drawing.Size(132, 28);
            this.InvoiceID.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(914, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Invoice Date : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Invoice No : ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.btn_Print);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_New);
            this.panel2.Location = new System.Drawing.Point(314, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 61);
            this.panel2.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(499, 13);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(114, 34);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "&Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(379, 13);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(114, 34);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "&Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(258, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(114, 34);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "&Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(138, 13);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(114, 34);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "&Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(18, 13);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(114, 34);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.ItemAdd);
            this.panel3.Controls.Add(this.PanelItemDetails);
            this.panel3.Controls.Add(this.lbl_InvoiceTotal);
            this.panel3.Controls.Add(this.lbl_SGST);
            this.panel3.Controls.Add(this.lbl_CGST);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(23, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1252, 375);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1185, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ItemAdd
            // 
            this.ItemAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemAdd.ForeColor = System.Drawing.Color.Green;
            this.ItemAdd.Location = new System.Drawing.Point(1185, 17);
            this.ItemAdd.Name = "ItemAdd";
            this.ItemAdd.Size = new System.Drawing.Size(59, 40);
            this.ItemAdd.TabIndex = 8;
            this.ItemAdd.Text = "+";
            this.ItemAdd.UseVisualStyleBackColor = true;
            this.ItemAdd.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // PanelItemDetails
            // 
            this.PanelItemDetails.Controls.Add(this.ProductID);
            this.PanelItemDetails.Controls.Add(this.button2);
            this.PanelItemDetails.Controls.Add(this.txt_TotalItemValue);
            this.PanelItemDetails.Controls.Add(this.txt_ItemSGST);
            this.PanelItemDetails.Controls.Add(this.txt_ItemCGST);
            this.PanelItemDetails.Controls.Add(this.txt_TaxableValue);
            this.PanelItemDetails.Controls.Add(this.txt_ItemRate);
            this.PanelItemDetails.Controls.Add(this.label15);
            this.PanelItemDetails.Controls.Add(this.label18);
            this.PanelItemDetails.Controls.Add(this.label17);
            this.PanelItemDetails.Controls.Add(this.label16);
            this.PanelItemDetails.Controls.Add(this.label13);
            this.PanelItemDetails.Controls.Add(this.txt_Discount);
            this.PanelItemDetails.Controls.Add(this.txt_quantity);
            this.PanelItemDetails.Controls.Add(this.cmb_Item);
            this.PanelItemDetails.Controls.Add(this.label14);
            this.PanelItemDetails.Controls.Add(this.label12);
            this.PanelItemDetails.Controls.Add(this.label11);
            this.PanelItemDetails.Enabled = false;
            this.PanelItemDetails.Location = new System.Drawing.Point(48, 14);
            this.PanelItemDetails.Name = "PanelItemDetails";
            this.PanelItemDetails.Size = new System.Drawing.Size(1131, 119);
            this.PanelItemDetails.TabIndex = 7;
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(148, 47);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(54, 17);
            this.ProductID.TabIndex = 18;
            this.ProductID.Text = "label19";
            this.ProductID.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(1033, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_TotalItemValue
            // 
            this.txt_TotalItemValue.Enabled = false;
            this.txt_TotalItemValue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalItemValue.Location = new System.Drawing.Point(897, 76);
            this.txt_TotalItemValue.Name = "txt_TotalItemValue";
            this.txt_TotalItemValue.Size = new System.Drawing.Size(112, 28);
            this.txt_TotalItemValue.TabIndex = 17;
            // 
            // txt_ItemSGST
            // 
            this.txt_ItemSGST.Enabled = false;
            this.txt_ItemSGST.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemSGST.Location = new System.Drawing.Point(643, 76);
            this.txt_ItemSGST.Name = "txt_ItemSGST";
            this.txt_ItemSGST.Size = new System.Drawing.Size(100, 28);
            this.txt_ItemSGST.TabIndex = 16;
            // 
            // txt_ItemCGST
            // 
            this.txt_ItemCGST.Enabled = false;
            this.txt_ItemCGST.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemCGST.Location = new System.Drawing.Point(407, 76);
            this.txt_ItemCGST.Name = "txt_ItemCGST";
            this.txt_ItemCGST.Size = new System.Drawing.Size(100, 28);
            this.txt_ItemCGST.TabIndex = 15;
            // 
            // txt_TaxableValue
            // 
            this.txt_TaxableValue.Enabled = false;
            this.txt_TaxableValue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaxableValue.Location = new System.Drawing.Point(191, 76);
            this.txt_TaxableValue.Name = "txt_TaxableValue";
            this.txt_TaxableValue.Size = new System.Drawing.Size(100, 28);
            this.txt_TaxableValue.TabIndex = 14;
            // 
            // txt_ItemRate
            // 
            this.txt_ItemRate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemRate.Location = new System.Drawing.Point(596, 15);
            this.txt_ItemRate.Name = "txt_ItemRate";
            this.txt_ItemRate.Size = new System.Drawing.Size(73, 26);
            this.txt_ItemRate.TabIndex = 13;
            this.txt_ItemRate.TextChanged += new System.EventHandler(this.txt_ItemRate_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(529, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 12;
            this.label15.Text = "Rate : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(816, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 19);
            this.label18.TabIndex = 11;
            this.label18.Text = "Total : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(567, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "SGST : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(330, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 19);
            this.label16.TabIndex = 9;
            this.label16.Text = "CGST : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Taxable Value :";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.Location = new System.Drawing.Point(1033, 15);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(70, 26);
            this.txt_Discount.TabIndex = 7;
            this.txt_Discount.Text = "0.00";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(806, 14);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(73, 26);
            this.txt_quantity.TabIndex = 6;
            this.txt_quantity.Text = "1";
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // cmb_Item
            // 
            this.cmb_Item.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Item.FormattingEnabled = true;
            this.cmb_Item.Location = new System.Drawing.Point(148, 14);
            this.cmb_Item.Name = "cmb_Item";
            this.cmb_Item.Size = new System.Drawing.Size(347, 26);
            this.cmb_Item.TabIndex = 5;
            this.cmb_Item.SelectedIndexChanged += new System.EventHandler(this.cmb_Item_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(932, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Discount : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(708, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Quantity : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Product Name : ";
            // 
            // lbl_InvoiceTotal
            // 
            this.lbl_InvoiceTotal.AutoSize = true;
            this.lbl_InvoiceTotal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvoiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_InvoiceTotal.Location = new System.Drawing.Point(1057, 338);
            this.lbl_InvoiceTotal.Name = "lbl_InvoiceTotal";
            this.lbl_InvoiceTotal.Size = new System.Drawing.Size(0, 20);
            this.lbl_InvoiceTotal.TabIndex = 6;
            // 
            // lbl_SGST
            // 
            this.lbl_SGST.AutoSize = true;
            this.lbl_SGST.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_SGST.Location = new System.Drawing.Point(685, 340);
            this.lbl_SGST.Name = "lbl_SGST";
            this.lbl_SGST.Size = new System.Drawing.Size(0, 20);
            this.lbl_SGST.TabIndex = 5;
            // 
            // lbl_CGST
            // 
            this.lbl_CGST.AutoSize = true;
            this.lbl_CGST.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CGST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_CGST.Location = new System.Drawing.Point(276, 340);
            this.lbl_CGST.Name = "lbl_CGST";
            this.lbl_CGST.Size = new System.Drawing.Size(0, 20);
            this.lbl_CGST.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(941, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(580, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "SGST : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(176, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CGST : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ItemCode,
            this.Itemdesc,
            this.Rate,
            this.Quantity,
            this.Discount,
            this.TaxableValue,
            this.CGST,
            this.SGST,
            this.TotalValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(68, 139);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // SrNo
            // 
            this.SrNo.Frozen = true;
            this.SrNo.HeaderText = "#";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Width = 45;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 97;
            // 
            // Itemdesc
            // 
            this.Itemdesc.HeaderText = "Item Description";
            this.Itemdesc.Name = "Itemdesc";
            this.Itemdesc.ReadOnly = true;
            this.Itemdesc.Width = 132;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 68;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 91;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 96;
            // 
            // TaxableValue
            // 
            this.TaxableValue.HeaderText = "Taxable Value";
            this.TaxableValue.Name = "TaxableValue";
            this.TaxableValue.ReadOnly = true;
            this.TaxableValue.Width = 118;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            this.CGST.ReadOnly = true;
            this.CGST.Width = 79;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST";
            this.SGST.Name = "SGST";
            this.SGST.ReadOnly = true;
            this.SGST.Width = 78;
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "Total";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            this.TotalValue.Width = 70;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lbl_ContactNumber);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbl_address);
            this.panel4.Controls.Add(this.lbl_GST);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cmb_Customer);
            this.panel4.Location = new System.Drawing.Point(23, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1252, 166);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Contact Number : ";
            // 
            // lbl_ContactNumber
            // 
            this.lbl_ContactNumber.AutoSize = true;
            this.lbl_ContactNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContactNumber.Location = new System.Drawing.Point(200, 116);
            this.lbl_ContactNumber.Name = "lbl_ContactNumber";
            this.lbl_ContactNumber.Size = new System.Drawing.Size(0, 20);
            this.lbl_ContactNumber.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "GST Number : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(809, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Billing Address : ";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(808, 54);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(0, 19);
            this.lbl_address.TabIndex = 3;
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_GST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(200, 74);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(0, 20);
            this.lbl_GST.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer : ";
            // 
            // cmb_Customer
            // 
            this.cmb_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Customer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Customer.FormattingEnabled = true;
            this.cmb_Customer.Location = new System.Drawing.Point(219, 25);
            this.cmb_Customer.Name = "cmb_Customer";
            this.cmb_Customer.Size = new System.Drawing.Size(520, 26);
            this.cmb_Customer.TabIndex = 0;
            this.cmb_Customer.TextChanged += new System.EventHandler(this.cmb_Customer_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.toolStripStatusLabel1,
            this.statusbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 691);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1283, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 19);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 20);
            this.toolStripStatusLabel1.Text = "     ";
            // 
            // statusbar
            // 
            this.statusbar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(0, 20);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 716);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PanelItemDetails.ResumeLayout(false);
            this.PanelItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Customer;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox InvoiceReference;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InvoiceID;
        private System.Windows.Forms.Label lbl_InvoiceTotal;
        private System.Windows.Forms.Label lbl_SGST;
        private System.Windows.Forms.Label lbl_CGST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_ContactNumber;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel statusbar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button ItemAdd;
        private System.Windows.Forms.Panel PanelItemDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.ComboBox cmb_Item;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ItemRate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_TotalItemValue;
        private System.Windows.Forms.TextBox txt_ItemSGST;
        private System.Windows.Forms.TextBox txt_ItemCGST;
        private System.Windows.Forms.TextBox txt_TaxableValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxableValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
    }
}