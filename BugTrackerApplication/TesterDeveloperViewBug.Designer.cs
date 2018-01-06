namespace BugTrackerApplication
{
    partial class TesterDeveloperViewBug
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTesterBox = new System.Windows.Forms.ComboBox();
            this.txtAssignedTo = new System.Windows.Forms.ComboBox();
            this.ListBoxBugs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BlackBoxTesterTitle
            // 
            this.BlackBoxTesterTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BlackBoxTesterTitle.AutoSize = true;
            this.BlackBoxTesterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.BlackBoxTesterTitle.Location = new System.Drawing.Point(12, 21);
            this.BlackBoxTesterTitle.Name = "BlackBoxTesterTitle";
            this.BlackBoxTesterTitle.Size = new System.Drawing.Size(151, 31);
            this.BlackBoxTesterTitle.TabIndex = 32;
            this.BlackBoxTesterTitle.Text = "Find a bug";
            this.BlackBoxTesterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tester:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Bug ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Assigned to:";
            // 
            // txtBugID
            // 
            this.txtBugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBugID.Location = new System.Drawing.Point(123, 67);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(183, 23);
            this.txtBugID.TabIndex = 55;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch.Location = new System.Drawing.Point(123, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 36);
            this.btnSearch.TabIndex = 58;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(355, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 31);
            this.label5.TabIndex = 60;
            this.label5.Text = "List of Bugs";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnViewDetails.Location = new System.Drawing.Point(443, 492);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(183, 36);
            this.btnViewDetails.TabIndex = 61;
            this.btnViewDetails.Text = "View details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProject.Location = new System.Drawing.Point(123, 139);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(183, 23);
            this.txtProject.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(54, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Project:";
            // 
            // txtTesterBox
            // 
            this.txtTesterBox.FormattingEnabled = true;
            this.txtTesterBox.Location = new System.Drawing.Point(123, 103);
            this.txtTesterBox.MaxDropDownItems = 100;
            this.txtTesterBox.Name = "txtTesterBox";
            this.txtTesterBox.Size = new System.Drawing.Size(183, 21);
            this.txtTesterBox.TabIndex = 64;
            // 
            // txtAssignedTo
            // 
            this.txtAssignedTo.FormattingEnabled = true;
            this.txtAssignedTo.Location = new System.Drawing.Point(123, 179);
            this.txtAssignedTo.Name = "txtAssignedTo";
            this.txtAssignedTo.Size = new System.Drawing.Size(183, 21);
            this.txtAssignedTo.TabIndex = 65;
            // 
            // ListBoxBugs
            // 
            this.ListBoxBugs.FormattingEnabled = true;
            this.ListBoxBugs.Location = new System.Drawing.Point(361, 67);
            this.ListBoxBugs.Name = "ListBoxBugs";
            this.ListBoxBugs.Size = new System.Drawing.Size(629, 407);
            this.ListBoxBugs.TabIndex = 66;
            // 
            // TesterDeveloperViewBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 555);
            this.Controls.Add(this.ListBoxBugs);
            this.Controls.Add(this.txtAssignedTo);
            this.Controls.Add(this.txtTesterBox);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlackBoxTesterTitle);
            this.Name = "TesterDeveloperViewBug";
            this.Text = "DeveloperViewBug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TesterDeveloperViewBug_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlackBoxTesterTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtTesterBox;
        private System.Windows.Forms.ComboBox txtAssignedTo;
        private System.Windows.Forms.ListBox ListBoxBugs;
    }
}