using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    [TestClass]
    public class ApplicationTests : BaseTest
    {
        [TestMethod]
        public void Permiting_officer_can_change_dashboard()
        {
            DashboardPage.SelectDashboard();
            Assert.IsTrue(DashboardPage.IsAt, "Failed to change dashboard");
        }
        [TestMethod]
        public void Permiting_officer_can_create_application()
        {
            NavBarMenu.openApplications();
            Assert.IsTrue(ApplicationsPage.IsAt, "Failed to go to Applications page");
            //Stores the number of applications for later checks on application being created
            ApplicationsPage.StoreApplicationCount();
            ApplicationsPage.newApplication();
            ApplicationsPage.completeApplication();
            NavBarMenu.openApplications();
            Assert.AreEqual(ApplicationsPage.PreviousApplicationsCount +1, ApplicationsPage.CurrentApplicationsCount, "Couldn't create application");
        }
    }
}
