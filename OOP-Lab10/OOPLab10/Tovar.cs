using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab10
{
    class Tovar : IComparable<Tovar>
    {
        public string Name;
        public float Weight;
        public float Cost;
        public int CompareTo(Tovar obj)
        {
            if (this.Cost > obj.Cost) return 1;
            if (this.Cost < obj.Cost) return -1;
            else return 0;
        }

        public Tovar(string name, float weight, float cost)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }
        public override string ToString()
        {
            return Name + " " + Weight + " " + Cost;
        }

    }
}
