using OpenQA.Selenium;

namespace WastePermitsAutomation
{
    public class ApplicationsPage
    {
        public static bool IsAt
        {
            get
            {
                var dashboardTitle = Driver.Instance.FindElement(By.CssSelector("span[title='Applications']"));
                if (dashboardTitle.Displayed is true)
                    return true;
                else
                    return false;
            }
        }
        public static void newApplication()
        {
            var createApplication = Driver.Instance.FindElement(By.CssSelector("li[title$='Create a new Application record.']"));
            createApplication.Click();
        }
    }
}
