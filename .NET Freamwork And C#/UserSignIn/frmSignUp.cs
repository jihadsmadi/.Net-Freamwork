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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {

                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "Enter User Name ...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }

            clsUsers User = new clsUsers();
            if(User.FindWithoutPassword(txtUserName.Text) != null)
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "User Name Is Exist, Enter Another Name ...!");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void cbSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSeePassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void cbSeeConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSeeConfirmPassword.Checked)
            {
                txtConfirmPassword.PasswordChar= '\0';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Not The Same Password ...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");

            }
        }

        private void pbGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if(!rbFemale.Checked && !rbMale.Checked)
            {
                MessageBox.Show("You Should Enter A Gender ....!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            clsUsers User = new clsUsers();

            User.SetUserName(txtUserName.Text);
            User.Password(txtPassword.Text);
            User.Email(txtEmail.Text);
            User.PhoneNumber(txtPhoneNumber.Text);

            if (rbFemale.Checked)
            {
                User.Gender(rbFemale.Tag.ToString());
            }
            else
                User.Gender(rbMale.Tag.ToString());

            User._WriteLineOnFile(User._CovertUserToLine());

            MessageBox.Show("User Added Successfully", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtPassword, "Enter A Password ...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");

            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtEmail, "Enter An Email ...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");

            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                e.Cancel = true;
                txtPhoneNumber.Focus();
                errorProvider1.SetError(txtPhoneNumber, "Enter Phone Number ...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhoneNumber, "");

            }
        }

        
    }
}
