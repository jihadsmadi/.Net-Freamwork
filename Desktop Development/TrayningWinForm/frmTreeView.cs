using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayningWinForm
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckAllChilds(e.Node, e.Node.Checked);
        }

        private void CheckAllChilds(TreeNode node,Boolean isChecked)
        {
            

            foreach(TreeNode child in node.Nodes)
            {
                child.Checked = isChecked;

                if (child.Nodes.Count > 0)
                {
                    this.CheckAllChilds(child, isChecked);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("", "New Girls", 1, 1);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.ToString());
        }
    }
}
