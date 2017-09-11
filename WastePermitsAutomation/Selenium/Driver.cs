using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium.Remote;

namespace WastePermitsAutomation
{
    public static class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string BaseAddress => System.Configuration.ConfigurationManager.AppSettings["BaseAddress"];
        public static string Host = ConfigurationManager.AppSettings["Host"];
        private static string browserName = ConfigurationManager.AppSettings["browserName"];
        private static string browserVersion = ConfigurationManager.AppSettings["browserVersion"];
        private static string osVersion = ConfigurationManager.AppSettings["osVersion"];
        private static string os = ConfigurationManager.AppSettings["os"];
        private static string bsUser = ConfigurationManager.AppSettings["bsUser"];
        private static string bsKey = ConfigurationManager.AppSettings["bsKey"];
        private static string maskKeyInput = ConfigurationManager.AppSettings["maskKeyInput"];
        private static string bsDebug = ConfigurationManager.AppSettings["bsDebug"];
        private static string bsVideo = ConfigurationManager.AppSettings["bsVideo"];

        public static void Initialize()
        {
            switch (Host)
            {
                case "Local":
                    Instance = new ChromeDriver();
                    break;
                case "Browserstack":
                    DesiredCapabilities caps = new DesiredCapabilities();
                    caps.SetCapability(CapabilityType.BrowserName, browserName);
                    caps.SetCapability(CapabilityType.Version, browserVersion);
                    caps.SetCapability("os", os);
                    caps.SetCapability("os_version", osVersion);
                    caps.SetCapability("browserstack.user", bsUser);
                    caps.SetCapability("browserstack.key", bsKey);
                    caps.SetCapability("build", "1");
                    caps.SetCapability("project", "Waste Permits");
                    caps.SetCapability("browserstack.maskSendKeys", maskKeyInput);
                    caps.SetCapability("browserstack.debug", bsDebug);
                    caps.SetCapability("browserstack.video", bsVideo);
                    Instance = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
                    break;
            }
            Instance.Manage().Window.Maximize();
            
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
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