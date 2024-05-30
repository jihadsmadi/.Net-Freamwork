namespace UserSignIn
{
    partial class frmSignUp
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbSeePassword = new System.Windows.Forms.CheckBox();
            this.cbSeeConfirmPassword = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pbGoBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 86);
            this.panel1.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(207, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(229, 31);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(207, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(229, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(207, 195);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(229, 31);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 31);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(207, 378);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(79, 28);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "Male";
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(339, 378);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(97, 28);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Tag = "Female";
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "confirm password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(207, 305);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(229, 31);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // cbSeePassword
            // 
            this.cbSeePassword.AutoSize = true;
            this.cbSeePassword.Location = new System.Drawing.Point(443, 147);
            this.cbSeePassword.Name = "cbSeePassword";
            this.cbSeePassword.Size = new System.Drawing.Size(22, 21);
            this.cbSeePassword.TabIndex = 3;
            this.cbSeePassword.UseVisualStyleBackColor = true;
            this.cbSeePassword.CheckedChanged += new System.EventHandler(this.cbSeePassword_CheckedChanged);
            // 
            // cbSeeConfirmPassword
            // 
            this.cbSeeConfirmPassword.AutoSize = true;
            this.cbSeeConfirmPassword.Location = new System.Drawing.Point(443, 205);
            this.cbSeeConfirmPassword.Name = "cbSeeConfirmPassword";
            this.cbSeeConfirmPassword.Size = new System.Drawing.Size(22, 21);
            this.cbSeeConfirmPassword.TabIndex = 5;
            this.cbSeeConfirmPassword.UseVisualStyleBackColor = true;
            this.cbSeeConfirmPassword.CheckedChanged += new System.EventHandler(this.cbSeeConfirmPassword_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnSignUp.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.Location = new System.Drawing.Point(492, 160);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(189, 100);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pbGoBack
            // 
            this.pbGoBack.Image = global::UserSignIn.Properties.Resources._786399;
            this.pbGoBack.Location = new System.Drawing.Point(12, 12);
            this.pbGoBack.Name = "pbGoBack";
            this.pbGoBack.Size = new System.Drawing.Size(52, 55);
            this.pbGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGoBack.TabIndex = 12;
            this.pbGoBack.TabStop = false;
            this.pbGoBack.Click += new System.EventHandler(this.pbGoBack_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 515);
            this.Controls.Add(this.pbGoBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.cbSeeConfirmPassword);
            this.Controls.Add(this.cbSeePassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUp";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.CheckBox cbSeePassword;
        private System.Windows.Forms.CheckBox cbSeeConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pbGoBack;
    }
}