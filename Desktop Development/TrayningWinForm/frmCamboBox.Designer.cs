namespace TrayningWinForm
{
    partial class frmCamboBox
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbChangePicture = new System.Windows.Forms.Label();
            this.LBName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Image = global::TrayningWinForm.Properties.Resources.Girl;
            this.pbImage.Location = new System.Drawing.Point(398, 75);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(437, 383);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Book",
            "Boy",
            "Girl",
            "Pen"});
            this.comboBox1.Location = new System.Drawing.Point(687, 509);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbChangePicture
            // 
            this.lbChangePicture.AutoSize = true;
            this.lbChangePicture.Font = new System.Drawing.Font("Trebuchet MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangePicture.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbChangePicture.Location = new System.Drawing.Point(416, 496);
            this.lbChangePicture.Name = "lbChangePicture";
            this.lbChangePicture.Size = new System.Drawing.Size(246, 40);
            this.lbChangePicture.TabIndex = 2;
            this.lbChangePicture.Text = "Change Picture";
            // 
            // LBName
            // 
            this.LBName.AutoSize = true;
            this.LBName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBName.ForeColor = System.Drawing.Color.Red;
            this.LBName.Location = new System.Drawing.Point(591, 24);
            this.LBName.Name = "LBName";
            this.LBName.Size = new System.Drawing.Size(0, 43);
            this.LBName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.LBName);
            this.Controls.Add(this.lbChangePicture);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbChangePicture;
        private System.Windows.Forms.Label LBName;
    }
}

