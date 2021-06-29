using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void InitTreeView()
        {
            TreeNodeCollection nodeCollection = treeView_Region.Nodes;
            TreeNode rootNode = nodeCollection.Add("대한민국");
            TreeNode seoulNode = nodeCollection.Add("서울특별시");
            TreeNode busanNode = nodeCollection.Add("부산");
            seoulNode.Nodes.Add("서초구");
            seoulNode.Nodes.Add("성북구");
            seoulNode.Nodes.Add("강북구");
            TreeNode jinguNode = busanNode.Nodes.Add("부산진구");
            busanNode.Nodes.Add("연제구");
            busanNode.Nodes.Add("사하구");
            busanNode.Nodes.Add("서면");
            jinguNode.Nodes.Add("범내골");
            jinguNode.Nodes.Add("전포동");
            jinguNode.Nodes.Add("BIFC 국제금융센터");
            jinguNode.Nodes.Add("아바니 호텔");
            jinguNode.Nodes.Add("WeWork");
        }
    }
}
