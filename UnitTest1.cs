using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using static OACISTestAutomationSelenium.Functional.DriverFactory;

namespace OACISTestAutomationSelenium
{
    public class Tests
    {

        public IWebDriver Driver { get; set; }
        [SetUp]
        public void Setup()
        {
           
           
            //InternetExplorerDriver Driver = DriverFactory.Initialize();
            this.Driver =  DriverFactory.Initialize();
        }

      
        

        [Test]
        public  void Test1()
        {


           // this.Driver = DriverFactory.Initialize();

            LandingPage landingPage = new LandingPage(Driver);
            landingPage
                .Search("OAP0068541")
                .ClickFirstRow()
                .ClickApplicationsLink()
                .ClickApplication("Intake Process", "Determination of Needs");

    

            IWebElement result = null;
            result =  DriverHelper.FindElementWithWait(Driver, @"//*[@id=""ctlAppContent_panelStatus""]");

            Assert.IsNotNull(result);

         
        }

        [TearDown]
        public void TearDown()
        {
            DriverFactory.Cleanup(Driver);
        }
    }
}