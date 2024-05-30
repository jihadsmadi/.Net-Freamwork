namespace ApiTrayning
{
	partial class frmGetCity
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
			this.cbLocation = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(155, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search a location";
			// 
			// cbLocation
			// 
			this.cbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbLocation.Font = new System.Drawing.Font("Tahoma", 10F);
			this.cbLocation.FormattingEnabled = true;
			this.cbLocation.Location = new System.Drawing.Point(162, 101);
			this.cbLocation.Name = "cbLocation";
			this.cbLocation.Size = new System.Drawing.Size(253, 32);
			this.cbLocation.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnSave.Location = new System.Drawing.Point(162, 176);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(253, 61);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmGetCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(571, 283);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cbLocation);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGetCity";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Get City";
			this.Load += new System.EventHandler(this.frmGetCity_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbLocation;
		private System.Windows.Forms.Button btnSave;
	}
}