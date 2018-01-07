﻿using System;
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
    public partial class About : Form
    {
        BugTracker BugTracker;
        public About(BugTracker BugTracker)
        {
            InitializeComponent();
            this.BugTracker = BugTracker;
            BugTracker.Hide();
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            BugTracker.Show();
        }
    }
}