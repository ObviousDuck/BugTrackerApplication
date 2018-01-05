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
        public bool isLoggedIn = false;
        public int isAdmin = 0;

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
                TesterReportBug.Owner = this;
                TesterReportBug.Show();
            }

            else if (TesterType == 2)
            {
                TesterDeveloperReportBug TesterDeveloperReportBug = new TesterDeveloperReportBug(this);
                TesterDeveloperReportBug.Owner = this;
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
                MessageBox.Show("You cannot view bugs as a Black Box Tester.");
            }

            else if (TesterType == 2)
            {
                if (isLoggedIn == true)
                {
                    Login loginForm = new Login(this);
                    TesterDeveloperViewBug developerViewBug = new TesterDeveloperViewBug();
                    developerViewBug.Owner = this;
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            loginForm.Owner = this;
            loginForm.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (isLoggedIn == true && isAdmin == 1)
            { 
            Register registerForm = new Register(this);
            registerForm.Owner = this;
            registerForm.Show();
            }
            else
            {
                MessageBox.Show("Admin rights required to register a new user, please login with an administrator account.");
            }
        }
    }
}
