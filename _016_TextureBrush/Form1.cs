using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_TextureBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 실행파일과 같은 위치에서 '서지혜.jpg'를 찾는다.
            // 현재 디렉토리
            /*Image imageSeo = Image.FromFile("서지혜.jpg");
            Image imageSeo = Image.FromFile("./서지혜.jpg");*/
            // 상위 디렉토리로 3단계 거슬러 올라가 찾는다.
            Image imageSeo = Image.FromFile("../../../서지혜.jpg");
            TextureBrush tb = new TextureBrush(imageSeo);
            e.Graphics.FillRectangle(tb, this.ClientRectangle);
        }
    }
}
