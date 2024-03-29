﻿using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.PageObjects.ApplicationPages;
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
    public class ApplicationPage: IPageObject
    {
        protected IWebDriver Driver;

        private IWebElement contactLink;
        private IWebElement priorServiceLink;
        private IWebElement bankingLink;
        private IWebElement intakeLink;
        private IWebElement budgetLink;
        private IWebElement followUpLink;
        private IWebElement newLink;
        private IWebElement saveLink;
        private IWebElement deleteLink;
        private IWebElement listLink;
        private IWebElement lettersLink;
        private IWebElement mergeLink;
        private IWebElement expensesLink;
        private IWebElement authorizationsLink;
        private IWebElement narrativesLink;

        public IWebElement ContactLink
        {
            get => contactLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lbContactsTab""]") : contactLink;
            set => contactLink = value;
        }
        public IWebElement PriorServiceLink
        {
            get => priorServiceLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lbContactsTab""]") : priorServiceLink;
            set => priorServiceLink = value;
        }
        public IWebElement BankingLink
        {
            get => bankingLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lbBankingTab""]") : bankingLink;
            set => bankingLink = value;
        }
        public IWebElement IntakeLink
        {
            get => intakeLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lbIntakeTab""]") : intakeLink;
            set => intakeLink = value;
        }
        public IWebElement BudgetLink
        {
            get => budgetLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lbBudgetTab""]") : budgetLink;
            set => budgetLink = value;
        }
        public IWebElement FollowUpLink
        {
            get => followUpLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lbFollowUpTab""]") : followUpLink;
            set => followUpLink = value;
        }
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
        public IWebElement ListLink
        {
            get => listLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkAppList""]") : listLink;
            set => listLink = value;
        }
        public IWebElement LettersLink
        {
            get => lettersLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkLetters""]") : lettersLink;
            set => lettersLink = value;
        }
        public IWebElement MergeLink
        {
            get => mergeLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkMerge""]") : mergeLink;
            set => mergeLink = value;
        }
        public IWebElement ExpensesLink
        {
            get => expensesLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkExpenses""]") : expensesLink;
            set => expensesLink = value;
        }
        public IWebElement AuthorizationsLink
        {
            get => authorizationsLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkAuthorization""]") : authorizationsLink;
            set => authorizationsLink = value;
        }
        public IWebElement NarrativesLink
        {
            get => narrativesLink == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkNarratives""]") : narrativesLink;
            set => narrativesLink = value;
        }

        protected ApplicationPage(IWebDriver driver)
        {
            this.Driver = driver;
        }
        public static ApplicationPage CreateApplicationPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            ApplicationPage thisPage = new ApplicationPage(driver);
            IWebElement activeTab =  DriverHelper.FindElementWithWait(driver, @"//a[@class=""TabOn""]");
            string activeTabId = activeTab.GetAttribute("id");

            switch (activeTabId)
            {
                case "ctlAppContent_lbPriorServiceTab":
                    thisPage = new ApplicationPriorServicePage(driver);
                    //prior service tab
                    break;
                case "ctlAppContent_lbContactsTab":
                    //contact tab
                    thisPage = new ApplicationContactsPage(driver);
                    break;
                case "ctlAppContent_lbIntakeTab":
                    //intake tab
                    thisPage = new ApplicationIntakePage(driver);
                    break;
                case "ctlAppContent_lbBudgetTab":
                    //budget
                    thisPage = new ApplicationBudgetPage(driver);
                    break;
                case "ctlAppContent_lbFollowUpTab":
                    //followup
                    thisPage = new ApplicationFollowUpPage(driver);
                    break;
                case "ctlAppContent_lbBankingTab":
                    //banking
                    thisPage = new ApplicationBankingPage(driver);
                    break;
                default:
                    break;
            }
            return thisPage;
        }
        public ApplicationPriorServicePage ClickPriorServiceLink()
        {
            PriorServiceLink.Click();
            return new ApplicationPriorServicePage(Driver);
        }
        public ApplicationContactsPage ClickContactsLink()
        {
            ContactLink.Click();
            return new ApplicationContactsPage(Driver);
        }
        public ApplicationBankingPage ClickBankingLink()
        {
            BankingLink.Click();
            return new ApplicationBankingPage(Driver);
        }
        public ApplicationIntakePage ClickIntakeLink()
        {
            IntakeLink.Click();
            return new ApplicationIntakePage(Driver);
        }
        public ApplicationBudgetPage ClickBudgetLink()
        {
            BudgetLink.Click();
            return new ApplicationBudgetPage (Driver);
        }
        public ApplicationFollowUpPage ClickFollowUpLink()
        {
            FollowUpLink.Click();
            return new ApplicationFollowUpPage(Driver);
        }
    }
}


