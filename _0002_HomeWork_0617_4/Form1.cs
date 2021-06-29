using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0002_HomeWork_0617_4
{
    public partial class Form1 : Form
    {
        private bool isActive = false;
        private int xCat, yCat;
        private int xMouse, yMouse;
        Timer timer = new Timer();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isActive = true;
            }
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            BackColor = Color.White;
            this.timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isActive = false;
            }
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.isActive)
            {
                this.xMouse = e.X;
                this.yMouse = e.Y;
            }
            Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                if (xCat != xMouse)
                {
                    if (xCat <= xMouse)
                        xCat += 20;
                    else if (xCat >= xMouse)
                        xCat -= 20;
                }
                if (yCat != yMouse)
                {
                    if (yCat <= yMouse)
                        yCat += 20;
                    else if (yCat >= yMouse)
                        yCat -= 20;
                }
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("고딕", 13);

            g.DrawString("고양이", f, Brushes.Black, xCat, yCat);
            Console.WriteLine("xCat :{0}, yCat: {1}", xCat, yCat);

            if (this.isActive)
            {
                g.DrawString("쥐", f, Brushes.Black, xMouse, yMouse);
                Console.WriteLine("working xMouse :{0}, yMouse: {1}", xMouse, yMouse);
            }
        }
    }
}
