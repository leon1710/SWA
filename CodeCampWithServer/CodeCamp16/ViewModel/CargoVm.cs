using CodeCamp16.Models;
using GalaSoft.MvvmLight;

namespace CodeCamp16.ViewModel
{
    public class CargoVm : ViewModelBase
    {

        private Cargo cargo;
        public string ItemName
        {
            get { return cargo.ItemName; }
            set { cargo.ItemName = value; RaisePropertyChanged("ItemName"); }
        }

        public int Weight
        {
            get { return cargo.Weight; }
            set { cargo.Weight = value; RaisePropertyChanged(); }
        }

        public int Amount
        {
            get { return cargo.Amount; }
            set { cargo.Amount = value; RaisePropertyChanged(); }
        }

        public CargoVm(string itemName, int weight, int amount)
        {
            cargo = new Cargo(itemName, weight, amount);
        }
    }
}