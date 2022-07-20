using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class ApplicationsListPage:IPageTables
    {
        private IWebDriver Driver;
        public PageTables Tables { get ; set ; }

        public ApplicationsListPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
            this.Tables = new PageTables(driver);
        }

        public ApplicationPage ClickApplication(string colName, string rowValue)
        {
            Tables.GetRow(colName, rowValue).Click();
            return ApplicationPage.CreateApplicationPage(Driver);
        }
    }
}
