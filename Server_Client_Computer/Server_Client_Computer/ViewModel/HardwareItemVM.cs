using Server_Client_Computer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Computer.ViewModel
{
    public class HardwareItemVM
    {
        private HardwareItem item;
        

        public HardwareItemVM(string name, int menge, int prodMenge)
        {
            item = new HardwareItem(name, menge, prodMenge);
        }

        public int Menge
        {
            get { return item.Menge; }
            set { item.Menge = value; }
        }


        public string Name
        {
            get { return item.Name; }
            set { item.Name = value; }
        }

        public int ProdMenge
        {
            get { return item.ProdMenge; }
            set { item.ProdMenge = value; }
        }
        public override string ToString()
        {
            return item.Name;
        }

    }
}
