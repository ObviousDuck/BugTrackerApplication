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
        public Register(BugTracker BugTracker)
        {
            InitializeComponent();
            string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BugTrackerDB.mdf;Integrated Security=True";
            mySqlConnection = new SqlConnection(path);
            mySqlConnection.Open();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }

        private void createNewUser()
        {
            if (string.IsNullOrEmpty(NameTxtBox.Text) || string.IsNullOrEmpty(UsernameTxtBox.Text) || string.IsNullOrEmpty(PasswordTxtBox.Text))
            {
                MessageBox.Show("Please fill in all the fields!");
            }

            else
            {
               string cmd = "INSERT INTO Users (Name, Username, Password, isAdmin) VALUES (@name, @username, @password, ";
               if (isAdminCheckBox.Checked)
                {
                    cmd += "1)";
                    MessageBox.Show("isAdmin");
                }
                else
                {
                    cmd += "0)";
                    MessageBox.Show("is NOT Admin");
                }
                SqlCommand addUserString = new SqlCommand(cmd, mySqlConnection);
                addUserString.Parameters.AddWithValue("@name", NameTxtBox.Text);
                addUserString.Parameters.AddWithValue("@username", UsernameTxtBox.Text);
                addUserString.Parameters.AddWithValue("@password", PasswordTxtBox.Text);

 
                
                addUserString.ExecuteNonQuery();
                MessageBox.Show("User created successfully!");
                
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySqlConnection.Close();
            BugTracker.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            createNewUser();
        }
    }
}
