using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Services;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    internal class ClientListPage:IPageTables
    {
        private IWebDriver Driver;
        public PageTables Tables { get; set; }
        private IWebElement searchField;
        private IWebElement searchSubmitButton;

        public ClientListPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
            this.Tables = new PageTables(driver);
        }

        public IWebElement SearchField
        {
            get => searchField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientSearch_txtName""]") : searchField;
            set => searchField = value;
        }

        public IWebElement SearchSubmitButton
		{
			get => searchSubmitButton == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientSearch_lnkSearch""]") : searchSubmitButton;
			set => searchSubmitButton = value;
		}
        public ClientInformationPage ClickFirstRow()
        {
            Tables.GetRow(1).Click();
            return new ClientInformationPage(Driver);
        }

        public ClientListPage SubmitSearch()
        {
            SearchField.Submit();
            return this;
        }
        public ClientListPage FillSearchField(string text)
        {
            SearchField.SendKeys(text);
            return this;
        }
    }
}
