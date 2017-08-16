using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace WastePermitsAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string Baseaddress => "https://ea-lp-crm-qa.crm4.dynamics.com";
        public static void Initialize()
        {
            Instance = new FirefoxDriver ();
            // Need to change to set implicit wait propertysetting
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static void Wait(TimeSpan timespan)
        {
            Thread.Sleep((int) (timespan.TotalSeconds * 1000));
        }
    }
}