using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_App.Model
{
    public class Load
    {
        private string name;
        private float weight;
        private int amount;

        public Load(string name, float weight, int amount)
        {
            Name = name;
            Weight = weight;
            Amount = amount;
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }


        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
