using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Models.ExcelTableImportTemplates;
using OACISTestAutomationSelenium.PageObjects;
using OACISTestAutomationSelenium.Services;
using OACISTestAutomationSelenium.Services.Enums;
using OACISTestAutomationSelenium.Services.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System.Data;
using static OACISTestAutomationSelenium.Functional.DriverFactory;

namespace OACISTestAutomationSelenium
{
    public class Tests
    {

        public IWebDriver Driver { get; set; }
        
        [SetUp]
        public void Setup()
        {
            this.Driver = DriverFactory.Initialize();
        }

        /*[Test]
        public void CreateClient()
        {
            bool testOkay = false;
           
            DataTable importedClients = ExcelTableFactory.ReadExcelIntoTable(@$"{ new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName}\Data\ExcelImports\ClientImportJul20.xlsx", ImportTemplates.Client);
            List<IImportObject> clientsToCreate = ExcelTableImportHelper.ConvertTableToObjects(importedClients, ImportTemplates.Client);

            for(int i = 0; i < clientsToCreate.Count; i++)
            {
                ImportedClient client = (ImportedClient)clientsToCreate[i];
                LandingPage landingPage = new LandingPage(Driver);

                landingPage
                    .ClickClientLink()
                    .ClickNewButton()
                    .FillFirstNameField(client.ClientFirstName)
                    .FillLastNameField(client.ClientLastName)
                    .FillDobField(client.ClientDob)
                .ClickSaveButton();

                ScreenshotHelper.TakeScreenShotBrowserContents(Driver,"TC-1234");
                Console.WriteLine(client.ToString());

                if (client != null)
                    testOkay = true;
            }
            Assert.IsTrue(testOkay);
        }*/

        [Test]
        public void PrintIds()
        {
            LandingPage landingPage = new LandingPage(Driver);

           // landingPage
               // .Search("OAP0052778")
                //.ClickFirstRow();

        

            PageModelCreator.PrintAllIds(Driver); 

        }

        [TearDown]
        public void TearDown()
        {
            DriverFactory.Cleanup(Driver);
        }
    }
}