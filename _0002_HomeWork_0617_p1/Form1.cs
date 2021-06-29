using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0002_HomeWork_0617_p1
{
    public partial class Form1 : Form
    {
        private int x = 1;
        private int y = 1;
        private int[,] map = new int[40, 40];
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            BackColor = Color.Black;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen map = new Pen(Color.Black, 2);
            Pen mapLine = new Pen(Color.White, 2);

            for(int i = 0; i < 30; i++)
            {
                for(int j = 0; j < 30; j++)
                {
                    x = i * 20;
                    y = j * 20;

                    if (i == 0 || j == 0 || i == 29 || j == 29)
                    {

                        g.DrawRectangle(mapLine, x, y, 100, 100);
                    }
                    else
                    {
                        g.DrawRectangle(map, x, y, 100, 100);

                    }
                }
            }
        }
    }
}
