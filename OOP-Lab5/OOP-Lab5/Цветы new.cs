using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    partial class Цветы : Товар
    {

        public Цветы(string a, int b, int c, int d, string e, int g) : base(a, b, c)
        {
            name = a;
            weight = b;
            count = c;
            length = d;
            color = e;
            cost = g * c;
        }
    }
}
