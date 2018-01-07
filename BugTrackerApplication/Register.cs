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
    public partial class Register : Form
    {
        SqlConnection mySqlConnection;
        BugTracker BugTracker;

        /// <summary>
        /// Initializes the components and establishes connection to database and opens it.
        /// Hides the main menu.
        /// </summary>
        /// <param name="BugTracker"></param>
        public Register(BugTracker BugTracker)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(EstablishConnection.SqlConnection);
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
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
        
        /// <summary>
        /// Method to create new user. This will return a result if unsuccessful or successful.
        /// </summary>
        private void createNewUser()
        {
            // If any of the fields on the form are empty, a message will be shown to prompt the user to fill in these.
            if (string.IsNullOrEmpty(NameTxtBox.Text) || string.IsNullOrEmpty(UsernameTxtBox.Text) || string.IsNullOrEmpty(PasswordTxtBox.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
            }

            // If the fields have been filled in, add new user to the database. Check to see if the isAdmin checkbox has been checked.
            // Then append unto the SQL command as appropriate to set the value in the isAdmin column.
            else
            {
               string cmd = "INSERT INTO Users (Name, Username, Password, isAdmin) VALUES (@name, @username, @password, ";
               if (isAdminCheckBox.Checked)
                {
                    cmd += "1)";
                }
                else
                {
                    cmd += "0)";
                }

                // Sanitization of SQL. This way, if the user enters SQL keywords, 
                // they will be stored as literal strings and not be run as commands.
                SqlCommand addUserString = new SqlCommand(cmd, mySqlConnection);
                addUserString.Parameters.AddWithValue("@name", NameTxtBox.Text);
                addUserString.Parameters.AddWithValue("@username", UsernameTxtBox.Text);
                addUserString.Parameters.AddWithValue("@password", PasswordTxtBox.Text);
                addUserString.ExecuteNonQuery();
                MessageBox.Show("User created successfully!");
                
            }
        }

        /// <summary>
        /// On form close, close SQL connection and show main menu again.
        /// </summary>
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySqlConnection.Close();
            BugTracker.Show();
        }

        /// <summary>
        /// Calls methods on Register button click
        /// </summary>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            createNewUser();
            ClearTxtBoxes(this.Controls);
        }
        /// <summary>
        /// Allows the Enter key to be pressed when user is on the Password field.
        /// </summary>
        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                createNewUser();
                ClearTxtBoxes(this.Controls);
            }
        }
    }
}
