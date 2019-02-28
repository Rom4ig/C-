using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop_lab9
{
    public delegate void myDel();
    public delegate void D(int i);
    delegate int Summator(int b);
    class Program
    {
        private static void Hello(int i) { Console.WriteLine(i + 1); }//Объявление делегатов
        private static void Hello1(int i) { Console.WriteLine(i + 2); }
        private static void SayHello()

        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            D del; //Переменная делегата
            del = Hello; //Присваиваем это переменной адрес метода
            del += Hello1;
            del.Invoke(4); //Вызываем метод
            myDel d = () => { Console.WriteLine("This is delegate"); }; //упрощенная запись анонимных методов
            d();
            myDel del2 = () => SayHello();
            del2();
            int result = 0;
            Summator someDelegat = delegate (int number) //представляет собой безымянный кодовый блок, передаваемый конструктору делегата
            {
                for (int i = 0; i <= number; i++)
                    result += i; //захват переменной
                return result;
            };
            Console.WriteLine(someDelegat.Invoke(10));
            Programmer programmer = new Programmer();

            int[] Arr1 = { 1, 2, 3, 4, 5 };
            int[] Arr2 = { 3, 6, 2, 8, 43 };

            Examplelist list1 = new Examplelist(Arr1);
            Examplelist list2 = new Examplelist(Arr2);

            list1.show();
            list2.show();

            programmer.Del += list1.delfirst;
            programmer.Del += list2.dellast;
            programmer.Mutate += list2.reverse;
            programmer.Mutate += list1.reverse;
            programmer.Mutate -= list1.reverse;

            programmer.eventDel();
            programmer.eventMutate();
            list1.show();
            list2.show();

            Func<string, string> func;

            string mystr = "one  two  three . four";
            Console.WriteLine(mystr);

            func = StringProc.RemDot;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            func = StringProc.RemSp;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            func = StringProc.ToUpp;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            func = StringProc.AddDot;
            mystr = func(mystr);
            Console.WriteLine(mystr);

            Console.WriteLine();

            Action<string> action = StringProc.show;
            action(mystr);
        }



    }
}
