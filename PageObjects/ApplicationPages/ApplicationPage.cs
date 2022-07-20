using OACISTestAutomationSelenium.Functional;
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
           // IWebElement activeTab = await DriverHelper.FindElementWithWait(driver, @"//div[class=""SectionTabOn""]");
            IWebElement activeTab =  DriverHelper.FindElementWithWait(driver, @"//div[class=""SectionTabOn""]");
            string activeTabId = activeTab.GetAttribute("id");

            switch (activeTabId)
            {
                case "ctlAppContent_panelTab0":
                    return (ApplicationContactsPage)thisPage;
                    //prior service tab
                    break;
                case "ctlAppContent_panelTab1":
                    //contact tab
                    return (ApplicationContactsPage)thisPage;
                    break;
                case "ctlAppContent_panelTab2":
                    //intake tab
                    return (ApplicationIntakePage)thisPage;
                    break;
                case "ctlAppContent_panelTab3":
                    //budget
                    return (ApplicationContactsPage)thisPage;
                    break;
                case "ctlAppContent_panelTab4":
                    //followup
                    return (ApplicationContactsPage)thisPage;
                    break;
                case "ctlAppContent_panelTab5":
                    //banking
                    return (ApplicationContactsPage)thisPage;
                    break;
                default:
                    return thisPage;
            }
        }
        public ApplicationPage ClickPriorServiceLink()
        {
            PriorServiceLink.Click();
            return (ApplicationPriorServicePage)this;
        }
        public ApplicationPage ClickContactsLink()
        {
            ContactLink.Click();
            return (ApplicationContactsPage)this;
        }
        public ApplicationPage ClickBankingLink()
        {
            BankingLink.Click();
            return (ApplicationBankingPage)this;
        }
        public ApplicationPage ClickIntakeLink()
        {
            IntakeLink.Click();
            return (ApplicationIntakePage)this;
        }
        public ApplicationPage ClickBudgetLink()
        {
            BudgetLink.Click();
            return (ApplicationBudgetPage)this;
        }
        public ApplicationPage ClickFollowUpLink()
        {
            FollowUpLink.Click();
            return (ApplicationFollowUpPage)this;
        }
    }
}


