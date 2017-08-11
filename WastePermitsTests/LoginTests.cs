using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        [TestMethod]
        public void Permitting_Officer_Can_Login()
        {
            LoginPage.Goto();
            LoginPage.LoginAs("tim.stone@defradev.onmicrosoft.com").WithPassword("XXXXXXX").Login();

            //Assert.IsTrue(MainPage.IsAt, "Failed to login.");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
