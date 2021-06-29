using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_ListBox_ConboBox
{
    public partial class Form1 : Form
    {
        private string[] sentences =
        {
            "사랑합니다.",
            "존경합니다.",
            "감사합니다.",
            "행복합니다.",
            "즐겁습니다."
        };
        private string[] words =
        {
            "Happy",
            "Love",
            "Luck",
            "Pleasure",
            "Good"
        };
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initListBox();
            initComboBox();
        }

        private void btnComboToList_Click(object sender, EventArgs e)
        {
            string selStr = cb_Right.SelectedItem.ToString();
            lb_Left.Items.Add(selStr);
            cb_Right.Items.RemoveAt(cb_Right.SelectedIndex);
        }

        private void btnListToCombo_Click(object sender, EventArgs e)
        {
            string selStr = lb_Left.SelectedItem.ToString();
            cb_Right.Items.Add(selStr);
            lb_Left.Items.RemoveAt(lb_Left.SelectedIndex);
        }
        private void initListBox()
        {
            foreach (var str in sentences)
            {
                lb_Left.Items.Add(str);
            }
        }

        private void initComboBox()
        {
            foreach(var str in words)
            {
                cb_Right.Items.Add(str);
            }
        }

    }
}
