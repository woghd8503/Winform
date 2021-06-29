using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0003_HomeWork_0617_2
{
    public partial class Form1 : Form
    {
        private int x = 20, y = 15;
        private int diameter = 100;
        private int interval = 110;
        private Timer timer = new Timer();
        private int cnt = 0;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.Paint += Form1_Paint;
            this.timer.Interval = 1000;
            this.timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            cnt = rand.Next(3);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Black, x -10, y -10, 125, 350);

            if (cnt == 0)
            g.FillEllipse(Brushes.Red, this.x, this.y, this.diameter, this.diameter);
            if (cnt == 1)
            g.FillEllipse(Brushes.Yellow, this.x, this.y + this.interval, this.diameter, this.diameter);
            if (cnt == 2)
            g.FillEllipse(Brushes.Green, this.x, this.y + (this.interval * 2), this.diameter, this.diameter);

            Pen pen = new Pen(Color.White, 3);
            g.DrawEllipse(pen, this.x, this.y, this.diameter, this.diameter);
            g.DrawEllipse(pen, this.x, this.y + this.interval, this.diameter, this.diameter);
            g.DrawEllipse(pen, this.x, this.y + (this.interval * 2), this.diameter, this.diameter);
        }
    }
}
