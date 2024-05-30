using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayningWinForm
{
    public partial class frmColorDailog : Form
    {
        public frmColorDailog()
        {
            InitializeComponent();
        }

        private void btnForColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtb.ForeColor = colorDialog1.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtb.BackColor = colorDialog1.Color;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor= true;
            fontDialog1.ShowEffects= true;

            fontDialog1.Font = txtb.Font;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtb.Font= fontDialog1.Font;
                txtb.ForeColor= fontDialog1.Color;
            }
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            txtb.Font = fontDialog1.Font;
            txtb.ForeColor = fontDialog1.Color;
        }

        private void btnFileDailog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.DefaultExt = "txt";

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt |All files (*.*)|*.*";


            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void btnOpenFileDailog_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void btnMultiOpenFileDailog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect= true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string FileName in openFileDialog1.FileNames)
                {
                    MessageBox.Show(FileName);
                }
               
            }
        }
    }
}
