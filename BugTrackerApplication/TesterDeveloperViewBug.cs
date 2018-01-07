﻿using System;
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
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd, testerName;
        BugTracker BugTracker;
        public TesterDeveloperViewBug(BugTracker BugTracker, String testerName)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\BugTrackerApplication\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            this.testerName = testerName;
            BugTracker.Hide();

            try
            {
                cmd = "SELECT Name FROM Users";
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                txtTesterBox.Items.Clear();
                txtAssignedTo.Items.Add("");
                txtTesterBox.Items.Add("");
                while (mySqlDataReader.Read())
                {
                    txtTesterBox.Items.Add(mySqlDataReader["Name"]);
                    txtAssignedTo.Items.Add(mySqlDataReader["Name"]);
                }
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = "SELECT ID, TesterName, Project, Summary, AssignedTo FROM Bugs WHERE";
                if (!(string.IsNullOrEmpty(txtBugID.Text))) cmd += " ID=@ID AND ";
                if (!(string.IsNullOrEmpty(txtTesterBox.Text))) cmd += " TesterName=@TesterName AND ";
                if (!(string.IsNullOrEmpty(txtProject.Text))) cmd += " Project=@Project AND ";
                if (!(string.IsNullOrEmpty(txtAssignedTo.Text))) cmd += " AssignedTo=@AssignedTo AND ";
                if (checkboxShowArchived.Checked) cmd += " isArchived = 1 AND "; else cmd += " isArchived = 0 AND ";

                // Deletes the last 5 characters to avoid SQL syntax error with an empty AND on the end.
                cmd = cmd.Remove(cmd.Length - 5, 5);

                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@ID", txtBugID.Text);
                mySqlCommand.Parameters.AddWithValue("@TesterName", txtTesterBox.Text);
                mySqlCommand.Parameters.AddWithValue("@Project", txtProject.Text);
                mySqlCommand.Parameters.AddWithValue("@AssignedTo", txtAssignedTo.Text);

                ListBoxBugs.Items.Clear();
                mySqlDataReader = mySqlCommand.ExecuteReader();
                
                while (mySqlDataReader.Read())
                {
                    ListBoxBugs.Items.Add(
                        mySqlDataReader["ID"] + 
                        "- Project: " + mySqlDataReader["Project"] + 
                        " Summary: " + mySqlDataReader["Summary"]);
                }
                mySqlDataReader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ListBoxBugs.Text)))
            {
                String[] id = ListBoxBugs.Text.Split('-');
                BugDetails BugDetails = new BugDetails(id[0], BugTracker.LoggedInAsLabel.Text, this);
                BugDetails.Owner = this;
                BugDetails.Show();
            } else
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
