using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OACISTestAutomationSelenium.Models
{
    public class LocatorRepoItem
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public LocatorRepoItem()
        {


        }
        public LocatorRepoItem(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
