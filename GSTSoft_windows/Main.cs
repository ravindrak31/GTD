﻿using System;
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
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Customer();
           
            childForm.Show();
            childForm.MdiParent = this;
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
            childform.Name = toolStripStatusLabel.Text;
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
            toolStripStatusLabel.Text =Name;
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            Form childform = new PrintReports();
            childform.MdiParent = this;

            childform.Show();
        }

       
    }
}