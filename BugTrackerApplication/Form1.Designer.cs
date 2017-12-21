namespace BugTrackerApplication
{
    partial class Form1
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
            this.TesterBtn = new System.Windows.Forms.Button();
            this.BugTrackerTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TesterBtn
            // 
            this.TesterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TesterBtn.Location = new System.Drawing.Point(162, 109);
            this.TesterBtn.Name = "TesterBtn";
            this.TesterBtn.Size = new System.Drawing.Size(205, 37);
            this.TesterBtn.TabIndex = 0;
            this.TesterBtn.Text = "Black Box Tester";
            this.TesterBtn.UseVisualStyleBackColor = true;
            this.TesterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BugTrackerTitle
            // 
            this.BugTrackerTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BugTrackerTitle.AutoSize = true;
            this.BugTrackerTitle.Font = new System.Drawing.Font("Prestige Elite Std", 30F, System.Drawing.FontStyle.Bold);
            this.BugTrackerTitle.Location = new System.Drawing.Point(136, 9);
            this.BugTrackerTitle.Name = "BugTrackerTitle";
            this.BugTrackerTitle.Size = new System.Drawing.Size(260, 45);
            this.BugTrackerTitle.TabIndex = 1;
            this.BugTrackerTitle.Text = "BugTracker";
            this.BugTrackerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BugTrackerTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "White Box Tester";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(162, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Programmer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please select your role";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prestige Elite Std", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(477, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "v 0.1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BugTrackerTitle);
            this.Controls.Add(this.TesterBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TesterBtn;
        private System.Windows.Forms.Label BugTrackerTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

