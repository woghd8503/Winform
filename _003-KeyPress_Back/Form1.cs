using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_KeyPress_Back
{
    public partial class Form1 : Form
    {
        // 100개 이상이 되면 자동으로 공간 할당
        // 내부에 char배열공간이 생김
        private StringBuilder strInput = new StringBuilder(100);
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
            switch (ch)
            {
                case '\b':
                    //마지막 인덱스 위치에서 1글자를 지워라
                    if(strInput.Length > 0)
                    strInput.Remove(strInput.Length - 1, 1);
                    break;
                default:
                    strInput.Append(ch);
                    break;
            }

            Invalidate();    // Paint 이벤트 발생
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Enter값의 적용을 위해 출력방식을 교체
            // Enter값을 만나면 개행
            Graphics g = e.Graphics;            // 화면그릴 대상 객체
            Font f = new Font("맑은 고딕", 30);  // 폰트
            Rectangle rect = this.ClientRectangle; // 폼의 화면영역 사각형
            TextFormatFlags flags = TextFormatFlags.WordBreak; // Enter 개행
            String str = this.strInput.ToString();             // StringBuilder -> string
            TextRenderer.DrawText(g, str, Font, this.ClientRectangle, Color.Ivory, flags); 
        }
    }
}
