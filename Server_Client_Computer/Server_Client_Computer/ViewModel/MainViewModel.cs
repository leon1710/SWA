using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System;

namespace Server_Client_Computer.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        ObservableCollection<HardwareItemVM> startItems = new ObservableCollection<HardwareItemVM>();
        private HardwareItemVM mb = new HardwareItemVM("Motherboard", 0, 5);
        private HardwareItemVM proz = new HardwareItemVM("Prozessor", 0, 4);
        private HardwareItemVM fest = new HardwareItemVM("Festplatte", 0, 5);
        private HardwareItemVM speicher = new HardwareItemVM("Speicher", 0, 5);
        private HardwareItemVM dvd = new HardwareItemVM("DVD Ram", 0, 5);

        public MainViewModel()
        {
            Load();
        }
        private void Load()
        {
            StartItems.Add(Mb);
            StartItems.Add(Proz);
            StartItems.Add(Fest);
            StartItems.Add(Speicher);
            StartItems.Add(Dvd);
        }

        #region

        public ObservableCollection<HardwareItemVM> StartItems
        {
            get
            {
                return startItems;
            }

            set
            {
                startItems = value;
            }
        }

        public HardwareItemVM Mb
        {
            get
            {
                return mb;
            }

            set
            {
                mb = value;
            }
        }

        public HardwareItemVM Proz
        {
            get
            {
                return proz;
            }

            set
            {
                proz = value;
            }
        }

        public HardwareItemVM Fest
        {
            get
            {
                return fest;
            }

            set
            {
                fest = value;
            }
        }

        public HardwareItemVM Speicher
        {
            get
            {
                return speicher;
            }

            set
            {
                speicher = value;
            }
        }

        public HardwareItemVM Dvd
        {
            get
            {
                return dvd;
            }

            set
            {
                dvd = value;
            }
        }
        #endregion Properties
        
    }
}