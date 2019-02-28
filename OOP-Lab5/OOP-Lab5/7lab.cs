using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP_Lab5
{
    class except1 : Exception
    {
        public except1()
        {
        }
        public except1(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }

    class except2 : except1
    {
        public except2(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }

    public static class test
    {
        public static bool t;
        public static void assert()
        {
            Debug.Assert(t == false/*true*/, "Программа завершена без ошибок");
        }
    }
}