namespace BugTrackerApplication
{
    partial class DeveloperReportBug
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
            this.CodeSnippetTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TesterTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgrammerTitle
            // 
            this.ProgrammerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgrammerTitle.AutoSize = true;
            this.ProgrammerTitle.Font = new System.Drawing.Font("Prestige Elite Std", 30F, System.Drawing.FontStyle.Bold);
            this.ProgrammerTitle.Location = new System.Drawing.Point(248, 20);
            this.ProgrammerTitle.Name = "ProgrammerTitle";
            this.ProgrammerTitle.Size = new System.Drawing.Size(236, 45);
            this.ProgrammerTitle.TabIndex = 3;
            this.ProgrammerTitle.Text = "Developer";
            this.ProgrammerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CodeSnippetTxtBox
            // 
            this.CodeSnippetTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CodeSnippetTxtBox.Location = new System.Drawing.Point(145, 204);
            this.CodeSnippetTxtBox.Multiline = true;
            this.CodeSnippetTxtBox.Name = "CodeSnippetTxtBox";
            this.CodeSnippetTxtBox.Size = new System.Drawing.Size(450, 310);
            this.CodeSnippetTxtBox.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(248, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "Retrieve Code";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TesterTxtBox
            // 
            this.TesterTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TesterTxtBox.Location = new System.Drawing.Point(331, 133);
            this.TesterTxtBox.Name = "TesterTxtBox";
            this.TesterTxtBox.Size = new System.Drawing.Size(71, 23);
            this.TesterTxtBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Bug ID:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(369, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 53;
            this.button2.Text = "View in HTML";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DeveloperReportBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 750);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TesterTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodeSnippetTxtBox);
            this.Controls.Add(this.ProgrammerTitle);
            this.Name = "DeveloperReportBug";
            this.Text = "Programmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Developer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgrammerTitle;
        private System.Windows.Forms.TextBox CodeSnippetTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TesterTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}