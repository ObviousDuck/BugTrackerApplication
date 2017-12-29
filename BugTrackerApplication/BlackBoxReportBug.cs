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
    public partial class BlackBoxReportBug : Form
    {
        SqlConnection mySqlConnection;
        public BlackBoxReportBug()
        {
            InitializeComponent();
        }

        public void insertRecord(String TesterName, String Project, String Component, String BugDescription, String reportBugString)
        {
            // Change to local
            mySqlConnection = new SqlConnection(@"Data Source=F:\BugTrackerApplication-master\BugTrackerApplication-master\BugTrackerDB.mdf");

            try
            {
                SqlCommand cmdInsert = new SqlCommand(reportBugString, mySqlConnection);

                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = cmdInsert.ExecuteReader();

                cmdInsert.Parameters.AddWithValue("@TesterName", TesterName);
                cmdInsert.Parameters.AddWithValue("@Project", Project);
                cmdInsert.Parameters.AddWithValue("@Component", Component);
                cmdInsert.Parameters.AddWithValue("@BugDescription", BugDescription);
                cmdInsert.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(TesterName + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BlackBoxReportBug_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as BugTracker).BlackBoxBtn.Enabled = true;
            (this.Owner as BugTracker).WhiteBoxBtn.Enabled = true;
            (this.Owner as BugTracker).DeveloperBtn.Enabled = true;
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(TesterTxtBox.Text) ||
                string.IsNullOrEmpty(ProjectTxtBox.Text) ||
                string.IsNullOrEmpty(DescriptionTxtBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields before submitting");
                rtnvalue = false;
            }
            return (rtnvalue);
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String reportBugString = "INSERT INTO Bugs(TesterName, Project, Component, BugDescription) VALUES (@TesterName, @Project, @Component, @BugDescription)";
                insertRecord(TesterTxtBox.Text, ProjectTxtBox.Text, ComponentTxtBox.Text, DescriptionTxtBox.Text, reportBugString);
                mySqlConnection.Close();
            }

        }
    }
}
