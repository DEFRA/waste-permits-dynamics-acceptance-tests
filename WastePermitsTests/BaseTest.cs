using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            string userName = System.Configuration.ConfigurationManager.AppSettings["userName"];
            string userPassword = System.Configuration.ConfigurationManager.AppSettings["userPassword"];

            Driver.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs(userName).WithPassword(userPassword).Login();
        }
        [TestCleanup]
        public void Cleanup()
        {
            NavBarMenu.Signout();
            Driver.Close();
        }
    }
}
