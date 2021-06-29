using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_CheckBox_RadioButton
{
    public partial class Form1 : Form
    {
        private string wish;
        private List<string> ownList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioPlay_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rd = (RadioButton)sender;
            RadioButton rb = sender as RadioButton;
            if(rb.Checked)
                this.wish = "평생 놀다 먹고 가는 사람";
        }

        private void radioBadWealth_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                this.wish = "엄첨 부자. 다만 나쁜 짓을 잘함";
        }

        private void radioOrdinary_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                this.wish = "평범한 소시민";
        }

        private void CheckGoodness_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (ownList.Count < 2)
                    ownList.Add("착한 성품");
                else
                {
                    MessageBox.Show("더 이상 추가할 수 없습니다");
                    cb.Checked = false;
                }
            }
            else
            {
                ownList.Remove("착한 성품");
            }
        }

        private void checKMoney_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (ownList.Count < 2)
                    ownList.Add("돈");
                else
                {
                    MessageBox.Show("더 이상 추가할 수 없습니다");
                    cb.Checked = false;
                }
            }
            else
            {
                ownList.Remove("돈");
            }
        }

        private void checkHandsome_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (ownList.Count < 2)
                    ownList.Add("외모");
                else
                {
                    MessageBox.Show("더 이상 추가할 수 없습니다");
                    cb.Checked = false;
                }
            }
            else
            {
                ownList.Remove("외모");
            }
        }

        private void checkPower_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (ownList.Count < 2)
                    ownList.Add("힘");
                else
                {
                    MessageBox.Show("더 이상 추가할 수 없습니다");
                    cb.Checked = false;
                }
            }
            else
            {
                ownList.Remove("힘");
            }
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            string choice = this.wish + "\r\n";
            //foreach (string str in ownList)
                foreach(var str in ownList)
                choice += str + "\r\n";

            MessageBox.Show(choice);
        }
    }
}
