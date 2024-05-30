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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmCamboBox();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmTrayning();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmCheckesListBox();
            frm.Show();
        }

        private void btnDateTimePicker_Click(object sender, EventArgs e)
        {
            Form frm = new frmDateTimePicker();
            frm.Show();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form frm = new frmTimer();
            frm.Show();
        }

      
        private void btnNotifyIcon_Click(object sender, EventArgs e)
        {
            Form frm = new frmNotifyIcon();
            frm.Show();
        }

        private void btTreeView_Click(object sender, EventArgs e)
        {
            Form frm = new frmTreeView();
            frm.Show();
        }

        private void btnProgres_Click(object sender, EventArgs e)
        {
            Form frm = new frmProgresBar();
            frm.Show();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {

            Form frm = new frmListView();
            frm.Show();
        }

        private void btnErrorProvider_Click(object sender, EventArgs e)
        {
            Form frm = new frmErrorProvider();
            frm.Show();
        }

        private void btnTruckBar_Click(object sender, EventArgs e)
        {
            Form frm = new frmTrakBar();
            frm.Show();
        }

        private void btnColorDailog_Click(object sender, EventArgs e)
        {
            Form frm = new frmColorDailog();
            frm.Show();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Form frm = new frmRandom();
            frm.Show();
        }
    }
    
}
