﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorCode;
using System.IO;
using System.Data.SqlClient;

namespace BugTrackerApplication
{
    public partial class WhiteBoxReportBug : Form
    {
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd;

        public WhiteBoxReportBug()
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3439024\Documents\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;
            try
            {
                if (
                string.IsNullOrEmpty(TesterTxtBox.Text) ||
                string.IsNullOrEmpty(ProjectTxtBox.Text) ||
                string.IsNullOrEmpty(SummaryTxtBox.Text) ||
                string.IsNullOrEmpty(ClassTxtBox.Text) ||
                string.IsNullOrEmpty(MethodTxtBox.Text) ||
                string.IsNullOrEmpty(LineNumberTxtBox.Text) ||
                string.IsNullOrEmpty(DescriptionTxtBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields before submitting the bug report.");
                    rtnvalue = false;
                }

                else
                {
                    cmd = "INSERT INTO Bugs (DateLogged, TesterName, Project, Component, Summary, Dependencies, AssignedTo, TimeToFix, Class, Method, LineNumber, CodeSnippet, Description) VALUES ('"
                        + DateTime.Now.ToString("dd-MM-yy HH:mm") + "', '" + TesterTxtBox.Text.ToString() + "' ,'" + ProjectTxtBox.Text.ToString() + "' ,'" + ComponentTxtBox.Text.ToString() +
                        "' ,'" + SummaryTxtBox.Text.ToString() + "' ,'" + DependenciesTxtBox.Text.ToString() + "' ,'" + AssignToTxtBox.Text.ToString() + "' ,'" + EtaTxtBox.Text +
                        "' ,'" + ClassTxtBox.Text.ToString() + "' ,'" + MethodTxtBox.Text.ToString() + "' ,'" + LineNumberTxtBox.Text + "' ,'" + CodeSnippetTxtBox.Text.ToString() +
                        "' ,'" + DescriptionTxtBox.Text.ToString() + "')";

                    mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    MessageBox.Show("Bug successfully logged!");
                    
                    ClearTxtBoxes(this.Controls);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (rtnvalue);
        }

        public void ClearTxtBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTxtBoxes(ctrl.Controls);
            }
        }

        private void WhiteBoxTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as BugTracker).BlackBoxBtn.Enabled = true;
            (this.Owner as BugTracker).WhiteBoxBtn.Enabled = true;
            (this.Owner as BugTracker).DeveloperBtn.Enabled = true;
            mySqlConnection.Close();
        }
        /// <summary>
        /// Some code that does things
        /// </summary>
        public void ColourizeCode()
        {
            string colourizedSourceCode = new CodeColorizer().Colorize(CodeSnippetTxtBox.Text, Languages.CSharp);
            CodeSnippetTxtBox.Text = colourizedSourceCode;

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            System.IO.File.WriteAllText(@"C:\Users\c3439024\Documents\FormattedCode.html", html);
        }

        private void uploadCode_Click(object sender, EventArgs e)
        {
            ColourizeCode();
        }

        private void UploadAttachmentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog attachment = new OpenFileDialog();
            attachment.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (attachment.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    AttachmentTxtBox.Text = attachment.FileName;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
            }
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void WhiteBoxReportBug_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter3.Fill(this.testerName.Users);
            this.usersTableAdapter4.Fill(this.assignedTo.Users);   
        }
    }
}
