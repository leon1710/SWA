using CodingDojo4DataLib;
using GalaSoft.MvvmLight.Command;
using System;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dojo3.ViewModels
{
    public class MainVM : BaseVM
    {
        private List<StockEntry> stock;
        private string userFilter;
        private ObservableCollection<StockEntryVM> items = new ObservableCollection<StockEntryVM>();
        private ObservableCollection<StockEntryVM> filtered = new ObservableCollection<StockEntryVM>();
         

        private StockEntryVM selectedName;
        private RelayCommand filterBtnClicked;
        private RelayCommand deleteBtnClicked;
        private StockEntryVM newEntry;

        public MainVM()
        {
            SampleManager manager = new SampleManager();
            stock = manager.CurrentStock.OnStock;

           
            foreach (var item in manager.CurrentStock.OnStock)
            {
                //filling ViewModel datastructure
                Items.Add(new StockEntryVM(item));
                Filtered.Add(new StockEntryVM(item));
            }

            
            //Items.Add(new StockEntryVM());
            //Filtered.Add(new StockEntryVM());

            DeleteBtnClicked = new RelayCommand(ClearEntry);
            FilterBtnClicked = new RelayCommand(FilterEntries);
        }



        private void FilterEntries()
        {
            if(userFilter != null)
            {
                Filtered.Clear();
                foreach(StockEntryVM item in Items)
                {
                    if (item.Name.Contains(userFilter))
                    {
                        Filtered.Add(item);
                    }
                } 
            }
        }

        private void ClearEntry()
        {
            Items.Remove(SelectedName);
            Filtered.Remove(SelectedName);
            /*
            for (int i = 0; i < Filtered.Count; i++)
                if (Filtered[i] == SelectedName)
                    Filtered.RemoveAt(i);

            Items.Remove(SelectedName);
            */

            //int index = Items.IndexOf(SelectedName);
            //int index2 = Filtered.IndexOf(SelectedName);
            //Filtered.RemoveAt(Filtered.IndexOf(SelectedName));
        }

        public bool CreateNewEntry(StockEntryVM entry)
        {
            Filtered.Add(entry);
            return true;
        }

        public void AddItem()
        {
            StockEntry newEntry = new StockEntry();

        }

        public ObservableCollection<StockEntryVM> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
                OnChange("Items");
            }
        }


        public RelayCommand FilterBtnClicked
        {
            get
            {
                return filterBtnClicked;
            }

            set
            {
                filterBtnClicked = value;
            }
        }

        public RelayCommand DeleteBtnClicked
        {
            get
            {
                return deleteBtnClicked;
            }

            set
            {
                deleteBtnClicked = value;
            }
        }

        public ObservableCollection<StockEntryVM> Filtered
        {
            get
            {
                return filtered;
            }

            set
            {
                filtered = value;
                OnChange("Filtered");
            }
        }

        public StockEntryVM SelectedName
        {
            get
            {
                return selectedName;
            }

            set
            {
                selectedName = value;
            }
        }


        public string UserFilter
        {
            get
            {
                return userFilter;
            }

            set
            {
                userFilter = value;
            }
        }

        public StockEntryVM NewEntry
        {
            get
            {
                return newEntry;
            }

            set
            {
                newEntry = value;
            }
        }
    }
}
