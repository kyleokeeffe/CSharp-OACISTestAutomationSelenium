using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects.AuthorizationPages
{
    public class AuthorizationParent
    {
        private IWebDriver Driver;
        private IWebElement newLink;
        private IWebElement saveLink;
        private IWebElement deleteLink;
        private IWebElement authorizationsLink;
        private IWebElement serviceLinesLink;
        private IWebElement paymentsLink;
        public IWebElement applicationLink;

        public IWebElement NewLink
        {
            get => newLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]") : newLink;
            set => newLink = value;
        }
        public IWebElement SaveLink
        {
            get => saveLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkSave""]") : saveLink;
            set => saveLink = value;
        }
        public IWebElement DeleteLink
        {
            get => deleteLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkDelete""]") : deleteLink;
            set => deleteLink = value;
        }
        public IWebElement AuthorizationsLink
        {
            get => authorizationsLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAuthPageNav_lnkAuthList""]") : authorizationsLink;
            set => authorizationsLink = value;
        }
        public IWebElement ServiceLinesLink
        {
            get => serviceLinesLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAuthPageNav_lnkServiceLines""]") : serviceLinesLink;
            set => serviceLinesLink = value;
        }
        public IWebElement PaymentsLink
        {
            get => paymentsLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAuthPageNav_lnkPayments""]") : paymentsLink;
            set => paymentsLink = value;
        }
        public IWebElement ApplicationLink
        {
            get => applicationLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAuthPageNav_lnkApplication""]") : applicationLink;
            set => applicationLink = value;
        }

        public AuthorizationParent(IWebDriver driver)
        {
            this.Driver = driver;
        }
        public AuthorizationListPage ClickAuthorizationsLink()
        {
            AuthorizationsLink.Click();
            return (AuthorizationListPage)this;
        }
        public  ApplicationPage ClickApplicationLink()
        {
            ApplicationLink.Click();
            return  ApplicationPage.CreateApplicationPage(Driver);
        }
    }
}
