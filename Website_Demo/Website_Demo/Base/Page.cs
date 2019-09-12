using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website_Demo.Core;

namespace Website_Demo.Base
{
    public abstract class Page
    {
        protected IWebDriver driver = Driver.GetInstance();

        public Page() { }
    }
}
