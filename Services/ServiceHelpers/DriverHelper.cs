﻿using OpenQA.Selenium;
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
       
        public static void WaitForPageLoad(IWebDriver driver)
        {
            Console.WriteLine($"Waiting for page to load...");
            IWait<IWebDriver> Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));
            Wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));
            Console.WriteLine("Wait over - Page loaded.");
        }
        public static IWebElement FindElementWithWait(IWebDriver driver, string xPathString, int callDuration=30,int timeout = TIMEOUT_CONST)
        {
            if (wait==null)
                wait=InitializeWait(driver);
            IWebElement foundElement = null;
            Console.WriteLine($"Finding element {xPathString} - waiting for response...");

            bool elementWasFound = wait.Until<bool>(drv =>
            {
                try
                {
                    foundElement = drv.FindElement(By.XPath(xPathString));
                }
                catch (Exception e)
                {
                    throw new Exception($"Element could not be found with an XPath of {xPathString}");
                }
                return true;
            });
         
            Console.WriteLine($"Wait over - element {xPathString} found.");
            return foundElement;
        }
        public static IWebElement FindElementWithWait(IWebDriver driver, By byLocator, int timeout= TIMEOUT_CONST )
        {
            if (wait==null)
                wait=InitializeWait(driver);

            IWebElement foundElement = null;
            Console.WriteLine($"Finding element {byLocator.ToString} - waiting for response...");

            bool elementWasFound = wait.Until<bool>(drv =>
            {
                try
                {
                    foundElement = drv.FindElement(byLocator);
                }
                catch (Exception e)
                {
                    throw new Exception($"Element could not be found with an XPath of {byLocator.ToString}");
                }
                return true;
            });

            Console.WriteLine($"Wait over - element {byLocator.ToString} found.");
            return foundElement;
        }
        public static IWebElement FindElementWithinElementWithWait(IWebDriver driver, string xPath, IWebElement withinElement)
        {
            if (wait==null)
                wait=InitializeWait(driver);
     
            Console.WriteLine($"Finding element {xPath} - waiting for response...");
            IWebElement foundWithinElement = wait.Until(drv => withinElement.FindElement(By.XPath(xPath)));
            IWebElement clickableFoundWithinElement = wait.Until(ExpectedConditions.ElementToBeClickable(foundWithinElement));

            Console.WriteLine($"Wait over - element {xPath} found.");
            return clickableFoundWithinElement;
        }
        public static IReadOnlyCollection<IWebElement> FindElementsWithWait(IWebDriver driver, string xPath, int callDuration = 30)
        {
            if (wait==null)
                wait=InitializeWait(driver);

            Console.WriteLine($"Finding element {xPath} - waiting for response...");
            var elements = wait.Until(drv => drv.FindElements(By.XPath(xPath)));

            Console.WriteLine($"Wait over - element {xPath} found.");
            return elements;
        }
        public static IReadOnlyCollection<IWebElement> FindElementsWithWait(IWebDriver driver, By byLocator)
        {
            if (wait==null)
                wait=InitializeWait(driver);

            Console.WriteLine($"Finding element {byLocator.ToString} - waiting for response...");
            return wait.Until(drv => drv.FindElements(byLocator));
            Console.WriteLine($"Wait over - element {byLocator.ToString} found.");
        }
        public static IReadOnlyCollection<IWebElement> FindElementsWithinElementWithWait(IWebDriver driver,string xPath, IWebElement withinElement)
        {
            if (wait==null)
                wait=InitializeWait(driver);

            Console.WriteLine($"Finding element {xPath} - waiting for response...");
            IReadOnlyCollection<IWebElement> foundWithinElements = wait.Until(drv => withinElement.FindElements(By.XPath(xPath)));
           //For ensuring element is clickable before clicking it....
         /*   List<IWebElement> clickableFoundWithinElements = new List<IWebElement>();

              foreach (var element in foundWithinElements)
              {
                 // IWait<IWebDriver> Wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));
                 // Wait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));
                  var elementClickable = wait.Until(ExpectedConditions.ElementToBeClickable(element));
                  //var elementClickable = wait.Until(ExpectedConditions. (element));
                  clickableFoundWithinElements.Add(elementClickable);
              }
              var clickableElementsAsReadOnly = clickableFoundWithinElements.AsReadOnly();
              Console.WriteLine($"Wait over - element {xPath} found.");
              return clickableElementsAsReadOnly;*/
            
            return foundWithinElements;
        }
    }
}
