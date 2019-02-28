using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    class Prepod : People, IGood
    {
        public int plus(int c)
        {
            int x;
            x = c+10;
            return x;
        }
    }
}
