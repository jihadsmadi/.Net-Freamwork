using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrayningWinForm
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
           

            for(int i=0;i<10;i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());

               
                item.SubItems.Add("Person " + i.ToString());
                
                if(i %2 == 0)
                
                    item.ImageIndex = 0;
                else 
                    item.ImageIndex = 1;

                listView1.Items.Add(item);
            }
        }

        private void rbDeatils_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTail_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;


            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if (rbMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;


            item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text.ToString());
        }
    }
}
