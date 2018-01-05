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
    public partial class TesterReportBug : Form
    {
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd;
        BugTracker BugTracker;

        public TesterReportBug(BugTracker BugTracker)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\BugTrackerApplication\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }
        
        public bool checkInputs()
        {
            bool rtnvalue = true;
            try
            {
                if 
                (
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
                        + DateTime.Now.ToString("dd-MM-yy HH:mm") + "', '" + TesterTxtBox.Text.ToString() + "' ,'" + ProjectTxtBox.Text.ToString() +
                        "' ,'" + ComponentTxtBox.Text.ToString() + "' ,'" + SummaryTxtBox.Text.ToString() + "' ,'" + DescriptionTxtBox.Text.ToString() + "')";

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

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            checkInputs();
        }

        private void BlackBoxReportBug_FormClosing(object sender, FormClosingEventArgs e)
        {
            BugTracker.Show();
            mySqlConnection.Close();
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
    }
}
