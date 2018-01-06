namespace BugTrackerApplication
{
    partial class BugDetails
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
            this.txtBugDetails = new System.Windows.Forms.RichTextBox();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnViewSyntaxedCode = new System.Windows.Forms.Button();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.radioCSharp = new System.Windows.Forms.RadioButton();
            this.radioHTML = new System.Windows.Forms.RadioButton();
            this.radioJava = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BlackBoxTesterTitle
            // 
            this.BlackBoxTesterTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BlackBoxTesterTitle.AutoSize = true;
            this.BlackBoxTesterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.BlackBoxTesterTitle.Location = new System.Drawing.Point(23, 19);
            this.BlackBoxTesterTitle.Name = "BlackBoxTesterTitle";
            this.BlackBoxTesterTitle.Size = new System.Drawing.Size(164, 31);
            this.BlackBoxTesterTitle.TabIndex = 33;
            this.BlackBoxTesterTitle.Text = "Bug Details";
            this.BlackBoxTesterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBugDetails
            // 
            this.txtBugDetails.Location = new System.Drawing.Point(29, 67);
            this.txtBugDetails.Name = "txtBugDetails";
            this.txtBugDetails.Size = new System.Drawing.Size(366, 310);
            this.txtBugDetails.TabIndex = 34;
            this.txtBugDetails.Text = "";
            // 
            // btnArchive
            // 
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnArchive.Location = new System.Drawing.Point(29, 576);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(118, 36);
            this.btnArchive.TabIndex = 59;
            this.btnArchive.Text = "Archive Bug";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSaveChanges.Location = new System.Drawing.Point(540, 600);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(118, 36);
            this.btnSaveChanges.TabIndex = 60;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(29, 395);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(366, 133);
            this.txtComment.TabIndex = 62;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAddComment.Location = new System.Drawing.Point(29, 534);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(118, 36);
            this.btnAddComment.TabIndex = 63;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnViewSyntaxedCode
            // 
            this.btnViewSyntaxedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnViewSyntaxedCode.Location = new System.Drawing.Point(416, 600);
            this.btnViewSyntaxedCode.Name = "btnViewSyntaxedCode";
            this.btnViewSyntaxedCode.Size = new System.Drawing.Size(118, 36);
            this.btnViewSyntaxedCode.TabIndex = 66;
            this.btnViewSyntaxedCode.Text = "Format Code";
            this.btnViewSyntaxedCode.UseVisualStyleBackColor = true;
            this.btnViewSyntaxedCode.Click += new System.EventHandler(this.btnViewSyntaxedCode_Click);
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Location = new System.Drawing.Point(416, 67);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.Size = new System.Drawing.Size(480, 461);
            this.txtSourceCode.TabIndex = 67;
            // 
            // radioCSharp
            // 
            this.radioCSharp.AutoSize = true;
            this.radioCSharp.Checked = true;
            this.radioCSharp.Location = new System.Drawing.Point(419, 567);
            this.radioCSharp.Name = "radioCSharp";
            this.radioCSharp.Size = new System.Drawing.Size(39, 17);
            this.radioCSharp.TabIndex = 68;
            this.radioCSharp.TabStop = true;
            this.radioCSharp.Text = "C#";
            this.radioCSharp.UseVisualStyleBackColor = true;
            // 
            // radioHTML
            // 
            this.radioHTML.AutoSize = true;
            this.radioHTML.Location = new System.Drawing.Point(464, 567);
            this.radioHTML.Name = "radioHTML";
            this.radioHTML.Size = new System.Drawing.Size(55, 17);
            this.radioHTML.TabIndex = 69;
            this.radioHTML.Text = "HTML";
            this.radioHTML.UseVisualStyleBackColor = true;
            // 
            // radioJava
            // 
            this.radioJava.AutoSize = true;
            this.radioJava.Location = new System.Drawing.Point(525, 567);
            this.radioJava.Name = "radioJava";
            this.radioJava.Size = new System.Drawing.Size(48, 17);
            this.radioJava.TabIndex = 70;
            this.radioJava.Text = "Java";
            this.radioJava.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Please select the language used:";
            // 
            // BugDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioJava);
            this.Controls.Add(this.radioHTML);
            this.Controls.Add(this.radioCSharp);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.btnViewSyntaxedCode);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.txtBugDetails);
            this.Controls.Add(this.BlackBoxTesterTitle);
            this.Name = "BugDetails";
            this.Text = "Bug Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BugDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlackBoxTesterTitle;
        private System.Windows.Forms.RichTextBox txtBugDetails;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnViewSyntaxedCode;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.RadioButton radioCSharp;
        private System.Windows.Forms.RadioButton radioHTML;
        private System.Windows.Forms.RadioButton radioJava;
        private System.Windows.Forms.Label label1;
    }
}