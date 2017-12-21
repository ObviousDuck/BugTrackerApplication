namespace BugTrackerApplication
{
    partial class Programmer
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
            this.ProgrammerTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgrammerTitle
            // 
            this.ProgrammerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgrammerTitle.AutoSize = true;
            this.ProgrammerTitle.Font = new System.Drawing.Font("Prestige Elite Std", 30F, System.Drawing.FontStyle.Bold);
            this.ProgrammerTitle.Location = new System.Drawing.Point(240, 27);
            this.ProgrammerTitle.Name = "ProgrammerTitle";
            this.ProgrammerTitle.Size = new System.Drawing.Size(260, 45);
            this.ProgrammerTitle.TabIndex = 3;
            this.ProgrammerTitle.Text = "Programmer";
            this.ProgrammerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProgrammerTitle.Click += new System.EventHandler(this.ProgrammerTitle_Click);
            // 
            // Programmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.ProgrammerTitle);
            this.Name = "Programmer";
            this.Text = "Programmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgrammerTitle;
    }
}