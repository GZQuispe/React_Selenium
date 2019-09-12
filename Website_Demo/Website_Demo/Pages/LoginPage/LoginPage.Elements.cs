using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Demo.Pages.LoginPage
{
    public partial class LoginPage
    {
        private IWebElement InputEmail => driver.FindElement(By.Id("txtUsername"));
        private IWebElement InputPassword => driver.FindElement(By.Id("txtPassword"));
        private IWebElement	ButtonSignIn => driver.FindElement(By.Id("btnLogin"));
    }
}
