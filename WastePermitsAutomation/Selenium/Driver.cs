using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace WastePermitsAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string Baseaddress => System.Configuration.ConfigurationManager.AppSettings["BaseUrl"];

        public static void Initialize()
        {
            Instance = new FirefoxDriver ();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
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