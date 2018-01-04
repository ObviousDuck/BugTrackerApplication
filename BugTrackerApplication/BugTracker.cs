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

        public BugTracker()
        {
            InitializeComponent();
        }

        public void ButtonsEnabled(bool enabled)
        {
            BlackBoxBtn.Enabled = enabled;
            WhiteBoxBtn.Enabled = enabled;
            DeveloperBtn.Enabled = enabled;
        }

        public void BlackBoxBtn_Click(object sender, EventArgs e)
        {
            TesterType = 1;
        }

        private void WhiteBoxBtn_Click(object sender, EventArgs e)
        {
            TesterType = 2;
        }

        private void DeveloperBtn_Click(object sender, EventArgs e)
        {
            TesterType = 3;
        }

        private void ReportBugButton_Click(object sender, EventArgs e)
        {
            if (TesterType == 1)
            {
                BlackBoxReportBug BlackBT = new BlackBoxReportBug();
                BlackBT.Owner = this;
                BlackBT.Show();
                ButtonsEnabled(false);
            }

            else if (TesterType == 2)
            {
                WhiteBoxReportBug WhiteReportBug = new WhiteBoxReportBug();
                WhiteReportBug.Owner = this;
                WhiteReportBug.Show();
                ButtonsEnabled(false);
            }

            else if (TesterType == 3)
            {
                WhiteBoxReportBug WhiteReportBug = new WhiteBoxReportBug();
                WhiteReportBug.Owner = this;
                WhiteReportBug.Show();
                ButtonsEnabled(false);
            }
            else
            {
                MessageBox.Show("Please select your role first!");
            }
        }

        private void FindBugButton_Click(object sender, EventArgs e)
        {

        }
    }
}
