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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("You Should Enter User Name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUsers users= new clsUsers();
            if(users.FindWithoutPassword(txtUserName.Text) != null)
            {
                Form frm = new frmResetPassword(txtUserName.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(txtUserName.Text + " Is Not Exist, Try Another User Name ...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
