using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
// Продукт, Кондитерское изделие, Товар, Цветы, Торт, Часы, Конфеты;  
namespace OOP_Lab5
{ 
    interface IInterface
    {
        string Weight();
    }
    interface IInterface2
    {
        string Weight();
    }
    class Program
    {
        static int dividenull(int x, int y)
        {
            if (y == 0)
            {
                Exception a = new Exception();
                a.HelpLink = "google.com";
                a.Data.Add("Время: ", DateTime.Now);
                throw a;
            };
            return x / y;//0000000000
        }
        static int My_Throw(int x, int y)
        {
            if (y == -11)
            {
                except1 a = new except1();
                a.HelpLink = "vk.com";
                a.Data.Add("Date: ", DateTime.Now);
                throw a;
            };
            return x+y;
        }
            static void Main(string[] args)
        {
            try
            {
                Товар qwerty = new Товар("Абвгд", 1900, 30);
                Console.WriteLine(((IInterface)qwerty).Weight());
                Console.WriteLine(((IInterface2)qwerty).Weight());
                Конфеты sweet = new Конфеты("Комунарка", 540, 3, 2, 75, "Черёмуха", 1);
                Торт cake = new Торт("Чараўнiца", 5540, 1, 2, 75, "Наполеон", 10);
                Часы clocks = new Часы("Луч", 130, 10, Часы.Types.cvartz, 100);
                Часы clocks2 = new Часы("GearWatch", 130, 10, Часы.Types.meh, 100);
                Цветы flowers = new Цветы("Розы", 480, 33, 50, "Красные", 2);
                Console.WriteLine(sweet.ToString());
                Console.WriteLine(cake.ToString());
                Console.WriteLine(clocks.ToString());
                Console.WriteLine(clocks2.ToString());
                Console.WriteLine(flowers.ToString());
                Console.WriteLine(cake is Продукт);
                Console.WriteLine(clocks is int);
                Console.WriteLine(flowers as Товар);
                Printer pr = new Printer();
                Console.WriteLine(pr.iAmPrinting(cake));
                pereopr x = new pereopr();
                Console.WriteLine(x);
                Портфель myBag = new Портфель("Columbia", 35);
                myBag.Info();
                Подарок p1 = new Подарок(sweet, cake, clocks, flowers);
                PController pc1 = new PController(p1);
                Console.WriteLine("Общая стоимость подарка: $" + pc1.Cost());
                pc1.smass();
                pc1.sort();
                pc1.print();                
                //dividenull(7, 0);//ERROR
                //My_Throw(7, -11);
                test.t = true;
                test.assert();

            }

            catch (except1 ex) when (ex.HelpLink==null){ Console.WriteLine("Не задана вспомогательная ссылка"); }
            catch (except1 ex) { Console.WriteLine(ex.HelpLink); }
            catch (Exception ex)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine(ex.TargetSite + "\n");
                Console.WriteLine(ex.StackTrace + "\n");
                Console.WriteLine(ex.HelpLink + "\n");
                if (ex.Data != null)
                {
                    Console.WriteLine("Сведения: \n");
                    foreach (DictionaryEntry d in ex.Data)
                        Console.WriteLine(" {0} {1}", d.Key, d.Value);
                    Console.WriteLine("------------------------------------------");
                }
            }

            finally { if (!test.t) Console.WriteLine("Программа завершена с ошибкой"); }
        }
    }
}