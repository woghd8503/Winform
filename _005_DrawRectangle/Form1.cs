using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_DrawRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.Layout += Form1_Layout;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-20, -20); // 너비, 높이를 20씩 줄인다
            Pen pen = new Pen(Color.Red, 30);
            g.DrawRectangle(pen, rect);

            rect.Inflate(-50, -50);
            g.FillRectangle(Brushes.Purple, rect);
        }
    }
}
