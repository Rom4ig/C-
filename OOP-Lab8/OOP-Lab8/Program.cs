using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab8
{
    interface IInterface<T>
    {
        void add(T obj);
        void del(T obj);
        void show();
    }

    public class CollectionType<T> : List<T>, IInterface<T> where T : IComparable
    {
        public void add(T obj)
        {
            this.Add(obj);
        }
        public void show()
        {
            Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            foreach (T l in this)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////\n");
        }
        public void del(T obj)
        {
            if (this.Count >= 5)
                this.Remove(obj);
            else throw new Exception("Добавьте по меньшей мере 5 объектов для удаления");
        }

        #region lab 4
        public static CollectionType<T> operator +(CollectionType<T> a, CollectionType<T> b)
        {
            CollectionType<T> c = new CollectionType<T>();
            foreach (T item in a) c.Add(item);
            foreach (T item in b) c.Add(item);
            return c;
        }

        public static CollectionType<T> operator --(CollectionType<T> a)
        {
            CollectionType<T> c = new CollectionType<T>();
            int n = 0;
            foreach (T item in a)
            {
                if (n > 0)
                    c.Add(item);
                n++;
            }
            return c;
        }
        #endregion
    }

    #region lab 5
    interface Idead
    {
        bool dead();
    }

    abstract class Name : Idead
    {
        public string name;
        public abstract bool dead();
        public Name(string a) { name = a; }
    }

    class Товар : Name, Idead, IComparable
    {
        bool Idead.dead()
        {
            if (this != null)
                return false;
            else
                return true;
        }
        public override bool dead()
        {
            throw new NotImplementedException();
        }
        public int CompareTo(object obj)
        {
            return 1;

        }
        public int weight;
        public int count;
        public override string ToString()
        {
            return (this.GetType() + " " + name + " Вес:" + weight + " Количество:" + count);
        }
        public Товар(string a, int b, int c) : base(a) {
            name = a;
            weight = b;
            count = c;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CollectionType<string> listofstring = new CollectionType<string>();
                listofstring.add("first");
                listofstring.add("second");
                listofstring.add("third");
                listofstring.add("fouth");
                listofstring.add("fifth");
                listofstring.del("fifth");
                listofstring.show();

                CollectionType<int> listofint = new CollectionType<int>();
                listofint.add(1);
                listofint.add(2);
                listofint.add(3);
                listofint.add(3);
                listofint.add(4);
                listofint.del(3);
                listofint.show();

                CollectionType<Товар> listofТовар = new CollectionType<Товар>();
                Товар a1 = new Товар("Табуретка", 400, 3);
                Товар a2 = new Товар("Стол", 5000, 1);
                listofТовар.add(a1);
                listofТовар.add(a2);
                listofТовар.add(a2);
                listofТовар.add(a1);
                listofТовар.add(a2);
                listofТовар.del(a2);
                listofТовар.show();
                CollectionType<int> newCol = listofint + listofint;
                newCol.show();
            }
            
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { Console.WriteLine("Программа завершена"); }
        }
    }
}
