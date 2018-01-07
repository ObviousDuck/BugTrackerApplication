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
    public partial class Login : Form
    {
        // Declare variables
        SqlConnection mySqlConnection;
        BugTracker BugTracker;
        string name;

        /// <summary>
        /// Initializes the components and establishes a connection with the database and opens it.
        /// Hides the main menu.
        /// </summary>
        /// <param name="BugTracker"></param>
        public Login(BugTracker BugTracker)
        {
            InitializeComponent();
            
            mySqlConnection = new SqlConnection(EstablishConnection.SqlConnection);
            mySqlConnection.Open();

            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }

        /// <summary>
        /// Compares entered values with those matching in the database and returns a result.
        /// A message will show if the login is successful or not.
        /// </summary>
        private void ConfirmLogin()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT Count(*), isAdmin, Name FROM Users WHERE Username = @username AND Password = @password GROUP BY isAdmin, Name", mySqlConnection);
                cmd.Parameters.AddWithValue("@username", UsernameTxtBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTxtBox.Text);
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    SqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        BugTracker.isAdmin = (int)mySqlDataReader["isAdmin"];
                        name = (string)mySqlDataReader["Name"];
                    }
                    MessageBox.Show("Login Successful!");
                    BugTracker.setLoggedInLabel(name);
                    BugTracker.isLoggedIn = true;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Login failed. Please check your inputs.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ConfirmLogin();
        }

        /// <summary>
        /// Close the Sql Connection and show the menu again once window is closed.
        /// </summary>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySqlConnection.Close();
            BugTracker.Show();
        }

        /// <summary>
        /// Allows the Enter key to be pressed when user is on the Password field.
        /// </summary>
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConfirmLogin();
            }
        }
    }
}
