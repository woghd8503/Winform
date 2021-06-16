using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001_HomeWork_0616_4
{
    public partial class Form1 : Form
    {
        private Timer timer = new Timer();
        private bool left = false;
        private bool right = false;
        private bool up = false;
        private bool down = false;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.Paint += Form1_Paint;
            this.Layout += Form1_Layout;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Right:
                    Console.WriteLine("right");
                    right = false;
                    break;
                case Keys.Left:
                    Console.WriteLine("left");
                    left = false;
                    break;
                case Keys.Up:
                    Console.WriteLine("up");
                    up = false;
                    break;
                case Keys.Down:
                    Console.WriteLine("down");
                    down = false;
                    break;
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
           {  
                case Keys.Right:
                    Console.WriteLine("right");
                    right = true;
                    break;
                case Keys.Left:
                    Console.WriteLine("left");
                    left = true;
                    break;
                case Keys.Up:
                    Console.WriteLine("up");
                    up = true;
                    break;
                case Keys.Down:
                    Console.WriteLine("down");
                    down = true;
                    break;
            }
            Invalidate();
        }
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle();
            Pen pen = new Pen(Color.Black, 2);

            rect.Inflate(-20, -20);
            g.DrawRectangle(pen, 90, 10, 70, 100);  // 위쪽
            g.DrawRectangle(pen, 90, 210, 70, 100); // 아래쪽

            g.DrawRectangle(pen, 20, 110, 70, 100); // 왼쪽
            g.DrawRectangle(pen, 160, 110, 70, 100);// 오른쪽

            if (up == true)
                g.FillRectangle(Brushes.Red, 90, 10, 70, 100);
            if (down == true)
                g.FillRectangle(Brushes.Red, 90, 210, 70, 100);
            if (left == true)
                g.FillRectangle(Brushes.Red, 20, 110, 70, 100);
            if (right == true)
                g.FillRectangle(Brushes.Red, 160, 110, 70, 100);

            Font f = new Font("궁서", 15);
            g.DrawString("위쪽", f, Brushes.Black, 100, 30);
            g.DrawString("아래쪽", f, Brushes.Black, 90, 230);
            g.DrawString("왼쪽", f, Brushes.Black, 30, 130);
            g.DrawString("오른쪽", f, Brushes.Black, 160, 130);
        }
    }
}
