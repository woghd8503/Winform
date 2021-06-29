using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = tb_text.Text;
            lb_text.Items.Add(text);
            tb_text.Text = null; // " ";
        }

        private void tb_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 윈폼에서 Enter를 치면 "\r\n"가 입력된다.
            switch(e.KeyChar)
            {
                case '\r':
                    string text = tb_text.Text;
                    lb_text.Items.Add(text);
                    tb_text.Text = null; // " ";
                    break;
            }
        }

        private void lb_text_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;   // lb_text
            lb.Items.Remove(lb.SelectedItem); // 선택항목 지우기
        }
    }
}
