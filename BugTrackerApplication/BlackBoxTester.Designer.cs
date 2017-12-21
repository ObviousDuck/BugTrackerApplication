namespace BugTrackerApplication
{
    partial class BlackBoxTester
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
            this.BlackBoxTesterTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BlackBoxTesterTitle
            // 
            this.BlackBoxTesterTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BlackBoxTesterTitle.AutoSize = true;
            this.BlackBoxTesterTitle.Font = new System.Drawing.Font("Prestige Elite Std", 30F, System.Drawing.FontStyle.Bold);
            this.BlackBoxTesterTitle.Location = new System.Drawing.Point(165, 27);
            this.BlackBoxTesterTitle.Name = "BlackBoxTesterTitle";
            this.BlackBoxTesterTitle.Size = new System.Drawing.Size(404, 45);
            this.BlackBoxTesterTitle.TabIndex = 2;
            this.BlackBoxTesterTitle.Text = "Black Box Tester";
            this.BlackBoxTesterTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BlackBoxTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.BlackBoxTesterTitle);
            this.Name = "BlackBoxTester";
            this.Text = "BlackBoxTester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackBoxTester_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlackBoxTesterTitle;
    }
}