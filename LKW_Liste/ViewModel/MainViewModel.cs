using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System;

namespace LKW_Liste.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<TruckVM> waitingTrucks = new ObservableCollection<TruckVM>();
        private ObservableCollection<TruckVM> readyTrucks = new ObservableCollection<TruckVM>();
        private ObservableCollection<LoadVM> load = new ObservableCollection<LoadVM>();

        private TruckVM selectedReadyTruck;
        private RelayCommand deleteBtnClicked;
        private RelayCommand startGenBtnClicked;
        private RelayCommand shiftTruckToReady;
        private RelayCommand stopGenBtnClicked;

        public MainViewModel()
        {
            LoadData();
            DeleteBtnClicked = new RelayCommand(ClearAllEntries);
            StartGenBtnClicked = new RelayCommand(CreateEntries);
        }

        private void CreateEntries()
        {
            waitingTrucks.Add(new TruckVM("Salzburg", 2, load));
            waitingTrucks.Add(new TruckVM("Wien", 5, load));
            waitingTrucks.Add(new TruckVM("Brüssel", 3, load));
        }

        private void LoadData()
        {
            // waitingTrucks.Add(new TruckVM("Salzburg", 2, )
        }

        private void ClearAllEntries()
        {
            readyTrucks.Clear();
            waitingTrucks.Clear();
        }

        public RelayCommand StopGenBtnClicked
        {
            get { return stopGenBtnClicked; }
            set { stopGenBtnClicked = value; }
        }


        public RelayCommand ShiftTruckToReady
        {
            get { return shiftTruckToReady; }
            set { shiftTruckToReady = value; }
        }

        public RelayCommand StartGenBtnClicked
        {
            get { return startGenBtnClicked; }
            set { startGenBtnClicked = value; }
        }



        internal ObservableCollection<TruckVM> WaitingTrucks
        {
            get
            {
                return waitingTrucks;
            }

            set
            {
                waitingTrucks = value;
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

        internal ObservableCollection<TruckVM> ReadyTrucks
        {
            get
            {
                return readyTrucks;
            }

            set
            {
                readyTrucks = value;
            }
        }

        internal TruckVM SelectedReadyTruck
        {
            get
            {
                return selectedReadyTruck;
            }

            set
            {
                selectedReadyTruck = value;
            }
        }

        
    }
}