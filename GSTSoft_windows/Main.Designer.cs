﻿namespace GSTSoft_windows
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UserName = new System.Windows.Forms.ToolStripLabel();
            this.DateTimeTimer = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerMenu
            // 
            this.CustomerMenu.AutoSize = false;
            this.CustomerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.CustomerMenu.Image = global::GSTSoft_windows.Properties.Resources.add_user_256;
            this.CustomerMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.CustomerMenu.Name = "CustomerMenu";
            this.CustomerMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.CustomerMenu.Size = new System.Drawing.Size(117, 50);
            this.CustomerMenu.Text = "&Party";
            this.CustomerMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CustomerMenu.Click += new System.EventHandler(this.CustomerMenu_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.customerToolStripMenuItem.Text = "&Customer ";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.supplierToolStripMenuItem.Text = "&Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.AutoSize = false;
            this.productsToolStripMenuItem.Image = global::GSTSoft_windows.Properties.Resources.purchase_order_256;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(117, 50);
            this.productsToolStripMenuItem.Text = "P&roducts";
            this.productsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.AutoSize = false;
            this.editMenu.Image = global::GSTSoft_windows.Properties.Resources.indian_rupee_256;
            this.editMenu.Name = "editMenu";
            this.editMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.editMenu.Size = new System.Drawing.Size(120, 50);
            this.editMenu.Text = "&Purchase";
            this.editMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.AutoSize = false;
            this.viewMenu.Image = global::GSTSoft_windows.Properties.Resources.cash_receiving_256;
            this.viewMenu.ImageTransparentColor = System.Drawing.Color.White;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.viewMenu.Size = new System.Drawing.Size(117, 50);
            this.viewMenu.Text = "&Sales";
            this.viewMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.viewMenu.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.AutoSize = false;
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.salesSummaryToolStripMenuItem,
            this.purchaseSummaryToolStripMenuItem});
            this.toolsMenu.Image = global::GSTSoft_windows.Properties.Resources.report_256;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toolsMenu.Size = new System.Drawing.Size(101, 50);
            this.toolsMenu.Text = "&Reports";
            this.toolsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolsMenu.Click += new System.EventHandler(this.toolsMenu_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Image = global::GSTSoft_windows.Properties.Resources.purchase_order_256__1_;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // salesSummaryToolStripMenuItem
            // 
            this.salesSummaryToolStripMenuItem.Name = "salesSummaryToolStripMenuItem";
            this.salesSummaryToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.salesSummaryToolStripMenuItem.Text = "Sale Summary";
            this.salesSummaryToolStripMenuItem.Click += new System.EventHandler(this.salesSummaryToolStripMenuItem_Click);
            // 
            // purchaseSummaryToolStripMenuItem
            // 
            this.purchaseSummaryToolStripMenuItem.Name = "purchaseSummaryToolStripMenuItem";
            this.purchaseSummaryToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.purchaseSummaryToolStripMenuItem.Text = "Purchase Summary";
            this.purchaseSummaryToolStripMenuItem.Click += new System.EventHandler(this.purchaseSummaryToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerMenu,
            this.productsToolStripMenuItem,
            this.editMenu,
            this.stockToolStripMenuItem,
            this.viewMenu,
            this.toolsMenu,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(15, 10, 0, 15);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(150, 646);
            this.menuStrip.TabIndex = 0;
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.AutoSize = false;
            this.stockToolStripMenuItem.Image = global::GSTSoft_windows.Properties.Resources.cart_69_256;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(117, 50);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AutoSize = false;
            this.exitToolStripMenuItem.Image = global::GSTSoft_windows.Properties.Resources.logout_xxl;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 50);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitToolStripMenuItem.ToolTipText = "You can also use ALT+X";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserName,
            this.DateTimeTimer});
            this.toolStrip1.Location = new System.Drawing.Point(150, 618);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UserName.Image = global::GSTSoft_windows.Properties.Resources.user;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(162, 25);
            this.UserName.Text = "toolStripLabel1";
            this.UserName.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DateTimeTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateTimeTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DateTimeTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DateTimeTimer.Name = "DateTimeTimer";
            this.DateTimeTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateTimeTimer.Size = new System.Drawing.Size(142, 25);
            this.DateTimeTimer.Text = "toolStripLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1171, 646);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close_Form);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem CustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel UserName;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel DateTimeTimer;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseSummaryToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}



