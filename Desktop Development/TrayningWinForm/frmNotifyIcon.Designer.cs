namespace TrayningWinForm
{
    partial class frmNotifyIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifyIcon));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnNotifyIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // btnNotifyIcon
            // 
            this.btnNotifyIcon.Location = new System.Drawing.Point(434, 252);
            this.btnNotifyIcon.Name = "btnNotifyIcon";
            this.btnNotifyIcon.Size = new System.Drawing.Size(195, 92);
            this.btnNotifyIcon.TabIndex = 0;
            this.btnNotifyIcon.Text = "Show Notify";
            this.btnNotifyIcon.UseVisualStyleBackColor = true;
            this.btnNotifyIcon.Click += new System.EventHandler(this.btnNotifyIcon_Click);
            // 
            // frmNotifyIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 630);
            this.Controls.Add(this.btnNotifyIcon);
            this.Name = "frmNotifyIcon";
            this.Text = "frmNotifyIcon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnNotifyIcon;
    }
}