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
    public partial class frmCheckesListBox : Form
    {
        public frmCheckesListBox()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            for(int i=0;i<5;i++)
            {
                checkedListBox1.Items.Add("Item " + i);
            }
        }

        private void btnShowCheckedItems_Click(object sender, EventArgs e)
        {
            for(int i=0;i<checkedListBox1.CheckedItems.Count;i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString(), "Checked Items");
            }
        }

        private void btnCheckAllItems_Click(object sender, EventArgs e)
        {
            for(int i=0;i<checkedListBox1.Items.Count;i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnUncheckAllItems_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void btnRemoveThirdItem_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(2);
        }
    }
}
