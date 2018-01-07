using System;
using BugTrackerApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BugTrackerApplicationTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ReturnListOfUsers()
        {
            TesterReportBug TesterReportBug = new TesterReportBug(new BugTracker());
            PrivateObject obj = new PrivateObject(TesterReportBug);

            //Assert.AreEqual(1, obj.Invoke("populateUserList"));
            Assert.IsNotNull(obj.Invoke("populateUserList"));

        }

        [TestMethod]
        public void TestTesterReportBugWithInput()
        {
           TesterReportBug TesterReportBug = new TesterReportBug(new BugTracker());
            PrivateObject obj = new PrivateObject(TesterReportBug);

            TesterReportBug.TesterTxtBox.Text = "TestName";
            TesterReportBug.ProjectTxtBox.Text = "TestProject";
            TesterReportBug.ComponentTxtBox.Text = "TestComponent";
            TesterReportBug.SummaryTxtBox.Text = "TestSummary";
            TesterReportBug.DescriptionTxtBox.Text = "TestDescription";

            Assert.AreEqual(1, obj.Invoke("checkInputs"));
        }

        [TestMethod]
        public void TestTesterReportBugWithoutInput()
        {
            TesterReportBug TesterReportBug = new TesterReportBug(new BugTracker());
            PrivateObject obj = new PrivateObject(TesterReportBug);

            Assert.AreEqual(0, obj.Invoke("checkInputs"));
        }
    }
}
