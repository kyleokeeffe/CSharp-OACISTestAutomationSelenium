using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Services;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects.ApplicationPages
{
    public class ApplicationBudgetPage:ApplicationPage, IPageTables
    {
        private IWebElement budgetCalcYearSelect;
        private IWebElement annualBudgetAmountField;
        private IWebElement authorizedTotalField;
        private IWebElement balanceField;
        private IWebElement fundingStartDateField;
        private IWebElement needsProfileSelect;
        private IWebElement totalReconciledExpensesLbl;
        private IWebElement totalInstalmentsPaidLbl;

        public PageTables Tables { get; set; }
        public IWebElement BudgetCalcYearSelect
        {
            get => budgetCalcYearSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlBudgetYear""]") : budgetCalcYearSelect;
            set => budgetCalcYearSelect = value;
        }
        public IWebElement AnnualBudgetAmountField
        {
            get => annualBudgetAmountField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtCurrentBudget""]") : annualBudgetAmountField;
            set => annualBudgetAmountField = value;
        }
        public IWebElement AuthorizedTotalField
        {
            get => authorizedTotalField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lblAuthorizedTotal""]") : authorizedTotalField;
            set => authorizedTotalField = value;
        }
        public IWebElement BalanceField
        {
            get => balanceField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lblBalance""]") : balanceField;
            set => balanceField = value;
        }
        public IWebElement FundingStartDateField
        {
            get => fundingStartDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlFundingStartDate_txtDate""]") : fundingStartDateField;
            set => fundingStartDateField = value;
        }
        public IWebElement NeedsProfileSelect
        {
            get => needsProfileSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlNeedsProfileLevel""]") : needsProfileSelect;
            set => needsProfileSelect = value;
        }
        public IWebElement TotalReconciledExpensesLbl
        {
            get => totalReconciledExpensesLbl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lblTotal_Reconciled_Expenses""]") : totalReconciledExpensesLbl;
            set => totalReconciledExpensesLbl = value;
        }
        public IWebElement TotalInstalmentsPaidLbl
        {
            get => totalInstalmentsPaidLbl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_lblTotal_Instalments_Paid""]") : totalInstalmentsPaidLbl;
            set => totalInstalmentsPaidLbl = value;
        }

        public ApplicationBudgetPage(IWebDriver driver) : base(driver)
        {

        }
        public AuthorizationPage ClickAuthorizationRow(string colName, string rowValue)
        {
            Tables.GetRow(colName, rowValue).Click();
            return new AuthorizationPage(Driver);
        }
    }
}
