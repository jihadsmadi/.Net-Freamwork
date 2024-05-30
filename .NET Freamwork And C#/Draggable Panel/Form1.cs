using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draggable_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool MouseDown;
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown= false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseDown)
            {
                int FormX = MousePosition.X -400;
                int Formy = MousePosition.Y-20;

                this.SetDesktopLocation(FormX,Formy);

            }
        }
    }
}
