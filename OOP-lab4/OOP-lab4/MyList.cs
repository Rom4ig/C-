using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4
{
    public class MyList<T> : List<T>
    {
        public static MyList<T> operator +(MyList<T> a, MyList<T> b)
        {
            MyList<T> c = new MyList<T>();
            foreach (T item in a) c.Add(item);
            foreach (T item in b) c.Add(item);
            return c;
        }
        public static MyList<T> operator --(MyList<T> a)
        {
            MyList<T> c = new MyList<T>();
            a.RemoveAt(0);
            foreach (T item in a) c.Add(item);
            return c;
        }

        public static Boolean operator ==(MyList<T> a, MyList<T> b)
        {
            if (a.Count != b.Count)
                return false;
            else
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (!a[i].Equals(b[i]))
                        return false;
                }
                return true;
            }
        }
        public static Boolean operator !=(MyList<T> a, MyList<T> b)
        {
            int i = 0;
            if (a.Count != b.Count)
                return true;
            else
            {
                for (i = 0; i < a.Count; i++)
                {
                    if (!a[i].Equals(b[i]))
                        return false;
                }
                return false;
            }
        }
        public static Boolean operator true(MyList<T> a)
        {
            if (a.Count > 0)
                return true;
            else return false;
        }
        public static Boolean operator false(MyList<T> a)
        {
            if (a.Count <= 0)
                return true;
            else return false;
        }

        public class Owner
        {
            public int Id;
            public string Name;
            public string organisation;
            public Owner(int Id, string Name, string organisation)
            {
                this.Id = Id;
                this.Name = Name;
                this.organisation = organisation;
            }
        }
        public Owner owner = new Owner(2000, "Roman", "BSTU");

        class Date
        {
            int day;
            int month;
            int year;
            public Date()
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            public override string ToString()
            {
                return $"{this.day}.{this.month}.{this.year}";
            }
        }
        public override string ToString()
        {
            return "Объект " + (this.GetType()).ToString() + " создан by" + this.owner.Name + " который обучается в " + this.owner.organisation;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
