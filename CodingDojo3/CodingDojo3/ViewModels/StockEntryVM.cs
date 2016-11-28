using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModels
{
    class StockEntryVM : BaseViewModel
    {
        private StockEntry stockEntry;

        private double salespriceInEuro;

        public String Name
        {
            get { return stockEntry.SoftwarePackage.Name; }
            set
            {
                stockEntry.SoftwarePackage.Name = value;
                OnChange("Name");
            }
        }

        public double SalesPrice
        {
            get { return stockEntry.SoftwarePackage.SalesPrice; }
            set
            {
                stockEntry.SoftwarePackage.SalesPrice = value;
                OnChange("SalesPrice");
            }
        }
        public StockEntryVM(StockEntry entry)
        {
            stockEntry = entry;
        }


    }
}
