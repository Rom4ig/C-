using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    abstract class Name : IInterface, IInterface2
    {
        public string name;
        public abstract string Weight();
        public Name(string a)
        {
            name = a;
        }
    }
}
