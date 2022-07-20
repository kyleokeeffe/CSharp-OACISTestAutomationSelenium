using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    internal class ClientSearchPage
    {
        public IWebDriver Driver { get; set; }
        private IWebElement newButton;
        private IWebElement saveButton;
        public ClientSearchPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
        }
        private IWebElement NewButton
        {
            get => newButton == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]") : newButton;
            set => newButton = value;
        }
        private IWebElement SaveButton
        {
            get => saveButton == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkSave""]") : saveButton;
            set => saveButton = value;
        }

        public ClientInformationPage ClickNewButton()
        {
            NewButton.Click();
            return new ClientInformationPage(Driver);
        }


    }
}
