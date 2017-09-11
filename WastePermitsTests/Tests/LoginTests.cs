using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;
using OpenQA.Selenium;

namespace WastePermitsTests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        [TestMethod]
        public void Permitting_Officer_Can_Login()
        {
            //Assert.AreEqual(true,Driver.Instance.FindElement(By.ClassName("navTabButtonUserInfoProfileImage")).Displayed);
            Assert.IsTrue(NavBarMenu.IsAt, "Failed to login.");
        }
    }
}
