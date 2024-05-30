using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProjectWinForms
{
    

    public partial class PizzaForm : Form
    {

       


        public int Price = 0;

        private int SizePrice = 0;
        private int CrustPrice = 0;
        private int ToppingsPrice = 0;
        private int WhereToEatPrice = 0;

        private void CalculatePizzaPrice()
        {
            Price = SizePrice + CrustPrice + ToppingsPrice + WhereToEatPrice;        
        }

        void UpdateOrderLablePrice()
        {
            LbTotalPriceResult.Text = Convert.ToString(Price) + "$";
        }

        void UpdateSizePrice()
        {
            

            if (rbSmall.Checked)
                SizePrice = 15;
            else if (rbMeduim.Checked)
                SizePrice = 20;
            else if(rbLarge.Checked)
                SizePrice= 30;

            CalculatePizzaPrice();

            UpdateOrderLablePrice();

        }

        void UpdateCrustPrice()
        {

            if (rbThin.Checked)
                CrustPrice = 10;
            else if(rbThick.Checked)
                CrustPrice = 20;


            CalculatePizzaPrice();

            UpdateOrderLablePrice();

        }

        void UpdateToppingsPrice()
        {
            int value = 0;

            if (cbExtraChees.Checked)
                value += 5;

            if (cbOnion.Checked)
                value += 5;

            if (cbMushrooms.Checked)
                value += 5;

            if (cbOlives.Checked)
                value += 5;

            if (cbTomatoes.Checked)
                value += 5;

            if (cbGreenPeppers.Checked)
                value += 5;


            ToppingsPrice = value;

            CalculatePizzaPrice();

            UpdateOrderLablePrice();

        }

        void UpdateToppingsLableResult()
        {
            string result = "";

            if (cbExtraChees.Checked)
                result += "Extra Chees, ";

            if (cbOnion.Checked)
                result += "Onion, \n";

            if (cbMushrooms.Checked)
                result += "Mushrooms, ";

            if (cbOlives.Checked)
                result += "Olives, \n";

            if (cbTomatoes.Checked)
                result += "Tomatoes, ";

            if (cbGreenPeppers.Checked)
                result += "Green Peppers, ";

            LbToppingsResult.Text = result;
        }

        public PizzaForm()
        {
            InitializeComponent();
        }

        //Size
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            
            lbbSizeResult.Text = rbSmall.Text;

            UpdateSizePrice();

        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lbbSizeResult.Text = rbMeduim.Text;
            UpdateSizePrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lbbSizeResult.Text = rbLarge.Text;
            UpdateSizePrice();
        }

        //Crust
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            LbCrustTypeResult.Text = rbThin.Text;

            UpdateCrustPrice();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {

            LbCrustTypeResult.Text = rbThick.Text;

            UpdateCrustPrice();
        }

        //Toppings


        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppingsPrice();
            UpdateToppingsLableResult();
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsPrice();
            UpdateToppingsLableResult();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsPrice();
            UpdateToppingsLableResult();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsPrice();
            UpdateToppingsLableResult();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsPrice();
            UpdateToppingsLableResult();
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsPrice();
            UpdateToppingsLableResult();
        }



        //WhereToEat
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            LbWherToEatResult.Text = "Eat In";
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            LbWherToEatResult.Text = "Eat Out";
        }


        //Button
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {



            gbOrder.Enabled= false;
            btnOrderPizza.Enabled= false;


            MessageBox.Show("Your Pizza Request sent, it will take 10 Min ..!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
            rbMeduim.Checked = false;
            rbLarge.Checked = false;

            SizePrice = 0;


            rbThin.Checked = false;
            rbThick.Checked = false;

            CrustPrice = 0;

            cbExtraChees.Checked = false;
            cbOnion.Checked = false;
            cbOlives.Checked = false;
            cbMushrooms.Checked = false;
            cbTomatoes.Checked = false;
            cbGreenPeppers.Checked = false;

            ToppingsPrice = 0;


            rbEatIn.Checked = false;
            rbEatOut.Checked = false;

            WhereToEatPrice = 0;


            lbbSizeResult.Text = "";
            LbToppingsResult.Text = "";
            LbCrustTypeResult.Text = "";
            LbWherToEatResult.Text = "";

            UpdateOrderLablePrice();
            gbOrder.Enabled = true;
            btnOrderPizza.Enabled = true;
           


        }


    }
}
