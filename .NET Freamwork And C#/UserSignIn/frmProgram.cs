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
    public partial class frmProgram : Form
    {
        public string UserName;
        
        public frmProgram(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
            lbUserName.Text = UserName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
