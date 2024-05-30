namespace FastFood
{
    partial class UC_OrderItem
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
            this.Order_Item_image = new System.Windows.Forms.PictureBox();
            this.Ordar_item_Name = new System.Windows.Forms.Label();
            this.btn_Ordar_Minus = new System.Windows.Forms.Button();
            this.btnOrder_Add = new System.Windows.Forms.Button();
            this.lb_Ordar_Price = new System.Windows.Forms.Label();
            this.lb_Ordar_Quantite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Order_Item_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_Item_image
            // 
            this.Order_Item_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Order_Item_image.Image = global::FastFood.Properties.Resources.Burger;
            this.Order_Item_image.Location = new System.Drawing.Point(12, 9);
            this.Order_Item_image.Name = "Order_Item_image";
            this.Order_Item_image.Size = new System.Drawing.Size(109, 75);
            this.Order_Item_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Order_Item_image.TabIndex = 0;
            this.Order_Item_image.TabStop = false;
            // 
            // Ordar_item_Name
            // 
            this.Ordar_item_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Ordar_item_Name.AutoSize = true;
            this.Ordar_item_Name.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ordar_item_Name.ForeColor = System.Drawing.Color.Black;
            this.Ordar_item_Name.Location = new System.Drawing.Point(145, 18);
            this.Ordar_item_Name.Name = "Ordar_item_Name";
            this.Ordar_item_Name.Size = new System.Drawing.Size(81, 25);
            this.Ordar_item_Name.TabIndex = 1;
            this.Ordar_item_Name.Text = "Burger";
            // 
            // btn_Ordar_Minus
            // 
            this.btn_Ordar_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Ordar_Minus.BackColor = System.Drawing.Color.White;
            this.btn_Ordar_Minus.FlatAppearance.BorderSize = 0;
            this.btn_Ordar_Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ordar_Minus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ordar_Minus.Image = global::FastFood.Properties.Resources.icons8_minus_1;
            this.btn_Ordar_Minus.Location = new System.Drawing.Point(205, 46);
            this.btn_Ordar_Minus.Name = "btn_Ordar_Minus";
            this.btn_Ordar_Minus.Size = new System.Drawing.Size(43, 43);
            this.btn_Ordar_Minus.TabIndex = 2;
            this.btn_Ordar_Minus.UseVisualStyleBackColor = false;
            this.btn_Ordar_Minus.Click += new System.EventHandler(this.btn_Ordar_Minus_Click);
            // 
            // btnOrder_Add
            // 
            this.btnOrder_Add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrder_Add.BackColor = System.Drawing.Color.White;
            this.btnOrder_Add.FlatAppearance.BorderSize = 0;
            this.btnOrder_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder_Add.Image = global::FastFood.Properties.Resources.icons8_Plus_7;
            this.btnOrder_Add.Location = new System.Drawing.Point(127, 46);
            this.btnOrder_Add.Name = "btnOrder_Add";
            this.btnOrder_Add.Size = new System.Drawing.Size(43, 43);
            this.btnOrder_Add.TabIndex = 3;
            this.btnOrder_Add.UseVisualStyleBackColor = false;
            this.btnOrder_Add.Click += new System.EventHandler(this.btnOrder_Add_Click);
            // 
            // lb_Ordar_Price
            // 
            this.lb_Ordar_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ordar_Price.AutoSize = true;
            this.lb_Ordar_Price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Ordar_Price.ForeColor = System.Drawing.Color.Black;
            this.lb_Ordar_Price.Location = new System.Drawing.Point(302, 28);
            this.lb_Ordar_Price.Name = "lb_Ordar_Price";
            this.lb_Ordar_Price.Size = new System.Drawing.Size(36, 28);
            this.lb_Ordar_Price.TabIndex = 4;
            this.lb_Ordar_Price.Tag = "2";
            this.lb_Ordar_Price.Text = "0$";
            // 
            // lb_Ordar_Quantite
            // 
            this.lb_Ordar_Quantite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Ordar_Quantite.AutoSize = true;
            this.lb_Ordar_Quantite.Location = new System.Drawing.Point(177, 54);
            this.lb_Ordar_Quantite.Name = "lb_Ordar_Quantite";
            this.lb_Ordar_Quantite.Size = new System.Drawing.Size(22, 25);
            this.lb_Ordar_Quantite.TabIndex = 5;
            this.lb_Ordar_Quantite.Text = "1";
            // 
            // UC_OrderItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_Ordar_Quantite);
            this.Controls.Add(this.lb_Ordar_Price);
            this.Controls.Add(this.btnOrder_Add);
            this.Controls.Add(this.btn_Ordar_Minus);
            this.Controls.Add(this.Ordar_item_Name);
            this.Controls.Add(this.Order_Item_image);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Name = "UC_OrderItem";
            this.Size = new System.Drawing.Size(372, 94);
            this.Load += new System.EventHandler(this.UC_OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Order_Item_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Order_Item_image;
        private Label Ordar_item_Name;
        private Button btn_Ordar_Minus;
        private Button btnOrder_Add;
        private Label lb_Ordar_Price;
        private Label lb_Ordar_Quantite;
    }
}
