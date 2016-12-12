using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCamp16.Models;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace CodeCamp16.ViewModel
{
    public class TruckVM : ViewModelBase
    {
        private TruckLoad truckload;

        private ObservableCollection<CargoVm> load = new ObservableCollection<CargoVm>();

        public ObservableCollection<CargoVm> Load
        {
            get { return load; }
            set { load = value; RaisePropertyChanged(); }
        }
      

        public String Source
        {
            get
            {
                return truckload.Source;
            }
            set { truckload.Source = value; RaisePropertyChanged(); }
        }

        public int TimeToReady
        {
            get
            {
                return truckload.TimeToReady;
            }
            set { truckload.TimeToReady = value; RaisePropertyChanged(); }
        }

        public TruckVM(string source, int timeToReady)
        {
            truckload = new TruckLoad(source, timeToReady);
        }

        public TruckVM(string source, int timeToReady, List<Cargo> load)
        {
            truckload = new TruckLoad(source, timeToReady, load);

            foreach (var item in load)
            {
                this.load.Add(new CargoVm(
                    item.ItemName,
                    item.Weight,
                    item.Amount));
            }

        }

        public override string ToString()
        {
            return Source + " " + TimeToReady;
        }

    }
}
