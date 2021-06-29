using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _035_MemoText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string text = tb_Memo.Text;
            StreamWriter sw = new StreamWriter("memo.txt");
            sw.Write(text);
            sw.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            char[] buf = new char[1024];
            StreamReader sr = new StreamReader("memo.txt");
            tb_Memo.Text = "";
            while(true)
            {
                // buf 배열의 0부터 채우되, buf.Length 깅이만큼
                // 읽어서 저장해라
                // 읽어야 할 크기가 작을 수 있으므로
                // 실제 읽은 크기가 ret로 반환한다.

                int ret = sr.Read(buf, 0, buf.Length);
                tb_Memo.Text += new string(buf, 0, ret);
                // 더 읽을 것이 없으므로 탈출
                if (ret < buf.Length)
                    break;
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            tb_Memo.Text = "";
        }
    }
}
