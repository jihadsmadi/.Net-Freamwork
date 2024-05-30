using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrayningWinForm.Properties;

namespace TrayningWinForm
{
    public partial class frmCamboBox : Form
    {
        public frmCamboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = comboBox1.SelectedItem.ToString();
            LBName.Text = x;
            switch(x)
            {
                case ("Boy"):
                    pbImage.Image = Resources.Boy;
                    break;
                case ("Girl"):
                    pbImage.Image = Resources.Girl;
                    break;
                case ("Pen"):
                     pbImage.Image = Resources.Pen;
                    break;
                case ("Book"):
                    pbImage.Image = Resources.Book;
                    break;
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}