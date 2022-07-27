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
		private IWebElement querytxt;
		private IWebElement mainlnk;
		private IWebElement queuelnk;
		private IWebElement clientlnk;
		private IWebElement maintenancelnk;
		private IWebElement reportslnk;
		private IWebElement supplierSearchlnk;
		public static string BrowserWindowHandle { get; set; }

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

		public LandingPage(IWebDriver driver)
		{
			DriverHelper.WaitForPageLoad(driver);
			this.Driver = driver;
			BrowserWindowHandle = Driver.CurrentWindowHandle;
		}
		public LandingPage FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		public LandingPage ClickMainlnk()
		{
			Mainlnk.Click();
			return this;
		}
		//public Place_Holder ClickQueuelnk()
		//{
		//	Queuelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ClientSearchPage ClickClientlnk()
		{
			Clientlnk.Click();
			return new ClientSearchPage(Driver);
		}
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
		//public Place_Holder ClickSupplierSearchlnk()
		//{
		//	SupplierSearchlnk.Click();
		//	return new Place_Holder(Driver);
		//}

		public ClientSearchPage SubmitSearchField(string searchTerm)
        {
            Querytxt.SendKeys(searchTerm);
			Querytxt.SendKeys(Keys.Return);
            return new ClientSearchPage(Driver);
        }

       
    }
}
