using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_MoveEllipse_Timer
{
    public partial class Form1 : Form
    {
        private int x = 10, y = 10;
        private int diameter = 100;
        private Timer timer = new Timer();
        private int cnt = 0;
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.timer.Interval = 100;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.x += 10;

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            Rectangle rect = this.ClientRectangle;
            if (this.x < rect.Left) this.x += 10;
            if (this.y < rect.Top) this.y += 10;
            if (this.x + this.diameter > rect.Right) this.x -= 10;
            if (this.y + this.diameter > rect.Bottom) this.y -= 10;

            switch (key)
            {
                case Keys.Left:
                    //if (this.left < rect.X)
                    this.x -= 10;
                    break;
                case Keys.Right:
                    //if (this.left < rect.Width)
                    this.x += 10;
                    break;
                case Keys.Up:
                    //if (this.top > rect.Height)
                    this.y -= 10;
                    break;
                case Keys.Down:
                    //if (this.top < rect.Bottom)
                    this.y += 10;
                    break;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gold, 5);
            g.FillEllipse(Brushes.DarkBlue, this.x, this.y, this.diameter, this.diameter);
            g.DrawEllipse(pen, this.x, this.y, this.diameter, this.diameter);
        }
    }
}
