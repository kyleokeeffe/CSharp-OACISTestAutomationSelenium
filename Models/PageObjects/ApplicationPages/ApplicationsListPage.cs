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
		private IWebElement querytxt;
		private IWebElement mainlnk;
		private IWebElement queuelnk;
		private IWebElement clientlnk;
		private IWebElement maintenancelnk;
		private IWebElement reportslnk;
		private IWebElement newlnk;
		private IWebElement savelnk;
		private IWebElement deletelnk;
		private IWebElement appListlnk;
		private IWebElement mergelnk;
		private IWebElement expenseslnk;
		private IWebElement authorizationlnk;
		private IWebElement narrativeslnk;

		public IWebElement Querytxt
		{
			get => querytxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : querytxt;
			set => querytxt = value;
		}
		public IWebElement Mainlnk
		{
			get => mainlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkMain""]") : mainlnk;
			set => mainlnk = value;
		}
		public IWebElement Queuelnk
		{
			get => queuelnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkQueue""]") : queuelnk;
			set => queuelnk = value;
		}
		public IWebElement Clientlnk
		{
			get => clientlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkClient""]") : clientlnk;
			set => clientlnk = value;
		}
		public IWebElement Maintenancelnk
		{
			get => maintenancelnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkMaintenance""]") : maintenancelnk;
			set => maintenancelnk = value;
		}
		public IWebElement Reportslnk
		{
			get => reportslnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkReports""]") : reportslnk;
			set => reportslnk = value;
		}
		public IWebElement Newlnk
		{
			get => newlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]") : newlnk;
			set => newlnk = value;
		}
		public IWebElement Savelnk
		{
			get => savelnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkSave""]") : savelnk;
			set => savelnk = value;
		}
		public IWebElement Deletelnk
		{
			get => deletelnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkDelete""]") : deletelnk;
			set => deletelnk = value;
		}
		public IWebElement AppListlnk
		{
			get => appListlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkAppList""]") : appListlnk;
			set => appListlnk = value;
		}
		public IWebElement Mergelnk
		{
			get => mergelnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkMerge""]") : mergelnk;
			set => mergelnk = value;
		}
		public IWebElement Expenseslnk
		{
			get => expenseslnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkExpenses""]") : expenseslnk;
			set => expenseslnk = value;
		}
		public IWebElement Authorizationlnk
		{
			get => authorizationlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkAuthorization""]") : authorizationlnk;
			set => authorizationlnk = value;
		}
		public IWebElement Narrativeslnk
		{
			get => narrativeslnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppPageNav_lnkNarratives""]") : narrativeslnk;
			set => narrativeslnk = value;
		}
		
		public PageTables Tables { get; set; }

		public ApplicationsListPage(IWebDriver driver)
		{
			DriverHelper.WaitForPageLoad(driver);
			this.Driver = driver;
			this.Tables = new PageTables(driver);
		}
		public ApplicationsListPage FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		//public Place_Holder ClickMainlnk()
		//{
		//	Mainlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickQueuelnk()
		//{
		//	Queuelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickClientlnk()
		//{
		//	Clientlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickMaintenancelnk()
		//{
		//	Maintenancelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickReportslnk()
		//{
		//	Reportslnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ApplicationContactsPage ClickNewlnk()
		{
			Newlnk.Click();
			return new ApplicationContactsPage(Driver);
		}
		//public Place_Holder ClickSavelnk()
		//{
		//	Savelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickDeletelnk()
		//{
		//	Deletelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickAppListlnk()
		//{
		//	AppListlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickMergelnk()
		//{
		//	Mergelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickExpenseslnk()
		//{
		//	Expenseslnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickAuthorizationlnk()
		//{
		//	Authorizationlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickNarrativeslnk()
		//{
		//	Narrativeslnk.Click();
		//	return new Place_Holder(Driver);
		//}

		public ApplicationPage ClickApplication(ApplicationListColumns columnName, string rowValue)
        {
            Tables.GetRow(Regex.Replace(columnName.ToString(), "(\\B[A-Z])", " $1"),rowValue).Click();
            //@"(\B[A-Z]+?(?=[A-Z][^A-Z])|\B[A-Z]+?(?=[^A-Z]))"
            return ApplicationPage.CreateApplicationPage(Driver);
        }
		public ApplicationPage ClickFirstRow()
		{

			Tables.GetRow(1).Click();

			return ApplicationPage.CreateApplicationPage(Driver);

		}

	}
}
