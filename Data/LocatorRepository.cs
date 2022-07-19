using OACISTestAutomationSelenium.Functional;
using OACISTestAutomationSelenium.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OACISTestAutomationSelenium.Data
{
    public class LocatorRepository
    {

        public static By GetLocator(string Xpath)
        {
            XmlDocument repo = new XmlDocument();
            repo.Load(@$"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\Data\SuccessDictionary.xml");


            XmlNode node;
            XmlElement root = repo.DocumentElement;
            node = root.SelectSingleNode(Xpath);

            
            By b = null;
            string valueString = "";

            if(node != null)
            {
                valueString = node.ChildNodes.OfType<XmlElement>().Where(e => e.Name == "value").FirstOrDefault().InnerText;

                switch (node.ChildNodes.OfType<XmlElement>().Where(e => e.Name == "byType").FirstOrDefault().InnerText)
                {
                    case "xpath":
                        b = By.XPath(valueString);
                        break;
                    case "name":
                        b = By.Name(valueString);
                        break;
                    case "class name":
                        b = By.ClassName(valueString);
                        break;
                    case "UAI":
                        b = By.Name(valueString);
                        break;
                    default:
                        break;
                }
            }
            if (b == null) throw new NotFoundException("Locator not found on Object Repository");

            return b;
        }

        public static Dictionary<string, string> SuccessDictionary { get; set; }
        public static bool CurrentlyLoaded { get; set; }
        public static bool SaveRequired { get; set; }
        private static string successDictionaryFile = @$"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\Data\SuccessDictionary.xml";

        static LocatorRepository()
        {
            SuccessDictionary = new Dictionary<string, string>();
            CurrentlyLoaded = false;
            SaveRequired = false;
        }
        public void Save()
        {
            Console.WriteLine("Saving success dictionary....");
            if (File.Exists(successDictionaryFile))
                File.Delete(successDictionaryFile);

            XmlSerializer serializer = new XmlSerializer(typeof(List<LocatorRepoItem>));
            //string successDictionaryFile= @$"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\Data\SuccessDictionary.xml";
            List<LocatorRepoItem> entryList = new List<LocatorRepoItem>();

            using (var stream = new FileStream(successDictionaryFile, FileMode.OpenOrCreate))
            {
                foreach (string key in SuccessDictionary.Keys)
                {
                    entryList.Add(new LocatorRepoItem(key, SuccessDictionary[key]));
                }
                serializer.Serialize(stream, entryList);
            }
            Console.WriteLine("Success dictionary saved.");
        }

        /*     public static void Update()
             {
                 //string successDictionaryFile= @$"{new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\Data\SuccessDictionary.xml";
                 if (File.Exists(successDictionaryFile))
                     File.Delete(successDictionaryFile);
                 Save();
             }
        */
        public void Load()
        {
            if (File.Exists(successDictionaryFile))
            {

                SuccessDictionary.Clear();
                XmlSerializer serializer = new XmlSerializer(typeof(List<LocatorRepoItem>));
                // string[] successDictionaryFile;

                // if(Directory.GetFiles(path) != null)
                //  {
                //string successDictionaryFile = "path/name.xml";

                List<LocatorRepoItem> entryCollection = new List<LocatorRepoItem>();

                using (var reader = new FileStream(successDictionaryFile, FileMode.Open))
                {
                    entryCollection = (List<LocatorRepoItem>)serializer.Deserialize(reader);
                    foreach (var entry in entryCollection)
                    {
                        SuccessDictionary[entry.Key] = (string)entry.Value;
                    }
                }
                CurrentlyLoaded = true;
            }



        }

        /*private string GeneratePageImageString()
        {
            string pageString = "";
            var pageInputs = wait.FindElementsWait(@"//div[@id]");
            foreach (var pageInput in pageInputs)
            {
                pageString += pageInput.GetAttribute("id");
            }

            return pageString;
        }*/

        public string GeneratePageImageString(IWebDriver driver)
        {
            string pageStringFull = "";
            string pageString = "";
            var pageId = DriverHelper.FindElementWithWait(driver,@"//script[@data-dtconfig]"); //*[contains(@id, 'f41_txt')]
            /*foreach (var pageInput in pageInputs)
            {
                pageString += pageInput.GetAttribute("id");
            }*/
            pageStringFull = pageId.GetAttribute("data-dtconfig");
            pageString = pageStringFull.Substring(pageStringFull.IndexOf("rid="), pageStringFull.IndexOf('|', pageStringFull.IndexOf("rid=")));
            return pageString;
        }
        private string GenerateXPATH(IWebElement childElement, String currentKnownXPath) //code reference: https://stackoverflow.com/questions/18510576/find-an-element-by-text-and-get-xpath-selenium-webdriver-junit
        {
            Console.Write(".");
            String childTag = childElement.TagName;
            if (childTag.Equals("html"))
            {
                return "/html[1]" + currentKnownXPath;
            }
            IWebElement parentElement = childElement.FindElement(By.XPath(".."));
            var childrenElements = parentElement.FindElements(By.XPath("*"));
            int count = 0;
            for (int i = 0; i < childrenElements.Count(); i++)
            {
                IWebElement childrenElement = childrenElements.ElementAt(i);
                String childrenElementTag = childrenElement.TagName;
                if (childTag.Equals(childrenElementTag))
                {
                    count++;
                }
                if (childElement.Equals(childrenElement))
                {
                    return GenerateXPATH(parentElement, "/" + childTag + "[" + count + "]" + currentKnownXPath);
                }
            }
            return null;

        }
        /*
        public IWebElement TryGetSearchInSuccessDictionary(IWebDriver driver, string searchTerm)
        {
            /* var callingMethod4Back = (new System.Diagnostics.StackTrace()).GetFrame(4).GetMethod().Name;
             var callingMethod3Back = (new System.Diagnostics.StackTrace()).GetFrame(3).GetMethod().Name;
             var callingMethod2Back = (new System.Diagnostics.StackTrace()).GetFrame(2).GetMethod().Name;
             var stackTraceFrames = (new System.Diagnostics.StackTrace()).GetFrames();
             string allStackTraceFrames = "";
             for (int i = 1; i < stackTraceFrames.Length; i++)


             {

                 allStackTraceFrames += stackTraceFrames[i].GetMethod().Name;
             }*/

            // IWebElement uniquePageElement= wait.FindElementWait(@"//span[@class=""ContentLabel""] | //span[@class=""ContentStatus""] | //a[@class=""SectionLabel""]");
            /*
             IWebElement uniquePageElement = wait.FindElementWait(successDictionaryKeyString);


             string uniquePageElementValue = uniquePageElement.GetAttribute("innerHTML");
            */
           /* string pageInputString = lib.currentPageIDString;

            string searchTermAndUniquePageElementValue = $"{searchTerm}:{pageInputString}";
            IWebElement returnedElement = null;
            string elementXPath;

            bool foundInSuccessDictionary = SuccessDictionary.TryGetValue(searchTermAndUniquePageElementValue, out elementXPath);

            if (foundInSuccessDictionary)//////****************************************************************************************************************************
            {
                Console.WriteLine($"Element found in dictionary:{searchTermAndUniquePageElementValue}");
                //IWebElement foundElement2 = Program.Driver.FindElement(By.Id(outElement));
                try
                {
                    returnedElement = DriverHelper.FindElementWithWait(driver,elementXPath);
                }
                catch (Exception e)
                {
                    throw new DictionaryOutdatedException("Page format has changed since Success Dictionary was created. Please delete SuccessDictionary.xml.");
                }
                Console.WriteLine("Find element wait done.");

            }
            else if (!foundInSuccessDictionary)
            {

                // LogSearchSuccess(searchTermAndCallingMethod,foundElement);
                returnedElement = null;
                Console.WriteLine($"Element not found in dictionary: {searchTermAndUniquePageElementValue}");
            }
            return returnedElement;



        }

        public void LogSearchSuccess(string searchTerm, IWebElement foundElement)
        {
            /*
            var callingMethod4Back = (new System.Diagnostics.StackTrace()).GetFrame(4).GetMethod().Name;
            var callingMethod3Back = (new System.Diagnostics.StackTrace()).GetFrame(3).GetMethod().Name;
            var callingMethod2Back = (new System.Diagnostics.StackTrace()).GetFrame(2).GetMethod().Name;
            var callingMethod1Back = (new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name;
            // IWebElement viewStateElement = wait.FindElementWait(@"//span[@class=""ContentLabel""] | //span[@class=""ContentStatus""] | //a[@class=""SectionLabel""]");


            var stackTraceFrames = (new System.Diagnostics.StackTrace()).GetFrames();
            string allStackTraceFrames = "";
            for(int i = 1; i < stackTraceFrames.Length; i++)
            
            
            {

                allStackTraceFrames += stackTraceFrames[i].GetMethod().Name;
            }*/
            /*
            IWebElement viewStateElement = wait.FindElementWait(successDictionaryKeyString);



            string viewStateValue = viewStateElement.GetAttribute("innerHTML");
            
            */
            /*
            string pageInputString = lib.currentPageIDString;

            string searchTermAndCallingMethod = $"{searchTerm}:{pageInputString}";

            //string searchTermAndCallingMethod = $"{searchTerm}:{callingMethod3Back}:{pageContentStatus}";
            Console.WriteLine("Generating dictionary Xpath.");
            string elementGeneratedXPath = GenerateXPATH(foundElement, "");
            Console.WriteLine("\nDictionary Xpath Generated.");
            SuccessDictionary.Add(searchTermAndCallingMethod, elementGeneratedXPath);
            SaveRequired = true;
            Console.WriteLine($"Added to dictionary: {searchTermAndCallingMethod}, {elementGeneratedXPath}");
        }*/
    }



}
    

