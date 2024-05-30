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
    public partial class UC_Item : UserControl
    {
        public UC_Item()
        {
            InitializeComponent();
        }

        private Image UC_image
        {
            get { return UC_PB_image.Image; }
            set { UC_PB_image.Image = value;}
        }

        private string UC_ItemName
        {
            get { return UC_LB_Name.Text; }
            set { UC_LB_Name.Text = value; }
                
        }

        private string UC_ItemCount
        {
            get { return UC_LB_Count.Text; }
            set
            {
                UC_LB_Count.Text = value;

            }
        }

        private string UC_ItemPrice
        {
            get { return UC_LB_Price.Text; }
            set
            {
                UC_LB_Price.Text = value;
            }
        }

        bool IsCheck = false;
        private void UC_PB_image_Click(object sender, EventArgs e)
        {
            if(IsCheck)
            {
                UC_LB_Count.Text = "0";
                IsCheck = false;
                UC_Panel_Adding.Enabled = false;
            }
            else
            {
                UC_LB_Count.Text = "1";
                IsCheck = true ;
                UC_Panel_Adding.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UC_LB_Count.Text = (Convert.ToInt16(UC_LB_Count.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(UC_LB_Count.Text) == 1)
                return;

            UC_LB_Count.Text = (Convert.ToInt16(UC_LB_Count.Text) - 1).ToString();
        }
    }
}
