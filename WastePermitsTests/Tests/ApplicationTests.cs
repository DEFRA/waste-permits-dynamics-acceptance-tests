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
            ApplicationsPage.newApplication();
            ApplicationsPage.completeApplication();

        }
    }
}
