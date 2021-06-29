using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _30_MdiForm
{
    public partial class childForm : Form
    {
        Random rand = new Random();
        public childForm()
        {
            InitializeComponent();
        }
        private void childForm_Load(object sender, EventArgs e)
        {
            double rNum = rand.NextDouble();
            this.Opacity = 0.5D + (rNum / 2); // 0.5 ~ 1.0
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
