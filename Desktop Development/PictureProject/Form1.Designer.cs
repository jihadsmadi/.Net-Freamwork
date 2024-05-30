namespace PictureProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbGame = new System.Windows.Forms.Label();
            this.LbTurn = new System.Windows.Forms.Label();
            this.LbTurnResult = new System.Windows.Forms.Label();
            this.LbWinner = new System.Windows.Forms.Label();
            this.LbWinnerResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbGame
            // 
            this.LbGame.AutoSize = true;
            this.LbGame.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGame.ForeColor = System.Drawing.Color.White;
            this.LbGame.Location = new System.Drawing.Point(619, 28);
            this.LbGame.Name = "LbGame";
            this.LbGame.Size = new System.Drawing.Size(407, 55);
            this.LbGame.TabIndex = 0;
            this.LbGame.Text = "Tec-Tac-Toe Game";
            // 
            // LbTurn
            // 
            this.LbTurn.AutoSize = true;
            this.LbTurn.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTurn.ForeColor = System.Drawing.Color.Yellow;
            this.LbTurn.Location = new System.Drawing.Point(76, 89);
            this.LbTurn.Name = "LbTurn";
            this.LbTurn.Size = new System.Drawing.Size(125, 53);
            this.LbTurn.TabIndex = 2;
            this.LbTurn.Text = "Turn";
            // 
            // LbTurnResult
            // 
            this.LbTurnResult.AutoSize = true;
            this.LbTurnResult.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTurnResult.ForeColor = System.Drawing.Color.White;
            this.LbTurnResult.Location = new System.Drawing.Point(77, 151);
            this.LbTurnResult.Name = "LbTurnResult";
            this.LbTurnResult.Size = new System.Drawing.Size(217, 43);
            this.LbTurnResult.TabIndex = 3;
            this.LbTurnResult.Text = "Player One";
            // 
            // LbWinner
            // 
            this.LbWinner.AutoSize = true;
            this.LbWinner.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWinner.ForeColor = System.Drawing.Color.Yellow;
            this.LbWinner.Location = new System.Drawing.Point(76, 214);
            this.LbWinner.Name = "LbWinner";
            this.LbWinner.Size = new System.Drawing.Size(182, 53);
            this.LbWinner.TabIndex = 4;
            this.LbWinner.Text = "Winner";
            // 
            // LbWinnerResult
            // 
            this.LbWinnerResult.AutoSize = true;
            this.LbWinnerResult.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWinnerResult.ForeColor = System.Drawing.Color.Lime;
            this.LbWinnerResult.Location = new System.Drawing.Point(77, 282);
            this.LbWinnerResult.Name = "LbWinnerResult";
            this.LbWinnerResult.Size = new System.Drawing.Size(171, 48);
            this.LbWinnerResult.TabIndex = 5;
            this.LbWinnerResult.Text = "Player2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(85, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb9
            // 
            this.pb9.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb9.Location = new System.Drawing.Point(1006, 578);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(191, 141);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 15;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb8.Location = new System.Drawing.Point(724, 578);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(191, 141);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 14;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb7.Location = new System.Drawing.Point(464, 578);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(191, 141);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 13;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb4.Location = new System.Drawing.Point(464, 367);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(191, 141);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 12;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb5.Location = new System.Drawing.Point(736, 367);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(191, 141);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 11;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb6.Location = new System.Drawing.Point(1015, 367);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(191, 141);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 10;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.DarkGray;
            this.pb2.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb2.Location = new System.Drawing.Point(736, 126);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(191, 141);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 9;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb3.Location = new System.Drawing.Point(1006, 126);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(191, 141);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 8;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::PictureProject.Properties.Resources.qustionTwo;
            this.pb1.Location = new System.Drawing.Point(464, 126);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(191, 141);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1796, 768);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbWinnerResult);
            this.Controls.Add(this.LbWinner);
            this.Controls.Add(this.LbTurnResult);
            this.Controls.Add(this.LbTurn);
            this.Controls.Add(this.LbGame);
            this.Name = "Form1";
            this.Text = "Tec-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbGame;
        private System.Windows.Forms.Label LbTurn;
        private System.Windows.Forms.Label LbTurnResult;
        private System.Windows.Forms.Label LbWinner;
        private System.Windows.Forms.Label LbWinnerResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb1;
    }
}

