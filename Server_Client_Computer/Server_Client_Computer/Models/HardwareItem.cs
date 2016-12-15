using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Computer.Models
{
    public class HardwareItem
    {
        public string Name { get; set; }
        public int Menge { get; set; }

        public int ProdMenge { get; set; }

        public HardwareItem(string name, int menge, int prodMenge)
        {
            this.Name = name;
            this.Menge = menge;
            this.ProdMenge = prodMenge; 
        }
    }
}
