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
        public int TesterType = 0;
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
            RoleLabel.Text = "Black Box Tester";
        }

        private void WhiteBoxBtn_Click(object sender, EventArgs e)
        {
            TesterType = 2;
            RoleLabel.Text = "White Box Tester";
        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            TesterType = 3;
            RoleLabel.Text = "Developer";
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            if (TesterType == 1)
            {
                BlackBoxReportBug BlackBT = new BlackBoxReportBug(this);
                BlackBT.Owner = this;
                BlackBT.Show();
            }

            else if (TesterType == 2)
            {
                WhiteBoxReportBug WhiteReportBug = new WhiteBoxReportBug(this);
                WhiteReportBug.Owner = this;
                WhiteReportBug.Show();
            }

            else if (TesterType == 3)
            {
                WhiteBoxReportBug WhiteReportBug = new WhiteBoxReportBug(this);
                WhiteReportBug.Owner = this;
                WhiteReportBug.Show();
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
                    WhiteBoxReportBug WhiteReportBug = new WhiteBoxReportBug(this);
                    WhiteReportBug.Owner = this;
                    WhiteReportBug.Show();
                }
                else
                {
                    MessageBox.Show("Please login to access.");
                }
            }

            else if (TesterType == 3)
            {
                if (isLoggedIn == true)
                {
                    Login loginForm = new Login(this);
                    DeveloperViewBug developerViewBug = new DeveloperViewBug();
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
            Register registerForm = new Register();
            registerForm.Owner = this;
            registerForm.Show();
            } else
            {
                MessageBox.Show("Admin rights required to register a new user, please login with an administrator account.");
            }
        }
    }
}
