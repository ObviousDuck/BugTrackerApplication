namespace BugTrackerApplication
{
    partial class SyntaxedCode
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
            this.browserSyntaxedCode = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // browserSyntaxedCode
            // 
            this.browserSyntaxedCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserSyntaxedCode.Location = new System.Drawing.Point(0, 0);
            this.browserSyntaxedCode.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserSyntaxedCode.Name = "browserSyntaxedCode";
            this.browserSyntaxedCode.Size = new System.Drawing.Size(882, 677);
            this.browserSyntaxedCode.TabIndex = 0;
            // 
            // SyntaxedCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 677);
            this.Controls.Add(this.browserSyntaxedCode);
            this.Name = "SyntaxedCode";
            this.Text = "Syntaxed Code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browserSyntaxedCode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}