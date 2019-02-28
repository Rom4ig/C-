using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_lab9
{
    class Programmer
    {
       
        public delegate void ListActivity();

        public event ListActivity Del;
        public event ListActivity Mutate;

        public void eventDel()
        {
            if (Del!=null)
                Del();
        }

        public void eventMutate()
        {
            if (Mutate!=null)
                Mutate();
        }
    }
    class Examplelist : List<int>
    {
        public void delfirst()
        {
            if (this.Count>0)
                this.RemoveAt(0);
        }

        public void dellast()
        {
            if (this.Count > 0)
                this.RemoveAt(this.Count-1);
        }

        public void reverse()
        {
            this.Reverse();
        }

        public void show()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            int n=0;
            if (this.Count > 0)
                foreach (int a in this)
                    Console.WriteLine($"{++n}) {a}");
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }
        public Examplelist(int[] arr) { foreach (int a in arr) this.Add(a); }
    }
}
