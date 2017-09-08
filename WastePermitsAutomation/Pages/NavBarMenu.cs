using OpenQA.Selenium;
using System;

namespace WastePermitsAutomation
{
    public class NavBarMenu
    {
        public static void Signout()
        {
           var profileImage = Driver.Instance.FindElement(By.ClassName("navTabButtonUserInfoProfileImage"));
            profileImage.Click();

            Driver.Wait(TimeSpan.FromSeconds(10));
            var signOut = Driver.Instance.FindElement(By.CssSelector("a[Title='Sign out']"));
            signOut.Click();
        }
    }
}
