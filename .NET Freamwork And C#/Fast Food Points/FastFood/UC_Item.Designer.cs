namespace FastFood
{
    partial class UC_Item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_uc_Name = new System.Windows.Forms.Label();
            this.lb_us_Price = new System.Windows.Forms.Label();
            this.cb_uc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucImage = new System.Windows.Forms.PictureBox();
            this.btnOrder_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ordar_Minus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Quantite = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_uc_Name
            // 
            this.lb_uc_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_uc_Name.AutoSize = true;
            this.lb_uc_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_uc_Name.Location = new System.Drawing.Point(3, -5);
            this.lb_uc_Name.Name = "lb_uc_Name";
            this.lb_uc_Name.Size = new System.Drawing.Size(86, 30);
            this.lb_uc_Name.TabIndex = 1;
            this.lb_uc_Name.Text = "label1";
            // 
            // lb_us_Price
            // 
            this.lb_us_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_us_Price.AutoSize = true;
            this.lb_us_Price.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_us_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lb_us_Price.Location = new System.Drawing.Point(168, 1);
            this.lb_us_Price.Name = "lb_us_Price";
            this.lb_us_Price.Size = new System.Drawing.Size(32, 23);
            this.lb_us_Price.TabIndex = 2;
            this.lb_us_Price.Text = "0$";
            // 
            // cb_uc
            // 
            this.cb_uc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_uc.AutoSize = true;
            this.cb_uc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_uc.CheckedState.BorderColor = System.Drawing.Color.White;
            this.cb_uc.CheckedState.BorderRadius = 0;
            this.cb_uc.CheckedState.BorderThickness = 0;
            this.cb_uc.CheckedState.FillColor = System.Drawing.Color.White;
            this.cb_uc.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cb_uc.Location = new System.Drawing.Point(177, 3);
            this.cb_uc.Name = "cb_uc";
            this.cb_uc.Size = new System.Drawing.Size(22, 21);
            this.cb_uc.TabIndex = 3;
            this.cb_uc.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.cb_uc.UncheckedState.BorderRadius = 0;
            this.cb_uc.UncheckedState.BorderThickness = 0;
            this.cb_uc.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cb_uc.UseVisualStyleBackColor = false;
            this.cb_uc.CheckedChanged += new System.EventHandler(this.cb_uc_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_uc_Name);
            this.panel1.Controls.Add(this.lb_us_Price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 28);
            this.panel1.TabIndex = 4;
            // 
            // ucImage
            // 
            this.ucImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucImage.Location = new System.Drawing.Point(0, 0);
            this.ucImage.Name = "ucImage";
            this.ucImage.Size = new System.Drawing.Size(202, 102);
            this.ucImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucImage.TabIndex = 0;
            this.ucImage.TabStop = false;
            this.ucImage.Click += new System.EventHandler(this.cb_uc_CheckedChanged);
            // 
            // btnOrder_Add
            // 
            this.btnOrder_Add.BackColor = System.Drawing.Color.White;
            this.btnOrder_Add.FlatAppearance.BorderSize = 0;
            this.btnOrder_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder_Add.Image = global::FastFood.Properties.Resources.icons8_Plus_7;
            this.btnOrder_Add.Location = new System.Drawing.Point(28, 0);
            this.btnOrder_Add.Name = "btnOrder_Add";
            this.btnOrder_Add.Size = new System.Drawing.Size(40, 30);
            this.btnOrder_Add.TabIndex = 7;
            this.btnOrder_Add.UseVisualStyleBackColor = false;
            this.btnOrder_Add.Click += new System.EventHandler(this.btnOrder_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(135, -63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "1";
            // 
            // btn_Ordar_Minus
            // 
            this.btn_Ordar_Minus.BackColor = System.Drawing.Color.White;
            this.btn_Ordar_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Ordar_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordar_Minus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ordar_Minus.Image = global::FastFood.Properties.Resources.icons8_minus_1;
            this.btn_Ordar_Minus.Location = new System.Drawing.Point(105, 0);
            this.btn_Ordar_Minus.Name = "btn_Ordar_Minus";
            this.btn_Ordar_Minus.Size = new System.Drawing.Size(35, 30);
            this.btn_Ordar_Minus.TabIndex = 6;
            this.btn_Ordar_Minus.UseVisualStyleBackColor = false;
            this.btn_Ordar_Minus.Click += new System.EventHandler(this.btn_Ordar_Minus_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lb_Quantite);
            this.panel2.Controls.Add(this.btn_Ordar_Minus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnOrder_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 30);
            this.panel2.TabIndex = 9;
            // 
            // lb_Quantite
            // 
            this.lb_Quantite.AutoSize = true;
            this.lb_Quantite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Quantite.Location = new System.Drawing.Point(74, 0);
            this.lb_Quantite.Name = "lb_Quantite";
            this.lb_Quantite.Size = new System.Drawing.Size(27, 32);
            this.lb_Quantite.TabIndex = 10;
            this.lb_Quantite.Text = "0";
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_uc);
            this.Controls.Add(this.ucImage);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(202, 160);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_uc_Name;
        private Label lb_us_Price;
        private Guna.UI2.WinForms.Guna2CheckBox cb_uc;
        private Panel panel1;
        private PictureBox ucImage;
        private Button btnOrder_Add;
        private Label label3;
        private Button btn_Ordar_Minus;
        private Panel panel2;
        private Label lb_Quantite;
    }
}
