namespace Events_Course20
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
			this.uctlCalculater1 = new Events_Course20.uctlCalculater();
			this.SuspendLayout();
			// 
			// uctlCalculater1
			// 
			this.uctlCalculater1.BackColor = System.Drawing.Color.RosyBrown;
			this.uctlCalculater1.Location = new System.Drawing.Point(330, 102);
			this.uctlCalculater1.Name = "uctlCalculater1";
			this.uctlCalculater1.Size = new System.Drawing.Size(294, 262);
			this.uctlCalculater1.TabIndex = 0;
			this.uctlCalculater1.onCalculationComplete += new System.EventHandler<Events_Course20.uctlCalculater.onCalculationEventArgs>(this.uctlCalculater1_onCalculationComplete);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(893, 524);
			this.Controls.Add(this.uctlCalculater1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private uctlCalculater uctlCalculater1;
	}
}

