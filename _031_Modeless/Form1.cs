using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _031_Modeless
{
    public partial class Form1 : Form
    {
        ModelessForm childForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        //계속해서 여러 개의 창이 생성된다.
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    ModelessForm mlf = new ModelessForm();
        //    mlf.Show();
        //}

        // Modeless 방식으로 1개창만 띄우기
        private void button_Click(object sender, EventArgs e)
        {
            //객체가 생성되지 않거나
            //창의 리소스가 해제되었을 때 (창이 닫혔을 때)
            if(childForm == null || childForm.IsDisposed)
            {
                childForm = new ModelessForm();
                childForm.Show();
            }
        }
    }
}
