using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> first = new MyList<int>() { 1, 2, 3 };
            if (first)
            {
                Console.WriteLine("Объект не пустой");
            }
            else
            {
                Console.WriteLine("Объект пустой");
            }
            MyList<int> second = new MyList<int>() { 4, 5, 6, 7, 8, 9 };
            MathObject.Last(second);
            MyList<int> concat = first + second;
            foreach (int item in concat)
                Console.Write(item + " ");
            Console.WriteLine("\n" + "-----------------");

            MyList<int> deletefirst = --first;
            foreach (int item in deletefirst)
                Console.Write(item + " ");
            Console.WriteLine("\n" + "-----------------");

            MyList<int> third = new MyList<int>() {2, 3};
            Console.WriteLine(first == third);
            Console.WriteLine("\n" + "-----------------");

            int last_index = second.Count-1;
            Console.WriteLine(second[last_index]);
            Console.WriteLine("\n" + "-----------------");

            MyList<int> fourth = new MyList<int>() { 4, 5, 6, 7, 8, 9 };
            fourth.RemoveAt(2);
            foreach (int item in fourth)
                Console.Write(item + " ");
            Console.WriteLine("\n" + "-----------------");

            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
            Console.WriteLine("Min эл-т second = {0}, max эл-т second = {1}", MathObject.MinElement(second), MathObject.MaxElement(second));
            MathObject.Obnull(second);
            foreach (int item in second)
                Console.Write(item + " ");



        }
    }
}
 