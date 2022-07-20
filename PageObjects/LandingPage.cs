using OACISTestAutomationSelenium.Functional;
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
    internal class LandingPage
    {
        private IWebDriver Driver;
        private IWebElement searchField;
        private IWebElement clientLink;
        private IWebElement reportsLink;

        public IWebElement SearchField
        {
            get => searchField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : searchField;
            set => searchField = value;
        }
        private IWebElement ClientLink
        {
            get => clientLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkClient""]") : clientLink;
            set => clientLink = value;
        }
        private IWebElement ReportsLink
        {
            get => reportsLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkReports""]") : reportsLink;
            set => reportsLink = value;
        }
        /* public IWebElement GetSearchField()
         {
             return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]");
         }

         public IWebElement GetClientLink()
         {
             return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkClient""]");
         }
        
        public IWebElement GetReportsLink()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkReports""]");
        }
        */

        public LandingPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
        }
        public SearchResults Search(string searchTerm)
        {
            SearchField.SendKeys(searchTerm);
            SearchField.SendKeys(Keys.Return);
            return new SearchResults(Driver);
        }
        public ClientSearchPage ClickClientLink()
        {
            ClientLink.Click();
            return new ClientSearchPage(Driver);
        }
    }
}
