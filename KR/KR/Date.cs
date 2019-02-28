using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    class Time
    {
        int hh {get; set;}
        int mm { get; set; }
        int ss { get; set; }
        enum time { PM, AM};
        public Time(int v1, int v2, int v3)
        {
            this.hh = v1;
            this.mm = v2;
            this.ss = v3;
        }

        public virtual string ToString()
        {
            return this.hh + " часов " + this.mm +  " минут " + this.ss + " секунд ";
        }
    }
}
