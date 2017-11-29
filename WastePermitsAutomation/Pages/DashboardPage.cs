using OpenQA.Selenium;

namespace WastePermitsAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var dashboardTitle = Driver.Instance.FindElement(By.Id("dashboardSelectorLink")).FindElement(By.CssSelector("span[Title='Waste Permitting Officer Dashboard']"));
                if (dashboardTitle.Displayed is true)
                    return true;
                else
                    return false;
            }
        }

        public static void SelectDashboard()
        {
            var dashboard = Driver.Instance.FindElement(By.Id("contentIFrame0"));
            Driver.Instance.SwitchTo().Frame(dashboard);
            var dashboardSelector = Driver.Instance.FindElement(By.Id("dashboardSelectorLink"));
            dashboardSelector.Click();
            var dashboardTitle = Driver.Instance.FindElement(By.CssSelector("span[Title='Waste Permitting Officer Dashboard']"));
            dashboardTitle.Click();
        }
    }
}
