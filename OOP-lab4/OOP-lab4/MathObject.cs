using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4
{
    public static class MathObject
    {
        public static int MinElement(MyList<int> a)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static int MaxElement(MyList<int> a)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static void Obnull(MyList<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                a[i] = 0;
            }
        }
        public static int LengthOfString(this string str)
        {
            int i = 0;
            foreach (char m in str)
            {
                i++;
            }
            return i;
        }
        public static void Last(this MyList<int> a)
        {      
                Console.WriteLine(a[a.Count - 1]);   
        }
    }
}
