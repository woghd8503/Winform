using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_HomeWork_0616_5
{
    public partial class Form1 : Form
    {
        private int x = 1, y = 1;
        private int diameter = 60;
        private int xDir = 10;
        private int yDir = 10;

        private Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black;
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
            Paint += Form1_Paint;
            Layout += Form1_Layout;
        }
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            this.x += xDir;
            this.y += yDir;

            if (this.x > rect.Right - diameter)
                xDir *= -1;
            if (this.x < rect.Left)
                xDir *= -1;

            if (this.y > rect.Bottom - diameter)
                yDir *= -1;
            if (this.y < rect.Top)
                yDir *= -1;

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 1);
            g.FillEllipse(Brushes.Red, x, y, diameter, diameter);
        }
    }
}
