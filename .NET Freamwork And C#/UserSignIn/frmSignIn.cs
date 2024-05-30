using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSignIn
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void lbForgotPassword_MouseHover(object sender, EventArgs e)
        { 
           ((Label)sender).Font = new Font("Tahoma", 8, FontStyle.Underline);
        }
        private void lbForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font("Tahoma", 8);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtUserName_MouseHover(object sender, EventArgs e)
        {

            if (((TextBox)sender).Text != "Enter Your User Name")
            {
                return;
            }
            else
            {
                ((TextBox)sender).Text = "";
            }
        }
        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text != "Enter Your Password")
            {
                return;
            }
            else
            {
                ((TextBox)sender).Text = "";
         
            }
        }
        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace( ((TextBox)sender).Text))
            {
                ((TextBox)sender).Text = "Enter Your User Name";
         
                return;
            }
            else
            {
                return;
            }
        }
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
            
               ((TextBox)sender).Text = "Enter Your Password";
                
                return;
            }
            else
            {
                return;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != "Enter Your Password")
            txtPassword.PasswordChar = '*';
            else
                txtPassword.PasswordChar = '\0';
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text)|| string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("You Must Enter User Name And Password ...!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                clsUsers user= new clsUsers();
                if(user.Find(UserName:txtUserName.Text,password:txtPassword.Text) != null)
                {
                    Form frm = new frmProgram(txtUserName.Text);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("UserName Or Password is Uncorrected ...!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void lbCreateAccount_Click(object sender, EventArgs e)
        {
            Form frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmForgotPassword();
            frm.ShowDialog();
        }
    }
}
