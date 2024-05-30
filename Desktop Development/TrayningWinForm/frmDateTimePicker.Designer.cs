namespace TrayningWinForm
{
    partial class frmDateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLongDate = new System.Windows.Forms.Button();
            this.btnShortDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(469, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnLongDate
            // 
            this.btnLongDate.Location = new System.Drawing.Point(155, 210);
            this.btnLongDate.Name = "btnLongDate";
            this.btnLongDate.Size = new System.Drawing.Size(199, 78);
            this.btnLongDate.TabIndex = 1;
            this.btnLongDate.Text = "Show Long Date";
            this.btnLongDate.UseVisualStyleBackColor = true;
            this.btnLongDate.Click += new System.EventHandler(this.btnLongDate_Click);
            // 
            // btnShortDate
            // 
            this.btnShortDate.Location = new System.Drawing.Point(425, 210);
            this.btnShortDate.Name = "btnShortDate";
            this.btnShortDate.Size = new System.Drawing.Size(199, 78);
            this.btnShortDate.TabIndex = 2;
            this.btnShortDate.Text = "Show Short Date";
            this.btnShortDate.UseVisualStyleBackColor = true;
            this.btnShortDate.Click += new System.EventHandler(this.btnShortDate_Click);
            // 
            // frmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 612);
            this.Controls.Add(this.btnShortDate);
            this.Controls.Add(this.btnLongDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmDateTimePicker";
            this.Text = "frmDateTimePicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLongDate;
        private System.Windows.Forms.Button btnShortDate;
    }
}