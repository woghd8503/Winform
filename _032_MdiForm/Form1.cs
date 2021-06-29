using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_MdiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 부모폼이 자식을 담는 컨테이너 역할 속성
            this.IsMdiContainer = true;

            this.newToolStripButton.Click += NewToolStripButton_Click;
            this.closeToolStripButton.Click += CloseToolStripButton_Click;
            this.계단식toolStripButton4.Click += 계단식toolStripButton4_Click;
            this.수직바둑판toolStripButton4.Click += 수직바둑판toolStripButton4_Click;
            this.수평바둑판toolStripButton3.Click += 수평바둑판toolStripButton3_Click;
        }



        private void 수평바둑판toolStripButton3_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 수직바둑판toolStripButton4_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 계단식toolStripButton4_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            childForm cf = new childForm();
            cf.MdiParent = this;
            cf.Show();
        }

        private void CloseToolStripButton_Click(object sender, EventArgs e)
        {
            // 현재 선택(활성화)된 자식 폼
            Form child = this.ActiveMdiChild;
            if (child != null)
                child.Close();
        }
    }
}
