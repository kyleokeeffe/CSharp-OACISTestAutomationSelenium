using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class ApplicationIntakePage:ApplicationPage
    {
        private IWebElement appReceivedDateField;
        private IWebElement intakeProcessSelect;
        private IWebElement familyInfoLetterDateField;
        private IWebElement fundingInvSentDateField;
        private IWebElement applicantTypeSelect;
        private IWebElement proofOfDiagnosisChkBx;
        private IWebElement unreconciledAmountField;
        private IWebElement priorUnreconciledChkBx;
        private IWebElement proofOfAgeProvidedSelect;
        private IWebElement proofOfResidencyProvidedSelect;
        private IWebElement consentChkBx;
        private IWebElement consentProvidedByField;
        private IWebElement dateOfConsentField;
        private IWebElement attendingSchoolSelect;
        private IWebElement schoolBoardField;
        private IWebElement schoolField;
        private IWebElement applicationCompletedField;

        public IWebElement AppReceivedDateField
        {
            get => appReceivedDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlApplicationReceivedDate_txtDate""]") : appReceivedDateField;
            set => appReceivedDateField = value;
        }
        public IWebElement IntakeProcessSelect
        {
            get => intakeProcessSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlIntakeProcess""]") : intakeProcessSelect;
            set => intakeProcessSelect = value;
        }
        public IWebElement FamilyInfoLetterDateField
        {
            get => familyInfoLetterDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlInformationLetterDate_txtDate""]") : familyInfoLetterDateField;
            set => familyInfoLetterDateField = value;
        }
        public IWebElement FundingInvSentDateField
        {
            get => fundingInvSentDateField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlLetterSentDate_txtDate""]") : fundingInvSentDateField;
            set => fundingInvSentDateField = value;
        }
        public IWebElement ApplicantTypeSelect
        {
            get => applicantTypeSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAppType""]") : applicantTypeSelect;
            set => applicantTypeSelect = value;
        }
        public IWebElement ProofOfDiagnosisChkBx
        {
            get => proofOfDiagnosisChkBx == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_chkDiagnosisProof""]") : proofOfDiagnosisChkBx;
            set => proofOfDiagnosisChkBx = value;
        }
        public IWebElement UnreconciledAmountField
        {
            get => unreconciledAmountField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtUnreconciledAmount""]") : unreconciledAmountField;
            set => unreconciledAmountField = value;
        }
        public IWebElement PriorUnreconciledChkBx
        {
            get => priorUnreconciledChkBx == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_chkPriorUnreconciled""]") : priorUnreconciledChkBx;
            set => priorUnreconciledChkBx = value;
        }
        public IWebElement ProofOfAgeProvidedSelect
        {
            get => proofOfAgeProvidedSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAgeProof""]") : proofOfAgeProvidedSelect;
            set => proofOfAgeProvidedSelect = value;
        }
        public IWebElement ProofOfResidencyProvidedSelect
        {
            get => proofOfResidencyProvidedSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlResidencyProof""]") : proofOfResidencyProvidedSelect;
            set => proofOfResidencyProvidedSelect = value;
        }
        public IWebElement ConsentChkBx
        {
            get => consentChkBx == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_chkConsent""]") : consentChkBx;
            set => consentChkBx = value;
        }
        public IWebElement ConsentProvidedByField
        {
            get => consentProvidedByField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlConsent""]") : consentProvidedByField;
            set => consentProvidedByField = value;
        }
        public IWebElement DateOfConsentField
        {
            get => dateOfConsentField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlConsentDate_txtDate""]") : dateOfConsentField;
            set => dateOfConsentField = value;
        }
        public IWebElement AttendingSchoolSelect
        {
            get => attendingSchoolSelect == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ddlAttendingSchool""]") : attendingSchoolSelect;
            set => attendingSchoolSelect = value;
        }
        public IWebElement SchoolBoardField
        {
            get => schoolBoardField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtSchoolBoard""]") : schoolBoardField;
            set => schoolBoardField = value;
        }
        public IWebElement SchoolField
        {
            get => schoolField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_txtSchoolName""]") : schoolField;
            set => schoolField = value;
        }
        public IWebElement ApplicationCompletedField
        {
            get => applicationCompletedField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_ctlApplicationCompletedDate_txtDate""]") : applicationCompletedField;
            set => applicationCompletedField = value;
        }

        public ApplicationIntakePage(IWebDriver driver) : base(driver)
        {
            
        }
        //public IWebElement GetAppReceivedDateField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ctlApplicationReceivedDate_txtDate""]");
        // public IWebElement GetIntakeProcessSelect() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlIntakeProcess""]");
        //public IWebElement GetFamilyInfoLetterDateField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ctlInformationLetterDate_txtDate""]");
        //public IWebElement GetFundingInvRequiredChkBx() => DriverHelper.FindElementWithWait(base.Driver, @"");

        // public IWebElement GetfundingInvSentDateField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ctlLetterSentDate_txtDate""]");
        //public IWebElement GetapplicantTypeSelect() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlAppType""]");
        //public IWebElement GetpriorUnreconciledChkBx() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_chkPriorUnreconciled""]");

        //public IWebElement GetunreconciledAmountField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtUnreconciledAmount""]");
        // public IWebElement GetproofOfDiagnosisChkBx() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_chkDiagnosisProof""]");

        //public IWebElement GetproofOfAgeProvidedSelect() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlAgeProof""]");
        //public IWebElement GetproofOfResidencyProvidedSelect() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlResidencyProof""]");
        //public IWebElement GetconsentChkBx() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_chkConsent""]");

        //public IWebElement GetconsentProvidedByField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlConsent""]");
        //public IWebElement GetdateOfConsentField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ctlConsentDate_txtDate""]");
        // public IWebElement GetattendingSchoolSelect() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ddlAttendingSchool""]");
        //public IWebElement GetschoolBoardField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtSchoolBoard""]");
        //public IWebElement GetschoolField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_txtSchoolName""]");
        //public IWebElement GetapplicationCompletedField() => DriverHelper.FindElementWithWait(base.Driver, @"//*[@id=""ctlAppContent_ctlApplicationCompletedDate_txtDate""]");
    }
}
