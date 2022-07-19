using OACISTestAutomationSelenium.PageObjects.AuthorizationPages;
using OACISTestAutomationSelenium.Services;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class AuthorizationListPage:AuthorizationParent, IPageTables
    {
        //private IWebDriver Driver;

        public AuthorizationListPage(IWebDriver driver):base(driver)
        {
           // this.Driver = driver;
        }

        public PageTables Tables { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
