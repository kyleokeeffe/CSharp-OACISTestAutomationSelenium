using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class ClientInformationPage
    {
		private IWebDriver Driver;
		private IWebElement querytxt;
		private IWebElement oAPClientNumbertxt;
		private IWebElement iIO_TransitionCodetxt;
		private IWebElement registrationDatetxt;
		private IWebElement lastNametxt;
		private IWebElement firstNametxt;
		private IWebElement middleNametxt;
		private IWebElement dob_txtDatectl;
		private IWebElement doNInvitationDate_txtDatectl;
		private IWebElement iIO_InvitationSentDatetxt;
		private IWebElement iIO_DossierSentDatetxt;
		private IWebElement consentProviderNametxt;
		private IWebElement dateFieldNoTransferConfirmedDate_txtDate;
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

		public IWebElement Querytxt
		{
			get => querytxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : querytxt;
			set => querytxt = value;
		}
		public IWebElement OAPClientNumbertxt
		{
			get => oAPClientNumbertxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtOAPClientNumber""]") : oAPClientNumbertxt;
			set => oAPClientNumbertxt = value;
		}
		public IWebElement IIO_TransitionCodetxt
		{
			get => iIO_TransitionCodetxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_TransitionCode""]") : iIO_TransitionCodetxt;
			set => iIO_TransitionCodetxt = value;
		}
		public IWebElement RegistrationDatetxt
		{
			get => registrationDatetxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtRegistrationDate""]") : registrationDatetxt;
			set => registrationDatetxt = value;
		}
		public IWebElement LastNametxt
		{
			get => lastNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtLastName""]") : lastNametxt;
			set => lastNametxt = value;
		}
		public IWebElement FirstNametxt
		{
			get => firstNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtFirstName""]") : firstNametxt;
			set => firstNametxt = value;
		}
		public IWebElement MiddleNametxt
		{
			get => middleNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtMiddleName""]") : middleNametxt;
			set => middleNametxt = value;
		}
		public IWebElement Dob_txtDatectl
		{
			get => dob_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDob_txtDate""]") : dob_txtDatectl;
			set => dob_txtDatectl = value;
		}
		public IWebElement DoNInvitationDate_txtDatectl
		{
			get => doNInvitationDate_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDoNInvitationDate_txtDate""]") : doNInvitationDate_txtDatectl;
			set => doNInvitationDate_txtDatectl = value;
		}
		public IWebElement IIO_InvitationSentDatetxt
		{
			get => iIO_InvitationSentDatetxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_InvitationSentDate""]") : iIO_InvitationSentDatetxt;
			set => iIO_InvitationSentDatetxt = value;
		}
		public IWebElement IIO_DossierSentDatetxt
		{
			get => iIO_DossierSentDatetxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_DossierSentDate""]") : iIO_DossierSentDatetxt;
			set => iIO_DossierSentDatetxt = value;
		}
		public IWebElement ConsentProviderNametxt
		{
			get => consentProviderNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtConsentProviderName""]") : consentProviderNametxt;
			set => consentProviderNametxt = value;
		}
		public IWebElement DateFieldNoTransferConfirmedDate_txtDate
		{
			get => dateFieldNoTransferConfirmedDate_txtDate == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_DateFieldNoTransferConfirmedDate_txtDate""]") : dateFieldNoTransferConfirmedDate_txtDate;
			set => dateFieldNoTransferConfirmedDate_txtDate = value;
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

		public ClientInformationPage(IWebDriver driver)
		{
			DriverHelper.WaitForPageLoad(driver);
			this.Driver = driver;
		}
		public ClientInformationPage FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillOAPClientNumbertxt(string text)
		{
			OAPClientNumbertxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillIIO_TransitionCodetxt(string text)
		{
			IIO_TransitionCodetxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillRegistrationDatetxt(string text)
		{
			RegistrationDatetxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillLastNametxt(string text)
		{
			LastNametxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillFirstNametxt(string text)
		{
			FirstNametxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillMiddleNametxt(string text)
		{
			MiddleNametxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillDob_txtDatectl(string text)
		{
			Dob_txtDatectl.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillDoNInvitationDate_txtDatectl(string text)
		{
			DoNInvitationDate_txtDatectl.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillIIO_InvitationSentDatetxt(string text)
		{
			IIO_InvitationSentDatetxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillIIO_DossierSentDatetxt(string text)
		{
			IIO_DossierSentDatetxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillConsentProviderNametxt(string text)
		{
			ConsentProviderNametxt.SendKeys(text);
			return this;
		}
		public ClientInformationPage FillDateFieldNoTransferConfirmedDate_txtDate(string text)
		{
			DateFieldNoTransferConfirmedDate_txtDate.SendKeys(text);
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
		//public Place_Holder ClickNewlnk()
		//{
		//	Newlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ClientInformationPage ClickSavelnk()
		{

			Savelnk.Click();
			DriverHelper.WaitForPageLoad(Driver);
			if (IIO_TransitionCodetxt.Text == "" || String.IsNullOrEmpty(IIO_TransitionCodetxt.Text)) 
			{
				Savelnk.Click();
				DriverHelper.WaitForPageLoad(Driver);
			}
			return this;
		}
		//public Place_Holder ClickDeletelnk()
		//{
		//	Deletelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickListlnk()
		//{
		//	Listlnk.Click();
		//	return new Place_Holder(Driver);
		//}
		//public Place_Holder ClickMergelnk()
		//{
		//	Mergelnk.Click();
		//	return new Place_Holder(Driver);
		//}
		public ApplicationsListPage ClickApplicationslnk()
		{
			Applicationslnk.Click();
			return new ApplicationsListPage(Driver);
		}
	}
}
