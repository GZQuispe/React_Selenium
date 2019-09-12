using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Website_Demo.Base;

namespace Website_Demo.Pages.LoginPage
{
    public partial class LoginPage : Page
    {
        private readonly string url = "https://orangehrm-demo-6x.orangehrmlive.com/auth/login";

        public void Login(string email, string password)
        {
            InputEmail.Clear();
            InputEmail.SendKeys(email);
            InputPassword.Clear();
            InputPassword.SendKeys(password);
            ButtonSignIn.Click();
        }

        public void NavigateTo() => driver.Navigate().GoToUrl(url);   
    }
}
