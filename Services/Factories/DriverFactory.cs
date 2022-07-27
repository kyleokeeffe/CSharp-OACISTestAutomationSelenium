using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Functional
{
    public class DriverFactory
    {
        public  static IWebDriver Initialize()
        {
            IWebDriver driver = null;
            var ieOptions = new InternetExplorerOptions();
            ieOptions.AttachToEdgeChrome = true;
            ieOptions.EdgeExecutablePath = "C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe";
            ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;

            Console.WriteLine("Initializing Driver...");

            driver =  new InternetExplorerDriver($@"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName}", ieOptions);
            driver.Manage().Window.Maximize();
            // Driver.Url=@"file://C:\Users\OKeeffKy\SeleniumDrivers\ON00294E_Dev_V1.pdf";
            driver.Url = "http://intra.stage.oacis.children.gov.on.ca/";
         
            Console.WriteLine("Driver Initialized.");
            return driver;
        }

        public  static void Cleanup(IWebDriver driver)
        {
            Console.WriteLine("Cleaning up...");
            Console.WriteLine("Quitting...");
            driver.Quit();
            Console.WriteLine("Goodbye!");
        }
    }
}
