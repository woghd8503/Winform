using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_MouseSelectEllipse
{
    public partial class Form1 : Form
    {
        private int x = 50, y = 50;     // 원의 좌상단 좌표
        private int rad = 200;          // 원의 반지름
        private bool isSelect = false;  // 마우스 선택 여부

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // 마우스 왼쪽 버튼이 up되었느냐?
            if(e.Button == MouseButtons.Left)
            {
                isSelect = false;
                Invalidate();
            }
        }
        /// <summary>
        /// 1번째 조건 : 마우스 왼쪽 버튼이 눌렸는지 여부
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">마우스 클릭 좌표를 얻을 수 있음</param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // MouseDown 버튼이 왼쪽 버튼이니?
            if(e.Button == MouseButtons.Left)
            {
                // 클릭좌표를 얻는다
                Console.WriteLine("x:{0}, y:{1}", e.X, e.Y);

                if (InEllipse(rad + rad, y + rad, e.X, e.Y))
                    isSelect = true;
                else
                    isSelect = false;

                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gold, 10);
            g.DrawEllipse(pen, x, y, rad * 2, rad * 2);

            if(this.isSelect)
            {
                pen = new Pen(Color.AliceBlue, 10);
                g.DrawRectangle(pen, x, y, rad*2, rad*2);
            }
        }
        /// <summary>
        /// 두 점의 길이를 구하는 메서드
        /// </summary>
        /// <param name="x0">한 점의 x좌표</param>
        /// <param name="y0">한 점의 x좌표</param>
        /// <param name="x1">다른 점의 x좌표</param>
        /// <param name="y1">다른 점의 y좌표</param>
        /// <returns></returns>
        private double LenghtPts(int x0, int y0, int x1, int y1)
        {
            // a^2 + b^2 = 밑변제곱 + 높이제곱
            int len_Pow = (x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0);
            // 제곱근, 루트
            return Math.Sqrt(len_Pow);
        }
        /// <summary>
        /// 원 안에 좌표가 포함되는지 판별하는 메서드
        /// </summary>
        /// <param name="centerX">원의 중심</param>
        /// <param name="centerY">원의 중심</param>
        /// <param name="mouseX">마우스 클릭</param>
        /// <param name="mouseY">마우스 클릭</param>
        /// <returns></returns>
        private bool InEllipse(int centerX, int centerY, int mouseX, int mouseY)
        {
            double lenPts = LenghtPts(centerX, centerY, mouseX, mouseY);
            if((int)lenPts < rad)
                return true;
            else
                return false;
        }
    }
}
