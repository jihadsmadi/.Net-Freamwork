using PictureProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        short Count = 0;
        enum Players { PlayerOne =1,PlayerTwo = 2,Draw=3};

        Players Turn = Players.PlayerOne;



        private bool HowWonTheGame(string player)
        {

            if (pb1.Tag == player)
            {
                if (pb2.Tag == player && pb3.Tag == player)
                {
                    pb1.BackColor = Color.Yellow;
                    pb2.BackColor = Color.Yellow;
                    pb3.BackColor = Color.Yellow;

                    return true;
                }

                if (pb4.Tag == player && pb7.Tag == player)
                {
                    pb1.BackColor = Color.Yellow;
                    pb4.BackColor = Color.Yellow;
                    pb7.BackColor = Color.Yellow;

                    return true;
                }


                if (pb5.Tag == player && pb9.Tag == player)
                {
                    pb1.BackColor = Color.Yellow;
                    pb5.BackColor = Color.Yellow;
                    pb9.BackColor = Color.Yellow;

                    return true;
                }


            } else if (pb2.Tag == player)
            {

                if (pb5.Tag == player && pb8.Tag == player)
                {
                    pb2.BackColor = Color.Yellow;
                    pb5.BackColor = Color.Yellow;
                    pb8.BackColor = Color.Yellow;

                    return true;
                }



            } else if (pb3.Tag == player)
            {
                if (pb5.Tag == player && pb7.Tag == player)
                {
                    pb3.BackColor = Color.Yellow;
                    pb5.BackColor = Color.Yellow;
                    pb7.BackColor = Color.Yellow;

                    return true;
                }


                if (pb6.Tag == player && pb9.Tag == player)
                {
                    pb3.BackColor = Color.Yellow;
                    pb6.BackColor = Color.Yellow;
                    pb9.BackColor = Color.Yellow;

                    return true;
                }
            } else if (pb4.Tag == player)
            {
                if (pb5.Tag == player && pb6.Tag == player)
                {
                    pb4.BackColor = Color.Yellow;
                    pb5.BackColor = Color.Yellow;
                    pb6.BackColor = Color.Yellow;

                    return true;
                }
            }
            else if (pb7.Tag == player)
            {
                if (pb8.Tag == player && pb9.Tag == player)
                {
                    pb7.BackColor = Color.Yellow;
                    pb8.BackColor = Color.Yellow;
                    pb9.BackColor = Color.Yellow;

                    return true;
                }
            }

            return false;

        }

        private void DoClick(PictureBox pic)
        {
            if (pic.Tag == "Player One" || pic.Tag == "Player Two")
            {
                MessageBox.Show("Wrong Choise", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Count++;

            if(Turn == Players.PlayerOne)
            {
                

                pic.Tag = "Player One";
                pic.Image = Resources.X;

                if(HowWonTheGame(pic.Tag.ToString()))
                {
                    LbWinnerResult.Text = pic.Tag.ToString();
                    MessageBox.Show("Congratulation Player One Won The Game ....!","Winner",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }else
            {
                pic.Tag = "Player Two";
                pic.Image = Resources.O;

                if (HowWonTheGame(pic.Tag.ToString()))
                {
                    LbWinnerResult.Text = pic.Tag.ToString();
                    MessageBox.Show("Congratulation Player Two Won The Game ....!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if(Count == 9)
            {
                LbWinnerResult.Text = "Draw";
                MessageBox.Show("Draw  ,Good Luck For All Of You ", "Drawing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if(Turn == Players.PlayerOne ) 
            {
                Turn = Players.PlayerTwo;
                LbTurnResult.Text = "Player Two";
            }
            else
            {
                Turn = Players.PlayerOne;
                LbTurnResult.Text = "Player One";
            }
        }

        private void RestartTheGame()
        {
            Count = 0;

            pb1.Image = Resources.qustionTwo;
            pb1.BackColor = Color.DarkGray;
            pb1.Tag = "";

            pb2.Image = Resources.qustionTwo;
            pb2.BackColor = Color.DarkGray;
            pb2.Tag = "";

            pb3.Image = Resources.qustionTwo;
            pb3.BackColor = Color.DarkGray;
            pb3.Tag = "";

            pb4.Image = Resources.qustionTwo;
            pb4.BackColor = Color.DarkGray;
            pb4.Tag = "";

            pb5.Image = Resources.qustionTwo;
            pb5.BackColor = Color.DarkGray;
            pb5.Tag = "";

            pb6.Image = Resources.qustionTwo;
            pb6.BackColor = Color.DarkGray;
            pb6.Tag = "";

            pb7.Image = Resources.qustionTwo;
            pb7.BackColor = Color.DarkGray;
            pb7.Tag = "";

            pb8.Image = Resources.qustionTwo;
            pb8.BackColor = Color.DarkGray;
            pb8.Tag = "";

            pb9.Image = Resources.qustionTwo;
            pb9.BackColor = Color.DarkGray;
            pb9.Tag = "";

          

            Turn = Players.PlayerOne;
            LbTurn.Text = "Player One";
            LbWinnerResult.Text = "";
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


           
            e.Graphics.DrawLine(Pen, 450, 100, 450, 490);
            e.Graphics.DrawLine(Pen, 650, 100, 650, 490);

            e.Graphics.DrawLine(Pen, 300, 230, 800, 230);
            e.Graphics.DrawLine(Pen, 300, 370, 800, 370);



        }

        private void pb_Click(object sender, EventArgs e)
        {
            DoClick((PictureBox)sender);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            RestartTheGame();
        }
    }
}
