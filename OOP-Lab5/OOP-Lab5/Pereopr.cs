using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    public class pereopr : Object
    {
        public override string ToString()
        {
            return "a";
        }

        public override int GetHashCode()
        {
            return 2;
        }

        public override bool Equals(object obj)
        {
            if (obj != null) return true;
            else return false;
        }
    }
}
