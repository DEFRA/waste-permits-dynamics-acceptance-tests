using Microsoft.VisualStudio.TestTools.UnitTesting;
using WastePermitsAutomation;

namespace WastePermitsTests
{
    public class WastePermitsTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs("tim.stone@defradev.onmicrosoft.com").WithPassword("XXXXX").Login();
        }

        [TestCleanup]
        public void Cleanup()
        {
            NavBarMenu.Signout();
            Driver.Close();
        }

    }
}
