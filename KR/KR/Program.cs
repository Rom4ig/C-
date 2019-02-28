using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    interface IGood
    {
        int plus(int c);
    }
    interface IBad
    {
        int minus(int c);
    }
    class Program
    {
        static void Main(string[] args)
        { // ================ 1 =======================
            Console.WriteLine((int)char.MaxValue);
            Convert.ToInt32(Console.ReadLine());
            // ================ 1 =======================

            // ================ 2 =======================
            Time time1 = new Time(12, 30, 20);
            Time time2 = new Time(9, 22, 11);
            Console.WriteLine(time1.ToString());
            Console.WriteLine(time2.ToString());
            // ================ 2 =======================

            // ================ 1 =======================
            int[,,] a = new int[2,2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        a[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            // ================ 1 =======================
            Prepod prepod = new Prepod();
            Console.WriteLine(prepod.plus(10)); //+10
            Student student = new Student();
            Student student1 = new Student();
            Console.WriteLine(student.plus(9)); //++
            Console.WriteLine(student1.minus(10)); // --
        }
    }
}
