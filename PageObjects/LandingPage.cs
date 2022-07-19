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
        private IWebElement searchField;



        public LandingPage(IWebDriver driver)
        {
            DriverHelper.WaitForPageLoad(driver);
            this.Driver = driver;
        }




        public IWebElement SearchField
        {
             get => searchField == null ? DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : searchField;

            //get => searchField == null ? await DriverHelper.FindElementAsyncCaller(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]") : searchField;


          //  Window.Current.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => { Title= await GetTytleAsync(url);
   // });
          //  get => searchField == null ?  Task.Run(() => DriverHelper.FindElementAsyncCaller(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]")).GetAwaiter().GetResult():searchField;
   
            set => searchField = value;
        }
        public IWebElement GetSearchBox()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlQueryBox_txtQuery""]");
        }

        public IWebElement GetClientLink()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkClient""]");
        }

        public IWebElement GetReportsLink()
        {
            return DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlPrimaryNav_lnkReports""]");
        }




        public SearchResults Search(string searchTerm)
        {
            SearchField.SendKeys(searchTerm);
            SearchField.SendKeys(Keys.Return);
            //Elements.GetSearchBox().SendKeys(searchTerm);
            //Elements.GetSearchBox().Submit();
            return new SearchResults(Driver);
        }


        
    }
}
