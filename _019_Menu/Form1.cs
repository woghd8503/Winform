using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_Menu
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.toolStripMenuItem_open.Click += ToolStripMenuItem_open_Click;
            this.toolStripMenuItem_save.Click += ToolStripMenuItem_save_Click;
            this.toolStripMenuItem_close.Click += ToolStripMenuItem_close_Click;
        }

        private void ToolStripMenuItem_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
        }

        private void ToolStripMenuItem_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int red = rand.Next(256);  // 0 ~ 255
            int green = rand.Next(256);  // 0 ~ 255
            int blue = rand.Next(256);  // 0 ~ 255
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
