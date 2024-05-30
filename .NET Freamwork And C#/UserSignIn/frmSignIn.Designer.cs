namespace UserSignIn
{
    partial class frmSignIn
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lbCreateAccount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlBottom.Controls.Add(this.lbCreateAccount);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 465);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(447, 63);
            this.pnlBottom.TabIndex = 0;
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.lbCreateAccount.Location = new System.Drawing.Point(228, 16);
            this.lbCreateAccount.Name = "lbCreateAccount";
            this.lbCreateAccount.Size = new System.Drawing.Size(135, 19);
            this.lbCreateAccount.TabIndex = 1;
            this.lbCreateAccount.Text = "Create an account";
            this.lbCreateAccount.Click += new System.EventHandler(this.lbCreateAccount_Click);
            this.lbCreateAccount.MouseLeave += new System.EventHandler(this.lbForgotPassword_MouseLeave);
            this.lbCreateAccount.MouseHover += new System.EventHandler(this.lbForgotPassword_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Not a member?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(64, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 46);
            this.panel1.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUserName.Location = new System.Drawing.Point(17, 8);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(299, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Text = "Enter Your User Name";
            this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
            this.txtUserName.MouseHover += new System.EventHandler(this.txtUserName_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign In";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(64, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 46);
            this.panel2.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(17, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(299, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Enter Your Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Location = new System.Drawing.Point(64, 297);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(319, 46);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.lbForgotPassword.Location = new System.Drawing.Point(243, 358);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(140, 19);
            this.lbForgotPassword.TabIndex = 7;
            this.lbForgotPassword.Text = "Forgot Password ?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            this.lbForgotPassword.MouseLeave += new System.EventHandler(this.lbForgotPassword_MouseLeave);
            this.lbForgotPassword.MouseHover += new System.EventHandler(this.lbForgotPassword_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserSignIn.Properties.Resources.logout_icon_png_20;
            this.pictureBox2.Location = new System.Drawing.Point(409, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::UserSignIn.Properties.Resources.person_icon_blue_18;
            this.pictureBox1.Location = new System.Drawing.Point(186, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 528);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbCreateAccount;
        private System.Windows.Forms.Label label2;
    }
}

