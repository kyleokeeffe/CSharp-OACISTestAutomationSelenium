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
        private IWebElement clientNumberField;
        private IWebElement iIOTransitionCodeField;
        private IWebElement lockStatusSelect;
        private IWebElement registrationDate;
        private IWebElement lastNameField;
        private IWebElement firstNameField;
        private IWebElement dobField;
        private IWebElement iIOInvSentDateField;
        private IWebElement iIODossierSentDateField;
        private IWebElement dDonInvDateField;
        private IWebElement consentProviderName;
        private IWebElement consentDeclinedDateField;
        private IWebElement newButton;
        private IWebElement saveButton;
        private IWebElement applicationsButton;

        public IWebElement ClientNumberField
        {
            get => clientNumberField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtOAPClientNumber""]") : clientNumberField;
            set => clientNumberField = value;
        }
        public IWebElement IIOTransitionCodeField
        {
            get => iIOTransitionCodeField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_TransitionCode""]") : iIOTransitionCodeField;
            set => iIOTransitionCodeField = value;
        }
        public IWebElement LockStatusSelect
        {
            get => lockStatusSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtRegistrationDate""]") : lockStatusSelect;
            set => lockStatusSelect = value;
        }
        public IWebElement RegistrationDate
        {
            get => registrationDate == null ? DriverHelper.FindElementWithWait(Driver, @" //*[@id=""ctlClientContent_ddl_LockStatus""]") : registrationDate;
            set => registrationDate = value;
        }
        public IWebElement LastNameField
        {
            get => lastNameField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtLastName""]") : lastNameField;
            set => lastNameField = value;
        }
        public IWebElement FirstNameField
        {
            get => firstNameField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtFirstName""]") : firstNameField;
            set => firstNameField = value;
        }
        public IWebElement DobField
        {
            get => dobField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDob_txtDate""]") : dobField;
            set => dobField = value;
        }
        public IWebElement IIOInvSentDateField
        {
            get => iIOInvSentDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_InvitationSentDate""]") : iIOInvSentDateField;
            set => iIOInvSentDateField = value;
        }
        public IWebElement IIODossierSentDateField
        {
            get => iIODossierSentDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_DossierSentDate""]") : iIODossierSentDateField;
            set => iIODossierSentDateField = value;
        }
        public IWebElement DonInvDateField
        {
            get => dDonInvDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDoNInvitationDate_txtDate""]") : dDonInvDateField;
            set => dDonInvDateField = value;
        }
        public IWebElement ConsentProviderName
        {
            get => consentProviderName == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtConsentProviderName""]") : consentProviderName;
            set => consentProviderName = value;
        }
        public IWebElement ConsentDeclinedDateField
        {
            get => consentDeclinedDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_DateFieldNoTransferConfirmedDate_txtDate""]") : consentDeclinedDateField;
            set => consentDeclinedDateField = value;
        }
        public IWebElement NewButton
        {
            get => newButton == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]") : newButton;
            set => newButton = value;
        }
        public IWebElement SaveButton
        {
            get => saveButton == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkSave""]") : saveButton;
            set => saveButton = value;
        }
        public IWebElement ApplicationsButton
        {
            get => applicationsButton == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkApplications""]") : applicationsButton;
            set => applicationsButton = value;
        }


        public ClientInformationPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
        }
        // public IWebElement GetClientNumberField()
        //  {
        //      return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtOAPClientNumber""]");
        //  }



        //public IWebElement GetIIOTransitionCodeField()
        //{
        //      return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_TransitionCode""]");
        //  }




        //public IWebElement getLockStatusSelect()
        // {
        //     return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtRegistrationDate""]");
        // }


        //public IWebElement getRegistrationDate()
        //{
        //      return DriverHelper.FindElementWithWait(Driver, @" //*[@id=""ctlClientContent_ddl_LockStatus""]");
        //}

        // public IWebElement GetLastNameField()
        //  {
        //      return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtLastName""]");
        //  }


        // public IWebElement GetfirstNameField()
        //  {
        //      return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtFirstName""]");
        //  }


        // public IWebElement GetdobField()
        // {
        //     return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDob_txtDate""]");
        //
        // }


        // public IWebElement GetIIOInvSentDateField()
        // {
        //    return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_InvitationSentDate""]");

        //}


        //public IWebElement GetIIODossierSentDateField()
        // {
        //     return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtIIO_DossierSentDate""]");

        // }



        // public IWebElement GetDonInvDateField()
        // {
        //     return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_ctlDoNInvitationDate_txtDate""]");

        // }



        //public IWebElement GetConsentProviderName()
        //  {
        //      return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_txtConsentProviderName""]");

        //  }


        // public IWebElement GetConsentDeclinedDateField()
        //  {
        //     return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlClientContent_DateFieldNoTransferConfirmedDate_txtDate""]");

        //   }


        //  public IWebElement GetNewButton()
        //  {
        //      return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]");

        //  }

        // public IWebElement GetSaveButton()
        // {
        //     return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkSave""]");

        // }
        ///public IWebElement GetApplicationsButton()
        /// {
        //    return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPageNav_lnkApplications""]");

        // }


        public ApplicationsListPage ClickApplicationsLink()
        {
            ApplicationsButton.Click();
            return  new ApplicationsListPage(Driver);
        }

        public ClientInformationPage ClickSaveButton()
        {
            SaveButton.Click();
            DriverHelper.WaitForPageLoad(Driver);
            return this;
        }

        public ClientInformationPage FillLNameField(string text)
        {
            LastNameField.SendKeys(text);
            return this;
        }

        public ClientInformationPage FillClientNumberField(string text)
        { 
            ClientNumberField.SendKeys(text); 
            return this; 
        }

        public ClientInformationPage FillIIOTransitionCodeField(string text)
        {
            IIOTransitionCodeField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillLockStatusSelect(string text)
        {
            LockStatusSelect.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillRegistrationDate(string text)
        {
            RegistrationDate.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillLastNameField(string text)
        {
            LastNameField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillFirstNameField(string text)
        {
            FirstNameField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillDobField(string text)
        {
            DobField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillIIOInvSentDateField(string text)
        {
            IIOInvSentDateField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillIIODossierSentDateField(string text)
        {
            IIODossierSentDateField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillDDonInvDateField(string text)
        {
            DonInvDateField.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillConsentProviderName(string text)
        {
            ConsentProviderName.SendKeys(text);
            return this;
        }
        public ClientInformationPage FillConsentDeclinedDateField(string text)
        {
            ConsentDeclinedDateField.SendKeys(text);
            return this;
        }

    }
}
