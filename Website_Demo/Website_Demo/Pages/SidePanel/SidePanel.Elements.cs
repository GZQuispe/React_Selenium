using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website_Demo.Base;

namespace Website_Demo.Pages.SidePanel
{
    public partial class SidePanel : Page
    {
        private IWebElement Admin => driver.FindElement(By.Id("menu_admin_viewAdminModule"));
    }
}
