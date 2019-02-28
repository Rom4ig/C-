using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Подарок : List<object>
    {
        public Подарок(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                this.Add(list[i]);
            }
        }
    }
    class PController : Подарок
    {
        public PController(Подарок pd)
        {
            for (int i = 0; i < pd.Count; i++)
            {
                this.Add(pd[i]);
            }
        }
        public int Cost()
        {
            int cost = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.ElementAt(i) is Товар)
                {
                    Товар ex = new Товар("");
                    ex = (Товар)this.ElementAt(i);
                    cost += ex.cost;
                }
            }
            return cost;
        }
        public void smass()
        {
            int mass = Int32.MaxValue;
            bool mass_test = false;
            string info = "";
            for (int i = 0; i < this.Count; i++)
            {
                if (this.ElementAt(i) is Товар)
                {
                    Товар ex = new Товар("");
                    ex = (Товар)this.ElementAt(i);
                    if (ex.weight < mass) { mass = ex.weight; mass_test = true; info = ex.ToString(); }
                }
            }
            if (mass_test) Console.WriteLine("Самая маленькая масса: " + info);
        }
        public void sort()
        {
            Товар ex = new Товар("");
            Товар ex1 = new Товар("");
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (this.ElementAt(i) is Товар)
                {
                    ex = (Товар)this.ElementAt(i);
                    ex1 = (Товар)this.ElementAt(i + 1);
                    if (ex.weight < ex1.weight)
                    {
                        sorts();
                    }
                }
            }
            void sorts()
            {
                this.Remove(ex);
                this.Remove(ex1);
                this.Add(ex1);
                this.Add(ex);
                sort();
            }
        }

        public void print()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < this.Count; i++)
            {
                if (this.ElementAt(i) is Товар)
                {
                    Товар ex = new Товар("");
                    ex = (Товар)this.ElementAt(i);
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
