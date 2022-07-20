using OACISTestAutomationSelenium.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Models.ExcelTableImportTemplates
{
    internal class ImportedClient:IImportObject
    {
        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }

        public string ClientDob { get; set; }

        public ImportedClient()
        {

        }
        public ImportedClient(DataRow tableRow)
        {
     

            this.ClientLastName = tableRow["ClientLastName"].ToString();
            this.ClientFirstName = tableRow["ClientFirstName"].ToString();
            this.ClientDob = tableRow["ClientDob"].ToString();
     
        }

        public override string ToString()
        {
            return $"\nNew client created and saved:\n\tLast Name: {this.ClientLastName}\n\tFirst Name: {this.ClientFirstName}\n\tDate of Birth: {this.ClientDob}\n";
        }




    }
}
