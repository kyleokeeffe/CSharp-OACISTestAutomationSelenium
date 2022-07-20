using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OACISTestAutomationSelenium.Services;

namespace OACISTestAutomationSelenium.Functional
{
   // public delegate IPageObject AsyncPageObjectMethodCaller(int callDuration, out int threadId);
   // public delegate IWebElement AsyncWebElementMethodCaller(IWebDriver driver, string xPathString, int callDuration, int timeout);
   // public delegate IWebElement AsyncWebElementByMethodCaller(IWebDriver driver, By byLocator, int callDuration, int timeout);
   // public delegate IReadOnlyCollection<IWebElement> AsyncWebElementsMethodCaller(IWebDriver driver, string xPathString, int callDuration);
    public class DriverHelper
    {
        public const int TIMEOUT_CONST = 30;
        public static WebDriverWait wait { get; set; }
        public static WebDriverWait InitializeWait(IWebDriver driver, int timeout = TIMEOUT_CONST)
        {
            var wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(timeout))
            {
                PollingInterval = TimeSpan.FromSeconds(1),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return wait;
        }
        //public async static Task<IWebElement> FindElementAsyncCaller(IWebDriver driver, string xPathString,int callDuration = 30, int timeout = TIMEOUT_CONST)
        //{
          
        //    IWebElement element;
        //    //int threadId;
        //    AsyncWebElementMethodCaller caller = new AsyncWebElementMethodCaller(FindElementWithWait);
        //    IAsyncResult result = caller.BeginInvoke(driver,xPathString, callDuration = 30, timeout = TIMEOUT_CONST,  null, null);

        //    element = caller.EndInvoke(result);
        //    return element;
        //}
        //public async static Task<IReadOnlyCollection<IWebElement>> FindElementsAsyncCaller(IWebDriver driver, string xPathString, int callDuration = 30, int timeout = TIMEOUT_CONST)
        //{
        //    IReadOnlyCollection<IWebElement> elements;

        //    //int threadId;
        //    AsyncWebElementsMethodCaller caller = new AsyncWebElementsMethodCaller(FindElementsWithWait);
        //    IAsyncResult result = caller.BeginInvoke(driver, xPathString, callDuration = 30, null, null);

        //    elements = caller.EndInvoke(result);
        //    return elements;
        //}
        public static void WaitForPageLoad(IWebDriver driver)
        {
            Console.WriteLine($"Waiting for page to load...");
            //var callingMethod4Back = (new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name;
            // Console.WriteLine($"Waiting for page load from {callingMethod4Back}");
            IWait<IWebDriver> Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

            Wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));
            Console.WriteLine("Wait over - Page loaded.");
        }
        public static IWebElement FindElementWithWait(IWebDriver driver, string xPathString, int callDuration=30,int timeout = TIMEOUT_CONST)
        {
           


            //Driver.Manage().Timeouts().ImplicitWait = new System.TimeSpan(0, 0, 0, 0, 500);
            if (wait==null)
                wait=InitializeWait(driver);


            //threadId = Thread.CurrentThread.ManagedThreadId;




            IWebElement foundElement = null;
            Console.WriteLine($"Finding element {xPathString} - waiting for response...");

            //          foundElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(byLocator)//Alternate approach, but ExpectedConditions is deprecated
            bool elementWasFound = wait.Until<bool>(drv =>
            {
                try
                {
                    //foundElement = drv.FindElement(By.XPath(xPath));
                    foundElement = drv.FindElement(By.XPath(xPathString));
                }
                catch (Exception e)
                {
                    // throw new CustomNotFoundException("", e);//for throwing to calling method  - or just remove catch entirely and have only finally https://stackoverflow.com/questions/7024252/throw-exception-from-called-function-to-the-caller-functions-catch-block
                    throw new Exception();
                }
                return true;
            });

            /* if (elementWasFound == true)
             {
                 return foundElement;
             }
             else
             {
                 throw new NoSuchElementException();
                 return null;
             }
              */

            Console.WriteLine($"Wait over - element {xPathString} found.");
            return foundElement;



        }
        public static IWebElement FindElementWithWait(IWebDriver driver, By byLocator, int timeout= TIMEOUT_CONST )
        {
            
            //Driver.Manage().Timeouts().ImplicitWait = new System.TimeSpan(0, 0, 0, 0, 500);

            if (wait==null)
                wait=InitializeWait(driver);
     


            IWebElement foundElement = null;
            Console.WriteLine($"Finding element {byLocator.ToString} - waiting for response...");
            //          foundElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(byLocator)//Alternate approach, but ExpectedConditions is deprecated
            bool elementWasFound = wait.Until<bool>(drv =>
            {
                try
                {
                   //foundElement = drv.FindElement(By.XPath(xPath));
                    foundElement = drv.FindElement(byLocator);
                }
                catch (Exception e)
                {
                    // throw new CustomNotFoundException("", e);//for throwing to calling method  - or just remove catch entirely and have only finally https://stackoverflow.com/questions/7024252/throw-exception-from-called-function-to-the-caller-functions-catch-block
                    throw new Exception();                                    
                }
                return true;
            });

            /* if (elementWasFound == true)
             {
                 return foundElement;
             }
             else
             {
                 throw new NoSuchElementException();
                 return null;
             }
              */

          
            Console.WriteLine($"Wait over - element {byLocator.ToString} found.");
            return foundElement;

           

        }
        public static IWebElement FindElementWithinElementWithWait(IWebDriver driver, string xPath, IWebElement withinElement)
        {

              if (wait==null)
                wait=InitializeWait(driver);

            //WebDriverWait wait = InitializeWait(driver);
     
            Console.WriteLine($"Finding element {xPath} - waiting for response...");
            IWebElement foundWithinElement = wait.Until(drv => withinElement.FindElement(By.XPath(xPath)));
            // / html / body / form / table / tbody / tr / td[2] / div / div[2] / table / tbody / tr[2] / td[2] / span
            IWebElement clickableFoundWithinElement = wait.Until(ExpectedConditions.ElementToBeClickable(foundWithinElement));


            Console.WriteLine($"Wait over - element {xPath} found.");
            return clickableFoundWithinElement;


        }
        public static IReadOnlyCollection<IWebElement> FindElementsWithWait(IWebDriver driver, string xPath, int callDuration = 30)
        {
                if (wait==null)
                wait=InitializeWait(driver);

            //WebDriverWait wait = InitializeWait(driver);

            // wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            Console.WriteLine($"Finding element {xPath} - waiting for response...");

            var elements = wait.Until(drv => drv.FindElements(By.XPath(xPath)));

            Console.WriteLine($"Wait over - element {xPath} found.");
            return elements;


        }
        public static IReadOnlyCollection<IWebElement> FindElementsWithWait(IWebDriver driver, By byLocator)
        {

            if (wait==null)
                wait=InitializeWait(driver);
            //WebDriverWait wait = InitializeWait(driver);

           // wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
           
            Console.WriteLine($"Finding element {byLocator.ToString} - waiting for response...");
            return wait.Until(drv => drv.FindElements(byLocator));
            Console.WriteLine($"Wait over - element {byLocator.ToString} found.");



        }
        public static IReadOnlyCollection<IWebElement> FindElementsWithinElementWithWait(IWebDriver driver,string xPath, IWebElement withinElement)
        {
            
            if (wait==null)
                wait=InitializeWait(driver);

            // WebDriverWait wait = InitializeWait(driver);
            // Console.WriteLine($"Waiting for find elements: {xPath}...");
            Console.WriteLine($"Finding element {xPath} - waiting for response...");

            IReadOnlyCollection<IWebElement> foundWithinElements = wait.Until(drv => withinElement.FindElements(By.XPath(xPath)));

            List<IWebElement> clickableFoundWithinElements = new List<IWebElement>();
            // clickableFoundWithinElements = new IReadOnlyCollection<IWebElement>(); 

            foreach (var element in foundWithinElements)
            {

                var elementClickable = wait.Until(ExpectedConditions.ElementToBeClickable(element));
                clickableFoundWithinElements.Add(elementClickable);
                // return Wait.Until(withinElement => withinElement.FindElements(By.XPath(xPath)));


            }
            var clickableElementsAsReadOnly = clickableFoundWithinElements.AsReadOnly();
            Console.WriteLine($"Wait over - element {xPath} found.");
            return clickableElementsAsReadOnly;
        }


    }
}
