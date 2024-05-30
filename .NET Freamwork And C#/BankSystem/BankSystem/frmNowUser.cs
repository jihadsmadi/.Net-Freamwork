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
    public partial class frmNowUser : Form
    {
        clsUser user = new clsUser();
        public frmNowUser(string nowUsername)
        {
            InitializeComponent();
            user = user.FindWithoutPassword(nowUsername);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNowUser_Load(object sender, EventArgs e)
        {

            tbUsername.Text = user.UserName;
            tbPassword.Text = user.Password;
            tbPermission.Text = user.Permissions.ToString();


            lvNowUser.Items.Clear();

            lvNowUser.Items.Add(user.Id);
            lvNowUser.Items[0].SubItems.Add(user.FirstName + " " + user.LastName);
            lvNowUser.Items[0].SubItems.Add(user.FatheName);
            lvNowUser.Items[0].SubItems.Add(user.MotherName);
            lvNowUser.Items[0].SubItems.Add(user.Email);
            lvNowUser.Items[0].SubItems.Add(user.Phone);
            lvNowUser.Items[0].SubItems.Add(user.Address);
            lvNowUser.Items[0].SubItems.Add(user.DateOfBirth.ToShortDateString());
        }
    }
}
