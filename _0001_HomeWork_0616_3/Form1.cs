using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_HomeWork_0616_3
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;
        private int diameter = 40;
        private Timer timer = new Timer();
        private bool movement = false;
        private int count = 2;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.White;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;
            this.timer.Interval = 10;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            if (movement == true)
            {
                if (count == 1 && this.x > rect.Left)
                    this.x -= 10;
                else if (count == 2 && this.x < rect.Right - diameter)
                    this.x += 10;
                else if (count == 3 && this.y > rect.Top)
                    this.y -= 10;
                else if (count == 4 && this.y < rect.Bottom - diameter)
                    this.y += 10;
            }
            else if (movement == false)
            { this.x += 0; this.y += 0; }
            Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Enter:
                    if (movement == false)
                        this.movement = true;
                    else if (movement == true)
                        this.movement = false;
                    break;
                case Keys.Left:
                    count = 1;
                    break;
                case Keys.Right:
                    count = 2;
                    break;
                case Keys.Up:
                    count = 3;
                    break;
                case Keys.Down:
                    count = 4;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            Pen pen = new Pen(Color.Black, 1);
            g.DrawEllipse(pen, this.x, this.y, this.diameter, this.diameter);
        }
    }
}
