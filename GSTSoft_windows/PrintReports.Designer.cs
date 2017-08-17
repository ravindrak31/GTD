namespace GSTSoft_windows
{
    partial class PrintReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GTDDataSet = new GSTSoft_windows.GTDDataSet();
            this.BillSummaryTableAdapter = new GSTSoft_windows.GTDDataSetTableAdapters.BillSummaryTableAdapter();
            this.BillDetailsTableAdapter = new GSTSoft_windows.GTDDataSetTableAdapters.BillDetailsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_reportType = new System.Windows.Forms.ComboBox();
            this.grp_Summary = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate1 = new System.Windows.Forms.DateTimePicker();
            this.Todate1 = new System.Windows.Forms.DateTimePicker();
            this.grp_Invoice = new System.Windows.Forms.GroupBox();
            this.cmb_InvYear = new System.Windows.Forms.ComboBox();
            this.txt_invoiceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Email = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_SendEmailCancel = new System.Windows.Forms.Button();
            this.txt_MailTO = new System.Windows.Forms.TextBox();
            this.rdo_PDF = new System.Windows.Forms.RadioButton();
            this.rdo_Excel = new System.Windows.Forms.RadioButton();
            this.rdo_Word = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillSummaryBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTDDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_Summary.SuspendLayout();
            this.grp_Invoice.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillDetailsBindingSource
            // 
            this.BillDetailsBindingSource.DataMember = "BillDetails";
            // 
            // BillSummaryBindingSource
            // 
            this.BillSummaryBindingSource.DataMember = "BillSummary";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Email);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(1141, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 56);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(195, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GTDDataSet
            // 
            this.GTDDataSet.DataSetName = "GTDDataSet";
            this.GTDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BillSummaryTableAdapter
            // 
            this.BillSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // BillDetailsTableAdapter
            // 
            this.BillDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_reportType);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select What To Print";
            // 
            // cmb_reportType
            // 
            this.cmb_reportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_reportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_reportType.FormattingEnabled = true;
            this.cmb_reportType.Items.AddRange(new object[] {
            "Invoice",
            "Sales Summary",
            "Purchase Summary"});
            this.cmb_reportType.Location = new System.Drawing.Point(6, 22);
            this.cmb_reportType.Name = "cmb_reportType";
            this.cmb_reportType.Size = new System.Drawing.Size(219, 28);
            this.cmb_reportType.TabIndex = 3;
            this.cmb_reportType.SelectedIndexChanged += new System.EventHandler(this.cmb_reportType_SelectedIndexChanged);
            // 
            // grp_Summary
            // 
            this.grp_Summary.Controls.Add(this.label3);
            this.grp_Summary.Controls.Add(this.label2);
            this.grp_Summary.Controls.Add(this.FromDate1);
            this.grp_Summary.Controls.Add(this.Todate1);
            this.grp_Summary.Enabled = false;
            this.grp_Summary.Location = new System.Drawing.Point(247, 1);
            this.grp_Summary.Name = "grp_Summary";
            this.grp_Summary.Size = new System.Drawing.Size(599, 65);
            this.grp_Summary.TabIndex = 7;
            this.grp_Summary.TabStop = false;
            this.grp_Summary.Text = "SelectDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "From Date :";
            // 
            // FromDate1
            // 
            this.FromDate1.CustomFormat = "dd/MM/yyyy";
            this.FromDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate1.Location = new System.Drawing.Point(244, 23);
            this.FromDate1.Name = "FromDate1";
            this.FromDate1.Size = new System.Drawing.Size(119, 24);
            this.FromDate1.TabIndex = 8;
            this.FromDate1.Value = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            // 
            // Todate1
            // 
            this.Todate1.CustomFormat = "dd/MM/yyyy";
            this.Todate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Todate1.Location = new System.Drawing.Point(453, 23);
            this.Todate1.Name = "Todate1";
            this.Todate1.Size = new System.Drawing.Size(120, 24);
            this.Todate1.TabIndex = 7;
            this.Todate1.Value = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            // 
            // grp_Invoice
            // 
            this.grp_Invoice.Controls.Add(this.cmb_InvYear);
            this.grp_Invoice.Controls.Add(this.txt_invoiceNumber);
            this.grp_Invoice.Controls.Add(this.label1);
            this.grp_Invoice.Enabled = false;
            this.grp_Invoice.Location = new System.Drawing.Point(855, 1);
            this.grp_Invoice.Name = "grp_Invoice";
            this.grp_Invoice.Size = new System.Drawing.Size(280, 65);
            this.grp_Invoice.TabIndex = 11;
            this.grp_Invoice.TabStop = false;
            this.grp_Invoice.Text = "Invoice Number";
            // 
            // cmb_InvYear
            // 
            this.cmb_InvYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_InvYear.FormattingEnabled = true;
            this.cmb_InvYear.Location = new System.Drawing.Point(114, 22);
            this.cmb_InvYear.Name = "cmb_InvYear";
            this.cmb_InvYear.Size = new System.Drawing.Size(89, 28);
            this.cmb_InvYear.TabIndex = 10;
            // 
            // txt_invoiceNumber
            // 
            this.txt_invoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceNumber.Location = new System.Drawing.Point(209, 22);
            this.txt_invoiceNumber.Name = "txt_invoiceNumber";
            this.txt_invoiceNumber.Size = new System.Drawing.Size(55, 28);
            this.txt_invoiceNumber.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bill No : INV";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reportViewer1);
            this.groupBox4.Location = new System.Drawing.Point(4, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(1423, 687);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BillDetailsBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.BillSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(6, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1405, 661);
            this.reportViewer1.TabIndex = 13;
            this.reportViewer1.Visible = false;
            // 
            // btn_Email
            // 
            this.btn_Email.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Email.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Email.Location = new System.Drawing.Point(110, 7);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(79, 37);
            this.btn_Email.TabIndex = 2;
            this.btn_Email.Text = "&Email";
            this.btn_Email.UseVisualStyleBackColor = true;
            this.btn_Email.Click += new System.EventHandler(this.btn_Email_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_MailTO);
            this.groupBox3.Controls.Add(this.btn_Send);
            this.groupBox3.Controls.Add(this.btn_SendEmailCancel);
            this.groupBox3.Location = new System.Drawing.Point(523, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 65);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email ID and Send";
            // 
            // btn_Send
            // 
            this.btn_Send.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(432, 19);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(79, 37);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "&Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_SendEmailCancel
            // 
            this.btn_SendEmailCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SendEmailCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_SendEmailCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendEmailCancel.Location = new System.Drawing.Point(517, 19);
            this.btn_SendEmailCancel.Name = "btn_SendEmailCancel";
            this.btn_SendEmailCancel.Size = new System.Drawing.Size(79, 37);
            this.btn_SendEmailCancel.TabIndex = 3;
            this.btn_SendEmailCancel.Text = "&Cancel";
            this.btn_SendEmailCancel.UseVisualStyleBackColor = true;
            // 
            // txt_MailTO
            // 
            this.txt_MailTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MailTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MailTO.Location = new System.Drawing.Point(6, 22);
            this.txt_MailTO.Name = "txt_MailTO";
            this.txt_MailTO.Size = new System.Drawing.Size(420, 28);
            this.txt_MailTO.TabIndex = 5;
            // 
            // rdo_PDF
            // 
            this.rdo_PDF.AutoSize = true;
            this.rdo_PDF.Location = new System.Drawing.Point(15, 27);
            this.rdo_PDF.Name = "rdo_PDF";
            this.rdo_PDF.Size = new System.Drawing.Size(56, 21);
            this.rdo_PDF.TabIndex = 0;
            this.rdo_PDF.TabStop = true;
            this.rdo_PDF.Text = "PDF";
            this.rdo_PDF.UseVisualStyleBackColor = true;
            // 
            // rdo_Excel
            // 
            this.rdo_Excel.AutoSize = true;
            this.rdo_Excel.Location = new System.Drawing.Point(92, 27);
            this.rdo_Excel.Name = "rdo_Excel";
            this.rdo_Excel.Size = new System.Drawing.Size(62, 21);
            this.rdo_Excel.TabIndex = 1;
            this.rdo_Excel.TabStop = true;
            this.rdo_Excel.Text = "Excel";
            this.rdo_Excel.UseVisualStyleBackColor = true;
            // 
            // rdo_Word
            // 
            this.rdo_Word.AutoSize = true;
            this.rdo_Word.Location = new System.Drawing.Point(174, 27);
            this.rdo_Word.Name = "rdo_Word";
            this.rdo_Word.Size = new System.Drawing.Size(63, 21);
            this.rdo_Word.TabIndex = 2;
            this.rdo_Word.TabStop = true;
            this.rdo_Word.Text = "Word";
            this.rdo_Word.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_Word);
            this.groupBox2.Controls.Add(this.rdo_Excel);
            this.groupBox2.Controls.Add(this.rdo_PDF);
            this.groupBox2.Location = new System.Drawing.Point(267, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 65);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format for Email";
            // 
            // PrintReports
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1436, 825);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grp_Invoice);
            this.Controls.Add(this.grp_Summary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillSummaryBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTDDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grp_Summary.ResumeLayout(false);
            this.grp_Summary.PerformLayout();
            this.grp_Invoice.ResumeLayout(false);
            this.grp_Invoice.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource BillSummaryBindingSource;
       // private DBDataSet DBDataSet;
        //private DBDataSetTableAdapters.BillSummaryTableAdapter BillSummaryTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private System.Windows.Forms.BindingSource BillDetailsBindingSource;
        private GTDDataSet GTDDataSet;
        private GTDDataSetTableAdapters.BillSummaryTableAdapter BillSummaryTableAdapter;
        private GTDDataSetTableAdapters.BillDetailsTableAdapter BillDetailsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_reportType;
        private System.Windows.Forms.GroupBox grp_Summary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDate1;
        private System.Windows.Forms.DateTimePicker Todate1;
        private System.Windows.Forms.GroupBox grp_Invoice;
        private System.Windows.Forms.TextBox txt_invoiceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_InvYear;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_MailTO;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_SendEmailCancel;
        private System.Windows.Forms.RadioButton rdo_PDF;
        private System.Windows.Forms.RadioButton rdo_Excel;
        private System.Windows.Forms.RadioButton rdo_Word;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}