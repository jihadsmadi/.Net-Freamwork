namespace TrayningWinForm
{
    partial class frmColorDailog
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
            this.txtb = new System.Windows.Forms.TextBox();
            this.btnForColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnFileDailog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFileDailog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMultiOpenFileDailog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(275, 112);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(342, 27);
            this.txtb.TabIndex = 0;
            // 
            // btnForColor
            // 
            this.btnForColor.Location = new System.Drawing.Point(275, 206);
            this.btnForColor.Name = "btnForColor";
            this.btnForColor.Size = new System.Drawing.Size(151, 95);
            this.btnForColor.TabIndex = 1;
            this.btnForColor.Text = "Change Color";
            this.btnForColor.UseVisualStyleBackColor = true;
            this.btnForColor.Click += new System.EventHandler(this.btnForColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(465, 206);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(152, 95);
            this.btnBackColor.TabIndex = 2;
            this.btnBackColor.Text = "Change Back Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(275, 316);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(151, 95);
            this.btnChangeFont.TabIndex = 3;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnFileDailog
            // 
            this.btnFileDailog.Location = new System.Drawing.Point(466, 316);
            this.btnFileDailog.Name = "btnFileDailog";
            this.btnFileDailog.Size = new System.Drawing.Size(151, 95);
            this.btnFileDailog.TabIndex = 4;
            this.btnFileDailog.Text = "Save File Dialog";
            this.btnFileDailog.UseVisualStyleBackColor = true;
            this.btnFileDailog.Click += new System.EventHandler(this.btnFileDailog_Click);
            // 
            // btnOpenFileDailog
            // 
            this.btnOpenFileDailog.Location = new System.Drawing.Point(275, 434);
            this.btnOpenFileDailog.Name = "btnOpenFileDailog";
            this.btnOpenFileDailog.Size = new System.Drawing.Size(151, 95);
            this.btnOpenFileDailog.TabIndex = 5;
            this.btnOpenFileDailog.Text = "Open File Dialog";
            this.btnOpenFileDailog.UseVisualStyleBackColor = true;
            this.btnOpenFileDailog.Click += new System.EventHandler(this.btnOpenFileDailog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnMultiOpenFileDailog
            // 
            this.btnMultiOpenFileDailog.Location = new System.Drawing.Point(465, 434);
            this.btnMultiOpenFileDailog.Name = "btnMultiOpenFileDailog";
            this.btnMultiOpenFileDailog.Size = new System.Drawing.Size(151, 95);
            this.btnMultiOpenFileDailog.TabIndex = 6;
            this.btnMultiOpenFileDailog.Text = "Open Multi File Dialog";
            this.btnMultiOpenFileDailog.UseVisualStyleBackColor = true;
            this.btnMultiOpenFileDailog.Click += new System.EventHandler(this.btnMultiOpenFileDailog_Click);
            // 
            // frmColorDailog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 594);
            this.Controls.Add(this.btnMultiOpenFileDailog);
            this.Controls.Add(this.btnOpenFileDailog);
            this.Controls.Add(this.btnFileDailog);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnForColor);
            this.Controls.Add(this.txtb);
            this.Name = "frmColorDailog";
            this.Text = "frmColorDailog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btnForColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFileDailog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDailog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMultiOpenFileDailog;
    }
}