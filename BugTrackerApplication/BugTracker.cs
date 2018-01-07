using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackerApplication
{
    /// <summary>
    /// Main menu form.
    /// Variables here passes information to other places of the program.
    /// </summary>
    public partial class BugTracker : Form
    {
        // Will either be Tester or Tester/Developer
        public int TesterType;

        // Can be set to true for testing purposes to avoid having to log in.
        public bool isLoggedIn = true;

        // Can be set to 1 for testing purposes to always have admin rights for the purpose of registering new users.
        public int isAdmin = 0;

        /// <summary>
        /// Initializes the components of the form.
        /// </summary>
        public BugTracker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the label on the menu to show who is currently logged in. 
        /// This is stored in a name variable which is passed along to other forms.
        /// </summary>
        public void setLoggedInLabel(string name)
        {
            LoggedInAsLabel.Text = name;
        }

        /// <summary>
        /// Sets Tester type and changes the label accordingly
        /// </summary>
        public void TesterBtn_Click(object sender, EventArgs e)
        {
            TesterType = 1;
            RoleLabel.Text = "Tester";
        }

        /// <summary>
        /// Sets Tester type and changes the label accordingly
        /// </summary>
        private void WhiteBoxBtn_Click(object sender, EventArgs e)
        {
            TesterType = 2;
            RoleLabel.Text = "Tester/Developer";
        }

        /// <summary>
        /// Opens a different class depending on what tester type was selected
        /// or if no testertype was selected - prompts a message.
        /// </summary>
        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            if (TesterType == 1)
            {
                TesterReportBug TesterReportBug = new TesterReportBug(this);
                TesterReportBug.Show();
            }

            else if (TesterType == 2)
            {
                TesterDeveloperReportBug TesterDeveloperReportBug = new TesterDeveloperReportBug(this);
                TesterDeveloperReportBug.Show();
            }
            else
            {
                MessageBox.Show("Please select your role first!");
            }
        }

        /// <summary>
        /// Controls the Find Bug button. User must be TesterType 2 and Logged in to access this feature.
        /// isLoggedIn determines this.
        /// </summary>
        private void FindBugButton_Click(object sender, EventArgs e)
        {
            if (TesterType == 1)
            {
                MessageBox.Show("You cannot view bugs as a Tester.");
            }

            else if (TesterType == 2)
            {
                if (isLoggedIn == true)
                {
                    Login loginForm = new Login(this);
                    TesterDeveloperViewBug developerViewBug = new TesterDeveloperViewBug(this, LoggedInAsLabel.Text);
                    developerViewBug.Show();
                }
                else
                {
                    MessageBox.Show("Please login to access.");
                }
            }

            else
            {
                MessageBox.Show("Please select your role first!");
            }
        }

        /// <summary>
        /// Opens the login form.
        /// </summary>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            loginForm.Show();
        }

        /// <summary>
        /// Opens the Register form if user is logged in as admin (determined by a column in the DB)
        /// If user is not admin but logged in, this will prompt a message.
        /// </summary>
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (isLoggedIn == true && isAdmin == 1)
            { 
            Register registerForm = new Register(this);
            registerForm.Show();
            }
            else
            {
                MessageBox.Show("Admin rights required to register a new user, please login with an administrator account.");
            }
        }

        /// <summary>
        /// The following three methods all refer to different menu items which opens those menu items
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help(this);
            helpForm.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutForm = new About(this);
            aboutForm.Show();
        }
    }
}
