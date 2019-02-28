using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    sealed class Printer
    {
        public string iAmPrinting(Name someobj)
        {
            Type a = someobj.GetType();
            return a.ToString();
        }

    }
}
