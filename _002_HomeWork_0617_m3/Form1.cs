using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_HomeWork_0617_m3
{
    public partial class Form1 : Form
    {
        private const int WIDTH = 100;
        private const int HEIGHT = 100;

        private bool _color = true;
        private int x = 1, y = 1;
        private int rX = 1, rY = 1;
        private int cnt = 0;

        private List<int> eX = new List<int>();
        private List<int> eY = new List<int>();
        private List<bool> color = new List<bool>();
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Console.WriteLine("x:{0}, y:{1}", e.X, e.Y);
                rX = (e.X / 100) * 100;
                rY = (e.Y / 100) * 100;
 
                    Console.WriteLine("=======판단 전" + _color);
 
                        if (_color == true)
                        {
                            _color = false;

                        }
                        else if (_color == false)
                        {
                            _color = true;

                        }

                Console.WriteLine("=======판단 후" + _color);

                eX.Add(rX);
                eY.Add(rY);
                color.Add(_color);

                Invalidate();

                Console.WriteLine("Rx:{0}, Ry:{1}", rX, rY);
            }
        }

        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen bluePen = new Pen(Color.Blue, 2);
            Pen redPen = new Pen(Color.Red, 2);
            Pen pen = new Pen(Color.Black, 2);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    x = j * 100;
                    y = i * 100;
                    g.DrawRectangle(pen, x, y, WIDTH, HEIGHT);
                }
            }

            for (int i = 0; i < eX.Count; i++)
            {
                if (color[i] == true)
                    g.DrawEllipse(redPen, eX[i], eY[i], WIDTH, HEIGHT);
                else if(color[i] == false) g.DrawEllipse(bluePen, eX[i], eY[i], WIDTH, HEIGHT);
                Console.WriteLine($"{i}번 {color[i]}");
            }
        }
    }
}
