using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_App.Model
{
    public class Truck
    {
        private string source;
        private int duration;
        private ObservableCollection<Load> Load { get; set; }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }


        public string Source
        {
            get { return source; }
            set { source = value; }
        }

    }
}
