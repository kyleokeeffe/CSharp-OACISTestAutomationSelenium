using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects.ApplicationPages
{
    public class ApplicationFollowUpPage : ApplicationPage
    {
        private IWebElement followupDate;



        public IWebElement FollowupDate
        {
            get { return followupDate == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]") : followupDate; }
            set { followupDate = value; }     
        }

            //followupDate = DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlStandardOperations_lnkNew""]")
        public ApplicationFollowUpPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
