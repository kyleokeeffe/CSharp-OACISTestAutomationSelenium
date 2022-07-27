using OACISTestAutomationSelenium.Models.ExcelTableImportTemplates;
using OACISTestAutomationSelenium.Services.Enums;
using OACISTestAutomationSelenium.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Services
{
    internal class ExcelTableImportHelper
    {

        public static List<IImportObject> ConvertTableToObjects(DataTable table, ImportTemplates importTemplate)
        {
            List<IImportObject> importObjects = new List<IImportObject>();
            
            string[] modelPropertyNames;

            IImportObject importedObject = null;
            Type importedType = null;
            ConstructorInfo importTypeConstructorInfo = null;
            object importObjectInstance = null;
          
            switch (importTemplate)
            {
                case ImportTemplates.Client:
                    importedType = typeof(ImportedClient);
                    break;
                case ImportTemplates.Application:
                    importedType = typeof(ImportedApplication);
                    break;
                default:
                    break;
            }

            importTypeConstructorInfo = importedType.GetConstructor(new[] { typeof(DataRow) });

            for (int i = 1; i < table.AsEnumerable().Count(); i++)
            {
                importObjectInstance = importTypeConstructorInfo.Invoke(new object[] { table.AsEnumerable().ElementAt(i) });
                importObjects.Add((IImportObject)importObjectInstance);
            }
            return importObjects;
     
        }

    }
}

