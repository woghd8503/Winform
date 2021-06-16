using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_KeyPress_Char
{
    public partial class Form1 : Form
    {
        private string strInput;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            this.strInput += ch;

            Invalidate(); // 강제로 Paint이벤트 발생시킴
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Font f = new Font("맑은 고딕", 20);
            g.DrawString(this.strInput, f, Brushes.Ivory, 10, 10);
        }
    }
}
