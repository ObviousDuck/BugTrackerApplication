using System;
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
    public partial class TesterDeveloperReportBug : Form
    {
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd;
        BugTracker BugTracker;

        public TesterDeveloperReportBug(BugTracker BugTracker)
        {
            InitializeComponent();
            //string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BugTrackerDB.mdf;Integrated Security=True";
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\BugTrackerApplication\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();

            try
            {
                cmd = "SELECT Name FROM Users";
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                TesterTxtBox.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    TesterTxtBox.Items.Add(mySqlDataReader["Name"]);
                    AssignToTxtBox.Items.Add(mySqlDataReader["Name"]);
                }
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            mySqlConnection.Close();
            BugTracker.Show();
        }
        /// <summary>
        /// Some code that does things
        /// </summary>
        public void ColourizeCode()
        {
            string colourizedSourceCode = new CodeColorizer().Colorize(CodeSnippetTxtBox.Text, Languages.CSharp);
            CodeSnippetTxtBox.Text = colourizedSourceCode;

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            File.WriteAllText(@"C:\Users\c3439024\Documents\FormattedCode.html", html);
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
            // TODO: This line of code loads data into the 'assignedToName.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.assignedToName.Users);
            // TODO: This line of code loads data into the 'testerName.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.testerName.Users);
        }
    }
}
