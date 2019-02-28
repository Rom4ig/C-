using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle[] array = new Circle[]
 {
            new Circle(11, 10, -5),
            new Circle(13, 12, 14),
            new Circle(12, 11, 17),
            new Circle(11, 11, 14),
            new Circle(11, 1, 14),
            new Circle(14),
            new Circle(),

 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, array[i].ToString());
                Console.WriteLine("Hachcode {0} - {1}\n\n", i + 1, array[i].GetHashCode());
            }
            Console.WriteLine(array[1].GetType());
            Console.WriteLine(array[1].Equals(array[0]));
            Circle.DisplayCount();
            double max = System.Double.MinValue;
            double min = System.Double.MaxValue;
            int i_max = 0;
            int i_min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Square() > max ) { max = array[i].Square(); i_max = i; }
                if (array[i].Square() < min) { min = array[i].Square(); i_min = i; }
            }
            Console.WriteLine("Наибольшая площадь у окружности №{0} и S={1}", i_max + 1, max);
            Console.WriteLine("Наименьшая площадь у окружности №{0} и S={1}", i_min + 1, min);
             max = System.Double.MinValue;
             min = System.Double.MaxValue;
             i_max = 0;
             i_min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].line() > max) { max = array[i].line(); i_max = i; }
                if (array[i].line() < min) { min = array[i].line(); i_min = i; }
            }
            Console.WriteLine("Наибольшая длина окружности №{0} и L={1}", i_max + 1, max);
            Console.WriteLine("Наименьшая длина окружности №{0} и L={1}", i_min + 1, min);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (((array[i].Oy - array[j].Oy) / (array[k].Oy - array[j].Oy)) == ((array[i].Ox - array[j].Ox) / (array[k].Ox - array[j].Ox))
                            ||(array[i].Oy==array[j].Oy&& array[j].Oy == array[k].Oy)
                            || (array[i].Ox == array[j].Ox && array[j].Ox == array[k].Ox))
                        {
                            Console.WriteLine("\nОкружности  {0} {1} {2} лежат на одной прямой", i + 1, j + 1, k + 1);
                        }
                    }
                }
            }
        }
    }
}
