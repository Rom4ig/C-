using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    class User
    {
        public delegate void ListActivity();
        public event ListActivity move;
        public void eventmove()
        {
            if (move != null)
                move();
            else Console.WriteLine("Не двигали мышью");
        }       
    }
    class Window : User
    {
        public int size;
        public Window(int k)
        {
            this.size = k;
        }

        public void change()
        {
            this.size--;
        }
    }
}
