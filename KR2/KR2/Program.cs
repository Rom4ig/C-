using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task\n");

 
            SuperQueue<int> super = new SuperQueue<int>();
            super.Enqueue(1);
            super.Enqueue(2);
            super.Enqueue(3);
            //super.Enqueue(4);
            if (super.Count >= 4)
            {
                throw new Exception("Вы добавили 4-ый элемент в коллекцию");
            }
            foreach (int var in super)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("Second task\n");
            string[] array = { "б22", "в1", "а333", "г55555", "д4444" };
            var sortedElements = from arrElement in array.Distinct()
                                 orderby arrElement.Length
                                 select arrElement;
            IEnumerable<string> rezult1 = sortedElements.Take(3);
            Console.WriteLine("По длине");
            foreach (object var in rezult1)
            {                
                Console.WriteLine(var);
            }
            var result = from user in rezult1
                         orderby user
                         select user;
            Console.WriteLine("По алф");
            foreach (object var in result)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("Third task\n");
            User Roman = new User();
            Window window1 = new Window(10);
            Window window2 = new Window(7);
            Roman.move += window1.change;
            Roman.move += window1.change;
            Roman.move += window2.change;
            //Roman.eventmove();
            Console.WriteLine(window1.size);
            Console.WriteLine(window2.size);
        }
    }
}
