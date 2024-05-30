namespace GeneraterPassword
{
    partial class frmPasswordGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbLengthNumber = new System.Windows.Forms.Label();
            this.rbNumbers = new System.Windows.Forms.RadioButton();
            this.rbSmallLetters = new System.Windows.Forms.RadioButton();
            this.rbCapitalLetters = new System.Windows.Forms.RadioButton();
            this.rbSymbols = new System.Windows.Forms.RadioButton();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(197, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(486, 28);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Character Type";
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.Location = new System.Drawing.Point(429, 334);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(64, 27);
            this.rbMix.TabIndex = 7;
            this.rbMix.TabStop = true;
            this.rbMix.Tag = "m";
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            this.rbMix.CheckedChanged += new System.EventHandler(this.rbSmallLetters_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Purple;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(197, 388);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(8);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(486, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbLengthNumber
            // 
            this.lbLengthNumber.AutoSize = true;
            this.lbLengthNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLengthNumber.Font = new System.Drawing.Font("Tw Cen MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLengthNumber.ForeColor = System.Drawing.Color.Purple;
            this.lbLengthNumber.Location = new System.Drawing.Point(731, 397);
            this.lbLengthNumber.Name = "lbLengthNumber";
            this.lbLengthNumber.Size = new System.Drawing.Size(45, 50);
            this.lbLengthNumber.TabIndex = 9;
            this.lbLengthNumber.Text = "0";
            // 
            // rbNumbers
            // 
            this.rbNumbers.AutoSize = true;
            this.rbNumbers.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumbers.Location = new System.Drawing.Point(269, 228);
            this.rbNumbers.Name = "rbNumbers";
            this.rbNumbers.Size = new System.Drawing.Size(105, 27);
            this.rbNumbers.TabIndex = 10;
            this.rbNumbers.TabStop = true;
            this.rbNumbers.Tag = "m";
            this.rbNumbers.Text = "Numbers";
            this.rbNumbers.UseVisualStyleBackColor = true;
            this.rbNumbers.CheckedChanged += new System.EventHandler(this.rbSmallLetters_CheckedChanged);
            // 
            // rbSmallLetters
            // 
            this.rbSmallLetters.AutoSize = true;
            this.rbSmallLetters.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallLetters.Location = new System.Drawing.Point(544, 228);
            this.rbSmallLetters.Name = "rbSmallLetters";
            this.rbSmallLetters.Size = new System.Drawing.Size(135, 27);
            this.rbSmallLetters.TabIndex = 11;
            this.rbSmallLetters.TabStop = true;
            this.rbSmallLetters.Tag = "m";
            this.rbSmallLetters.Text = "Samll Letters";
            this.rbSmallLetters.UseVisualStyleBackColor = true;
            this.rbSmallLetters.CheckedChanged += new System.EventHandler(this.rbSmallLetters_CheckedChanged);
            // 
            // rbCapitalLetters
            // 
            this.rbCapitalLetters.AutoSize = true;
            this.rbCapitalLetters.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCapitalLetters.Location = new System.Drawing.Point(269, 289);
            this.rbCapitalLetters.Name = "rbCapitalLetters";
            this.rbCapitalLetters.Size = new System.Drawing.Size(151, 27);
            this.rbCapitalLetters.TabIndex = 12;
            this.rbCapitalLetters.TabStop = true;
            this.rbCapitalLetters.Tag = "m";
            this.rbCapitalLetters.Text = "Capital Letters";
            this.rbCapitalLetters.UseVisualStyleBackColor = true;
            this.rbCapitalLetters.CheckedChanged += new System.EventHandler(this.rbSmallLetters_CheckedChanged);
            // 
            // rbSymbols
            // 
            this.rbSymbols.AutoSize = true;
            this.rbSymbols.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSymbols.Location = new System.Drawing.Point(544, 289);
            this.rbSymbols.Name = "rbSymbols";
            this.rbSymbols.Size = new System.Drawing.Size(100, 27);
            this.rbSymbols.TabIndex = 13;
            this.rbSymbols.TabStop = true;
            this.rbSymbols.Tag = "m";
            this.rbSymbols.Text = "Symbols";
            this.rbSymbols.UseVisualStyleBackColor = true;
            this.rbSymbols.CheckedChanged += new System.EventHandler(this.rbSmallLetters_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Purple;
            this.btnCopy.Location = new System.Drawing.Point(386, 495);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(106, 55);
            this.btnCopy.TabIndex = 14;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeneraterPassword.Properties.Resources.logout_icon_png_20;
            this.pictureBox1.Location = new System.Drawing.Point(809, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 579);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.rbSymbols);
            this.Controls.Add(this.rbCapitalLetters);
            this.Controls.Add(this.rbSmallLetters);
            this.Controls.Add(this.rbNumbers);
            this.Controls.Add(this.lbLengthNumber);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.rbMix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbLengthNumber;
        private System.Windows.Forms.RadioButton rbNumbers;
        private System.Windows.Forms.RadioButton rbSmallLetters;
        private System.Windows.Forms.RadioButton rbCapitalLetters;
        private System.Windows.Forms.RadioButton rbSymbols;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

