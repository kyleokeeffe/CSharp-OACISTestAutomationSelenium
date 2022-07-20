using OACISTestAutomationSelenium.Models.ExcelTableImportTemplates;
using OACISTestAutomationSelenium.Services.Enums;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Services
{
    internal class ExcelTableFactory
    {


        public static DataTable ReadExcelIntoTable(string filePathAndName, ImportTemplates importTemplate)
           
        {
            // string filePath = @"C:\Users\OKeeffKy\SeleniumDrivers\NewAppInject.xlsx";
            DataTable table = new DataTable();
            FileInfo fileInfo = new FileInfo(filePathAndName);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            DataColumn col;
            DataRow row;

            Console.WriteLine("Reading Excel sheet into DataTable...");
            using (var package = new ExcelPackage(fileInfo))
            {
                try
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    var dims = worksheet.Dimension;
                    var rowQuant = dims.End.Row;
                    var colQuant = dims.End.Column;
                    ; var headerRow = worksheet.Cells[1, 1, 1, colQuant].AsEnumerable();

                    foreach (var cell in headerRow)//getting header column names 
                    {
                        col = new DataColumn();
                        col.DataType = typeof(string);
                        col.ColumnName = cell.Value.ToString();
                        //col.Caption = "name";
                        table.Columns.Add(col);
                    }

                    for (int iRow = 1; iRow <= rowQuant; iRow++)//maybe start shoudl be 2 
                    {
                        row = table.NewRow();
                        for (int iCol = 1; iCol <= table.Columns.Count; iCol++)
                        {
                            row[iCol - 1] = worksheet.Cells[iRow, iCol].Value.ToString();
                          
                        }
                        table.Rows.Add(row);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }

            /*foreach (var thisRow in tableInjected.AsEnumerable())
              {
                  foreach (var cell in thisRow.ItemArray)
                  {
                      Console.WriteLine($"thing is {cell.ToString()}");
                  }
              }
            */
            Console.WriteLine("Excel sheet successfully read.");
            
            CheckImportedFormat(table, importTemplate);
            return table;
        }

        public static bool CheckImportedFormat(DataTable importedTable, ImportTemplates importTemplate)
        {
            Console.WriteLine($"Checking format of imported table against {importTemplate} template...");
            string[] modelPropertyNames;

            var headerRow = importedTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName.ToUpper()).ToArray();

            bool allColumnsPresent = false;
            Dictionary<string, bool> allColumnChecks = new Dictionary<string, bool>();


            switch (importTemplate)
            {
                case ImportTemplates.Client:
                    modelPropertyNames = new ImportedClient().GetType().GetProperties().Cast<PropertyInfo>().Select(x => x.Name.ToUpper()).ToArray();

                    break;
                case ImportTemplates.Application:
                    modelPropertyNames = new ImportedApplication().GetType().GetProperties().Cast<PropertyInfo>().Select(x => x.Name.ToUpper()).ToArray();
                    break;
                default:
                    modelPropertyNames = null;
                    break;
            }

            foreach (var propertyName in modelPropertyNames)//Check each template property for a match 
                allColumnChecks.Add(propertyName, headerRow.Contains(propertyName));

            if (allColumnChecks.Values.ToArray().Contains(false))
            {

                Console.WriteLine($"Imported excel table does not match {importTemplate} template.\n" +
                    $"Please ensure the imported spreadsheet contains the following columns:");
                foreach (var incorrectColumnName in allColumnChecks.Where(x => x.Value.Equals(false)).Select(x => x.Key))
                {
                    Console.WriteLine($"{incorrectColumnName}");
                }

                throw new Exception($"Imported excel table does not match {importTemplate.ToString()}");
            }
            else
                Console.WriteLine("Table import matches specified template.");
            return allColumnsPresent;
        }

    }
}
