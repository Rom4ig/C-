using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_lab9
{
    class StringProc
    {
        public static string RemDot(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) == '.')
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }

        public static string RemSp(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str.ElementAt(i) == ' ' && str.ElementAt(i - 1) == ' ')
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }

        public static string ToUpp(string str)
        {
            str = str.ToUpper();
            return str;
        }

        public static string AddDot(string str)
        {
            str = str.Insert(str.Length, ".");
            return str;
        }

        public static void show(string str)
        {
            Console.WriteLine(str);
        }
    }
}
