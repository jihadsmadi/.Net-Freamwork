namespace MyFirstProjectWinForms
{
    partial class PizzaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LbOrderSummary = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSizeResult = new System.Windows.Forms.Label();
            this.LbToppings = new System.Windows.Forms.Label();
            this.LbToppingsResult = new System.Windows.Forms.Label();
            this.lbbSizeResult = new System.Windows.Forms.Label();
            this.LbCrustType = new System.Windows.Forms.Label();
            this.LbCrustTypeResult = new System.Windows.Forms.Label();
            this.LbTotalPrice = new System.Windows.Forms.Label();
            this.LbTotalPriceResult = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbExtraChees = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lbWherToEat = new System.Windows.Forms.Label();
            this.LbWherToEatResult = new System.Windows.Forms.Label();
            this.gbOrder.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // LbOrderSummary
            // 
            this.LbOrderSummary.AutoSize = true;
            this.LbOrderSummary.Location = new System.Drawing.Point(915, 98);
            this.LbOrderSummary.Name = "LbOrderSummary";
            this.LbOrderSummary.Size = new System.Drawing.Size(123, 19);
            this.LbOrderSummary.TabIndex = 16;
            this.LbOrderSummary.Text = "Order Summary";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(930, 138);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(49, 19);
            this.lbSize.TabIndex = 17;
            this.lbSize.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(985, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 18;
            // 
            // lbSizeResult
            // 
            this.lbSizeResult.AutoSize = true;
            this.lbSizeResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizeResult.Location = new System.Drawing.Point(985, 138);
            this.lbSizeResult.Name = "lbSizeResult";
            this.lbSizeResult.Size = new System.Drawing.Size(0, 19);
            this.lbSizeResult.TabIndex = 19;
            // 
            // LbToppings
            // 
            this.LbToppings.AutoSize = true;
            this.LbToppings.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbToppings.Location = new System.Drawing.Point(930, 173);
            this.LbToppings.Name = "LbToppings";
            this.LbToppings.Size = new System.Drawing.Size(89, 19);
            this.LbToppings.TabIndex = 20;
            this.LbToppings.Text = "Toppings:";
            // 
            // LbToppingsResult
            // 
            this.LbToppingsResult.AutoSize = true;
            this.LbToppingsResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbToppingsResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbToppingsResult.Location = new System.Drawing.Point(996, 192);
            this.LbToppingsResult.Name = "LbToppingsResult";
            this.LbToppingsResult.Size = new System.Drawing.Size(0, 19);
            this.LbToppingsResult.TabIndex = 21;
            // 
            // lbbSizeResult
            // 
            this.lbbSizeResult.AutoSize = true;
            this.lbbSizeResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbbSizeResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbSizeResult.Location = new System.Drawing.Point(982, 138);
            this.lbbSizeResult.Name = "lbbSizeResult";
            this.lbbSizeResult.Size = new System.Drawing.Size(0, 19);
            this.lbbSizeResult.TabIndex = 22;
            // 
            // LbCrustType
            // 
            this.LbCrustType.AutoSize = true;
            this.LbCrustType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCrustType.Location = new System.Drawing.Point(930, 264);
            this.LbCrustType.Name = "LbCrustType";
            this.LbCrustType.Size = new System.Drawing.Size(103, 19);
            this.LbCrustType.TabIndex = 23;
            this.LbCrustType.Text = "Crust Type:";
            // 
            // LbCrustTypeResult
            // 
            this.LbCrustTypeResult.AutoSize = true;
            this.LbCrustTypeResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbCrustTypeResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCrustTypeResult.Location = new System.Drawing.Point(996, 301);
            this.LbCrustTypeResult.Name = "LbCrustTypeResult";
            this.LbCrustTypeResult.Size = new System.Drawing.Size(0, 19);
            this.LbCrustTypeResult.TabIndex = 24;
            // 
            // LbTotalPrice
            // 
            this.LbTotalPrice.AutoSize = true;
            this.LbTotalPrice.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPrice.Location = new System.Drawing.Point(930, 388);
            this.LbTotalPrice.Name = "LbTotalPrice";
            this.LbTotalPrice.Size = new System.Drawing.Size(104, 19);
            this.LbTotalPrice.TabIndex = 25;
            this.LbTotalPrice.Text = "Total Price:";
            // 
            // LbTotalPriceResult
            // 
            this.LbTotalPriceResult.AutoSize = true;
            this.LbTotalPriceResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbTotalPriceResult.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPriceResult.ForeColor = System.Drawing.Color.Green;
            this.LbTotalPriceResult.Location = new System.Drawing.Point(1005, 431);
            this.LbTotalPriceResult.Name = "LbTotalPriceResult";
            this.LbTotalPriceResult.Size = new System.Drawing.Size(83, 61);
            this.LbTotalPriceResult.TabIndex = 26;
            this.LbTotalPriceResult.Text = "0$";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(447, 513);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(134, 38);
            this.btnOrderPizza.TabIndex = 27;
            this.btnOrderPizza.Text = "Order Pizza\r\n";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(620, 513);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(134, 38);
            this.btnResetForm.TabIndex = 28;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.gbWhereToEat);
            this.gbOrder.Controls.Add(this.gbToppings);
            this.gbOrder.Controls.Add(this.gbCrustType);
            this.gbOrder.Controls.Add(this.gbSize);
            this.gbOrder.Location = new System.Drawing.Point(126, 70);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(632, 398);
            this.gbOrder.TabIndex = 29;
            this.gbOrder.TabStop = false;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Location = new System.Drawing.Point(325, 289);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(200, 100);
            this.gbWhereToEat.TabIndex = 19;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(6, 40);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(76, 23);
            this.rbEatIn.TabIndex = 16;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.Location = new System.Drawing.Point(107, 40);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(87, 23);
            this.rbEatOut.TabIndex = 15;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbEatOut_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbGreenPeppers);
            this.gbToppings.Controls.Add(this.cbTomatoes);
            this.gbToppings.Controls.Add(this.cbOlives);
            this.gbToppings.Controls.Add(this.cbMushrooms);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbExtraChees);
            this.gbToppings.Location = new System.Drawing.Point(325, 26);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(303, 222);
            this.gbToppings.TabIndex = 18;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Location = new System.Drawing.Point(160, 149);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(129, 23);
            this.cbGreenPeppers.TabIndex = 17;
            this.cbGreenPeppers.Text = "Green Pepers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Location = new System.Drawing.Point(13, 149);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(105, 23);
            this.cbTomatoes.TabIndex = 16;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Location = new System.Drawing.Point(160, 103);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(78, 23);
            this.cbOlives.TabIndex = 15;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(13, 103);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(117, 23);
            this.cbMushrooms.TabIndex = 14;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(160, 57);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(78, 23);
            this.cbOnion.TabIndex = 13;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbExtraChees
            // 
            this.cbExtraChees.AutoSize = true;
            this.cbExtraChees.Location = new System.Drawing.Point(13, 57);
            this.cbExtraChees.Name = "cbExtraChees";
            this.cbExtraChees.Size = new System.Drawing.Size(118, 23);
            this.cbExtraChees.TabIndex = 12;
            this.cbExtraChees.Text = "Extra Chees";
            this.cbExtraChees.UseVisualStyleBackColor = true;
            this.cbExtraChees.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.Location = new System.Drawing.Point(11, 272);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(228, 132);
            this.gbCrustType.TabIndex = 17;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(49, 89);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(114, 23);
            this.rbThick.TabIndex = 9;
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(49, 48);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(108, 23);
            this.rbThin.TabIndex = 8;
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(6, 31);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(213, 192);
            this.gbSize.TabIndex = 16;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(23, 91);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(90, 23);
            this.rbMeduim.TabIndex = 5;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(23, 139);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(73, 23);
            this.rbLarge.TabIndex = 6;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(23, 43);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 23);
            this.rbSmall.TabIndex = 4;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // lbWherToEat
            // 
            this.lbWherToEat.AutoSize = true;
            this.lbWherToEat.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWherToEat.Location = new System.Drawing.Point(930, 329);
            this.lbWherToEat.Name = "lbWherToEat";
            this.lbWherToEat.Size = new System.Drawing.Size(126, 19);
            this.lbWherToEat.TabIndex = 30;
            this.lbWherToEat.Text = "Where To Eat:";
            // 
            // LbWherToEatResult
            // 
            this.LbWherToEatResult.AutoSize = true;
            this.LbWherToEatResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbWherToEatResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWherToEatResult.Location = new System.Drawing.Point(996, 359);
            this.LbWherToEatResult.Name = "LbWherToEatResult";
            this.LbWherToEatResult.Size = new System.Drawing.Size(0, 19);
            this.LbWherToEatResult.TabIndex = 31;
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 644);
            this.Controls.Add(this.LbWherToEatResult);
            this.Controls.Add(this.lbWherToEat);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.LbTotalPriceResult);
            this.Controls.Add(this.LbTotalPrice);
            this.Controls.Add(this.LbCrustTypeResult);
            this.Controls.Add(this.LbCrustType);
            this.Controls.Add(this.lbbSizeResult);
            this.Controls.Add(this.LbToppingsResult);
            this.Controls.Add(this.LbToppings);
            this.Controls.Add(this.lbSizeResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.LbOrderSummary);
            this.Controls.Add(this.label1);
            this.Name = "PizzaForm";
            this.Text = "PizzaForm";
            this.gbOrder.ResumeLayout(false);
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbOrderSummary;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSizeResult;
        private System.Windows.Forms.Label LbToppings;
        private System.Windows.Forms.Label LbToppingsResult;
        private System.Windows.Forms.Label lbbSizeResult;
        private System.Windows.Forms.Label LbCrustType;
        private System.Windows.Forms.Label LbCrustTypeResult;
        private System.Windows.Forms.Label LbTotalPrice;
        private System.Windows.Forms.Label LbTotalPriceResult;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbExtraChees;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label lbWherToEat;
        private System.Windows.Forms.Label LbWherToEatResult;
    }
}