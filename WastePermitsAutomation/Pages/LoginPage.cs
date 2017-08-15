
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WastePermitsAutomation
{
    public class LoginPage
    {
        public static void Goto()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.Baseaddress);
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private string userName;
        private string password;

        public LoginCommand(string userName)
        {  
            this.userName = userName;
        }

 

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
           var LoginInput = Driver.Instance.FindElement(By.Id("cred_userid_inputtext"));
           LoginInput.SendKeys(userName);


            var PasswordInput = Driver.Instance.FindElement(By.Id("cred_password_inputtext"));
           PasswordInput.SendKeys(password);

           var LoginButton = Driver.Instance.FindElement(By.Id("cred_sign_in_button"));
            Driver.Wait(TimeSpan.FromSeconds(2));
            LoginButton.Click();



        }
    }
}
