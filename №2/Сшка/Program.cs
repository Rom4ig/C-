using System;
using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace lab.rab._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определите переменные всех возможных примитивных типов
            //С# и проинициализируйте их. 
            bool flag = true;
            byte bit = 1;
            sbyte bit1 = -101;
            short sh = 1; 
            ushort ush = 10; 
            int a = 20; 
            uint b = 30; 
            long c = -40; 
            ulong d = 50; 
            decimal e = 60.111m; 
            float fl = 30.5f; 
            double doub = 40.99; 
            char ch = 'A';
            string str = "string"; 
            object ob = 100; 



            //Выполните 5 операций явного 



            a = (int)doub; //double to int.
            bit = (byte)a; //int to byte
            doub = (double)10f; //float to double
            a = (int)c; //long to int
            bit = (byte)d; //long to byte


                           //и 5 неявного приведения.



            c = a; // long to int
            doub = 1f;// double to float 
            a = bit;//int to byte
            sh = bit; //short to byte
            doub = a; //double to int



            //Выполните упаковку и распаковку значимых типов.
            object o = a; // упаковки (boxing) — помещение копии типа значений (ссылки) в класс-обёртку, экземпляр которого сохраняется в куче.
            byte p = (byte)(int)o; // распаковки (unboxing) — извлечение из упаковки копии типа значения и помещение её в стек.
            Console.WriteLine("============================================================");
            // Продемонстрируйте работу с неявно типизированной переменной.
            Console.WriteLine("Демонстрация работы с неявно типизированной переменной:");
            var c1 = 2.8m;
            var c2 = 3;
            var c3 = true;
            var c4 = c1 + c2;
            Console.WriteLine("Тип неявно типизированной переменной c1:" + c1.GetType());
            Console.WriteLine("Тип неявно типизированной переменной c2:" + c2.GetType());
            Console.WriteLine("Тип неявно типизированной переменной c3:" + c3.GetType());
            Console.WriteLine("Тип неявно типизированной переменной c4:" + c4.GetType());



            //Продемонстрируйте пример работы с Nullable переменной. 



            int? d1 = null;
            Nullable<int> d2 = 3;
            int d3 = d1 ?? 5;// возвращает левый операнд, если этот операнд не равен null
            int? d4 = 2;
            int d5 = d4 ?? 1;


            Console.WriteLine("============================================================");

            //Объявите строковые литералы.Сравните их. 



            string str1 = "string_1";
            string str2 = "str_2";
            int result = String.Compare(str1, str2);
            if (result < 0)
            {
                Console.WriteLine("Строка str1 меньше строки str2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка str1 больше строки str2");
            }
            else
            {
                Console.WriteLine("Строки str1 и str2 равны");
            }

            String str3 = "Microsoft";
            String str4 = "Visual";
            String str5 = "Studio";

            //сцепление
            String str6 = String.Concat(str3, str4, str5);
            Console.WriteLine("Конкантенация строк: " + str6);

            //копирование
            String str7 = String.Copy(str6);//копирует одну строку в другую
            Console.WriteLine("Cтроку str6 скопировали в str7: " + str7);

            //Выделение подстроки
            String str8 = str6.Substring(0, 10);
            Console.WriteLine("Выделение подстроки: " + str8);

            //Разделение строки на слова
            string text = "This is a text. New string";
            char[] delims = ".,;:!?\n\xD\xA\" ".ToCharArray();
            string[] words1 = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words1)
                Console.WriteLine(word);

            //Вставки подстроки в заданную позицию
            String str9 = str3.Insert(5, "Mini");
            Console.WriteLine("Вставка подстроки в заданную позицию: " + str9);

            //Удаление заданной подстроки.
            String str10 = str6.Remove(9, 7);
            Console.WriteLine("Удаление: " + str10);

            //Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками 
            string str_4 = " ";
            string str_5 = null;
            // метод string.IsNullOrEmpty позволяет проверить является ли строка null или пустой.
            if (String.IsNullOrEmpty(str_4))
                Console.WriteLine("string 4 is null");
            else
                Console.WriteLine("string 4 is empty");

            if (String.IsNullOrEmpty(str_5))
                Console.WriteLine("string 5 is null");
            else
                Console.WriteLine("string 5 is empty");

            //Создайте строку на основе StringBuilder.
            //Удалите определенные позиции и добавьте новые символы в начало и конец строки. 
            //выделяет больше памяти, чем нужно в данный момент. У вас, как разработчика, есть возможность указать, сколько именно памяти должен выделить StringBuilder,
            //Length, показывающее длину строки, содержащуюся в объекте в данный момент
            //capacity, указывающее максимальную длину строки, которая может поместиться в выделенную для объекта память
            //Создайте строку на основе StringBuilder.
            StringBuilder str14 = new StringBuilder("crosoЧ232", 20);
            str14.Remove(5, 4);
            str14.Append("ft");
            str14.Insert(0, "Mi");
            Console.WriteLine("Манипуляции с StringBuilder: " + str14);



            Console.WriteLine("============================================================");
            object[]kek= { 1, "" };
            dynamic[] azaza = { 22, "qqq" };
            int[,] array1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 }, { 7, 8, 9 } };
            Console.WriteLine("Двумерный массив в виде матрицы: ");
            for (int i = 0; i < 4; i++) { 
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array1[i, j]+"\t");
                }
                Console.WriteLine();
            }
            //Строковый массив
            string[] Stringarray = { "Один", "Два", "Три", "Четыре", "Пять" };
                        Console.WriteLine("Строковый массив:");
                        foreach (string i in Stringarray)
                {
                    Console.WriteLine(i);
                }
            Console.WriteLine("Длина массива: " + Stringarray.Length);
            Console.WriteLine("Введите число от 1 до 5 для замены");
            int y = int.Parse(Console.ReadLine());
            if (y<1||y>5)
            { Console.WriteLine("Вы ввели неверное число"); }
            else
            Stringarray.SetValue("Замена", y - 1);
            foreach (string i in Stringarray)
            {
                Console.WriteLine(i);
            }

            //Ступечатый(не выровненный) массив
            double[][] DoubleArray = new double[3][];
            DoubleArray[0] = new double[2];
            DoubleArray[1] = new double[3];
            DoubleArray[2] = new double[4];
            int l = 2;
            Console.WriteLine("Ввод ступенчатого вещественного массива:\n");
            for (int f = 0; f < 3; f++)
            {
                for (int k = 0; k < l; k++)
                {
                    DoubleArray[f][k] = Convert.ToDouble(Console.ReadLine());
                }
                l++;
            }
            Console.WriteLine("Вывод ступенчатого массива\n");
            foreach (double[] i in DoubleArray)
            {
                foreach (double k in i)
                    Console.Write("{0}\t", k);
                Console.WriteLine();
            }
            //Создайте неявно типизированные переменные для хранения
            //массива и строки.
            var varArray = new[] { 1, 2, 3, 4, 5 };
            var varString = "Microsoft Visual Studio";
            Console.WriteLine("Тип переменной:" + varArray.GetType());
            Console.WriteLine("Тип переменной:" + varString.GetType());
            Console.WriteLine("============================================================");

            ////////////////////////////
            //КОРТЕЖИ
            (int age, string name, char, string, ulong) student = (18, "Roman", 'A', "Nevski", 21121998);
            Console.WriteLine(student);
            Console.WriteLine(student.age + " y.o " + student.name + " " + student.Item4);
            //int z1 = student.age;
            var (one, two, three, four, five) = student;
            (int age2, string name2, char, string, ulong) student2 = (19, "Roman", 'Z', "is love", 20115996);
            Console.WriteLine("Сравнение student и student2 - "+student.Equals(student2));

            Console.WriteLine("============================================================");

            //////
            (int, int, int, string) locfun(int[,] arr, string str23)
            {
                int min = Int32.MaxValue;
                int max = Int32.MinValue;
                int sum = 0;
                foreach (int i in arr)
                {
                    sum += i;
                    if (i < min)
                    {
                        min = i;
                    }
                }
                foreach (int i in arr)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                return (min, max, sum, str23.Substring(0, 1));
            }
            Console.WriteLine(locfun(array1, str1));

        }
    }
}