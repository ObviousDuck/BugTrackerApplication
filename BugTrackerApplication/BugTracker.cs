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
    /// 
    /// </summary>
    public partial class BugTracker : Form
    {
        public int TesterType;
        // SET TO FALSE
        public bool isLoggedIn = true;

        // SET TO 0
        public int isAdmin = 1;

        public BugTracker()
        {
            InitializeComponent();
        }

        public void setLoggedInLabel(string name)
        {
            LoggedInAsLabel.Text = name;
        }

        public void BlackBoxBtn_Click(object sender, EventArgs e)
        {
            TesterType = 1;
            RoleLabel.Text = "Tester";
        }

        private void WhiteBoxBtn_Click(object sender, EventArgs e)
        {
            TesterType = 2;
            RoleLabel.Text = "Tester/Developer";
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            if (TesterType == 1)
            {
                TesterReportBug TesterReportBug = new TesterReportBug(this);
                //TesterReportBug.Owner = this;
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
                    TesterDeveloperViewBug developerViewBug = new TesterDeveloperViewBug(this);
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

        // Opens the login form
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            loginForm.Show();
        }

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
