namespace GSTSoft_windows
{
    partial class StockEntry
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.productDetails = new System.Windows.Forms.Panel();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ProductName = new System.Windows.Forms.ComboBox();
            this.txt_ProductionStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.productDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_New);
            this.panel2.Location = new System.Drawing.Point(64, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 64);
            this.panel2.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(264, 13);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(97, 34);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "&Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Green;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(144, 13);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(97, 34);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "&Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(22, 13);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(97, 34);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&New";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // productDetails
            // 
            this.productDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productDetails.Controls.Add(this.txt_Stock);
            this.productDetails.Controls.Add(this.label1);
            this.productDetails.Controls.Add(this.cmb_ProductName);
            this.productDetails.Controls.Add(this.txt_ProductionStock);
            this.productDetails.Controls.Add(this.label3);
            this.productDetails.Controls.Add(this.label2);
            this.productDetails.Location = new System.Drawing.Point(12, 82);
            this.productDetails.Name = "productDetails";
            this.productDetails.Size = new System.Drawing.Size(495, 104);
            this.productDetails.TabIndex = 6;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.Location = new System.Drawing.Point(423, 58);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(67, 28);
            this.txt_Stock.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available Stock -";
            // 
            // cmb_ProductName
            // 
            this.cmb_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ProductName.FormattingEnabled = true;
            this.cmb_ProductName.Location = new System.Drawing.Point(172, 16);
            this.cmb_ProductName.Name = "cmb_ProductName";
            this.cmb_ProductName.Size = new System.Drawing.Size(298, 28);
            this.cmb_ProductName.TabIndex = 1;
            this.cmb_ProductName.SelectedIndexChanged += new System.EventHandler(this.cmb_ProductName_SelectedIndexChanged);
            // 
            // txt_ProductionStock
            // 
            this.txt_ProductionStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductionStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductionStock.Location = new System.Drawing.Point(172, 62);
            this.txt_ProductionStock.Name = "txt_ProductionStock";
            this.txt_ProductionStock.Size = new System.Drawing.Size(89, 27);
            this.txt_ProductionStock.TabIndex = 3;
            this.txt_ProductionStock.TextChanged += new System.EventHandler(this.txt_ProductionStock_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Items :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name : ";
            // 
            // StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 193);
            this.ControlBox = false;
            this.Controls.Add(this.productDetails);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.StockEntry_Load);
            this.panel2.ResumeLayout(false);
            this.productDetails.ResumeLayout(false);
            this.productDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Panel productDetails;
        private System.Windows.Forms.ComboBox cmb_ProductName;
        private System.Windows.Forms.TextBox txt_ProductionStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label1;
    }
}