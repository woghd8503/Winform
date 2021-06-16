using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_HomeWork_0616
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            Layout += Form1_Layout;
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;

            int left = rect.Left;
            int top = rect.Top;
            int right = rect.Right;
            int bottom = rect.Bottom;
            Pen pen = new Pen(Color.Red, 10);
            g.DrawLine(pen, left, top, right, bottom);
            g.DrawLine(pen, right, top, left, bottom);
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }
    }
}
