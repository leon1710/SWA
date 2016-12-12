using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo3.ViewModels
{
    public class StockEntryVM : BaseVM
    {
        private StockEntry stockEntry;

        public StockEntryVM()
        {
            
            this.stockEntry = new StockEntry();
            this.stockEntry.SoftwarePackage = new Software("");
            this.stockEntry.SoftwarePackage.SalesPrice = 0;
            this.stockEntry.SoftwarePackage.PurchasePrice = 0;
            this.stockEntry.SoftwarePackage.Category = new Group();
            this.stockEntry.SoftwarePackage.Name = "";
            this.stockEntry.SoftwarePackage.Category.Name = "";
            //Filtered.Add(this.stockEntry);
            // MainVM.CreateNewEntry(new StockEntryVM(this.stockEntry));
            /*
            this.stockEntry.SoftwarePackage = new Software("");
            this.stockEntry.SoftwarePackage.Category = new Group();
            this.stockEntry.SoftwarePackage.Name = "Add new Software";
            */
        }


        public StockEntryVM(StockEntry entry)
        {
            stockEntry = entry;
        }

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

        public double PurchasePrice
        {
            get { return stockEntry.SoftwarePackage.PurchasePrice; }
            set
            {
                stockEntry.SoftwarePackage.PurchasePrice = value;
                OnChange("PurchasePrice");
            }
        }
        
        public string Group
        {
            get { return stockEntry.SoftwarePackage.Category.Name; }
            set
            {
                stockEntry.SoftwarePackage.Category.Name = value;
                OnChange("Group");
            }
        }

        public int OnStock
        {
            get { return stockEntry.Amount; }
            set { stockEntry.Amount = value; }
        }
    }
}
