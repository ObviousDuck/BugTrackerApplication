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
        // Declare variables
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd;
        BugTracker BugTracker;

        /// <summary>
        /// Initializes the components and establishes connection to database and opens it.
        /// Hides the main menu.
        /// </summary>
        /// <param name="BugTracker"></param>
        public TesterReportBug(BugTracker BugTracker)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(EstablishConnection.SqlConnection);
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
            PopulateUserList();
            
        }

        /// <summary>
        /// Populates the Tester drop down list. 
        /// </summary>
        public void PopulateUserList()
        {
            try
            {
                cmd = "SELECT Name FROM Users";
                mySqlCommand = new SqlCommand(cmd, mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                TesterTxtBox.Items.Clear();

                // While the Data Reader is open, add items to the list (Name)
                while (mySqlDataReader.Read())
                {
                    TesterTxtBox.Items.Add(mySqlDataReader["Name"]);
                }
                // Close the data reader
                mySqlDataReader.Close();
            }

            // Throw exception if the above block fails, and display error to MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to create new user. This will return a result if unsuccessful or successful.
        /// </summary>
        public int checkInputs()
        {
            try
            {
                // If all fields are not filled in, exit block and send message
                if 
                (
                    string.IsNullOrEmpty(TesterTxtBox.Text) ||
                    string.IsNullOrEmpty(ProjectTxtBox.Text) ||
                    string.IsNullOrEmpty(DescriptionTxtBox.Text) ||
                    string.IsNullOrEmpty(SummaryTxtBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields before submitting the bug report.");
                    return 0;
                }

                // Otherwise, add bug to database
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Bugs (DateLogged, TesterName, Project, Component, Summary, Description) VALUES ('"
                        + DateTime.Now.ToString("dd-MM-yy HH:mm") + "', '" + TesterTxtBox.Text + "' , @Project, @Component, @Summary, @Description)", mySqlConnection);

                    // Sanitization of SQL. This way, if the user enters SQL keywords, 
                    // they will be stored as literal strings and not be run as commands.
                    cmd.Parameters.AddWithValue("@Project", ProjectTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Component", ComponentTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Summary", SummaryTxtBox.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionTxtBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Bug successfully logged!");

                    // Clear the text boxes.
                    ClearTxtBoxes(this.Controls);
                }
                
            }

            // Throws SqlException if above fails and puts error in MessageBox.
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 1;
        }

        /// <summary>
        /// Runs through each of the Control elements on the form, if it is a TextBox, clear its contents.
        /// </summary>
        /// <param name="cc"></param>
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

        /// <summary>
        /// Shows main menu again and closes Database connection.
        /// </summary>
        private void TesterReportBug_FormClosing(object sender, FormClosingEventArgs e)
        {
            BugTracker.Show();
            mySqlConnection.Close();
        }

        /// <summary>
        /// Opens file dialog which prompts user to select a file.
        /// </summary>
        private void UploadAttachmentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog attachment = new OpenFileDialog();

            // Filetypes are specified
            attachment.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            // If successful, add the name of attachment to the Attachment Text box.
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
