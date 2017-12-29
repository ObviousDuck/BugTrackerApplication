namespace BugTrackerApplication
{
    partial class BugTracker
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
            this.BlackBoxBtn = new System.Windows.Forms.Button();
            this.BugTrackerTitle = new System.Windows.Forms.Label();
            this.WhiteBoxBtn = new System.Windows.Forms.Button();
            this.DeveloperBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportBugButton = new System.Windows.Forms.Button();
            this.FindBugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlackBoxBtn
            // 
            this.BlackBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackBoxBtn.Location = new System.Drawing.Point(53, 109);
            this.BlackBoxBtn.Name = "BlackBoxBtn";
            this.BlackBoxBtn.Size = new System.Drawing.Size(181, 37);
            this.BlackBoxBtn.TabIndex = 0;
            this.BlackBoxBtn.Text = "Black Box Tester";
            this.BlackBoxBtn.UseVisualStyleBackColor = true;
            this.BlackBoxBtn.Click += new System.EventHandler(this.BlackBoxBtn_Click);
            // 
            // BugTrackerTitle
            // 
            this.BugTrackerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BugTrackerTitle.AutoSize = true;
            this.BugTrackerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.BugTrackerTitle.Location = new System.Drawing.Point(222, 9);
            this.BugTrackerTitle.Name = "BugTrackerTitle";
            this.BugTrackerTitle.Size = new System.Drawing.Size(236, 46);
            this.BugTrackerTitle.TabIndex = 1;
            this.BugTrackerTitle.Text = "BugTracker";
            this.BugTrackerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WhiteBoxBtn
            // 
            this.WhiteBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteBoxBtn.Location = new System.Drawing.Point(254, 109);
            this.WhiteBoxBtn.Name = "WhiteBoxBtn";
            this.WhiteBoxBtn.Size = new System.Drawing.Size(181, 37);
            this.WhiteBoxBtn.TabIndex = 2;
            this.WhiteBoxBtn.Text = "White Box Tester";
            this.WhiteBoxBtn.UseVisualStyleBackColor = true;
            this.WhiteBoxBtn.Click += new System.EventHandler(this.WhiteBoxBtn_Click);
            // 
            // DeveloperBtn
            // 
            this.DeveloperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeveloperBtn.Location = new System.Drawing.Point(458, 109);
            this.DeveloperBtn.Name = "DeveloperBtn";
            this.DeveloperBtn.Size = new System.Drawing.Size(181, 37);
            this.DeveloperBtn.TabIndex = 3;
            this.DeveloperBtn.Text = "Developer";
            this.DeveloperBtn.UseVisualStyleBackColor = true;
            this.DeveloperBtn.Click += new System.EventHandler(this.DeveloperBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select your role";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(635, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "v 0.2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "What would you like to do?";
            // 
            // ReportBugButton
            // 
            this.ReportBugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReportBugButton.Location = new System.Drawing.Point(152, 218);
            this.ReportBugButton.Name = "ReportBugButton";
            this.ReportBugButton.Size = new System.Drawing.Size(181, 37);
            this.ReportBugButton.TabIndex = 7;
            this.ReportBugButton.Text = "Report a bug";
            this.ReportBugButton.UseVisualStyleBackColor = true;
            this.ReportBugButton.Click += new System.EventHandler(this.ReportBugButton_Click);
            // 
            // FindBugButton
            // 
            this.FindBugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FindBugButton.Location = new System.Drawing.Point(362, 218);
            this.FindBugButton.Name = "FindBugButton";
            this.FindBugButton.Size = new System.Drawing.Size(181, 37);
            this.FindBugButton.TabIndex = 8;
            this.FindBugButton.Text = "Find a bug";
            this.FindBugButton.UseVisualStyleBackColor = true;
            this.FindBugButton.Click += new System.EventHandler(this.FindBugButton_Click);
            // 
            // BugTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 300);
            this.Controls.Add(this.FindBugButton);
            this.Controls.Add(this.ReportBugButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeveloperBtn);
            this.Controls.Add(this.WhiteBoxBtn);
            this.Controls.Add(this.BugTrackerTitle);
            this.Controls.Add(this.BlackBoxBtn);
            this.Name = "BugTracker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BugTrackerTitle;
        public System.Windows.Forms.Button BlackBoxBtn;
        public System.Windows.Forms.Button WhiteBoxBtn;
        public System.Windows.Forms.Button DeveloperBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReportBugButton;
        private System.Windows.Forms.Button FindBugButton;
    }
}

