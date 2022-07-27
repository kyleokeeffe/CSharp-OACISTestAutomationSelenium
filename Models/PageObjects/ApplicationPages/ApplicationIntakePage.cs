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
    public class ApplicationIntakePage:ApplicationPage
    {
		
		private IWebElement querytxt;
		private IWebElement applicationReceivedDate_txtDatectl;
		private IWebElement appHourReceivedtxt;
		private IWebElement appMinuteReceivedtxt;
		private IWebElement informationLetterDate_txtDatectl;
		private IWebElement letterSentDate_txtDatectl;
		private IWebElement unreconciledAmounttxt;
		private IWebElement consentDate_txtDatectl;
		private IWebElement schoolBoardtxt;
		private IWebElement schoolNametxt;
		private IWebElement applicationCompletedDate_txtDatectl;
		private IWebElement ddlAMPMSelect;
		private IWebElement ddlIntakeProcessSelect;
		private IWebElement ddlAppTypeSelect;
		private IWebElement ddlAgeProofSelect;
		private IWebElement ddlResidencyProofSelect;
		private IWebElement ddlConsentSelect;
		private IWebElement ddlAttendingSchoolSelect;

		public IWebElement Querytxt
		{
			get => querytxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : querytxt;
			set => querytxt = value;
		}
		public IWebElement ApplicationReceivedDate_txtDatectl
		{
			get => applicationReceivedDate_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlApplicationReceivedDate_txtDate""]") : applicationReceivedDate_txtDatectl;
			set => applicationReceivedDate_txtDatectl = value;
		}
		public IWebElement AppHourReceivedtxt
		{
			get => appHourReceivedtxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtAppHourReceived""]") : appHourReceivedtxt;
			set => appHourReceivedtxt = value;
		}
		public IWebElement AppMinuteReceivedtxt
		{
			get => appMinuteReceivedtxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtAppMinuteReceived""]") : appMinuteReceivedtxt;
			set => appMinuteReceivedtxt = value;
		}
		public IWebElement InformationLetterDate_txtDatectl
		{
			get => informationLetterDate_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlInformationLetterDate_txtDate""]") : informationLetterDate_txtDatectl;
			set => informationLetterDate_txtDatectl = value;
		}
		public IWebElement LetterSentDate_txtDatectl
		{
			get => letterSentDate_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlLetterSentDate_txtDate""]") : letterSentDate_txtDatectl;
			set => letterSentDate_txtDatectl = value;
		}
		public IWebElement UnreconciledAmounttxt
		{
			get => unreconciledAmounttxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtUnreconciledAmount""]") : unreconciledAmounttxt;
			set => unreconciledAmounttxt = value;
		}
		public IWebElement ConsentDate_txtDatectl
		{
			get => consentDate_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlConsentDate_txtDate""]") : consentDate_txtDatectl;
			set => consentDate_txtDatectl = value;
		}
		public IWebElement SchoolBoardtxt
		{
			get => schoolBoardtxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtSchoolBoard""]") : schoolBoardtxt;
			set => schoolBoardtxt = value;
		}
		public IWebElement SchoolNametxt
		{
			get => schoolNametxt == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtSchoolName""]") : schoolNametxt;
			set => schoolNametxt = value;
		}
		public IWebElement ApplicationCompletedDate_txtDatectl
		{
			get => applicationCompletedDate_txtDatectl == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlApplicationCompletedDate_txtDate""]") : applicationCompletedDate_txtDatectl;
			set => applicationCompletedDate_txtDatectl = value;
		}

		public IWebElement ddlAMPM
		{
			get => ddlAMPMSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAMPM""]") : ddlAMPMSelect;
			set => ddlAMPMSelect = value;
		}
		public IWebElement ddlIntakeProcess
		{
			get => ddlIntakeProcessSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlIntakeProcess""]") : ddlIntakeProcessSelect;
			set => ddlIntakeProcessSelect = value;
		}
		public IWebElement ddlAppType
		{
			get => ddlAppTypeSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAppType""]") : ddlAppTypeSelect;
			set => ddlAppTypeSelect = value;
		}
		public IWebElement ddlAgeProof
		{
			get => ddlAgeProofSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAgeProof""]") : ddlAgeProofSelect;
			set => ddlAgeProofSelect = value;
		}
		public IWebElement ddlResidencyProof
		{
			get => ddlResidencyProofSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlResidencyProof""]") : ddlResidencyProofSelect;
			set => ddlResidencyProofSelect = value;
		}
		public IWebElement ddlConsent
		{
			get => ddlConsentSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlConsent""]") : ddlConsentSelect;
			set => ddlConsentSelect = value;
		}
		public IWebElement ddlAttendingSchool
		{
			get => ddlAttendingSchoolSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAttendingSchool""]") : ddlAttendingSchoolSelect;
			set => ddlAttendingSchoolSelect = value;
		}

		public ApplicationIntakePage(IWebDriver driver):base(driver)
		{
			DriverHelper.WaitForPageLoad(driver);
		
		}
		public ApplicationIntakePage FillQuerytxt(string text)
		{
			Querytxt.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillApplicationReceivedDate_txtDatectl(string text)
		{
			ApplicationReceivedDate_txtDatectl.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillAppHourReceivedtxt(string text)
		{
			AppHourReceivedtxt.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillAppMinuteReceivedtxt(string text)
		{
			AppMinuteReceivedtxt.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillInformationLetterDate_txtDatectl(string text)
		{
			InformationLetterDate_txtDatectl.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillLetterSentDate_txtDatectl(string text)
		{
			LetterSentDate_txtDatectl.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillUnreconciledAmounttxt(string text)
		{
			UnreconciledAmounttxt.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillConsentDate_txtDatectl(string text)
		{
			ConsentDate_txtDatectl.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillSchoolBoardtxt(string text)
		{
			SchoolBoardtxt.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillSchoolNametxt(string text)
		{
			SchoolNametxt.SendKeys(text);
			return this;
		}
		public ApplicationIntakePage FillApplicationCompletedDate_txtDatectl(string text)
		{
			ApplicationCompletedDate_txtDatectl.SendKeys(text);
			return this;
		}

		public ApplicationIntakePage SelectOptionddlAMPM(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlAMPM);
			ddlAMPM.Click();
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
		public ApplicationIntakePage SelectOptionddlIntakeProcess(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlIntakeProcess);
			ddlIntakeProcess.Click();
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
		public ApplicationIntakePage SelectOptionddlAppType(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlAppType);
			ddlAppType.Click();
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
		public ApplicationIntakePage SelectOptionddlAgeProof(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlAgeProof);
			ddlAgeProof.Click();
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
		public ApplicationIntakePage SelectOptionddlResidencyProof(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlResidencyProof);
			ddlResidencyProof.Click();
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
		public ApplicationIntakePage SelectOptionddlConsent(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlConsent);
			ddlConsent.Click();
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
		public ApplicationIntakePage SelectOptionddlAttendingSchool(int optionNum)
		{
			Actions action = new Actions(Driver);
			SelectElement elementAsSelect = new SelectElement(ddlAttendingSchool);
			ddlAttendingSchool.Click();
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
