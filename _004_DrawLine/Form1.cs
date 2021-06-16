using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DrawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.Layout += Form1_Layout;
        }
        /// <summary>
        /// 폼의 창의 크기가 변할 때 발생하는 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate(); // 다시 그려라(Paint 이벤트 발생)
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            int left = rect.Left;      // 0
            int top = rect.Top;        // 0
            int right = rect.Right;
            int bottom = rect.Bottom;
            Pen pen = new Pen(Color.Gold, 10);

            g.DrawLine(pen, left, top, right, bottom);
        }
    }
}
