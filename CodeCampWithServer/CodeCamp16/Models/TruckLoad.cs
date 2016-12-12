using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp16.Models
{
    public class TruckLoad
    {  
        public String Source { get; set; }
        public int TimeToReady { get; set; }
        public List<Cargo> Load { get; set; }

        public TruckLoad(string source, int timeToReady, List<Cargo> load): this(source, timeToReady)
        {
            Load = load;
        }
        public TruckLoad(string source, int timeToReady)
        {
            Source = source;
            TimeToReady = timeToReady;
        }

    }
}
