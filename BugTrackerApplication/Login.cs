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
        SqlConnection mySqlConnection;
        SqlCommand mySqlCommand;
        SqlDataReader mySqlDataReader;
        String cmd;
        BugTracker BugTracker;

        

        public Login(BugTracker BugTracker)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3439024\Documents\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Users WHERE Username = @username AND Password = @password", mySqlConnection);
                cmd.Parameters.AddWithValue("@username", UsernameTxtBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTxtBox.Text);
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Login Successful!");
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
                MessageBox.Show("Unexpected error occurred.");
            }
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            BugTracker bugTracker = new BugTracker();
            try
            {
                if (bugTracker.TesterType == 3)
                {
                    var registerForm = new Register();
                    registerForm.Show();
                }
                else
                {
                    MessageBox.Show("Only users with admin privileges can create users. Please log in as an admin user first.");
                }
            }
            catch
            {
                MessageBox.Show("Unexpected error occurred.");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySqlConnection.Close();
            BugTracker.Show();
        }
    }
}
