namespace BugTrackerApplication
{
    partial class BlackBoxReportBug
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TesterTxtBox = new System.Windows.Forms.TextBox();
            this.ProjectTxtBox = new System.Windows.Forms.TextBox();
            this.ComponentTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.UploadAttachmentButton = new System.Windows.Forms.Button();
            this.ReportBugButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.SummaryTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AttachmentTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BlackBoxTesterTitle
            // 
            this.BlackBoxTesterTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BlackBoxTesterTitle.AutoSize = true;
            this.BlackBoxTesterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.BlackBoxTesterTitle.Location = new System.Drawing.Point(270, 22);
            this.BlackBoxTesterTitle.Name = "BlackBoxTesterTitle";
            this.BlackBoxTesterTitle.Size = new System.Drawing.Size(185, 31);
            this.BlackBoxTesterTitle.TabIndex = 2;
            this.BlackBoxTesterTitle.Text = "Report a Bug";
            this.BlackBoxTesterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(138, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tester:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Component:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description of bug:";
            // 
            // TesterTxtBox
            // 
            this.TesterTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TesterTxtBox.Location = new System.Drawing.Point(202, 84);
            this.TesterTxtBox.Name = "TesterTxtBox";
            this.TesterTxtBox.Size = new System.Drawing.Size(288, 23);
            this.TesterTxtBox.TabIndex = 0;
            // 
            // ProjectTxtBox
            // 
            this.ProjectTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProjectTxtBox.Location = new System.Drawing.Point(202, 122);
            this.ProjectTxtBox.Name = "ProjectTxtBox";
            this.ProjectTxtBox.Size = new System.Drawing.Size(288, 23);
            this.ProjectTxtBox.TabIndex = 1;
            // 
            // ComponentTxtBox
            // 
            this.ComponentTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ComponentTxtBox.Location = new System.Drawing.Point(202, 162);
            this.ComponentTxtBox.Name = "ComponentTxtBox";
            this.ComponentTxtBox.Size = new System.Drawing.Size(288, 23);
            this.ComponentTxtBox.TabIndex = 2;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DescriptionTxtBox.Location = new System.Drawing.Point(202, 242);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(437, 163);
            this.DescriptionTxtBox.TabIndex = 4;
            // 
            // UploadAttachmentButton
            // 
            this.UploadAttachmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UploadAttachmentButton.Location = new System.Drawing.Point(202, 456);
            this.UploadAttachmentButton.Name = "UploadAttachmentButton";
            this.UploadAttachmentButton.Size = new System.Drawing.Size(160, 36);
            this.UploadAttachmentButton.TabIndex = 5;
            this.UploadAttachmentButton.Text = "Upload Attachment";
            this.UploadAttachmentButton.UseVisualStyleBackColor = true;
            this.UploadAttachmentButton.Click += new System.EventHandler(this.UploadAttachmentButton_Click);
            // 
            // ReportBugButton
            // 
            this.ReportBugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ReportBugButton.Location = new System.Drawing.Point(202, 513);
            this.ReportBugButton.Name = "ReportBugButton";
            this.ReportBugButton.Size = new System.Drawing.Size(101, 36);
            this.ReportBugButton.TabIndex = 6;
            this.ReportBugButton.Text = "Report Bug";
            this.ReportBugButton.UseVisualStyleBackColor = true;
            this.ReportBugButton.Click += new System.EventHandler(this.ReportBugButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(126, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(122, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(44, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "*";
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryLabel.Location = new System.Drawing.Point(116, 201);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(80, 20);
            this.SummaryLabel.TabIndex = 12;
            this.SummaryLabel.Text = "Summary:";
            // 
            // SummaryTxtBox
            // 
            this.SummaryTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SummaryTxtBox.Location = new System.Drawing.Point(202, 201);
            this.SummaryTxtBox.Name = "SummaryTxtBox";
            this.SummaryTxtBox.Size = new System.Drawing.Size(288, 23);
            this.SummaryTxtBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(106, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            // 
            // AttachmentTxtBox
            // 
            this.AttachmentTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AttachmentTxtBox.Location = new System.Drawing.Point(202, 425);
            this.AttachmentTxtBox.Name = "AttachmentTxtBox";
            this.AttachmentTxtBox.Size = new System.Drawing.Size(288, 23);
            this.AttachmentTxtBox.TabIndex = 15;
            // 
            // BlackBoxReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 561);
            this.Controls.Add(this.AttachmentTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SummaryTxtBox);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReportBugButton);
            this.Controls.Add(this.UploadAttachmentButton);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.ComponentTxtBox);
            this.Controls.Add(this.ProjectTxtBox);
            this.Controls.Add(this.TesterTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlackBoxTesterTitle);
            this.Name = "BlackBoxReportBug";
            this.Text = "BlackBoxTester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackBoxReportBug_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlackBoxTesterTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TesterTxtBox;
        private System.Windows.Forms.TextBox ProjectTxtBox;
        private System.Windows.Forms.TextBox ComponentTxtBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.Button UploadAttachmentButton;
        private System.Windows.Forms.Button ReportBugButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.TextBox SummaryTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AttachmentTxtBox;
    }
}