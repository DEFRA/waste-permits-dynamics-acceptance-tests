using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    [TestClass]
    public class ApplicationTests : BaseTest
    {
        [TestMethod]
        public void Permiting_officer_can_create_application()
        {
            Dashboard.SelectDashboard("Waste Permitting Officer Dashboard");
        }
    }
}
