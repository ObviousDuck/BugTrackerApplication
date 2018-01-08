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
    public partial class BugDetails : Form
    {
        // Declare variables
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd, id, testerName;
        TesterDeveloperViewBug ViewBug;

        /// <summary>
        /// Initializes the components and establishes connection to database and opens it.
        /// Hides the previous menu. Calls methods.
        /// </summary>
        /// <param name="BugTracker"></param>
        public BugDetails(String id, String testerName, TesterDeveloperViewBug ViewBug)
        {
            InitializeComponent();
            this.id = id;
            this.testerName = testerName;
            mySqlConnection = new SqlConnection(EstablishConnection.SqlConnection);
            mySqlConnection.Open();
            this.ViewBug = ViewBug;
            ViewBug.Hide();
            LoadBug();
            LoadComments();
        }

        /// <summary>
        /// Loads up the details of a bug from the database and formats it to a RichTextBox.
        /// </summary>
        public void LoadBug()
        {
            try
            {
                cmd = "SELECT * FROM Bugs WHERE ID=" + id;
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();

                // While data reader is open, add data columns to string.
                while (mySqlDataReader.Read())
                {
                    string bugDetails =
                        "\\rtf1\\pc\\b ID: \\par\\b0 " + mySqlDataReader["Id"] + "\\par\\par" +
                        "\\b DATE LOGGED \\par\\b0 " + mySqlDataReader["DateLogged"] + "\\par\\par" +
                        "\\b TESTER NAME: \\par\\b0 " + mySqlDataReader["TesterName"] + "\\par\\par" +
                        "\\b PROJECT: \\par\\b0 " + mySqlDataReader["Project"] + "\\par\\par" +
                        "\\b COMPONENT: \\par\\b0 " + mySqlDataReader["Component"] + "\\par\\par" +
                        "\\b SUMMARY: \\par\\b0 " + mySqlDataReader["Summary"] + "\\par\\par" +
                        "\\b DEPENDENCIES: \\par\\b0 " + mySqlDataReader["Dependencies"] + "\\par\\par" +
                        "\\b ASSIGNED TO: \\par\\b0 " + mySqlDataReader["AssignedTo"] + "\\par\\par" +
                        "\\b TIME TO FIX IN HOURS: \\par\\b0 " + mySqlDataReader["TimeToFix"] + "\\par\\par" +
                        "\\b CLASS: \\par\\b0 " + mySqlDataReader["Class"] + "\\par\\par" +
                        "\\b METHOD: \\par\\b0 " + mySqlDataReader["Method"] + "\\par\\par" +
                        "\\b LINE NUMBER: \\par\\b0 " + mySqlDataReader["LineNumber"] + "\\par\\par" +
                        "\\b DESCRIPTION: \\par\\b0 " + mySqlDataReader["Description"] + "\\par\\par";

                    txtBugDetails.Rtf = @"{" + bugDetails + "}";

                    
                    // Puts CodeSnippet into its own separate textbox if available.
                    if (!string.IsNullOrEmpty(txtSourceCode.Text))
                    {
                        //txtSourceCode.Text = (String)mySqlDataReader["CodeSnippet"];
                        String intermediate = (String)mySqlDataReader["CodeSnippet"];
                        txtSourceCode.Text = intermediate;
                    }
                    else
                    {
                        MessageBox.Show("Please enter the source code!"); 
                    }
                }

                // Closes the data reader
                mySqlDataReader.Close();
            }
            // Throws SqlException if above fails and puts error in MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public void LoadBugCodeSnippet()
        //{
        //    cmd = "SELECT * FROM Bugs WHERE ID=" + id;
        //    mySqlCommand = new SqlCommand(cmd, mySqlConnection);
        //    mySqlDataReader = mySqlCommand.ExecuteReader();
        //}

           

        /// <summary>
        /// Loads up comments from the Comments table and outputs these to a textbox.
        /// </summary>
        public void LoadComments()
        {
            try
            {
                cmd = "SELECT * FROM Comments WHERE BugId=" + id;
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                string rtfString = "\\rtf1\\pc";
                mySqlDataReader = mySqlCommand.ExecuteReader();

                // While the data reader is open, populate text box with comments (formatted)
                while (mySqlDataReader.Read())
                {
                    rtfString += "\\b TESTER:\\b0  " + mySqlDataReader["Author"] + "\\par\\b DATE LOGGED:\\b0  " + mySqlDataReader["DateLogged"] + "\\par\\b COMMENT:\\b0\\par " + mySqlDataReader["Comment"] + "\\par\\par";
                }
                txtComments.Rtf = @"{" + rtfString + "}";
                mySqlDataReader.Close();
            }

            // Throws SqlException if above fails and puts error in MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adds new comments to the Comments table
        /// </summary>
        public void AddCommment()
        {
            try
            {
                // Insert new comment into database along with a timestamp and the name of the tester, passed from the Login form.
                cmd = "INSERT INTO Comments (DateLogged, Author, Comment, BugId) VALUES ('"
                    + DateTime.Now.ToString("dd-MM-yy HH:mm") + "', '" +  testerName + "', '" + txtAddComment.Text.ToString() + "', '" + id + "')";

                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Close();
            }

            // Throws SqlException if above fails and puts error in MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the code snippet when edited.
        /// </summary>
        public void UpdateCode()
        {
            try
            {
                cmd = "UPDATE Bugs SET CodeSnippet = @codesnippet WHERE Id =" + id;
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@codesnippet", txtSourceCode.Text);
                mySqlCommand.ExecuteNonQuery();
            }

            // Throws SqlException if above fails and puts error in MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Formats the code with proper syntax colours according to user selection of Programming Language and
        /// outputs it to the SyntaxedCode class which has a Web Browser that can display it. 
        /// Furthermore, writes the formatted code to an .html file.
        /// </summary>
        public void ColourizeCode()
        {
            String colourizedSource;
            String path = Application.StartupPath + "\\FormattedCode.html";

            if (radioCSharp.Checked)
            {
                colourizedSource = new CodeColorizer().Colorize(txtSourceCode.Text, Languages.CSharp);
            }
            else if (radioHTML.Checked)
            {
                colourizedSource = new CodeColorizer().Colorize(txtSourceCode.Text, Languages.Html);
            }
            else
            {
                colourizedSource = new CodeColorizer().Colorize(txtSourceCode.Text, Languages.Java);
            }
            
            // Wrap the code in HTML.
            String html = ("<!doctype html><head><meta charset=\"utf-8\"</head><body>" + colourizedSource + "</body></html>");
            System.IO.File.WriteAllText(@path, html);
            MessageBox.Show("File Written to " + path, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            Uri uri = new Uri(path);

            // Opens up the code in the SyntaxedCode class and displays it formatted.
            SyntaxedCode formattedCode = new SyntaxedCode(uri);
            formattedCode.Show();
        }

        private void BugDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            ViewBug.Show();
        }

        private void btnViewSyntaxedCode_Click(object sender, EventArgs e)
        {
            ColourizeCode();
        }

        /// <summary>
        /// Adds a comment on button click and immediately clears the textbox and returns 
        /// the bug details again with the new comment.
        /// </summary>
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddComment.Text))
            {
                AddCommment();
                LoadBug();
                LoadComments();
                txtAddComment.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a comment!");
            }
        }

        /// <summary>
        /// Archives bugs by setting a isArchived flag in the Table. Archived bugs can be filtered
        /// in the Find Bug menu.
        /// </summary>
        private void btnArchive_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Bugs SET isArchived=1 WHERE Id=" + id, mySqlConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bug archived!");
        }

        // Saves any changes to codes and reloads the bug information.
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UpdateCode();
            LoadBug();
            MessageBox.Show("Code updated!");
        }
    }
}
