using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace WastePermitsAutomation
{
    public class NavBarMenu
    {
        public static void Signout()
        {
           var profileImage = Driver.Instance.FindElement(By.ClassName("navTabButtonUserInfoProfileImage"));
            profileImage.Click();
            //Usual find element then click doesn't seem to work
            //Using advanced user actions API to move to element then click it
            var input = Driver.Instance.FindElement(By.CssSelector("a[Title='Sign out']"));
            new Actions(Driver.Instance).MoveToElement(input).Click().Perform();
        }
    }
}
