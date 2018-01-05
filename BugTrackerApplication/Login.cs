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
        BugTracker BugTracker;
        string name;

        public Login(BugTracker BugTracker)
        {
            InitializeComponent();
            mySqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\c3439024\Documents\BugTrackerDB.mdf;Integrated Security=True;Connect Timeout=30");
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }

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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySqlConnection.Close();
            BugTracker.Show();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConfirmLogin();
            }
        }
    }
}
