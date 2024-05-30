namespace TrayningWinForm
{
    partial class frmCheckesListBox
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
            this.btnAddItems = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnShowCheckedItems = new System.Windows.Forms.Button();
            this.btnCheckAllItems = new System.Windows.Forms.Button();
            this.btnUncheckAllItems = new System.Windows.Forms.Button();
            this.btnRemoveThirdItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(147, 312);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(124, 63);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(147, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(490, 160);
            this.checkedListBox1.TabIndex = 2;
            // 
            // btnShowCheckedItems
            // 
            this.btnShowCheckedItems.Location = new System.Drawing.Point(331, 312);
            this.btnShowCheckedItems.Name = "btnShowCheckedItems";
            this.btnShowCheckedItems.Size = new System.Drawing.Size(124, 63);
            this.btnShowCheckedItems.TabIndex = 3;
            this.btnShowCheckedItems.Text = "Show Checked Items";
            this.btnShowCheckedItems.UseVisualStyleBackColor = true;
            this.btnShowCheckedItems.Click += new System.EventHandler(this.btnShowCheckedItems_Click);
            // 
            // btnCheckAllItems
            // 
            this.btnCheckAllItems.Location = new System.Drawing.Point(513, 312);
            this.btnCheckAllItems.Name = "btnCheckAllItems";
            this.btnCheckAllItems.Size = new System.Drawing.Size(124, 63);
            this.btnCheckAllItems.TabIndex = 4;
            this.btnCheckAllItems.Text = "Check All Items";
            this.btnCheckAllItems.UseVisualStyleBackColor = true;
            this.btnCheckAllItems.Click += new System.EventHandler(this.btnCheckAllItems_Click);
            // 
            // btnUncheckAllItems
            // 
            this.btnUncheckAllItems.Location = new System.Drawing.Point(237, 403);
            this.btnUncheckAllItems.Name = "btnUncheckAllItems";
            this.btnUncheckAllItems.Size = new System.Drawing.Size(124, 63);
            this.btnUncheckAllItems.TabIndex = 5;
            this.btnUncheckAllItems.Text = "Uncheck All Items";
            this.btnUncheckAllItems.UseVisualStyleBackColor = true;
            this.btnUncheckAllItems.Click += new System.EventHandler(this.btnUncheckAllItems_Click);
            // 
            // btnRemoveThirdItem
            // 
            this.btnRemoveThirdItem.Location = new System.Drawing.Point(426, 403);
            this.btnRemoveThirdItem.Name = "btnRemoveThirdItem";
            this.btnRemoveThirdItem.Size = new System.Drawing.Size(124, 63);
            this.btnRemoveThirdItem.TabIndex = 6;
            this.btnRemoveThirdItem.Text = "Remove Third Item";
            this.btnRemoveThirdItem.UseVisualStyleBackColor = true;
            this.btnRemoveThirdItem.Click += new System.EventHandler(this.btnRemoveThirdItem_Click);
            // 
            // frmCheckesListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 478);
            this.Controls.Add(this.btnRemoveThirdItem);
            this.Controls.Add(this.btnUncheckAllItems);
            this.Controls.Add(this.btnCheckAllItems);
            this.Controls.Add(this.btnShowCheckedItems);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnAddItems);
            this.Name = "frmCheckesListBox";
            this.Text = "v";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnShowCheckedItems;
        private System.Windows.Forms.Button btnCheckAllItems;
        private System.Windows.Forms.Button btnUncheckAllItems;
        private System.Windows.Forms.Button btnRemoveThirdItem;
    }
}