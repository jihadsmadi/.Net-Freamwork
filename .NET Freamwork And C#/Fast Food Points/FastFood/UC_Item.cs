using Guna.UI2.WinForms;
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
    public partial class UC_Item : UserControl
    {
        bool IsCheck = false;
        public bool IsItemChecked
        {
            get { return IsCheck; }
            set { IsCheck = value; }
        }
        public Image image_item
        {
            get { return ucImage.Image; }
            set { ucImage.Image = value; }
        }

        
        public string lbName
        {
            get { return lb_uc_Name.Text; }
            set { lb_uc_Name.Text = value; }
        }

        public string lbPrice
        {
            get { return lb_us_Price.Text; }
            set { lb_us_Price.Text = value; }
        }

        public string Quantite
        {
            get { return lb_Quantite.Text; }
            set { lb_Quantite.Text = value; }
        }

        public UC_Item()
        {
            InitializeComponent();
        }

        

        private void btnOrder_Add_Click(object sender, EventArgs e)
        {
            lb_Quantite.Text = (Convert.ToInt16(lb_Quantite.Text) + 1).ToString();

            
        }

        private void btn_Ordar_Minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lb_Quantite.Text) == 1)
                return;

            lb_Quantite.Text = (Convert.ToInt16(lb_Quantite.Text) - 1).ToString();
           
        }

        private void cb_uc_CheckedChanged(object sender, EventArgs e)
        {
            if(IsCheck)
            {
               
                panel2.Enabled = false;
                lb_Quantite.Text = "0";
                IsCheck = false;
            }
            else
            {
                panel2.Enabled = true;
                lb_Quantite.Text = "1";
                IsCheck = true;

               
                

            }
        }
    }
}
