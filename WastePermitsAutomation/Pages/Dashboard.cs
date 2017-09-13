using OpenQA.Selenium;

namespace WastePermitsAutomation
{
    public class Dashboard
    {
        public static void SelectDashboard(string title)
        {
            var dashboard = Driver.Instance.FindElement(By.Id("contentIFrame0"));
            Driver.Instance.SwitchTo().Frame(dashboard);
            var dashboardSelector = Driver.Instance.FindElement(By.Id("dashboardSelectorLink"));
            dashboardSelector.Click();
            var dashboardTitle = Driver.Instance.FindElement(By.CssSelector("span[Title='title']"));
            dashboardTitle.Click();
            //Comes out of iframe
            Driver.Instance.SwitchTo().DefaultContent();
        }
    }
}
