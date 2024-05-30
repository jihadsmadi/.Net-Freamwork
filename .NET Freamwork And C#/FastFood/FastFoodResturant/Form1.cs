using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodResturant
{
    public partial class Form1 : Form
    {
        bool SideBarExpand = true;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void pbMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {

            if (SideBarExpand)
            {

                plSideBar.Width -= 10;

                if (plSideBar.Width == plSideBar.MinimumSize.Width)
                {

                    sideBarTimer.Stop();
                    SideBarExpand = false;
                }
            }
            else
            {
                plSideBar.Width += 10;

                if (plSideBar.Width == plSideBar.MaximumSize.Width)
                {

                    sideBarTimer.Stop();
                    SideBarExpand = true;
                }
            }
        }

       

        private void cbBurger_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
