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

            Driver.Wait(TimeSpan.FromSeconds(2));

            var signOut = Driver.Instance.FindElement(By.Id("navTabButtonUserInfoSignOutId"));
            signOut.Click();
        }
    }
}
