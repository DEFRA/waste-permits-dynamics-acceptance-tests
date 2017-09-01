using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;

namespace WastePermitsAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string Baseaddress => System.Configuration.ConfigurationManager.AppSettings["BaseUrl"];
        public static string Browser = ConfigurationManager.AppSettings["browser"];

        public static void Initialize()
        {

            switch (Browser)
            {
                case "Chrome":
                    Instance = new ChromeDriver();
                    break;
                case "IE":
                    Instance = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    Instance = new FirefoxDriver(); ;
                    break;
            }
            Instance.Manage().Window.Maximize();
            
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