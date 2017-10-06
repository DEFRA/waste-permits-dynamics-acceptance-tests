using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WastePermitsAutomation
{
    public class ApplicationsPage
    {
        private static int lastCount;

        public static int PreviousApplicationsCount
        {
            get { return lastCount; }
        }

        public static int CurrentApplicationsCount
        {
            get { return GetApplicationCount(); }
        }

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

        public static void completeApplication()
        {
            var applicationForm = Driver.Instance.FindElement(By.Id("contentIFrame1"));
            Driver.Instance.SwitchTo().Frame(applicationForm);

            //Usual find element then click doesn't seem to work
            //Using advanced user actions API to move to element then click it then fill in the details
            //https://github.com/SeleniumHQ/selenium/wiki/Advanced-User-Interactions
            //Title name ID seems to change every time page is rendered so using a css selector begins with defra_name_
            var Title = Driver.Instance.FindElement(By.CssSelector("div[aria-describedby^='defra_name_']"));
            new Actions(Driver.Instance).MoveToElement(Title).Click().SendKeys("Permit XX").Perform();
            var customerName = Driver.Instance.FindElement(By.Id("header_process_defra_customerid"));
            new Actions(Driver.Instance).MoveToElement(customerName).Click().SendKeys("Tim Stone").Perform();
            var primaryContact = Driver.Instance.FindElement(By.Id("header_process_defra_primarycontactid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(primaryContact).Click().SendKeys("Tim Stone").Perform();
            var agentName = Driver.Instance.FindElement(By.Id("header_process_defra_agentid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(agentName).Click().SendKeys("Tim Stone").Perform();
            var areaName = Driver.Instance.FindElement(By.Id("header_process_defra_areaid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(areaName).Click().SendKeys("Bristol").Perform();
            var saveApplication = Driver.Instance.FindElement(By.CssSelector("img[Title='Save']"));
            saveApplication.Click();
            //TODO check for saving complete before continuing
            Driver.Wait(TimeSpan.FromSeconds(5));
            Driver.Instance.SwitchTo().DefaultContent();
        }

        public static void StoreApplicationCount()
        {
            lastCount = GetApplicationCount();
        }

        private static int GetApplicationCount()
        {
            var activeApplications = Driver.Instance.FindElement(By.Id("contentIFrame0"));
            Driver.Instance.SwitchTo().Frame(activeApplications);
            var activeApplicationsTable = Driver.Instance.FindElement(By.Id("gridBodyTable"));
            var recordCount = int.Parse(activeApplicationsTable.GetAttribute("totalrecordcount"));
            Driver.Instance.SwitchTo().DefaultContent();
            return recordCount;

        }
    }
}
