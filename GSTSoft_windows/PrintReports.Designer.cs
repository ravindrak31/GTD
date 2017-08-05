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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DBDataSet = new GSTSoft_windows.DBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_report = new System.Windows.Forms.RadioButton();
            this.radio_bill = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BillSummaryTableAdapter = new GSTSoft_windows.DBDataSetTableAdapters.BillSummaryTableAdapter();
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillDetailsTableAdapter = new GSTSoft_windows.DBDataSetTableAdapters.BillDetailsTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BillSummaryBindingSource
            // 
            this.BillSummaryBindingSource.DataMember = "BillSummary";
            this.BillSummaryBindingSource.DataSource = this.DBDataSet;
            // 
            // DBDataSet
            // 
            this.DBDataSet.DataSetName = "DBDataSet";
            this.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_report);
            this.panel1.Controls.Add(this.radio_bill);
            this.panel1.Location = new System.Drawing.Point(53, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 69);
            this.panel1.TabIndex = 1;
            // 
            // radio_report
            // 
            this.radio_report.AutoSize = true;
            this.radio_report.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radio_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_report.Location = new System.Drawing.Point(174, 18);
            this.radio_report.Name = "radio_report";
            this.radio_report.Size = new System.Drawing.Size(90, 29);
            this.radio_report.TabIndex = 1;
            this.radio_report.Text = "Report";
            this.radio_report.UseVisualStyleBackColor = true;
            this.radio_report.CheckedChanged += new System.EventHandler(this.radio_report_CheckedChanged);
            // 
            // radio_bill
            // 
            this.radio_bill.AutoSize = true;
            this.radio_bill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radio_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_bill.Location = new System.Drawing.Point(24, 18);
            this.radio_bill.Name = "radio_bill";
            this.radio_bill.Size = new System.Drawing.Size(123, 29);
            this.radio_bill.TabIndex = 0;
            this.radio_bill.Text = "Display Bill";
            this.radio_bill.UseVisualStyleBackColor = true;
            this.radio_bill.CheckedChanged += new System.EventHandler(this.radio_bill_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(342, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 69);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "From Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 27);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(639, 17);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 27);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2017, 7, 27, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(164, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill No :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(1139, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 69);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(138, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillSummaryTableAdapter
            // 
            this.BillSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // dBDataSetBindingSource
            // 
            this.dBDataSetBindingSource.DataSource = this.DBDataSet;
            this.dBDataSetBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.BillSummaryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(104, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1206, 551);
            this.reportViewer1.TabIndex = 4;
            // 
            // BillDetailsBindingSource
            // 
            this.BillDetailsBindingSource.DataMember = "BillDetails";
            this.BillDetailsBindingSource.DataSource = this.DBDataSet;
            // 
            // BillDetailsTableAdapter
            // 
            this.BillDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(79, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 27);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "INV2017/";
            // 
            // PrintReports
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1423, 645);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrintReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radio_report;
        private System.Windows.Forms.RadioButton radio_bill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource BillSummaryBindingSource;
        private DBDataSet DBDataSet;
        private DBDataSetTableAdapters.BillSummaryTableAdapter BillSummaryTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillDetailsBindingSource;
        private DBDataSetTableAdapters.BillDetailsTableAdapter BillDetailsTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
    }
}