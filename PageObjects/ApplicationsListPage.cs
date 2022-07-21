using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Services;
using OACISTestAutomationSelenium.Services.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public ApplicationPage ClickApplication(ApplicationListColumns columnName, string rowValue)
        {
            Tables.GetRow(Regex.Replace(columnName.ToString(), "(\\B[A-Z])", " $1"),rowValue).Click();
            //@"(\B[A-Z]+?(?=[A-Z][^A-Z])|\B[A-Z]+?(?=[^A-Z]))"
            return ApplicationPage.CreateApplicationPage(Driver);
        }
    }
}
