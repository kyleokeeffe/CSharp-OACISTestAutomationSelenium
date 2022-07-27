using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class ApplicationContactsPage : ApplicationPage
    {
		private IWebElement? querytxt;
		private IWebElement? applicantLastNametxt;
		private IWebElement? applicantFirstNametxt;
		private IWebElement? applicantDob_txtDatectl;
		private IWebElement? referenceNumbertxt;
		private IWebElement? applicantUnittxt;
		private IWebElement? applicantStreetNumbertxt;
		private IWebElement? applicantStreettxt;
		private IWebElement? applicantPOBoxtxt;
		private IWebElement? applicantCitytxt;
		private IWebElement? applicantPostalCodetxt;
		private IWebElement? applicantEmailtxt;
		private IWebElement? phoneHometxt;
		private IWebElement? applicantExt1txt;
		private IWebElement? phoneCelltxt;
		private IWebElement? applicantExt2txt;
		private IWebElement? applicantOtherLanguagetxt;

		private IWebElement? ddlApplicantProvinceSelect;
		private IWebElement? ddlApplicantLanguageSelect;

		public IWebElement Querytxt
		{
			get => querytxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : querytxt;
			set => querytxt = value;
		}
		public IWebElement ApplicantLastNametxt
		{
			get => applicantLastNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantLastName""]") : applicantLastNametxt;
			set => applicantLastNametxt = value;
		}
		public IWebElement ApplicantFirstNametxt
		{
			get => applicantFirstNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantFirstName""]") : applicantFirstNametxt;
			set => applicantFirstNametxt = value;
		}
		public IWebElement ApplicantDob_txtDatectl
		{
			get => applicantDob_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlApplicantDob_txtDate""]") : applicantDob_txtDatectl;
			set => applicantDob_txtDatectl = value;
		}
		public IWebElement ReferenceNumbertxt
		{
			get => referenceNumbertxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtReferenceNumber""]") : referenceNumbertxt;
			set => referenceNumbertxt = value;
		}
		public IWebElement ApplicantUnittxt
		{
			get => applicantUnittxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantUnit""]") : applicantUnittxt;
			set => applicantUnittxt = value;
		}
		public IWebElement ApplicantStreetNumbertxt
		{
			get => applicantStreetNumbertxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantStreetNumber""]") : applicantStreetNumbertxt;
			set => applicantStreetNumbertxt = value;
		}
		public IWebElement ApplicantStreettxt
		{
			get => applicantStreettxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantStreet""]") : applicantStreettxt;
			set => applicantStreettxt = value;
		}
		public IWebElement ApplicantPOBoxtxt
		{
			get => applicantPOBoxtxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantPOBox""]") : applicantPOBoxtxt;
			set => applicantPOBoxtxt = value;
		}
		public IWebElement ApplicantCitytxt
		{
			get => applicantCitytxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantCity""]") : applicantCitytxt;
			set => applicantCitytxt = value;
		}
		public IWebElement ApplicantPostalCodetxt
		{
			get => applicantPostalCodetxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantPostalCode""]") : applicantPostalCodetxt;
			set => applicantPostalCodetxt = value;
		}
		public IWebElement ApplicantEmailtxt
		{
			get => applicantEmailtxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantEmail""]") : applicantEmailtxt;
			set => applicantEmailtxt = value;
		}
		public IWebElement PhoneHometxt
		{
			get => phoneHometxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtPhoneHome""]") : phoneHometxt;
			set => phoneHometxt = value;
		}
		public IWebElement ApplicantExt1txt
		{
			get => applicantExt1txt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantExt1""]") : applicantExt1txt;
			set => applicantExt1txt = value;
		}
		public IWebElement PhoneCelltxt
		{
			get => phoneCelltxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtPhoneCell""]") : phoneCelltxt;
			set => phoneCelltxt = value;
		}
		public IWebElement ApplicantExt2txt
		{
			get => applicantExt2txt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantExt2""]") : applicantExt2txt;
			set => applicantExt2txt = value;
		}
		public IWebElement ApplicantOtherLanguagetxt
		{
			get => applicantOtherLanguagetxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantOtherLanguage""]") : applicantOtherLanguagetxt;
			set => applicantOtherLanguagetxt = value;
		}
		
		public IWebElement ddlApplicantProvince
		{
			get => ddlApplicantProvinceSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlApplicantProvince""]") : ddlApplicantProvinceSelect;
			set => ddlApplicantProvinceSelect = value;
		}
		public IWebElement ddlApplicantLanguage
		{
			get => ddlApplicantLanguageSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlApplicantLanguage""]") : ddlApplicantLanguageSelect;
			set => ddlApplicantLanguageSelect = value;
		}

		public ApplicationContactsPage(IWebDriver driver) : base(driver)
		{
			DriverHelper.WaitForPageLoad(driver);
	
		}
		public ApplicationContactsPage FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantLastNametxt(string text)
		{
			ApplicantLastNametxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantFirstNametxt(string text)
		{
			ApplicantFirstNametxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantDob_txtDatectl(string text)
		{
			ApplicantDob_txtDatectl.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillReferenceNumbertxt(string text)
		{
			ReferenceNumbertxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantUnittxt(string text)
		{
			ApplicantUnittxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantStreetNumbertxt(string text)
		{
			ApplicantStreetNumbertxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantStreettxt(string text)
		{
			ApplicantStreettxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantPOBoxtxt(string text)
		{
			ApplicantPOBoxtxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantCitytxt(string text)
		{
			ApplicantCitytxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantPostalCodetxt(string text)
		{
			ApplicantPostalCodetxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantEmailtxt(string text)
		{
			ApplicantEmailtxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillPhoneHometxt(string text)
		{
			PhoneHometxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantExt1txt(string text)
		{
			ApplicantExt1txt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillPhoneCelltxt(string text)
		{
			PhoneCelltxt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantExt2txt(string text)
		{
			ApplicantExt2txt.SendKeys(text);
			return this;
		}
		public ApplicationContactsPage FillApplicantOtherLanguagetxt(string text)
		{
			ApplicantOtherLanguagetxt.SendKeys(text);
			return this;
		}
		
		public ApplicationContactsPage SelectOptionddlApplicantProvince(string optionText)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlApplicantProvince);
			ddlApplicantProvince.Click();
			IList<IWebElement> selectOptions = elementAsSelect.Options;
			int? matchingOptionNum = null;
			for (int i = 0; i < selectOptions.Count; i++)
			{
				if(selectOptions[i].Text == optionText)
                {
					matchingOptionNum = i;
					break;
                }
			}

			if (matchingOptionNum != null)
			{
				for (int i = 0; i < matchingOptionNum; i++)
				{
					action.SendKeys(Keys.Down);
				}
			}
			else
			{
				string allOptions = "";
				foreach (var option in selectOptions)
					allOptions += $"\t{option.Text}\n";
				throw new Exception($"Option value {optionText} not found in select list. List contains the following values:\n{allOptions}");
			}

			action.SendKeys(Keys.Tab);
			action.Build().Perform();
			Driver.SwitchTo().Window(LandingPage.BrowserWindowHandle);
			return this;
		}
		public ApplicationContactsPage SelectOptionddlApplicantProvince(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlApplicantProvince);
			ddlApplicantProvince.Click();
			var selectOptions = elementAsSelect.Options;

			for (int i = 0; i < optionNum; i++)
			{
				action.SendKeys(Keys.Down);
			}
			action.SendKeys(Keys.Tab);
			action.Build().Perform();
			Driver.SwitchTo().Window(LandingPage.BrowserWindowHandle);
			return this;
		}
		public ApplicationContactsPage SelectOptionddlApplicantLanguage(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlApplicantLanguage);
			ddlApplicantLanguage.Click();
			var selectOptions = elementAsSelect.Options;
			for (int i = 0; i < optionNum; i++)
			{
				action.SendKeys(Keys.Down);
			}
			action.SendKeys(Keys.Tab);
			action.Build().Perform();
			Driver.SwitchTo().Window(LandingPage.BrowserWindowHandle);
			return this;
		}
	}
}
