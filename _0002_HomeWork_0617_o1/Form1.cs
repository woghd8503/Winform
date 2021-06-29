using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0002_HomeWork_0617_o1
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        private int x = 400;
        private int y = 100;

        private int y1 = 0;

        private int num = 0;
        private int speed = 10;
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black;
            Paint += Form1_Paint;
            this.timer.Tick += Timer_Tick;
            timer.Interval = speed;
            timer.Start();
            Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            num++;
            Console.WriteLine(num);
            if (num == 5)
                num = 1;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image kettleImage = Image.FromFile("../../../ani.png");

            //e.Graphics.DrawImage(kettleImage, x, y);

            // 0, 200, 400, 600, 850
            switch (num)
            {
                case 1:
                    Rectangle rect = new Rectangle(0, y1, 200, 300);
                    e.Graphics.DrawImage(kettleImage, x, y, rect, GraphicsUnit.Pixel);
                    break;
                case 2:
                    rect = new Rectangle(200, y1, 200, 300);
                    e.Graphics.DrawImage(kettleImage, x, y, rect, GraphicsUnit.Pixel);
                    break;
                case 3:
                    rect = new Rectangle(400, y1, 200, 300);
                    e.Graphics.DrawImage(kettleImage, x, y, rect, GraphicsUnit.Pixel);
                    break;
                case 4:
                    rect = new Rectangle(600, y1, 200, 300);
                    e.Graphics.DrawImage(kettleImage, x, y, rect, GraphicsUnit.Pixel);
                    break;
                case 5:
                    rect = new Rectangle(800, y1, 200, 300);
                    e.Graphics.DrawImage(kettleImage, x, y, rect, GraphicsUnit.Pixel);
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                x -= 2;
            if (e.KeyCode == Keys.Right)
                x += 2;
            if (e.KeyCode == Keys.Up)
                speed += 100;
            Console.WriteLine("speed up" + speed);

            if (e.KeyCode == Keys.Down)
                speed -= 100;
            Console.WriteLine("speed down" + speed);

            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X - 50;
                y = e.Y - 100;
                Console.WriteLine("mouse down");
            }
            Invalidate();
        }
    }
}
