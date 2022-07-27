using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Instructions:
//1. Navigate Driver to a page then invoke PrintPageModelCode()
//2. In Console will be printed c# class implementation for properties, constructor and action methods (Fill x field, Click x button etc) for all text fields/links etc found on that page
//3. Copy text printed to console into new new class body and use as page object model for that page

namespace OACISTestAutomationSelenium.Services
{
    internal class PageModelCreator
    {
        
        public IWebDriver Driver { get; set; }
        public PageModelCreator(IWebDriver driver)
        {
            this.Driver = driver;
        }

        public static void PrintPageModelCode(IWebDriver driver)
        {
            string backingFields = "private IWebDriver Driver;\n";
            string propertyDefinitions = "";
            string actionMethods = "public PlaceHolderThis(IWebDriver driver)\n" +
            "{" +
                "DriverHelper.WaitForPageLoad(driver);\n" +
                "this.Driver = driver;\n" +
            "}";
           DriverHelper.WaitForPageLoad(driver);
            IWebElement activeTab = null;
            try
            {

                activeTab = DriverHelper.FindElementWithWait(driver, @"//div[@class=""SectionTabOn""]");

            }catch(Exception ex)
            {
                activeTab = null;
            }

            IReadOnlyCollection<IWebElement> allTextInputs; 
            IReadOnlyCollection<IWebElement> allLinks;
            IReadOnlyCollection<IWebElement> allSelects;
            IReadOnlyCollection<IWebElement> allCheckBoxes;
            if (activeTab != null)
            {
              
                List<IWebElement> allSectionOffTextInputs = new List<IWebElement>();
                List<IWebElement> allSectionOffLinks = new List<IWebElement>();
                List<IWebElement> allSectionOffSelects = new List<IWebElement>();
               
                var allTextInputsEntirePage = DriverHelper.FindElementsWithWait(driver, @"//input[@type=""text"" and starts-with(@id,""ctl"") and not(contains(@class,""idden"")) ]");
                var allLinksEntirePage = DriverHelper.FindElementsWithWait(driver, @"//a[contains(@id,""ctl"") and contains(@id,""lnk"")]");
                var allSelectsEntirePage = DriverHelper.FindElementsWithWait(driver, @"//select[@*]");
               
                // @"//select[contains(@id,""ctl"")]"


                var allSectionOffDivs = DriverHelper.FindElementsWithWait(driver, @"//div[@class=""SectionTabOff""]");



                foreach(var element in allSectionOffDivs)
                {
                    var sectionOffTexts = DriverHelper.FindElementsWithinElementWithWait(driver, @"./descendant::input[@type=""text"" and starts-with(@id,""ctl"") and not(contains(@class,""idden""))]", element);
                    var sectionOffLinks = DriverHelper.FindElementsWithinElementWithWait(driver, @"./descendant::a[contains(@id,""ctl"") and contains(@id,""lnk"")]", element);
                    var sectionOffSelects = DriverHelper.FindElementsWithinElementWithWait(driver, @"./descendant::select[@*]", element);

                    allSectionOffTextInputs.AddRange(sectionOffTexts);
                    allSectionOffLinks.AddRange(sectionOffLinks);
                    allSectionOffSelects.AddRange(sectionOffSelects);


                }
               

                // var allSectionOffTextInputs= DriverHelper.FindElementsWithWait(driver, @"//div[@class=""SectionTabOff""]/descendant::input[@type=""text"" and starts-with(@id,""ctl"") and not(contains(@class,""idden"")) ]");
                // var allSectionOffLinks =DriverHelper.FindElementsWithinElementWithWait(driver, @"//div[@class=""SectionTabOff""]/descendant::a[contains(@id,""ctl"") and contains(@id,""lnk"")]", activeTab);

                IReadOnlyCollection<IWebElement> allTextInputsExceptSectionOff = allTextInputsEntirePage.Except(allSectionOffTextInputs).ToList().AsReadOnly();
                IReadOnlyCollection<IWebElement> allLinksExceptSectionOff = allLinksEntirePage.Except(allSectionOffLinks).ToList().AsReadOnly();
                IReadOnlyCollection<IWebElement> allSelectsExceptSectionOff = allSelectsEntirePage.Except(allSectionOffSelects).ToList().AsReadOnly();

                allTextInputs = allTextInputsExceptSectionOff;
                allLinks = allLinksExceptSectionOff;
                allSelects = allSelectsExceptSectionOff;
                // allTextInputs = DriverHelper.FindElementsWithinElementWithWait(driver, @"./descendant::input[@type=""text"" and starts-with(@id,""ctl"") and not(contains(@class,""idden"")) ]",activeTab);
                //allLinks = DriverHelper.FindElementsWithinElementWithWait(driver, @"./descendant::a[contains(@id,""ctl"") and contains(@id,""lnk"")]", activeTab);

            }
            else
            {

                allTextInputs = DriverHelper.FindElementsWithWait(driver, @"//input[@type=""text"" and starts-with(@id,""ctl"") and not(contains(@class,""idden"")) ]");
                allLinks = DriverHelper.FindElementsWithWait(driver, @"//a[contains(@id,""ctl"") and contains(@id,""lnk"")]");
                allSelects = DriverHelper.FindElementsWithWait(driver, @"//select[@*]");
               // allCheckBoxes = DriverHelper.FindElementsWithWait(driver, @"//input[@type=""checkbox"" and starts-with(@id,""ctl"") ]");
            }
           
    

            foreach (var input in allTextInputs)
            {
                string id = input.GetAttribute("id");
                int iOfUScore = id.IndexOf("_")+1;
                string propName = id.Substring(iOfUScore, id.Length- iOfUScore);
                if (propName.Substring(0, 3)=="txt" || propName.Substring(0, 3) == "ctl")
                {
                    propName = $"{propName.Substring(3, propName.Length - 3)}{propName.Substring(0, 3)}";
                }
                string propNameLower= $"{propName.Substring(0, 1).ToLower()}{propName.Substring(1,propName.Length-1)}";

                backingFields += $"private IWebElement {propNameLower};\n";
                propertyDefinitions += $"" +
                    $"public IWebElement {propName}\n" +
                    @"{" + "\n" +
                    "\t" + @$"get => {propNameLower} == null ? DriverHelper.FindElementWithWait(Driver, @""//*[@id=""""{id}""""]"") : {propNameLower};" + "\n" +
                    $"\tset => {propNameLower}= value;\n" +
                    @"}" + "\n";

                actionMethods += "" +
                    $"public PlaceHolderThis Fill{propName}(string text)\n" +
                    "{\n" +
                    $"\t{propName}.SendKeys(text);\n" +
                    "\treturn this;\n" +
                    "}\n";
                
                //Console.WriteLine($"{id} - {propName} - {propNameLower}");
            }
           
            foreach (var link in allLinks)
            {
                string id = link.GetAttribute("id");
                int iOfUScore = id.IndexOf("_") + 1;
                string propName = id.Substring(iOfUScore, id.Length - iOfUScore);

                if (propName.Substring(0, 3) == "lnk")
                {
                    propName = $"{propName.Substring(3, propName.Length - 3)}{propName.Substring(0, 3)}";
                }
                string propNameLower = $"{propName.Substring(0, 1).ToLower()}{propName.Substring(1, propName.Length - 1)}";

                backingFields+=$"private IWebElement {propNameLower};\n";
                propertyDefinitions+=$"" +
                    $"public IWebElement {propName}\n" +
                    @"{" + "\n"+
                    "\t"+@$"get => {propNameLower} == null ? DriverHelper.FindElementWithWait(Driver, @""//*[@id=""""{id}""""]"") : {propNameLower};"+"\n"+
                    $"\tset => {propNameLower}= value;\n" +
                    @"}"+"\n";

                actionMethods += "" +
                    $"public Place_Holder Click{propName}()\n" +
                    "{\n" +
                    $"\t{propName}.Click();\n" +
                    "\treturn new Place_Holder(Driver);\n" +
                    "}\n";
                //Console.WriteLine($"{id} - {propName} - {propNameLower}");
            }
            foreach (var link in allSelects)
            {
                string id = link.GetAttribute("id");
                int iOfUnderScore = id.IndexOf("_") + 1;
                string propName = id.Substring(iOfUnderScore, id.Length - iOfUnderScore);

                if (propName.Substring(0, 3) == "lnk")
                {
                    propName = $"{propName.Substring(3, propName.Length - 3)}{propName.Substring(0, 3)}Select";
                }
                string propNameLower = $"{propName.Substring(0, 1).ToLower()}{propName.Substring(1, propName.Length - 1)}Select";

                backingFields += $"private IWebElement {propNameLower};\n";
                propertyDefinitions += $"" +
                    $"public IWebElement {propName}\n" +
                    @"{" + "\n" +
                    "\t" + @$"get => {propNameLower} == null ? DriverHelper.FindElementWithWait(Driver, @""//*[@id=""""{id}""""]"") : {propNameLower};" + "\n" +
                    $"\tset => {propNameLower}= value;\n" +
                    @"}" + "\n";

                actionMethods += "" +
                    $"public PlaceHolderThis SelectOption{propName}(int optionNum)\n" +
                    "{\n" +
                    "\tActions action = new Actions(Driver);\n" +
                    $"\tSelectElement elementAsSelect = new SelectElement({propName});\n" +
                    $"\t{propName}.Click();\n" +
                    "\tvar selectOptions = elementAsSelect.Options;\n" +
                    " \tfor (int i = 0; i < optionNum; i++)\n" +
                    "{\n" +
                    "\t\taction.SendKeys(Keys.Down);\n" +
                    "\t}\n" +
                    "\taction.SendKeys(Keys.Tab);\n" +
                    "\taction.Build().Perform();\n" +
                    "\tDriver.SwitchTo().Window(LandingPage.BrowserWindowHandle);\n" +
                    "\treturn this;\n" +
                    "}\n";

                //to be implemented into interpolated string and added to select action methods:

                //public ApplicationContactsPage SelectOptionddlApplicantProvince(string optionText)
                //{
                //    Actions action = new Actions(Driver);
                //    SelectElement elementAsSelect = new SelectElement(ddlApplicantProvince);
                //    ddlApplicantProvince.Click();
                //    IList<IWebElement> selectOptions = elementAsSelect.Options;
                //    int? matchingOptionNum = null;
                //    for (int i = 0; i < selectOptions.Count; i++)
                //    {
                //        if (selectOptions[i].Text == optionText)
                //        {
                //            matchingOptionNum = i;
                //            break;
                //        }
                //    }

                //    if (matchingOptionNum != null)
                //    {
                //        for (int i = 0; i < matchingOptionNum; i++)
                //        {
                //            action.SendKeys(Keys.Down);
                //        }
                //    }
                //    else
                //    {
                //        string allOptions = "";
                //        foreach (var option in selectOptions)
                //            allOptions += $"\t{option.Text}\n";
                //        throw new Exception($"Option value {optionText} not found in select list. List contains the following values:\n{allOptions}");
                //    }

                //    action.SendKeys(Keys.Tab);
                //    action.Build().Perform();
                //    Driver.SwitchTo().Window(LandingPage.BrowserWindowHandle);
                //    return this;
                //}



                //Console.WriteLine($"{id} - {propName} - {propNameLower}");
            }
            Console.WriteLine(backingFields);
            Console.WriteLine(propertyDefinitions);
            Console.WriteLine(actionMethods);

           
        }
    }
}
