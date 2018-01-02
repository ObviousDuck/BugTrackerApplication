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
    public partial class BlackBoxReportBug : Form
    {
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd;

        public BlackBoxReportBug()
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\Documents\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                string.IsNullOrEmpty(DescriptionTxtBox.Text) ||
                string.IsNullOrEmpty(SummaryTxtBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields before submitting the bug report.");
                    rtnvalue = false;
                }

                else
                {
                    cmd = "INSERT INTO Bugs (TesterName, DateLogged, Project, Component, Summary, Description) VALUES ('"
                        + TesterTxtBox.Text + "', '" + ProjectTxtBox.Text + "' ,'" + ComponentTxtBox.Text + "' ,'" + SummaryTxtBox.Text + "' ,'" + DescriptionTxtBox.Text + "' ,'" + DateTime.Now.ToString("dd-MM-yy HH:mm") + "')";

                    mySqlCommand = new SqlCommand(cmd, mySqlConnection);

                    mySqlDataReader = mySqlCommand.ExecuteReader();
                }
                
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (rtnvalue);
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                
            }

        }

        private void BlackBoxReportBug_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as BugTracker).BlackBoxBtn.Enabled = true;
            (this.Owner as BugTracker).WhiteBoxBtn.Enabled = true;
            (this.Owner as BugTracker).DeveloperBtn.Enabled = true;
        }

    }
}
