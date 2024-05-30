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
    public partial class frmResetPassword : Form
    {
        string UserName;
        public frmResetPassword(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
            txtUserName.Text = UserName;
        }

        private void pbGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtPassword.Text.Length < 8) 
            { 
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password Should Be 8 Character Or More ...!");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Passwords Not The Same ...!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            clsUsers user = new clsUsers();
            user.UpdatePassword(txtUserName.Text,txtPassword.Text);

            MessageBox.Show("Password Reset Succesfully ..!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }


}
