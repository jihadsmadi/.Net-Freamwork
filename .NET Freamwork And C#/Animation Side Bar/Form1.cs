using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Side_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool SideBarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand)
            {

                plSideBar.Width -= 10;

                if (plSideBar.Width == plSideBar.MinimumSize.Width)
                {

                    timer1.Stop();
                    SideBarExpand = false;
                }
            }
            else
            {
                plSideBar.Width += 10;

                if (plSideBar.Width == plSideBar.MaximumSize.Width)
                {

                    timer1.Stop();
                    SideBarExpand = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
