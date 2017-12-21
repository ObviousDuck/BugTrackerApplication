namespace BugTrackerApplication
{
    partial class WhiteBoxTester
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
            this.WhiteBoxTesterTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WhiteBoxTesterTitle
            // 
            this.WhiteBoxTesterTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WhiteBoxTesterTitle.AutoSize = true;
            this.WhiteBoxTesterTitle.Font = new System.Drawing.Font("Prestige Elite Std", 30F, System.Drawing.FontStyle.Bold);
            this.WhiteBoxTesterTitle.Location = new System.Drawing.Point(165, 27);
            this.WhiteBoxTesterTitle.Name = "WhiteBoxTesterTitle";
            this.WhiteBoxTesterTitle.Size = new System.Drawing.Size(404, 45);
            this.WhiteBoxTesterTitle.TabIndex = 3;
            this.WhiteBoxTesterTitle.Text = "White Box Tester";
            this.WhiteBoxTesterTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WhiteBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.WhiteBoxTesterTitle);
            this.Name = "WhiteBoxTester";
            this.Text = "WhiteBoxTester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WhiteBoxTester_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhiteBoxTesterTitle;
    }
}