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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GTDDataSet = new GSTSoft_windows.GTDDataSet();
            this.BillSummaryTableAdapter = new GSTSoft_windows.GTDDataSetTableAdapters.BillSummaryTableAdapter();
            this.BillDetailsTableAdapter = new GSTSoft_windows.GTDDataSetTableAdapters.BillDetailsTableAdapter();
            this.grp_Summary = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate1 = new System.Windows.Forms.DateTimePicker();
            this.Todate1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_MailTO = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.rdo_PDF = new System.Windows.Forms.RadioButton();
            this.rdo_Excel = new System.Windows.Forms.RadioButton();
            this.rdo_Word = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTDDataSet)).BeginInit();
            this.grp_Summary.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // grp_Summary
            // 
            this.grp_Summary.Controls.Add(this.label3);
            this.grp_Summary.Controls.Add(this.label2);
            this.grp_Summary.Controls.Add(this.FromDate1);
            this.grp_Summary.Controls.Add(this.Todate1);
            this.grp_Summary.Location = new System.Drawing.Point(12, 7);
            this.grp_Summary.Name = "grp_Summary";
            this.grp_Summary.Size = new System.Drawing.Size(441, 65);
            this.grp_Summary.TabIndex = 7;
            this.grp_Summary.TabStop = false;
            this.grp_Summary.Text = "SelectDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 24);
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
            this.FromDate1.Location = new System.Drawing.Point(100, 21);
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
            this.Todate1.Location = new System.Drawing.Point(309, 21);
            this.Todate1.Name = "Todate1";
            this.Todate1.Size = new System.Drawing.Size(120, 24);
            this.Todate1.TabIndex = 7;
            this.Todate1.Value = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reportViewer1);
            this.groupBox4.Location = new System.Drawing.Point(4, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(1420, 688);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report";
            // 
            // reportViewer1
            // 
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.BillDetailsBindingSource;
            reportDataSource12.Name = "DataSet2";
            reportDataSource12.Value = this.BillSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(6, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1405, 661);
            this.reportViewer1.TabIndex = 13;
            this.reportViewer1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_MailTO);
            this.groupBox3.Controls.Add(this.btn_Send);
            this.groupBox3.Location = new System.Drawing.Point(977, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 62);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email ID and Send";
            // 
            // txt_MailTO
            // 
            this.txt_MailTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MailTO.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MailTO.Location = new System.Drawing.Point(6, 22);
            this.txt_MailTO.Name = "txt_MailTO";
            this.txt_MailTO.Size = new System.Drawing.Size(328, 27);
            this.txt_MailTO.TabIndex = 5;
            // 
            // btn_Send
            // 
            this.btn_Send.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(351, 18);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(74, 37);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "&Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // rdo_PDF
            // 
            this.rdo_PDF.AutoSize = true;
            this.rdo_PDF.Location = new System.Drawing.Point(16, 26);
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
            this.rdo_Excel.Location = new System.Drawing.Point(88, 26);
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
            this.rdo_Word.Location = new System.Drawing.Point(171, 26);
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
            this.groupBox2.Location = new System.Drawing.Point(718, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 65);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format for Email";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(475, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 56);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(126, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
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
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1436, 770);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grp_Summary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTDDataSet)).EndInit();
            this.grp_Summary.ResumeLayout(false);
            this.grp_Summary.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BillSummaryBindingSource;
       // private DBDataSet DBDataSet;
        //private DBDataSetTableAdapters.BillSummaryTableAdapter BillSummaryTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private System.Windows.Forms.BindingSource BillDetailsBindingSource;
        private GTDDataSet GTDDataSet;
        private GTDDataSetTableAdapters.BillSummaryTableAdapter BillSummaryTableAdapter;
        private GTDDataSetTableAdapters.BillDetailsTableAdapter BillDetailsTableAdapter;
        private System.Windows.Forms.GroupBox grp_Summary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDate1;
        private System.Windows.Forms.DateTimePicker Todate1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_MailTO;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.RadioButton rdo_PDF;
        private System.Windows.Forms.RadioButton rdo_Excel;
        private System.Windows.Forms.RadioButton rdo_Word;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}