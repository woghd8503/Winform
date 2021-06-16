using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_MoveEllipse
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
            switch(key)
            {
                case Keys.Left:
                    this.left -= 10;
                    break;
                case Keys.Right:
                    this.left += 10;
                    break;
                case Keys.Up:
                    this.top -= 10;
                    break;
                case Keys.Down:
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
