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
    /// Hides the main menu and shows the Help window.
    /// On close, will show the main menu again.
    /// </summary>
    public partial class Help : Form
    {
        BugTracker BugTracker;
        public Help(BugTracker BugTracker)
        {
            InitializeComponent();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            BugTracker.Show();
        }

        // Opens a browser when the link is clicked navigating to the project on GitHUb
        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ObviousDuck/BugTrackerApplication");
        }
    }
}
