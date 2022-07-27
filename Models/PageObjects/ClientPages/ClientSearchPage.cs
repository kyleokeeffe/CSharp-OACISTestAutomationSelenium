﻿using OACISTestAutomationSelenium.Functional;
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


		private IWebDriver Driver;
		private IWebElement querytxt;
		private IWebElement nametxt;
		private IWebElement mainlnk;
		private IWebElement queuelnk;
		private IWebElement clientlnk;
		private IWebElement maintenancelnk;
		private IWebElement reportslnk;
		private IWebElement newlnk;
		private IWebElement savelnk;
		private IWebElement deletelnk;
		private IWebElement listlnk;
		private IWebElement mergelnk;
		private IWebElement applicationslnk;
		private IWebElement searchlnk;

		public IWebElement Querytxt
		{
			get => querytxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : querytxt;
			set => querytxt = value;
		}
		public IWebElement Nametxt
		{
			get => nametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientSearch_txtName""]") : nametxt;
			set => nametxt = value;
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
		public IWebElement Listlnk
		{
			get => listlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkList""]") : listlnk;
			set => listlnk = value;
		}
		public IWebElement Mergelnk
		{
			get => mergelnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkMerge""]") : mergelnk;
			set => mergelnk = value;
		}
		public IWebElement Applicationslnk
		{
			get => applicationslnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkApplications""]") : applicationslnk;
			set => applicationslnk = value;
		}
		public IWebElement Searchlnk
		{
			get => searchlnk == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientSearch_lnkSearch""]") : searchlnk;
			set => searchlnk = value;
		}
		public PageTables Tables { get; set; }

		public ClientSearchPage(IWebDriver driver)
		{
			DriverHelper.WaitForPageLoad(driver);
			this.Driver = driver;
			this.Tables = new PageTables(driver);
		}
		public ClientSearchPage FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		public ClientSearchPage FillNametxt(string text)
		{
			Nametxt.SendKeys(text);
			return this;
		}
		public LandingPageAutoGen ClickMainlnk()
		{
			Mainlnk.Click();
			return new LandingPageAutoGen(Driver);
		}
		//public Place_Holder ClickQueuelnk()
		//{
		//	Queuelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ClientSearchPage ClickClientlnk()
		{
			Clientlnk.Click();
			return this;
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
		public ClientInformationPage ClickNewlnk()
		{
			Newlnk.Click();
			return new ClientInformationPage(Driver);
		}
		public ClientSearchPage ClickSavelnk()
		{
			DriverHelper.WaitForPageLoad(Driver);
			Savelnk.Click();
			return this;
		}
		//public Place_Holder ClickDeletelnk()
		//{
		//	Deletelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ClientSearchPage ClickListlnk()
		{
			Listlnk.Click();
			return this;
		}
		//public Place_Holder ClickMergelnk()
		//{
		//	Mergelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickApplicationslnk()
		//{
		//	Applicationslnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickSearchlnk()
		//{
		//	Searchlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ClientInformationPage ClickFirstRow()
        {
			Tables.GetRow(1).Click();

			return new ClientInformationPage(Driver);
		}
    }
}
