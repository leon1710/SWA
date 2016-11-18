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
        private TruckVM selectedWaitingTruck;
        private RelayCommand deleteBtnClicked;
        private RelayCommand startGenBtnClicked;
        private RelayCommand shiftTruckToReady;
        private RelayCommand stopGenBtnClicked;

        public MainViewModel()
        {
            LoadData();
            DeleteBtnClicked = new RelayCommand(ClearAllEntries);
            StartGenBtnClicked = new RelayCommand(CreateEntries);
            shiftTruckToReady = new RelayCommand(ShiftToReadyTrucks);
        }

        private void ShiftToReadyTrucks()
        {
            ReadyTrucks.Add(SelectedWaitingTruck);
        }

        

        private void CreateEntries()
        {
            WaitingTrucks.Add(new TruckVM("Salzburg", 2));
            WaitingTrucks[0].Load.Add(new LoadVM("Paket1", 3, 3));
            WaitingTrucks.Add(new TruckVM("Wien", 5));
            WaitingTrucks[1].Load.Add(new LoadVM("Paket2", 2, 5));
            WaitingTrucks.Add(new TruckVM("Br�ssel", 3));
            WaitingTrucks[2].Load.Add(new LoadVM("Paket3", 2, 5));
        }

        /*
        private bool CheckIfBtnEnabled()
        {
            return WaitingTrucks.Count > 1;
        }
        */
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



        public ObservableCollection<TruckVM> WaitingTrucks
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

        public ObservableCollection<TruckVM> ReadyTrucks
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

        public TruckVM SelectedReadyTruck
        {
            get
            {
                return selectedReadyTruck;
            }

            set
            {
                selectedReadyTruck = value;
                RaisePropertyChanged();
            }
        }

        public TruckVM SelectedWaitingTruck
        {
            get
            {
                return selectedWaitingTruck;
            }

            set
            {
                selectedWaitingTruck = value;
            }
        }

        public ObservableCollection<LoadVM> Load
        {
            get
            {
                return load;
            }

            set
            {
                load = value;
            }
        }
    }
}