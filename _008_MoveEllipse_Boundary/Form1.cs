using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_MoveEllipse_Boundary
{
    public partial class Form1 : Form
    {
        private int left = 10, top = 10;
        private int diameter = 100;
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            Rectangle rect = this.ClientRectangle;
            if (this.left < rect.Left) this.left += 10;
            if (this.top < rect.Top) this.top += 10;
            if (this.left + this.diameter > rect.Right) this.left -= 10;
            if (this.top + this.diameter > rect.Bottom) this.top -= 10;

            switch (key)
            {
                case Keys.Left:
                    //if (this.left < rect.X)
                    this.left -= 10;
                    break;
                case Keys.Right:
                    //if (this.left < rect.Width)
                    this.left += 10;
                    break;
                case Keys.Up:
                    //if (this.top > rect.Height)
                    this.top -= 10;
                    break;
                case Keys.Down:
                    //if (this.top < rect.Bottom)
                    this.top += 10;
                    break;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gold, 5);
            g.FillEllipse(Brushes.DarkBlue, left, top, diameter, diameter);
            g.DrawEllipse(pen, left, top, diameter, diameter);
        }
    }
}
