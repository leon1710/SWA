using CodingDojo4DataLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3_Test.ViewModels
{
    public class MainVM
    {
        private List<StockEntry> stock;
        private ObservableCollection<StockEntryVM> items = new ObservableCollection<StockEntryVM>();

        public ObservableCollection<StockEntryVM> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public MainVM()
        {
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;

            foreach (var item in manager.CurrentStock.OnStock)
            {
                //filling ViewModel datastructure
                Items.Add(new StockEntryVM(item));
            }
        }

    }
}
