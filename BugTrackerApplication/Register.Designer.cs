namespace BugTrackerApplication
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Register new user";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RegisterButton.Location = new System.Drawing.Point(111, 175);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(85, 36);
            this.RegisterButton.TabIndex = 23;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(114, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password:";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PasswordTxtBox.Location = new System.Drawing.Point(67, 132);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(176, 23);
            this.PasswordTxtBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(114, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username:";
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsernameTxtBox.Location = new System.Drawing.Point(67, 76);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(176, 23);
            this.UsernameTxtBox.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 227);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxtBox;
    }
}