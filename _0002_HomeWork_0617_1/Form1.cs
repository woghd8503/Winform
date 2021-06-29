using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0002_HomeWork_0617_1
{
    public partial class Form1 : Form
    {
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        
        List<int> x1 = new List<int>();
        List<int> y1 = new List<int>();

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Black;
            Paint += Form1_Paint;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // cat
            {
                Console.WriteLine("오른쪽 x:{0}, y:{1}", e.X, e.Y);
                x.Add(e.X);
                y.Add(e.Y);
                Invalidate();
            }
            
            if (e.Button == MouseButtons.Left) // puppy
            {
                Console.WriteLine("왼쪽 x1:{0}, y1:{1}", e.X, e.Y);
                x1.Add(e.X);
                y1.Add(e.Y);
                Invalidate();
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image imageDog = Image.FromFile("../../../puppy.jpg");
            Image imageCat = Image.FromFile("../../../cat.jpg");

            for (int i = 0; i < x1.Count; i++)
            {
                
                e.Graphics.DrawImage(imageDog, x1[i], y1[i]);
            }

            for (int i = 0; i < x.Count; i++)
            {
                
                e.Graphics.DrawImage(imageCat, x[i], y[i]);
            }
        }
    }
}
