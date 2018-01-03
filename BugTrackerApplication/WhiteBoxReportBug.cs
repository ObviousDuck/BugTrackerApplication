using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorCode;
using System.IO;

namespace BugTrackerApplication
{
    public partial class WhiteBoxReportBug : Form
    {
        public WhiteBoxReportBug()
        {
            InitializeComponent();
        }

        private void WhiteBoxTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as BugTracker).BlackBoxBtn.Enabled = true;
            (this.Owner as BugTracker).WhiteBoxBtn.Enabled = true;
            (this.Owner as BugTracker).DeveloperBtn.Enabled = true;
        }
        /// <summary>
        /// Some code that does things
        /// </summary>
        public void ColourizeCode()
        {
            string colourizedSourceCode = new CodeColorizer().Colorize(CodeSnippetTxtBox.Text, Languages.CSharp);
            CodeSnippetTxtBox.Text = colourizedSourceCode;

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Code Snippet </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            System.IO.File.WriteAllText(@"C:\Users\c3439024\Documents\FormattedCode.html", html);
        }

        private void uploadCode_Click(object sender, EventArgs e)
        {
            ColourizeCode();
        }
    }
}
