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
        public BugTracker()
        {
            InitializeComponent();
        }

        public void ButtonsEnabled(bool enabled)
        {
            BlackBoxBtn.Enabled = enabled;
            WhiteBoxBtn.Enabled = enabled;
            ProgrammerBtn.Enabled = enabled;
        }

        private void BlackBoxBtn_Click(object sender, EventArgs e)
        {
            BlackBoxTester BlackBT = new BlackBoxTester();
            BlackBT.Owner = this;
            BlackBT.Show();
            ButtonsEnabled(false);
        }

        private void WhiteBoxBtn_Click(object sender, EventArgs e)
        {
            WhiteBoxTester WhiteBT = new WhiteBoxTester();
            WhiteBT.Owner = this;
            WhiteBT.Show();
            ButtonsEnabled(false);
        }

        private void ProgrammerBtn_Click(object sender, EventArgs e)
        {
            Programmer Programmer = new Programmer();
            Programmer.Owner = this;
            Programmer.Show();
            ButtonsEnabled(false);
        }
    }
}
