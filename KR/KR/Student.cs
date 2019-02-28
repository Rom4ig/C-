using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    class Student : People, IGood, IBad
    {
        public int minus(int c)
        {
            int x;
            x = c--;
            return x;
        }

        public int plus(int c)
        {
            int x;
            x = c++;
            return x;
        }
    }
}
