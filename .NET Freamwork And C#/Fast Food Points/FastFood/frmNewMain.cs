using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class frmNewMain : Form
    {
        bool SideBarExpand=true;
        public frmNewMain()
        {
            InitializeComponent();
        }

       

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if(SideBarExpand)
            {
                SideBar.Width -= 10;
                if(SideBar.Width == SideBar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if(SideBar.Width == SideBar.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void MuneButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
    }
}
