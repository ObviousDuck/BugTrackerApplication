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
            this.ProgrammerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BlackBoxBtn
            // 
            this.BlackBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackBoxBtn.Location = new System.Drawing.Point(162, 109);
            this.BlackBoxBtn.Name = "BlackBoxBtn";
            this.BlackBoxBtn.Size = new System.Drawing.Size(205, 37);
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
            this.BugTrackerTitle.Location = new System.Drawing.Point(149, 9);
            this.BugTrackerTitle.Name = "BugTrackerTitle";
            this.BugTrackerTitle.Size = new System.Drawing.Size(236, 46);
            this.BugTrackerTitle.TabIndex = 1;
            this.BugTrackerTitle.Text = "BugTracker";
            this.BugTrackerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WhiteBoxBtn
            // 
            this.WhiteBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteBoxBtn.Location = new System.Drawing.Point(162, 164);
            this.WhiteBoxBtn.Name = "WhiteBoxBtn";
            this.WhiteBoxBtn.Size = new System.Drawing.Size(205, 37);
            this.WhiteBoxBtn.TabIndex = 2;
            this.WhiteBoxBtn.Text = "White Box Tester";
            this.WhiteBoxBtn.UseVisualStyleBackColor = true;
            this.WhiteBoxBtn.Click += new System.EventHandler(this.WhiteBoxBtn_Click);
            // 
            // ProgrammerBtn
            // 
            this.ProgrammerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerBtn.Location = new System.Drawing.Point(162, 219);
            this.ProgrammerBtn.Name = "ProgrammerBtn";
            this.ProgrammerBtn.Size = new System.Drawing.Size(205, 37);
            this.ProgrammerBtn.TabIndex = 3;
            this.ProgrammerBtn.Text = "Programmer";
            this.ProgrammerBtn.UseVisualStyleBackColor = true;
            this.ProgrammerBtn.Click += new System.EventHandler(this.ProgrammerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 72);
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
            this.label2.Location = new System.Drawing.Point(477, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "v 0.1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BugTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgrammerBtn);
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
        public System.Windows.Forms.Button ProgrammerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

