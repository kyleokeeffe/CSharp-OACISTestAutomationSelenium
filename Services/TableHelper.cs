using OACISTestAutomationSelenium.Functional;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Services
{
    public class TableHelper
    {
        public static IWebDriver Driver { get; set; }



        public TableHelper(IWebDriver driver)
        {
            Driver = driver;
        }

        public static IReadOnlyCollection<IWebElement> GetGridRows(IWebDriver driver)
        {
            return DriverHelper.FindElementsWithWait(driver, By.XPath("//tr[@class='GridHeader' or starts-with(@class,'GridRow')]"));

        }
        
        public static IReadOnlyCollection<IWebElement> GetTables(IWebDriver driver)
        {
           return DriverHelper.FindElementsWithWait(driver,@"//table[@class=""Grid""]");

        }

        public static IWebElement GetRow(IWebDriver driver,int tableNum, string colName, string rowValue)
        {
            Console.WriteLine("Finding row...");
            // pes.ReadPage();
          
            IWebElement table = GetTables(driver).ElementAt(tableNum - 1);
            int headerColNum = GetHeaderColumnNumber(colName, tableNum);

            var rowAtValue = DriverHelper.FindElementWithinElementWithWait(Driver,$@"./tbody/tr/td[{headerColNum}]/span[text()[contains(., ""{rowValue}"")]]/parent::td/parent::tr", table);
            Console.WriteLine("Find element wait done.");
            //var rowAtValue = table.FindElement(By.XPath($@"./tbody/tr/td[{headerColNum}]/span[text()[contains(., ""{rowValue}"")]]/parent::td/parent::tr"));
            Console.WriteLine("Row found.");
            return rowAtValue;
        }

        public void GetRowItems()
        {
            var firstRow = GetTables(Driver).ElementAt<IWebElement>(1);
            var firstRowItems = firstRow.FindElements(By.XPath("//td[@*]"));
            Console.WriteLine("Header Items:");
            foreach (var item in firstRowItems)
            {
                //item.FindElement(By.XPath("//span[@*]")).GetAttribute("i")
                Console.WriteLine(item.TagName);
            }

            //var thisThing = row.FindElement(By.TagName("td"));
            //Console.WriteLine(thisThing);
        }
        public static int GetHeaderColumnNumber(string colName, int tableNum =1)
        {
          
            IWebElement table = GetTables(Driver).ElementAt(tableNum - 1);
            var colNameSplit = colName.Split('\u0020');

            string colNameJoined = String.Join(@""")] and text()[contains(., """, colNameSplit);

            int headerColNum = DriverHelper.FindElementsWithinElementWithWait(Driver,@$"./tbody/tr[@class=""GridHeader""]/td[text()[contains(.,""{colNameJoined}"")]]/preceding-sibling::td", table).Count + 1;
            Console.WriteLine("Find element wait done.");
            return headerColNum;
        }
       
        public IWebElement FindRow(int tableNum, int rowNum)
        {
            Console.WriteLine("Finding row...");
            IWebElement table = GetTables(Driver).ElementAt(tableNum - 1);
            var foundRow = DriverHelper.FindElementWithinElementWithWait(Driver,$@"./tbody/tr[{rowNum + 1}]", table);
            Console.WriteLine("Find element wait done.");
            Console.WriteLine("Row found.");
            return foundRow;
        }
        public List<string> FindColCells(int tableNum, string colName)
        {

            List<string> allTargetCellValues = new List<string>();
            if (GetTables(Driver).Count > 0)
            {
                IWebElement table = GetTables(Driver).ElementAt(tableNum - 1);
                int headerColNum1 = GetHeaderColumnNumber(colName, tableNum);

                var allRows = DriverHelper.FindElementsWithinElementWithWait(Driver,$@"./tbody/tr", table);
                Console.WriteLine("Find element wait done.");
                for (int i = 1; i < allRows.Count; i++)
                {
                    var targetCellValue = DriverHelper.FindElementWithinElementWithWait(Driver,$@"./tbody/tr[{i + 1}]/td[{headerColNum1}]/span", table).GetAttribute("innerHTML");
                    Console.WriteLine("Find element wait done.");
                    allTargetCellValues.Add(targetCellValue);
                }
            }
            return allTargetCellValues;
        }
        public IWebElement FindCell(int tableNum, string colName1, string rowLookup, string colName2)
        {

            IWebElement table = GetTables(Driver).ElementAt(tableNum - 1);
            int headerColNum1 = GetHeaderColumnNumber(colName1, tableNum);
            int headerColNum2 = GetHeaderColumnNumber(colName2, tableNum);

            var targetCell = DriverHelper.FindElementWithinElementWithWait(Driver,$@"./tbody/tr/td[{headerColNum1}]/span[text()[contains(., ""{rowLookup}"")]]/parent::td/parent::tr/td[{headerColNum2}]/span", table);
            Console.WriteLine("Find element wait done.");
            return targetCell;
        }
        public IWebElement FindCell(int tableNum, string colName1, int rowNum)
        {

            IWebElement table = GetTables(Driver).ElementAt(tableNum - 1);
            int headerColNum1 = GetHeaderColumnNumber(colName1, tableNum);
            //int headerColNum2 = GetHeaderColumnNumber(tableNum, colName2);


            //need value of calumn at row num 

            var targetCell = DriverHelper.FindElementWithinElementWithWait(Driver,$@"./tbody/tr/td[{headerColNum1}]/span", table);///////////////////////////////////Mar 25 edit
            Console.WriteLine("Find element wait done.");
            return targetCell;
        }
        /*public IWebElement QueryTable(int tableNum, string colName, string colValue)
        {

           // var table = lib.currentPageDataTables[tableNum - 1];

            var getIndexQuery = table.AsEnumerable()
                .Select((row, index) => new { row, index })
                .Where(item => item.row.Field<string>(colName) == colValue)
                .Select(item => item.index).ToArray();

            var foundRow = lib.currentPageTables.ElementAt(0).FindElement(By.XPath($"./tbody/tr[{getIndexQuery[0] + 1}]"));
            return foundRow;
        }*/
        public DataTable CreateDataTable(IWebElement table)
        {
            DataColumn col;
            DataRow row;

            DataTable dt = new DataTable();
            var thisTableHeader = table.FindElements(By.XPath(@"./tbody/tr[@class=""GridHeader""]/td"));
            var thisTableRows = table.FindElements(By.XPath(@"./tbody/tr"));
            foreach (var column in thisTableHeader)
            {
                col = new DataColumn();
                col.DataType = typeof(string);
                col.ColumnName = column.GetAttribute("innerHTML");
                //col.Caption = "name";

                dt.Columns.Add(col);
            }

            for (int i = 1; i < thisTableRows.Count; i++)
            {
                row = dt.NewRow();
                for (int k = 1; k < dt.Columns.Count; k++)
                {
                    row[k] = thisTableRows.ElementAt(i).FindElement(By.XPath($"./td[{k}]/span")).GetAttribute("innerHTML");
                }
                dt.Rows.Add(row);
            }
            //var queryStatement = dt.AsEnumerable().Where<DataRow>(x => (string)x["Name"] == "Steve").Select(j => j["Age"]);

            foreach (var blah in dt.AsEnumerable())
            {
                foreach (var asdf in blah.ItemArray)
                {
                    Console.WriteLine($"thing is {asdf.ToString()}");
                }
            }
            return dt;
        }
        public string ReadRowCell(int tableNum, string colName1, string rowValue, string colName2)
        {
            var foundCell = FindCell(tableNum, colName1, rowValue, colName2);
            string foundCellValue = foundCell.GetAttribute("innerHTML");
            return foundCellValue;
        }
        public string ReadRowCell(int tableNum, string colName1, int rowNum)
        {
            var foundCell = FindCell(tableNum, colName1, rowNum);//left here at mar 25 
            string foundCellValue = foundCell.GetAttribute("innerHTML");
            return foundCellValue;
        }
        public List<string> ReadColAllRows(int tableNum, string colName)
        {
            var foundCellValues = FindColCells(tableNum, colName);
            return foundCellValues;
        }
        public DataTable ConvertWebTableToDataTable(int tableNum)
        {
            Console.WriteLine("Converting web table to DataTable...");
            var table = GetTables(Driver).ElementAt(tableNum - 1);
            DataColumn col;
            DataRow row;

            DataTable dt = new DataTable();
            var thisTableHeader = table.FindElements(By.XPath(@"./tbody/tr[@class=""GridHeader""]/td"));
            var thisTableRows = table.FindElements(By.XPath(@"./tbody/tr"));
            foreach (var column in thisTableHeader)
            {
                col = new DataColumn();
                col.DataType = typeof(string);
                //var colNameSplit = colName.Split('\u0020');

                // string colNameJoined = String.Join(@""")] and text()[contains(., """, colNameSplit);
                string colName = column.GetAttribute("innerHTML");
                if (colName.Contains('<') || colName.Contains('>'))
                {
                    int start = colName.IndexOf('<');
                    int end = colName.IndexOf('>') + 1;
                    int secondWordLength = colName.Length - end;
                    string firstWord = colName.Substring(0, start);
                    string secondWord = colName.Substring(end, secondWordLength);
                    col.ColumnName = $"{firstWord} {secondWord}";
                }
                else
                    col.ColumnName = colName;
                //col.Caption = "name";
                Console.WriteLine($"column header: {col.ColumnName}");
                dt.Columns.Add(col);
            }

            for (int i = 1; i < thisTableRows.Count; i++)
            {
                row = dt.NewRow();
                for (int k = 1; k < dt.Columns.Count; k++)
                {
                    var thisCell = thisTableRows.ElementAt(i).FindElement(By.XPath($"./td[{k}]/span")).GetAttribute("innerHTML");

                    row[k - 1] = thisCell;
                    Console.WriteLine($"{dt.Columns[k - 1].ColumnName}: {thisCell}");
                }
                dt.Rows.Add(row);
            }
            //var queryStatement = dt.AsEnumerable().Where<DataRow>(x => (string)x["Name"] == "Steve").Select(j => j["Age"]);


            // return dt;


            foreach (var blah in dt.AsEnumerable())
            {
                foreach (var asdf in blah.ItemArray)
                {
                    Console.WriteLine($"thing is {asdf.ToString()}");
                }
            }
            Console.WriteLine("Converting web table to DataTable done.");
            return dt;
        }
    }

}

