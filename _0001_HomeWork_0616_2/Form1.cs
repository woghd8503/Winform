using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_HomeWork_0616_2
{
    public partial class Form1 : Form
    {
        private int x = 500, y = 0;
        private int diameter = 60;
        private Timer timer = new Timer();
        private bool direc = true;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.timer.Interval = 10;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
            this.Layout += Form1_Layout;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Rectangle rect = this.ClientRectangle;


            if (this.y == rect.Bottom - diameter)
                direc = false;
            if (this.y == rect.Top)
                direc = true;

            if (direc == true)
                this.y += 10;
            if (direc == false)
                this.y -= 10;

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
