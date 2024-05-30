namespace FastFood
{
    partial class frmNewMain
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
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MuneButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.SideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuneButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.panel4);
            this.SideBar.Controls.Add(this.panel5);
            this.SideBar.Location = new System.Drawing.Point(0, -1);
            this.SideBar.MaximumSize = new System.Drawing.Size(294, 712);
            this.SideBar.MinimumSize = new System.Drawing.Size(99, 712);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(294, 712);
            this.SideBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MuneButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 155);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(134, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // MuneButton
            // 
            this.MuneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuneButton.Image = global::FastFood.Properties.Resources.icons8_menu_32px;
            this.MuneButton.Location = new System.Drawing.Point(21, 39);
            this.MuneButton.Name = "MuneButton";
            this.MuneButton.Size = new System.Drawing.Size(58, 57);
            this.MuneButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MuneButton.TabIndex = 0;
            this.MuneButton.TabStop = false;
            this.MuneButton.Click += new System.EventHandler(this.MuneButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 61);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FastFood.Properties.Resources.icons8_home_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(284, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "         Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 61);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::FastFood.Properties.Resources.icons8_group_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(22, 5);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(284, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "         Users";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 61);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::FastFood.Properties.Resources.icons8_info_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(22, 5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(284, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "         About";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 61);
            this.panel5.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::FastFood.Properties.Resources.icons8_help_32px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(22, 5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(284, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "         Help";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // frmNewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 727);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewMain";
            this.Text = "frmNewMain";
            this.SideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuneButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel SideBar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Label label1;
        private PictureBox MuneButton;
        private System.Windows.Forms.Timer sideBarTimer;
    }
}