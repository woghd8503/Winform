using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_DrawString
{
  
    public partial class Form1 : Form
    {
        private int cnt = 0;
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
        }
        /// <summary>
        /// 화면이 다시 그려질 때 호출되는 이벤트 핸들러(메서드)
        /// </summary>
        /// <param name="sender"></param>이벤트를 발생시킨 주체 (컨트롤)
        /// <param name="e">이벤트 처리에 필요한 부가정보</param>부가
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Paint 호출" + ++cnt);

            Graphics g = e.Graphics;
            g.DrawString("Hello World", Font, Brushes.Red, 10, 10);

            Font f = new Font("궁서", 70);
            g.DrawString("아름다운 대한민국", f, Brushes.Gold, 10, 100);
        }
    }
}
