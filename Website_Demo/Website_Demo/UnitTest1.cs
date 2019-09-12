using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Website_Demo.Pages.LoginPage;

namespace Website_Demo
{
    [TestClass]
    public class UnitTest1
    {

        private IWebDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = new FirefoxDriver("C:\\Users\\gquispe\\Documents\\Chrome Serenium");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        [TestMethod]
        public void TestMethod1()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.NavigateTo();
            loginPage.Login("admin","admin123");
        }
    }
}
