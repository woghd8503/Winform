using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_DrawImage
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
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image imageIU = Image.FromFile("../../../IU.jpg");
            //1) 원점을 기준으로 아이유 이미지 크기대로 출력
            //e.Graphics.DrawImage(imageIU, 0, 0);

            //2) 화면 전체에 출력하기
            //e.Graphics.DrawImage(imageIU, this.ClientRectangle);

            //3) 특정 위치에 특정크기만큼 오려서 출력
            // Form의 100, 100위치에 출력 시작
            // 아이유 이미지에서 170, 80에서 시작해서
            // 너비는 510-170, 높이는 420-80만큼 출력
            Rectangle rect = new Rectangle(180, 60, 600, 600);
            e.Graphics.DrawImage(imageIU, 300, 200, rect, GraphicsUnit.Pixel);
        }
    }
}
