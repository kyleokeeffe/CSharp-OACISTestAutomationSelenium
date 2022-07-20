﻿using OACISTestAutomationSelenium.Functional;
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
            var allTextInputs = DriverHelper.FindElementsWithWait(driver,@"//input[@type=""text"" and starts-with(@id,""ctl"")]");
            var allLinks = DriverHelper.FindElementsWithWait(driver, @"//a[contains(@id,""ctl"") and contains(@id,""lnk"")]");

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
                    $"public Place_Holder Click{propName}(string text)\n" +
                    "{\n" +
                    $"\t{propName}.Click();\n" +
                    "\treturn Place_Holder;\n" +
                    "}\n";
                //Console.WriteLine($"{id} - {propName} - {propNameLower}");
            }
            Console.WriteLine(backingFields);
            Console.WriteLine(propertyDefinitions);
            Console.WriteLine(actionMethods);
        }
    }
}