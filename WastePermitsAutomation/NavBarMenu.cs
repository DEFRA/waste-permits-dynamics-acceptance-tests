using OpenQA.Selenium;

namespace WastePermitsAutomation
{
    public class NavBarMenu
    {
        public static void Signout()
        {
           var profileImage = Driver.Instance.FindElement(By.ClassName("navTabButtonUserInfoProfileImage"));
            profileImage.Click();

            var signOut = Driver.Instance.FindElement(By.Id("navTabButtonUserInfoSignOutId"));
            signOut.Click();
        }
    }
}
