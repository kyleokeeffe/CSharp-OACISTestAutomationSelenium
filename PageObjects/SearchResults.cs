using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class SearchResults : IPageTables
    {
        private IWebDriver Driver;
        public PageTables Tables { get; set ; }

        public SearchResults(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;

            this.Tables = new PageTables(driver);

        }
        public IReadOnlyCollection<IWebElement> GetSearchResults()
        {
            return TableHelper.GetGridRows(this.Driver);
        }
        public ClientInformationPage ClickFirstRow()
        {
          
            Tables.GetRow(1).Click();

            return  new ClientInformationPage(Driver);

        }

        /* public IWebElement GetSearchResultRow(int tableNum, string colName, string rowValue)
        {
            return TableHelper.GetRow(this.Driver, 1, colName, rowValue);
        }*/
        /*public SearchResults ClickResult(string searchTerm)
        {
            GetSearchResultRow(1, "Application Number", searchTerm);
            return this;
        }*/
        /* public IReadOnlyCollection<IWebElement> GetTables(IWebDriver driver)
         {
             return DriverHelper.FindElementsWithWait(driver, @"//table[@class=""Grid""]");
         }*/
    }
}

