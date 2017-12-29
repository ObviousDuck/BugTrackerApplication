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
    public partial class WhiteBoxTester : Form
    {
        public WhiteBoxTester()
        {
            InitializeComponent();
        }

        private void WhiteBoxTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as BugTracker).BlackBoxBtn.Enabled = true;
            (this.Owner as BugTracker).WhiteBoxBtn.Enabled = true;
            (this.Owner as BugTracker).ProgrammerBtn.Enabled = true;
        }
    }
}
