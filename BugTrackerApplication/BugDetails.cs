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
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd, id, testerName;
        TesterDeveloperViewBug ViewBug;

        public BugDetails(String id, String testerName, TesterDeveloperViewBug ViewBug)
        {
            InitializeComponent();
            this.id = id;
            this.testerName = testerName;
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\BugTrackerApplication\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            this.ViewBug = ViewBug;
            ViewBug.Hide();
            LoadBug();
            LoadComments();
        }

        public void LoadBug()
        {
            try
            {
                cmd = "SELECT * FROM Bugs WHERE ID=" + id;
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();

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
                    txtSourceCode.Text = (string)mySqlDataReader["CodeSnippet"];
                }
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadComments()
        {
            try
            {

                cmd = "SELECT * FROM Comments WHERE BugId=" + id;
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                string rtfString = "\\rtf1\\pc";
                mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    rtfString += "\\b TESTER:\\b0  " + mySqlDataReader["Author"] + "\\par\\b DATE LOGGED:\\b0  " + mySqlDataReader["DateLogged"] + "\\par\\b COMMENT:\\b0\\par " + mySqlDataReader["Comment"] + "\\par\\par";
                }
                txtComments.Rtf = @"{" + rtfString + "}";
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddCommment()
        {
            try
            {
                cmd = "INSERT INTO Comments (DateLogged, Author, Comment, BugId) VALUES ('"
                    + DateTime.Now.ToString("dd-MM-yy HH:mm") + "', '" +  testerName + "', '" + txtAddComment.Text.ToString() + "', '" + id + "')";

                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Close();

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateCode()
        {
            try
            {
                cmd = "UPDATE Bugs SET CodeSnippet = @codesnippet WHERE Id =" + id;
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@codesnippet", txtSourceCode.Text);
                mySqlCommand.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            
            String html = ("<!doctype html><head><meta charset=\"utf-8\"</head><body>" + colourizedSource + "</body></html>");
            System.IO.File.WriteAllText(@path, html);
            MessageBox.Show("File Written to " + path, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            Uri uri = new Uri(path);
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

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            //UpdateComment();
            AddCommment();
            LoadBug();
            LoadComments();
            txtAddComment.Text = "";
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Bugs SET isArchived=1 WHERE Id=" + id, mySqlConnection);
            cmd.ExecuteNonQuery();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UpdateCode();
            LoadBug();
        }
    }
}
