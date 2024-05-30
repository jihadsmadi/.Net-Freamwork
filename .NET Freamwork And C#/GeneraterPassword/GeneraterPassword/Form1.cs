using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneraterPassword
{
    public partial class frmPasswordGenerator : Form
    {
        public frmPasswordGenerator()
        {
            InitializeComponent();
        }

       
        private int From=0, To;

        private void GetTypeOfPassword()
        {
            if(rbNumbers.Checked )
            {
                From = 49;
                To = 57;
                return;
            }

            if(rbSmallLetters.Checked )
            {
                From = 97;
                To = 122;
                return;
            }

            if(rbCapitalLetters.Checked )
            {
                From = 65;
                To = 90;
                return;
            }

            if(rbSymbols.Checked )
            {
                From = 33;
                To = 47;
                return;
            }

            if(rbMix.Checked)
            {
                From = 33;
                To = 122;
                return;
            }

        }
        private void GeneratePassword(short Length)
        {
            Random Rnd = new Random();

            string Result = "";
          
            for(int i=0;i<Length;i++)
            {
                Result += Convert.ToChar(Rnd.Next(From, To));
            }
           
           
            txtPassword.Text = Result;


        }
        private void rbSmallLetters_CheckedChanged(object sender, EventArgs e)
        {
            GetTypeOfPassword();
            DoTheWork();
        }
        private void DoTheWork()
        {
            if (From == 0)
                return;

            lbLengthNumber.Text = trackBar1.Value.ToString();
            GeneratePassword(Convert.ToByte(trackBar1.Value));
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);

            MessageBox.Show("Password Copied .. ");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DoTheWork();
        }
       
        
    }
}
