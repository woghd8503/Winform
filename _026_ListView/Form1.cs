using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_ListView
{
    public partial class Form1 : Form
    {
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == null || tbName.Text == "" || tbPhone.Text == null || tbPhone.Text == "")
            {
                MessageBox.Show("입력이 빠져있습니다~");
                return;
            }

            string[] addItems =
            {
                index.ToString(),tbName.Text,tbPhone.Text
            };

            listView_Person.Items.Add(new ListViewItem(addItems));
            index++;
        }

        private void listView_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            int idx = lv.FocusedItem.Index; // 어떤 행을 선택했는지
            string info = "";
            for (int i = 0; i < lv.Items[idx].SubItems.Count; i++)
            {
                info += lv.Items[idx].SubItems[i].Text + ", ";
            }
            this.Text = info; // 폼의 타이틀출력
            MessageBox.Show(info);
        }
    }
}
