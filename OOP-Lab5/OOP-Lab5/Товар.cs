using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Товар : Name, IInterface, IInterface2
    {

        string IInterface.Weight()
        {
            if (this.weight >= 1000)
                return "Тяжеловато";
            else return "Нормально";
        }
        string IInterface2.Weight()
        {
            if (this.weight >= 2000)
                return "Тяжеловато";
            else return "Нормально";
        }
        public int weight;
        public int count;
        public int cost;
        public override string ToString()
        {
            return (this.GetType() + " " + "Вес:" + weight + " Количество:" + count);
        }

        public override string Weight()
        {
            throw new NotImplementedException();
        }

        public Товар(string a, int b, int c) : base(a)
        {
            name = a;
            weight = b;
            count = c;
        }
        public Товар(string a) : base(a) { }
    }
}
