using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        [TestMethod]
        public void Permitting_Officer_Can_Login()
        {
            Assert.IsTrue(NavBarMenu.IsAt, "Failed to login.");
        }
    }
}
