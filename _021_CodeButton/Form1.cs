using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_CodeButton
{
    public partial class Form1 : Form
    {
        const int BTN_WIDTH = 100;  // 코드버튼의 너비
        const int BTN_HEIGHT = 100; // 코드버튼의 높이
        const int MARGIN_X = 100;   // 왼쪽 시작 위치
        const int MARGIN_Y = 100;   // 위 시작 위치
        int cnt = 0;                // 코드버튼에 이름 숫자
        Random rand = new Random(); // 난수 객체

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load; // 폼객체 생성 후 초기화 작업 시
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            makeButtons(MARGIN_X, MARGIN_Y, this.Width-MARGIN_X * 2, this.Height - MARGIN_Y *2);
        }
        /// <summary>
        /// 버튼들을 동적으로 생성한다
        /// </summary>
        /// <param name="offsetX">x축 시작위치</param>
        /// <param name="offsetY">y축 시작위치</param>
        /// <param name="areaWidth">생성해야 할 너비 범위</param>
        /// <param name="areaHeight">생성해야 할 높이 범위</param>

        private void makeButtons(int offsetX, int offsetY, int areaWidth, int areaHeight)
        {
            this.Controls.Clear(); // 기존의 폼의 자식 컨트롤 모두 제거

            int widthCnt = areaWidth / BTN_WIDTH;
            int heightCnt = areaHeight / BTN_HEIGHT;

            for(int i = 0; i < heightCnt; i++)
            {
                for(int j = 0; j < widthCnt; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); 
                    btn.Font = new Font("맑은 고딕", 20, FontStyle.Bold | FontStyle.Italic);
                    btn.Text = cnt.ToString();
                    btn.Name = "button_" + cnt;
                    btn.SetBounds(offsetX + j * BTN_WIDTH, offsetY + i * BTN_HEIGHT, BTN_WIDTH, BTN_HEIGHT);
                    btn.Click += Btn_Click; // 버튼에 이벤트 등록
                    this.Controls.Add(btn); // 폼에 추가한다
                    cnt++;
                }
            }
        }
        /// <summary>
        /// 폼의 자식으로 등록되는 버튼의 click이벤트를 모두 여기서 수진
        /// </summary>
        /// <param name="sender">이벤트 발생 버튼</param>
        /// <param name="e">부가정보</param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Console.WriteLine(btn.Name + " 클릭됨");

            //.NET의 클래스는 IDissposable인터페이스를 상속구현해서
            //필요가 없을 때는 Dispose()를 호출해서 리소스 메모리를
            //정리하도록 구현되어 있다.
                btn.Dispose();  // 버튼의 리소스 메모리 정리
        }
    }
}
