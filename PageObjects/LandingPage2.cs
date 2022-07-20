using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    internal class LandingPage2
    {
		private IWebDriver Driver;
		private IWebElement querytxt;
		private IWebElement mainlnk;
		private IWebElement queuelnk;
		private IWebElement clientlnk;
		private IWebElement maintenancelnk;
		private IWebElement reportslnk;
		private IWebElement supplierSearchlnk;

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
		public IWebElement SupplierSearchlnk
		{
			get => supplierSearchlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkSupplierSearch""]") : supplierSearchlnk;
			set => supplierSearchlnk = value;
		}

		public LandingPage2(IWebDriver driver)
		{
			DriverHelper.WaitForPageLoad(driver);
			this.Driver = driver;
		}
		public LandingPage2 FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		public Place_Holder ClickMainlnk(string text)
		{
			Mainlnk.Click();
			return Place_Holder;
		}
		public Place_Holder ClickQueuelnk(string text)
		{
			Queuelnk.Click();
			return Place_Holder;
		}
		public Place_Holder ClickClientlnk(string text)
		{
			Clientlnk.Click();
			return Place_Holder;
		}
		public Place_Holder ClickMaintenancelnk(string text)
		{
			Maintenancelnk.Click();
			return Place_Holder;
		}
		public Place_Holder ClickReportslnk(string text)
		{
			Reportslnk.Click();
			return Place_Holder;
		}
		public Place_Holder ClickSupplierSearchlnk(string text)
		{
			SupplierSearchlnk.Click();
			return Place_Holder;
		}


	}
}
