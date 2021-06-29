using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0002_HomeWork_0617_m1
{
    public partial class Form1 : Form
    {
        private bool isActive = false;
        private int xCat, yCat;
        private int xMouse, yMouse;
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            BackColor = Color.White;
            this.timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isActive)
            {
                this.xMouse = e.X;
                this.yMouse = e.Y;
            }
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isActive = true;
                Console.WriteLine("mouse down");
            }
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isActive = false;
                Console.WriteLine("mouse up");
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
            Image ratImage = Image.FromFile($"../../../rat.jpg");
            Image catImage = Image.FromFile($"../../../cat.png");

            e.Graphics.DrawImage(catImage, xCat, yCat);

            if (this.isActive)
            {
                e.Graphics.DrawImage(ratImage, xMouse, yMouse);
                Console.WriteLine("출력",xMouse, yMouse);
            }
        }
    }
}
