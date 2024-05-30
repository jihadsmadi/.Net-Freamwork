using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        char Operater = ' ';
        Double Result ;

        private void btnZero_Click(object sender, EventArgs e)
        {
          

            txtStore.Text += Convert.ToString((((Guna2Button)sender).Tag));
           

        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            
                txtStore.Text += Convert.ToString((((Guna2Button)sender).Tag));
               
               
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operater = Convert.ToChar(((Guna2Button)sender).Text);
            if(txtStore.Text != "")
            {
                Result = Convert.ToDouble(txtStore.Text);
                txtResult.Text = txtStore.Text + Operater;
                txtStore.Clear();
            }



        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double ans;
            switch(Operater)
            {
                case ('+'):
                    ans = Result + Convert.ToDouble(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
                case ('-'):
                    ans = Result - Convert.ToDouble(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
                case ('x'):
                    ans = Result * Convert.ToDouble(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
                case ('/'):
                    ans = Result / Convert.ToDouble(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
                case ('%'):
                    ans = Result % Convert.ToDouble(txtStore.Text);
                    txtResult.Text = txtResult.Text + txtStore.Text + " = " + ans;
                    txtStore.Text = ans.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStore.Clear();
            txtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private int GetIndexOperatFromText(string text)
        //{
        //    int index = text.IndexOfAny(new char[] { '+', '-', 'x', '/', '%' });

        //    if (index == -1)
        //        return text.Length;
        //    else
        //        return index;
        //}
        //private void CalculateResult()
        //{
        //    switch (Operater)
        //    {
        //        case ('+'):
        //            Result = Number1 + Number2;
        //            break;
        //        case ('-'):
        //            Result = Number1 - Number2;
        //            break;
        //        case ('x'):
        //            Result = Number1 * Number2;
        //            break;
        //        case ('/'):
        //            Result = Number1 / Number2;
        //            break;
        //        case ('%'):
        //            Result = Number1 % Number2;
        //            break;
        //        default:
        //            Result = Number1;
        //            break;
        //    }

        //    Number1 = Result;

        //}

        //private void CalculateEquals()
        //{

        //    if (text.Length == 1) return;

        //    int indexOfOperator = 0;



        //    indexOfOperator = GetIndexOperatFromText(text);


        //    if (indexOfOperator == 0)
        //    {
        //        Operater = Convert.ToChar(text.Substring(0, 1));
        //        text = text.Substring(1, (text.Length - (indexOfOperator + 1)));
        //        indexOfOperator = GetIndexOperatFromText(text);
        //        Number2 = Convert.ToDouble(text.Substring(0, indexOfOperator));
        //        CalculateResult();

        //        if (text.Length == 1)
        //        {
        //            text = " ";
        //            txtStore.Text = Result.ToString();
        //            return;
        //        }


        //    }
        //    else
        //        Number1 = Convert.ToDouble(text.Substring(0, indexOfOperator));


        //    if (indexOfOperator == text.Length)
        //    {

        //        CalculateResult();
        //        txtResult.Text = Result.ToString();
        //        txtStore.Text = Result.ToString();
        //        return;

        //    }
        //    else
        //    {
        //        Operater = Convert.ToChar(text.Substring(indexOfOperator, 1));
        //        text = text.Substring(indexOfOperator + 1, (text.Length - (indexOfOperator + 1)));
        //        indexOfOperator = GetIndexOperatFromText(text);
        //        Number2 = Convert.ToDouble(text.Substring(0, indexOfOperator));
        //        text = text.Substring(indexOfOperator, (text.Length - (indexOfOperator)));
        //    }



        //    CalculateResult();

        //    if (text.Length > 0)
        //    {
        //        CalculateEquals();
        //    }


        //    txtResult.Text = Result.ToString();
        //    txtStore.Text = Result.ToString();
        //    return;


        //}
        //private void btnFloat_Click(object sender, EventArgs e)
        //{
        //    if (IsThereDot == true)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        txtStore.Text += ".";
        //        IsThereDot = true;
        //    }

        //}
        //private void btnZero_Click(object sender, EventArgs e)
        //{
        //    txtStore.Text += ((Guna2Button)sender).Tag;
        //}
        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    txtResult.Text = "0";
        //    txtStore.Text = "";
        //    IsThereDot = false;
        //}
        //private void btnEquals_Click(object sender, EventArgs e)
        //{
        //    text = txtStore.Text;
        //    CalculateEquals();
        //}
        //private void btnModelo_Click(object sender, EventArgs e)
        //{
        //    txtStore.Text += ((Guna2Button)sender).Tag;
        //}




    }
}
