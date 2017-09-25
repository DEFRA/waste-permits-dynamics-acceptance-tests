using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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

        public static void completeApplication()
        {
            var applicationForm = Driver.Instance.FindElement(By.Id("contentIFrame1"));
            Driver.Instance.SwitchTo().Frame(applicationForm);

            //Usual find element then click doesn't seem to work
            //Using advanced user actions API to move to element then click it then fill in the details
            var customerTitle = Driver.Instance.FindElement(By.Id("defra_name_i"));
            new Actions(Driver.Instance).MoveToElement(customerTitle).Click().SendKeys("Mr").Perform();
            var customerName = Driver.Instance.FindElement(By.Id("header_process_defra_customerid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(customerName).Click().SendKeys("Tim Stone").Perform();
            var primaryContact = Driver.Instance.FindElement(By.Id("header_process_defra_primarycontactid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(primaryContact).Click().SendKeys("Tim Stone").Perform();
            var agentName = Driver.Instance.FindElement(By.Id("header_process_defra_agentid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(agentName).Click().SendKeys("Tim Stone").Perform();
            var areaName = Driver.Instance.FindElement(By.Id("header_process_defra_areaid_lookupValue"));
            new Actions(Driver.Instance).MoveToElement(areaName).Click().SendKeys("Bristol").Perform();
            Driver.Instance.SwitchTo().DefaultContent();
            var saveApplication = Driver.Instance.FindElement(By.Id("defra_application|NoRelationship|Form|Mscrm.Form.defra_application.Save"));
            saveApplication.Click();
        }
    }
}
