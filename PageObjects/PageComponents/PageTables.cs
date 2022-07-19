using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.PageObjects
{
    public class PageTables
    {
        private IWebDriver Driver;
  



        public PageTables(IWebDriver driver)
        {
            this.Driver = driver;
     
           

        }

        public IReadOnlyCollection<IWebElement> GetTables()
        {

            var tables = DriverHelper.FindElementsWithWait(Driver, @"//table[@class=""Grid""]");
            return tables;

        }

        public IWebElement GetRow(string colName, string rowValue, int tableNum=1)
        {
            Console.WriteLine("Finding row...");
            // pes.ReadPage();

            IWebElement table = GetTables().ElementAt(tableNum - 1);
            int headerColNum = this.GetHeaderColumnNumber(colName, tableNum);

            var rowAtValue = DriverHelper.FindElementWithinElementWithWait(Driver, $@"./tbody/tr/td[{headerColNum}]/span[text()[contains(., ""{rowValue}"")]]/parent::td/parent::tr", table);
            Console.WriteLine("Find element wait done.");
            //var rowAtValue = table.FindElement(By.XPath($@"./tbody/tr/td[{headerColNum}]/span[text()[contains(., ""{rowValue}"")]]/parent::td/parent::tr"));
            Console.WriteLine("Row found.");
            return rowAtValue;
        }

        public IWebElement GetRow(int rowNum, int tableNum = 1)
        {
            Console.WriteLine("Finding row...");
            var tables = GetTables();

            IWebElement table = tables.ElementAt(tableNum - 1);
            //IWebElement table = GetTables().ElementAt(tableNum - 1);
            var foundRow = DriverHelper.FindElementWithinElementWithWait(Driver, $@"./tbody/tr[{rowNum + 1}]", table);
            Console.WriteLine("Find element wait done.");
            Console.WriteLine("Row found.");
            return foundRow;
        }
        public  int GetHeaderColumnNumber(string colName, int tableNum=1)
        {
            var tables = GetTables();

            IWebElement table = tables.ElementAt(tableNum - 1);
            var colNameSplit = colName.Split('\u0020');

            string colNameJoined = String.Join(@""")] and text()[contains(., """, colNameSplit);

            int headerColNum = DriverHelper.FindElementsWithinElementWithWait(Driver, @$"./tbody/tr[@class=""GridHeader""]/td[text()[contains(.,""{colNameJoined}"")]]/preceding-sibling::td", table).Count + 1;
            Console.WriteLine("Find element wait done.");
            return headerColNum;
        }

      
    }
}
