using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp16.Models
{
    public class Cargo
    {
        #region PROPERTIES
        public String ItemName { get; set; }
        public int Weight { get; set; }
        public int Amount { get; set; }

        #endregion

        public Cargo(string itemName, int weight, int amount)
        {
            ItemName = itemName;
            Weight = weight;
            Amount = amount;
        }

    }
}
