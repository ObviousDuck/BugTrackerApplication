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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(635, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "v 0.5";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "What would you like to do?";
            // 
            // ReportBugButton
            // 
            this.ReportBugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReportBugButton.Location = new System.Drawing.Point(364, 277);
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
            this.FindBugButton.Location = new System.Drawing.Point(364, 337);
            this.FindBugButton.Name = "FindBugButton";
            this.FindBugButton.Size = new System.Drawing.Size(181, 37);
            this.FindBugButton.TabIndex = 8;
            this.FindBugButton.Text = "Find a bug";
            this.FindBugButton.UseVisualStyleBackColor = true;
            this.FindBugButton.Click += new System.EventHandler(this.FindBugButton_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoginBtn.Location = new System.Drawing.Point(154, 277);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(181, 37);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterBtn.Location = new System.Drawing.Point(154, 337);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(181, 37);
            this.RegisterBtn.TabIndex = 10;
            this.RegisterBtn.Text = "Register new user";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "You have selected:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(350, 188);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(59, 20);
            this.RoleLabel.TabIndex = 12;
            this.RoleLabel.Text = "No role";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BugTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 449);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
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
            this.Text = "BugTracker";
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
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RoleLabel;
    }
}

