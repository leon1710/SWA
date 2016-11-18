using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKW_Liste.ViewModel
{
    class TruckVM
    {
        private string source;
        private int duration;
        ObservableCollection<LoadVM> load = new ObservableCollection<LoadVM>();

        public TruckVM(string source, int duration, ObservableCollection<LoadVM> load)
        {
            this.source = source;
            this.duration = duration;
            this.load = load;
        }

        public string Source
        {
            get
            {
                return source;
            }

            set
            {
                source = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        internal ObservableCollection<LoadVM> Load
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
