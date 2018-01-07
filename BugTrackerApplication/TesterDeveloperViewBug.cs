using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BugTrackerApplication
{
    public partial class TesterDeveloperViewBug : Form
    {
        // Declare variables
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd, testerName;
        BugTracker BugTracker;

        /// <summary>
        /// Initializes the components and establishes connection to database and opens it.
        /// Hides the main menu.
        /// </summary>
        /// <param name="BugTracker"></param>
        public TesterDeveloperViewBug(BugTracker BugTracker, String testerName)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(EstablishConnection.SqlConnection);
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            this.testerName = testerName;
            BugTracker.Hide();
            PopulateUserLists();
        }

        /// <summary>
        /// Populates the Tester drop down list. 
        /// </summary>
        public void PopulateUserLists()
        {
            try
            {
                cmd = "SELECT Name FROM Users";
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                txtTesterBox.Items.Clear();
                txtAssignedTo.Items.Add("");
                txtTesterBox.Items.Add("");

                // While the Data Reader is open, add items to the lists (Name)
                while (mySqlDataReader.Read())
                {
                    txtTesterBox.Items.Add(mySqlDataReader["Name"]);
                    txtAssignedTo.Items.Add(mySqlDataReader["Name"]);
                }
                mySqlDataReader.Close();
            }

            // Throw exception if the above block fails, and display error to MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Searches through the database with filters.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Sql command to search the Bugs table with possibility of appending filters depending on user selection.
                cmd = "SELECT ID, TesterName, Project, Summary, AssignedTo FROM Bugs WHERE";
                if (!(string.IsNullOrEmpty(txtBugID.Text))) cmd += " ID=@ID AND ";
                if (!(string.IsNullOrEmpty(txtTesterBox.Text))) cmd += " TesterName=@TesterName AND ";
                if (!(string.IsNullOrEmpty(txtProject.Text))) cmd += " Project=@Project AND ";
                if (!(string.IsNullOrEmpty(txtAssignedTo.Text))) cmd += " AssignedTo=@AssignedTo AND ";
                if (checkboxShowArchived.Checked) cmd += " isArchived = 1 AND "; else cmd += " isArchived = 0 AND ";

                // Deletes the last 5 characters to avoid SQL syntax error with an empty AND on the end.
                cmd = cmd.Remove(cmd.Length - 5, 5);

                // Sanitization of SQL. This way, if the user enters SQL keywords, 
                // they will be stored as literal strings and not be run as commands.
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@ID", txtBugID.Text);
                mySqlCommand.Parameters.AddWithValue("@TesterName", txtTesterBox.Text);
                mySqlCommand.Parameters.AddWithValue("@Project", txtProject.Text);
                mySqlCommand.Parameters.AddWithValue("@AssignedTo", txtAssignedTo.Text);

                // Clear ListBox
                ListBoxBugs.Items.Clear();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                
                // Add items to the ListBox but display only certain columns from the DB.
                while (mySqlDataReader.Read())
                {
                    ListBoxBugs.Items.Add(
                        mySqlDataReader["ID"] + 
                        "- Project: " + mySqlDataReader["Project"] + 
                        " Summary: " + mySqlDataReader["Summary"]);
                }

                // Close the data reader.
                mySqlDataReader.Close();
            }

            // Throws SqlException if above fails and puts error in MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Allows user to view more details about a selected bug.
        /// </summary>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // If user has selected something, find the details of the bug by it's ID (before the '-')
            // Open the BugDetails form and pass in the ID of the bug.
            if (!(string.IsNullOrEmpty(ListBoxBugs.Text)))
            {
                String[] id = ListBoxBugs.Text.Split('-');
                BugDetails BugDetails = new BugDetails(id[0], BugTracker.LoggedInAsLabel.Text, this);
                BugDetails.Owner = this;
                BugDetails.Show();
            }

            // If user has not selected a bug, prompt message.
            else
            {
                MessageBox.Show("Please select a bug from the list to view its details!");
            }
        }

        private void TesterDeveloperViewBug_FormClosing(object sender, FormClosingEventArgs e)
        {
            BugTracker.Show();
        }
    }
}
