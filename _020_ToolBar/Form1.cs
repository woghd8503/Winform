using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_ToolBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripButton.Click += NewToolStripButton_Click;
            this.openToolStripButton.Click += OpenToolStripButton_Click;
            this.saveToolStripButton.Click += SaveToolStripButton_Click;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");

        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New");

        }
    }
}
