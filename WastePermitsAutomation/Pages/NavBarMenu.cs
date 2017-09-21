using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WastePermitsAutomation
{
    public class NavBarMenu
    {
        public static bool IsAt
        {
           get
            {
                var ProfileImageLocator = Driver.Instance.FindElement(By.Id("navTabButtonUserInfoLinkId"));
                if (ProfileImageLocator.Displayed is true)
                return true;
                else 
                return false;
            }
         }

        public static void Signout()
        {
           var profileImage = Driver.Instance.FindElement(By.Id("TabUserInfoId"));
            profileImage.Click();
            //Usual find element then click doesn't seem to work
            //Using advanced user actions API to move to element then click it
            var input = Driver.Instance.FindElement(By.CssSelector("a[Title='Sign out']"));
            new Actions(Driver.Instance).MoveToElement(input).Click().Perform();
        }

        public static void openApplications()
        {
            var lpSitemap = Driver.Instance.FindElement(By.Id("TabLP"));
            lpSitemap.Click();
            var applicationsMenu = Driver.Instance.FindElement(By.Id("LP_Applications"));
            applicationsMenu.Click();
            var applications = Driver.Instance.FindElement(By.CssSelector("a[Title='Applications']"));
            applications.Click();

        }
    }
}
