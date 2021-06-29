using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0002_HomeWork_0617_3
{
    public partial class Form1 : Form
    {
        private int cnt = 0; 
        public Form1()
        {
            InitializeComponent();
            Paint += Form1_Paint;
            Layout += Form1_Layout;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image image = Image.FromFile($"../../../{cnt}.jpg");
            e.Graphics.DrawImage(image, this.ClientRectangle);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 9)
                cnt = 0;
            cnt++;
            Invalidate();
        }
    }
}
