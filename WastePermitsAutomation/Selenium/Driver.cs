using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium.Remote;

namespace WastePermitsAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string Baseaddress => System.Configuration.ConfigurationManager.AppSettings["BaseUrl"];
        public static string Host = ConfigurationManager.AppSettings["Host"];
        private static string BrowserName = ConfigurationManager.AppSettings["BrowserName"];
        private static string BrowserVersion = ConfigurationManager.AppSettings["BrowserVersion"];
        private static string Platform = ConfigurationManager.AppSettings["Platform"];
        private static string BS_USER = ConfigurationManager.AppSettings["BS_USERNAME"];
        private static string BS_KEY = ConfigurationManager.AppSettings["BS_ACCESS_KEY"];
        private static string MASK_KEY_INPUT = ConfigurationManager.AppSettings["MASK_KEY_INPUT"];

        public static void Initialize()
        {
            switch (Host)
            {
                case "Local":
                    Instance = new ChromeDriver();
                    break;
                case "Browserstack":
                    DesiredCapabilities caps = new DesiredCapabilities();
                    caps.SetCapability(CapabilityType.BrowserName, BrowserName);
                    caps.SetCapability(CapabilityType.Version, BrowserVersion);
                    caps.SetCapability(CapabilityType.Platform, Platform);
                    caps.SetCapability("browserstack.user", BS_USER);
                    caps.SetCapability("browserstack.key", BS_KEY);
                    caps.SetCapability("build", "1");
                    caps.SetCapability("project", "Waste Permits");
                    caps.SetCapability("browserstack.maskSendKeys", MASK_KEY_INPUT);
                    Instance = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
                    break;
            }
            Instance.Manage().Window.Maximize();
            
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        public static void Close()
        {
            if (Instance != null)
                Instance.Quit();
        }

        internal static void Wait(TimeSpan timespan)
        {
            Thread.Sleep((int) (timespan.TotalSeconds * 1000));
        }
    }
}