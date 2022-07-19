using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class ApplicationContactsPage : ApplicationPage
    {
        public IWebElement lastNameField;
        public IWebElement firstNameField;
        public IWebElement dobField;
        public IWebElement referenceNumberField;
        public IWebElement unitNumberField;
        public IWebElement streetNumberField;
        public IWebElement streetNameField;
        public IWebElement pOBoxField;
        public IWebElement cityField;
        public IWebElement provinceSelect;
        public IWebElement postalCodeField;
      
        public IWebElement LastNameField 
        {
            get => lastNameField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantLastName""]") : lastNameField; 
            set => lastNameField = value; 
        }
        public IWebElement FirstNameField 
        { 
            get => firstNameField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantFirstName""]") : firstNameField; 
            set => firstNameField = value; 
        }
        public IWebElement DobField 
        { 
            get => dobField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlApplicantDob_txtDate""]") : dobField;
            set => dobField = value; 
        }
        public IWebElement ReferenceNumberField 
        {
            get => referenceNumberField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtReferenceNumber""]") : referenceNumberField;
            set => referenceNumberField = value; 
        }
        public IWebElement UnitNumberField 
        {
            get => unitNumberField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantUnit""]") : unitNumberField;
            set => unitNumberField = value; 
        }
        public IWebElement StreetNumberField 
        {
            get => streetNumberField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantStreetNumber""]") : streetNumberField; 
            set => streetNumberField = value;
        }
        public IWebElement StreetNameField 
        { 
            get => streetNameField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantStreet""]") : streetNameField; 
            set => streetNameField = value; 
        }
        public IWebElement POBoxField 
        {
            get => pOBoxField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantPOBox""]") : pOBoxField; 
            set => pOBoxField = value;
        }
        public IWebElement CityField 
        {
            get => cityField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantCity""]") : cityField;
            set => cityField = value; 
        }
        public IWebElement ProvinceSelect 
        { 
            get => provinceSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlApplicantProvince""]") : provinceSelect; 
            set => provinceSelect = value; 
        }
        public IWebElement PostalCodeField 
        { 
            get => postalCodeField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtApplicantPostalCode""]") : postalCodeField; 
            set => postalCodeField = value; 
        }

        public ApplicationContactsPage(IWebDriver driver) : base(driver)
        {

        }

        /*public IWebElement GetLastNameField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantLastName""]");
        public IWebElement GetFirstNameField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantFirstName""]");
        public IWebElement GetDobField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ctlApplicantDob_txtDate""]");
        public IWebElement GetReferenceNumberField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtReferenceNumber""]");
        public IWebElement GetUnitNumberField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantUnit""]");
        public IWebElement GetStreetNumberField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantStreetNumber""]");
        public IWebElement GetStreetNameField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantStreet""]");
        public IWebElement GetPOBoxField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantPOBox""]");
        public IWebElement GetCityField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantCity""]");
        public IWebElement GetProvinceSelect() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlApplicantProvince""]");
        public IWebElement GetPostalCodeField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtApplicantPostalCode""]");
        */




    }
}
