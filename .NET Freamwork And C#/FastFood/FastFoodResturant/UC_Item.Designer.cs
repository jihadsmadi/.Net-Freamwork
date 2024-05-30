namespace FastFoodResturant
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
            this.UC_PB_image = new System.Windows.Forms.PictureBox();
            this.UC_LB_Name = new System.Windows.Forms.Label();
            this.UC_LB_Price = new System.Windows.Forms.Label();
            this.UC_Panel_Adding = new System.Windows.Forms.Panel();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.UC_LB_Count = new System.Windows.Forms.Label();
            this.UC_CB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UC_PB_image)).BeginInit();
            this.UC_Panel_Adding.SuspendLayout();
            this.SuspendLayout();
            // 
            // UC_PB_image
            // 
            this.UC_PB_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.UC_PB_image.Image = global::FastFoodResturant.Properties.Resources.Burger;
            this.UC_PB_image.Location = new System.Drawing.Point(0, 0);
            this.UC_PB_image.Name = "UC_PB_image";
            this.UC_PB_image.Size = new System.Drawing.Size(168, 113);
            this.UC_PB_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UC_PB_image.TabIndex = 1;
            this.UC_PB_image.TabStop = false;
            this.UC_PB_image.Click += new System.EventHandler(this.UC_PB_image_Click);
            // 
            // UC_LB_Name
            // 
            this.UC_LB_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UC_LB_Name.AutoSize = true;
            this.UC_LB_Name.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_LB_Name.Location = new System.Drawing.Point(8, 118);
            this.UC_LB_Name.Name = "UC_LB_Name";
            this.UC_LB_Name.Size = new System.Drawing.Size(72, 23);
            this.UC_LB_Name.TabIndex = 3;
            this.UC_LB_Name.Text = "Burger";
            // 
            // UC_LB_Price
            // 
            this.UC_LB_Price.AutoSize = true;
            this.UC_LB_Price.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_LB_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.UC_LB_Price.Location = new System.Drawing.Point(125, 118);
            this.UC_LB_Price.Name = "UC_LB_Price";
            this.UC_LB_Price.Size = new System.Drawing.Size(36, 24);
            this.UC_LB_Price.TabIndex = 4;
            this.UC_LB_Price.Text = "4$";
            // 
            // UC_Panel_Adding
            // 
            this.UC_Panel_Adding.Controls.Add(this.btnMinus);
            this.UC_Panel_Adding.Controls.Add(this.btnAdd);
            this.UC_Panel_Adding.Controls.Add(this.UC_LB_Count);
            this.UC_Panel_Adding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UC_Panel_Adding.Enabled = false;
            this.UC_Panel_Adding.Location = new System.Drawing.Point(0, 147);
            this.UC_Panel_Adding.Name = "UC_Panel_Adding";
            this.UC_Panel_Adding.Size = new System.Drawing.Size(168, 43);
            this.UC_Panel_Adding.TabIndex = 5;
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Image = global::FastFoodResturant.Properties.Resources.icons8_minus_1;
            this.btnMinus.Location = new System.Drawing.Point(101, 6);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(48, 34);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::FastFoodResturant.Properties.Resources.icons8_Plus_7;
            this.btnAdd.Location = new System.Drawing.Point(10, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UC_LB_Count
            // 
            this.UC_LB_Count.AutoSize = true;
            this.UC_LB_Count.Font = new System.Drawing.Font("Tahoma", 10F);
            this.UC_LB_Count.Location = new System.Drawing.Point(69, 9);
            this.UC_LB_Count.Name = "UC_LB_Count";
            this.UC_LB_Count.Size = new System.Drawing.Size(21, 24);
            this.UC_LB_Count.TabIndex = 0;
            this.UC_LB_Count.Text = "0";
            // 
            // UC_CB
            // 
            this.UC_CB.AutoSize = true;
            this.UC_CB.FlatAppearance.BorderSize = 0;
            this.UC_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UC_CB.Location = new System.Drawing.Point(144, 15);
            this.UC_CB.Name = "UC_CB";
            this.UC_CB.Size = new System.Drawing.Size(17, 16);
            this.UC_CB.TabIndex = 6;
            this.UC_CB.UseVisualStyleBackColor = true;
            this.UC_CB.CheckedChanged += new System.EventHandler(this.UC_PB_image_Click);
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_CB);
            this.Controls.Add(this.UC_Panel_Adding);
            this.Controls.Add(this.UC_LB_Name);
            this.Controls.Add(this.UC_LB_Price);
            this.Controls.Add(this.UC_PB_image);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(168, 190);
            ((System.ComponentModel.ISupportInitialize)(this.UC_PB_image)).EndInit();
            this.UC_Panel_Adding.ResumeLayout(false);
            this.UC_Panel_Adding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UC_PB_image;
        private System.Windows.Forms.Label UC_LB_Name;
        private System.Windows.Forms.Label UC_LB_Price;
        private System.Windows.Forms.Panel UC_Panel_Adding;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label UC_LB_Count;
        private System.Windows.Forms.CheckBox UC_CB;
    }
}
