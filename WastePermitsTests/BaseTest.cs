using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            string username = System.Configuration.ConfigurationManager.AppSettings["UserName"];
            string userpassword = System.Configuration.ConfigurationManager.AppSettings["UserPassword"];

            Driver.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs(username).WithPassword(userpassword).Login();
        }
        [TestCleanup]
        public void Cleanup() => Driver.Close();

    }
}
