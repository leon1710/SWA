using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3_Test.ViewModels
{
    public class StockEntryVM
    {
        private StockEntry stockEntry;


        public StockEntryVM(StockEntry entry)
        {
            stockEntry = entry;
        }

        public String Name
        {
            get { return stockEntry.SoftwarePackage.Name; }
            set
            {
                stockEntry.SoftwarePackage.Name= value;
               // OnChange("Name");
            }
        }

        public double SalesPrice
        {
            get { return stockEntry.SoftwarePackage.SalesPrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
               // OnChange("SalesPrice");
            }
        }

        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }
            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
            }
        }

        public string Group
        {
            get { return stockEntry.}
        }

    }
}
