namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbCalculator = new System.Windows.Forms.Label();
            this.btnDivide = new Guna.UI2.WinForms.Guna2Button();
            this.btnMultiply = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinus = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnThree = new Guna.UI2.WinForms.Guna2Button();
            this.btnSix = new Guna.UI2.WinForms.Guna2Button();
            this.btnNine = new Guna.UI2.WinForms.Guna2Button();
            this.btnModelo = new Guna.UI2.WinForms.Guna2Button();
            this.btnFloat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnFife = new Guna.UI2.WinForms.Guna2Button();
            this.btnEaight = new Guna.UI2.WinForms.Guna2Button();
            this.btnZero = new Guna.UI2.WinForms.Guna2Button();
            this.btnOne = new Guna.UI2.WinForms.Guna2Button();
            this.btnFour = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeven = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnEquals = new Guna.UI2.WinForms.Guna2Button();
            this.txtStore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtResult = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(312, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(49, 44);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbCalculator
            // 
            this.lbCalculator.AutoSize = true;
            this.lbCalculator.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.lbCalculator.Location = new System.Drawing.Point(3, 7);
            this.lbCalculator.Name = "lbCalculator";
            this.lbCalculator.Size = new System.Drawing.Size(185, 49);
            this.lbCalculator.TabIndex = 1;
            this.lbCalculator.Text = "Calculator";
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Transparent;
            this.btnDivide.BorderRadius = 15;
            this.btnDivide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDivide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDivide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDivide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDivide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnDivide.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnDivide.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnDivide.Location = new System.Drawing.Point(271, 251);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.ShadowDecoration.BorderRadius = 15;
            this.btnDivide.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnDivide.ShadowDecoration.Enabled = true;
            this.btnDivide.Size = new System.Drawing.Size(60, 45);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiply.BorderRadius = 15;
            this.btnMultiply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultiply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultiply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnMultiply.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnMultiply.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnMultiply.Location = new System.Drawing.Point(271, 311);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.ShadowDecoration.BorderRadius = 15;
            this.btnMultiply.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnMultiply.ShadowDecoration.Enabled = true;
            this.btnMultiply.Size = new System.Drawing.Size(60, 45);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Tag = "x";
            this.btnMultiply.Text = "x";
            this.btnMultiply.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnMinus.BorderRadius = 15;
            this.btnMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnMinus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnMinus.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnMinus.Location = new System.Drawing.Point(271, 431);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ShadowDecoration.BorderRadius = 15;
            this.btnMinus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnMinus.ShadowDecoration.Enabled = true;
            this.btnMinus.Size = new System.Drawing.Size(60, 45);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Tag = "-";
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.BorderRadius = 15;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnPlus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnPlus.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnPlus.Location = new System.Drawing.Point(271, 371);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ShadowDecoration.BorderRadius = 15;
            this.btnPlus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnPlus.ShadowDecoration.Enabled = true;
            this.btnPlus.Size = new System.Drawing.Size(60, 45);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Tag = "+";
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.BorderRadius = 15;
            this.btnThree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnThree.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnThree.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnThree.Location = new System.Drawing.Point(192, 433);
            this.btnThree.Name = "btnThree";
            this.btnThree.ShadowDecoration.BorderRadius = 15;
            this.btnThree.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnThree.ShadowDecoration.Enabled = true;
            this.btnThree.Size = new System.Drawing.Size(60, 45);
            this.btnThree.TabIndex = 9;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Transparent;
            this.btnSix.BorderRadius = 15;
            this.btnSix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnSix.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnSix.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnSix.Location = new System.Drawing.Point(192, 372);
            this.btnSix.Name = "btnSix";
            this.btnSix.ShadowDecoration.BorderRadius = 15;
            this.btnSix.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnSix.ShadowDecoration.Enabled = true;
            this.btnSix.Size = new System.Drawing.Size(60, 45);
            this.btnSix.TabIndex = 8;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Transparent;
            this.btnNine.BorderRadius = 15;
            this.btnNine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnNine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnNine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnNine.Location = new System.Drawing.Point(192, 312);
            this.btnNine.Name = "btnNine";
            this.btnNine.ShadowDecoration.BorderRadius = 15;
            this.btnNine.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnNine.ShadowDecoration.Enabled = true;
            this.btnNine.Size = new System.Drawing.Size(60, 45);
            this.btnNine.TabIndex = 7;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.BackColor = System.Drawing.Color.Transparent;
            this.btnModelo.BorderRadius = 15;
            this.btnModelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnModelo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnModelo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnModelo.Location = new System.Drawing.Point(192, 251);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.ShadowDecoration.BorderRadius = 15;
            this.btnModelo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnModelo.ShadowDecoration.Enabled = true;
            this.btnModelo.Size = new System.Drawing.Size(60, 45);
            this.btnModelo.TabIndex = 6;
            this.btnModelo.Tag = "%";
            this.btnModelo.Text = "%";
            this.btnModelo.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.Transparent;
            this.btnFloat.BorderRadius = 15;
            this.btnFloat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFloat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFloat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFloat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFloat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnFloat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFloat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFloat.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnFloat.Location = new System.Drawing.Point(115, 491);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.ShadowDecoration.BorderRadius = 15;
            this.btnFloat.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFloat.ShadowDecoration.Enabled = true;
            this.btnFloat.Size = new System.Drawing.Size(60, 45);
            this.btnFloat.TabIndex = 13;
            this.btnFloat.Text = ".";
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.BorderRadius = 15;
            this.btnTwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnTwo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnTwo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnTwo.Location = new System.Drawing.Point(115, 433);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.ShadowDecoration.BorderRadius = 15;
            this.btnTwo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnTwo.ShadowDecoration.Enabled = true;
            this.btnTwo.Size = new System.Drawing.Size(60, 45);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnFife
            // 
            this.btnFife.BackColor = System.Drawing.Color.Transparent;
            this.btnFife.BorderRadius = 15;
            this.btnFife.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFife.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFife.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFife.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFife.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnFife.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFife.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFife.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFife.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnFife.Location = new System.Drawing.Point(115, 373);
            this.btnFife.Name = "btnFife";
            this.btnFife.ShadowDecoration.BorderRadius = 15;
            this.btnFife.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFife.ShadowDecoration.Enabled = true;
            this.btnFife.Size = new System.Drawing.Size(60, 45);
            this.btnFife.TabIndex = 11;
            this.btnFife.Tag = "5";
            this.btnFife.Text = "5";
            this.btnFife.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEaight
            // 
            this.btnEaight.BackColor = System.Drawing.Color.Transparent;
            this.btnEaight.BorderRadius = 15;
            this.btnEaight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEaight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEaight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEaight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEaight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnEaight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEaight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnEaight.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnEaight.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnEaight.Location = new System.Drawing.Point(115, 312);
            this.btnEaight.Name = "btnEaight";
            this.btnEaight.ShadowDecoration.BorderRadius = 15;
            this.btnEaight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnEaight.ShadowDecoration.Enabled = true;
            this.btnEaight.Size = new System.Drawing.Size(60, 45);
            this.btnEaight.TabIndex = 10;
            this.btnEaight.Tag = "8";
            this.btnEaight.Text = "8";
            this.btnEaight.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.BorderRadius = 15;
            this.btnZero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnZero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnZero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnZero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnZero.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnZero.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnZero.Location = new System.Drawing.Point(35, 491);
            this.btnZero.Name = "btnZero";
            this.btnZero.ShadowDecoration.BorderRadius = 15;
            this.btnZero.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnZero.ShadowDecoration.Enabled = true;
            this.btnZero.Size = new System.Drawing.Size(60, 45);
            this.btnZero.TabIndex = 17;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.BorderRadius = 15;
            this.btnOne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOne.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnOne.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnOne.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnOne.Location = new System.Drawing.Point(35, 431);
            this.btnOne.Name = "btnOne";
            this.btnOne.ShadowDecoration.BorderRadius = 15;
            this.btnOne.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnOne.ShadowDecoration.Enabled = true;
            this.btnOne.Size = new System.Drawing.Size(60, 45);
            this.btnOne.TabIndex = 16;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.BorderRadius = 15;
            this.btnFour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFour.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFour.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnFour.Location = new System.Drawing.Point(35, 373);
            this.btnFour.Name = "btnFour";
            this.btnFour.ShadowDecoration.BorderRadius = 15;
            this.btnFour.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnFour.ShadowDecoration.Enabled = true;
            this.btnFour.Size = new System.Drawing.Size(60, 45);
            this.btnFour.TabIndex = 15;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnSeven.BorderRadius = 15;
            this.btnSeven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnSeven.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnSeven.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnSeven.Location = new System.Drawing.Point(35, 312);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.ShadowDecoration.BorderRadius = 15;
            this.btnSeven.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnSeven.ShadowDecoration.Enabled = true;
            this.btnSeven.Size = new System.Drawing.Size(60, 45);
            this.btnSeven.TabIndex = 14;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnClear.Location = new System.Drawing.Point(35, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.BorderRadius = 15;
            this.btnClear.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnClear.ShadowDecoration.Enabled = true;
            this.btnClear.Size = new System.Drawing.Size(140, 45);
            this.btnClear.TabIndex = 18;
            this.btnClear.Tag = "c";
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Transparent;
            this.btnEquals.BorderRadius = 15;
            this.btnEquals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEquals.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEquals.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEquals.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(128)))), ((int)(((byte)(46)))));
            this.btnEquals.Location = new System.Drawing.Point(192, 491);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.ShadowDecoration.BorderRadius = 15;
            this.btnEquals.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnEquals.ShadowDecoration.Enabled = true;
            this.btnEquals.Size = new System.Drawing.Size(139, 45);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Tag = "=";
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtStore
            // 
            this.txtStore.BorderThickness = 0;
            this.txtStore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStore.DefaultText = "";
            this.txtStore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.txtStore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtStore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStore.Location = new System.Drawing.Point(35, 121);
            this.txtStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStore.Name = "txtStore";
            this.txtStore.PasswordChar = '\0';
            this.txtStore.PlaceholderText = "";
            this.txtStore.SelectedText = "";
            this.txtStore.Size = new System.Drawing.Size(296, 48);
            this.txtStore.TabIndex = 20;
            this.txtStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            this.txtResult.BorderThickness = 0;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.DefaultText = "";
            this.txtResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResult.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.txtResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResult.Location = new System.Drawing.Point(35, 180);
            this.txtResult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.PlaceholderText = "0";
            this.txtResult.SelectedText = "";
            this.txtResult.Size = new System.Drawing.Size(296, 48);
            this.txtResult.TabIndex = 21;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFife);
            this.Controls.Add(this.btnEaight);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnModelo);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.lbCalculator);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnExit;
        private System.Windows.Forms.Label lbCalculator;
        private Guna.UI2.WinForms.Guna2Button btnDivide;
        private Guna.UI2.WinForms.Guna2Button btnMultiply;
        private Guna.UI2.WinForms.Guna2Button btnMinus;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btnThree;
        private Guna.UI2.WinForms.Guna2Button btnSix;
        private Guna.UI2.WinForms.Guna2Button btnNine;
        private Guna.UI2.WinForms.Guna2Button btnModelo;
        private Guna.UI2.WinForms.Guna2Button btnFloat;
        private Guna.UI2.WinForms.Guna2Button btnTwo;
        private Guna.UI2.WinForms.Guna2Button btnFife;
        private Guna.UI2.WinForms.Guna2Button btnEaight;
        private Guna.UI2.WinForms.Guna2Button btnZero;
        private Guna.UI2.WinForms.Guna2Button btnOne;
        private Guna.UI2.WinForms.Guna2Button btnFour;
        private Guna.UI2.WinForms.Guna2Button btnSeven;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnEquals;
        private Guna.UI2.WinForms.Guna2TextBox txtStore;
        private Guna.UI2.WinForms.Guna2TextBox txtResult;
    }
}

