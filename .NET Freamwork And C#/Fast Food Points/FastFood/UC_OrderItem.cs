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
    public partial class UC_OrderItem : UserControl
    {
        public UC_OrderItem()
        {
            InitializeComponent();
        }

        public Image Image_Ordar
        {
            get { return Order_Item_image.Image; }
            set { Order_Item_image.Image  = value; }
        }
        public string QuantiteTag
        {
            get { return lb_Ordar_Quantite.Tag.ToString(); }
            set { lb_Ordar_Quantite.Tag = value; }
        }

        public string OrdarName
        {
            get { return Ordar_item_Name.Text; }
            set { Ordar_item_Name.Text = value; }
        }

        public float OrdarPrice
        {
            get { return Convert.ToSingle(this.Tag); }
            set { this.Tag = value; }

        }
        private void btnOrder_Add_Click(object sender, EventArgs e)
        {
            lb_Ordar_Quantite.Text =  (Convert.ToInt16(lb_Ordar_Quantite.Text)+1).ToString();

            lb_Ordar_Price.Text = (Convert.ToInt16(lb_Ordar_Quantite.Text) * Convert.ToInt16(lb_Ordar_Quantite.Tag)).ToString() + "$";
        }

        private void btn_Ordar_Minus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lb_Ordar_Quantite.Text) == 1)
                return;

            lb_Ordar_Quantite.Text = (Convert.ToInt16(lb_Ordar_Quantite.Text) - 1).ToString();
            lb_Ordar_Price.Text = (Convert.ToInt16(lb_Ordar_Quantite.Text) * Convert.ToInt16(lb_Ordar_Quantite.Tag)).ToString() + "$";
        }

        private void UC_OrderItem_Load(object sender, EventArgs e)
        {

        }
    }
    
}
