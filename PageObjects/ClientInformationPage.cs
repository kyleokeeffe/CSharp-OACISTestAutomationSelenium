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




        public ClientInformationPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
          
         


        }

        public IWebElement GetClientNumberField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtOAPClientNumber""]");
        }

        public IWebElement GetIIOTransitionCodeField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_TransitionCode""]");
        }

        public IWebElement GetLockStatusSelect()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtRegistrationDate""]");
        }

        public IWebElement GetRegistrationDate()
        {
            return DriverHelper.FindElementWithWait(Driver, @" //*[@id=""ctlClientContent_ddl_LockStatus""]");
        }
       
        public IWebElement GetLastNameField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtLastName""]");
        }

        public IWebElement GetFirstNameField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtFirstName""]");
        }

        public IWebElement GetDobField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDob_txtDate""]");

        }

        public IWebElement GetIIOInvSentDateField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_InvitationSentDate""]");

        }

        public IWebElement GetIIODossierSentDateField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_DossierSentDate""]");

        }

        public IWebElement GetDonInvDateField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDoNInvitationDate_txtDate""]");

        }

        public IWebElement GetConsentProviderName()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtConsentProviderName""]");

        }

        public IWebElement GetConsentDeclinedDateField()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_DateFieldNoTransferConfirmedDate_txtDate""]");

        }

        public IWebElement GetNewButton()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]");

        }

        public IWebElement GetSaveButton()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkSave""]");

        }


        public IWebElement GetApplicationsButton()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkApplications""]");

        }


        public ApplicationsListPage ClickApplicationsLink()
        {
            GetApplicationsButton().Click();
            return  new ApplicationsListPage(Driver);
        }
    }
}
