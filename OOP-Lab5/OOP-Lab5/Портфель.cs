using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    struct Портфель
    {
        readonly string name;
        readonly int cost;
        public Портфель(string Name, int Cost)
        {
            name = Name;
            cost = Cost;
        }
        public void Info()
        {
            Console.WriteLine("Портфель: " + name + "\nСтоимостью $" + cost);
        }
    }
}
