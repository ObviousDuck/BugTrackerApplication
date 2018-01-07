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
            this.components = new System.ComponentModel.Container();
            this.TesterBtn = new System.Windows.Forms.Button();
            this.BugTrackerTitle = new System.Windows.Forms.Label();
            this.TesterDeveloperBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportBugButton = new System.Windows.Forms.Button();
            this.FindBugButton = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TesterBtn
            // 
            this.TesterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterBtn.Location = new System.Drawing.Point(66, 140);
            this.TesterBtn.Name = "TesterBtn";
            this.TesterBtn.Size = new System.Drawing.Size(181, 37);
            this.TesterBtn.TabIndex = 0;
            this.TesterBtn.Text = "Tester";
            this.TesterBtn.UseVisualStyleBackColor = true;
            this.TesterBtn.Click += new System.EventHandler(this.BlackBoxBtn_Click);
            // 
            // BugTrackerTitle
            // 
            this.BugTrackerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BugTrackerTitle.AutoSize = true;
            this.BugTrackerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.BugTrackerTitle.Location = new System.Drawing.Point(146, 33);
            this.BugTrackerTitle.Name = "BugTrackerTitle";
            this.BugTrackerTitle.Size = new System.Drawing.Size(236, 46);
            this.BugTrackerTitle.TabIndex = 1;
            this.BugTrackerTitle.Text = "BugTracker";
            this.BugTrackerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TesterDeveloperBtn
            // 
            this.TesterDeveloperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterDeveloperBtn.Location = new System.Drawing.Point(276, 140);
            this.TesterDeveloperBtn.Name = "TesterDeveloperBtn";
            this.TesterDeveloperBtn.Size = new System.Drawing.Size(181, 37);
            this.TesterDeveloperBtn.TabIndex = 2;
            this.TesterDeveloperBtn.Text = "Tester/Developer";
            this.TesterDeveloperBtn.UseVisualStyleBackColor = true;
            this.TesterDeveloperBtn.Click += new System.EventHandler(this.WhiteBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 93);
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
            this.label2.Location = new System.Drawing.Point(472, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "v 0.7";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "What would you like to do?";
            // 
            // ReportBugButton
            // 
            this.ReportBugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReportBugButton.Location = new System.Drawing.Point(278, 328);
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
            this.FindBugButton.Location = new System.Drawing.Point(278, 388);
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
            this.LoginBtn.Location = new System.Drawing.Point(68, 328);
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
            this.RegisterBtn.Location = new System.Drawing.Point(68, 388);
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
            this.label4.Location = new System.Drawing.Point(64, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "You have selected:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(214, 204);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(59, 20);
            this.RoleLabel.TabIndex = 12;
            this.RoleLabel.Text = "No role";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "You are logged in as:";
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAsLabel.Location = new System.Drawing.Point(228, 233);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(60, 20);
            this.LoggedInAsLabel.TabIndex = 14;
            this.LoggedInAsLabel.Text = "No one";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // BugTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 487);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.FindBugButton);
            this.Controls.Add(this.ReportBugButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TesterDeveloperBtn);
            this.Controls.Add(this.BugTrackerTitle);
            this.Controls.Add(this.TesterBtn);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BugTracker";
            this.Text = "BugTracker";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BugTrackerTitle;
        public System.Windows.Forms.Button TesterBtn;
        public System.Windows.Forms.Button TesterDeveloperBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReportBugButton;
        private System.Windows.Forms.Button FindBugButton;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

