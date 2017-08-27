using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTSoft_windows
{
    public partial class Main : Form
    {
       // private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
          
            //   childForm.StartPosition = FormStartPosition.Manual;
            //  childForm.Location = new Point(Location.X + (Width - childForm.Width) / 2, Location.Y + (Height - childForm.Height) / 2);
            //  childForm.Show();


        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        

        private void viewMenu_Click(object sender, EventArgs e)
        {
            Form childform = new Invoice();
            childform.MdiParent = this;
            childform.Location = new Point(Location.X + (Width - childform.Width) / 2, Location.Y + (Height - childform.Height) / 2);
            childform.Name = UserName.Text;
            childform.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childform = new Product();
            childform.MdiParent = this;
            
            childform.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        
            UserName.Text =Name.Trim()+" - Manage - Users";
            
            timer1.Start();
             
          // DateTimeTimer.Text = DateTime.Now.ToShortDateString();
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void Close_Form(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childform = new StockEntry();
            childform.MdiParent = this;
            childform.Location = new Point(Location.X + (Width - childform.Width) / 2, Location.Y + (Height - childform.Height) / 2);

            childform.Show();
        }

        private void CustomerMenu_Click(object sender, EventArgs e)
        {
          
        }

        private void billSummaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.billSummaryBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.gTDDataSet);

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form childForm = new Customer();
            childForm.MdiParent = this;
            childForm.Location = new Point(Location.X + (Width - childForm.Width) / 2, Location.Y + (Height - childForm.Height) / 2);
            childForm.Show();
            

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Supplier();
            childForm.MdiParent = this;
            childForm.Location = new Point(Location.X + (Width - childForm.Width) / 2, Location.Y + (Height - childForm.Height) / 2);
            childForm.Show();
            
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            Form childForm = new Purchase();
            childForm.MdiParent = this;
            childForm.Location = new Point(Location.X + (Width - childForm.Width) / 2, Location.Y + (Height - childForm.Height) / 2);
            childForm.Show();
            
        }

        private void salesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childform = new PrintReports(UserName.Text);
            childform.MdiParent = this;
            childform.Location = new Point(Location.X + (Width - childform.Width) / 2, Location.Y + (Height - childform.Height) / 2);
            childform.Name = "Sale Summary";
            childform.Show();
        }

        private void purchaseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childform = new PrintReports(UserName.Text);
            childform.MdiParent = this;
            childform.Location = new Point(Location.X + (Width - childform.Width) / 2, Location.Y + (Height - childform.Height) / 2);
            childform.Name = "Purchase Summary";
            childform.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childform = new PrintInvoice(UserName.Text);
            childform.MdiParent = this;
            childform.Location = new Point(Location.X + (Width - childform.Width) / 2, Location.Y + (Height - childform.Height) / 2);
            childform.Name = "Invoice";
            
            childform.Show();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            Form childform = new UserInfo();
            childform.MdiParent = this;
            childform.Location = new Point(Location.X + (Width - childform.Width) / 2, Location.Y + (Height - childform.Height) / 2);
            childform.Name = "UserInfo";
            childform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimeTimer.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }
    }
}
