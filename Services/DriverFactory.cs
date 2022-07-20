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
       // public delegate IWebDriver AsyncMethodCaller(InternetExplorerOptions ieOptions,int callDuration, out int threadId);
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
            //  BrowserWindowHandle = driver.CurrentWindowHandle;
            //  threadId = Thread.CurrentThread.ManagedThreadId;
            return driver;
        }

       /* public static IWebDriver CreateDriver(InternetExplorerOptions ieOptions, int callDuration,out int threadId)
        {
            threadId = Thread.CurrentThread.ManagedThreadId;
            //return new InternetExplorerDriver(@"C:\Users\OKeeffKy\OneDrive - Government of Ontario\Documents\02Projects\ProgProj\WebDriverTest1\UnitTestProject1\UnitTestProject1\bin", ieOptions);
            return new InternetExplorerDriver($@"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName}", ieOptions);
        }*/

        public  static void Cleanup(IWebDriver driver)
        {
            Console.WriteLine("Cleaning up...");
           // if (LocatorRepository.SaveRequired == true)
              //  sd.Save();
            Console.WriteLine("Quitting...");
            driver.Quit();
            Console.WriteLine("Goodbye!");
        }
    }
}
