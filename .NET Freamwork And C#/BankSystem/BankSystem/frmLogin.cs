using BankSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("You Should Enter Username And Password ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsUser user = new clsUser();   

            user = user.Find(tbUsername.Text,tbPassword.Text);

            if(user == null)
            {
                MessageBox.Show("Usrename Or Password is Uncorrect ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }

            this.Hide();
            user.RegisterLogin();
            Form frm = new frmBankSystem(frmBankSystem.enUserOrClient.user, tbUsername.Text);
            frm.Show();


        }

        private void lbClientLogin_Click(object sender, EventArgs e)
        {
            plLoginAsClient.Visible = true;
            pbLoginImage.Image = Resources.istockphoto_1397741475_612x612;
        }

        private void lbLoginAsUser_Click(object sender, EventArgs e)
        {
            plLoginAsClient.Visible = false;
            pbLoginImage.Image = Resources.Users1;
        }

        private void btnLoginAsClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccountNumber.Text) || string.IsNullOrWhiteSpace(tbPinCode.Text))
            {
                MessageBox.Show("You Should Enter Account Number And Pin Code ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsClients Client = new clsClients();

            Client = Client.Find(tbAccountNumber.Text, tbPinCode.Text);

            if (Client == null)
            {
                MessageBox.Show("Account Number Or Pin Code is Uncorrect ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; ;
            }

            this.Hide();
           
            Form frm = new frmBankSystem(frmBankSystem.enUserOrClient.client, tbAccountNumber.Text);
            frm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
